using System.Collections.Generic;
using System.Xml.Linq;

namespace OpenGLGen
{
	public class FeatureDefinition
	{
		public string Api;
		public string Name;
		public string Number;
		public List<string> RequiredEnums = new List<string>();
		public List<string> RequiredCommands = new List<string>();
		public List<string> RemovedEnums = new List<string>();
		public List<string> RemovedCommands = new List<string>();

		public static FeatureDefinition FromXML(XElement elem)
		{
			var feature = new FeatureDefinition();
			feature.Api = elem.Attribute("api").Value;
			feature.Name = elem.Attribute("name").Value;
			feature.Number = elem.Attribute("number").Value;

			foreach (var require in elem.Elements("require"))
			{
				foreach (var e in require.Elements("enum"))
				{
					feature.RequiredEnums.Add(e.Attribute("name").Value);
				}

				foreach (var c in require.Elements("command"))
				{
					feature.RequiredCommands.Add(c.Attribute("name").Value);
				}
			}

			foreach (var remove in elem.Elements("remove"))
			{
				foreach (var e in remove.Elements("enum"))
				{
					feature.RemovedEnums.Add(e.Attribute("name").Value);
				}

				foreach (var c in remove.Elements("command"))
				{
					feature.RemovedCommands.Add(c.Attribute("name").Value);
				}
			}

			return feature;
		}
	}
}
