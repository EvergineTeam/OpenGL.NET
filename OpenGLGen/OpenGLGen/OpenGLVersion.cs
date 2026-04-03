using System.Collections.Generic;
using System.Linq;

namespace OpenGLGen
{
	public class OpenGLVersion
	{
		public List<GLGroup> Groups = new List<GLGroup>();
		public List<CommandDefinition> Commands = new List<CommandDefinition>();
		public List<ConstantDefinition> Constants = new List<ConstantDefinition>();

		public static OpenGLVersion FromSpec(OpenGLSpecification spec, string[] api)
		{
			var version = new OpenGLVersion();
			version.Constants.AddRange(spec.Constants);

			// Process features in order — each version builds on previous
			foreach (var feature in spec.Features)
			{
				// Add new items from require blocks
				foreach (var enumName in feature.RequiredEnums)
				{
					AddEnumToGroups(spec, version, enumName);
				}

				foreach (var cmdName in feature.RequiredCommands)
				{
					if (!version.Commands.Exists(c => c.Name == cmdName))
					{
						var cmdDef = spec.Commands.Find(c => c.Name == cmdName);
						if (cmdDef != null)
						{
							version.Commands.Add(cmdDef);

							// Also resolve enum groups referenced by command parameters
							AddGroupsFromCommand(spec, version, cmdDef);
						}
					}
				}

				// Remove items from remove blocks
				foreach (var enumName in feature.RemovedEnums)
				{
					foreach (var group in version.Groups)
					{
						group.Enums.RemoveAll(e => e.Name == enumName);
					}
				}

				foreach (var cmdName in feature.RemovedCommands)
				{
					version.Commands.RemoveAll(c => c.Name == cmdName);
				}
			}

			// Remove empty groups
			version.Groups.RemoveAll(g => g.Enums.Count == 0);

			// Remove GLBoolean type
			version.Groups.RemoveAll(g => g.Name == "Boolean");

			// Process extensions
			foreach (var ext in spec.Extensions)
			{
				if (ext.Supported == "disabled")
					continue;

				var supportedApis = ext.Supported.Split('|');
				bool isSupported = api.Any(a => supportedApis.Contains(a));
				if (!isSupported)
					continue;

				foreach (var enumName in ext.EnumNames)
				{
					AddEnumToGroups(spec, version, enumName);
				}

				foreach (var cmdName in ext.CommandNames)
				{
					if (!version.Commands.Exists(c => c.Name == cmdName))
					{
						var cmdDef = spec.Commands.Find(c => c.Name == cmdName);
						if (cmdDef != null)
						{
							version.Commands.Add(cmdDef);
							AddGroupsFromCommand(spec, version, cmdDef);
						}
					}
				}
			}

			// Final cleanup: remove empty groups
			version.Groups.RemoveAll(g => g.Enums.Count == 0);

			// Set bitmask flag on groups
			foreach (var group in version.Groups)
			{
				group.IsBitmask = spec.BitmaskGroups.Contains(group.Name)
					|| Helpers.IsBitmaskGroup(group.Name);
			}

			return version;
		}

		private static void AddEnumToGroups(OpenGLSpecification spec, OpenGLVersion version, string enumName)
		{
			// Skip if already exists in some group
			if (version.Groups.Exists(g => g.Enums.Exists(e => e.Name == enumName)))
				return;

			// Find the group this enum belongs to
			string groupName;
			if (!spec.EnumToGroupMap.TryGetValue(enumName, out groupName))
			{
				groupName = "Extensions";
			}

			// Find or create the group
			var group = version.Groups.Find(g => g.Name == groupName);
			if (group == null)
			{
				group = new GLGroup { Name = groupName };
				version.Groups.Add(group);
			}

			// Look up the value
			string value;
			spec.EnumValueMap.TryGetValue(enumName, out value);

			var glEnum = new GLEnumValue
			{
				Name = enumName,
				ShortName = Helpers.ComputeShortName(enumName),
				Value = value,
			};
			group.Enums.Add(glEnum);
		}

		private static void AddGroupsFromCommand(OpenGLSpecification spec, OpenGLVersion version, CommandDefinition cmd)
		{
			// Check return type group
			if (cmd.ReturnType.Type == "GLenum" && cmd.ReturnType.Group != null)
			{
				EnsureGroupFromXMLGroups(spec, version, cmd.ReturnType.Group);
			}

			// Check parameter groups
			foreach (var param in cmd.Parameters)
			{
				if (param.Type == "GLenum" && param.Group != null)
				{
					EnsureGroupFromXMLGroups(spec, version, param.Group);
				}
			}
		}

		private static void EnsureGroupFromXMLGroups(OpenGLSpecification spec, OpenGLVersion version, string groupName)
		{
			if (version.Groups.Exists(g => g.Name == groupName))
				return;

			// Find all enums belonging to this group using the group-to-enums map
			List<string> enumNames;
			if (!spec.GroupToEnumsMap.TryGetValue(groupName, out enumNames) || enumNames.Count == 0)
				return;

			var group = new GLGroup { Name = groupName };
			foreach (var enumName in enumNames)
			{
				string value;
				spec.EnumValueMap.TryGetValue(enumName, out value);

				group.Enums.Add(new GLEnumValue
				{
					Name = enumName,
					ShortName = Helpers.ComputeShortName(enumName),
					Value = value,
				});
			}

			version.Groups.Add(group);
		}
	}

	public class GLGroup
	{
		public string Name;
		public bool IsBitmask;
		public List<GLEnumValue> Enums = new List<GLEnumValue>();
	}

	public class GLEnumValue
	{
		public string Name;
		public string ShortName;
		public string Value;
	}
}
