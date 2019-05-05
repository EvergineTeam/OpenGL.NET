using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OpenGLGen
{
    public class GLParser
    {
        public string HeaderComment;
        public List<GLVersion> Versions = new List<GLVersion>();

        public static GLParser FromFile(string xmlFile)
        {
            XDocument file = XDocument.Load(xmlFile);
            GLParser spec = new GLParser();
            spec.HeaderComment = file.Root.Element("comment").Value;

            foreach (var feature in file.Root.Elements("feature"))
            {
                if (feature.Attribute("api").Value == "gl")
                {
                    var version = new GLVersion
                    {
                        Api = feature.Attribute("api").Value.ToUpper(),
                        Number = feature.Attribute("number").Value,
                    };

                    version.Name = version.Api + version.Number.Replace(".", "");

                    // Add all enums and commands from previus versions
                    int i = spec.Versions.Count - 1;
                    if (i >= 0)
                    {
                        var previousVersion = spec.Versions[i];

                        foreach (var g in previousVersion.Groups)
                        {
                            version.Groups.Add(g.Clone());
                        }

                        foreach (var c in previousVersion.Commands)
                        {
                            version.Commands.Add(c.Clone());
                        }
                    }

                    // Include all new enums and commands
                    foreach (var require in feature.Elements("require"))
                    {
                        foreach (var enumElem in require.Elements("enum"))
                        {
                            var enumName = enumElem.Attribute("name").Value;

                            // if enum doesn't exists
                            bool exists = version.Groups.Exists(g => g.Enums.Exists(e => e.Name == enumName));

                            if (!exists)
                            {
                                // Find group
                                string groupFound = FindGroupInXML(file, enumName);

                                // The group already exists
                                GlGroup glgroup = version.Groups.Find(g => g.Name == groupFound);

                                if (glgroup == null)
                                {
                                    glgroup = new GlGroup() { Name = groupFound };
                                    version.Groups.Add(glgroup);
                                }

                                // Create new Enum
                                var glEnum = new GLEnum();
                                glEnum.Initialize(file, enumName);
                                glgroup.Enums.Add(glEnum);
                            }
                        }

                        foreach (var commandElem in require.Elements("command"))
                        {
                            var glCommand = new GLCommand() { Name = commandElem.Attribute("name").Value };
                            if (version.Commands.Find(c => c.Name == glCommand.Name) == null)
                            {
                                // Create new command
                                glCommand.Initialize(commandElem.Document);
                                version.Commands.Add(glCommand);
                            }
                        }
                    }

                    // Add enum from commands
                    foreach (var commandElem in version.Commands)
                    {
                        // Return Type
                        if (commandElem.ReturnType.Type == "GLenum")
                        {
                            var selectedGroup = commandElem.ReturnType.Group;
                            bool groupExists = version.Groups.Exists(g => g.Name == selectedGroup);
                            if (!groupExists)
                            {
                                foreach (var group in file.Root.Element("groups").Elements("group"))
                                {
                                    string groupName = group.Attribute("name").Value;
                                    if (groupName == selectedGroup)
                                    {
                                        GlGroup glgroup = new GlGroup() { Name = selectedGroup };
                                        foreach (var e in group.Elements("enum"))
                                        {
                                            GLEnum glEnum = new GLEnum();
                                            var enumName = e.Attribute("name").Value;
                                            glEnum.Initialize(file, enumName);
                                            glgroup.Enums.Add(glEnum);
                                        }
                                        version.Groups.Add(glgroup);
                                    }
                                }
                            }
                        }

                        // Parameters
                        foreach (var param in commandElem.Parameters)
                        {
                            if (param.Type == "GLenum")
                            {
                                bool groupExists = version.Groups.Exists(g => g.Name == param.Group);
                                if (!groupExists)
                                {
                                    foreach (var group in file.Root.Element("groups").Elements("group"))
                                    {
                                        string groupName = group.Attribute("name").Value;
                                        if (groupName == param.Group)
                                        {
                                            GlGroup glgroup = new GlGroup() { Name = param.Group };
                                            foreach (var e in group.Elements("enum"))
                                            {
                                                GLEnum glEnum = new GLEnum();
                                                var enumName = e.Attribute("name").Value;
                                                glEnum.Initialize(file, enumName);
                                                glgroup.Enums.Add(glEnum);
                                            }
                                            version.Groups.Add(glgroup);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // Remove any anums and commands
                    foreach (var remove in feature.Elements("remove"))
                    {
                        foreach (var e in remove.Elements("enum"))
                        {
                            foreach (var group in version.Groups)
                            {
                                var glenum = group.Enums.Find(n => n.Name == e.Attribute("name").Value);

                                if (glenum != null)
                                {
                                    group.Enums.Remove(glenum);
                                }
                            }
                        }

                        foreach (var c in remove.Elements("command"))
                        {
                            version.Commands.RemoveAll(command => command.Name == c.Attribute("name").Value);
                        }
                    }

                    // Remove all group with 0 enums
                    version.Groups.RemoveAll(g => g.Enums.Count == 0);

                    // Remove GLBoolean type
                    version.Groups.RemoveAll(g => g.Name == "Boolean");

                    spec.Versions.Add(version);
                }
            }

            return spec;
        }

        private static string FindGroupInXML(XDocument file, string enumName)
        {
            string groupFound = string.Empty;
            foreach (var group in file.Root.Element("groups").Elements("group"))
            {
                foreach (var e in group.Elements("enum"))
                {
                    if (enumName == e.Attribute("name").Value)
                    {
                        groupFound = group.Attribute("name").Value;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(groupFound))
                {
                    break;
                }
            }

            if (string.IsNullOrEmpty(groupFound))
            {
                groupFound = "Extensions";
            }

            return groupFound;
        }

        public class GLVersion
        {
            public string Api;
            public string Name;
            public string Profile;
            public string Number;

            public List<GlGroup> Groups = new List<GlGroup>();
            public List<GLCommand> Commands = new List<GLCommand>();
        }

        public class GlGroup
        {
            public string Name;

            public List<GLEnum> Enums = new List<GLEnum>();

            public GlGroup Clone()
            {
                return new GlGroup
                {
                    Name = Name,
                    Enums = (from p in Enums select new GLEnum { Name = p.Name, ShortName = p.ShortName, Value = p.Value }).ToList()
                };
            }
        }

        public class GLEnum
        {
            public string Name;
            public string ShortName;
            public string Value;

            internal void Initialize(XDocument file, string enumName)
            {
                this.Name = enumName;
                this.ShortName = ComputeShortName(enumName);

                foreach (var enumsElements in file.Root.Elements("enums"))
                {
                    foreach (var enumElem in enumsElements.Elements("enum"))
                    {
                        if (enumElem.Attribute("name").Value == enumName &&
                            (enumElem.Attribute("api") == null)) // || enumElem.Attribute("api").Value == api))
                        {
                            this.Value = enumElem.Attribute("value").Value;
                            break;
                        }
                    }

                    if (!string.IsNullOrEmpty(this.Value))
                    {
                        break;
                    }
                }
            }

            private string ComputeShortName(string enumName)
            {
                string result = string.Empty;
                string lowername = enumName.ToLower();
                var strings = lowername.Split('_');

                for (int i = 1; i < strings.Length; i++)
                {
                    string temp = strings[i];
                    result += char.ToUpper(temp[0]) + temp.Substring(1);
                }

                return result;
            }
        }

        public class GLCommand
        {
            public string Name;

            public GLReturnType ReturnType;

            public List<GLParameter> Parameters = new List<GLParameter>();

            public GLCommand Clone()
            {
                return new GLCommand
                {
                    Name = Name,
                    ReturnType = new GLReturnType() { Type = ReturnType.Type, Group = ReturnType.Group },
                    Parameters = (from p in Parameters select new GLParameter { Name = p.Name, Type = p.Type, Group = p.Group }).ToList()
                };
            }

            public void Initialize(XDocument specDoc)
            {
                var commandElem = (from elem in specDoc.Root.Element("commands").Elements("command")
                                   where elem.Element("proto").Element("name").Value == Name
                                   select elem).First();

                var proto = commandElem.Element("proto");
                ReturnType = new GLReturnType();
                ReturnType.Type = proto.Value.Replace(Name, string.Empty).Trim();
                ReturnType.Group = proto.Attribute("group")?.Value;

                foreach (var p in commandElem.Elements("param"))
                {
                    var param = new GLParameter { Name = p.Element("name").Value };
                    param.Type = p.Value.Substring(0, p.Value.LastIndexOf(param.Name)).Trim();
                    if (p.Attribute("group") != null)
                    {
                        param.Group = p.Attribute("group").Value;
                    }
                    Parameters.Add(param);
                }
            }
        }

        public class GLReturnType
        {
            public string Group;
            public string Type;
        }

        public class GLParameter
        {
            public string Group;
            public string Type;
            public string Name;
        }
    }
}
