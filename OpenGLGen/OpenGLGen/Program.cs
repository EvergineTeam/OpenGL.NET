using System;
using System.Globalization;
using System.IO;


namespace OpenGLGen
{
    class Program
    {
        static void Main(string[] args)
        {
            string glFile = "..\\..\\..\\..\\..\\KhronosRegistry\\gl.xml";
            var spec = GLParser.FromFile(glFile);

            DirectoryInfo bindingDirectory = new DirectoryInfo("..\\..\\..\\..\\WaveEngine.Bindings.OpenGL");

            // Select version
            var version = spec.Versions[spec.Versions.Count - 1];

            // Write Enums
            using (var writer = new StreamWriter((Path.Combine(bindingDirectory.FullName, "Enums.cs"))))
            {
                writer.WriteLine("using System;\n");
                writer.WriteLine("namespace WaveEngine.Bindings.OpenGL");
                writer.WriteLine("{");

                foreach (var groupElem in version.Groups)
                {
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
                    writer.WriteLine();
                }
                writer.WriteLine("}");
            }

            // Write Commands
            using (var writer = new StreamWriter((Path.Combine(bindingDirectory.FullName, "OpenGLNative.cs"))))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Runtime.InteropServices;\n");
                writer.WriteLine("namespace WaveEngine.Bindings.OpenGL");
                writer.WriteLine("{");
                writer.WriteLine("\tpublic static unsafe class OpenGLNative");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tprivate static Func<string, IntPtr> s_getProcAddress;\n");
                writer.WriteLine("\t\tprivate const CallingConvention CallConv = CallingConvention.Winapi;\n");

                // Prototypes
                foreach (var command in version.Commands)
                {
                    writer.WriteLine($"\t\t//{command.Name}");
                }
                
                // Helper functions
                writer.WriteLine("\n\t\tpublic static void LoadAllFunctions(IntPtr glContext, Func<string, IntPtr> getProcAddress, bool gles)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\ts_getProcAddress = getProcAddress;\n");

                foreach (var command in version.Commands)
                {
                    writer.WriteLine($"\t\t\tLoadFunction(\"{command.Name}\", out p_{command.Name});");
                }
                writer.WriteLine("\t\t}\n");

                // Load AllCommands
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
    }
}
