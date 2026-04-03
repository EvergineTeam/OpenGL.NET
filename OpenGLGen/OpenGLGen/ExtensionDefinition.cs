using System.Collections.Generic;
using System.Xml.Linq;

namespace OpenGLGen
{
	public class ExtensionDefinition
	{
		public string Name;
		public string Supported;
		public List<string> EnumNames = new List<string>();
		public List<string> CommandNames = new List<string>();

		public static ExtensionDefinition FromXML(XElement elem)
		{
			var ext = new ExtensionDefinition();
			ext.Name = elem.Attribute("name").Value;
			ext.Supported = elem.Attribute("supported")?.Value ?? string.Empty;

			foreach (var require in elem.Elements("require"))
			{
				foreach (var e in require.Elements("enum"))
				{
					ext.EnumNames.Add(e.Attribute("name").Value);
				}

				foreach (var c in require.Elements("command"))
				{
					ext.CommandNames.Add(c.Attribute("name").Value);
				}
			}

			return ext;
		}
	}
}
