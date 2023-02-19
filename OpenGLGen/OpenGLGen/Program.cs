using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace OpenGLGen
{
    class Program
    {
        static void Main(string[] args)
        {
            string glFile = "..\\..\\..\\..\\..\\KhronosRegistry\\gl.xml";

            // Generate OpenGL bindings
            DirectoryInfo workingDirectory = new DirectoryInfo("..\\..\\..\\..\\Evergine.Bindings.OpenGL");
            var api = new[] { "gl" };
            string namespaceText = "namespace Evergine.Bindings.OpenGL";
            string nativeClassText = "GL";
            GenerateBindings(glFile, workingDirectory, api, namespaceText, nativeClassText);
        }

        private static void GenerateBindings(string glFile, DirectoryInfo workingDirectory, string[] api, string namespaceText, string nativeClassText)
        {
            var spec = GLParser.FromFile(glFile, api);

            // Select version
            var version = spec.Versions[spec.Versions.Count - 1];

            // Write Enums
            using (var writer = new StreamWriter((Path.Combine(workingDirectory.FullName, "Enums.cs"))))
            {
                writer.WriteLine("using System;\n");
                writer.WriteLine(namespaceText);
                writer.WriteLine("{");

                int count = 0;
                foreach (var groupElem in version.Groups)
                {
                    // Separate one line betweens enums
                    if (count++ > 0)
                    {
                        writer.WriteLine();
                    }

                    writer.WriteLine($"\tpublic enum {groupElem.Name} : uint");
                    writer.WriteLine("\t{");
                    foreach (var enumElem in groupElem.Enums)
                    {
                        if (IsUint(enumElem.Value))
                        {
                            writer.WriteLine($"\t\t{enumElem.ShortName} = {enumElem.Value},");
                        }
                    }
                    writer.WriteLine("\t}");
                }

                writer.WriteLine("}");
            }

            // Write Commands
            using (var writer = new StreamWriter((Path.Combine(workingDirectory.FullName, $"{nativeClassText}.cs"))))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Runtime.InteropServices;\n");
                writer.WriteLine(namespaceText);
                writer.WriteLine("{");
                writer.WriteLine($"\tpublic static unsafe class {nativeClassText}");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tprivate static Func<string, IntPtr> s_getProcAddress;\n");
                writer.WriteLine("\t\tprivate const CallingConvention CallConv = CallingConvention.Winapi;");

                // Prototypes
                foreach (var command in version.Commands)
                {
                    writer.WriteLine("\n\t\t[UnmanagedFunctionPointer(CallConv)]");

                    // Delegate
                    StringBuilder delegateCommand = new StringBuilder("\t\tprivate delegate ");
                    BuildReturnType(version, command, delegateCommand);
                    delegateCommand.Append($" {command.Name}_t(");
                    BuildParameterList(version, command, delegateCommand);
                    delegateCommand.Append(");");
                    writer.WriteLine(delegateCommand.ToString());

                    // internal function
                    writer.WriteLine($"\t\tprivate static {command.Name}_t p_{command.Name};");

                    // public function
                    StringBuilder function = new StringBuilder($"\t\tpublic static ");
                    BuildReturnType(version, command, function);
                    function.Append($" {command.Name}(");
                    BuildParameterList(version, command, function);
                    function.Append($") => p_{command.Name}(");
                    BuildParameterNamesList(command, function);
                    function.Append(");");
                    writer.WriteLine(function.ToString());
                }

                // Helper functions
                writer.WriteLine("\n\t\tpublic static void LoadGetString(Func<string, IntPtr> getProcAddress)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\ts_getProcAddress = getProcAddress;");
                writer.WriteLine("\t\t\tLoadFunction(\"glGetString\", out p_glGetString);");
                writer.WriteLine("\t\t}");

                writer.WriteLine("\n\t\tpublic static void LoadAllFunctions(Func<string, IntPtr> getProcAddress)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\ts_getProcAddress = getProcAddress;\n");

                foreach (var command in version.Commands)
                {
                    writer.WriteLine($"\t\t\tLoadFunction(\"{command.Name}\", out p_{command.Name});");
                }
                writer.WriteLine("\t\t}\n");

                writer.WriteLine("\t\tprivate static void LoadFunction<T>(string name, out T field)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\tIntPtr funcPtr = s_getProcAddress(name);");
                writer.WriteLine("\t\t\tif (funcPtr != IntPtr.Zero)");
                writer.WriteLine("\t\t\t{");
                writer.WriteLine("\t\t\t\tfield = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);");
                writer.WriteLine("\t\t\t}");
                writer.WriteLine("\t\t\telse");
                writer.WriteLine("\t\t\t{");
                writer.WriteLine("\t\t\t\tfield = default(T);");
                writer.WriteLine("\t\t\t}");
                writer.WriteLine("\t\t}");

                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private static bool IsUint(string value)
        {
            bool isHex = false;

            if (value.StartsWith("0x"))
            {
                isHex = true;
                value = value.Substring(2);

                if (value.Length > 8)
                {
                    return false;
                }
            }

            uint result;
            if (isHex)
            {
                return uint.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);
            }
            else
            {
                return uint.TryParse(value, out result);
            }
        }

        private static void BuildReturnType(GLParser.GLVersion version, GLParser.GLCommand c, StringBuilder builder)
        {
            if (c.ReturnType.Type == "GLenum")
            {
                bool groupExists = version.Groups.Exists(g => g.Name == c.ReturnType.Group);

                var groupName = c.ReturnType.Group;

                // For GLenums that don't appear in the gl.xml file.
                if (!groupExists)
                {
                    groupName = "uint";
                }

                builder.Append($"{groupName}");
            }
            else
            {
                builder.Append($"{ConvertGLType(c.ReturnType.Type)}");
            }
        }

        private static void BuildParameterList(GLParser.GLVersion version, GLParser.GLCommand c, StringBuilder builder)
        {
            if (c.Parameters.Count > 0)
            {
                foreach (var p in c.Parameters)
                {
                    var name = p.Name;

                    // Add @ to start of any names that are C# keywords to avoid conflict
                    if (name == "params" || name == "string" || name == "ref" || name == "base")
                    {
                        name = "@" + name;
                    }

                    if (p.Type == "GLenum")
                    {
                        bool groupExists = version.Groups.Exists(g => g.Name == p.Group);

                        var groupName = p.Group;

                        // For GLenums that don't appear in the gl.xml file.
                        if (!groupExists)
                        {
                            groupName = "uint";
                        }

                        builder.Append($"{groupName} {name}, ");
                    }
                    else
                    {
                        builder.Append($"{ConvertGLType(p.Type)} {name}, ");
                    }
                }
                builder.Length -= 2;
            }
        }

        private static void BuildParameterNamesList(GLParser.GLCommand c, StringBuilder builder)
        {
            if (c.Parameters.Count > 0)
            {
                foreach (var p in c.Parameters)
                {
                    var name = p.Name;

                    // Add @ to start of any names that are C# keywords to avoid conflict
                    if (name == "params" || name == "string" || name == "ref" || name == "base")
                    {
                        name = "@" + name;
                    }

                    builder.Append($"{name}, ");
                }
                builder.Length -= 2;
            }
        }

        private static string ConvertGLType(string type)
        {
            switch (type)
            {
                case "GLboolean":
                    return "bool";
                case "GLenum":
                case "GLuint":
                case "GLbitfield":
                case "GLhandleARB":
                    return "uint";
                case "GLint":
                case "GLsizei":
                case "GLsizeiptr":
                case "GLfixed":
                case "GLclampx":
                case "GLintptrARB":
                case "GLsizeiptrARB":
                    return "int";
                case "GLuint *":
                case "const GLuint *":
                case "GLenum *":
                case "const GLenum *":
                    return "uint*";
                case "GLdouble *":
                case "const GLdouble *":
                    return "double*";
                case "GLfloat *":
                case "const GLfloat *":
                    return "float*";
                case "GLint *":
                case "const GLint *":
                case "GLsizei *":
                case "const GLsizei *":
                case "GLsizeiptr *":
                case "const GLsizeiptr *":
                    return "int*";
                case "GLushort *":
                case "const GLushort *":
                case "GLshort *":
                case "const GLshort *":
                    return "short*";
                case "GLboolean *":
                case "const GLboolean *":
                    return "bool*";
                case "GLchar *":
                case "const GLchar *":
                    return "char*";
                case "GLint64 *":
                case "const GLint64 *":
                    return "long*";
                case "GLuint64 *":
                case "const GLuint64 *":
                    return "ulong*";
                case "GLubyte *":
                case "const GLubyte *":
                case "GLbyte *":
                case "const GLbyte *":
                    return "byte*";
                case "void *":
                case "const void *":
                    return "void*";
                case "void **":
                case "const void **":
                    return "void**";
                case "GLfloat":
                case "GLclampf":
                    return "float";
                case "GLclampd":
                case "GLdouble":
                    return "double";
                case "GLubyte":
                    return "byte";
                case "GLbyte":
                    return "sbyte";
                case "GLhalfNV": 
                case "GLushort":
                    return "ushort";
                case "GLshort":
                    return "short";
                case "GLint64":
                case "GLint64EXT":
                    return "long";
                case "GLuint64":
                case "GLuint64EXT":
                    return "ulong";
                case "GLsync":
                case "GLintptr":
                case "GLDEBUGPROC":
                case "GLeglImageOES":
                case "GLvdpauSurfaceNV":
                case "GLVULKANPROCNV":
                case "GLeglClientBufferEXT":
                case "GLDEBUGPROCKHR":
                case "GLDEBUGPROCAMD":
                case "GLDEBUGPROCARB":
                    return "IntPtr";
            }
    
            if (type.Contains("*"))
            {
                return "IntPtr";
            }

            return type;
        }
    }
}
