using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.OpenGL
{
	public static unsafe partial class GL
	{
		private static Func<string, IntPtr> s_getProcAddress;

		private const CallingConvention CallConv = CallingConvention.Winapi;

		public static void LoadGetString(Func<string, IntPtr> getProcAddress)
		{
			s_getProcAddress = getProcAddress;
			LoadFunction("glGetString", out p_glGetString);
		}

		private static void LoadFunction<T>(string name, out T field)
		{
			IntPtr funcPtr = s_getProcAddress(name);
			if (funcPtr != IntPtr.Zero)
			{
				field = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);
			}
			else
			{
				field = default(T);
			}
		}
	}
}
