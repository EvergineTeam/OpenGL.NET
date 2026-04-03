using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace OpenGLGen
{
	public static class Helpers
	{
		private static readonly HashSet<string> BitmaskGroups = new HashSet<string>
		{
			"AttribMask",
			"BufferBitQCOM",
			"BufferStorageMask",
			"ClearBufferMask",
			"ClientAttribMask",
			"ContextFlagMask",
			"ContextProfileMask",
			"FfdMaskSGIX",
			"FoveationConfigBitQCOM",
			"FragmentShaderColorModMaskATI",
			"FragmentShaderDestMaskATI",
			"FragmentShaderDestModMaskATI",
			"MapBufferAccessMask",
			"MemoryBarrierMask",
			"OcclusionQueryEventMaskAMD",
			"PathRenderingMaskNV",
			"PerformanceQueryCapsMaskINTEL",
			"SyncObjectMask",
			"TextureStorageMaskAMD",
			"TraceMaskMESA",
			"UseProgramStageMask",
			"VertexHintsMaskPGI",
		};

		public static bool IsBitmaskGroup(string groupName)
		{
			return BitmaskGroups.Contains(groupName);
		}

		public static string ValidatedName(string name)
		{
			switch (name)
			{
				case "object":
				case "event":
				case "in":
					return "_" + name;
				default:
					return name;
			}
		}

		public static string EscapeCSharpKeyword(string name)
		{
			switch (name)
			{
				case "params":
				case "string":
				case "ref":
				case "base":
					return "@" + name;
				default:
					return name;
			}
		}

		public static string ConvertGLType(string type)
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
				case "GLfixed":
				case "GLclampx":
					return "int";
				case "GLsizeiptr":
				case "GLintptr":
				case "GLintptrARB":
				case "GLsizeiptrARB":
					return "nint";
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
					return "int*";
				case "GLsizeiptr *":
				case "const GLsizeiptr *":
				case "GLintptr *":
				case "const GLintptr *":
					return "nint*";
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

		public static bool IsUint(string value)
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

		public static string ComputeShortName(string enumName)
		{
			string result = string.Empty;
			string lowername = enumName.ToLower();
			var strings = lowername.Split('_');

			for (int i = 1; i < strings.Length; i++)
			{
				string temp = strings[i];
				result += char.ToUpper(temp[0]) + temp.Substring(1);
			}

			if (result.Length > 0 && char.IsDigit(result[0]))
			{
				result = "_" + result;
			}

			return result;
		}
	}
}
