using System.Xml.Linq;

namespace OpenGLGen
{
	public class ConstantDefinition
	{
		public string Name;
		public string Value;
		public string Type;
		public string Comment;

		public static ConstantDefinition FromXML(XElement elem)
		{
			var constant = new ConstantDefinition();
			constant.Name = elem.Attribute("name").Value;
			constant.Value = elem.Attribute("value")?.Value;
			constant.Type = elem.Attribute("type")?.Value;
			constant.Comment = elem.Attribute("comment")?.Value;
			return constant;
		}

		public string GetCSharpType()
		{
			if (Type == "ull")
				return "ulong";
			if (Type == "u")
				return "uint";
			if (Value != null && Value.StartsWith("\""))
				return "string";
			return "uint";
		}

		public string GetCSharpValue()
		{
			if (Value == null)
				return "0";

			if (Type == "ull")
				return Value.Replace("0xFFFFFFFFFFFFFFFF", "0xFFFFFFFFFFFFFFFF");

			return Value;
		}
	}
}
