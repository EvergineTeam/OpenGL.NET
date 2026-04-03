using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OpenGLGen
{
	public class OpenGLSpecification
	{
		public string HeaderComment;
		public List<ConstantDefinition> Constants = new List<ConstantDefinition>();
		public List<CommandDefinition> Commands = new List<CommandDefinition>();
		public List<FeatureDefinition> Features = new List<FeatureDefinition>();
		public List<ExtensionDefinition> Extensions = new List<ExtensionDefinition>();

		/// <summary>
		/// Maps enum names to their group name in the &lt;groups&gt; section.
		/// </summary>
		public Dictionary<string, string> EnumToGroupMap = new Dictionary<string, string>();

		/// <summary>
		/// Maps group names to the list of enum names that belong to them.
		/// </summary>
		public Dictionary<string, List<string>> GroupToEnumsMap = new Dictionary<string, List<string>>();

		/// <summary>
		/// Maps enum names to their value string from the &lt;enums&gt; blocks.
		/// </summary>
		public Dictionary<string, string> EnumValueMap = new Dictionary<string, string>();

		/// <summary>
		/// Set of group names defined as bitmask type in the XML.
		/// </summary>
		public HashSet<string> BitmaskGroups = new HashSet<string>();

		public static OpenGLSpecification FromFile(string xmlFile, params string[] api)
		{
			XDocument file = XDocument.Load(xmlFile);
			var spec = new OpenGLSpecification();
			var registry = file.Root;

			spec.HeaderComment = registry.Element("comment")?.Value;

			// 1. Build enum-to-group and group-to-enums mappings from <groups>
			var groupsElem = registry.Element("groups");
			if (groupsElem != null)
			{
				foreach (var group in groupsElem.Elements("group"))
				{
					string groupName = group.Attribute("name").Value;
					var enumNames = new List<string>();

					foreach (var e in group.Elements("enum"))
					{
						string enumName = e.Attribute("name").Value;
						enumNames.Add(enumName);

						// First group wins (an enum can appear in multiple groups)
						if (!spec.EnumToGroupMap.ContainsKey(enumName))
						{
							spec.EnumToGroupMap[enumName] = groupName;
						}
					}

					spec.GroupToEnumsMap[groupName] = enumNames;
				}
			}

			// 2. Build enum value map + detect bitmask groups from <enums> blocks
			foreach (var enumsBlock in registry.Elements("enums"))
			{
				string blockGroup = enumsBlock.Attribute("group")?.Value;
				string blockType = enumsBlock.Attribute("type")?.Value;

				if (blockType == "bitmask" && blockGroup != null)
				{
					spec.BitmaskGroups.Add(blockGroup);
				}

				foreach (var enumElem in enumsBlock.Elements("enum"))
				{
					string name = enumElem.Attribute("name").Value;
					string value = enumElem.Attribute("value")?.Value;
					if (value != null && !spec.EnumValueMap.ContainsKey(name))
					{
						spec.EnumValueMap[name] = value;
					}
				}
			}

			// 3. Parse constants from SpecialNumbers group
			var specialNumbers = registry.Elements("enums")
				.Where(e => e.Attribute("group")?.Value == "SpecialNumbers");
			foreach (var block in specialNumbers)
			{
				foreach (var enumElem in block.Elements("enum"))
				{
					spec.Constants.Add(ConstantDefinition.FromXML(enumElem));
				}
			}

			// 4. Parse all commands
			var commandsElem = registry.Element("commands");
			if (commandsElem != null)
			{
				foreach (var cmdElem in commandsElem.Elements("command"))
				{
					if (cmdElem.Element("proto") != null)
					{
						spec.Commands.Add(CommandDefinition.FromXML(cmdElem));
					}
				}
			}

			// 5. Parse features
			foreach (var featureElem in registry.Elements("feature"))
			{
				var featureApi = featureElem.Attribute("api").Value;
				if (api.Contains(featureApi))
				{
					spec.Features.Add(FeatureDefinition.FromXML(featureElem));
				}
			}

			// 6. Parse extensions
			var extensionsElem = registry.Element("extensions");
			if (extensionsElem != null)
			{
				foreach (var extElem in extensionsElem.Elements("extension"))
				{
					spec.Extensions.Add(ExtensionDefinition.FromXML(extElem));
				}
			}

			return spec;
		}
	}
}
