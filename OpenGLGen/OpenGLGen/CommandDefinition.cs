using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OpenGLGen
{
	public class CommandDefinition
	{
		public string Name;
		public CommandReturnType ReturnType;
		public List<CommandParameter> Parameters = new List<CommandParameter>();

		public static CommandDefinition FromXML(XElement elem)
		{
			var command = new CommandDefinition();

			var proto = elem.Element("proto");
			command.Name = proto.Element("name").Value;
			command.ReturnType = new CommandReturnType
			{
				Type = proto.Value.Replace(command.Name, string.Empty).Trim(),
				Group = proto.Attribute("group")?.Value,
			};

			foreach (var p in elem.Elements("param"))
			{
				var paramName = Helpers.ValidatedName(p.Element("name").Value);
				var param = new CommandParameter
				{
					Name = paramName,
					Type = p.Value.Substring(0, p.Value.LastIndexOf(p.Element("name").Value)).Trim(),
					Group = p.Attribute("group")?.Value,
				};
				command.Parameters.Add(param);
			}

			return command;
		}
	}

	public class CommandReturnType
	{
		public string Group;
		public string Type;
	}

	public class CommandParameter
	{
		public string Group;
		public string Type;
		public string Name;
	}
}
