using System;
using System.IO;


namespace OpenGLGen
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo khronosRegistry = new DirectoryInfo("..\\..\\..\\..\\..\\KhronosRegistry");

            string glFile = "..\\..\\..\\..\\..\\KhronosRegistry\\gl.xml";
            var spec = GLParser.FromFile(glFile);

            Console.WriteLine($"Versions: {spec.Versions.Count}");

            foreach (var version in spec.Versions)
            {
                Console.WriteLine($"API version: {version.Api} : {version.Name}\t Enums: {version.Groups.Count} Commands: {version.Commands.Count}");
            }

            using (StreamWriter writer = new StreamWriter("OpenGL.txt"))
            {
                foreach (var version in spec.Versions)
                {
                    writer.WriteLine($"API version: {version.Api} : {version.Name}\t Enums: {version.Groups.Count} Commands: {version.Commands.Count}");

                    writer.WriteLine("Groups");
                    foreach (var group in version.Groups)
                    {
                        writer.WriteLine($"\t{group.Name}");

                        foreach (var enumElem in group.Enums)
                        {
                            writer.WriteLine($"\t\t {enumElem.Name}");
                        }
                    }

                    writer.WriteLine("Commands");
                    foreach (var commandElem in version.Commands)
                    {
                        writer.WriteLine($"\t{commandElem.Name}");
                    }
                }
            }
        }
    }
}
