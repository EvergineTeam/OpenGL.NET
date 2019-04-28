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
        [XmlElement("Comment")]
        public string HeaderComment;

        [XmlArrayItem("Version")]
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
                            if (version.Commands.Find(c => c.Name == commandElem.Name) == null)
                            {
                                // Create new command
                                glCommand.Initialize(commandElem.Document);
                                version.Commands.Add(glCommand);
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
                    Enums = (from p in Enums select new GLEnum { Name = p.Name, Value = p.Value }).ToList()
                };
            }
        }

        public class GLEnum
        {
            public string Name;
            public string Value;

            internal void Initialize(XDocument file, string enumName)
            {
                this.Name = enumName;

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
        }

        public class GLCommand
        {
            public string Name;

            public string ReturnType;

            public List<GLParameter> Parameters = new List<GLParameter>();

            public GLCommand Clone()
            {
                return new GLCommand
                {
                    Name = Name,
                    ReturnType = ReturnType,
                    Parameters = (from p in Parameters select new GLParameter { Name = p.Name, Type = p.Type, Group = p.Group }).ToList()
                };
            }

            public void Initialize(XDocument specDoc)
            {
                var commandElem = (from elem in specDoc.Root.Element("commands").Elements("command")
                                   where elem.Element("proto").Element("name").Value == Name
                                   select elem).First();

                ReturnType = commandElem.Element("proto").Value.Replace(Name, string.Empty).Trim();

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

        public class GLParameter
        {
            public string Group;
            public string Type;
            public string Name;
        }
    }
}
