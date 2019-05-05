using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.OpenGL
{
	public static unsafe class OpenGLNative
	{
		private static Func<string, IntPtr> s_getProcAddress;

		private const CallingConvention CallConv = CallingConvention.Winapi;

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCullFace_t(uint mode);
		private static glCullFace_t p_glCullFace;
		public static void glCullFace(uint mode) => p_glCullFace(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFrontFace_t(uint mode);
		private static glFrontFace_t p_glFrontFace;
		public static void glFrontFace(uint mode) => p_glFrontFace(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glHint_t(uint target, uint mode);
		private static glHint_t p_glHint;
		public static void glHint(uint target, uint mode) => p_glHint(target, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLineWidth_t(float width);
		private static glLineWidth_t p_glLineWidth;
		public static void glLineWidth(float width) => p_glLineWidth(width);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointSize_t(float size);
		private static glPointSize_t p_glPointSize;
		public static void glPointSize(float size) => p_glPointSize(size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPolygonMode_t(uint face, uint mode);
		private static glPolygonMode_t p_glPolygonMode;
		public static void glPolygonMode(uint face, uint mode) => p_glPolygonMode(face, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glScissor_t(int x, int y, int width, int height);
		private static glScissor_t p_glScissor;
		public static void glScissor(int x, int y, int width, int height) => p_glScissor(x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterf_t(uint target, uint pname, float param);
		private static glTexParameterf_t p_glTexParameterf;
		public static void glTexParameterf(uint target, uint pname, float param) => p_glTexParameterf(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterfv_t(uint target, uint pname, IntPtr @params);
		private static glTexParameterfv_t p_glTexParameterfv;
		public static void glTexParameterfv(uint target, uint pname, IntPtr @params) => p_glTexParameterfv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameteri_t(uint target, uint pname, int param);
		private static glTexParameteri_t p_glTexParameteri;
		public static void glTexParameteri(uint target, uint pname, int param) => p_glTexParameteri(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameteriv_t(uint target, uint pname, IntPtr @params);
		private static glTexParameteriv_t p_glTexParameteriv;
		public static void glTexParameteriv(uint target, uint pname, IntPtr @params) => p_glTexParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexImage1D_t(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);
		private static glTexImage1D_t p_glTexImage1D;
		public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels) => p_glTexImage1D(target, level, internalformat, width, border, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexImage2D_t(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
		private static glTexImage2D_t p_glTexImage2D;
		public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels) => p_glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawBuffer_t(uint buf);
		private static glDrawBuffer_t p_glDrawBuffer;
		public static void glDrawBuffer(uint buf) => p_glDrawBuffer(buf);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClear_t(uint mask);
		private static glClear_t p_glClear;
		public static void glClear(uint mask) => p_glClear(mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearColor_t(float red, float green, float blue, float alpha);
		private static glClearColor_t p_glClearColor;
		public static void glClearColor(float red, float green, float blue, float alpha) => p_glClearColor(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearStencil_t(int s);
		private static glClearStencil_t p_glClearStencil;
		public static void glClearStencil(int s) => p_glClearStencil(s);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearDepth_t(double depth);
		private static glClearDepth_t p_glClearDepth;
		public static void glClearDepth(double depth) => p_glClearDepth(depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilMask_t(uint mask);
		private static glStencilMask_t p_glStencilMask;
		public static void glStencilMask(uint mask) => p_glStencilMask(mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorMask_t(bool red, bool green, bool blue, bool alpha);
		private static glColorMask_t p_glColorMask;
		public static void glColorMask(bool red, bool green, bool blue, bool alpha) => p_glColorMask(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthMask_t(bool flag);
		private static glDepthMask_t p_glDepthMask;
		public static void glDepthMask(bool flag) => p_glDepthMask(flag);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDisable_t(uint cap);
		private static glDisable_t p_glDisable;
		public static void glDisable(uint cap) => p_glDisable(cap);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEnable_t(uint cap);
		private static glEnable_t p_glEnable;
		public static void glEnable(uint cap) => p_glEnable(cap);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFinish_t();
		private static glFinish_t p_glFinish;
		public static void glFinish() => p_glFinish();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFlush_t();
		private static glFlush_t p_glFlush;
		public static void glFlush() => p_glFlush();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFunc_t(uint sfactor, uint dfactor);
		private static glBlendFunc_t p_glBlendFunc;
		public static void glBlendFunc(uint sfactor, uint dfactor) => p_glBlendFunc(sfactor, dfactor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLogicOp_t(uint opcode);
		private static glLogicOp_t p_glLogicOp;
		public static void glLogicOp(uint opcode) => p_glLogicOp(opcode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilFunc_t(uint func, int @ref, uint mask);
		private static glStencilFunc_t p_glStencilFunc;
		public static void glStencilFunc(uint func, int @ref, uint mask) => p_glStencilFunc(func, @ref, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilOp_t(uint fail, uint zfail, uint zpass);
		private static glStencilOp_t p_glStencilOp;
		public static void glStencilOp(uint fail, uint zfail, uint zpass) => p_glStencilOp(fail, zfail, zpass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthFunc_t(uint func);
		private static glDepthFunc_t p_glDepthFunc;
		public static void glDepthFunc(uint func) => p_glDepthFunc(func);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPixelStoref_t(uint pname, float param);
		private static glPixelStoref_t p_glPixelStoref;
		public static void glPixelStoref(uint pname, float param) => p_glPixelStoref(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPixelStorei_t(uint pname, int param);
		private static glPixelStorei_t p_glPixelStorei;
		public static void glPixelStorei(uint pname, int param) => p_glPixelStorei(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReadBuffer_t(uint src);
		private static glReadBuffer_t p_glReadBuffer;
		public static void glReadBuffer(uint src) => p_glReadBuffer(src);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReadPixels_t(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);
		private static glReadPixels_t p_glReadPixels;
		public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels) => p_glReadPixels(x, y, width, height, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBooleanv_t(uint pname, IntPtr data);
		private static glGetBooleanv_t p_glGetBooleanv;
		public static void glGetBooleanv(uint pname, IntPtr data) => p_glGetBooleanv(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetDoublev_t(uint pname, IntPtr data);
		private static glGetDoublev_t p_glGetDoublev;
		public static void glGetDoublev(uint pname, IntPtr data) => p_glGetDoublev(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetError_t();
		private static glGetError_t p_glGetError;
		public static uint glGetError() => p_glGetError();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFloatv_t(uint pname, IntPtr data);
		private static glGetFloatv_t p_glGetFloatv;
		public static void glGetFloatv(uint pname, IntPtr data) => p_glGetFloatv(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetIntegerv_t(uint pname, IntPtr data);
		private static glGetIntegerv_t p_glGetIntegerv;
		public static void glGetIntegerv(uint pname, IntPtr data) => p_glGetIntegerv(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glGetString_t(uint name);
		private static glGetString_t p_glGetString;
		public static IntPtr glGetString(uint name) => p_glGetString(name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexImage_t(uint target, int level, uint format, uint type, IntPtr pixels);
		private static glGetTexImage_t p_glGetTexImage;
		public static void glGetTexImage(uint target, int level, uint format, uint type, IntPtr pixels) => p_glGetTexImage(target, level, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameterfv_t(uint target, uint pname, IntPtr @params);
		private static glGetTexParameterfv_t p_glGetTexParameterfv;
		public static void glGetTexParameterfv(uint target, uint pname, IntPtr @params) => p_glGetTexParameterfv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameteriv_t(uint target, uint pname, IntPtr @params);
		private static glGetTexParameteriv_t p_glGetTexParameteriv;
		public static void glGetTexParameteriv(uint target, uint pname, IntPtr @params) => p_glGetTexParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexLevelParameterfv_t(uint target, int level, uint pname, IntPtr @params);
		private static glGetTexLevelParameterfv_t p_glGetTexLevelParameterfv;
		public static void glGetTexLevelParameterfv(uint target, int level, uint pname, IntPtr @params) => p_glGetTexLevelParameterfv(target, level, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexLevelParameteriv_t(uint target, int level, uint pname, IntPtr @params);
		private static glGetTexLevelParameteriv_t p_glGetTexLevelParameteriv;
		public static void glGetTexLevelParameteriv(uint target, int level, uint pname, IntPtr @params) => p_glGetTexLevelParameteriv(target, level, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsEnabled_t(uint cap);
		private static glIsEnabled_t p_glIsEnabled;
		public static bool glIsEnabled(uint cap) => p_glIsEnabled(cap);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthRange_t(double n, double f);
		private static glDepthRange_t p_glDepthRange;
		public static void glDepthRange(double n, double f) => p_glDepthRange(n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glViewport_t(int x, int y, int width, int height);
		private static glViewport_t p_glViewport;
		public static void glViewport(int x, int y, int width, int height) => p_glViewport(x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawArrays_t(uint mode, int first, int count);
		private static glDrawArrays_t p_glDrawArrays;
		public static void glDrawArrays(uint mode, int first, int count) => p_glDrawArrays(mode, first, count);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElements_t(uint mode, int count, uint type, IntPtr indices);
		private static glDrawElements_t p_glDrawElements;
		public static void glDrawElements(uint mode, int count, uint type, IntPtr indices) => p_glDrawElements(mode, count, type, indices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPolygonOffset_t(float factor, float units);
		private static glPolygonOffset_t p_glPolygonOffset;
		public static void glPolygonOffset(float factor, float units) => p_glPolygonOffset(factor, units);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexImage1D_t(uint target, int level, uint internalformat, int x, int y, int width, int border);
		private static glCopyTexImage1D_t p_glCopyTexImage1D;
		public static void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border) => p_glCopyTexImage1D(target, level, internalformat, x, y, width, border);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexImage2D_t(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		private static glCopyTexImage2D_t p_glCopyTexImage2D;
		public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) => p_glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexSubImage1D_t(uint target, int level, int xoffset, int x, int y, int width);
		private static glCopyTexSubImage1D_t p_glCopyTexSubImage1D;
		public static void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) => p_glCopyTexSubImage1D(target, level, xoffset, x, y, width);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexSubImage2D_t(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private static glCopyTexSubImage2D_t p_glCopyTexSubImage2D;
		public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => p_glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexSubImage1D_t(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		private static glTexSubImage1D_t p_glTexSubImage1D;
		public static void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) => p_glTexSubImage1D(target, level, xoffset, width, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexSubImage2D_t(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		private static glTexSubImage2D_t p_glTexSubImage2D;
		public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) => p_glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindTexture_t(uint target, uint texture);
		private static glBindTexture_t p_glBindTexture;
		public static void glBindTexture(uint target, uint texture) => p_glBindTexture(target, texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteTextures_t(int n, IntPtr textures);
		private static glDeleteTextures_t p_glDeleteTextures;
		public static void glDeleteTextures(int n, IntPtr textures) => p_glDeleteTextures(n, textures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenTextures_t(int n, IntPtr textures);
		private static glGenTextures_t p_glGenTextures;
		public static void glGenTextures(int n, IntPtr textures) => p_glGenTextures(n, textures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsTexture_t(uint texture);
		private static glIsTexture_t p_glIsTexture;
		public static bool glIsTexture(uint texture) => p_glIsTexture(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawRangeElements_t(uint mode, uint start, uint end, int count, uint type, IntPtr indices);
		private static glDrawRangeElements_t p_glDrawRangeElements;
		public static void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices) => p_glDrawRangeElements(mode, start, end, count, type, indices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexImage3D_t(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);
		private static glTexImage3D_t p_glTexImage3D;
		public static void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels) => p_glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexSubImage3D_t(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		private static glTexSubImage3D_t p_glTexSubImage3D;
		public static void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels) => p_glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexSubImage3D_t(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private static glCopyTexSubImage3D_t p_glCopyTexSubImage3D;
		public static void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => p_glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glActiveTexture_t(uint texture);
		private static glActiveTexture_t p_glActiveTexture;
		public static void glActiveTexture(uint texture) => p_glActiveTexture(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSampleCoverage_t(float value, bool invert);
		private static glSampleCoverage_t p_glSampleCoverage;
		public static void glSampleCoverage(float value, bool invert) => p_glSampleCoverage(value, invert);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexImage3D_t(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
		private static glCompressedTexImage3D_t p_glCompressedTexImage3D;
		public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data) => p_glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexImage2D_t(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
		private static glCompressedTexImage2D_t p_glCompressedTexImage2D;
		public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data) => p_glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexImage1D_t(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
		private static glCompressedTexImage1D_t p_glCompressedTexImage1D;
		public static void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data) => p_glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexSubImage3D_t(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		private static glCompressedTexSubImage3D_t p_glCompressedTexSubImage3D;
		public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data) => p_glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexSubImage2D_t(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		private static glCompressedTexSubImage2D_t p_glCompressedTexSubImage2D;
		public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data) => p_glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexSubImage1D_t(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		private static glCompressedTexSubImage1D_t p_glCompressedTexSubImage1D;
		public static void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data) => p_glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetCompressedTexImage_t(uint target, int level, IntPtr img);
		private static glGetCompressedTexImage_t p_glGetCompressedTexImage;
		public static void glGetCompressedTexImage(uint target, int level, IntPtr img) => p_glGetCompressedTexImage(target, level, img);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFuncSeparate_t(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
		private static glBlendFuncSeparate_t p_glBlendFuncSeparate;
		public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) => p_glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiDrawArrays_t(uint mode, IntPtr first, IntPtr count, int drawcount);
		private static glMultiDrawArrays_t p_glMultiDrawArrays;
		public static void glMultiDrawArrays(uint mode, IntPtr first, IntPtr count, int drawcount) => p_glMultiDrawArrays(mode, first, count, drawcount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiDrawElements_t(uint mode, IntPtr count, uint type, IntPtr indices, int drawcount);
		private static glMultiDrawElements_t p_glMultiDrawElements;
		public static void glMultiDrawElements(uint mode, IntPtr count, uint type, IntPtr indices, int drawcount) => p_glMultiDrawElements(mode, count, type, indices, drawcount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameterf_t(uint pname, float param);
		private static glPointParameterf_t p_glPointParameterf;
		public static void glPointParameterf(uint pname, float param) => p_glPointParameterf(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameterfv_t(uint pname, IntPtr @params);
		private static glPointParameterfv_t p_glPointParameterfv;
		public static void glPointParameterfv(uint pname, IntPtr @params) => p_glPointParameterfv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameteri_t(uint pname, int param);
		private static glPointParameteri_t p_glPointParameteri;
		public static void glPointParameteri(uint pname, int param) => p_glPointParameteri(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameteriv_t(uint pname, IntPtr @params);
		private static glPointParameteriv_t p_glPointParameteriv;
		public static void glPointParameteriv(uint pname, IntPtr @params) => p_glPointParameteriv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendColor_t(float red, float green, float blue, float alpha);
		private static glBlendColor_t p_glBlendColor;
		public static void glBlendColor(float red, float green, float blue, float alpha) => p_glBlendColor(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquation_t(uint mode);
		private static glBlendEquation_t p_glBlendEquation;
		public static void glBlendEquation(uint mode) => p_glBlendEquation(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenQueries_t(int n, IntPtr ids);
		private static glGenQueries_t p_glGenQueries;
		public static void glGenQueries(int n, IntPtr ids) => p_glGenQueries(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteQueries_t(int n, IntPtr ids);
		private static glDeleteQueries_t p_glDeleteQueries;
		public static void glDeleteQueries(int n, IntPtr ids) => p_glDeleteQueries(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsQuery_t(uint id);
		private static glIsQuery_t p_glIsQuery;
		public static bool glIsQuery(uint id) => p_glIsQuery(id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBeginQuery_t(uint target, uint id);
		private static glBeginQuery_t p_glBeginQuery;
		public static void glBeginQuery(uint target, uint id) => p_glBeginQuery(target, id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEndQuery_t(uint target);
		private static glEndQuery_t p_glEndQuery;
		public static void glEndQuery(uint target) => p_glEndQuery(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryiv_t(uint target, uint pname, IntPtr @params);
		private static glGetQueryiv_t p_glGetQueryiv;
		public static void glGetQueryiv(uint target, uint pname, IntPtr @params) => p_glGetQueryiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryObjectiv_t(uint id, uint pname, IntPtr @params);
		private static glGetQueryObjectiv_t p_glGetQueryObjectiv;
		public static void glGetQueryObjectiv(uint id, uint pname, IntPtr @params) => p_glGetQueryObjectiv(id, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryObjectuiv_t(uint id, uint pname, IntPtr @params);
		private static glGetQueryObjectuiv_t p_glGetQueryObjectuiv;
		public static void glGetQueryObjectuiv(uint id, uint pname, IntPtr @params) => p_glGetQueryObjectuiv(id, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBuffer_t(uint target, uint buffer);
		private static glBindBuffer_t p_glBindBuffer;
		public static void glBindBuffer(uint target, uint buffer) => p_glBindBuffer(target, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteBuffers_t(int n, IntPtr buffers);
		private static glDeleteBuffers_t p_glDeleteBuffers;
		public static void glDeleteBuffers(int n, IntPtr buffers) => p_glDeleteBuffers(n, buffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenBuffers_t(int n, IntPtr buffers);
		private static glGenBuffers_t p_glGenBuffers;
		public static void glGenBuffers(int n, IntPtr buffers) => p_glGenBuffers(n, buffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsBuffer_t(uint buffer);
		private static glIsBuffer_t p_glIsBuffer;
		public static bool glIsBuffer(uint buffer) => p_glIsBuffer(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBufferData_t(uint target, int size, IntPtr data, uint usage);
		private static glBufferData_t p_glBufferData;
		public static void glBufferData(uint target, int size, IntPtr data, uint usage) => p_glBufferData(target, size, data, usage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBufferSubData_t(uint target, IntPtr offset, int size, IntPtr data);
		private static glBufferSubData_t p_glBufferSubData;
		public static void glBufferSubData(uint target, IntPtr offset, int size, IntPtr data) => p_glBufferSubData(target, offset, size, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBufferSubData_t(uint target, IntPtr offset, int size, IntPtr data);
		private static glGetBufferSubData_t p_glGetBufferSubData;
		public static void glGetBufferSubData(uint target, IntPtr offset, int size, IntPtr data) => p_glGetBufferSubData(target, offset, size, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glMapBuffer_t(uint target, uint access);
		private static glMapBuffer_t p_glMapBuffer;
		public static IntPtr glMapBuffer(uint target, uint access) => p_glMapBuffer(target, access);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glUnmapBuffer_t(uint target);
		private static glUnmapBuffer_t p_glUnmapBuffer;
		public static bool glUnmapBuffer(uint target) => p_glUnmapBuffer(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBufferParameteriv_t(uint target, uint pname, IntPtr @params);
		private static glGetBufferParameteriv_t p_glGetBufferParameteriv;
		public static void glGetBufferParameteriv(uint target, uint pname, IntPtr @params) => p_glGetBufferParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBufferPointerv_t(uint target, uint pname, IntPtr @params);
		private static glGetBufferPointerv_t p_glGetBufferPointerv;
		public static void glGetBufferPointerv(uint target, uint pname, IntPtr @params) => p_glGetBufferPointerv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquationSeparate_t(uint modeRGB, uint modeAlpha);
		private static glBlendEquationSeparate_t p_glBlendEquationSeparate;
		public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha) => p_glBlendEquationSeparate(modeRGB, modeAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawBuffers_t(int n, IntPtr bufs);
		private static glDrawBuffers_t p_glDrawBuffers;
		public static void glDrawBuffers(int n, IntPtr bufs) => p_glDrawBuffers(n, bufs);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilOpSeparate_t(uint face, uint sfail, uint dpfail, uint dppass);
		private static glStencilOpSeparate_t p_glStencilOpSeparate;
		public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) => p_glStencilOpSeparate(face, sfail, dpfail, dppass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilFuncSeparate_t(uint face, uint func, int @ref, uint mask);
		private static glStencilFuncSeparate_t p_glStencilFuncSeparate;
		public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask) => p_glStencilFuncSeparate(face, func, @ref, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilMaskSeparate_t(uint face, uint mask);
		private static glStencilMaskSeparate_t p_glStencilMaskSeparate;
		public static void glStencilMaskSeparate(uint face, uint mask) => p_glStencilMaskSeparate(face, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glAttachShader_t(uint program, uint shader);
		private static glAttachShader_t p_glAttachShader;
		public static void glAttachShader(uint program, uint shader) => p_glAttachShader(program, shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindAttribLocation_t(uint program, uint index, IntPtr name);
		private static glBindAttribLocation_t p_glBindAttribLocation;
		public static void glBindAttribLocation(uint program, uint index, IntPtr name) => p_glBindAttribLocation(program, index, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompileShader_t(uint shader);
		private static glCompileShader_t p_glCompileShader;
		public static void glCompileShader(uint shader) => p_glCompileShader(shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCreateProgram_t();
		private static glCreateProgram_t p_glCreateProgram;
		public static uint glCreateProgram() => p_glCreateProgram();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCreateShader_t(uint type);
		private static glCreateShader_t p_glCreateShader;
		public static uint glCreateShader(uint type) => p_glCreateShader(type);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteProgram_t(uint program);
		private static glDeleteProgram_t p_glDeleteProgram;
		public static void glDeleteProgram(uint program) => p_glDeleteProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteShader_t(uint shader);
		private static glDeleteShader_t p_glDeleteShader;
		public static void glDeleteShader(uint shader) => p_glDeleteShader(shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDetachShader_t(uint program, uint shader);
		private static glDetachShader_t p_glDetachShader;
		public static void glDetachShader(uint program, uint shader) => p_glDetachShader(program, shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDisableVertexAttribArray_t(uint index);
		private static glDisableVertexAttribArray_t p_glDisableVertexAttribArray;
		public static void glDisableVertexAttribArray(uint index) => p_glDisableVertexAttribArray(index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEnableVertexAttribArray_t(uint index);
		private static glEnableVertexAttribArray_t p_glEnableVertexAttribArray;
		public static void glEnableVertexAttribArray(uint index) => p_glEnableVertexAttribArray(index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveAttrib_t(uint program, uint index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name);
		private static glGetActiveAttrib_t p_glGetActiveAttrib;
		public static void glGetActiveAttrib(uint program, uint index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name) => p_glGetActiveAttrib(program, index, bufSize, length, size, type, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniform_t(uint program, uint index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name);
		private static glGetActiveUniform_t p_glGetActiveUniform;
		public static void glGetActiveUniform(uint program, uint index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name) => p_glGetActiveUniform(program, index, bufSize, length, size, type, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetAttachedShaders_t(uint program, int maxCount, IntPtr count, IntPtr shaders);
		private static glGetAttachedShaders_t p_glGetAttachedShaders;
		public static void glGetAttachedShaders(uint program, int maxCount, IntPtr count, IntPtr shaders) => p_glGetAttachedShaders(program, maxCount, count, shaders);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetAttribLocation_t(uint program, IntPtr name);
		private static glGetAttribLocation_t p_glGetAttribLocation;
		public static int glGetAttribLocation(uint program, IntPtr name) => p_glGetAttribLocation(program, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramiv_t(uint program, uint pname, IntPtr @params);
		private static glGetProgramiv_t p_glGetProgramiv;
		public static void glGetProgramiv(uint program, uint pname, IntPtr @params) => p_glGetProgramiv(program, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramInfoLog_t(uint program, int bufSize, IntPtr length, IntPtr infoLog);
		private static glGetProgramInfoLog_t p_glGetProgramInfoLog;
		public static void glGetProgramInfoLog(uint program, int bufSize, IntPtr length, IntPtr infoLog) => p_glGetProgramInfoLog(program, bufSize, length, infoLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderiv_t(uint shader, uint pname, IntPtr @params);
		private static glGetShaderiv_t p_glGetShaderiv;
		public static void glGetShaderiv(uint shader, uint pname, IntPtr @params) => p_glGetShaderiv(shader, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderInfoLog_t(uint shader, int bufSize, IntPtr length, IntPtr infoLog);
		private static glGetShaderInfoLog_t p_glGetShaderInfoLog;
		public static void glGetShaderInfoLog(uint shader, int bufSize, IntPtr length, IntPtr infoLog) => p_glGetShaderInfoLog(shader, bufSize, length, infoLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderSource_t(uint shader, int bufSize, IntPtr length, IntPtr source);
		private static glGetShaderSource_t p_glGetShaderSource;
		public static void glGetShaderSource(uint shader, int bufSize, IntPtr length, IntPtr source) => p_glGetShaderSource(shader, bufSize, length, source);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetUniformLocation_t(uint program, IntPtr name);
		private static glGetUniformLocation_t p_glGetUniformLocation;
		public static int glGetUniformLocation(uint program, IntPtr name) => p_glGetUniformLocation(program, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformfv_t(uint program, int location, IntPtr @params);
		private static glGetUniformfv_t p_glGetUniformfv;
		public static void glGetUniformfv(uint program, int location, IntPtr @params) => p_glGetUniformfv(program, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformiv_t(uint program, int location, IntPtr @params);
		private static glGetUniformiv_t p_glGetUniformiv;
		public static void glGetUniformiv(uint program, int location, IntPtr @params) => p_glGetUniformiv(program, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribdv_t(uint index, uint pname, IntPtr @params);
		private static glGetVertexAttribdv_t p_glGetVertexAttribdv;
		public static void glGetVertexAttribdv(uint index, uint pname, IntPtr @params) => p_glGetVertexAttribdv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribfv_t(uint index, uint pname, IntPtr @params);
		private static glGetVertexAttribfv_t p_glGetVertexAttribfv;
		public static void glGetVertexAttribfv(uint index, uint pname, IntPtr @params) => p_glGetVertexAttribfv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribiv_t(uint index, uint pname, IntPtr @params);
		private static glGetVertexAttribiv_t p_glGetVertexAttribiv;
		public static void glGetVertexAttribiv(uint index, uint pname, IntPtr @params) => p_glGetVertexAttribiv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribPointerv_t(uint index, uint pname, IntPtr pointer);
		private static glGetVertexAttribPointerv_t p_glGetVertexAttribPointerv;
		public static void glGetVertexAttribPointerv(uint index, uint pname, IntPtr pointer) => p_glGetVertexAttribPointerv(index, pname, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsProgram_t(uint program);
		private static glIsProgram_t p_glIsProgram;
		public static bool glIsProgram(uint program) => p_glIsProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsShader_t(uint shader);
		private static glIsShader_t p_glIsShader;
		public static bool glIsShader(uint shader) => p_glIsShader(shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLinkProgram_t(uint program);
		private static glLinkProgram_t p_glLinkProgram;
		public static void glLinkProgram(uint program) => p_glLinkProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glShaderSource_t(uint shader, int count, IntPtr @string, IntPtr length);
		private static glShaderSource_t p_glShaderSource;
		public static void glShaderSource(uint shader, int count, IntPtr @string, IntPtr length) => p_glShaderSource(shader, count, @string, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUseProgram_t(uint program);
		private static glUseProgram_t p_glUseProgram;
		public static void glUseProgram(uint program) => p_glUseProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1f_t(int location, float v0);
		private static glUniform1f_t p_glUniform1f;
		public static void glUniform1f(int location, float v0) => p_glUniform1f(location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2f_t(int location, float v0, float v1);
		private static glUniform2f_t p_glUniform2f;
		public static void glUniform2f(int location, float v0, float v1) => p_glUniform2f(location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3f_t(int location, float v0, float v1, float v2);
		private static glUniform3f_t p_glUniform3f;
		public static void glUniform3f(int location, float v0, float v1, float v2) => p_glUniform3f(location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4f_t(int location, float v0, float v1, float v2, float v3);
		private static glUniform4f_t p_glUniform4f;
		public static void glUniform4f(int location, float v0, float v1, float v2, float v3) => p_glUniform4f(location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1i_t(int location, int v0);
		private static glUniform1i_t p_glUniform1i;
		public static void glUniform1i(int location, int v0) => p_glUniform1i(location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2i_t(int location, int v0, int v1);
		private static glUniform2i_t p_glUniform2i;
		public static void glUniform2i(int location, int v0, int v1) => p_glUniform2i(location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3i_t(int location, int v0, int v1, int v2);
		private static glUniform3i_t p_glUniform3i;
		public static void glUniform3i(int location, int v0, int v1, int v2) => p_glUniform3i(location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4i_t(int location, int v0, int v1, int v2, int v3);
		private static glUniform4i_t p_glUniform4i;
		public static void glUniform4i(int location, int v0, int v1, int v2, int v3) => p_glUniform4i(location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1fv_t(int location, int count, IntPtr value);
		private static glUniform1fv_t p_glUniform1fv;
		public static void glUniform1fv(int location, int count, IntPtr value) => p_glUniform1fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2fv_t(int location, int count, IntPtr value);
		private static glUniform2fv_t p_glUniform2fv;
		public static void glUniform2fv(int location, int count, IntPtr value) => p_glUniform2fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3fv_t(int location, int count, IntPtr value);
		private static glUniform3fv_t p_glUniform3fv;
		public static void glUniform3fv(int location, int count, IntPtr value) => p_glUniform3fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4fv_t(int location, int count, IntPtr value);
		private static glUniform4fv_t p_glUniform4fv;
		public static void glUniform4fv(int location, int count, IntPtr value) => p_glUniform4fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1iv_t(int location, int count, IntPtr value);
		private static glUniform1iv_t p_glUniform1iv;
		public static void glUniform1iv(int location, int count, IntPtr value) => p_glUniform1iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2iv_t(int location, int count, IntPtr value);
		private static glUniform2iv_t p_glUniform2iv;
		public static void glUniform2iv(int location, int count, IntPtr value) => p_glUniform2iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3iv_t(int location, int count, IntPtr value);
		private static glUniform3iv_t p_glUniform3iv;
		public static void glUniform3iv(int location, int count, IntPtr value) => p_glUniform3iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4iv_t(int location, int count, IntPtr value);
		private static glUniform4iv_t p_glUniform4iv;
		public static void glUniform4iv(int location, int count, IntPtr value) => p_glUniform4iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix2fv_t p_glUniformMatrix2fv;
		public static void glUniformMatrix2fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix2fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix3fv_t p_glUniformMatrix3fv;
		public static void glUniformMatrix3fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix3fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix4fv_t p_glUniformMatrix4fv;
		public static void glUniformMatrix4fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix4fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glValidateProgram_t(uint program);
		private static glValidateProgram_t p_glValidateProgram;
		public static void glValidateProgram(uint program) => p_glValidateProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1d_t(uint index, double x);
		private static glVertexAttrib1d_t p_glVertexAttrib1d;
		public static void glVertexAttrib1d(uint index, double x) => p_glVertexAttrib1d(index, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1dv_t(uint index, IntPtr v);
		private static glVertexAttrib1dv_t p_glVertexAttrib1dv;
		public static void glVertexAttrib1dv(uint index, IntPtr v) => p_glVertexAttrib1dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1f_t(uint index, float x);
		private static glVertexAttrib1f_t p_glVertexAttrib1f;
		public static void glVertexAttrib1f(uint index, float x) => p_glVertexAttrib1f(index, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1fv_t(uint index, IntPtr v);
		private static glVertexAttrib1fv_t p_glVertexAttrib1fv;
		public static void glVertexAttrib1fv(uint index, IntPtr v) => p_glVertexAttrib1fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1s_t(uint index, short x);
		private static glVertexAttrib1s_t p_glVertexAttrib1s;
		public static void glVertexAttrib1s(uint index, short x) => p_glVertexAttrib1s(index, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1sv_t(uint index, IntPtr v);
		private static glVertexAttrib1sv_t p_glVertexAttrib1sv;
		public static void glVertexAttrib1sv(uint index, IntPtr v) => p_glVertexAttrib1sv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2d_t(uint index, double x, double y);
		private static glVertexAttrib2d_t p_glVertexAttrib2d;
		public static void glVertexAttrib2d(uint index, double x, double y) => p_glVertexAttrib2d(index, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2dv_t(uint index, IntPtr v);
		private static glVertexAttrib2dv_t p_glVertexAttrib2dv;
		public static void glVertexAttrib2dv(uint index, IntPtr v) => p_glVertexAttrib2dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2f_t(uint index, float x, float y);
		private static glVertexAttrib2f_t p_glVertexAttrib2f;
		public static void glVertexAttrib2f(uint index, float x, float y) => p_glVertexAttrib2f(index, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2fv_t(uint index, IntPtr v);
		private static glVertexAttrib2fv_t p_glVertexAttrib2fv;
		public static void glVertexAttrib2fv(uint index, IntPtr v) => p_glVertexAttrib2fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2s_t(uint index, short x, short y);
		private static glVertexAttrib2s_t p_glVertexAttrib2s;
		public static void glVertexAttrib2s(uint index, short x, short y) => p_glVertexAttrib2s(index, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2sv_t(uint index, IntPtr v);
		private static glVertexAttrib2sv_t p_glVertexAttrib2sv;
		public static void glVertexAttrib2sv(uint index, IntPtr v) => p_glVertexAttrib2sv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3d_t(uint index, double x, double y, double z);
		private static glVertexAttrib3d_t p_glVertexAttrib3d;
		public static void glVertexAttrib3d(uint index, double x, double y, double z) => p_glVertexAttrib3d(index, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3dv_t(uint index, IntPtr v);
		private static glVertexAttrib3dv_t p_glVertexAttrib3dv;
		public static void glVertexAttrib3dv(uint index, IntPtr v) => p_glVertexAttrib3dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3f_t(uint index, float x, float y, float z);
		private static glVertexAttrib3f_t p_glVertexAttrib3f;
		public static void glVertexAttrib3f(uint index, float x, float y, float z) => p_glVertexAttrib3f(index, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3fv_t(uint index, IntPtr v);
		private static glVertexAttrib3fv_t p_glVertexAttrib3fv;
		public static void glVertexAttrib3fv(uint index, IntPtr v) => p_glVertexAttrib3fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3s_t(uint index, short x, short y, short z);
		private static glVertexAttrib3s_t p_glVertexAttrib3s;
		public static void glVertexAttrib3s(uint index, short x, short y, short z) => p_glVertexAttrib3s(index, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3sv_t(uint index, IntPtr v);
		private static glVertexAttrib3sv_t p_glVertexAttrib3sv;
		public static void glVertexAttrib3sv(uint index, IntPtr v) => p_glVertexAttrib3sv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4Nbv_t(uint index, IntPtr v);
		private static glVertexAttrib4Nbv_t p_glVertexAttrib4Nbv;
		public static void glVertexAttrib4Nbv(uint index, IntPtr v) => p_glVertexAttrib4Nbv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4Niv_t(uint index, IntPtr v);
		private static glVertexAttrib4Niv_t p_glVertexAttrib4Niv;
		public static void glVertexAttrib4Niv(uint index, IntPtr v) => p_glVertexAttrib4Niv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4Nsv_t(uint index, IntPtr v);
		private static glVertexAttrib4Nsv_t p_glVertexAttrib4Nsv;
		public static void glVertexAttrib4Nsv(uint index, IntPtr v) => p_glVertexAttrib4Nsv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4Nub_t(uint index, byte x, byte y, byte z, byte w);
		private static glVertexAttrib4Nub_t p_glVertexAttrib4Nub;
		public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) => p_glVertexAttrib4Nub(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4Nubv_t(uint index, IntPtr v);
		private static glVertexAttrib4Nubv_t p_glVertexAttrib4Nubv;
		public static void glVertexAttrib4Nubv(uint index, IntPtr v) => p_glVertexAttrib4Nubv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4Nuiv_t(uint index, IntPtr v);
		private static glVertexAttrib4Nuiv_t p_glVertexAttrib4Nuiv;
		public static void glVertexAttrib4Nuiv(uint index, IntPtr v) => p_glVertexAttrib4Nuiv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4Nusv_t(uint index, IntPtr v);
		private static glVertexAttrib4Nusv_t p_glVertexAttrib4Nusv;
		public static void glVertexAttrib4Nusv(uint index, IntPtr v) => p_glVertexAttrib4Nusv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4bv_t(uint index, IntPtr v);
		private static glVertexAttrib4bv_t p_glVertexAttrib4bv;
		public static void glVertexAttrib4bv(uint index, IntPtr v) => p_glVertexAttrib4bv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4d_t(uint index, double x, double y, double z, double w);
		private static glVertexAttrib4d_t p_glVertexAttrib4d;
		public static void glVertexAttrib4d(uint index, double x, double y, double z, double w) => p_glVertexAttrib4d(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4dv_t(uint index, IntPtr v);
		private static glVertexAttrib4dv_t p_glVertexAttrib4dv;
		public static void glVertexAttrib4dv(uint index, IntPtr v) => p_glVertexAttrib4dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4f_t(uint index, float x, float y, float z, float w);
		private static glVertexAttrib4f_t p_glVertexAttrib4f;
		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w) => p_glVertexAttrib4f(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4fv_t(uint index, IntPtr v);
		private static glVertexAttrib4fv_t p_glVertexAttrib4fv;
		public static void glVertexAttrib4fv(uint index, IntPtr v) => p_glVertexAttrib4fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4iv_t(uint index, IntPtr v);
		private static glVertexAttrib4iv_t p_glVertexAttrib4iv;
		public static void glVertexAttrib4iv(uint index, IntPtr v) => p_glVertexAttrib4iv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4s_t(uint index, short x, short y, short z, short w);
		private static glVertexAttrib4s_t p_glVertexAttrib4s;
		public static void glVertexAttrib4s(uint index, short x, short y, short z, short w) => p_glVertexAttrib4s(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4sv_t(uint index, IntPtr v);
		private static glVertexAttrib4sv_t p_glVertexAttrib4sv;
		public static void glVertexAttrib4sv(uint index, IntPtr v) => p_glVertexAttrib4sv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4ubv_t(uint index, IntPtr v);
		private static glVertexAttrib4ubv_t p_glVertexAttrib4ubv;
		public static void glVertexAttrib4ubv(uint index, IntPtr v) => p_glVertexAttrib4ubv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4uiv_t(uint index, IntPtr v);
		private static glVertexAttrib4uiv_t p_glVertexAttrib4uiv;
		public static void glVertexAttrib4uiv(uint index, IntPtr v) => p_glVertexAttrib4uiv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4usv_t(uint index, IntPtr v);
		private static glVertexAttrib4usv_t p_glVertexAttrib4usv;
		public static void glVertexAttrib4usv(uint index, IntPtr v) => p_glVertexAttrib4usv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribPointer_t(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);
		private static glVertexAttribPointer_t p_glVertexAttribPointer;
		public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer) => p_glVertexAttribPointer(index, size, type, normalized, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2x3fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix2x3fv_t p_glUniformMatrix2x3fv;
		public static void glUniformMatrix2x3fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix2x3fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3x2fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix3x2fv_t p_glUniformMatrix3x2fv;
		public static void glUniformMatrix3x2fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix3x2fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2x4fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix2x4fv_t p_glUniformMatrix2x4fv;
		public static void glUniformMatrix2x4fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix2x4fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4x2fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix4x2fv_t p_glUniformMatrix4x2fv;
		public static void glUniformMatrix4x2fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix4x2fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3x4fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix3x4fv_t p_glUniformMatrix3x4fv;
		public static void glUniformMatrix3x4fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix3x4fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4x3fv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix4x3fv_t p_glUniformMatrix4x3fv;
		public static void glUniformMatrix4x3fv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix4x3fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorMaski_t(uint index, bool r, bool g, bool b, bool a);
		private static glColorMaski_t p_glColorMaski;
		public static void glColorMaski(uint index, bool r, bool g, bool b, bool a) => p_glColorMaski(index, r, g, b, a);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBooleani_v_t(uint target, uint index, IntPtr data);
		private static glGetBooleani_v_t p_glGetBooleani_v;
		public static void glGetBooleani_v(uint target, uint index, IntPtr data) => p_glGetBooleani_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetIntegeri_v_t(uint target, uint index, IntPtr data);
		private static glGetIntegeri_v_t p_glGetIntegeri_v;
		public static void glGetIntegeri_v(uint target, uint index, IntPtr data) => p_glGetIntegeri_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEnablei_t(uint target, uint index);
		private static glEnablei_t p_glEnablei;
		public static void glEnablei(uint target, uint index) => p_glEnablei(target, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDisablei_t(uint target, uint index);
		private static glDisablei_t p_glDisablei;
		public static void glDisablei(uint target, uint index) => p_glDisablei(target, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsEnabledi_t(uint target, uint index);
		private static glIsEnabledi_t p_glIsEnabledi;
		public static bool glIsEnabledi(uint target, uint index) => p_glIsEnabledi(target, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBeginTransformFeedback_t(uint primitiveMode);
		private static glBeginTransformFeedback_t p_glBeginTransformFeedback;
		public static void glBeginTransformFeedback(uint primitiveMode) => p_glBeginTransformFeedback(primitiveMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEndTransformFeedback_t();
		private static glEndTransformFeedback_t p_glEndTransformFeedback;
		public static void glEndTransformFeedback() => p_glEndTransformFeedback();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBufferRange_t(uint target, uint index, uint buffer, IntPtr offset, int size);
		private static glBindBufferRange_t p_glBindBufferRange;
		public static void glBindBufferRange(uint target, uint index, uint buffer, IntPtr offset, int size) => p_glBindBufferRange(target, index, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBufferBase_t(uint target, uint index, uint buffer);
		private static glBindBufferBase_t p_glBindBufferBase;
		public static void glBindBufferBase(uint target, uint index, uint buffer) => p_glBindBufferBase(target, index, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTransformFeedbackVaryings_t(uint program, int count, IntPtr varyings, uint bufferMode);
		private static glTransformFeedbackVaryings_t p_glTransformFeedbackVaryings;
		public static void glTransformFeedbackVaryings(uint program, int count, IntPtr varyings, uint bufferMode) => p_glTransformFeedbackVaryings(program, count, varyings, bufferMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTransformFeedbackVarying_t(uint program, uint index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name);
		private static glGetTransformFeedbackVarying_t p_glGetTransformFeedbackVarying;
		public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name) => p_glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClampColor_t(uint target, uint clamp);
		private static glClampColor_t p_glClampColor;
		public static void glClampColor(uint target, uint clamp) => p_glClampColor(target, clamp);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBeginConditionalRender_t(uint id, uint mode);
		private static glBeginConditionalRender_t p_glBeginConditionalRender;
		public static void glBeginConditionalRender(uint id, uint mode) => p_glBeginConditionalRender(id, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEndConditionalRender_t();
		private static glEndConditionalRender_t p_glEndConditionalRender;
		public static void glEndConditionalRender() => p_glEndConditionalRender();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribIPointer_t(uint index, int size, uint type, int stride, IntPtr pointer);
		private static glVertexAttribIPointer_t p_glVertexAttribIPointer;
		public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer) => p_glVertexAttribIPointer(index, size, type, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribIiv_t(uint index, uint pname, IntPtr @params);
		private static glGetVertexAttribIiv_t p_glGetVertexAttribIiv;
		public static void glGetVertexAttribIiv(uint index, uint pname, IntPtr @params) => p_glGetVertexAttribIiv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribIuiv_t(uint index, uint pname, IntPtr @params);
		private static glGetVertexAttribIuiv_t p_glGetVertexAttribIuiv;
		public static void glGetVertexAttribIuiv(uint index, uint pname, IntPtr @params) => p_glGetVertexAttribIuiv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI1i_t(uint index, int x);
		private static glVertexAttribI1i_t p_glVertexAttribI1i;
		public static void glVertexAttribI1i(uint index, int x) => p_glVertexAttribI1i(index, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI2i_t(uint index, int x, int y);
		private static glVertexAttribI2i_t p_glVertexAttribI2i;
		public static void glVertexAttribI2i(uint index, int x, int y) => p_glVertexAttribI2i(index, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI3i_t(uint index, int x, int y, int z);
		private static glVertexAttribI3i_t p_glVertexAttribI3i;
		public static void glVertexAttribI3i(uint index, int x, int y, int z) => p_glVertexAttribI3i(index, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4i_t(uint index, int x, int y, int z, int w);
		private static glVertexAttribI4i_t p_glVertexAttribI4i;
		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w) => p_glVertexAttribI4i(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI1ui_t(uint index, uint x);
		private static glVertexAttribI1ui_t p_glVertexAttribI1ui;
		public static void glVertexAttribI1ui(uint index, uint x) => p_glVertexAttribI1ui(index, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI2ui_t(uint index, uint x, uint y);
		private static glVertexAttribI2ui_t p_glVertexAttribI2ui;
		public static void glVertexAttribI2ui(uint index, uint x, uint y) => p_glVertexAttribI2ui(index, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI3ui_t(uint index, uint x, uint y, uint z);
		private static glVertexAttribI3ui_t p_glVertexAttribI3ui;
		public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z) => p_glVertexAttribI3ui(index, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4ui_t(uint index, uint x, uint y, uint z, uint w);
		private static glVertexAttribI4ui_t p_glVertexAttribI4ui;
		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => p_glVertexAttribI4ui(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI1iv_t(uint index, IntPtr v);
		private static glVertexAttribI1iv_t p_glVertexAttribI1iv;
		public static void glVertexAttribI1iv(uint index, IntPtr v) => p_glVertexAttribI1iv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI2iv_t(uint index, IntPtr v);
		private static glVertexAttribI2iv_t p_glVertexAttribI2iv;
		public static void glVertexAttribI2iv(uint index, IntPtr v) => p_glVertexAttribI2iv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI3iv_t(uint index, IntPtr v);
		private static glVertexAttribI3iv_t p_glVertexAttribI3iv;
		public static void glVertexAttribI3iv(uint index, IntPtr v) => p_glVertexAttribI3iv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4iv_t(uint index, IntPtr v);
		private static glVertexAttribI4iv_t p_glVertexAttribI4iv;
		public static void glVertexAttribI4iv(uint index, IntPtr v) => p_glVertexAttribI4iv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI1uiv_t(uint index, IntPtr v);
		private static glVertexAttribI1uiv_t p_glVertexAttribI1uiv;
		public static void glVertexAttribI1uiv(uint index, IntPtr v) => p_glVertexAttribI1uiv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI2uiv_t(uint index, IntPtr v);
		private static glVertexAttribI2uiv_t p_glVertexAttribI2uiv;
		public static void glVertexAttribI2uiv(uint index, IntPtr v) => p_glVertexAttribI2uiv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI3uiv_t(uint index, IntPtr v);
		private static glVertexAttribI3uiv_t p_glVertexAttribI3uiv;
		public static void glVertexAttribI3uiv(uint index, IntPtr v) => p_glVertexAttribI3uiv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4uiv_t(uint index, IntPtr v);
		private static glVertexAttribI4uiv_t p_glVertexAttribI4uiv;
		public static void glVertexAttribI4uiv(uint index, IntPtr v) => p_glVertexAttribI4uiv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4bv_t(uint index, IntPtr v);
		private static glVertexAttribI4bv_t p_glVertexAttribI4bv;
		public static void glVertexAttribI4bv(uint index, IntPtr v) => p_glVertexAttribI4bv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4sv_t(uint index, IntPtr v);
		private static glVertexAttribI4sv_t p_glVertexAttribI4sv;
		public static void glVertexAttribI4sv(uint index, IntPtr v) => p_glVertexAttribI4sv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4ubv_t(uint index, IntPtr v);
		private static glVertexAttribI4ubv_t p_glVertexAttribI4ubv;
		public static void glVertexAttribI4ubv(uint index, IntPtr v) => p_glVertexAttribI4ubv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4usv_t(uint index, IntPtr v);
		private static glVertexAttribI4usv_t p_glVertexAttribI4usv;
		public static void glVertexAttribI4usv(uint index, IntPtr v) => p_glVertexAttribI4usv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformuiv_t(uint program, int location, IntPtr @params);
		private static glGetUniformuiv_t p_glGetUniformuiv;
		public static void glGetUniformuiv(uint program, int location, IntPtr @params) => p_glGetUniformuiv(program, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindFragDataLocation_t(uint program, uint color, IntPtr name);
		private static glBindFragDataLocation_t p_glBindFragDataLocation;
		public static void glBindFragDataLocation(uint program, uint color, IntPtr name) => p_glBindFragDataLocation(program, color, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetFragDataLocation_t(uint program, IntPtr name);
		private static glGetFragDataLocation_t p_glGetFragDataLocation;
		public static int glGetFragDataLocation(uint program, IntPtr name) => p_glGetFragDataLocation(program, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1ui_t(int location, uint v0);
		private static glUniform1ui_t p_glUniform1ui;
		public static void glUniform1ui(int location, uint v0) => p_glUniform1ui(location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2ui_t(int location, uint v0, uint v1);
		private static glUniform2ui_t p_glUniform2ui;
		public static void glUniform2ui(int location, uint v0, uint v1) => p_glUniform2ui(location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3ui_t(int location, uint v0, uint v1, uint v2);
		private static glUniform3ui_t p_glUniform3ui;
		public static void glUniform3ui(int location, uint v0, uint v1, uint v2) => p_glUniform3ui(location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4ui_t(int location, uint v0, uint v1, uint v2, uint v3);
		private static glUniform4ui_t p_glUniform4ui;
		public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => p_glUniform4ui(location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1uiv_t(int location, int count, IntPtr value);
		private static glUniform1uiv_t p_glUniform1uiv;
		public static void glUniform1uiv(int location, int count, IntPtr value) => p_glUniform1uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2uiv_t(int location, int count, IntPtr value);
		private static glUniform2uiv_t p_glUniform2uiv;
		public static void glUniform2uiv(int location, int count, IntPtr value) => p_glUniform2uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3uiv_t(int location, int count, IntPtr value);
		private static glUniform3uiv_t p_glUniform3uiv;
		public static void glUniform3uiv(int location, int count, IntPtr value) => p_glUniform3uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4uiv_t(int location, int count, IntPtr value);
		private static glUniform4uiv_t p_glUniform4uiv;
		public static void glUniform4uiv(int location, int count, IntPtr value) => p_glUniform4uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterIiv_t(uint target, uint pname, IntPtr @params);
		private static glTexParameterIiv_t p_glTexParameterIiv;
		public static void glTexParameterIiv(uint target, uint pname, IntPtr @params) => p_glTexParameterIiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterIuiv_t(uint target, uint pname, IntPtr @params);
		private static glTexParameterIuiv_t p_glTexParameterIuiv;
		public static void glTexParameterIuiv(uint target, uint pname, IntPtr @params) => p_glTexParameterIuiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameterIiv_t(uint target, uint pname, IntPtr @params);
		private static glGetTexParameterIiv_t p_glGetTexParameterIiv;
		public static void glGetTexParameterIiv(uint target, uint pname, IntPtr @params) => p_glGetTexParameterIiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameterIuiv_t(uint target, uint pname, IntPtr @params);
		private static glGetTexParameterIuiv_t p_glGetTexParameterIuiv;
		public static void glGetTexParameterIuiv(uint target, uint pname, IntPtr @params) => p_glGetTexParameterIuiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferiv_t(uint buffer, int drawbuffer, IntPtr value);
		private static glClearBufferiv_t p_glClearBufferiv;
		public static void glClearBufferiv(uint buffer, int drawbuffer, IntPtr value) => p_glClearBufferiv(buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferuiv_t(uint buffer, int drawbuffer, IntPtr value);
		private static glClearBufferuiv_t p_glClearBufferuiv;
		public static void glClearBufferuiv(uint buffer, int drawbuffer, IntPtr value) => p_glClearBufferuiv(buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferfv_t(uint buffer, int drawbuffer, IntPtr value);
		private static glClearBufferfv_t p_glClearBufferfv;
		public static void glClearBufferfv(uint buffer, int drawbuffer, IntPtr value) => p_glClearBufferfv(buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferfi_t(uint buffer, int drawbuffer, float depth, int stencil);
		private static glClearBufferfi_t p_glClearBufferfi;
		public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) => p_glClearBufferfi(buffer, drawbuffer, depth, stencil);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glGetStringi_t(uint name, uint index);
		private static glGetStringi_t p_glGetStringi;
		public static IntPtr glGetStringi(uint name, uint index) => p_glGetStringi(name, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsRenderbuffer_t(uint renderbuffer);
		private static glIsRenderbuffer_t p_glIsRenderbuffer;
		public static bool glIsRenderbuffer(uint renderbuffer) => p_glIsRenderbuffer(renderbuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindRenderbuffer_t(uint target, uint renderbuffer);
		private static glBindRenderbuffer_t p_glBindRenderbuffer;
		public static void glBindRenderbuffer(uint target, uint renderbuffer) => p_glBindRenderbuffer(target, renderbuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteRenderbuffers_t(int n, IntPtr renderbuffers);
		private static glDeleteRenderbuffers_t p_glDeleteRenderbuffers;
		public static void glDeleteRenderbuffers(int n, IntPtr renderbuffers) => p_glDeleteRenderbuffers(n, renderbuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenRenderbuffers_t(int n, IntPtr renderbuffers);
		private static glGenRenderbuffers_t p_glGenRenderbuffers;
		public static void glGenRenderbuffers(int n, IntPtr renderbuffers) => p_glGenRenderbuffers(n, renderbuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glRenderbufferStorage_t(uint target, uint internalformat, int width, int height);
		private static glRenderbufferStorage_t p_glRenderbufferStorage;
		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height) => p_glRenderbufferStorage(target, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetRenderbufferParameteriv_t(uint target, uint pname, IntPtr @params);
		private static glGetRenderbufferParameteriv_t p_glGetRenderbufferParameteriv;
		public static void glGetRenderbufferParameteriv(uint target, uint pname, IntPtr @params) => p_glGetRenderbufferParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsFramebuffer_t(uint framebuffer);
		private static glIsFramebuffer_t p_glIsFramebuffer;
		public static bool glIsFramebuffer(uint framebuffer) => p_glIsFramebuffer(framebuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindFramebuffer_t(uint target, uint framebuffer);
		private static glBindFramebuffer_t p_glBindFramebuffer;
		public static void glBindFramebuffer(uint target, uint framebuffer) => p_glBindFramebuffer(target, framebuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteFramebuffers_t(int n, IntPtr framebuffers);
		private static glDeleteFramebuffers_t p_glDeleteFramebuffers;
		public static void glDeleteFramebuffers(int n, IntPtr framebuffers) => p_glDeleteFramebuffers(n, framebuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenFramebuffers_t(int n, IntPtr framebuffers);
		private static glGenFramebuffers_t p_glGenFramebuffers;
		public static void glGenFramebuffers(int n, IntPtr framebuffers) => p_glGenFramebuffers(n, framebuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCheckFramebufferStatus_t(uint target);
		private static glCheckFramebufferStatus_t p_glCheckFramebufferStatus;
		public static uint glCheckFramebufferStatus(uint target) => p_glCheckFramebufferStatus(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTexture1D_t(uint target, uint attachment, uint textarget, uint texture, int level);
		private static glFramebufferTexture1D_t p_glFramebufferTexture1D;
		public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) => p_glFramebufferTexture1D(target, attachment, textarget, texture, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTexture2D_t(uint target, uint attachment, uint textarget, uint texture, int level);
		private static glFramebufferTexture2D_t p_glFramebufferTexture2D;
		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) => p_glFramebufferTexture2D(target, attachment, textarget, texture, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTexture3D_t(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
		private static glFramebufferTexture3D_t p_glFramebufferTexture3D;
		public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) => p_glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferRenderbuffer_t(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private static glFramebufferRenderbuffer_t p_glFramebufferRenderbuffer;
		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) => p_glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFramebufferAttachmentParameteriv_t(uint target, uint attachment, uint pname, IntPtr @params);
		private static glGetFramebufferAttachmentParameteriv_t p_glGetFramebufferAttachmentParameteriv;
		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, IntPtr @params) => p_glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenerateMipmap_t(uint target);
		private static glGenerateMipmap_t p_glGenerateMipmap;
		public static void glGenerateMipmap(uint target) => p_glGenerateMipmap(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlitFramebuffer_t(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private static glBlitFramebuffer_t p_glBlitFramebuffer;
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) => p_glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glRenderbufferStorageMultisample_t(uint target, int samples, uint internalformat, int width, int height);
		private static glRenderbufferStorageMultisample_t p_glRenderbufferStorageMultisample;
		public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) => p_glRenderbufferStorageMultisample(target, samples, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTextureLayer_t(uint target, uint attachment, uint texture, int level, int layer);
		private static glFramebufferTextureLayer_t p_glFramebufferTextureLayer;
		public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) => p_glFramebufferTextureLayer(target, attachment, texture, level, layer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glMapBufferRange_t(uint target, IntPtr offset, int length, uint access);
		private static glMapBufferRange_t p_glMapBufferRange;
		public static IntPtr glMapBufferRange(uint target, IntPtr offset, int length, uint access) => p_glMapBufferRange(target, offset, length, access);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFlushMappedBufferRange_t(uint target, IntPtr offset, int length);
		private static glFlushMappedBufferRange_t p_glFlushMappedBufferRange;
		public static void glFlushMappedBufferRange(uint target, IntPtr offset, int length) => p_glFlushMappedBufferRange(target, offset, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindVertexArray_t(uint array);
		private static glBindVertexArray_t p_glBindVertexArray;
		public static void glBindVertexArray(uint array) => p_glBindVertexArray(array);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteVertexArrays_t(int n, IntPtr arrays);
		private static glDeleteVertexArrays_t p_glDeleteVertexArrays;
		public static void glDeleteVertexArrays(int n, IntPtr arrays) => p_glDeleteVertexArrays(n, arrays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenVertexArrays_t(int n, IntPtr arrays);
		private static glGenVertexArrays_t p_glGenVertexArrays;
		public static void glGenVertexArrays(int n, IntPtr arrays) => p_glGenVertexArrays(n, arrays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsVertexArray_t(uint array);
		private static glIsVertexArray_t p_glIsVertexArray;
		public static bool glIsVertexArray(uint array) => p_glIsVertexArray(array);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawArraysInstanced_t(uint mode, int first, int count, int instancecount);
		private static glDrawArraysInstanced_t p_glDrawArraysInstanced;
		public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount) => p_glDrawArraysInstanced(mode, first, count, instancecount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsInstanced_t(uint mode, int count, uint type, IntPtr indices, int instancecount);
		private static glDrawElementsInstanced_t p_glDrawElementsInstanced;
		public static void glDrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount) => p_glDrawElementsInstanced(mode, count, type, indices, instancecount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexBuffer_t(uint target, uint internalformat, uint buffer);
		private static glTexBuffer_t p_glTexBuffer;
		public static void glTexBuffer(uint target, uint internalformat, uint buffer) => p_glTexBuffer(target, internalformat, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPrimitiveRestartIndex_t(uint index);
		private static glPrimitiveRestartIndex_t p_glPrimitiveRestartIndex;
		public static void glPrimitiveRestartIndex(uint index) => p_glPrimitiveRestartIndex(index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyBufferSubData_t(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, int size);
		private static glCopyBufferSubData_t p_glCopyBufferSubData;
		public static void glCopyBufferSubData(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, int size) => p_glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformIndices_t(uint program, int uniformCount, IntPtr uniformNames, IntPtr uniformIndices);
		private static glGetUniformIndices_t p_glGetUniformIndices;
		public static void glGetUniformIndices(uint program, int uniformCount, IntPtr uniformNames, IntPtr uniformIndices) => p_glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniformsiv_t(uint program, int uniformCount, IntPtr uniformIndices, uint pname, IntPtr @params);
		private static glGetActiveUniformsiv_t p_glGetActiveUniformsiv;
		public static void glGetActiveUniformsiv(uint program, int uniformCount, IntPtr uniformIndices, uint pname, IntPtr @params) => p_glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniformName_t(uint program, uint uniformIndex, int bufSize, IntPtr length, IntPtr uniformName);
		private static glGetActiveUniformName_t p_glGetActiveUniformName;
		public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, IntPtr length, IntPtr uniformName) => p_glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetUniformBlockIndex_t(uint program, IntPtr uniformBlockName);
		private static glGetUniformBlockIndex_t p_glGetUniformBlockIndex;
		public static uint glGetUniformBlockIndex(uint program, IntPtr uniformBlockName) => p_glGetUniformBlockIndex(program, uniformBlockName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniformBlockiv_t(uint program, uint uniformBlockIndex, uint pname, IntPtr @params);
		private static glGetActiveUniformBlockiv_t p_glGetActiveUniformBlockiv;
		public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, IntPtr @params) => p_glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniformBlockName_t(uint program, uint uniformBlockIndex, int bufSize, IntPtr length, IntPtr uniformBlockName);
		private static glGetActiveUniformBlockName_t p_glGetActiveUniformBlockName;
		public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, IntPtr length, IntPtr uniformBlockName) => p_glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformBlockBinding_t(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
		private static glUniformBlockBinding_t p_glUniformBlockBinding;
		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) => p_glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsBaseVertex_t(uint mode, int count, uint type, IntPtr indices, int basevertex);
		private static glDrawElementsBaseVertex_t p_glDrawElementsBaseVertex;
		public static void glDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex) => p_glDrawElementsBaseVertex(mode, count, type, indices, basevertex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawRangeElementsBaseVertex_t(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);
		private static glDrawRangeElementsBaseVertex_t p_glDrawRangeElementsBaseVertex;
		public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex) => p_glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsInstancedBaseVertex_t(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);
		private static glDrawElementsInstancedBaseVertex_t p_glDrawElementsInstancedBaseVertex;
		public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex) => p_glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiDrawElementsBaseVertex_t(uint mode, IntPtr count, uint type, IntPtr indices, int drawcount, IntPtr basevertex);
		private static glMultiDrawElementsBaseVertex_t p_glMultiDrawElementsBaseVertex;
		public static void glMultiDrawElementsBaseVertex(uint mode, IntPtr count, uint type, IntPtr indices, int drawcount, IntPtr basevertex) => p_glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProvokingVertex_t(uint mode);
		private static glProvokingVertex_t p_glProvokingVertex;
		public static void glProvokingVertex(uint mode) => p_glProvokingVertex(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glFenceSync_t(uint condition, uint flags);
		private static glFenceSync_t p_glFenceSync;
		public static IntPtr glFenceSync(uint condition, uint flags) => p_glFenceSync(condition, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsSync_t(IntPtr sync);
		private static glIsSync_t p_glIsSync;
		public static bool glIsSync(IntPtr sync) => p_glIsSync(sync);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteSync_t(IntPtr sync);
		private static glDeleteSync_t p_glDeleteSync;
		public static void glDeleteSync(IntPtr sync) => p_glDeleteSync(sync);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glClientWaitSync_t(IntPtr sync, uint flags, ulong timeout);
		private static glClientWaitSync_t p_glClientWaitSync;
		public static uint glClientWaitSync(IntPtr sync, uint flags, ulong timeout) => p_glClientWaitSync(sync, flags, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glWaitSync_t(IntPtr sync, uint flags, ulong timeout);
		private static glWaitSync_t p_glWaitSync;
		public static void glWaitSync(IntPtr sync, uint flags, ulong timeout) => p_glWaitSync(sync, flags, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetInteger64v_t(uint pname, IntPtr data);
		private static glGetInteger64v_t p_glGetInteger64v;
		public static void glGetInteger64v(uint pname, IntPtr data) => p_glGetInteger64v(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSynciv_t(IntPtr sync, uint pname, int bufSize, IntPtr length, IntPtr values);
		private static glGetSynciv_t p_glGetSynciv;
		public static void glGetSynciv(IntPtr sync, uint pname, int bufSize, IntPtr length, IntPtr values) => p_glGetSynciv(sync, pname, bufSize, length, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetInteger64i_v_t(uint target, uint index, IntPtr data);
		private static glGetInteger64i_v_t p_glGetInteger64i_v;
		public static void glGetInteger64i_v(uint target, uint index, IntPtr data) => p_glGetInteger64i_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBufferParameteri64v_t(uint target, uint pname, IntPtr @params);
		private static glGetBufferParameteri64v_t p_glGetBufferParameteri64v;
		public static void glGetBufferParameteri64v(uint target, uint pname, IntPtr @params) => p_glGetBufferParameteri64v(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTexture_t(uint target, uint attachment, uint texture, int level);
		private static glFramebufferTexture_t p_glFramebufferTexture;
		public static void glFramebufferTexture(uint target, uint attachment, uint texture, int level) => p_glFramebufferTexture(target, attachment, texture, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexImage2DMultisample_t(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private static glTexImage2DMultisample_t p_glTexImage2DMultisample;
		public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) => p_glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexImage3DMultisample_t(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private static glTexImage3DMultisample_t p_glTexImage3DMultisample;
		public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) => p_glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetMultisamplefv_t(uint pname, uint index, IntPtr val);
		private static glGetMultisamplefv_t p_glGetMultisamplefv;
		public static void glGetMultisamplefv(uint pname, uint index, IntPtr val) => p_glGetMultisamplefv(pname, index, val);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSampleMaski_t(uint maskNumber, uint mask);
		private static glSampleMaski_t p_glSampleMaski;
		public static void glSampleMaski(uint maskNumber, uint mask) => p_glSampleMaski(maskNumber, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindFragDataLocationIndexed_t(uint program, uint colorNumber, uint index, IntPtr name);
		private static glBindFragDataLocationIndexed_t p_glBindFragDataLocationIndexed;
		public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, IntPtr name) => p_glBindFragDataLocationIndexed(program, colorNumber, index, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetFragDataIndex_t(uint program, IntPtr name);
		private static glGetFragDataIndex_t p_glGetFragDataIndex;
		public static int glGetFragDataIndex(uint program, IntPtr name) => p_glGetFragDataIndex(program, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenSamplers_t(int count, IntPtr samplers);
		private static glGenSamplers_t p_glGenSamplers;
		public static void glGenSamplers(int count, IntPtr samplers) => p_glGenSamplers(count, samplers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteSamplers_t(int count, IntPtr samplers);
		private static glDeleteSamplers_t p_glDeleteSamplers;
		public static void glDeleteSamplers(int count, IntPtr samplers) => p_glDeleteSamplers(count, samplers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsSampler_t(uint sampler);
		private static glIsSampler_t p_glIsSampler;
		public static bool glIsSampler(uint sampler) => p_glIsSampler(sampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindSampler_t(uint unit, uint sampler);
		private static glBindSampler_t p_glBindSampler;
		public static void glBindSampler(uint unit, uint sampler) => p_glBindSampler(unit, sampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameteri_t(uint sampler, uint pname, int param);
		private static glSamplerParameteri_t p_glSamplerParameteri;
		public static void glSamplerParameteri(uint sampler, uint pname, int param) => p_glSamplerParameteri(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameteriv_t(uint sampler, uint pname, IntPtr param);
		private static glSamplerParameteriv_t p_glSamplerParameteriv;
		public static void glSamplerParameteriv(uint sampler, uint pname, IntPtr param) => p_glSamplerParameteriv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterf_t(uint sampler, uint pname, float param);
		private static glSamplerParameterf_t p_glSamplerParameterf;
		public static void glSamplerParameterf(uint sampler, uint pname, float param) => p_glSamplerParameterf(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterfv_t(uint sampler, uint pname, IntPtr param);
		private static glSamplerParameterfv_t p_glSamplerParameterfv;
		public static void glSamplerParameterfv(uint sampler, uint pname, IntPtr param) => p_glSamplerParameterfv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterIiv_t(uint sampler, uint pname, IntPtr param);
		private static glSamplerParameterIiv_t p_glSamplerParameterIiv;
		public static void glSamplerParameterIiv(uint sampler, uint pname, IntPtr param) => p_glSamplerParameterIiv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterIuiv_t(uint sampler, uint pname, IntPtr param);
		private static glSamplerParameterIuiv_t p_glSamplerParameterIuiv;
		public static void glSamplerParameterIuiv(uint sampler, uint pname, IntPtr param) => p_glSamplerParameterIuiv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameteriv_t(uint sampler, uint pname, IntPtr @params);
		private static glGetSamplerParameteriv_t p_glGetSamplerParameteriv;
		public static void glGetSamplerParameteriv(uint sampler, uint pname, IntPtr @params) => p_glGetSamplerParameteriv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameterIiv_t(uint sampler, uint pname, IntPtr @params);
		private static glGetSamplerParameterIiv_t p_glGetSamplerParameterIiv;
		public static void glGetSamplerParameterIiv(uint sampler, uint pname, IntPtr @params) => p_glGetSamplerParameterIiv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameterfv_t(uint sampler, uint pname, IntPtr @params);
		private static glGetSamplerParameterfv_t p_glGetSamplerParameterfv;
		public static void glGetSamplerParameterfv(uint sampler, uint pname, IntPtr @params) => p_glGetSamplerParameterfv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameterIuiv_t(uint sampler, uint pname, IntPtr @params);
		private static glGetSamplerParameterIuiv_t p_glGetSamplerParameterIuiv;
		public static void glGetSamplerParameterIuiv(uint sampler, uint pname, IntPtr @params) => p_glGetSamplerParameterIuiv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glQueryCounter_t(uint id, uint target);
		private static glQueryCounter_t p_glQueryCounter;
		public static void glQueryCounter(uint id, uint target) => p_glQueryCounter(id, target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryObjecti64v_t(uint id, uint pname, IntPtr @params);
		private static glGetQueryObjecti64v_t p_glGetQueryObjecti64v;
		public static void glGetQueryObjecti64v(uint id, uint pname, IntPtr @params) => p_glGetQueryObjecti64v(id, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryObjectui64v_t(uint id, uint pname, IntPtr @params);
		private static glGetQueryObjectui64v_t p_glGetQueryObjectui64v;
		public static void glGetQueryObjectui64v(uint id, uint pname, IntPtr @params) => p_glGetQueryObjectui64v(id, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribDivisor_t(uint index, uint divisor);
		private static glVertexAttribDivisor_t p_glVertexAttribDivisor;
		public static void glVertexAttribDivisor(uint index, uint divisor) => p_glVertexAttribDivisor(index, divisor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP1ui_t(uint index, uint type, bool normalized, uint value);
		private static glVertexAttribP1ui_t p_glVertexAttribP1ui;
		public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value) => p_glVertexAttribP1ui(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP1uiv_t(uint index, uint type, bool normalized, IntPtr value);
		private static glVertexAttribP1uiv_t p_glVertexAttribP1uiv;
		public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, IntPtr value) => p_glVertexAttribP1uiv(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP2ui_t(uint index, uint type, bool normalized, uint value);
		private static glVertexAttribP2ui_t p_glVertexAttribP2ui;
		public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value) => p_glVertexAttribP2ui(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP2uiv_t(uint index, uint type, bool normalized, IntPtr value);
		private static glVertexAttribP2uiv_t p_glVertexAttribP2uiv;
		public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, IntPtr value) => p_glVertexAttribP2uiv(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP3ui_t(uint index, uint type, bool normalized, uint value);
		private static glVertexAttribP3ui_t p_glVertexAttribP3ui;
		public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value) => p_glVertexAttribP3ui(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP3uiv_t(uint index, uint type, bool normalized, IntPtr value);
		private static glVertexAttribP3uiv_t p_glVertexAttribP3uiv;
		public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, IntPtr value) => p_glVertexAttribP3uiv(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP4ui_t(uint index, uint type, bool normalized, uint value);
		private static glVertexAttribP4ui_t p_glVertexAttribP4ui;
		public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value) => p_glVertexAttribP4ui(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribP4uiv_t(uint index, uint type, bool normalized, IntPtr value);
		private static glVertexAttribP4uiv_t p_glVertexAttribP4uiv;
		public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, IntPtr value) => p_glVertexAttribP4uiv(index, type, normalized, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexP2ui_t(uint type, uint value);
		private static glVertexP2ui_t p_glVertexP2ui;
		public static void glVertexP2ui(uint type, uint value) => p_glVertexP2ui(type, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexP2uiv_t(uint type, IntPtr value);
		private static glVertexP2uiv_t p_glVertexP2uiv;
		public static void glVertexP2uiv(uint type, IntPtr value) => p_glVertexP2uiv(type, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexP3ui_t(uint type, uint value);
		private static glVertexP3ui_t p_glVertexP3ui;
		public static void glVertexP3ui(uint type, uint value) => p_glVertexP3ui(type, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexP3uiv_t(uint type, IntPtr value);
		private static glVertexP3uiv_t p_glVertexP3uiv;
		public static void glVertexP3uiv(uint type, IntPtr value) => p_glVertexP3uiv(type, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexP4ui_t(uint type, uint value);
		private static glVertexP4ui_t p_glVertexP4ui;
		public static void glVertexP4ui(uint type, uint value) => p_glVertexP4ui(type, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexP4uiv_t(uint type, IntPtr value);
		private static glVertexP4uiv_t p_glVertexP4uiv;
		public static void glVertexP4uiv(uint type, IntPtr value) => p_glVertexP4uiv(type, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP1ui_t(uint type, uint coords);
		private static glTexCoordP1ui_t p_glTexCoordP1ui;
		public static void glTexCoordP1ui(uint type, uint coords) => p_glTexCoordP1ui(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP1uiv_t(uint type, IntPtr coords);
		private static glTexCoordP1uiv_t p_glTexCoordP1uiv;
		public static void glTexCoordP1uiv(uint type, IntPtr coords) => p_glTexCoordP1uiv(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP2ui_t(uint type, uint coords);
		private static glTexCoordP2ui_t p_glTexCoordP2ui;
		public static void glTexCoordP2ui(uint type, uint coords) => p_glTexCoordP2ui(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP2uiv_t(uint type, IntPtr coords);
		private static glTexCoordP2uiv_t p_glTexCoordP2uiv;
		public static void glTexCoordP2uiv(uint type, IntPtr coords) => p_glTexCoordP2uiv(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP3ui_t(uint type, uint coords);
		private static glTexCoordP3ui_t p_glTexCoordP3ui;
		public static void glTexCoordP3ui(uint type, uint coords) => p_glTexCoordP3ui(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP3uiv_t(uint type, IntPtr coords);
		private static glTexCoordP3uiv_t p_glTexCoordP3uiv;
		public static void glTexCoordP3uiv(uint type, IntPtr coords) => p_glTexCoordP3uiv(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP4ui_t(uint type, uint coords);
		private static glTexCoordP4ui_t p_glTexCoordP4ui;
		public static void glTexCoordP4ui(uint type, uint coords) => p_glTexCoordP4ui(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordP4uiv_t(uint type, IntPtr coords);
		private static glTexCoordP4uiv_t p_glTexCoordP4uiv;
		public static void glTexCoordP4uiv(uint type, IntPtr coords) => p_glTexCoordP4uiv(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP1ui_t(uint texture, uint type, uint coords);
		private static glMultiTexCoordP1ui_t p_glMultiTexCoordP1ui;
		public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords) => p_glMultiTexCoordP1ui(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP1uiv_t(uint texture, uint type, IntPtr coords);
		private static glMultiTexCoordP1uiv_t p_glMultiTexCoordP1uiv;
		public static void glMultiTexCoordP1uiv(uint texture, uint type, IntPtr coords) => p_glMultiTexCoordP1uiv(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP2ui_t(uint texture, uint type, uint coords);
		private static glMultiTexCoordP2ui_t p_glMultiTexCoordP2ui;
		public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords) => p_glMultiTexCoordP2ui(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP2uiv_t(uint texture, uint type, IntPtr coords);
		private static glMultiTexCoordP2uiv_t p_glMultiTexCoordP2uiv;
		public static void glMultiTexCoordP2uiv(uint texture, uint type, IntPtr coords) => p_glMultiTexCoordP2uiv(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP3ui_t(uint texture, uint type, uint coords);
		private static glMultiTexCoordP3ui_t p_glMultiTexCoordP3ui;
		public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords) => p_glMultiTexCoordP3ui(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP3uiv_t(uint texture, uint type, IntPtr coords);
		private static glMultiTexCoordP3uiv_t p_glMultiTexCoordP3uiv;
		public static void glMultiTexCoordP3uiv(uint texture, uint type, IntPtr coords) => p_glMultiTexCoordP3uiv(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP4ui_t(uint texture, uint type, uint coords);
		private static glMultiTexCoordP4ui_t p_glMultiTexCoordP4ui;
		public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords) => p_glMultiTexCoordP4ui(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoordP4uiv_t(uint texture, uint type, IntPtr coords);
		private static glMultiTexCoordP4uiv_t p_glMultiTexCoordP4uiv;
		public static void glMultiTexCoordP4uiv(uint texture, uint type, IntPtr coords) => p_glMultiTexCoordP4uiv(texture, type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNormalP3ui_t(uint type, uint coords);
		private static glNormalP3ui_t p_glNormalP3ui;
		public static void glNormalP3ui(uint type, uint coords) => p_glNormalP3ui(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNormalP3uiv_t(uint type, IntPtr coords);
		private static glNormalP3uiv_t p_glNormalP3uiv;
		public static void glNormalP3uiv(uint type, IntPtr coords) => p_glNormalP3uiv(type, coords);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorP3ui_t(uint type, uint color);
		private static glColorP3ui_t p_glColorP3ui;
		public static void glColorP3ui(uint type, uint color) => p_glColorP3ui(type, color);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorP3uiv_t(uint type, IntPtr color);
		private static glColorP3uiv_t p_glColorP3uiv;
		public static void glColorP3uiv(uint type, IntPtr color) => p_glColorP3uiv(type, color);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorP4ui_t(uint type, uint color);
		private static glColorP4ui_t p_glColorP4ui;
		public static void glColorP4ui(uint type, uint color) => p_glColorP4ui(type, color);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorP4uiv_t(uint type, IntPtr color);
		private static glColorP4uiv_t p_glColorP4uiv;
		public static void glColorP4uiv(uint type, IntPtr color) => p_glColorP4uiv(type, color);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSecondaryColorP3ui_t(uint type, uint color);
		private static glSecondaryColorP3ui_t p_glSecondaryColorP3ui;
		public static void glSecondaryColorP3ui(uint type, uint color) => p_glSecondaryColorP3ui(type, color);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSecondaryColorP3uiv_t(uint type, IntPtr color);
		private static glSecondaryColorP3uiv_t p_glSecondaryColorP3uiv;
		public static void glSecondaryColorP3uiv(uint type, IntPtr color) => p_glSecondaryColorP3uiv(type, color);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMinSampleShading_t(float value);
		private static glMinSampleShading_t p_glMinSampleShading;
		public static void glMinSampleShading(float value) => p_glMinSampleShading(value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquationi_t(uint buf, uint mode);
		private static glBlendEquationi_t p_glBlendEquationi;
		public static void glBlendEquationi(uint buf, uint mode) => p_glBlendEquationi(buf, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquationSeparatei_t(uint buf, uint modeRGB, uint modeAlpha);
		private static glBlendEquationSeparatei_t p_glBlendEquationSeparatei;
		public static void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha) => p_glBlendEquationSeparatei(buf, modeRGB, modeAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFunci_t(uint buf, uint src, uint dst);
		private static glBlendFunci_t p_glBlendFunci;
		public static void glBlendFunci(uint buf, uint src, uint dst) => p_glBlendFunci(buf, src, dst);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFuncSeparatei_t(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private static glBlendFuncSeparatei_t p_glBlendFuncSeparatei;
		public static void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) => p_glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawArraysIndirect_t(uint mode, IntPtr indirect);
		private static glDrawArraysIndirect_t p_glDrawArraysIndirect;
		public static void glDrawArraysIndirect(uint mode, IntPtr indirect) => p_glDrawArraysIndirect(mode, indirect);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsIndirect_t(uint mode, uint type, IntPtr indirect);
		private static glDrawElementsIndirect_t p_glDrawElementsIndirect;
		public static void glDrawElementsIndirect(uint mode, uint type, IntPtr indirect) => p_glDrawElementsIndirect(mode, type, indirect);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1d_t(int location, double x);
		private static glUniform1d_t p_glUniform1d;
		public static void glUniform1d(int location, double x) => p_glUniform1d(location, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2d_t(int location, double x, double y);
		private static glUniform2d_t p_glUniform2d;
		public static void glUniform2d(int location, double x, double y) => p_glUniform2d(location, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3d_t(int location, double x, double y, double z);
		private static glUniform3d_t p_glUniform3d;
		public static void glUniform3d(int location, double x, double y, double z) => p_glUniform3d(location, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4d_t(int location, double x, double y, double z, double w);
		private static glUniform4d_t p_glUniform4d;
		public static void glUniform4d(int location, double x, double y, double z, double w) => p_glUniform4d(location, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1dv_t(int location, int count, IntPtr value);
		private static glUniform1dv_t p_glUniform1dv;
		public static void glUniform1dv(int location, int count, IntPtr value) => p_glUniform1dv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2dv_t(int location, int count, IntPtr value);
		private static glUniform2dv_t p_glUniform2dv;
		public static void glUniform2dv(int location, int count, IntPtr value) => p_glUniform2dv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3dv_t(int location, int count, IntPtr value);
		private static glUniform3dv_t p_glUniform3dv;
		public static void glUniform3dv(int location, int count, IntPtr value) => p_glUniform3dv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4dv_t(int location, int count, IntPtr value);
		private static glUniform4dv_t p_glUniform4dv;
		public static void glUniform4dv(int location, int count, IntPtr value) => p_glUniform4dv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix2dv_t p_glUniformMatrix2dv;
		public static void glUniformMatrix2dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix2dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix3dv_t p_glUniformMatrix3dv;
		public static void glUniformMatrix3dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix3dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix4dv_t p_glUniformMatrix4dv;
		public static void glUniformMatrix4dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix4dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2x3dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix2x3dv_t p_glUniformMatrix2x3dv;
		public static void glUniformMatrix2x3dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix2x3dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2x4dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix2x4dv_t p_glUniformMatrix2x4dv;
		public static void glUniformMatrix2x4dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix2x4dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3x2dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix3x2dv_t p_glUniformMatrix3x2dv;
		public static void glUniformMatrix3x2dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix3x2dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3x4dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix3x4dv_t p_glUniformMatrix3x4dv;
		public static void glUniformMatrix3x4dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix3x4dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4x2dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix4x2dv_t p_glUniformMatrix4x2dv;
		public static void glUniformMatrix4x2dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix4x2dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4x3dv_t(int location, int count, bool transpose, IntPtr value);
		private static glUniformMatrix4x3dv_t p_glUniformMatrix4x3dv;
		public static void glUniformMatrix4x3dv(int location, int count, bool transpose, IntPtr value) => p_glUniformMatrix4x3dv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformdv_t(uint program, int location, IntPtr @params);
		private static glGetUniformdv_t p_glGetUniformdv;
		public static void glGetUniformdv(uint program, int location, IntPtr @params) => p_glGetUniformdv(program, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetSubroutineUniformLocation_t(uint program, uint shadertype, IntPtr name);
		private static glGetSubroutineUniformLocation_t p_glGetSubroutineUniformLocation;
		public static int glGetSubroutineUniformLocation(uint program, uint shadertype, IntPtr name) => p_glGetSubroutineUniformLocation(program, shadertype, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetSubroutineIndex_t(uint program, uint shadertype, IntPtr name);
		private static glGetSubroutineIndex_t p_glGetSubroutineIndex;
		public static uint glGetSubroutineIndex(uint program, uint shadertype, IntPtr name) => p_glGetSubroutineIndex(program, shadertype, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveSubroutineUniformiv_t(uint program, uint shadertype, uint index, uint pname, IntPtr values);
		private static glGetActiveSubroutineUniformiv_t p_glGetActiveSubroutineUniformiv;
		public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, IntPtr values) => p_glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveSubroutineUniformName_t(uint program, uint shadertype, uint index, int bufsize, IntPtr length, IntPtr name);
		private static glGetActiveSubroutineUniformName_t p_glGetActiveSubroutineUniformName;
		public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, IntPtr length, IntPtr name) => p_glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, length, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveSubroutineName_t(uint program, uint shadertype, uint index, int bufsize, IntPtr length, IntPtr name);
		private static glGetActiveSubroutineName_t p_glGetActiveSubroutineName;
		public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, IntPtr length, IntPtr name) => p_glGetActiveSubroutineName(program, shadertype, index, bufsize, length, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformSubroutinesuiv_t(uint shadertype, int count, IntPtr indices);
		private static glUniformSubroutinesuiv_t p_glUniformSubroutinesuiv;
		public static void glUniformSubroutinesuiv(uint shadertype, int count, IntPtr indices) => p_glUniformSubroutinesuiv(shadertype, count, indices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformSubroutineuiv_t(uint shadertype, int location, IntPtr @params);
		private static glGetUniformSubroutineuiv_t p_glGetUniformSubroutineuiv;
		public static void glGetUniformSubroutineuiv(uint shadertype, int location, IntPtr @params) => p_glGetUniformSubroutineuiv(shadertype, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramStageiv_t(uint program, uint shadertype, uint pname, IntPtr values);
		private static glGetProgramStageiv_t p_glGetProgramStageiv;
		public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, IntPtr values) => p_glGetProgramStageiv(program, shadertype, pname, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPatchParameteri_t(uint pname, int value);
		private static glPatchParameteri_t p_glPatchParameteri;
		public static void glPatchParameteri(uint pname, int value) => p_glPatchParameteri(pname, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPatchParameterfv_t(uint pname, IntPtr values);
		private static glPatchParameterfv_t p_glPatchParameterfv;
		public static void glPatchParameterfv(uint pname, IntPtr values) => p_glPatchParameterfv(pname, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindTransformFeedback_t(uint target, uint id);
		private static glBindTransformFeedback_t p_glBindTransformFeedback;
		public static void glBindTransformFeedback(uint target, uint id) => p_glBindTransformFeedback(target, id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteTransformFeedbacks_t(int n, IntPtr ids);
		private static glDeleteTransformFeedbacks_t p_glDeleteTransformFeedbacks;
		public static void glDeleteTransformFeedbacks(int n, IntPtr ids) => p_glDeleteTransformFeedbacks(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenTransformFeedbacks_t(int n, IntPtr ids);
		private static glGenTransformFeedbacks_t p_glGenTransformFeedbacks;
		public static void glGenTransformFeedbacks(int n, IntPtr ids) => p_glGenTransformFeedbacks(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsTransformFeedback_t(uint id);
		private static glIsTransformFeedback_t p_glIsTransformFeedback;
		public static bool glIsTransformFeedback(uint id) => p_glIsTransformFeedback(id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPauseTransformFeedback_t();
		private static glPauseTransformFeedback_t p_glPauseTransformFeedback;
		public static void glPauseTransformFeedback() => p_glPauseTransformFeedback();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glResumeTransformFeedback_t();
		private static glResumeTransformFeedback_t p_glResumeTransformFeedback;
		public static void glResumeTransformFeedback() => p_glResumeTransformFeedback();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawTransformFeedback_t(uint mode, uint id);
		private static glDrawTransformFeedback_t p_glDrawTransformFeedback;
		public static void glDrawTransformFeedback(uint mode, uint id) => p_glDrawTransformFeedback(mode, id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawTransformFeedbackStream_t(uint mode, uint id, uint stream);
		private static glDrawTransformFeedbackStream_t p_glDrawTransformFeedbackStream;
		public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream) => p_glDrawTransformFeedbackStream(mode, id, stream);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBeginQueryIndexed_t(uint target, uint index, uint id);
		private static glBeginQueryIndexed_t p_glBeginQueryIndexed;
		public static void glBeginQueryIndexed(uint target, uint index, uint id) => p_glBeginQueryIndexed(target, index, id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEndQueryIndexed_t(uint target, uint index);
		private static glEndQueryIndexed_t p_glEndQueryIndexed;
		public static void glEndQueryIndexed(uint target, uint index) => p_glEndQueryIndexed(target, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryIndexediv_t(uint target, uint index, uint pname, IntPtr @params);
		private static glGetQueryIndexediv_t p_glGetQueryIndexediv;
		public static void glGetQueryIndexediv(uint target, uint index, uint pname, IntPtr @params) => p_glGetQueryIndexediv(target, index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReleaseShaderCompiler_t();
		private static glReleaseShaderCompiler_t p_glReleaseShaderCompiler;
		public static void glReleaseShaderCompiler() => p_glReleaseShaderCompiler();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glShaderBinary_t(int count, IntPtr shaders, uint binaryformat, IntPtr binary, int length);
		private static glShaderBinary_t p_glShaderBinary;
		public static void glShaderBinary(int count, IntPtr shaders, uint binaryformat, IntPtr binary, int length) => p_glShaderBinary(count, shaders, binaryformat, binary, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderPrecisionFormat_t(uint shadertype, uint precisiontype, IntPtr range, IntPtr precision);
		private static glGetShaderPrecisionFormat_t p_glGetShaderPrecisionFormat;
		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, IntPtr range, IntPtr precision) => p_glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthRangef_t(float n, float f);
		private static glDepthRangef_t p_glDepthRangef;
		public static void glDepthRangef(float n, float f) => p_glDepthRangef(n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearDepthf_t(float d);
		private static glClearDepthf_t p_glClearDepthf;
		public static void glClearDepthf(float d) => p_glClearDepthf(d);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramBinary_t(uint program, int bufSize, IntPtr length, IntPtr binaryFormat, IntPtr binary);
		private static glGetProgramBinary_t p_glGetProgramBinary;
		public static void glGetProgramBinary(uint program, int bufSize, IntPtr length, IntPtr binaryFormat, IntPtr binary) => p_glGetProgramBinary(program, bufSize, length, binaryFormat, binary);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramBinary_t(uint program, uint binaryFormat, IntPtr binary, int length);
		private static glProgramBinary_t p_glProgramBinary;
		public static void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length) => p_glProgramBinary(program, binaryFormat, binary, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramParameteri_t(uint program, uint pname, int value);
		private static glProgramParameteri_t p_glProgramParameteri;
		public static void glProgramParameteri(uint program, uint pname, int value) => p_glProgramParameteri(program, pname, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUseProgramStages_t(uint pipeline, uint stages, uint program);
		private static glUseProgramStages_t p_glUseProgramStages;
		public static void glUseProgramStages(uint pipeline, uint stages, uint program) => p_glUseProgramStages(pipeline, stages, program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glActiveShaderProgram_t(uint pipeline, uint program);
		private static glActiveShaderProgram_t p_glActiveShaderProgram;
		public static void glActiveShaderProgram(uint pipeline, uint program) => p_glActiveShaderProgram(pipeline, program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCreateShaderProgramv_t(uint type, int count, IntPtr strings);
		private static glCreateShaderProgramv_t p_glCreateShaderProgramv;
		public static uint glCreateShaderProgramv(uint type, int count, IntPtr strings) => p_glCreateShaderProgramv(type, count, strings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindProgramPipeline_t(uint pipeline);
		private static glBindProgramPipeline_t p_glBindProgramPipeline;
		public static void glBindProgramPipeline(uint pipeline) => p_glBindProgramPipeline(pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteProgramPipelines_t(int n, IntPtr pipelines);
		private static glDeleteProgramPipelines_t p_glDeleteProgramPipelines;
		public static void glDeleteProgramPipelines(int n, IntPtr pipelines) => p_glDeleteProgramPipelines(n, pipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenProgramPipelines_t(int n, IntPtr pipelines);
		private static glGenProgramPipelines_t p_glGenProgramPipelines;
		public static void glGenProgramPipelines(int n, IntPtr pipelines) => p_glGenProgramPipelines(n, pipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsProgramPipeline_t(uint pipeline);
		private static glIsProgramPipeline_t p_glIsProgramPipeline;
		public static bool glIsProgramPipeline(uint pipeline) => p_glIsProgramPipeline(pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramPipelineiv_t(uint pipeline, uint pname, IntPtr @params);
		private static glGetProgramPipelineiv_t p_glGetProgramPipelineiv;
		public static void glGetProgramPipelineiv(uint pipeline, uint pname, IntPtr @params) => p_glGetProgramPipelineiv(pipeline, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1i_t(uint program, int location, int v0);
		private static glProgramUniform1i_t p_glProgramUniform1i;
		public static void glProgramUniform1i(uint program, int location, int v0) => p_glProgramUniform1i(program, location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1iv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform1iv_t p_glProgramUniform1iv;
		public static void glProgramUniform1iv(uint program, int location, int count, IntPtr value) => p_glProgramUniform1iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1f_t(uint program, int location, float v0);
		private static glProgramUniform1f_t p_glProgramUniform1f;
		public static void glProgramUniform1f(uint program, int location, float v0) => p_glProgramUniform1f(program, location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1fv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform1fv_t p_glProgramUniform1fv;
		public static void glProgramUniform1fv(uint program, int location, int count, IntPtr value) => p_glProgramUniform1fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1d_t(uint program, int location, double v0);
		private static glProgramUniform1d_t p_glProgramUniform1d;
		public static void glProgramUniform1d(uint program, int location, double v0) => p_glProgramUniform1d(program, location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1dv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform1dv_t p_glProgramUniform1dv;
		public static void glProgramUniform1dv(uint program, int location, int count, IntPtr value) => p_glProgramUniform1dv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1ui_t(uint program, int location, uint v0);
		private static glProgramUniform1ui_t p_glProgramUniform1ui;
		public static void glProgramUniform1ui(uint program, int location, uint v0) => p_glProgramUniform1ui(program, location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1uiv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform1uiv_t p_glProgramUniform1uiv;
		public static void glProgramUniform1uiv(uint program, int location, int count, IntPtr value) => p_glProgramUniform1uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2i_t(uint program, int location, int v0, int v1);
		private static glProgramUniform2i_t p_glProgramUniform2i;
		public static void glProgramUniform2i(uint program, int location, int v0, int v1) => p_glProgramUniform2i(program, location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2iv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform2iv_t p_glProgramUniform2iv;
		public static void glProgramUniform2iv(uint program, int location, int count, IntPtr value) => p_glProgramUniform2iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2f_t(uint program, int location, float v0, float v1);
		private static glProgramUniform2f_t p_glProgramUniform2f;
		public static void glProgramUniform2f(uint program, int location, float v0, float v1) => p_glProgramUniform2f(program, location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2fv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform2fv_t p_glProgramUniform2fv;
		public static void glProgramUniform2fv(uint program, int location, int count, IntPtr value) => p_glProgramUniform2fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2d_t(uint program, int location, double v0, double v1);
		private static glProgramUniform2d_t p_glProgramUniform2d;
		public static void glProgramUniform2d(uint program, int location, double v0, double v1) => p_glProgramUniform2d(program, location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2dv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform2dv_t p_glProgramUniform2dv;
		public static void glProgramUniform2dv(uint program, int location, int count, IntPtr value) => p_glProgramUniform2dv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2ui_t(uint program, int location, uint v0, uint v1);
		private static glProgramUniform2ui_t p_glProgramUniform2ui;
		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1) => p_glProgramUniform2ui(program, location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2uiv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform2uiv_t p_glProgramUniform2uiv;
		public static void glProgramUniform2uiv(uint program, int location, int count, IntPtr value) => p_glProgramUniform2uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3i_t(uint program, int location, int v0, int v1, int v2);
		private static glProgramUniform3i_t p_glProgramUniform3i;
		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2) => p_glProgramUniform3i(program, location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3iv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform3iv_t p_glProgramUniform3iv;
		public static void glProgramUniform3iv(uint program, int location, int count, IntPtr value) => p_glProgramUniform3iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3f_t(uint program, int location, float v0, float v1, float v2);
		private static glProgramUniform3f_t p_glProgramUniform3f;
		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2) => p_glProgramUniform3f(program, location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3fv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform3fv_t p_glProgramUniform3fv;
		public static void glProgramUniform3fv(uint program, int location, int count, IntPtr value) => p_glProgramUniform3fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3d_t(uint program, int location, double v0, double v1, double v2);
		private static glProgramUniform3d_t p_glProgramUniform3d;
		public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2) => p_glProgramUniform3d(program, location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3dv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform3dv_t p_glProgramUniform3dv;
		public static void glProgramUniform3dv(uint program, int location, int count, IntPtr value) => p_glProgramUniform3dv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3ui_t(uint program, int location, uint v0, uint v1, uint v2);
		private static glProgramUniform3ui_t p_glProgramUniform3ui;
		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) => p_glProgramUniform3ui(program, location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3uiv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform3uiv_t p_glProgramUniform3uiv;
		public static void glProgramUniform3uiv(uint program, int location, int count, IntPtr value) => p_glProgramUniform3uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4i_t(uint program, int location, int v0, int v1, int v2, int v3);
		private static glProgramUniform4i_t p_glProgramUniform4i;
		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) => p_glProgramUniform4i(program, location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4iv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform4iv_t p_glProgramUniform4iv;
		public static void glProgramUniform4iv(uint program, int location, int count, IntPtr value) => p_glProgramUniform4iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4f_t(uint program, int location, float v0, float v1, float v2, float v3);
		private static glProgramUniform4f_t p_glProgramUniform4f;
		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) => p_glProgramUniform4f(program, location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4fv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform4fv_t p_glProgramUniform4fv;
		public static void glProgramUniform4fv(uint program, int location, int count, IntPtr value) => p_glProgramUniform4fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4d_t(uint program, int location, double v0, double v1, double v2, double v3);
		private static glProgramUniform4d_t p_glProgramUniform4d;
		public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) => p_glProgramUniform4d(program, location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4dv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform4dv_t p_glProgramUniform4dv;
		public static void glProgramUniform4dv(uint program, int location, int count, IntPtr value) => p_glProgramUniform4dv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4ui_t(uint program, int location, uint v0, uint v1, uint v2, uint v3);
		private static glProgramUniform4ui_t p_glProgramUniform4ui;
		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) => p_glProgramUniform4ui(program, location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4uiv_t(uint program, int location, int count, IntPtr value);
		private static glProgramUniform4uiv_t p_glProgramUniform4uiv;
		public static void glProgramUniform4uiv(uint program, int location, int count, IntPtr value) => p_glProgramUniform4uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix2fv_t p_glProgramUniformMatrix2fv;
		public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix2fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix3fv_t p_glProgramUniformMatrix3fv;
		public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix3fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix4fv_t p_glProgramUniformMatrix4fv;
		public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix4fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix2dv_t p_glProgramUniformMatrix2dv;
		public static void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix2dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix3dv_t p_glProgramUniformMatrix3dv;
		public static void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix3dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix4dv_t p_glProgramUniformMatrix4dv;
		public static void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix4dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2x3fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix2x3fv_t p_glProgramUniformMatrix2x3fv;
		public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix2x3fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3x2fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix3x2fv_t p_glProgramUniformMatrix3x2fv;
		public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix3x2fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2x4fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix2x4fv_t p_glProgramUniformMatrix2x4fv;
		public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix2x4fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4x2fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix4x2fv_t p_glProgramUniformMatrix4x2fv;
		public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix4x2fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3x4fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix3x4fv_t p_glProgramUniformMatrix3x4fv;
		public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix3x4fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4x3fv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix4x3fv_t p_glProgramUniformMatrix4x3fv;
		public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix4x3fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2x3dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix2x3dv_t p_glProgramUniformMatrix2x3dv;
		public static void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix2x3dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3x2dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix3x2dv_t p_glProgramUniformMatrix3x2dv;
		public static void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix3x2dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2x4dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix2x4dv_t p_glProgramUniformMatrix2x4dv;
		public static void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix2x4dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4x2dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix4x2dv_t p_glProgramUniformMatrix4x2dv;
		public static void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix4x2dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3x4dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix3x4dv_t p_glProgramUniformMatrix3x4dv;
		public static void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix3x4dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4x3dv_t(uint program, int location, int count, bool transpose, IntPtr value);
		private static glProgramUniformMatrix4x3dv_t p_glProgramUniformMatrix4x3dv;
		public static void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, IntPtr value) => p_glProgramUniformMatrix4x3dv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glValidateProgramPipeline_t(uint pipeline);
		private static glValidateProgramPipeline_t p_glValidateProgramPipeline;
		public static void glValidateProgramPipeline(uint pipeline) => p_glValidateProgramPipeline(pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramPipelineInfoLog_t(uint pipeline, int bufSize, IntPtr length, IntPtr infoLog);
		private static glGetProgramPipelineInfoLog_t p_glGetProgramPipelineInfoLog;
		public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, IntPtr length, IntPtr infoLog) => p_glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL1d_t(uint index, double x);
		private static glVertexAttribL1d_t p_glVertexAttribL1d;
		public static void glVertexAttribL1d(uint index, double x) => p_glVertexAttribL1d(index, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL2d_t(uint index, double x, double y);
		private static glVertexAttribL2d_t p_glVertexAttribL2d;
		public static void glVertexAttribL2d(uint index, double x, double y) => p_glVertexAttribL2d(index, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL3d_t(uint index, double x, double y, double z);
		private static glVertexAttribL3d_t p_glVertexAttribL3d;
		public static void glVertexAttribL3d(uint index, double x, double y, double z) => p_glVertexAttribL3d(index, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL4d_t(uint index, double x, double y, double z, double w);
		private static glVertexAttribL4d_t p_glVertexAttribL4d;
		public static void glVertexAttribL4d(uint index, double x, double y, double z, double w) => p_glVertexAttribL4d(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL1dv_t(uint index, IntPtr v);
		private static glVertexAttribL1dv_t p_glVertexAttribL1dv;
		public static void glVertexAttribL1dv(uint index, IntPtr v) => p_glVertexAttribL1dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL2dv_t(uint index, IntPtr v);
		private static glVertexAttribL2dv_t p_glVertexAttribL2dv;
		public static void glVertexAttribL2dv(uint index, IntPtr v) => p_glVertexAttribL2dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL3dv_t(uint index, IntPtr v);
		private static glVertexAttribL3dv_t p_glVertexAttribL3dv;
		public static void glVertexAttribL3dv(uint index, IntPtr v) => p_glVertexAttribL3dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribL4dv_t(uint index, IntPtr v);
		private static glVertexAttribL4dv_t p_glVertexAttribL4dv;
		public static void glVertexAttribL4dv(uint index, IntPtr v) => p_glVertexAttribL4dv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribLPointer_t(uint index, int size, uint type, int stride, IntPtr pointer);
		private static glVertexAttribLPointer_t p_glVertexAttribLPointer;
		public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer) => p_glVertexAttribLPointer(index, size, type, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribLdv_t(uint index, uint pname, IntPtr @params);
		private static glGetVertexAttribLdv_t p_glGetVertexAttribLdv;
		public static void glGetVertexAttribLdv(uint index, uint pname, IntPtr @params) => p_glGetVertexAttribLdv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glViewportArrayv_t(uint first, int count, IntPtr v);
		private static glViewportArrayv_t p_glViewportArrayv;
		public static void glViewportArrayv(uint first, int count, IntPtr v) => p_glViewportArrayv(first, count, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glViewportIndexedf_t(uint index, float x, float y, float w, float h);
		private static glViewportIndexedf_t p_glViewportIndexedf;
		public static void glViewportIndexedf(uint index, float x, float y, float w, float h) => p_glViewportIndexedf(index, x, y, w, h);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glViewportIndexedfv_t(uint index, IntPtr v);
		private static glViewportIndexedfv_t p_glViewportIndexedfv;
		public static void glViewportIndexedfv(uint index, IntPtr v) => p_glViewportIndexedfv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glScissorArrayv_t(uint first, int count, IntPtr v);
		private static glScissorArrayv_t p_glScissorArrayv;
		public static void glScissorArrayv(uint first, int count, IntPtr v) => p_glScissorArrayv(first, count, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glScissorIndexed_t(uint index, int left, int bottom, int width, int height);
		private static glScissorIndexed_t p_glScissorIndexed;
		public static void glScissorIndexed(uint index, int left, int bottom, int width, int height) => p_glScissorIndexed(index, left, bottom, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glScissorIndexedv_t(uint index, IntPtr v);
		private static glScissorIndexedv_t p_glScissorIndexedv;
		public static void glScissorIndexedv(uint index, IntPtr v) => p_glScissorIndexedv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthRangeArrayv_t(uint first, int count, IntPtr v);
		private static glDepthRangeArrayv_t p_glDepthRangeArrayv;
		public static void glDepthRangeArrayv(uint first, int count, IntPtr v) => p_glDepthRangeArrayv(first, count, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthRangeIndexed_t(uint index, double n, double f);
		private static glDepthRangeIndexed_t p_glDepthRangeIndexed;
		public static void glDepthRangeIndexed(uint index, double n, double f) => p_glDepthRangeIndexed(index, n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFloati_v_t(uint target, uint index, IntPtr data);
		private static glGetFloati_v_t p_glGetFloati_v;
		public static void glGetFloati_v(uint target, uint index, IntPtr data) => p_glGetFloati_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetDoublei_v_t(uint target, uint index, IntPtr data);
		private static glGetDoublei_v_t p_glGetDoublei_v;
		public static void glGetDoublei_v(uint target, uint index, IntPtr data) => p_glGetDoublei_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawArraysInstancedBaseInstance_t(uint mode, int first, int count, int instancecount, uint baseinstance);
		private static glDrawArraysInstancedBaseInstance_t p_glDrawArraysInstancedBaseInstance;
		public static void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance) => p_glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsInstancedBaseInstance_t(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);
		private static glDrawElementsInstancedBaseInstance_t p_glDrawElementsInstancedBaseInstance;
		public static void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance) => p_glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsInstancedBaseVertexBaseInstance_t(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);
		private static glDrawElementsInstancedBaseVertexBaseInstance_t p_glDrawElementsInstancedBaseVertexBaseInstance;
		public static void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance) => p_glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetInternalformativ_t(uint target, uint internalformat, uint pname, int bufSize, IntPtr @params);
		private static glGetInternalformativ_t p_glGetInternalformativ;
		public static void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, IntPtr @params) => p_glGetInternalformativ(target, internalformat, pname, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveAtomicCounterBufferiv_t(uint program, uint bufferIndex, uint pname, IntPtr @params);
		private static glGetActiveAtomicCounterBufferiv_t p_glGetActiveAtomicCounterBufferiv;
		public static void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, IntPtr @params) => p_glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindImageTexture_t(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
		private static glBindImageTexture_t p_glBindImageTexture;
		public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format) => p_glBindImageTexture(unit, texture, level, layered, layer, access, format);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMemoryBarrier_t(uint barriers);
		private static glMemoryBarrier_t p_glMemoryBarrier;
		public static void glMemoryBarrier(uint barriers) => p_glMemoryBarrier(barriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage1D_t(uint target, int levels, uint internalformat, int width);
		private static glTexStorage1D_t p_glTexStorage1D;
		public static void glTexStorage1D(uint target, int levels, uint internalformat, int width) => p_glTexStorage1D(target, levels, internalformat, width);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage2D_t(uint target, int levels, uint internalformat, int width, int height);
		private static glTexStorage2D_t p_glTexStorage2D;
		public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height) => p_glTexStorage2D(target, levels, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage3D_t(uint target, int levels, uint internalformat, int width, int height, int depth);
		private static glTexStorage3D_t p_glTexStorage3D;
		public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) => p_glTexStorage3D(target, levels, internalformat, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawTransformFeedbackInstanced_t(uint mode, uint id, int instancecount);
		private static glDrawTransformFeedbackInstanced_t p_glDrawTransformFeedbackInstanced;
		public static void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount) => p_glDrawTransformFeedbackInstanced(mode, id, instancecount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawTransformFeedbackStreamInstanced_t(uint mode, uint id, uint stream, int instancecount);
		private static glDrawTransformFeedbackStreamInstanced_t p_glDrawTransformFeedbackStreamInstanced;
		public static void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount) => p_glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferData_t(uint target, uint internalformat, uint format, uint type, IntPtr data);
		private static glClearBufferData_t p_glClearBufferData;
		public static void glClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data) => p_glClearBufferData(target, internalformat, format, type, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferSubData_t(uint target, uint internalformat, IntPtr offset, int size, uint format, uint type, IntPtr data);
		private static glClearBufferSubData_t p_glClearBufferSubData;
		public static void glClearBufferSubData(uint target, uint internalformat, IntPtr offset, int size, uint format, uint type, IntPtr data) => p_glClearBufferSubData(target, internalformat, offset, size, format, type, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDispatchCompute_t(uint num_groups_x, uint num_groups_y, uint num_groups_z);
		private static glDispatchCompute_t p_glDispatchCompute;
		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => p_glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDispatchComputeIndirect_t(IntPtr indirect);
		private static glDispatchComputeIndirect_t p_glDispatchComputeIndirect;
		public static void glDispatchComputeIndirect(IntPtr indirect) => p_glDispatchComputeIndirect(indirect);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyImageSubData_t(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		private static glCopyImageSubData_t p_glCopyImageSubData;
		public static void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => p_glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferParameteri_t(uint target, uint pname, int param);
		private static glFramebufferParameteri_t p_glFramebufferParameteri;
		public static void glFramebufferParameteri(uint target, uint pname, int param) => p_glFramebufferParameteri(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFramebufferParameteriv_t(uint target, uint pname, IntPtr @params);
		private static glGetFramebufferParameteriv_t p_glGetFramebufferParameteriv;
		public static void glGetFramebufferParameteriv(uint target, uint pname, IntPtr @params) => p_glGetFramebufferParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetInternalformati64v_t(uint target, uint internalformat, uint pname, int bufSize, IntPtr @params);
		private static glGetInternalformati64v_t p_glGetInternalformati64v;
		public static void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, IntPtr @params) => p_glGetInternalformati64v(target, internalformat, pname, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateTexSubImage_t(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
		private static glInvalidateTexSubImage_t p_glInvalidateTexSubImage;
		public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) => p_glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateTexImage_t(uint texture, int level);
		private static glInvalidateTexImage_t p_glInvalidateTexImage;
		public static void glInvalidateTexImage(uint texture, int level) => p_glInvalidateTexImage(texture, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateBufferSubData_t(uint buffer, IntPtr offset, int length);
		private static glInvalidateBufferSubData_t p_glInvalidateBufferSubData;
		public static void glInvalidateBufferSubData(uint buffer, IntPtr offset, int length) => p_glInvalidateBufferSubData(buffer, offset, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateBufferData_t(uint buffer);
		private static glInvalidateBufferData_t p_glInvalidateBufferData;
		public static void glInvalidateBufferData(uint buffer) => p_glInvalidateBufferData(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateFramebuffer_t(uint target, int numAttachments, IntPtr attachments);
		private static glInvalidateFramebuffer_t p_glInvalidateFramebuffer;
		public static void glInvalidateFramebuffer(uint target, int numAttachments, IntPtr attachments) => p_glInvalidateFramebuffer(target, numAttachments, attachments);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateSubFramebuffer_t(uint target, int numAttachments, IntPtr attachments, int x, int y, int width, int height);
		private static glInvalidateSubFramebuffer_t p_glInvalidateSubFramebuffer;
		public static void glInvalidateSubFramebuffer(uint target, int numAttachments, IntPtr attachments, int x, int y, int width, int height) => p_glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiDrawArraysIndirect_t(uint mode, IntPtr indirect, int drawcount, int stride);
		private static glMultiDrawArraysIndirect_t p_glMultiDrawArraysIndirect;
		public static void glMultiDrawArraysIndirect(uint mode, IntPtr indirect, int drawcount, int stride) => p_glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiDrawElementsIndirect_t(uint mode, uint type, IntPtr indirect, int drawcount, int stride);
		private static glMultiDrawElementsIndirect_t p_glMultiDrawElementsIndirect;
		public static void glMultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int drawcount, int stride) => p_glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramInterfaceiv_t(uint program, uint programInterface, uint pname, IntPtr @params);
		private static glGetProgramInterfaceiv_t p_glGetProgramInterfaceiv;
		public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, IntPtr @params) => p_glGetProgramInterfaceiv(program, programInterface, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetProgramResourceIndex_t(uint program, uint programInterface, IntPtr name);
		private static glGetProgramResourceIndex_t p_glGetProgramResourceIndex;
		public static uint glGetProgramResourceIndex(uint program, uint programInterface, IntPtr name) => p_glGetProgramResourceIndex(program, programInterface, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramResourceName_t(uint program, uint programInterface, uint index, int bufSize, IntPtr length, IntPtr name);
		private static glGetProgramResourceName_t p_glGetProgramResourceName;
		public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, IntPtr length, IntPtr name) => p_glGetProgramResourceName(program, programInterface, index, bufSize, length, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramResourceiv_t(uint program, uint programInterface, uint index, int propCount, IntPtr props, int bufSize, IntPtr length, IntPtr @params);
		private static glGetProgramResourceiv_t p_glGetProgramResourceiv;
		public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, IntPtr props, int bufSize, IntPtr length, IntPtr @params) => p_glGetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetProgramResourceLocation_t(uint program, uint programInterface, IntPtr name);
		private static glGetProgramResourceLocation_t p_glGetProgramResourceLocation;
		public static int glGetProgramResourceLocation(uint program, uint programInterface, IntPtr name) => p_glGetProgramResourceLocation(program, programInterface, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetProgramResourceLocationIndex_t(uint program, uint programInterface, IntPtr name);
		private static glGetProgramResourceLocationIndex_t p_glGetProgramResourceLocationIndex;
		public static int glGetProgramResourceLocationIndex(uint program, uint programInterface, IntPtr name) => p_glGetProgramResourceLocationIndex(program, programInterface, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glShaderStorageBlockBinding_t(uint program, uint storageBlockIndex, uint storageBlockBinding);
		private static glShaderStorageBlockBinding_t p_glShaderStorageBlockBinding;
		public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) => p_glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexBufferRange_t(uint target, uint internalformat, uint buffer, IntPtr offset, int size);
		private static glTexBufferRange_t p_glTexBufferRange;
		public static void glTexBufferRange(uint target, uint internalformat, uint buffer, IntPtr offset, int size) => p_glTexBufferRange(target, internalformat, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage2DMultisample_t(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private static glTexStorage2DMultisample_t p_glTexStorage2DMultisample;
		public static void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) => p_glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage3DMultisample_t(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private static glTexStorage3DMultisample_t p_glTexStorage3DMultisample;
		public static void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) => p_glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureView_t(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
		private static glTextureView_t p_glTextureView;
		public static void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => p_glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindVertexBuffer_t(uint bindingindex, uint buffer, IntPtr offset, int stride);
		private static glBindVertexBuffer_t p_glBindVertexBuffer;
		public static void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride) => p_glBindVertexBuffer(bindingindex, buffer, offset, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribFormat_t(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private static glVertexAttribFormat_t p_glVertexAttribFormat;
		public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset) => p_glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribIFormat_t(uint attribindex, int size, uint type, uint relativeoffset);
		private static glVertexAttribIFormat_t p_glVertexAttribIFormat;
		public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) => p_glVertexAttribIFormat(attribindex, size, type, relativeoffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribLFormat_t(uint attribindex, int size, uint type, uint relativeoffset);
		private static glVertexAttribLFormat_t p_glVertexAttribLFormat;
		public static void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset) => p_glVertexAttribLFormat(attribindex, size, type, relativeoffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribBinding_t(uint attribindex, uint bindingindex);
		private static glVertexAttribBinding_t p_glVertexAttribBinding;
		public static void glVertexAttribBinding(uint attribindex, uint bindingindex) => p_glVertexAttribBinding(attribindex, bindingindex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexBindingDivisor_t(uint bindingindex, uint divisor);
		private static glVertexBindingDivisor_t p_glVertexBindingDivisor;
		public static void glVertexBindingDivisor(uint bindingindex, uint divisor) => p_glVertexBindingDivisor(bindingindex, divisor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDebugMessageControl_t(uint source, uint type, uint severity, int count, IntPtr ids, bool enabled);
		private static glDebugMessageControl_t p_glDebugMessageControl;
		public static void glDebugMessageControl(uint source, uint type, uint severity, int count, IntPtr ids, bool enabled) => p_glDebugMessageControl(source, type, severity, count, ids, enabled);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDebugMessageInsert_t(uint source, uint type, uint id, uint severity, int length, IntPtr buf);
		private static glDebugMessageInsert_t p_glDebugMessageInsert;
		public static void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, IntPtr buf) => p_glDebugMessageInsert(source, type, id, severity, length, buf);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDebugMessageCallback_t(IntPtr callback, IntPtr userParam);
		private static glDebugMessageCallback_t p_glDebugMessageCallback;
		public static void glDebugMessageCallback(IntPtr callback, IntPtr userParam) => p_glDebugMessageCallback(callback, userParam);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetDebugMessageLog_t(uint count, int bufSize, IntPtr sources, IntPtr types, IntPtr ids, IntPtr severities, IntPtr lengths, IntPtr messageLog);
		private static glGetDebugMessageLog_t p_glGetDebugMessageLog;
		public static uint glGetDebugMessageLog(uint count, int bufSize, IntPtr sources, IntPtr types, IntPtr ids, IntPtr severities, IntPtr lengths, IntPtr messageLog) => p_glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPushDebugGroup_t(uint source, uint id, int length, IntPtr message);
		private static glPushDebugGroup_t p_glPushDebugGroup;
		public static void glPushDebugGroup(uint source, uint id, int length, IntPtr message) => p_glPushDebugGroup(source, id, length, message);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPopDebugGroup_t();
		private static glPopDebugGroup_t p_glPopDebugGroup;
		public static void glPopDebugGroup() => p_glPopDebugGroup();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glObjectLabel_t(uint identifier, uint name, int length, IntPtr label);
		private static glObjectLabel_t p_glObjectLabel;
		public static void glObjectLabel(uint identifier, uint name, int length, IntPtr label) => p_glObjectLabel(identifier, name, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetObjectLabel_t(uint identifier, uint name, int bufSize, IntPtr length, IntPtr label);
		private static glGetObjectLabel_t p_glGetObjectLabel;
		public static void glGetObjectLabel(uint identifier, uint name, int bufSize, IntPtr length, IntPtr label) => p_glGetObjectLabel(identifier, name, bufSize, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glObjectPtrLabel_t(IntPtr ptr, int length, IntPtr label);
		private static glObjectPtrLabel_t p_glObjectPtrLabel;
		public static void glObjectPtrLabel(IntPtr ptr, int length, IntPtr label) => p_glObjectPtrLabel(ptr, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetObjectPtrLabel_t(IntPtr ptr, int bufSize, IntPtr length, IntPtr label);
		private static glGetObjectPtrLabel_t p_glGetObjectPtrLabel;
		public static void glGetObjectPtrLabel(IntPtr ptr, int bufSize, IntPtr length, IntPtr label) => p_glGetObjectPtrLabel(ptr, bufSize, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetPointerv_t(uint pname, IntPtr @params);
		private static glGetPointerv_t p_glGetPointerv;
		public static void glGetPointerv(uint pname, IntPtr @params) => p_glGetPointerv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBufferStorage_t(uint target, int size, IntPtr data, uint flags);
		private static glBufferStorage_t p_glBufferStorage;
		public static void glBufferStorage(uint target, int size, IntPtr data, uint flags) => p_glBufferStorage(target, size, data, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearTexImage_t(uint texture, int level, uint format, uint type, IntPtr data);
		private static glClearTexImage_t p_glClearTexImage;
		public static void glClearTexImage(uint texture, int level, uint format, uint type, IntPtr data) => p_glClearTexImage(texture, level, format, type, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearTexSubImage_t(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);
		private static glClearTexSubImage_t p_glClearTexSubImage;
		public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data) => p_glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBuffersBase_t(uint target, uint first, int count, IntPtr buffers);
		private static glBindBuffersBase_t p_glBindBuffersBase;
		public static void glBindBuffersBase(uint target, uint first, int count, IntPtr buffers) => p_glBindBuffersBase(target, first, count, buffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBuffersRange_t(uint target, uint first, int count, IntPtr buffers, IntPtr offsets, IntPtr sizes);
		private static glBindBuffersRange_t p_glBindBuffersRange;
		public static void glBindBuffersRange(uint target, uint first, int count, IntPtr buffers, IntPtr offsets, IntPtr sizes) => p_glBindBuffersRange(target, first, count, buffers, offsets, sizes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindTextures_t(uint first, int count, IntPtr textures);
		private static glBindTextures_t p_glBindTextures;
		public static void glBindTextures(uint first, int count, IntPtr textures) => p_glBindTextures(first, count, textures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindSamplers_t(uint first, int count, IntPtr samplers);
		private static glBindSamplers_t p_glBindSamplers;
		public static void glBindSamplers(uint first, int count, IntPtr samplers) => p_glBindSamplers(first, count, samplers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindImageTextures_t(uint first, int count, IntPtr textures);
		private static glBindImageTextures_t p_glBindImageTextures;
		public static void glBindImageTextures(uint first, int count, IntPtr textures) => p_glBindImageTextures(first, count, textures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindVertexBuffers_t(uint first, int count, IntPtr buffers, IntPtr offsets, IntPtr strides);
		private static glBindVertexBuffers_t p_glBindVertexBuffers;
		public static void glBindVertexBuffers(uint first, int count, IntPtr buffers, IntPtr offsets, IntPtr strides) => p_glBindVertexBuffers(first, count, buffers, offsets, strides);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClipControl_t(uint origin, uint depth);
		private static glClipControl_t p_glClipControl;
		public static void glClipControl(uint origin, uint depth) => p_glClipControl(origin, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateTransformFeedbacks_t(int n, IntPtr ids);
		private static glCreateTransformFeedbacks_t p_glCreateTransformFeedbacks;
		public static void glCreateTransformFeedbacks(int n, IntPtr ids) => p_glCreateTransformFeedbacks(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTransformFeedbackBufferBase_t(uint xfb, uint index, uint buffer);
		private static glTransformFeedbackBufferBase_t p_glTransformFeedbackBufferBase;
		public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer) => p_glTransformFeedbackBufferBase(xfb, index, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTransformFeedbackBufferRange_t(uint xfb, uint index, uint buffer, IntPtr offset, int size);
		private static glTransformFeedbackBufferRange_t p_glTransformFeedbackBufferRange;
		public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, int size) => p_glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTransformFeedbackiv_t(uint xfb, uint pname, IntPtr param);
		private static glGetTransformFeedbackiv_t p_glGetTransformFeedbackiv;
		public static void glGetTransformFeedbackiv(uint xfb, uint pname, IntPtr param) => p_glGetTransformFeedbackiv(xfb, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTransformFeedbacki_v_t(uint xfb, uint pname, uint index, IntPtr param);
		private static glGetTransformFeedbacki_v_t p_glGetTransformFeedbacki_v;
		public static void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, IntPtr param) => p_glGetTransformFeedbacki_v(xfb, pname, index, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTransformFeedbacki64_v_t(uint xfb, uint pname, uint index, IntPtr param);
		private static glGetTransformFeedbacki64_v_t p_glGetTransformFeedbacki64_v;
		public static void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, IntPtr param) => p_glGetTransformFeedbacki64_v(xfb, pname, index, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateBuffers_t(int n, IntPtr buffers);
		private static glCreateBuffers_t p_glCreateBuffers;
		public static void glCreateBuffers(int n, IntPtr buffers) => p_glCreateBuffers(n, buffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedBufferStorage_t(uint buffer, int size, IntPtr data, uint flags);
		private static glNamedBufferStorage_t p_glNamedBufferStorage;
		public static void glNamedBufferStorage(uint buffer, int size, IntPtr data, uint flags) => p_glNamedBufferStorage(buffer, size, data, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedBufferData_t(uint buffer, int size, IntPtr data, uint usage);
		private static glNamedBufferData_t p_glNamedBufferData;
		public static void glNamedBufferData(uint buffer, int size, IntPtr data, uint usage) => p_glNamedBufferData(buffer, size, data, usage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedBufferSubData_t(uint buffer, IntPtr offset, int size, IntPtr data);
		private static glNamedBufferSubData_t p_glNamedBufferSubData;
		public static void glNamedBufferSubData(uint buffer, IntPtr offset, int size, IntPtr data) => p_glNamedBufferSubData(buffer, offset, size, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyNamedBufferSubData_t(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size);
		private static glCopyNamedBufferSubData_t p_glCopyNamedBufferSubData;
		public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size) => p_glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearNamedBufferData_t(uint buffer, uint internalformat, uint format, uint type, IntPtr data);
		private static glClearNamedBufferData_t p_glClearNamedBufferData;
		public static void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data) => p_glClearNamedBufferData(buffer, internalformat, format, type, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearNamedBufferSubData_t(uint buffer, uint internalformat, IntPtr offset, int size, uint format, uint type, IntPtr data);
		private static glClearNamedBufferSubData_t p_glClearNamedBufferSubData;
		public static void glClearNamedBufferSubData(uint buffer, uint internalformat, IntPtr offset, int size, uint format, uint type, IntPtr data) => p_glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glMapNamedBuffer_t(uint buffer, uint access);
		private static glMapNamedBuffer_t p_glMapNamedBuffer;
		public static IntPtr glMapNamedBuffer(uint buffer, uint access) => p_glMapNamedBuffer(buffer, access);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glMapNamedBufferRange_t(uint buffer, IntPtr offset, int length, uint access);
		private static glMapNamedBufferRange_t p_glMapNamedBufferRange;
		public static IntPtr glMapNamedBufferRange(uint buffer, IntPtr offset, int length, uint access) => p_glMapNamedBufferRange(buffer, offset, length, access);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glUnmapNamedBuffer_t(uint buffer);
		private static glUnmapNamedBuffer_t p_glUnmapNamedBuffer;
		public static bool glUnmapNamedBuffer(uint buffer) => p_glUnmapNamedBuffer(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFlushMappedNamedBufferRange_t(uint buffer, IntPtr offset, int length);
		private static glFlushMappedNamedBufferRange_t p_glFlushMappedNamedBufferRange;
		public static void glFlushMappedNamedBufferRange(uint buffer, IntPtr offset, int length) => p_glFlushMappedNamedBufferRange(buffer, offset, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetNamedBufferParameteriv_t(uint buffer, uint pname, IntPtr @params);
		private static glGetNamedBufferParameteriv_t p_glGetNamedBufferParameteriv;
		public static void glGetNamedBufferParameteriv(uint buffer, uint pname, IntPtr @params) => p_glGetNamedBufferParameteriv(buffer, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetNamedBufferParameteri64v_t(uint buffer, uint pname, IntPtr @params);
		private static glGetNamedBufferParameteri64v_t p_glGetNamedBufferParameteri64v;
		public static void glGetNamedBufferParameteri64v(uint buffer, uint pname, IntPtr @params) => p_glGetNamedBufferParameteri64v(buffer, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetNamedBufferPointerv_t(uint buffer, uint pname, IntPtr @params);
		private static glGetNamedBufferPointerv_t p_glGetNamedBufferPointerv;
		public static void glGetNamedBufferPointerv(uint buffer, uint pname, IntPtr @params) => p_glGetNamedBufferPointerv(buffer, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetNamedBufferSubData_t(uint buffer, IntPtr offset, int size, IntPtr data);
		private static glGetNamedBufferSubData_t p_glGetNamedBufferSubData;
		public static void glGetNamedBufferSubData(uint buffer, IntPtr offset, int size, IntPtr data) => p_glGetNamedBufferSubData(buffer, offset, size, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateFramebuffers_t(int n, IntPtr framebuffers);
		private static glCreateFramebuffers_t p_glCreateFramebuffers;
		public static void glCreateFramebuffers(int n, IntPtr framebuffers) => p_glCreateFramebuffers(n, framebuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedFramebufferRenderbuffer_t(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private static glNamedFramebufferRenderbuffer_t p_glNamedFramebufferRenderbuffer;
		public static void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) => p_glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedFramebufferParameteri_t(uint framebuffer, uint pname, int param);
		private static glNamedFramebufferParameteri_t p_glNamedFramebufferParameteri;
		public static void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param) => p_glNamedFramebufferParameteri(framebuffer, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedFramebufferTexture_t(uint framebuffer, uint attachment, uint texture, int level);
		private static glNamedFramebufferTexture_t p_glNamedFramebufferTexture;
		public static void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level) => p_glNamedFramebufferTexture(framebuffer, attachment, texture, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedFramebufferTextureLayer_t(uint framebuffer, uint attachment, uint texture, int level, int layer);
		private static glNamedFramebufferTextureLayer_t p_glNamedFramebufferTextureLayer;
		public static void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer) => p_glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedFramebufferDrawBuffer_t(uint framebuffer, uint buf);
		private static glNamedFramebufferDrawBuffer_t p_glNamedFramebufferDrawBuffer;
		public static void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf) => p_glNamedFramebufferDrawBuffer(framebuffer, buf);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedFramebufferDrawBuffers_t(uint framebuffer, int n, IntPtr bufs);
		private static glNamedFramebufferDrawBuffers_t p_glNamedFramebufferDrawBuffers;
		public static void glNamedFramebufferDrawBuffers(uint framebuffer, int n, IntPtr bufs) => p_glNamedFramebufferDrawBuffers(framebuffer, n, bufs);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedFramebufferReadBuffer_t(uint framebuffer, uint src);
		private static glNamedFramebufferReadBuffer_t p_glNamedFramebufferReadBuffer;
		public static void glNamedFramebufferReadBuffer(uint framebuffer, uint src) => p_glNamedFramebufferReadBuffer(framebuffer, src);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateNamedFramebufferData_t(uint framebuffer, int numAttachments, IntPtr attachments);
		private static glInvalidateNamedFramebufferData_t p_glInvalidateNamedFramebufferData;
		public static void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, IntPtr attachments) => p_glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateNamedFramebufferSubData_t(uint framebuffer, int numAttachments, IntPtr attachments, int x, int y, int width, int height);
		private static glInvalidateNamedFramebufferSubData_t p_glInvalidateNamedFramebufferSubData;
		public static void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, IntPtr attachments, int x, int y, int width, int height) => p_glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearNamedFramebufferiv_t(uint framebuffer, uint buffer, int drawbuffer, IntPtr value);
		private static glClearNamedFramebufferiv_t p_glClearNamedFramebufferiv;
		public static void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, IntPtr value) => p_glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearNamedFramebufferuiv_t(uint framebuffer, uint buffer, int drawbuffer, IntPtr value);
		private static glClearNamedFramebufferuiv_t p_glClearNamedFramebufferuiv;
		public static void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, IntPtr value) => p_glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearNamedFramebufferfv_t(uint framebuffer, uint buffer, int drawbuffer, IntPtr value);
		private static glClearNamedFramebufferfv_t p_glClearNamedFramebufferfv;
		public static void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, IntPtr value) => p_glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearNamedFramebufferfi_t(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
		private static glClearNamedFramebufferfi_t p_glClearNamedFramebufferfi;
		public static void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil) => p_glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlitNamedFramebuffer_t(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private static glBlitNamedFramebuffer_t p_glBlitNamedFramebuffer;
		public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) => p_glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCheckNamedFramebufferStatus_t(uint framebuffer, uint target);
		private static glCheckNamedFramebufferStatus_t p_glCheckNamedFramebufferStatus;
		public static uint glCheckNamedFramebufferStatus(uint framebuffer, uint target) => p_glCheckNamedFramebufferStatus(framebuffer, target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetNamedFramebufferParameteriv_t(uint framebuffer, uint pname, IntPtr param);
		private static glGetNamedFramebufferParameteriv_t p_glGetNamedFramebufferParameteriv;
		public static void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, IntPtr param) => p_glGetNamedFramebufferParameteriv(framebuffer, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetNamedFramebufferAttachmentParameteriv_t(uint framebuffer, uint attachment, uint pname, IntPtr @params);
		private static glGetNamedFramebufferAttachmentParameteriv_t p_glGetNamedFramebufferAttachmentParameteriv;
		public static void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, IntPtr @params) => p_glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateRenderbuffers_t(int n, IntPtr renderbuffers);
		private static glCreateRenderbuffers_t p_glCreateRenderbuffers;
		public static void glCreateRenderbuffers(int n, IntPtr renderbuffers) => p_glCreateRenderbuffers(n, renderbuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedRenderbufferStorage_t(uint renderbuffer, uint internalformat, int width, int height);
		private static glNamedRenderbufferStorage_t p_glNamedRenderbufferStorage;
		public static void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height) => p_glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNamedRenderbufferStorageMultisample_t(uint renderbuffer, int samples, uint internalformat, int width, int height);
		private static glNamedRenderbufferStorageMultisample_t p_glNamedRenderbufferStorageMultisample;
		public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height) => p_glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetNamedRenderbufferParameteriv_t(uint renderbuffer, uint pname, IntPtr @params);
		private static glGetNamedRenderbufferParameteriv_t p_glGetNamedRenderbufferParameteriv;
		public static void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, IntPtr @params) => p_glGetNamedRenderbufferParameteriv(renderbuffer, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateTextures_t(uint target, int n, IntPtr textures);
		private static glCreateTextures_t p_glCreateTextures;
		public static void glCreateTextures(uint target, int n, IntPtr textures) => p_glCreateTextures(target, n, textures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureBuffer_t(uint texture, uint internalformat, uint buffer);
		private static glTextureBuffer_t p_glTextureBuffer;
		public static void glTextureBuffer(uint texture, uint internalformat, uint buffer) => p_glTextureBuffer(texture, internalformat, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureBufferRange_t(uint texture, uint internalformat, uint buffer, IntPtr offset, int size);
		private static glTextureBufferRange_t p_glTextureBufferRange;
		public static void glTextureBufferRange(uint texture, uint internalformat, uint buffer, IntPtr offset, int size) => p_glTextureBufferRange(texture, internalformat, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureStorage1D_t(uint texture, int levels, uint internalformat, int width);
		private static glTextureStorage1D_t p_glTextureStorage1D;
		public static void glTextureStorage1D(uint texture, int levels, uint internalformat, int width) => p_glTextureStorage1D(texture, levels, internalformat, width);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureStorage2D_t(uint texture, int levels, uint internalformat, int width, int height);
		private static glTextureStorage2D_t p_glTextureStorage2D;
		public static void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height) => p_glTextureStorage2D(texture, levels, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureStorage3D_t(uint texture, int levels, uint internalformat, int width, int height, int depth);
		private static glTextureStorage3D_t p_glTextureStorage3D;
		public static void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth) => p_glTextureStorage3D(texture, levels, internalformat, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureStorage2DMultisample_t(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private static glTextureStorage2DMultisample_t p_glTextureStorage2DMultisample;
		public static void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) => p_glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureStorage3DMultisample_t(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private static glTextureStorage3DMultisample_t p_glTextureStorage3DMultisample;
		public static void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) => p_glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureSubImage1D_t(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		private static glTextureSubImage1D_t p_glTextureSubImage1D;
		public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) => p_glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureSubImage2D_t(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		private static glTextureSubImage2D_t p_glTextureSubImage2D;
		public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) => p_glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureSubImage3D_t(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		private static glTextureSubImage3D_t p_glTextureSubImage3D;
		public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels) => p_glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTextureSubImage1D_t(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		private static glCompressedTextureSubImage1D_t p_glCompressedTextureSubImage1D;
		public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data) => p_glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTextureSubImage2D_t(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		private static glCompressedTextureSubImage2D_t p_glCompressedTextureSubImage2D;
		public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data) => p_glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTextureSubImage3D_t(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		private static glCompressedTextureSubImage3D_t p_glCompressedTextureSubImage3D;
		public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data) => p_glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTextureSubImage1D_t(uint texture, int level, int xoffset, int x, int y, int width);
		private static glCopyTextureSubImage1D_t p_glCopyTextureSubImage1D;
		public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width) => p_glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTextureSubImage2D_t(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private static glCopyTextureSubImage2D_t p_glCopyTextureSubImage2D;
		public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) => p_glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTextureSubImage3D_t(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private static glCopyTextureSubImage3D_t p_glCopyTextureSubImage3D;
		public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => p_glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureParameterf_t(uint texture, uint pname, float param);
		private static glTextureParameterf_t p_glTextureParameterf;
		public static void glTextureParameterf(uint texture, uint pname, float param) => p_glTextureParameterf(texture, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureParameterfv_t(uint texture, uint pname, IntPtr param);
		private static glTextureParameterfv_t p_glTextureParameterfv;
		public static void glTextureParameterfv(uint texture, uint pname, IntPtr param) => p_glTextureParameterfv(texture, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureParameteri_t(uint texture, uint pname, int param);
		private static glTextureParameteri_t p_glTextureParameteri;
		public static void glTextureParameteri(uint texture, uint pname, int param) => p_glTextureParameteri(texture, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureParameterIiv_t(uint texture, uint pname, IntPtr @params);
		private static glTextureParameterIiv_t p_glTextureParameterIiv;
		public static void glTextureParameterIiv(uint texture, uint pname, IntPtr @params) => p_glTextureParameterIiv(texture, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureParameterIuiv_t(uint texture, uint pname, IntPtr @params);
		private static glTextureParameterIuiv_t p_glTextureParameterIuiv;
		public static void glTextureParameterIuiv(uint texture, uint pname, IntPtr @params) => p_glTextureParameterIuiv(texture, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureParameteriv_t(uint texture, uint pname, IntPtr param);
		private static glTextureParameteriv_t p_glTextureParameteriv;
		public static void glTextureParameteriv(uint texture, uint pname, IntPtr param) => p_glTextureParameteriv(texture, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenerateTextureMipmap_t(uint texture);
		private static glGenerateTextureMipmap_t p_glGenerateTextureMipmap;
		public static void glGenerateTextureMipmap(uint texture) => p_glGenerateTextureMipmap(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindTextureUnit_t(uint unit, uint texture);
		private static glBindTextureUnit_t p_glBindTextureUnit;
		public static void glBindTextureUnit(uint unit, uint texture) => p_glBindTextureUnit(unit, texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureImage_t(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels);
		private static glGetTextureImage_t p_glGetTextureImage;
		public static void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels) => p_glGetTextureImage(texture, level, format, type, bufSize, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetCompressedTextureImage_t(uint texture, int level, int bufSize, IntPtr pixels);
		private static glGetCompressedTextureImage_t p_glGetCompressedTextureImage;
		public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels) => p_glGetCompressedTextureImage(texture, level, bufSize, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureLevelParameterfv_t(uint texture, int level, uint pname, IntPtr @params);
		private static glGetTextureLevelParameterfv_t p_glGetTextureLevelParameterfv;
		public static void glGetTextureLevelParameterfv(uint texture, int level, uint pname, IntPtr @params) => p_glGetTextureLevelParameterfv(texture, level, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureLevelParameteriv_t(uint texture, int level, uint pname, IntPtr @params);
		private static glGetTextureLevelParameteriv_t p_glGetTextureLevelParameteriv;
		public static void glGetTextureLevelParameteriv(uint texture, int level, uint pname, IntPtr @params) => p_glGetTextureLevelParameteriv(texture, level, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureParameterfv_t(uint texture, uint pname, IntPtr @params);
		private static glGetTextureParameterfv_t p_glGetTextureParameterfv;
		public static void glGetTextureParameterfv(uint texture, uint pname, IntPtr @params) => p_glGetTextureParameterfv(texture, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureParameterIiv_t(uint texture, uint pname, IntPtr @params);
		private static glGetTextureParameterIiv_t p_glGetTextureParameterIiv;
		public static void glGetTextureParameterIiv(uint texture, uint pname, IntPtr @params) => p_glGetTextureParameterIiv(texture, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureParameterIuiv_t(uint texture, uint pname, IntPtr @params);
		private static glGetTextureParameterIuiv_t p_glGetTextureParameterIuiv;
		public static void glGetTextureParameterIuiv(uint texture, uint pname, IntPtr @params) => p_glGetTextureParameterIuiv(texture, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureParameteriv_t(uint texture, uint pname, IntPtr @params);
		private static glGetTextureParameteriv_t p_glGetTextureParameteriv;
		public static void glGetTextureParameteriv(uint texture, uint pname, IntPtr @params) => p_glGetTextureParameteriv(texture, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateVertexArrays_t(int n, IntPtr arrays);
		private static glCreateVertexArrays_t p_glCreateVertexArrays;
		public static void glCreateVertexArrays(int n, IntPtr arrays) => p_glCreateVertexArrays(n, arrays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDisableVertexArrayAttrib_t(uint vaobj, uint index);
		private static glDisableVertexArrayAttrib_t p_glDisableVertexArrayAttrib;
		public static void glDisableVertexArrayAttrib(uint vaobj, uint index) => p_glDisableVertexArrayAttrib(vaobj, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEnableVertexArrayAttrib_t(uint vaobj, uint index);
		private static glEnableVertexArrayAttrib_t p_glEnableVertexArrayAttrib;
		public static void glEnableVertexArrayAttrib(uint vaobj, uint index) => p_glEnableVertexArrayAttrib(vaobj, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayElementBuffer_t(uint vaobj, uint buffer);
		private static glVertexArrayElementBuffer_t p_glVertexArrayElementBuffer;
		public static void glVertexArrayElementBuffer(uint vaobj, uint buffer) => p_glVertexArrayElementBuffer(vaobj, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayVertexBuffer_t(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride);
		private static glVertexArrayVertexBuffer_t p_glVertexArrayVertexBuffer;
		public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride) => p_glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayVertexBuffers_t(uint vaobj, uint first, int count, IntPtr buffers, IntPtr offsets, IntPtr strides);
		private static glVertexArrayVertexBuffers_t p_glVertexArrayVertexBuffers;
		public static void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, IntPtr buffers, IntPtr offsets, IntPtr strides) => p_glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayAttribBinding_t(uint vaobj, uint attribindex, uint bindingindex);
		private static glVertexArrayAttribBinding_t p_glVertexArrayAttribBinding;
		public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) => p_glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayAttribFormat_t(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private static glVertexArrayAttribFormat_t p_glVertexArrayAttribFormat;
		public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset) => p_glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayAttribIFormat_t(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private static glVertexArrayAttribIFormat_t p_glVertexArrayAttribIFormat;
		public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) => p_glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayAttribLFormat_t(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private static glVertexArrayAttribLFormat_t p_glVertexArrayAttribLFormat;
		public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) => p_glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexArrayBindingDivisor_t(uint vaobj, uint bindingindex, uint divisor);
		private static glVertexArrayBindingDivisor_t p_glVertexArrayBindingDivisor;
		public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) => p_glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexArrayiv_t(uint vaobj, uint pname, IntPtr param);
		private static glGetVertexArrayiv_t p_glGetVertexArrayiv;
		public static void glGetVertexArrayiv(uint vaobj, uint pname, IntPtr param) => p_glGetVertexArrayiv(vaobj, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexArrayIndexediv_t(uint vaobj, uint index, uint pname, IntPtr param);
		private static glGetVertexArrayIndexediv_t p_glGetVertexArrayIndexediv;
		public static void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, IntPtr param) => p_glGetVertexArrayIndexediv(vaobj, index, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexArrayIndexed64iv_t(uint vaobj, uint index, uint pname, IntPtr param);
		private static glGetVertexArrayIndexed64iv_t p_glGetVertexArrayIndexed64iv;
		public static void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, IntPtr param) => p_glGetVertexArrayIndexed64iv(vaobj, index, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateSamplers_t(int n, IntPtr samplers);
		private static glCreateSamplers_t p_glCreateSamplers;
		public static void glCreateSamplers(int n, IntPtr samplers) => p_glCreateSamplers(n, samplers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateProgramPipelines_t(int n, IntPtr pipelines);
		private static glCreateProgramPipelines_t p_glCreateProgramPipelines;
		public static void glCreateProgramPipelines(int n, IntPtr pipelines) => p_glCreateProgramPipelines(n, pipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCreateQueries_t(uint target, int n, IntPtr ids);
		private static glCreateQueries_t p_glCreateQueries;
		public static void glCreateQueries(uint target, int n, IntPtr ids) => p_glCreateQueries(target, n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryBufferObjecti64v_t(uint id, uint buffer, uint pname, IntPtr offset);
		private static glGetQueryBufferObjecti64v_t p_glGetQueryBufferObjecti64v;
		public static void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, IntPtr offset) => p_glGetQueryBufferObjecti64v(id, buffer, pname, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryBufferObjectiv_t(uint id, uint buffer, uint pname, IntPtr offset);
		private static glGetQueryBufferObjectiv_t p_glGetQueryBufferObjectiv;
		public static void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, IntPtr offset) => p_glGetQueryBufferObjectiv(id, buffer, pname, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryBufferObjectui64v_t(uint id, uint buffer, uint pname, IntPtr offset);
		private static glGetQueryBufferObjectui64v_t p_glGetQueryBufferObjectui64v;
		public static void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, IntPtr offset) => p_glGetQueryBufferObjectui64v(id, buffer, pname, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryBufferObjectuiv_t(uint id, uint buffer, uint pname, IntPtr offset);
		private static glGetQueryBufferObjectuiv_t p_glGetQueryBufferObjectuiv;
		public static void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, IntPtr offset) => p_glGetQueryBufferObjectuiv(id, buffer, pname, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMemoryBarrierByRegion_t(uint barriers);
		private static glMemoryBarrierByRegion_t p_glMemoryBarrierByRegion;
		public static void glMemoryBarrierByRegion(uint barriers) => p_glMemoryBarrierByRegion(barriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTextureSubImage_t(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels);
		private static glGetTextureSubImage_t p_glGetTextureSubImage;
		public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels) => p_glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetCompressedTextureSubImage_t(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);
		private static glGetCompressedTextureSubImage_t p_glGetCompressedTextureSubImage;
		public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels) => p_glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetGraphicsResetStatus_t();
		private static glGetGraphicsResetStatus_t p_glGetGraphicsResetStatus;
		public static uint glGetGraphicsResetStatus() => p_glGetGraphicsResetStatus();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnCompressedTexImage_t(uint target, int lod, int bufSize, IntPtr pixels);
		private static glGetnCompressedTexImage_t p_glGetnCompressedTexImage;
		public static void glGetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels) => p_glGetnCompressedTexImage(target, lod, bufSize, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnTexImage_t(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels);
		private static glGetnTexImage_t p_glGetnTexImage;
		public static void glGetnTexImage(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels) => p_glGetnTexImage(target, level, format, type, bufSize, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnUniformdv_t(uint program, int location, int bufSize, IntPtr @params);
		private static glGetnUniformdv_t p_glGetnUniformdv;
		public static void glGetnUniformdv(uint program, int location, int bufSize, IntPtr @params) => p_glGetnUniformdv(program, location, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnUniformfv_t(uint program, int location, int bufSize, IntPtr @params);
		private static glGetnUniformfv_t p_glGetnUniformfv;
		public static void glGetnUniformfv(uint program, int location, int bufSize, IntPtr @params) => p_glGetnUniformfv(program, location, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnUniformiv_t(uint program, int location, int bufSize, IntPtr @params);
		private static glGetnUniformiv_t p_glGetnUniformiv;
		public static void glGetnUniformiv(uint program, int location, int bufSize, IntPtr @params) => p_glGetnUniformiv(program, location, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnUniformuiv_t(uint program, int location, int bufSize, IntPtr @params);
		private static glGetnUniformuiv_t p_glGetnUniformuiv;
		public static void glGetnUniformuiv(uint program, int location, int bufSize, IntPtr @params) => p_glGetnUniformuiv(program, location, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReadnPixels_t(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);
		private static glReadnPixels_t p_glReadnPixels;
		public static void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data) => p_glReadnPixels(x, y, width, height, format, type, bufSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnMapdv_t(uint target, uint query, int bufSize, IntPtr v);
		private static glGetnMapdv_t p_glGetnMapdv;
		public static void glGetnMapdv(uint target, uint query, int bufSize, IntPtr v) => p_glGetnMapdv(target, query, bufSize, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnMapfv_t(uint target, uint query, int bufSize, IntPtr v);
		private static glGetnMapfv_t p_glGetnMapfv;
		public static void glGetnMapfv(uint target, uint query, int bufSize, IntPtr v) => p_glGetnMapfv(target, query, bufSize, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnMapiv_t(uint target, uint query, int bufSize, IntPtr v);
		private static glGetnMapiv_t p_glGetnMapiv;
		public static void glGetnMapiv(uint target, uint query, int bufSize, IntPtr v) => p_glGetnMapiv(target, query, bufSize, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnPixelMapfv_t(uint map, int bufSize, IntPtr values);
		private static glGetnPixelMapfv_t p_glGetnPixelMapfv;
		public static void glGetnPixelMapfv(uint map, int bufSize, IntPtr values) => p_glGetnPixelMapfv(map, bufSize, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnPixelMapuiv_t(uint map, int bufSize, IntPtr values);
		private static glGetnPixelMapuiv_t p_glGetnPixelMapuiv;
		public static void glGetnPixelMapuiv(uint map, int bufSize, IntPtr values) => p_glGetnPixelMapuiv(map, bufSize, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnPixelMapusv_t(uint map, int bufSize, IntPtr values);
		private static glGetnPixelMapusv_t p_glGetnPixelMapusv;
		public static void glGetnPixelMapusv(uint map, int bufSize, IntPtr values) => p_glGetnPixelMapusv(map, bufSize, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnPolygonStipple_t(int bufSize, IntPtr pattern);
		private static glGetnPolygonStipple_t p_glGetnPolygonStipple;
		public static void glGetnPolygonStipple(int bufSize, IntPtr pattern) => p_glGetnPolygonStipple(bufSize, pattern);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnColorTable_t(uint target, uint format, uint type, int bufSize, IntPtr table);
		private static glGetnColorTable_t p_glGetnColorTable;
		public static void glGetnColorTable(uint target, uint format, uint type, int bufSize, IntPtr table) => p_glGetnColorTable(target, format, type, bufSize, table);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnConvolutionFilter_t(uint target, uint format, uint type, int bufSize, IntPtr image);
		private static glGetnConvolutionFilter_t p_glGetnConvolutionFilter;
		public static void glGetnConvolutionFilter(uint target, uint format, uint type, int bufSize, IntPtr image) => p_glGetnConvolutionFilter(target, format, type, bufSize, image);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnSeparableFilter_t(uint target, uint format, uint type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span);
		private static glGetnSeparableFilter_t p_glGetnSeparableFilter;
		public static void glGetnSeparableFilter(uint target, uint format, uint type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span) => p_glGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnHistogram_t(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values);
		private static glGetnHistogram_t p_glGetnHistogram;
		public static void glGetnHistogram(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values) => p_glGetnHistogram(target, reset, format, type, bufSize, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnMinmax_t(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values);
		private static glGetnMinmax_t p_glGetnMinmax;
		public static void glGetnMinmax(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values) => p_glGetnMinmax(target, reset, format, type, bufSize, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTextureBarrier_t();
		private static glTextureBarrier_t p_glTextureBarrier;
		public static void glTextureBarrier() => p_glTextureBarrier();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSpecializeShader_t(uint shader, IntPtr pEntryPoint, uint numSpecializationConstants, IntPtr pConstantIndex, IntPtr pConstantValue);
		private static glSpecializeShader_t p_glSpecializeShader;
		public static void glSpecializeShader(uint shader, IntPtr pEntryPoint, uint numSpecializationConstants, IntPtr pConstantIndex, IntPtr pConstantValue) => p_glSpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiDrawArraysIndirectCount_t(uint mode, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride);
		private static glMultiDrawArraysIndirectCount_t p_glMultiDrawArraysIndirectCount;
		public static void glMultiDrawArraysIndirectCount(uint mode, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => p_glMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiDrawElementsIndirectCount_t(uint mode, uint type, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride);
		private static glMultiDrawElementsIndirectCount_t p_glMultiDrawElementsIndirectCount;
		public static void glMultiDrawElementsIndirectCount(uint mode, uint type, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => p_glMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPolygonOffsetClamp_t(float factor, float units, float clamp);
		private static glPolygonOffsetClamp_t p_glPolygonOffsetClamp;
		public static void glPolygonOffsetClamp(float factor, float units, float clamp) => p_glPolygonOffsetClamp(factor, units, clamp);

		public static void LoadGetString(IntPtr glContext, Func<string, IntPtr> getProcAddress)
		{
			s_getProcAddress = getProcAddress;
			LoadFunction("glGetString", out p_glGetString);
		}

		public static void LoadAllFunctions(IntPtr glContext, Func<string, IntPtr> getProcAddress, bool gles)
		{
			s_getProcAddress = getProcAddress;

			LoadFunction("glCullFace", out p_glCullFace);
			LoadFunction("glFrontFace", out p_glFrontFace);
			LoadFunction("glHint", out p_glHint);
			LoadFunction("glLineWidth", out p_glLineWidth);
			LoadFunction("glPointSize", out p_glPointSize);
			LoadFunction("glPolygonMode", out p_glPolygonMode);
			LoadFunction("glScissor", out p_glScissor);
			LoadFunction("glTexParameterf", out p_glTexParameterf);
			LoadFunction("glTexParameterfv", out p_glTexParameterfv);
			LoadFunction("glTexParameteri", out p_glTexParameteri);
			LoadFunction("glTexParameteriv", out p_glTexParameteriv);
			LoadFunction("glTexImage1D", out p_glTexImage1D);
			LoadFunction("glTexImage2D", out p_glTexImage2D);
			LoadFunction("glDrawBuffer", out p_glDrawBuffer);
			LoadFunction("glClear", out p_glClear);
			LoadFunction("glClearColor", out p_glClearColor);
			LoadFunction("glClearStencil", out p_glClearStencil);
			LoadFunction("glClearDepth", out p_glClearDepth);
			LoadFunction("glStencilMask", out p_glStencilMask);
			LoadFunction("glColorMask", out p_glColorMask);
			LoadFunction("glDepthMask", out p_glDepthMask);
			LoadFunction("glDisable", out p_glDisable);
			LoadFunction("glEnable", out p_glEnable);
			LoadFunction("glFinish", out p_glFinish);
			LoadFunction("glFlush", out p_glFlush);
			LoadFunction("glBlendFunc", out p_glBlendFunc);
			LoadFunction("glLogicOp", out p_glLogicOp);
			LoadFunction("glStencilFunc", out p_glStencilFunc);
			LoadFunction("glStencilOp", out p_glStencilOp);
			LoadFunction("glDepthFunc", out p_glDepthFunc);
			LoadFunction("glPixelStoref", out p_glPixelStoref);
			LoadFunction("glPixelStorei", out p_glPixelStorei);
			LoadFunction("glReadBuffer", out p_glReadBuffer);
			LoadFunction("glReadPixels", out p_glReadPixels);
			LoadFunction("glGetBooleanv", out p_glGetBooleanv);
			LoadFunction("glGetDoublev", out p_glGetDoublev);
			LoadFunction("glGetError", out p_glGetError);
			LoadFunction("glGetFloatv", out p_glGetFloatv);
			LoadFunction("glGetIntegerv", out p_glGetIntegerv);
			LoadFunction("glGetString", out p_glGetString);
			LoadFunction("glGetTexImage", out p_glGetTexImage);
			LoadFunction("glGetTexParameterfv", out p_glGetTexParameterfv);
			LoadFunction("glGetTexParameteriv", out p_glGetTexParameteriv);
			LoadFunction("glGetTexLevelParameterfv", out p_glGetTexLevelParameterfv);
			LoadFunction("glGetTexLevelParameteriv", out p_glGetTexLevelParameteriv);
			LoadFunction("glIsEnabled", out p_glIsEnabled);
			LoadFunction("glDepthRange", out p_glDepthRange);
			LoadFunction("glViewport", out p_glViewport);
			LoadFunction("glDrawArrays", out p_glDrawArrays);
			LoadFunction("glDrawElements", out p_glDrawElements);
			LoadFunction("glPolygonOffset", out p_glPolygonOffset);
			LoadFunction("glCopyTexImage1D", out p_glCopyTexImage1D);
			LoadFunction("glCopyTexImage2D", out p_glCopyTexImage2D);
			LoadFunction("glCopyTexSubImage1D", out p_glCopyTexSubImage1D);
			LoadFunction("glCopyTexSubImage2D", out p_glCopyTexSubImage2D);
			LoadFunction("glTexSubImage1D", out p_glTexSubImage1D);
			LoadFunction("glTexSubImage2D", out p_glTexSubImage2D);
			LoadFunction("glBindTexture", out p_glBindTexture);
			LoadFunction("glDeleteTextures", out p_glDeleteTextures);
			LoadFunction("glGenTextures", out p_glGenTextures);
			LoadFunction("glIsTexture", out p_glIsTexture);
			LoadFunction("glDrawRangeElements", out p_glDrawRangeElements);
			LoadFunction("glTexImage3D", out p_glTexImage3D);
			LoadFunction("glTexSubImage3D", out p_glTexSubImage3D);
			LoadFunction("glCopyTexSubImage3D", out p_glCopyTexSubImage3D);
			LoadFunction("glActiveTexture", out p_glActiveTexture);
			LoadFunction("glSampleCoverage", out p_glSampleCoverage);
			LoadFunction("glCompressedTexImage3D", out p_glCompressedTexImage3D);
			LoadFunction("glCompressedTexImage2D", out p_glCompressedTexImage2D);
			LoadFunction("glCompressedTexImage1D", out p_glCompressedTexImage1D);
			LoadFunction("glCompressedTexSubImage3D", out p_glCompressedTexSubImage3D);
			LoadFunction("glCompressedTexSubImage2D", out p_glCompressedTexSubImage2D);
			LoadFunction("glCompressedTexSubImage1D", out p_glCompressedTexSubImage1D);
			LoadFunction("glGetCompressedTexImage", out p_glGetCompressedTexImage);
			LoadFunction("glBlendFuncSeparate", out p_glBlendFuncSeparate);
			LoadFunction("glMultiDrawArrays", out p_glMultiDrawArrays);
			LoadFunction("glMultiDrawElements", out p_glMultiDrawElements);
			LoadFunction("glPointParameterf", out p_glPointParameterf);
			LoadFunction("glPointParameterfv", out p_glPointParameterfv);
			LoadFunction("glPointParameteri", out p_glPointParameteri);
			LoadFunction("glPointParameteriv", out p_glPointParameteriv);
			LoadFunction("glBlendColor", out p_glBlendColor);
			LoadFunction("glBlendEquation", out p_glBlendEquation);
			LoadFunction("glGenQueries", out p_glGenQueries);
			LoadFunction("glDeleteQueries", out p_glDeleteQueries);
			LoadFunction("glIsQuery", out p_glIsQuery);
			LoadFunction("glBeginQuery", out p_glBeginQuery);
			LoadFunction("glEndQuery", out p_glEndQuery);
			LoadFunction("glGetQueryiv", out p_glGetQueryiv);
			LoadFunction("glGetQueryObjectiv", out p_glGetQueryObjectiv);
			LoadFunction("glGetQueryObjectuiv", out p_glGetQueryObjectuiv);
			LoadFunction("glBindBuffer", out p_glBindBuffer);
			LoadFunction("glDeleteBuffers", out p_glDeleteBuffers);
			LoadFunction("glGenBuffers", out p_glGenBuffers);
			LoadFunction("glIsBuffer", out p_glIsBuffer);
			LoadFunction("glBufferData", out p_glBufferData);
			LoadFunction("glBufferSubData", out p_glBufferSubData);
			LoadFunction("glGetBufferSubData", out p_glGetBufferSubData);
			LoadFunction("glMapBuffer", out p_glMapBuffer);
			LoadFunction("glUnmapBuffer", out p_glUnmapBuffer);
			LoadFunction("glGetBufferParameteriv", out p_glGetBufferParameteriv);
			LoadFunction("glGetBufferPointerv", out p_glGetBufferPointerv);
			LoadFunction("glBlendEquationSeparate", out p_glBlendEquationSeparate);
			LoadFunction("glDrawBuffers", out p_glDrawBuffers);
			LoadFunction("glStencilOpSeparate", out p_glStencilOpSeparate);
			LoadFunction("glStencilFuncSeparate", out p_glStencilFuncSeparate);
			LoadFunction("glStencilMaskSeparate", out p_glStencilMaskSeparate);
			LoadFunction("glAttachShader", out p_glAttachShader);
			LoadFunction("glBindAttribLocation", out p_glBindAttribLocation);
			LoadFunction("glCompileShader", out p_glCompileShader);
			LoadFunction("glCreateProgram", out p_glCreateProgram);
			LoadFunction("glCreateShader", out p_glCreateShader);
			LoadFunction("glDeleteProgram", out p_glDeleteProgram);
			LoadFunction("glDeleteShader", out p_glDeleteShader);
			LoadFunction("glDetachShader", out p_glDetachShader);
			LoadFunction("glDisableVertexAttribArray", out p_glDisableVertexAttribArray);
			LoadFunction("glEnableVertexAttribArray", out p_glEnableVertexAttribArray);
			LoadFunction("glGetActiveAttrib", out p_glGetActiveAttrib);
			LoadFunction("glGetActiveUniform", out p_glGetActiveUniform);
			LoadFunction("glGetAttachedShaders", out p_glGetAttachedShaders);
			LoadFunction("glGetAttribLocation", out p_glGetAttribLocation);
			LoadFunction("glGetProgramiv", out p_glGetProgramiv);
			LoadFunction("glGetProgramInfoLog", out p_glGetProgramInfoLog);
			LoadFunction("glGetShaderiv", out p_glGetShaderiv);
			LoadFunction("glGetShaderInfoLog", out p_glGetShaderInfoLog);
			LoadFunction("glGetShaderSource", out p_glGetShaderSource);
			LoadFunction("glGetUniformLocation", out p_glGetUniformLocation);
			LoadFunction("glGetUniformfv", out p_glGetUniformfv);
			LoadFunction("glGetUniformiv", out p_glGetUniformiv);
			LoadFunction("glGetVertexAttribdv", out p_glGetVertexAttribdv);
			LoadFunction("glGetVertexAttribfv", out p_glGetVertexAttribfv);
			LoadFunction("glGetVertexAttribiv", out p_glGetVertexAttribiv);
			LoadFunction("glGetVertexAttribPointerv", out p_glGetVertexAttribPointerv);
			LoadFunction("glIsProgram", out p_glIsProgram);
			LoadFunction("glIsShader", out p_glIsShader);
			LoadFunction("glLinkProgram", out p_glLinkProgram);
			LoadFunction("glShaderSource", out p_glShaderSource);
			LoadFunction("glUseProgram", out p_glUseProgram);
			LoadFunction("glUniform1f", out p_glUniform1f);
			LoadFunction("glUniform2f", out p_glUniform2f);
			LoadFunction("glUniform3f", out p_glUniform3f);
			LoadFunction("glUniform4f", out p_glUniform4f);
			LoadFunction("glUniform1i", out p_glUniform1i);
			LoadFunction("glUniform2i", out p_glUniform2i);
			LoadFunction("glUniform3i", out p_glUniform3i);
			LoadFunction("glUniform4i", out p_glUniform4i);
			LoadFunction("glUniform1fv", out p_glUniform1fv);
			LoadFunction("glUniform2fv", out p_glUniform2fv);
			LoadFunction("glUniform3fv", out p_glUniform3fv);
			LoadFunction("glUniform4fv", out p_glUniform4fv);
			LoadFunction("glUniform1iv", out p_glUniform1iv);
			LoadFunction("glUniform2iv", out p_glUniform2iv);
			LoadFunction("glUniform3iv", out p_glUniform3iv);
			LoadFunction("glUniform4iv", out p_glUniform4iv);
			LoadFunction("glUniformMatrix2fv", out p_glUniformMatrix2fv);
			LoadFunction("glUniformMatrix3fv", out p_glUniformMatrix3fv);
			LoadFunction("glUniformMatrix4fv", out p_glUniformMatrix4fv);
			LoadFunction("glValidateProgram", out p_glValidateProgram);
			LoadFunction("glVertexAttrib1d", out p_glVertexAttrib1d);
			LoadFunction("glVertexAttrib1dv", out p_glVertexAttrib1dv);
			LoadFunction("glVertexAttrib1f", out p_glVertexAttrib1f);
			LoadFunction("glVertexAttrib1fv", out p_glVertexAttrib1fv);
			LoadFunction("glVertexAttrib1s", out p_glVertexAttrib1s);
			LoadFunction("glVertexAttrib1sv", out p_glVertexAttrib1sv);
			LoadFunction("glVertexAttrib2d", out p_glVertexAttrib2d);
			LoadFunction("glVertexAttrib2dv", out p_glVertexAttrib2dv);
			LoadFunction("glVertexAttrib2f", out p_glVertexAttrib2f);
			LoadFunction("glVertexAttrib2fv", out p_glVertexAttrib2fv);
			LoadFunction("glVertexAttrib2s", out p_glVertexAttrib2s);
			LoadFunction("glVertexAttrib2sv", out p_glVertexAttrib2sv);
			LoadFunction("glVertexAttrib3d", out p_glVertexAttrib3d);
			LoadFunction("glVertexAttrib3dv", out p_glVertexAttrib3dv);
			LoadFunction("glVertexAttrib3f", out p_glVertexAttrib3f);
			LoadFunction("glVertexAttrib3fv", out p_glVertexAttrib3fv);
			LoadFunction("glVertexAttrib3s", out p_glVertexAttrib3s);
			LoadFunction("glVertexAttrib3sv", out p_glVertexAttrib3sv);
			LoadFunction("glVertexAttrib4Nbv", out p_glVertexAttrib4Nbv);
			LoadFunction("glVertexAttrib4Niv", out p_glVertexAttrib4Niv);
			LoadFunction("glVertexAttrib4Nsv", out p_glVertexAttrib4Nsv);
			LoadFunction("glVertexAttrib4Nub", out p_glVertexAttrib4Nub);
			LoadFunction("glVertexAttrib4Nubv", out p_glVertexAttrib4Nubv);
			LoadFunction("glVertexAttrib4Nuiv", out p_glVertexAttrib4Nuiv);
			LoadFunction("glVertexAttrib4Nusv", out p_glVertexAttrib4Nusv);
			LoadFunction("glVertexAttrib4bv", out p_glVertexAttrib4bv);
			LoadFunction("glVertexAttrib4d", out p_glVertexAttrib4d);
			LoadFunction("glVertexAttrib4dv", out p_glVertexAttrib4dv);
			LoadFunction("glVertexAttrib4f", out p_glVertexAttrib4f);
			LoadFunction("glVertexAttrib4fv", out p_glVertexAttrib4fv);
			LoadFunction("glVertexAttrib4iv", out p_glVertexAttrib4iv);
			LoadFunction("glVertexAttrib4s", out p_glVertexAttrib4s);
			LoadFunction("glVertexAttrib4sv", out p_glVertexAttrib4sv);
			LoadFunction("glVertexAttrib4ubv", out p_glVertexAttrib4ubv);
			LoadFunction("glVertexAttrib4uiv", out p_glVertexAttrib4uiv);
			LoadFunction("glVertexAttrib4usv", out p_glVertexAttrib4usv);
			LoadFunction("glVertexAttribPointer", out p_glVertexAttribPointer);
			LoadFunction("glUniformMatrix2x3fv", out p_glUniformMatrix2x3fv);
			LoadFunction("glUniformMatrix3x2fv", out p_glUniformMatrix3x2fv);
			LoadFunction("glUniformMatrix2x4fv", out p_glUniformMatrix2x4fv);
			LoadFunction("glUniformMatrix4x2fv", out p_glUniformMatrix4x2fv);
			LoadFunction("glUniformMatrix3x4fv", out p_glUniformMatrix3x4fv);
			LoadFunction("glUniformMatrix4x3fv", out p_glUniformMatrix4x3fv);
			LoadFunction("glColorMaski", out p_glColorMaski);
			LoadFunction("glGetBooleani_v", out p_glGetBooleani_v);
			LoadFunction("glGetIntegeri_v", out p_glGetIntegeri_v);
			LoadFunction("glEnablei", out p_glEnablei);
			LoadFunction("glDisablei", out p_glDisablei);
			LoadFunction("glIsEnabledi", out p_glIsEnabledi);
			LoadFunction("glBeginTransformFeedback", out p_glBeginTransformFeedback);
			LoadFunction("glEndTransformFeedback", out p_glEndTransformFeedback);
			LoadFunction("glBindBufferRange", out p_glBindBufferRange);
			LoadFunction("glBindBufferBase", out p_glBindBufferBase);
			LoadFunction("glTransformFeedbackVaryings", out p_glTransformFeedbackVaryings);
			LoadFunction("glGetTransformFeedbackVarying", out p_glGetTransformFeedbackVarying);
			LoadFunction("glClampColor", out p_glClampColor);
			LoadFunction("glBeginConditionalRender", out p_glBeginConditionalRender);
			LoadFunction("glEndConditionalRender", out p_glEndConditionalRender);
			LoadFunction("glVertexAttribIPointer", out p_glVertexAttribIPointer);
			LoadFunction("glGetVertexAttribIiv", out p_glGetVertexAttribIiv);
			LoadFunction("glGetVertexAttribIuiv", out p_glGetVertexAttribIuiv);
			LoadFunction("glVertexAttribI1i", out p_glVertexAttribI1i);
			LoadFunction("glVertexAttribI2i", out p_glVertexAttribI2i);
			LoadFunction("glVertexAttribI3i", out p_glVertexAttribI3i);
			LoadFunction("glVertexAttribI4i", out p_glVertexAttribI4i);
			LoadFunction("glVertexAttribI1ui", out p_glVertexAttribI1ui);
			LoadFunction("glVertexAttribI2ui", out p_glVertexAttribI2ui);
			LoadFunction("glVertexAttribI3ui", out p_glVertexAttribI3ui);
			LoadFunction("glVertexAttribI4ui", out p_glVertexAttribI4ui);
			LoadFunction("glVertexAttribI1iv", out p_glVertexAttribI1iv);
			LoadFunction("glVertexAttribI2iv", out p_glVertexAttribI2iv);
			LoadFunction("glVertexAttribI3iv", out p_glVertexAttribI3iv);
			LoadFunction("glVertexAttribI4iv", out p_glVertexAttribI4iv);
			LoadFunction("glVertexAttribI1uiv", out p_glVertexAttribI1uiv);
			LoadFunction("glVertexAttribI2uiv", out p_glVertexAttribI2uiv);
			LoadFunction("glVertexAttribI3uiv", out p_glVertexAttribI3uiv);
			LoadFunction("glVertexAttribI4uiv", out p_glVertexAttribI4uiv);
			LoadFunction("glVertexAttribI4bv", out p_glVertexAttribI4bv);
			LoadFunction("glVertexAttribI4sv", out p_glVertexAttribI4sv);
			LoadFunction("glVertexAttribI4ubv", out p_glVertexAttribI4ubv);
			LoadFunction("glVertexAttribI4usv", out p_glVertexAttribI4usv);
			LoadFunction("glGetUniformuiv", out p_glGetUniformuiv);
			LoadFunction("glBindFragDataLocation", out p_glBindFragDataLocation);
			LoadFunction("glGetFragDataLocation", out p_glGetFragDataLocation);
			LoadFunction("glUniform1ui", out p_glUniform1ui);
			LoadFunction("glUniform2ui", out p_glUniform2ui);
			LoadFunction("glUniform3ui", out p_glUniform3ui);
			LoadFunction("glUniform4ui", out p_glUniform4ui);
			LoadFunction("glUniform1uiv", out p_glUniform1uiv);
			LoadFunction("glUniform2uiv", out p_glUniform2uiv);
			LoadFunction("glUniform3uiv", out p_glUniform3uiv);
			LoadFunction("glUniform4uiv", out p_glUniform4uiv);
			LoadFunction("glTexParameterIiv", out p_glTexParameterIiv);
			LoadFunction("glTexParameterIuiv", out p_glTexParameterIuiv);
			LoadFunction("glGetTexParameterIiv", out p_glGetTexParameterIiv);
			LoadFunction("glGetTexParameterIuiv", out p_glGetTexParameterIuiv);
			LoadFunction("glClearBufferiv", out p_glClearBufferiv);
			LoadFunction("glClearBufferuiv", out p_glClearBufferuiv);
			LoadFunction("glClearBufferfv", out p_glClearBufferfv);
			LoadFunction("glClearBufferfi", out p_glClearBufferfi);
			LoadFunction("glGetStringi", out p_glGetStringi);
			LoadFunction("glIsRenderbuffer", out p_glIsRenderbuffer);
			LoadFunction("glBindRenderbuffer", out p_glBindRenderbuffer);
			LoadFunction("glDeleteRenderbuffers", out p_glDeleteRenderbuffers);
			LoadFunction("glGenRenderbuffers", out p_glGenRenderbuffers);
			LoadFunction("glRenderbufferStorage", out p_glRenderbufferStorage);
			LoadFunction("glGetRenderbufferParameteriv", out p_glGetRenderbufferParameteriv);
			LoadFunction("glIsFramebuffer", out p_glIsFramebuffer);
			LoadFunction("glBindFramebuffer", out p_glBindFramebuffer);
			LoadFunction("glDeleteFramebuffers", out p_glDeleteFramebuffers);
			LoadFunction("glGenFramebuffers", out p_glGenFramebuffers);
			LoadFunction("glCheckFramebufferStatus", out p_glCheckFramebufferStatus);
			LoadFunction("glFramebufferTexture1D", out p_glFramebufferTexture1D);
			LoadFunction("glFramebufferTexture2D", out p_glFramebufferTexture2D);
			LoadFunction("glFramebufferTexture3D", out p_glFramebufferTexture3D);
			LoadFunction("glFramebufferRenderbuffer", out p_glFramebufferRenderbuffer);
			LoadFunction("glGetFramebufferAttachmentParameteriv", out p_glGetFramebufferAttachmentParameteriv);
			LoadFunction("glGenerateMipmap", out p_glGenerateMipmap);
			LoadFunction("glBlitFramebuffer", out p_glBlitFramebuffer);
			LoadFunction("glRenderbufferStorageMultisample", out p_glRenderbufferStorageMultisample);
			LoadFunction("glFramebufferTextureLayer", out p_glFramebufferTextureLayer);
			LoadFunction("glMapBufferRange", out p_glMapBufferRange);
			LoadFunction("glFlushMappedBufferRange", out p_glFlushMappedBufferRange);
			LoadFunction("glBindVertexArray", out p_glBindVertexArray);
			LoadFunction("glDeleteVertexArrays", out p_glDeleteVertexArrays);
			LoadFunction("glGenVertexArrays", out p_glGenVertexArrays);
			LoadFunction("glIsVertexArray", out p_glIsVertexArray);
			LoadFunction("glDrawArraysInstanced", out p_glDrawArraysInstanced);
			LoadFunction("glDrawElementsInstanced", out p_glDrawElementsInstanced);
			LoadFunction("glTexBuffer", out p_glTexBuffer);
			LoadFunction("glPrimitiveRestartIndex", out p_glPrimitiveRestartIndex);
			LoadFunction("glCopyBufferSubData", out p_glCopyBufferSubData);
			LoadFunction("glGetUniformIndices", out p_glGetUniformIndices);
			LoadFunction("glGetActiveUniformsiv", out p_glGetActiveUniformsiv);
			LoadFunction("glGetActiveUniformName", out p_glGetActiveUniformName);
			LoadFunction("glGetUniformBlockIndex", out p_glGetUniformBlockIndex);
			LoadFunction("glGetActiveUniformBlockiv", out p_glGetActiveUniformBlockiv);
			LoadFunction("glGetActiveUniformBlockName", out p_glGetActiveUniformBlockName);
			LoadFunction("glUniformBlockBinding", out p_glUniformBlockBinding);
			LoadFunction("glDrawElementsBaseVertex", out p_glDrawElementsBaseVertex);
			LoadFunction("glDrawRangeElementsBaseVertex", out p_glDrawRangeElementsBaseVertex);
			LoadFunction("glDrawElementsInstancedBaseVertex", out p_glDrawElementsInstancedBaseVertex);
			LoadFunction("glMultiDrawElementsBaseVertex", out p_glMultiDrawElementsBaseVertex);
			LoadFunction("glProvokingVertex", out p_glProvokingVertex);
			LoadFunction("glFenceSync", out p_glFenceSync);
			LoadFunction("glIsSync", out p_glIsSync);
			LoadFunction("glDeleteSync", out p_glDeleteSync);
			LoadFunction("glClientWaitSync", out p_glClientWaitSync);
			LoadFunction("glWaitSync", out p_glWaitSync);
			LoadFunction("glGetInteger64v", out p_glGetInteger64v);
			LoadFunction("glGetSynciv", out p_glGetSynciv);
			LoadFunction("glGetInteger64i_v", out p_glGetInteger64i_v);
			LoadFunction("glGetBufferParameteri64v", out p_glGetBufferParameteri64v);
			LoadFunction("glFramebufferTexture", out p_glFramebufferTexture);
			LoadFunction("glTexImage2DMultisample", out p_glTexImage2DMultisample);
			LoadFunction("glTexImage3DMultisample", out p_glTexImage3DMultisample);
			LoadFunction("glGetMultisamplefv", out p_glGetMultisamplefv);
			LoadFunction("glSampleMaski", out p_glSampleMaski);
			LoadFunction("glBindFragDataLocationIndexed", out p_glBindFragDataLocationIndexed);
			LoadFunction("glGetFragDataIndex", out p_glGetFragDataIndex);
			LoadFunction("glGenSamplers", out p_glGenSamplers);
			LoadFunction("glDeleteSamplers", out p_glDeleteSamplers);
			LoadFunction("glIsSampler", out p_glIsSampler);
			LoadFunction("glBindSampler", out p_glBindSampler);
			LoadFunction("glSamplerParameteri", out p_glSamplerParameteri);
			LoadFunction("glSamplerParameteriv", out p_glSamplerParameteriv);
			LoadFunction("glSamplerParameterf", out p_glSamplerParameterf);
			LoadFunction("glSamplerParameterfv", out p_glSamplerParameterfv);
			LoadFunction("glSamplerParameterIiv", out p_glSamplerParameterIiv);
			LoadFunction("glSamplerParameterIuiv", out p_glSamplerParameterIuiv);
			LoadFunction("glGetSamplerParameteriv", out p_glGetSamplerParameteriv);
			LoadFunction("glGetSamplerParameterIiv", out p_glGetSamplerParameterIiv);
			LoadFunction("glGetSamplerParameterfv", out p_glGetSamplerParameterfv);
			LoadFunction("glGetSamplerParameterIuiv", out p_glGetSamplerParameterIuiv);
			LoadFunction("glQueryCounter", out p_glQueryCounter);
			LoadFunction("glGetQueryObjecti64v", out p_glGetQueryObjecti64v);
			LoadFunction("glGetQueryObjectui64v", out p_glGetQueryObjectui64v);
			LoadFunction("glVertexAttribDivisor", out p_glVertexAttribDivisor);
			LoadFunction("glVertexAttribP1ui", out p_glVertexAttribP1ui);
			LoadFunction("glVertexAttribP1uiv", out p_glVertexAttribP1uiv);
			LoadFunction("glVertexAttribP2ui", out p_glVertexAttribP2ui);
			LoadFunction("glVertexAttribP2uiv", out p_glVertexAttribP2uiv);
			LoadFunction("glVertexAttribP3ui", out p_glVertexAttribP3ui);
			LoadFunction("glVertexAttribP3uiv", out p_glVertexAttribP3uiv);
			LoadFunction("glVertexAttribP4ui", out p_glVertexAttribP4ui);
			LoadFunction("glVertexAttribP4uiv", out p_glVertexAttribP4uiv);
			LoadFunction("glVertexP2ui", out p_glVertexP2ui);
			LoadFunction("glVertexP2uiv", out p_glVertexP2uiv);
			LoadFunction("glVertexP3ui", out p_glVertexP3ui);
			LoadFunction("glVertexP3uiv", out p_glVertexP3uiv);
			LoadFunction("glVertexP4ui", out p_glVertexP4ui);
			LoadFunction("glVertexP4uiv", out p_glVertexP4uiv);
			LoadFunction("glTexCoordP1ui", out p_glTexCoordP1ui);
			LoadFunction("glTexCoordP1uiv", out p_glTexCoordP1uiv);
			LoadFunction("glTexCoordP2ui", out p_glTexCoordP2ui);
			LoadFunction("glTexCoordP2uiv", out p_glTexCoordP2uiv);
			LoadFunction("glTexCoordP3ui", out p_glTexCoordP3ui);
			LoadFunction("glTexCoordP3uiv", out p_glTexCoordP3uiv);
			LoadFunction("glTexCoordP4ui", out p_glTexCoordP4ui);
			LoadFunction("glTexCoordP4uiv", out p_glTexCoordP4uiv);
			LoadFunction("glMultiTexCoordP1ui", out p_glMultiTexCoordP1ui);
			LoadFunction("glMultiTexCoordP1uiv", out p_glMultiTexCoordP1uiv);
			LoadFunction("glMultiTexCoordP2ui", out p_glMultiTexCoordP2ui);
			LoadFunction("glMultiTexCoordP2uiv", out p_glMultiTexCoordP2uiv);
			LoadFunction("glMultiTexCoordP3ui", out p_glMultiTexCoordP3ui);
			LoadFunction("glMultiTexCoordP3uiv", out p_glMultiTexCoordP3uiv);
			LoadFunction("glMultiTexCoordP4ui", out p_glMultiTexCoordP4ui);
			LoadFunction("glMultiTexCoordP4uiv", out p_glMultiTexCoordP4uiv);
			LoadFunction("glNormalP3ui", out p_glNormalP3ui);
			LoadFunction("glNormalP3uiv", out p_glNormalP3uiv);
			LoadFunction("glColorP3ui", out p_glColorP3ui);
			LoadFunction("glColorP3uiv", out p_glColorP3uiv);
			LoadFunction("glColorP4ui", out p_glColorP4ui);
			LoadFunction("glColorP4uiv", out p_glColorP4uiv);
			LoadFunction("glSecondaryColorP3ui", out p_glSecondaryColorP3ui);
			LoadFunction("glSecondaryColorP3uiv", out p_glSecondaryColorP3uiv);
			LoadFunction("glMinSampleShading", out p_glMinSampleShading);
			LoadFunction("glBlendEquationi", out p_glBlendEquationi);
			LoadFunction("glBlendEquationSeparatei", out p_glBlendEquationSeparatei);
			LoadFunction("glBlendFunci", out p_glBlendFunci);
			LoadFunction("glBlendFuncSeparatei", out p_glBlendFuncSeparatei);
			LoadFunction("glDrawArraysIndirect", out p_glDrawArraysIndirect);
			LoadFunction("glDrawElementsIndirect", out p_glDrawElementsIndirect);
			LoadFunction("glUniform1d", out p_glUniform1d);
			LoadFunction("glUniform2d", out p_glUniform2d);
			LoadFunction("glUniform3d", out p_glUniform3d);
			LoadFunction("glUniform4d", out p_glUniform4d);
			LoadFunction("glUniform1dv", out p_glUniform1dv);
			LoadFunction("glUniform2dv", out p_glUniform2dv);
			LoadFunction("glUniform3dv", out p_glUniform3dv);
			LoadFunction("glUniform4dv", out p_glUniform4dv);
			LoadFunction("glUniformMatrix2dv", out p_glUniformMatrix2dv);
			LoadFunction("glUniformMatrix3dv", out p_glUniformMatrix3dv);
			LoadFunction("glUniformMatrix4dv", out p_glUniformMatrix4dv);
			LoadFunction("glUniformMatrix2x3dv", out p_glUniformMatrix2x3dv);
			LoadFunction("glUniformMatrix2x4dv", out p_glUniformMatrix2x4dv);
			LoadFunction("glUniformMatrix3x2dv", out p_glUniformMatrix3x2dv);
			LoadFunction("glUniformMatrix3x4dv", out p_glUniformMatrix3x4dv);
			LoadFunction("glUniformMatrix4x2dv", out p_glUniformMatrix4x2dv);
			LoadFunction("glUniformMatrix4x3dv", out p_glUniformMatrix4x3dv);
			LoadFunction("glGetUniformdv", out p_glGetUniformdv);
			LoadFunction("glGetSubroutineUniformLocation", out p_glGetSubroutineUniformLocation);
			LoadFunction("glGetSubroutineIndex", out p_glGetSubroutineIndex);
			LoadFunction("glGetActiveSubroutineUniformiv", out p_glGetActiveSubroutineUniformiv);
			LoadFunction("glGetActiveSubroutineUniformName", out p_glGetActiveSubroutineUniformName);
			LoadFunction("glGetActiveSubroutineName", out p_glGetActiveSubroutineName);
			LoadFunction("glUniformSubroutinesuiv", out p_glUniformSubroutinesuiv);
			LoadFunction("glGetUniformSubroutineuiv", out p_glGetUniformSubroutineuiv);
			LoadFunction("glGetProgramStageiv", out p_glGetProgramStageiv);
			LoadFunction("glPatchParameteri", out p_glPatchParameteri);
			LoadFunction("glPatchParameterfv", out p_glPatchParameterfv);
			LoadFunction("glBindTransformFeedback", out p_glBindTransformFeedback);
			LoadFunction("glDeleteTransformFeedbacks", out p_glDeleteTransformFeedbacks);
			LoadFunction("glGenTransformFeedbacks", out p_glGenTransformFeedbacks);
			LoadFunction("glIsTransformFeedback", out p_glIsTransformFeedback);
			LoadFunction("glPauseTransformFeedback", out p_glPauseTransformFeedback);
			LoadFunction("glResumeTransformFeedback", out p_glResumeTransformFeedback);
			LoadFunction("glDrawTransformFeedback", out p_glDrawTransformFeedback);
			LoadFunction("glDrawTransformFeedbackStream", out p_glDrawTransformFeedbackStream);
			LoadFunction("glBeginQueryIndexed", out p_glBeginQueryIndexed);
			LoadFunction("glEndQueryIndexed", out p_glEndQueryIndexed);
			LoadFunction("glGetQueryIndexediv", out p_glGetQueryIndexediv);
			LoadFunction("glReleaseShaderCompiler", out p_glReleaseShaderCompiler);
			LoadFunction("glShaderBinary", out p_glShaderBinary);
			LoadFunction("glGetShaderPrecisionFormat", out p_glGetShaderPrecisionFormat);
			LoadFunction("glDepthRangef", out p_glDepthRangef);
			LoadFunction("glClearDepthf", out p_glClearDepthf);
			LoadFunction("glGetProgramBinary", out p_glGetProgramBinary);
			LoadFunction("glProgramBinary", out p_glProgramBinary);
			LoadFunction("glProgramParameteri", out p_glProgramParameteri);
			LoadFunction("glUseProgramStages", out p_glUseProgramStages);
			LoadFunction("glActiveShaderProgram", out p_glActiveShaderProgram);
			LoadFunction("glCreateShaderProgramv", out p_glCreateShaderProgramv);
			LoadFunction("glBindProgramPipeline", out p_glBindProgramPipeline);
			LoadFunction("glDeleteProgramPipelines", out p_glDeleteProgramPipelines);
			LoadFunction("glGenProgramPipelines", out p_glGenProgramPipelines);
			LoadFunction("glIsProgramPipeline", out p_glIsProgramPipeline);
			LoadFunction("glGetProgramPipelineiv", out p_glGetProgramPipelineiv);
			LoadFunction("glProgramUniform1i", out p_glProgramUniform1i);
			LoadFunction("glProgramUniform1iv", out p_glProgramUniform1iv);
			LoadFunction("glProgramUniform1f", out p_glProgramUniform1f);
			LoadFunction("glProgramUniform1fv", out p_glProgramUniform1fv);
			LoadFunction("glProgramUniform1d", out p_glProgramUniform1d);
			LoadFunction("glProgramUniform1dv", out p_glProgramUniform1dv);
			LoadFunction("glProgramUniform1ui", out p_glProgramUniform1ui);
			LoadFunction("glProgramUniform1uiv", out p_glProgramUniform1uiv);
			LoadFunction("glProgramUniform2i", out p_glProgramUniform2i);
			LoadFunction("glProgramUniform2iv", out p_glProgramUniform2iv);
			LoadFunction("glProgramUniform2f", out p_glProgramUniform2f);
			LoadFunction("glProgramUniform2fv", out p_glProgramUniform2fv);
			LoadFunction("glProgramUniform2d", out p_glProgramUniform2d);
			LoadFunction("glProgramUniform2dv", out p_glProgramUniform2dv);
			LoadFunction("glProgramUniform2ui", out p_glProgramUniform2ui);
			LoadFunction("glProgramUniform2uiv", out p_glProgramUniform2uiv);
			LoadFunction("glProgramUniform3i", out p_glProgramUniform3i);
			LoadFunction("glProgramUniform3iv", out p_glProgramUniform3iv);
			LoadFunction("glProgramUniform3f", out p_glProgramUniform3f);
			LoadFunction("glProgramUniform3fv", out p_glProgramUniform3fv);
			LoadFunction("glProgramUniform3d", out p_glProgramUniform3d);
			LoadFunction("glProgramUniform3dv", out p_glProgramUniform3dv);
			LoadFunction("glProgramUniform3ui", out p_glProgramUniform3ui);
			LoadFunction("glProgramUniform3uiv", out p_glProgramUniform3uiv);
			LoadFunction("glProgramUniform4i", out p_glProgramUniform4i);
			LoadFunction("glProgramUniform4iv", out p_glProgramUniform4iv);
			LoadFunction("glProgramUniform4f", out p_glProgramUniform4f);
			LoadFunction("glProgramUniform4fv", out p_glProgramUniform4fv);
			LoadFunction("glProgramUniform4d", out p_glProgramUniform4d);
			LoadFunction("glProgramUniform4dv", out p_glProgramUniform4dv);
			LoadFunction("glProgramUniform4ui", out p_glProgramUniform4ui);
			LoadFunction("glProgramUniform4uiv", out p_glProgramUniform4uiv);
			LoadFunction("glProgramUniformMatrix2fv", out p_glProgramUniformMatrix2fv);
			LoadFunction("glProgramUniformMatrix3fv", out p_glProgramUniformMatrix3fv);
			LoadFunction("glProgramUniformMatrix4fv", out p_glProgramUniformMatrix4fv);
			LoadFunction("glProgramUniformMatrix2dv", out p_glProgramUniformMatrix2dv);
			LoadFunction("glProgramUniformMatrix3dv", out p_glProgramUniformMatrix3dv);
			LoadFunction("glProgramUniformMatrix4dv", out p_glProgramUniformMatrix4dv);
			LoadFunction("glProgramUniformMatrix2x3fv", out p_glProgramUniformMatrix2x3fv);
			LoadFunction("glProgramUniformMatrix3x2fv", out p_glProgramUniformMatrix3x2fv);
			LoadFunction("glProgramUniformMatrix2x4fv", out p_glProgramUniformMatrix2x4fv);
			LoadFunction("glProgramUniformMatrix4x2fv", out p_glProgramUniformMatrix4x2fv);
			LoadFunction("glProgramUniformMatrix3x4fv", out p_glProgramUniformMatrix3x4fv);
			LoadFunction("glProgramUniformMatrix4x3fv", out p_glProgramUniformMatrix4x3fv);
			LoadFunction("glProgramUniformMatrix2x3dv", out p_glProgramUniformMatrix2x3dv);
			LoadFunction("glProgramUniformMatrix3x2dv", out p_glProgramUniformMatrix3x2dv);
			LoadFunction("glProgramUniformMatrix2x4dv", out p_glProgramUniformMatrix2x4dv);
			LoadFunction("glProgramUniformMatrix4x2dv", out p_glProgramUniformMatrix4x2dv);
			LoadFunction("glProgramUniformMatrix3x4dv", out p_glProgramUniformMatrix3x4dv);
			LoadFunction("glProgramUniformMatrix4x3dv", out p_glProgramUniformMatrix4x3dv);
			LoadFunction("glValidateProgramPipeline", out p_glValidateProgramPipeline);
			LoadFunction("glGetProgramPipelineInfoLog", out p_glGetProgramPipelineInfoLog);
			LoadFunction("glVertexAttribL1d", out p_glVertexAttribL1d);
			LoadFunction("glVertexAttribL2d", out p_glVertexAttribL2d);
			LoadFunction("glVertexAttribL3d", out p_glVertexAttribL3d);
			LoadFunction("glVertexAttribL4d", out p_glVertexAttribL4d);
			LoadFunction("glVertexAttribL1dv", out p_glVertexAttribL1dv);
			LoadFunction("glVertexAttribL2dv", out p_glVertexAttribL2dv);
			LoadFunction("glVertexAttribL3dv", out p_glVertexAttribL3dv);
			LoadFunction("glVertexAttribL4dv", out p_glVertexAttribL4dv);
			LoadFunction("glVertexAttribLPointer", out p_glVertexAttribLPointer);
			LoadFunction("glGetVertexAttribLdv", out p_glGetVertexAttribLdv);
			LoadFunction("glViewportArrayv", out p_glViewportArrayv);
			LoadFunction("glViewportIndexedf", out p_glViewportIndexedf);
			LoadFunction("glViewportIndexedfv", out p_glViewportIndexedfv);
			LoadFunction("glScissorArrayv", out p_glScissorArrayv);
			LoadFunction("glScissorIndexed", out p_glScissorIndexed);
			LoadFunction("glScissorIndexedv", out p_glScissorIndexedv);
			LoadFunction("glDepthRangeArrayv", out p_glDepthRangeArrayv);
			LoadFunction("glDepthRangeIndexed", out p_glDepthRangeIndexed);
			LoadFunction("glGetFloati_v", out p_glGetFloati_v);
			LoadFunction("glGetDoublei_v", out p_glGetDoublei_v);
			LoadFunction("glDrawArraysInstancedBaseInstance", out p_glDrawArraysInstancedBaseInstance);
			LoadFunction("glDrawElementsInstancedBaseInstance", out p_glDrawElementsInstancedBaseInstance);
			LoadFunction("glDrawElementsInstancedBaseVertexBaseInstance", out p_glDrawElementsInstancedBaseVertexBaseInstance);
			LoadFunction("glGetInternalformativ", out p_glGetInternalformativ);
			LoadFunction("glGetActiveAtomicCounterBufferiv", out p_glGetActiveAtomicCounterBufferiv);
			LoadFunction("glBindImageTexture", out p_glBindImageTexture);
			LoadFunction("glMemoryBarrier", out p_glMemoryBarrier);
			LoadFunction("glTexStorage1D", out p_glTexStorage1D);
			LoadFunction("glTexStorage2D", out p_glTexStorage2D);
			LoadFunction("glTexStorage3D", out p_glTexStorage3D);
			LoadFunction("glDrawTransformFeedbackInstanced", out p_glDrawTransformFeedbackInstanced);
			LoadFunction("glDrawTransformFeedbackStreamInstanced", out p_glDrawTransformFeedbackStreamInstanced);
			LoadFunction("glClearBufferData", out p_glClearBufferData);
			LoadFunction("glClearBufferSubData", out p_glClearBufferSubData);
			LoadFunction("glDispatchCompute", out p_glDispatchCompute);
			LoadFunction("glDispatchComputeIndirect", out p_glDispatchComputeIndirect);
			LoadFunction("glCopyImageSubData", out p_glCopyImageSubData);
			LoadFunction("glFramebufferParameteri", out p_glFramebufferParameteri);
			LoadFunction("glGetFramebufferParameteriv", out p_glGetFramebufferParameteriv);
			LoadFunction("glGetInternalformati64v", out p_glGetInternalformati64v);
			LoadFunction("glInvalidateTexSubImage", out p_glInvalidateTexSubImage);
			LoadFunction("glInvalidateTexImage", out p_glInvalidateTexImage);
			LoadFunction("glInvalidateBufferSubData", out p_glInvalidateBufferSubData);
			LoadFunction("glInvalidateBufferData", out p_glInvalidateBufferData);
			LoadFunction("glInvalidateFramebuffer", out p_glInvalidateFramebuffer);
			LoadFunction("glInvalidateSubFramebuffer", out p_glInvalidateSubFramebuffer);
			LoadFunction("glMultiDrawArraysIndirect", out p_glMultiDrawArraysIndirect);
			LoadFunction("glMultiDrawElementsIndirect", out p_glMultiDrawElementsIndirect);
			LoadFunction("glGetProgramInterfaceiv", out p_glGetProgramInterfaceiv);
			LoadFunction("glGetProgramResourceIndex", out p_glGetProgramResourceIndex);
			LoadFunction("glGetProgramResourceName", out p_glGetProgramResourceName);
			LoadFunction("glGetProgramResourceiv", out p_glGetProgramResourceiv);
			LoadFunction("glGetProgramResourceLocation", out p_glGetProgramResourceLocation);
			LoadFunction("glGetProgramResourceLocationIndex", out p_glGetProgramResourceLocationIndex);
			LoadFunction("glShaderStorageBlockBinding", out p_glShaderStorageBlockBinding);
			LoadFunction("glTexBufferRange", out p_glTexBufferRange);
			LoadFunction("glTexStorage2DMultisample", out p_glTexStorage2DMultisample);
			LoadFunction("glTexStorage3DMultisample", out p_glTexStorage3DMultisample);
			LoadFunction("glTextureView", out p_glTextureView);
			LoadFunction("glBindVertexBuffer", out p_glBindVertexBuffer);
			LoadFunction("glVertexAttribFormat", out p_glVertexAttribFormat);
			LoadFunction("glVertexAttribIFormat", out p_glVertexAttribIFormat);
			LoadFunction("glVertexAttribLFormat", out p_glVertexAttribLFormat);
			LoadFunction("glVertexAttribBinding", out p_glVertexAttribBinding);
			LoadFunction("glVertexBindingDivisor", out p_glVertexBindingDivisor);
			LoadFunction("glDebugMessageControl", out p_glDebugMessageControl);
			LoadFunction("glDebugMessageInsert", out p_glDebugMessageInsert);
			LoadFunction("glDebugMessageCallback", out p_glDebugMessageCallback);
			LoadFunction("glGetDebugMessageLog", out p_glGetDebugMessageLog);
			LoadFunction("glPushDebugGroup", out p_glPushDebugGroup);
			LoadFunction("glPopDebugGroup", out p_glPopDebugGroup);
			LoadFunction("glObjectLabel", out p_glObjectLabel);
			LoadFunction("glGetObjectLabel", out p_glGetObjectLabel);
			LoadFunction("glObjectPtrLabel", out p_glObjectPtrLabel);
			LoadFunction("glGetObjectPtrLabel", out p_glGetObjectPtrLabel);
			LoadFunction("glGetPointerv", out p_glGetPointerv);
			LoadFunction("glBufferStorage", out p_glBufferStorage);
			LoadFunction("glClearTexImage", out p_glClearTexImage);
			LoadFunction("glClearTexSubImage", out p_glClearTexSubImage);
			LoadFunction("glBindBuffersBase", out p_glBindBuffersBase);
			LoadFunction("glBindBuffersRange", out p_glBindBuffersRange);
			LoadFunction("glBindTextures", out p_glBindTextures);
			LoadFunction("glBindSamplers", out p_glBindSamplers);
			LoadFunction("glBindImageTextures", out p_glBindImageTextures);
			LoadFunction("glBindVertexBuffers", out p_glBindVertexBuffers);
			LoadFunction("glClipControl", out p_glClipControl);
			LoadFunction("glCreateTransformFeedbacks", out p_glCreateTransformFeedbacks);
			LoadFunction("glTransformFeedbackBufferBase", out p_glTransformFeedbackBufferBase);
			LoadFunction("glTransformFeedbackBufferRange", out p_glTransformFeedbackBufferRange);
			LoadFunction("glGetTransformFeedbackiv", out p_glGetTransformFeedbackiv);
			LoadFunction("glGetTransformFeedbacki_v", out p_glGetTransformFeedbacki_v);
			LoadFunction("glGetTransformFeedbacki64_v", out p_glGetTransformFeedbacki64_v);
			LoadFunction("glCreateBuffers", out p_glCreateBuffers);
			LoadFunction("glNamedBufferStorage", out p_glNamedBufferStorage);
			LoadFunction("glNamedBufferData", out p_glNamedBufferData);
			LoadFunction("glNamedBufferSubData", out p_glNamedBufferSubData);
			LoadFunction("glCopyNamedBufferSubData", out p_glCopyNamedBufferSubData);
			LoadFunction("glClearNamedBufferData", out p_glClearNamedBufferData);
			LoadFunction("glClearNamedBufferSubData", out p_glClearNamedBufferSubData);
			LoadFunction("glMapNamedBuffer", out p_glMapNamedBuffer);
			LoadFunction("glMapNamedBufferRange", out p_glMapNamedBufferRange);
			LoadFunction("glUnmapNamedBuffer", out p_glUnmapNamedBuffer);
			LoadFunction("glFlushMappedNamedBufferRange", out p_glFlushMappedNamedBufferRange);
			LoadFunction("glGetNamedBufferParameteriv", out p_glGetNamedBufferParameteriv);
			LoadFunction("glGetNamedBufferParameteri64v", out p_glGetNamedBufferParameteri64v);
			LoadFunction("glGetNamedBufferPointerv", out p_glGetNamedBufferPointerv);
			LoadFunction("glGetNamedBufferSubData", out p_glGetNamedBufferSubData);
			LoadFunction("glCreateFramebuffers", out p_glCreateFramebuffers);
			LoadFunction("glNamedFramebufferRenderbuffer", out p_glNamedFramebufferRenderbuffer);
			LoadFunction("glNamedFramebufferParameteri", out p_glNamedFramebufferParameteri);
			LoadFunction("glNamedFramebufferTexture", out p_glNamedFramebufferTexture);
			LoadFunction("glNamedFramebufferTextureLayer", out p_glNamedFramebufferTextureLayer);
			LoadFunction("glNamedFramebufferDrawBuffer", out p_glNamedFramebufferDrawBuffer);
			LoadFunction("glNamedFramebufferDrawBuffers", out p_glNamedFramebufferDrawBuffers);
			LoadFunction("glNamedFramebufferReadBuffer", out p_glNamedFramebufferReadBuffer);
			LoadFunction("glInvalidateNamedFramebufferData", out p_glInvalidateNamedFramebufferData);
			LoadFunction("glInvalidateNamedFramebufferSubData", out p_glInvalidateNamedFramebufferSubData);
			LoadFunction("glClearNamedFramebufferiv", out p_glClearNamedFramebufferiv);
			LoadFunction("glClearNamedFramebufferuiv", out p_glClearNamedFramebufferuiv);
			LoadFunction("glClearNamedFramebufferfv", out p_glClearNamedFramebufferfv);
			LoadFunction("glClearNamedFramebufferfi", out p_glClearNamedFramebufferfi);
			LoadFunction("glBlitNamedFramebuffer", out p_glBlitNamedFramebuffer);
			LoadFunction("glCheckNamedFramebufferStatus", out p_glCheckNamedFramebufferStatus);
			LoadFunction("glGetNamedFramebufferParameteriv", out p_glGetNamedFramebufferParameteriv);
			LoadFunction("glGetNamedFramebufferAttachmentParameteriv", out p_glGetNamedFramebufferAttachmentParameteriv);
			LoadFunction("glCreateRenderbuffers", out p_glCreateRenderbuffers);
			LoadFunction("glNamedRenderbufferStorage", out p_glNamedRenderbufferStorage);
			LoadFunction("glNamedRenderbufferStorageMultisample", out p_glNamedRenderbufferStorageMultisample);
			LoadFunction("glGetNamedRenderbufferParameteriv", out p_glGetNamedRenderbufferParameteriv);
			LoadFunction("glCreateTextures", out p_glCreateTextures);
			LoadFunction("glTextureBuffer", out p_glTextureBuffer);
			LoadFunction("glTextureBufferRange", out p_glTextureBufferRange);
			LoadFunction("glTextureStorage1D", out p_glTextureStorage1D);
			LoadFunction("glTextureStorage2D", out p_glTextureStorage2D);
			LoadFunction("glTextureStorage3D", out p_glTextureStorage3D);
			LoadFunction("glTextureStorage2DMultisample", out p_glTextureStorage2DMultisample);
			LoadFunction("glTextureStorage3DMultisample", out p_glTextureStorage3DMultisample);
			LoadFunction("glTextureSubImage1D", out p_glTextureSubImage1D);
			LoadFunction("glTextureSubImage2D", out p_glTextureSubImage2D);
			LoadFunction("glTextureSubImage3D", out p_glTextureSubImage3D);
			LoadFunction("glCompressedTextureSubImage1D", out p_glCompressedTextureSubImage1D);
			LoadFunction("glCompressedTextureSubImage2D", out p_glCompressedTextureSubImage2D);
			LoadFunction("glCompressedTextureSubImage3D", out p_glCompressedTextureSubImage3D);
			LoadFunction("glCopyTextureSubImage1D", out p_glCopyTextureSubImage1D);
			LoadFunction("glCopyTextureSubImage2D", out p_glCopyTextureSubImage2D);
			LoadFunction("glCopyTextureSubImage3D", out p_glCopyTextureSubImage3D);
			LoadFunction("glTextureParameterf", out p_glTextureParameterf);
			LoadFunction("glTextureParameterfv", out p_glTextureParameterfv);
			LoadFunction("glTextureParameteri", out p_glTextureParameteri);
			LoadFunction("glTextureParameterIiv", out p_glTextureParameterIiv);
			LoadFunction("glTextureParameterIuiv", out p_glTextureParameterIuiv);
			LoadFunction("glTextureParameteriv", out p_glTextureParameteriv);
			LoadFunction("glGenerateTextureMipmap", out p_glGenerateTextureMipmap);
			LoadFunction("glBindTextureUnit", out p_glBindTextureUnit);
			LoadFunction("glGetTextureImage", out p_glGetTextureImage);
			LoadFunction("glGetCompressedTextureImage", out p_glGetCompressedTextureImage);
			LoadFunction("glGetTextureLevelParameterfv", out p_glGetTextureLevelParameterfv);
			LoadFunction("glGetTextureLevelParameteriv", out p_glGetTextureLevelParameteriv);
			LoadFunction("glGetTextureParameterfv", out p_glGetTextureParameterfv);
			LoadFunction("glGetTextureParameterIiv", out p_glGetTextureParameterIiv);
			LoadFunction("glGetTextureParameterIuiv", out p_glGetTextureParameterIuiv);
			LoadFunction("glGetTextureParameteriv", out p_glGetTextureParameteriv);
			LoadFunction("glCreateVertexArrays", out p_glCreateVertexArrays);
			LoadFunction("glDisableVertexArrayAttrib", out p_glDisableVertexArrayAttrib);
			LoadFunction("glEnableVertexArrayAttrib", out p_glEnableVertexArrayAttrib);
			LoadFunction("glVertexArrayElementBuffer", out p_glVertexArrayElementBuffer);
			LoadFunction("glVertexArrayVertexBuffer", out p_glVertexArrayVertexBuffer);
			LoadFunction("glVertexArrayVertexBuffers", out p_glVertexArrayVertexBuffers);
			LoadFunction("glVertexArrayAttribBinding", out p_glVertexArrayAttribBinding);
			LoadFunction("glVertexArrayAttribFormat", out p_glVertexArrayAttribFormat);
			LoadFunction("glVertexArrayAttribIFormat", out p_glVertexArrayAttribIFormat);
			LoadFunction("glVertexArrayAttribLFormat", out p_glVertexArrayAttribLFormat);
			LoadFunction("glVertexArrayBindingDivisor", out p_glVertexArrayBindingDivisor);
			LoadFunction("glGetVertexArrayiv", out p_glGetVertexArrayiv);
			LoadFunction("glGetVertexArrayIndexediv", out p_glGetVertexArrayIndexediv);
			LoadFunction("glGetVertexArrayIndexed64iv", out p_glGetVertexArrayIndexed64iv);
			LoadFunction("glCreateSamplers", out p_glCreateSamplers);
			LoadFunction("glCreateProgramPipelines", out p_glCreateProgramPipelines);
			LoadFunction("glCreateQueries", out p_glCreateQueries);
			LoadFunction("glGetQueryBufferObjecti64v", out p_glGetQueryBufferObjecti64v);
			LoadFunction("glGetQueryBufferObjectiv", out p_glGetQueryBufferObjectiv);
			LoadFunction("glGetQueryBufferObjectui64v", out p_glGetQueryBufferObjectui64v);
			LoadFunction("glGetQueryBufferObjectuiv", out p_glGetQueryBufferObjectuiv);
			LoadFunction("glMemoryBarrierByRegion", out p_glMemoryBarrierByRegion);
			LoadFunction("glGetTextureSubImage", out p_glGetTextureSubImage);
			LoadFunction("glGetCompressedTextureSubImage", out p_glGetCompressedTextureSubImage);
			LoadFunction("glGetGraphicsResetStatus", out p_glGetGraphicsResetStatus);
			LoadFunction("glGetnCompressedTexImage", out p_glGetnCompressedTexImage);
			LoadFunction("glGetnTexImage", out p_glGetnTexImage);
			LoadFunction("glGetnUniformdv", out p_glGetnUniformdv);
			LoadFunction("glGetnUniformfv", out p_glGetnUniformfv);
			LoadFunction("glGetnUniformiv", out p_glGetnUniformiv);
			LoadFunction("glGetnUniformuiv", out p_glGetnUniformuiv);
			LoadFunction("glReadnPixels", out p_glReadnPixels);
			LoadFunction("glGetnMapdv", out p_glGetnMapdv);
			LoadFunction("glGetnMapfv", out p_glGetnMapfv);
			LoadFunction("glGetnMapiv", out p_glGetnMapiv);
			LoadFunction("glGetnPixelMapfv", out p_glGetnPixelMapfv);
			LoadFunction("glGetnPixelMapuiv", out p_glGetnPixelMapuiv);
			LoadFunction("glGetnPixelMapusv", out p_glGetnPixelMapusv);
			LoadFunction("glGetnPolygonStipple", out p_glGetnPolygonStipple);
			LoadFunction("glGetnColorTable", out p_glGetnColorTable);
			LoadFunction("glGetnConvolutionFilter", out p_glGetnConvolutionFilter);
			LoadFunction("glGetnSeparableFilter", out p_glGetnSeparableFilter);
			LoadFunction("glGetnHistogram", out p_glGetnHistogram);
			LoadFunction("glGetnMinmax", out p_glGetnMinmax);
			LoadFunction("glTextureBarrier", out p_glTextureBarrier);
			LoadFunction("glSpecializeShader", out p_glSpecializeShader);
			LoadFunction("glMultiDrawArraysIndirectCount", out p_glMultiDrawArraysIndirectCount);
			LoadFunction("glMultiDrawElementsIndirectCount", out p_glMultiDrawElementsIndirectCount);
			LoadFunction("glPolygonOffsetClamp", out p_glPolygonOffsetClamp);
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
