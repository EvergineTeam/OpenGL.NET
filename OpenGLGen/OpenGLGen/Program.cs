using System;
using System.IO;
using System.Linq;
using System.Text;

namespace OpenGLGen
{
	class Program
	{
		static void Main(string[] args)
		{
			string glFile = Path.Combine("..", "..", "..", "..", "..", "KhronosRegistry", "gl.xml");

			// Generate OpenGL bindings
			DirectoryInfo workingDirectory = new DirectoryInfo(Path.Combine("..", "..", "..", "..", "Evergine.Bindings.OpenGL"));
			var api = new[] { "gl" };
			string namespaceText = "namespace Evergine.Bindings.OpenGL";
			string nativeClassText = "GL";
			GenerateBindings(glFile, workingDirectory, api, namespaceText, nativeClassText);
		}

		private static void GenerateBindings(string glFile, DirectoryInfo workingDirectory, string[] api, string namespaceText, string nativeClassText)
		{
			var spec = OpenGLSpecification.FromFile(glFile, api);

			Console.WriteLine($"Parsed {spec.Features.Count} API versions");
			Console.WriteLine($"Parsed {spec.Extensions.Count} extensions ({spec.Extensions.Count(e => e.Supported != "disabled" && e.Supported.Split('|').Any(s => api.Contains(s)))} matching API filter)");
			Console.WriteLine($"Parsed {spec.Commands.Count} commands");
			Console.WriteLine($"Parsed {spec.Constants.Count} constants");

			var version = OpenGLVersion.FromSpec(spec, api);

			Console.WriteLine($"Resolved {version.Groups.Count} enum groups");
			Console.WriteLine($"Resolved {version.Commands.Count} commands");
			Console.WriteLine($"Resolved {version.Constants.Count} constants");

			// Ensure Generated/ output directory exists
			string generatedPath = Path.Combine(workingDirectory.FullName, "Generated");
			if (!Directory.Exists(generatedPath))
			{
				Directory.CreateDirectory(generatedPath);
			}

			GenerateEnums(version, generatedPath, namespaceText);
			GenerateConstants(version, generatedPath, namespaceText, nativeClassText);
			GenerateCommands(version, spec, generatedPath, namespaceText, nativeClassText);

			Console.WriteLine("Generation complete.");
		}

		private static void GenerateEnums(OpenGLVersion version, string outputPath, string namespaceText)
		{
			using (var writer = new StreamWriter(Path.Combine(outputPath, "Enums.cs")))
			{
				writer.WriteLine("using System;\n");
				writer.WriteLine(namespaceText);
				writer.WriteLine("{");

				int count = 0;
				foreach (var groupElem in version.Groups)
				{
					// Separate one line between enums
					if (count++ > 0)
					{
						writer.WriteLine();
					}

					if (groupElem.IsBitmask)
					{
						writer.WriteLine("\t[Flags]");
					}

					writer.WriteLine($"\tpublic enum {groupElem.Name} : uint");
					writer.WriteLine("\t{");

					// Add None = 0 for bitmask enums if no zero value exists
					if (groupElem.IsBitmask && !groupElem.Enums.Exists(e => e.Value == "0" || e.Value == "0x0000" || e.Value == "0x00000000"))
					{
						writer.WriteLine("\t\tNone = 0,");
					}

					foreach (var enumElem in groupElem.Enums)
					{
						if (Helpers.IsUint(enumElem.Value))
						{
							writer.WriteLine($"\t\t{enumElem.ShortName} = {enumElem.Value},");
						}
					}
					writer.WriteLine("\t}");
				}

				writer.WriteLine("}");
			}
		}

		private static void GenerateConstants(OpenGLVersion version, string outputPath, string namespaceText, string nativeClassText)
		{
			using (var writer = new StreamWriter(Path.Combine(outputPath, "Constants.cs")))
			{
				writer.WriteLine(namespaceText);
				writer.WriteLine("{");
				writer.WriteLine($"\tpublic static partial class {nativeClassText}");
				writer.WriteLine("\t{");

				foreach (var constant in version.Constants)
				{
					string csharpType = constant.GetCSharpType();
					string csharpValue = constant.GetCSharpValue();
					string shortName = Helpers.ComputeShortName(constant.Name);

					if (constant.Comment != null)
					{
						writer.WriteLine($"\t\t/// <summary>{constant.Comment}</summary>");
					}

					writer.WriteLine($"\t\tpublic const {csharpType} {shortName} = {csharpValue};");
				}

				writer.WriteLine("\t}");
				writer.WriteLine("}");
			}
		}

		private static void GenerateCommands(OpenGLVersion version, OpenGLSpecification spec, string outputPath, string namespaceText, string nativeClassText)
		{
			using (var writer = new StreamWriter(Path.Combine(outputPath, "Commands.cs")))
			{
				writer.WriteLine("using System;");
				writer.WriteLine("using System.Runtime.InteropServices;\n");
				writer.WriteLine(namespaceText);
				writer.WriteLine("{");
				writer.WriteLine($"\tpublic static unsafe partial class {nativeClassText}");
				writer.WriteLine("\t{");

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

					// internal function pointer field
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

				// LoadAllFunctions
				writer.WriteLine("\n\t\tpublic static void LoadAllFunctions(Func<string, IntPtr> getProcAddress)");
				writer.WriteLine("\t\t{");
				writer.WriteLine("\t\t\ts_getProcAddress = getProcAddress;\n");

				foreach (var command in version.Commands)
				{
					writer.WriteLine($"\t\t\tLoadFunction(\"{command.Name}\", out p_{command.Name});");
				}
				writer.WriteLine("\t\t}");

				writer.WriteLine("\t}");
				writer.WriteLine("}");
			}
		}

		private static void BuildReturnType(OpenGLVersion version, CommandDefinition c, StringBuilder builder)
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
				builder.Append($"{Helpers.ConvertGLType(c.ReturnType.Type)}");
			}
		}

		private static void BuildParameterList(OpenGLVersion version, CommandDefinition c, StringBuilder builder)
		{
			if (c.Parameters.Count > 0)
			{
				foreach (var p in c.Parameters)
				{
					var name = Helpers.EscapeCSharpKeyword(p.Name);

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
						builder.Append($"{Helpers.ConvertGLType(p.Type)} {name}, ");
					}
				}
				builder.Length -= 2;
			}
		}

		private static void BuildParameterNamesList(CommandDefinition c, StringBuilder builder)
		{
			if (c.Parameters.Count > 0)
			{
				foreach (var p in c.Parameters)
				{
					var name = Helpers.EscapeCSharpKeyword(p.Name);
					builder.Append($"{name}, ");
				}
				builder.Length -= 2;
			}
		}
	}
}
