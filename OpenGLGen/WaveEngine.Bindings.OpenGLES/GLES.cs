using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.OpenGLES
{
	public static unsafe class GLES
	{
		private static Func<string, IntPtr> s_getProcAddress;

		private const CallingConvention CallConv = CallingConvention.Winapi;

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glAlphaFunc_t(AlphaFunction func, float @ref);
		private static glAlphaFunc_t p_glAlphaFunc;
		public static void glAlphaFunc(AlphaFunction func, float @ref) => p_glAlphaFunc(func, @ref);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearColor_t(float red, float green, float blue, float alpha);
		private static glClearColor_t p_glClearColor;
		public static void glClearColor(float red, float green, float blue, float alpha) => p_glClearColor(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearDepthf_t(float d);
		private static glClearDepthf_t p_glClearDepthf;
		public static void glClearDepthf(float d) => p_glClearDepthf(d);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClipPlanef_t(ClipPlaneName p, float* eqn);
		private static glClipPlanef_t p_glClipPlanef;
		public static void glClipPlanef(ClipPlaneName p, float* eqn) => p_glClipPlanef(p, eqn);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColor4f_t(float red, float green, float blue, float alpha);
		private static glColor4f_t p_glColor4f;
		public static void glColor4f(float red, float green, float blue, float alpha) => p_glColor4f(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthRangef_t(float n, float f);
		private static glDepthRangef_t p_glDepthRangef;
		public static void glDepthRangef(float n, float f) => p_glDepthRangef(n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFogf_t(FogParameter pname, float param);
		private static glFogf_t p_glFogf;
		public static void glFogf(FogParameter pname, float param) => p_glFogf(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFogfv_t(FogParameter pname, float* @params);
		private static glFogfv_t p_glFogfv;
		public static void glFogfv(FogParameter pname, float* @params) => p_glFogfv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFrustumf_t(float l, float r, float b, float t, float n, float f);
		private static glFrustumf_t p_glFrustumf;
		public static void glFrustumf(float l, float r, float b, float t, float n, float f) => p_glFrustumf(l, r, b, t, n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetClipPlanef_t(ClipPlaneName plane, float* equation);
		private static glGetClipPlanef_t p_glGetClipPlanef;
		public static void glGetClipPlanef(ClipPlaneName plane, float* equation) => p_glGetClipPlanef(plane, equation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFloatv_t(GetPName pname, float* data);
		private static glGetFloatv_t p_glGetFloatv;
		public static void glGetFloatv(GetPName pname, float* data) => p_glGetFloatv(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetLightfv_t(LightName light, LightParameter pname, float* @params);
		private static glGetLightfv_t p_glGetLightfv;
		public static void glGetLightfv(LightName light, LightParameter pname, float* @params) => p_glGetLightfv(light, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetMaterialfv_t(MaterialFace face, MaterialParameter pname, float* @params);
		private static glGetMaterialfv_t p_glGetMaterialfv;
		public static void glGetMaterialfv(MaterialFace face, MaterialParameter pname, float* @params) => p_glGetMaterialfv(face, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexEnvfv_t(TextureEnvTarget target, TextureEnvParameter pname, float* @params);
		private static glGetTexEnvfv_t p_glGetTexEnvfv;
		public static void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params) => p_glGetTexEnvfv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameterfv_t(TextureTarget target, GetTextureParameter pname, float* @params);
		private static glGetTexParameterfv_t p_glGetTexParameterfv;
		public static void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* @params) => p_glGetTexParameterfv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightModelf_t(LightModelParameter pname, float param);
		private static glLightModelf_t p_glLightModelf;
		public static void glLightModelf(LightModelParameter pname, float param) => p_glLightModelf(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightModelfv_t(LightModelParameter pname, float* @params);
		private static glLightModelfv_t p_glLightModelfv;
		public static void glLightModelfv(LightModelParameter pname, float* @params) => p_glLightModelfv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightf_t(LightName light, LightParameter pname, float param);
		private static glLightf_t p_glLightf;
		public static void glLightf(LightName light, LightParameter pname, float param) => p_glLightf(light, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightfv_t(LightName light, LightParameter pname, float* @params);
		private static glLightfv_t p_glLightfv;
		public static void glLightfv(LightName light, LightParameter pname, float* @params) => p_glLightfv(light, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLineWidth_t(float width);
		private static glLineWidth_t p_glLineWidth;
		public static void glLineWidth(float width) => p_glLineWidth(width);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLoadMatrixf_t(float* m);
		private static glLoadMatrixf_t p_glLoadMatrixf;
		public static void glLoadMatrixf(float* m) => p_glLoadMatrixf(m);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMaterialf_t(MaterialFace face, MaterialParameter pname, float param);
		private static glMaterialf_t p_glMaterialf;
		public static void glMaterialf(MaterialFace face, MaterialParameter pname, float param) => p_glMaterialf(face, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMaterialfv_t(MaterialFace face, MaterialParameter pname, float* @params);
		private static glMaterialfv_t p_glMaterialfv;
		public static void glMaterialfv(MaterialFace face, MaterialParameter pname, float* @params) => p_glMaterialfv(face, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultMatrixf_t(float* m);
		private static glMultMatrixf_t p_glMultMatrixf;
		public static void glMultMatrixf(float* m) => p_glMultMatrixf(m);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoord4f_t(TextureUnit target, float s, float t, float r, float q);
		private static glMultiTexCoord4f_t p_glMultiTexCoord4f;
		public static void glMultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => p_glMultiTexCoord4f(target, s, t, r, q);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNormal3f_t(float nx, float ny, float nz);
		private static glNormal3f_t p_glNormal3f;
		public static void glNormal3f(float nx, float ny, float nz) => p_glNormal3f(nx, ny, nz);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glOrthof_t(float l, float r, float b, float t, float n, float f);
		private static glOrthof_t p_glOrthof;
		public static void glOrthof(float l, float r, float b, float t, float n, float f) => p_glOrthof(l, r, b, t, n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameterf_t(uint pname, float param);
		private static glPointParameterf_t p_glPointParameterf;
		public static void glPointParameterf(uint pname, float param) => p_glPointParameterf(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameterfv_t(uint pname, float* @params);
		private static glPointParameterfv_t p_glPointParameterfv;
		public static void glPointParameterfv(uint pname, float* @params) => p_glPointParameterfv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointSize_t(float size);
		private static glPointSize_t p_glPointSize;
		public static void glPointSize(float size) => p_glPointSize(size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPolygonOffset_t(float factor, float units);
		private static glPolygonOffset_t p_glPolygonOffset;
		public static void glPolygonOffset(float factor, float units) => p_glPolygonOffset(factor, units);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glRotatef_t(float angle, float x, float y, float z);
		private static glRotatef_t p_glRotatef;
		public static void glRotatef(float angle, float x, float y, float z) => p_glRotatef(angle, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glScalef_t(float x, float y, float z);
		private static glScalef_t p_glScalef;
		public static void glScalef(float x, float y, float z) => p_glScalef(x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexEnvf_t(TextureEnvTarget target, TextureEnvParameter pname, float param);
		private static glTexEnvf_t p_glTexEnvf;
		public static void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => p_glTexEnvf(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexEnvfv_t(TextureEnvTarget target, TextureEnvParameter pname, float* @params);
		private static glTexEnvfv_t p_glTexEnvfv;
		public static void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params) => p_glTexEnvfv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterf_t(TextureTarget target, TextureParameterName pname, float param);
		private static glTexParameterf_t p_glTexParameterf;
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, float param) => p_glTexParameterf(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterfv_t(TextureTarget target, TextureParameterName pname, float* @params);
		private static glTexParameterfv_t p_glTexParameterfv;
		public static void glTexParameterfv(TextureTarget target, TextureParameterName pname, float* @params) => p_glTexParameterfv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTranslatef_t(float x, float y, float z);
		private static glTranslatef_t p_glTranslatef;
		public static void glTranslatef(float x, float y, float z) => p_glTranslatef(x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glActiveTexture_t(TextureUnit texture);
		private static glActiveTexture_t p_glActiveTexture;
		public static void glActiveTexture(TextureUnit texture) => p_glActiveTexture(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glAlphaFuncx_t(AlphaFunction func, int @ref);
		private static glAlphaFuncx_t p_glAlphaFuncx;
		public static void glAlphaFuncx(AlphaFunction func, int @ref) => p_glAlphaFuncx(func, @ref);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBuffer_t(BufferTargetARB target, uint buffer);
		private static glBindBuffer_t p_glBindBuffer;
		public static void glBindBuffer(BufferTargetARB target, uint buffer) => p_glBindBuffer(target, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindTexture_t(TextureTarget target, uint texture);
		private static glBindTexture_t p_glBindTexture;
		public static void glBindTexture(TextureTarget target, uint texture) => p_glBindTexture(target, texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFunc_t(BlendingFactor sfactor, BlendingFactor dfactor);
		private static glBlendFunc_t p_glBlendFunc;
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => p_glBlendFunc(sfactor, dfactor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBufferData_t(BufferTargetARB target, int size, void* data, BufferUsageARB usage);
		private static glBufferData_t p_glBufferData;
		public static void glBufferData(BufferTargetARB target, int size, void* data, BufferUsageARB usage) => p_glBufferData(target, size, data, usage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBufferSubData_t(BufferTargetARB target, IntPtr offset, int size, void* data);
		private static glBufferSubData_t p_glBufferSubData;
		public static void glBufferSubData(BufferTargetARB target, IntPtr offset, int size, void* data) => p_glBufferSubData(target, offset, size, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClear_t(uint mask);
		private static glClear_t p_glClear;
		public static void glClear(uint mask) => p_glClear(mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearColorx_t(int red, int green, int blue, int alpha);
		private static glClearColorx_t p_glClearColorx;
		public static void glClearColorx(int red, int green, int blue, int alpha) => p_glClearColorx(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearDepthx_t(int depth);
		private static glClearDepthx_t p_glClearDepthx;
		public static void glClearDepthx(int depth) => p_glClearDepthx(depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearStencil_t(int s);
		private static glClearStencil_t p_glClearStencil;
		public static void glClearStencil(int s) => p_glClearStencil(s);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClientActiveTexture_t(TextureUnit texture);
		private static glClientActiveTexture_t p_glClientActiveTexture;
		public static void glClientActiveTexture(TextureUnit texture) => p_glClientActiveTexture(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClipPlanex_t(ClipPlaneName plane, IntPtr equation);
		private static glClipPlanex_t p_glClipPlanex;
		public static void glClipPlanex(ClipPlaneName plane, IntPtr equation) => p_glClipPlanex(plane, equation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColor4ub_t(byte red, byte green, byte blue, byte alpha);
		private static glColor4ub_t p_glColor4ub;
		public static void glColor4ub(byte red, byte green, byte blue, byte alpha) => p_glColor4ub(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColor4x_t(int red, int green, int blue, int alpha);
		private static glColor4x_t p_glColor4x;
		public static void glColor4x(int red, int green, int blue, int alpha) => p_glColor4x(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorMask_t(bool red, bool green, bool blue, bool alpha);
		private static glColorMask_t p_glColorMask;
		public static void glColorMask(bool red, bool green, bool blue, bool alpha) => p_glColorMask(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorPointer_t(int size, ColorPointerType type, int stride, void* pointer);
		private static glColorPointer_t p_glColorPointer;
		public static void glColorPointer(int size, ColorPointerType type, int stride, void* pointer) => p_glColorPointer(size, type, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexImage2D_t(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data);
		private static glCompressedTexImage2D_t p_glCompressedTexImage2D;
		public static void glCompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => p_glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexSubImage2D_t(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data);
		private static glCompressedTexSubImage2D_t p_glCompressedTexSubImage2D;
		public static void glCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data) => p_glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexImage2D_t(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border);
		private static glCopyTexImage2D_t p_glCopyTexImage2D;
		public static void glCopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => p_glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexSubImage2D_t(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private static glCopyTexSubImage2D_t p_glCopyTexSubImage2D;
		public static void glCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => p_glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCullFace_t(CullFaceMode mode);
		private static glCullFace_t p_glCullFace;
		public static void glCullFace(CullFaceMode mode) => p_glCullFace(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteBuffers_t(int n, uint* buffers);
		private static glDeleteBuffers_t p_glDeleteBuffers;
		public static void glDeleteBuffers(int n, uint* buffers) => p_glDeleteBuffers(n, buffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteTextures_t(int n, uint* textures);
		private static glDeleteTextures_t p_glDeleteTextures;
		public static void glDeleteTextures(int n, uint* textures) => p_glDeleteTextures(n, textures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthFunc_t(DepthFunction func);
		private static glDepthFunc_t p_glDepthFunc;
		public static void glDepthFunc(DepthFunction func) => p_glDepthFunc(func);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthMask_t(bool flag);
		private static glDepthMask_t p_glDepthMask;
		public static void glDepthMask(bool flag) => p_glDepthMask(flag);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDepthRangex_t(int n, int f);
		private static glDepthRangex_t p_glDepthRangex;
		public static void glDepthRangex(int n, int f) => p_glDepthRangex(n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDisable_t(EnableCap cap);
		private static glDisable_t p_glDisable;
		public static void glDisable(EnableCap cap) => p_glDisable(cap);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDisableClientState_t(EnableCap array);
		private static glDisableClientState_t p_glDisableClientState;
		public static void glDisableClientState(EnableCap array) => p_glDisableClientState(array);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawArrays_t(PrimitiveType mode, int first, int count);
		private static glDrawArrays_t p_glDrawArrays;
		public static void glDrawArrays(PrimitiveType mode, int first, int count) => p_glDrawArrays(mode, first, count);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElements_t(PrimitiveType mode, int count, DrawElementsType type, void* indices);
		private static glDrawElements_t p_glDrawElements;
		public static void glDrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => p_glDrawElements(mode, count, type, indices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEnable_t(EnableCap cap);
		private static glEnable_t p_glEnable;
		public static void glEnable(EnableCap cap) => p_glEnable(cap);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEnableClientState_t(EnableCap array);
		private static glEnableClientState_t p_glEnableClientState;
		public static void glEnableClientState(EnableCap array) => p_glEnableClientState(array);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFinish_t();
		private static glFinish_t p_glFinish;
		public static void glFinish() => p_glFinish();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFlush_t();
		private static glFlush_t p_glFlush;
		public static void glFlush() => p_glFlush();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFogx_t(FogPName pname, int param);
		private static glFogx_t p_glFogx;
		public static void glFogx(FogPName pname, int param) => p_glFogx(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFogxv_t(FogPName pname, IntPtr param);
		private static glFogxv_t p_glFogxv;
		public static void glFogxv(FogPName pname, IntPtr param) => p_glFogxv(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFrontFace_t(FrontFaceDirection mode);
		private static glFrontFace_t p_glFrontFace;
		public static void glFrontFace(FrontFaceDirection mode) => p_glFrontFace(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFrustumx_t(int l, int r, int b, int t, int n, int f);
		private static glFrustumx_t p_glFrustumx;
		public static void glFrustumx(int l, int r, int b, int t, int n, int f) => p_glFrustumx(l, r, b, t, n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBooleanv_t(GetPName pname, bool* data);
		private static glGetBooleanv_t p_glGetBooleanv;
		public static void glGetBooleanv(GetPName pname, bool* data) => p_glGetBooleanv(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBufferParameteriv_t(BufferTargetARB target, uint pname, int* @params);
		private static glGetBufferParameteriv_t p_glGetBufferParameteriv;
		public static void glGetBufferParameteriv(BufferTargetARB target, uint pname, int* @params) => p_glGetBufferParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetClipPlanex_t(ClipPlaneName plane, IntPtr equation);
		private static glGetClipPlanex_t p_glGetClipPlanex;
		public static void glGetClipPlanex(ClipPlaneName plane, IntPtr equation) => p_glGetClipPlanex(plane, equation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenBuffers_t(int n, uint* buffers);
		private static glGenBuffers_t p_glGenBuffers;
		public static void glGenBuffers(int n, uint* buffers) => p_glGenBuffers(n, buffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenTextures_t(int n, uint* textures);
		private static glGenTextures_t p_glGenTextures;
		public static void glGenTextures(int n, uint* textures) => p_glGenTextures(n, textures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ErrorCode glGetError_t();
		private static glGetError_t p_glGetError;
		public static ErrorCode glGetError() => p_glGetError();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFixedv_t(GetPName pname, IntPtr @params);
		private static glGetFixedv_t p_glGetFixedv;
		public static void glGetFixedv(GetPName pname, IntPtr @params) => p_glGetFixedv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetIntegerv_t(GetPName pname, int* data);
		private static glGetIntegerv_t p_glGetIntegerv;
		public static void glGetIntegerv(GetPName pname, int* data) => p_glGetIntegerv(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetLightxv_t(LightName light, LightParameter pname, IntPtr @params);
		private static glGetLightxv_t p_glGetLightxv;
		public static void glGetLightxv(LightName light, LightParameter pname, IntPtr @params) => p_glGetLightxv(light, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetMaterialxv_t(MaterialFace face, MaterialParameter pname, IntPtr @params);
		private static glGetMaterialxv_t p_glGetMaterialxv;
		public static void glGetMaterialxv(MaterialFace face, MaterialParameter pname, IntPtr @params) => p_glGetMaterialxv(face, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetPointerv_t(GetPointervPName pname, void** @params);
		private static glGetPointerv_t p_glGetPointerv;
		public static void glGetPointerv(GetPointervPName pname, void** @params) => p_glGetPointerv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate byte* glGetString_t(StringName name);
		private static glGetString_t p_glGetString;
		public static byte* glGetString(StringName name) => p_glGetString(name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexEnviv_t(TextureEnvTarget target, TextureEnvParameter pname, int* @params);
		private static glGetTexEnviv_t p_glGetTexEnviv;
		public static void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params) => p_glGetTexEnviv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexEnvxv_t(TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params);
		private static glGetTexEnvxv_t p_glGetTexEnvxv;
		public static void glGetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params) => p_glGetTexEnvxv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameteriv_t(TextureTarget target, GetTextureParameter pname, int* @params);
		private static glGetTexParameteriv_t p_glGetTexParameteriv;
		public static void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* @params) => p_glGetTexParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameterxv_t(TextureTarget target, GetTextureParameter pname, IntPtr @params);
		private static glGetTexParameterxv_t p_glGetTexParameterxv;
		public static void glGetTexParameterxv(TextureTarget target, GetTextureParameter pname, IntPtr @params) => p_glGetTexParameterxv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glHint_t(HintTarget target, HintMode mode);
		private static glHint_t p_glHint;
		public static void glHint(HintTarget target, HintMode mode) => p_glHint(target, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsBuffer_t(uint buffer);
		private static glIsBuffer_t p_glIsBuffer;
		public static bool glIsBuffer(uint buffer) => p_glIsBuffer(buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsEnabled_t(EnableCap cap);
		private static glIsEnabled_t p_glIsEnabled;
		public static bool glIsEnabled(EnableCap cap) => p_glIsEnabled(cap);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsTexture_t(uint texture);
		private static glIsTexture_t p_glIsTexture;
		public static bool glIsTexture(uint texture) => p_glIsTexture(texture);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightModelx_t(LightModelParameter pname, int param);
		private static glLightModelx_t p_glLightModelx;
		public static void glLightModelx(LightModelParameter pname, int param) => p_glLightModelx(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightModelxv_t(LightModelParameter pname, IntPtr param);
		private static glLightModelxv_t p_glLightModelxv;
		public static void glLightModelxv(LightModelParameter pname, IntPtr param) => p_glLightModelxv(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightx_t(LightName light, LightParameter pname, int param);
		private static glLightx_t p_glLightx;
		public static void glLightx(LightName light, LightParameter pname, int param) => p_glLightx(light, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLightxv_t(LightName light, LightParameter pname, IntPtr @params);
		private static glLightxv_t p_glLightxv;
		public static void glLightxv(LightName light, LightParameter pname, IntPtr @params) => p_glLightxv(light, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLineWidthx_t(int width);
		private static glLineWidthx_t p_glLineWidthx;
		public static void glLineWidthx(int width) => p_glLineWidthx(width);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLoadIdentity_t();
		private static glLoadIdentity_t p_glLoadIdentity;
		public static void glLoadIdentity() => p_glLoadIdentity();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLoadMatrixx_t(IntPtr m);
		private static glLoadMatrixx_t p_glLoadMatrixx;
		public static void glLoadMatrixx(IntPtr m) => p_glLoadMatrixx(m);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLogicOp_t(LogicOp opcode);
		private static glLogicOp_t p_glLogicOp;
		public static void glLogicOp(LogicOp opcode) => p_glLogicOp(opcode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMaterialx_t(MaterialFace face, MaterialParameter pname, int param);
		private static glMaterialx_t p_glMaterialx;
		public static void glMaterialx(MaterialFace face, MaterialParameter pname, int param) => p_glMaterialx(face, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMaterialxv_t(MaterialFace face, MaterialParameter pname, IntPtr param);
		private static glMaterialxv_t p_glMaterialxv;
		public static void glMaterialxv(MaterialFace face, MaterialParameter pname, IntPtr param) => p_glMaterialxv(face, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMatrixMode_t(MatrixMode mode);
		private static glMatrixMode_t p_glMatrixMode;
		public static void glMatrixMode(MatrixMode mode) => p_glMatrixMode(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultMatrixx_t(IntPtr m);
		private static glMultMatrixx_t p_glMultMatrixx;
		public static void glMultMatrixx(IntPtr m) => p_glMultMatrixx(m);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMultiTexCoord4x_t(TextureUnit texture, int s, int t, int r, int q);
		private static glMultiTexCoord4x_t p_glMultiTexCoord4x;
		public static void glMultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => p_glMultiTexCoord4x(texture, s, t, r, q);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNormal3x_t(int nx, int ny, int nz);
		private static glNormal3x_t p_glNormal3x;
		public static void glNormal3x(int nx, int ny, int nz) => p_glNormal3x(nx, ny, nz);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glNormalPointer_t(NormalPointerType type, int stride, void* pointer);
		private static glNormalPointer_t p_glNormalPointer;
		public static void glNormalPointer(NormalPointerType type, int stride, void* pointer) => p_glNormalPointer(type, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glOrthox_t(int l, int r, int b, int t, int n, int f);
		private static glOrthox_t p_glOrthox;
		public static void glOrthox(int l, int r, int b, int t, int n, int f) => p_glOrthox(l, r, b, t, n, f);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPixelStorei_t(PixelStoreParameter pname, int param);
		private static glPixelStorei_t p_glPixelStorei;
		public static void glPixelStorei(PixelStoreParameter pname, int param) => p_glPixelStorei(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameterx_t(uint pname, int param);
		private static glPointParameterx_t p_glPointParameterx;
		public static void glPointParameterx(uint pname, int param) => p_glPointParameterx(pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointParameterxv_t(uint pname, IntPtr @params);
		private static glPointParameterxv_t p_glPointParameterxv;
		public static void glPointParameterxv(uint pname, IntPtr @params) => p_glPointParameterxv(pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPointSizex_t(int size);
		private static glPointSizex_t p_glPointSizex;
		public static void glPointSizex(int size) => p_glPointSizex(size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPolygonOffsetx_t(int factor, int units);
		private static glPolygonOffsetx_t p_glPolygonOffsetx;
		public static void glPolygonOffsetx(int factor, int units) => p_glPolygonOffsetx(factor, units);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPopMatrix_t();
		private static glPopMatrix_t p_glPopMatrix;
		public static void glPopMatrix() => p_glPopMatrix();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPushMatrix_t();
		private static glPushMatrix_t p_glPushMatrix;
		public static void glPushMatrix() => p_glPushMatrix();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReadPixels_t(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels);
		private static glReadPixels_t p_glReadPixels;
		public static void glReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => p_glReadPixels(x, y, width, height, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glRotatex_t(int angle, int x, int y, int z);
		private static glRotatex_t p_glRotatex;
		public static void glRotatex(int angle, int x, int y, int z) => p_glRotatex(angle, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSampleCoverage_t(float value, bool invert);
		private static glSampleCoverage_t p_glSampleCoverage;
		public static void glSampleCoverage(float value, bool invert) => p_glSampleCoverage(value, invert);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSampleCoveragex_t(int value, bool invert);
		private static glSampleCoveragex_t p_glSampleCoveragex;
		public static void glSampleCoveragex(int value, bool invert) => p_glSampleCoveragex(value, invert);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glScalex_t(int x, int y, int z);
		private static glScalex_t p_glScalex;
		public static void glScalex(int x, int y, int z) => p_glScalex(x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glScissor_t(int x, int y, int width, int height);
		private static glScissor_t p_glScissor;
		public static void glScissor(int x, int y, int width, int height) => p_glScissor(x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glShadeModel_t(ShadingModel mode);
		private static glShadeModel_t p_glShadeModel;
		public static void glShadeModel(ShadingModel mode) => p_glShadeModel(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilFunc_t(StencilFunction func, int @ref, uint mask);
		private static glStencilFunc_t p_glStencilFunc;
		public static void glStencilFunc(StencilFunction func, int @ref, uint mask) => p_glStencilFunc(func, @ref, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilMask_t(uint mask);
		private static glStencilMask_t p_glStencilMask;
		public static void glStencilMask(uint mask) => p_glStencilMask(mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilOp_t(StencilOp fail, StencilOp zfail, StencilOp zpass);
		private static glStencilOp_t p_glStencilOp;
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => p_glStencilOp(fail, zfail, zpass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexCoordPointer_t(int size, TexCoordPointerType type, int stride, void* pointer);
		private static glTexCoordPointer_t p_glTexCoordPointer;
		public static void glTexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer) => p_glTexCoordPointer(size, type, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexEnvi_t(TextureEnvTarget target, TextureEnvParameter pname, int param);
		private static glTexEnvi_t p_glTexEnvi;
		public static void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => p_glTexEnvi(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexEnvx_t(TextureEnvTarget target, TextureEnvParameter pname, int param);
		private static glTexEnvx_t p_glTexEnvx;
		public static void glTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => p_glTexEnvx(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexEnviv_t(TextureEnvTarget target, TextureEnvParameter pname, int* @params);
		private static glTexEnviv_t p_glTexEnviv;
		public static void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params) => p_glTexEnviv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexEnvxv_t(TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params);
		private static glTexEnvxv_t p_glTexEnvxv;
		public static void glTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params) => p_glTexEnvxv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexImage2D_t(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels);
		private static glTexImage2D_t p_glTexImage2D;
		public static void glTexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => p_glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameteri_t(TextureTarget target, TextureParameterName pname, int param);
		private static glTexParameteri_t p_glTexParameteri;
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, int param) => p_glTexParameteri(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterx_t(TextureTarget target, GetTextureParameter pname, int param);
		private static glTexParameterx_t p_glTexParameterx;
		public static void glTexParameterx(TextureTarget target, GetTextureParameter pname, int param) => p_glTexParameterx(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameteriv_t(TextureTarget target, TextureParameterName pname, int* @params);
		private static glTexParameteriv_t p_glTexParameteriv;
		public static void glTexParameteriv(TextureTarget target, TextureParameterName pname, int* @params) => p_glTexParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterxv_t(TextureTarget target, GetTextureParameter pname, IntPtr @params);
		private static glTexParameterxv_t p_glTexParameterxv;
		public static void glTexParameterxv(TextureTarget target, GetTextureParameter pname, IntPtr @params) => p_glTexParameterxv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexSubImage2D_t(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels);
		private static glTexSubImage2D_t p_glTexSubImage2D;
		public static void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => p_glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTranslatex_t(int x, int y, int z);
		private static glTranslatex_t p_glTranslatex;
		public static void glTranslatex(int x, int y, int z) => p_glTranslatex(x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexPointer_t(int size, VertexPointerType type, int stride, void* pointer);
		private static glVertexPointer_t p_glVertexPointer;
		public static void glVertexPointer(int size, VertexPointerType type, int stride, void* pointer) => p_glVertexPointer(size, type, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glViewport_t(int x, int y, int width, int height);
		private static glViewport_t p_glViewport;
		public static void glViewport(int x, int y, int width, int height) => p_glViewport(x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glAttachShader_t(uint program, uint shader);
		private static glAttachShader_t p_glAttachShader;
		public static void glAttachShader(uint program, uint shader) => p_glAttachShader(program, shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindAttribLocation_t(uint program, uint index, char* name);
		private static glBindAttribLocation_t p_glBindAttribLocation;
		public static void glBindAttribLocation(uint program, uint index, char* name) => p_glBindAttribLocation(program, index, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindFramebuffer_t(FramebufferTarget target, uint framebuffer);
		private static glBindFramebuffer_t p_glBindFramebuffer;
		public static void glBindFramebuffer(FramebufferTarget target, uint framebuffer) => p_glBindFramebuffer(target, framebuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindRenderbuffer_t(RenderbufferTarget target, uint renderbuffer);
		private static glBindRenderbuffer_t p_glBindRenderbuffer;
		public static void glBindRenderbuffer(RenderbufferTarget target, uint renderbuffer) => p_glBindRenderbuffer(target, renderbuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendColor_t(float red, float green, float blue, float alpha);
		private static glBlendColor_t p_glBlendColor;
		public static void glBlendColor(float red, float green, float blue, float alpha) => p_glBlendColor(red, green, blue, alpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquation_t(BlendEquationModeEXT mode);
		private static glBlendEquation_t p_glBlendEquation;
		public static void glBlendEquation(BlendEquationModeEXT mode) => p_glBlendEquation(mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquationSeparate_t(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
		private static glBlendEquationSeparate_t p_glBlendEquationSeparate;
		public static void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => p_glBlendEquationSeparate(modeRGB, modeAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFuncSeparate_t(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);
		private static glBlendFuncSeparate_t p_glBlendFuncSeparate;
		public static void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => p_glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate FramebufferStatus glCheckFramebufferStatus_t(FramebufferTarget target);
		private static glCheckFramebufferStatus_t p_glCheckFramebufferStatus;
		public static FramebufferStatus glCheckFramebufferStatus(FramebufferTarget target) => p_glCheckFramebufferStatus(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompileShader_t(uint shader);
		private static glCompileShader_t p_glCompileShader;
		public static void glCompileShader(uint shader) => p_glCompileShader(shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCreateProgram_t();
		private static glCreateProgram_t p_glCreateProgram;
		public static uint glCreateProgram() => p_glCreateProgram();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCreateShader_t(ShaderType type);
		private static glCreateShader_t p_glCreateShader;
		public static uint glCreateShader(ShaderType type) => p_glCreateShader(type);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteFramebuffers_t(int n, uint* framebuffers);
		private static glDeleteFramebuffers_t p_glDeleteFramebuffers;
		public static void glDeleteFramebuffers(int n, uint* framebuffers) => p_glDeleteFramebuffers(n, framebuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteProgram_t(uint program);
		private static glDeleteProgram_t p_glDeleteProgram;
		public static void glDeleteProgram(uint program) => p_glDeleteProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteRenderbuffers_t(int n, uint* renderbuffers);
		private static glDeleteRenderbuffers_t p_glDeleteRenderbuffers;
		public static void glDeleteRenderbuffers(int n, uint* renderbuffers) => p_glDeleteRenderbuffers(n, renderbuffers);

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
		private delegate void glFramebufferRenderbuffer_t(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
		private static glFramebufferRenderbuffer_t p_glFramebufferRenderbuffer;
		public static void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer) => p_glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTexture2D_t(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
		private static glFramebufferTexture2D_t p_glFramebufferTexture2D;
		public static void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => p_glFramebufferTexture2D(target, attachment, textarget, texture, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenerateMipmap_t(TextureTarget target);
		private static glGenerateMipmap_t p_glGenerateMipmap;
		public static void glGenerateMipmap(TextureTarget target) => p_glGenerateMipmap(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenFramebuffers_t(int n, uint* framebuffers);
		private static glGenFramebuffers_t p_glGenFramebuffers;
		public static void glGenFramebuffers(int n, uint* framebuffers) => p_glGenFramebuffers(n, framebuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenRenderbuffers_t(int n, uint* renderbuffers);
		private static glGenRenderbuffers_t p_glGenRenderbuffers;
		public static void glGenRenderbuffers(int n, uint* renderbuffers) => p_glGenRenderbuffers(n, renderbuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveAttrib_t(uint program, uint index, int bufSize, int* length, int* size, IntPtr type, char* name);
		private static glGetActiveAttrib_t p_glGetActiveAttrib;
		public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, IntPtr type, char* name) => p_glGetActiveAttrib(program, index, bufSize, length, size, type, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniform_t(uint program, uint index, int bufSize, int* length, int* size, IntPtr type, char* name);
		private static glGetActiveUniform_t p_glGetActiveUniform;
		public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, IntPtr type, char* name) => p_glGetActiveUniform(program, index, bufSize, length, size, type, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetAttachedShaders_t(uint program, int maxCount, int* count, uint* shaders);
		private static glGetAttachedShaders_t p_glGetAttachedShaders;
		public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) => p_glGetAttachedShaders(program, maxCount, count, shaders);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetAttribLocation_t(uint program, char* name);
		private static glGetAttribLocation_t p_glGetAttribLocation;
		public static int glGetAttribLocation(uint program, char* name) => p_glGetAttribLocation(program, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFramebufferAttachmentParameteriv_t(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params);
		private static glGetFramebufferAttachmentParameteriv_t p_glGetFramebufferAttachmentParameteriv;
		public static void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params) => p_glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramiv_t(uint program, ProgramPropertyARB pname, int* @params);
		private static glGetProgramiv_t p_glGetProgramiv;
		public static void glGetProgramiv(uint program, ProgramPropertyARB pname, int* @params) => p_glGetProgramiv(program, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramInfoLog_t(uint program, int bufSize, int* length, char* infoLog);
		private static glGetProgramInfoLog_t p_glGetProgramInfoLog;
		public static void glGetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog) => p_glGetProgramInfoLog(program, bufSize, length, infoLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetRenderbufferParameteriv_t(RenderbufferTarget target, RenderbufferParameterName pname, int* @params);
		private static glGetRenderbufferParameteriv_t p_glGetRenderbufferParameteriv;
		public static void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* @params) => p_glGetRenderbufferParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderiv_t(uint shader, ShaderParameterName pname, int* @params);
		private static glGetShaderiv_t p_glGetShaderiv;
		public static void glGetShaderiv(uint shader, ShaderParameterName pname, int* @params) => p_glGetShaderiv(shader, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderInfoLog_t(uint shader, int bufSize, int* length, char* infoLog);
		private static glGetShaderInfoLog_t p_glGetShaderInfoLog;
		public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog) => p_glGetShaderInfoLog(shader, bufSize, length, infoLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderPrecisionFormat_t(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision);
		private static glGetShaderPrecisionFormat_t p_glGetShaderPrecisionFormat;
		public static void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => p_glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetShaderSource_t(uint shader, int bufSize, int* length, char* source);
		private static glGetShaderSource_t p_glGetShaderSource;
		public static void glGetShaderSource(uint shader, int bufSize, int* length, char* source) => p_glGetShaderSource(shader, bufSize, length, source);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformfv_t(uint program, int location, float* @params);
		private static glGetUniformfv_t p_glGetUniformfv;
		public static void glGetUniformfv(uint program, int location, float* @params) => p_glGetUniformfv(program, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformiv_t(uint program, int location, int* @params);
		private static glGetUniformiv_t p_glGetUniformiv;
		public static void glGetUniformiv(uint program, int location, int* @params) => p_glGetUniformiv(program, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetUniformLocation_t(uint program, char* name);
		private static glGetUniformLocation_t p_glGetUniformLocation;
		public static int glGetUniformLocation(uint program, char* name) => p_glGetUniformLocation(program, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribfv_t(uint index, uint pname, float* @params);
		private static glGetVertexAttribfv_t p_glGetVertexAttribfv;
		public static void glGetVertexAttribfv(uint index, uint pname, float* @params) => p_glGetVertexAttribfv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribiv_t(uint index, uint pname, int* @params);
		private static glGetVertexAttribiv_t p_glGetVertexAttribiv;
		public static void glGetVertexAttribiv(uint index, uint pname, int* @params) => p_glGetVertexAttribiv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribPointerv_t(uint index, uint pname, void** pointer);
		private static glGetVertexAttribPointerv_t p_glGetVertexAttribPointerv;
		public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer) => p_glGetVertexAttribPointerv(index, pname, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsFramebuffer_t(uint framebuffer);
		private static glIsFramebuffer_t p_glIsFramebuffer;
		public static bool glIsFramebuffer(uint framebuffer) => p_glIsFramebuffer(framebuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsProgram_t(uint program);
		private static glIsProgram_t p_glIsProgram;
		public static bool glIsProgram(uint program) => p_glIsProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsRenderbuffer_t(uint renderbuffer);
		private static glIsRenderbuffer_t p_glIsRenderbuffer;
		public static bool glIsRenderbuffer(uint renderbuffer) => p_glIsRenderbuffer(renderbuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsShader_t(uint shader);
		private static glIsShader_t p_glIsShader;
		public static bool glIsShader(uint shader) => p_glIsShader(shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glLinkProgram_t(uint program);
		private static glLinkProgram_t p_glLinkProgram;
		public static void glLinkProgram(uint program) => p_glLinkProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReleaseShaderCompiler_t();
		private static glReleaseShaderCompiler_t p_glReleaseShaderCompiler;
		public static void glReleaseShaderCompiler() => p_glReleaseShaderCompiler();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glRenderbufferStorage_t(RenderbufferTarget target, InternalFormat internalformat, int width, int height);
		private static glRenderbufferStorage_t p_glRenderbufferStorage;
		public static void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => p_glRenderbufferStorage(target, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glShaderBinary_t(int count, uint* shaders, uint binaryformat, void* binary, int length);
		private static glShaderBinary_t p_glShaderBinary;
		public static void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length) => p_glShaderBinary(count, shaders, binaryformat, binary, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glShaderSource_t(uint shader, int count, IntPtr @string, int* length);
		private static glShaderSource_t p_glShaderSource;
		public static void glShaderSource(uint shader, int count, IntPtr @string, int* length) => p_glShaderSource(shader, count, @string, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilFuncSeparate_t(StencilFaceDirection face, StencilFunction func, int @ref, uint mask);
		private static glStencilFuncSeparate_t p_glStencilFuncSeparate;
		public static void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int @ref, uint mask) => p_glStencilFuncSeparate(face, func, @ref, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilMaskSeparate_t(StencilFaceDirection face, uint mask);
		private static glStencilMaskSeparate_t p_glStencilMaskSeparate;
		public static void glStencilMaskSeparate(StencilFaceDirection face, uint mask) => p_glStencilMaskSeparate(face, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glStencilOpSeparate_t(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
		private static glStencilOpSeparate_t p_glStencilOpSeparate;
		public static void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => p_glStencilOpSeparate(face, sfail, dpfail, dppass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1f_t(int location, float v0);
		private static glUniform1f_t p_glUniform1f;
		public static void glUniform1f(int location, float v0) => p_glUniform1f(location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1fv_t(int location, int count, float* value);
		private static glUniform1fv_t p_glUniform1fv;
		public static void glUniform1fv(int location, int count, float* value) => p_glUniform1fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1i_t(int location, int v0);
		private static glUniform1i_t p_glUniform1i;
		public static void glUniform1i(int location, int v0) => p_glUniform1i(location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform1iv_t(int location, int count, int* value);
		private static glUniform1iv_t p_glUniform1iv;
		public static void glUniform1iv(int location, int count, int* value) => p_glUniform1iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2f_t(int location, float v0, float v1);
		private static glUniform2f_t p_glUniform2f;
		public static void glUniform2f(int location, float v0, float v1) => p_glUniform2f(location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2fv_t(int location, int count, float* value);
		private static glUniform2fv_t p_glUniform2fv;
		public static void glUniform2fv(int location, int count, float* value) => p_glUniform2fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2i_t(int location, int v0, int v1);
		private static glUniform2i_t p_glUniform2i;
		public static void glUniform2i(int location, int v0, int v1) => p_glUniform2i(location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2iv_t(int location, int count, int* value);
		private static glUniform2iv_t p_glUniform2iv;
		public static void glUniform2iv(int location, int count, int* value) => p_glUniform2iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3f_t(int location, float v0, float v1, float v2);
		private static glUniform3f_t p_glUniform3f;
		public static void glUniform3f(int location, float v0, float v1, float v2) => p_glUniform3f(location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3fv_t(int location, int count, float* value);
		private static glUniform3fv_t p_glUniform3fv;
		public static void glUniform3fv(int location, int count, float* value) => p_glUniform3fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3i_t(int location, int v0, int v1, int v2);
		private static glUniform3i_t p_glUniform3i;
		public static void glUniform3i(int location, int v0, int v1, int v2) => p_glUniform3i(location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3iv_t(int location, int count, int* value);
		private static glUniform3iv_t p_glUniform3iv;
		public static void glUniform3iv(int location, int count, int* value) => p_glUniform3iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4f_t(int location, float v0, float v1, float v2, float v3);
		private static glUniform4f_t p_glUniform4f;
		public static void glUniform4f(int location, float v0, float v1, float v2, float v3) => p_glUniform4f(location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4fv_t(int location, int count, float* value);
		private static glUniform4fv_t p_glUniform4fv;
		public static void glUniform4fv(int location, int count, float* value) => p_glUniform4fv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4i_t(int location, int v0, int v1, int v2, int v3);
		private static glUniform4i_t p_glUniform4i;
		public static void glUniform4i(int location, int v0, int v1, int v2, int v3) => p_glUniform4i(location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4iv_t(int location, int count, int* value);
		private static glUniform4iv_t p_glUniform4iv;
		public static void glUniform4iv(int location, int count, int* value) => p_glUniform4iv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix2fv_t p_glUniformMatrix2fv;
		public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix2fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix3fv_t p_glUniformMatrix3fv;
		public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix3fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix4fv_t p_glUniformMatrix4fv;
		public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix4fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUseProgram_t(uint program);
		private static glUseProgram_t p_glUseProgram;
		public static void glUseProgram(uint program) => p_glUseProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glValidateProgram_t(uint program);
		private static glValidateProgram_t p_glValidateProgram;
		public static void glValidateProgram(uint program) => p_glValidateProgram(program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1f_t(uint index, float x);
		private static glVertexAttrib1f_t p_glVertexAttrib1f;
		public static void glVertexAttrib1f(uint index, float x) => p_glVertexAttrib1f(index, x);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib1fv_t(uint index, float* v);
		private static glVertexAttrib1fv_t p_glVertexAttrib1fv;
		public static void glVertexAttrib1fv(uint index, float* v) => p_glVertexAttrib1fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2f_t(uint index, float x, float y);
		private static glVertexAttrib2f_t p_glVertexAttrib2f;
		public static void glVertexAttrib2f(uint index, float x, float y) => p_glVertexAttrib2f(index, x, y);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib2fv_t(uint index, float* v);
		private static glVertexAttrib2fv_t p_glVertexAttrib2fv;
		public static void glVertexAttrib2fv(uint index, float* v) => p_glVertexAttrib2fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3f_t(uint index, float x, float y, float z);
		private static glVertexAttrib3f_t p_glVertexAttrib3f;
		public static void glVertexAttrib3f(uint index, float x, float y, float z) => p_glVertexAttrib3f(index, x, y, z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib3fv_t(uint index, float* v);
		private static glVertexAttrib3fv_t p_glVertexAttrib3fv;
		public static void glVertexAttrib3fv(uint index, float* v) => p_glVertexAttrib3fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4f_t(uint index, float x, float y, float z, float w);
		private static glVertexAttrib4f_t p_glVertexAttrib4f;
		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w) => p_glVertexAttrib4f(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttrib4fv_t(uint index, float* v);
		private static glVertexAttrib4fv_t p_glVertexAttrib4fv;
		public static void glVertexAttrib4fv(uint index, float* v) => p_glVertexAttrib4fv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribPointer_t(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer);
		private static glVertexAttribPointer_t p_glVertexAttribPointer;
		public static void glVertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer) => p_glVertexAttribPointer(index, size, type, normalized, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReadBuffer_t(ReadBufferMode src);
		private static glReadBuffer_t p_glReadBuffer;
		public static void glReadBuffer(ReadBufferMode src) => p_glReadBuffer(src);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawRangeElements_t(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices);
		private static glDrawRangeElements_t p_glDrawRangeElements;
		public static void glDrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => p_glDrawRangeElements(mode, start, end, count, type, indices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexImage3D_t(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels);
		private static glTexImage3D_t p_glTexImage3D;
		public static void glTexImage3D(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => p_glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexSubImage3D_t(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels);
		private static glTexSubImage3D_t p_glTexSubImage3D;
		public static void glTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => p_glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyTexSubImage3D_t(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private static glCopyTexSubImage3D_t p_glCopyTexSubImage3D;
		public static void glCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => p_glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexImage3D_t(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data);
		private static glCompressedTexImage3D_t p_glCompressedTexImage3D;
		public static void glCompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => p_glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCompressedTexSubImage3D_t(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data);
		private static glCompressedTexSubImage3D_t p_glCompressedTexSubImage3D;
		public static void glCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, void* data) => p_glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenQueries_t(int n, uint* ids);
		private static glGenQueries_t p_glGenQueries;
		public static void glGenQueries(int n, uint* ids) => p_glGenQueries(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteQueries_t(int n, uint* ids);
		private static glDeleteQueries_t p_glDeleteQueries;
		public static void glDeleteQueries(int n, uint* ids) => p_glDeleteQueries(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsQuery_t(uint id);
		private static glIsQuery_t p_glIsQuery;
		public static bool glIsQuery(uint id) => p_glIsQuery(id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBeginQuery_t(QueryTarget target, uint id);
		private static glBeginQuery_t p_glBeginQuery;
		public static void glBeginQuery(QueryTarget target, uint id) => p_glBeginQuery(target, id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEndQuery_t(QueryTarget target);
		private static glEndQuery_t p_glEndQuery;
		public static void glEndQuery(QueryTarget target) => p_glEndQuery(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryiv_t(QueryTarget target, QueryParameterName pname, int* @params);
		private static glGetQueryiv_t p_glGetQueryiv;
		public static void glGetQueryiv(QueryTarget target, QueryParameterName pname, int* @params) => p_glGetQueryiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetQueryObjectuiv_t(uint id, QueryObjectParameterName pname, uint* @params);
		private static glGetQueryObjectuiv_t p_glGetQueryObjectuiv;
		public static void glGetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint* @params) => p_glGetQueryObjectuiv(id, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glUnmapBuffer_t(BufferTargetARB target);
		private static glUnmapBuffer_t p_glUnmapBuffer;
		public static bool glUnmapBuffer(BufferTargetARB target) => p_glUnmapBuffer(target);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBufferPointerv_t(BufferTargetARB target, uint pname, void** @params);
		private static glGetBufferPointerv_t p_glGetBufferPointerv;
		public static void glGetBufferPointerv(BufferTargetARB target, uint pname, void** @params) => p_glGetBufferPointerv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawBuffers_t(int n, IntPtr bufs);
		private static glDrawBuffers_t p_glDrawBuffers;
		public static void glDrawBuffers(int n, IntPtr bufs) => p_glDrawBuffers(n, bufs);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2x3fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix2x3fv_t p_glUniformMatrix2x3fv;
		public static void glUniformMatrix2x3fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix2x3fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3x2fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix3x2fv_t p_glUniformMatrix3x2fv;
		public static void glUniformMatrix3x2fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix3x2fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix2x4fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix2x4fv_t p_glUniformMatrix2x4fv;
		public static void glUniformMatrix2x4fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix2x4fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4x2fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix4x2fv_t p_glUniformMatrix4x2fv;
		public static void glUniformMatrix4x2fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix4x2fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix3x4fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix3x4fv_t p_glUniformMatrix3x4fv;
		public static void glUniformMatrix3x4fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix3x4fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformMatrix4x3fv_t(int location, int count, bool transpose, float* value);
		private static glUniformMatrix4x3fv_t p_glUniformMatrix4x3fv;
		public static void glUniformMatrix4x3fv(int location, int count, bool transpose, float* value) => p_glUniformMatrix4x3fv(location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlitFramebuffer_t(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter);
		private static glBlitFramebuffer_t p_glBlitFramebuffer;
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter) => p_glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glRenderbufferStorageMultisample_t(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height);
		private static glRenderbufferStorageMultisample_t p_glRenderbufferStorageMultisample;
		public static void glRenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => p_glRenderbufferStorageMultisample(target, samples, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTextureLayer_t(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);
		private static glFramebufferTextureLayer_t p_glFramebufferTextureLayer;
		public static void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer) => p_glFramebufferTextureLayer(target, attachment, texture, level, layer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void* glMapBufferRange_t(BufferTargetARB target, IntPtr offset, int length, uint access);
		private static glMapBufferRange_t p_glMapBufferRange;
		public static void* glMapBufferRange(BufferTargetARB target, IntPtr offset, int length, uint access) => p_glMapBufferRange(target, offset, length, access);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFlushMappedBufferRange_t(BufferTargetARB target, IntPtr offset, int length);
		private static glFlushMappedBufferRange_t p_glFlushMappedBufferRange;
		public static void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, int length) => p_glFlushMappedBufferRange(target, offset, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindVertexArray_t(uint array);
		private static glBindVertexArray_t p_glBindVertexArray;
		public static void glBindVertexArray(uint array) => p_glBindVertexArray(array);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteVertexArrays_t(int n, uint* arrays);
		private static glDeleteVertexArrays_t p_glDeleteVertexArrays;
		public static void glDeleteVertexArrays(int n, uint* arrays) => p_glDeleteVertexArrays(n, arrays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenVertexArrays_t(int n, uint* arrays);
		private static glGenVertexArrays_t p_glGenVertexArrays;
		public static void glGenVertexArrays(int n, uint* arrays) => p_glGenVertexArrays(n, arrays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsVertexArray_t(uint array);
		private static glIsVertexArray_t p_glIsVertexArray;
		public static bool glIsVertexArray(uint array) => p_glIsVertexArray(array);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetIntegeri_v_t(TypeEnum target, uint index, int* data);
		private static glGetIntegeri_v_t p_glGetIntegeri_v;
		public static void glGetIntegeri_v(TypeEnum target, uint index, int* data) => p_glGetIntegeri_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBeginTransformFeedback_t(PrimitiveType primitiveMode);
		private static glBeginTransformFeedback_t p_glBeginTransformFeedback;
		public static void glBeginTransformFeedback(PrimitiveType primitiveMode) => p_glBeginTransformFeedback(primitiveMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEndTransformFeedback_t();
		private static glEndTransformFeedback_t p_glEndTransformFeedback;
		public static void glEndTransformFeedback() => p_glEndTransformFeedback();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBufferRange_t(BufferTargetARB target, uint index, uint buffer, IntPtr offset, int size);
		private static glBindBufferRange_t p_glBindBufferRange;
		public static void glBindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, int size) => p_glBindBufferRange(target, index, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindBufferBase_t(BufferTargetARB target, uint index, uint buffer);
		private static glBindBufferBase_t p_glBindBufferBase;
		public static void glBindBufferBase(BufferTargetARB target, uint index, uint buffer) => p_glBindBufferBase(target, index, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTransformFeedbackVaryings_t(uint program, int count, IntPtr varyings, uint bufferMode);
		private static glTransformFeedbackVaryings_t p_glTransformFeedbackVaryings;
		public static void glTransformFeedbackVaryings(uint program, int count, IntPtr varyings, uint bufferMode) => p_glTransformFeedbackVaryings(program, count, varyings, bufferMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTransformFeedbackVarying_t(uint program, uint index, int bufSize, int* length, int* size, IntPtr type, char* name);
		private static glGetTransformFeedbackVarying_t p_glGetTransformFeedbackVarying;
		public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, IntPtr type, char* name) => p_glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribIPointer_t(uint index, int size, VertexAttribPointerType type, int stride, void* pointer);
		private static glVertexAttribIPointer_t p_glVertexAttribIPointer;
		public static void glVertexAttribIPointer(uint index, int size, VertexAttribPointerType type, int stride, void* pointer) => p_glVertexAttribIPointer(index, size, type, stride, pointer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribIiv_t(uint index, VertexAttribEnum pname, int* @params);
		private static glGetVertexAttribIiv_t p_glGetVertexAttribIiv;
		public static void glGetVertexAttribIiv(uint index, VertexAttribEnum pname, int* @params) => p_glGetVertexAttribIiv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetVertexAttribIuiv_t(uint index, VertexAttribEnum pname, uint* @params);
		private static glGetVertexAttribIuiv_t p_glGetVertexAttribIuiv;
		public static void glGetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* @params) => p_glGetVertexAttribIuiv(index, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4i_t(uint index, int x, int y, int z, int w);
		private static glVertexAttribI4i_t p_glVertexAttribI4i;
		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w) => p_glVertexAttribI4i(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4ui_t(uint index, uint x, uint y, uint z, uint w);
		private static glVertexAttribI4ui_t p_glVertexAttribI4ui;
		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => p_glVertexAttribI4ui(index, x, y, z, w);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4iv_t(uint index, int* v);
		private static glVertexAttribI4iv_t p_glVertexAttribI4iv;
		public static void glVertexAttribI4iv(uint index, int* v) => p_glVertexAttribI4iv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribI4uiv_t(uint index, uint* v);
		private static glVertexAttribI4uiv_t p_glVertexAttribI4uiv;
		public static void glVertexAttribI4uiv(uint index, uint* v) => p_glVertexAttribI4uiv(index, v);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformuiv_t(uint program, int location, uint* @params);
		private static glGetUniformuiv_t p_glGetUniformuiv;
		public static void glGetUniformuiv(uint program, int location, uint* @params) => p_glGetUniformuiv(program, location, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetFragDataLocation_t(uint program, char* name);
		private static glGetFragDataLocation_t p_glGetFragDataLocation;
		public static int glGetFragDataLocation(uint program, char* name) => p_glGetFragDataLocation(program, name);

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
		private delegate void glUniform1uiv_t(int location, int count, uint* value);
		private static glUniform1uiv_t p_glUniform1uiv;
		public static void glUniform1uiv(int location, int count, uint* value) => p_glUniform1uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform2uiv_t(int location, int count, uint* value);
		private static glUniform2uiv_t p_glUniform2uiv;
		public static void glUniform2uiv(int location, int count, uint* value) => p_glUniform2uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform3uiv_t(int location, int count, uint* value);
		private static glUniform3uiv_t p_glUniform3uiv;
		public static void glUniform3uiv(int location, int count, uint* value) => p_glUniform3uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniform4uiv_t(int location, int count, uint* value);
		private static glUniform4uiv_t p_glUniform4uiv;
		public static void glUniform4uiv(int location, int count, uint* value) => p_glUniform4uiv(location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferiv_t(Buffer buffer, int drawbuffer, int* value);
		private static glClearBufferiv_t p_glClearBufferiv;
		public static void glClearBufferiv(Buffer buffer, int drawbuffer, int* value) => p_glClearBufferiv(buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferuiv_t(Buffer buffer, int drawbuffer, uint* value);
		private static glClearBufferuiv_t p_glClearBufferuiv;
		public static void glClearBufferuiv(Buffer buffer, int drawbuffer, uint* value) => p_glClearBufferuiv(buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferfv_t(Buffer buffer, int drawbuffer, float* value);
		private static glClearBufferfv_t p_glClearBufferfv;
		public static void glClearBufferfv(Buffer buffer, int drawbuffer, float* value) => p_glClearBufferfv(buffer, drawbuffer, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glClearBufferfi_t(Buffer buffer, int drawbuffer, float depth, int stencil);
		private static glClearBufferfi_t p_glClearBufferfi;
		public static void glClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => p_glClearBufferfi(buffer, drawbuffer, depth, stencil);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate byte* glGetStringi_t(StringName name, uint index);
		private static glGetStringi_t p_glGetStringi;
		public static byte* glGetStringi(StringName name, uint index) => p_glGetStringi(name, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyBufferSubData_t(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, int size);
		private static glCopyBufferSubData_t p_glCopyBufferSubData;
		public static void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, int size) => p_glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetUniformIndices_t(uint program, int uniformCount, IntPtr uniformNames, uint* uniformIndices);
		private static glGetUniformIndices_t p_glGetUniformIndices;
		public static void glGetUniformIndices(uint program, int uniformCount, IntPtr uniformNames, uint* uniformIndices) => p_glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniformsiv_t(uint program, int uniformCount, uint* uniformIndices, UniformPName pname, int* @params);
		private static glGetActiveUniformsiv_t p_glGetActiveUniformsiv;
		public static void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, UniformPName pname, int* @params) => p_glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetUniformBlockIndex_t(uint program, char* uniformBlockName);
		private static glGetUniformBlockIndex_t p_glGetUniformBlockIndex;
		public static uint glGetUniformBlockIndex(uint program, char* uniformBlockName) => p_glGetUniformBlockIndex(program, uniformBlockName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniformBlockiv_t(uint program, uint uniformBlockIndex, UniformBlockPName pname, int* @params);
		private static glGetActiveUniformBlockiv_t p_glGetActiveUniformBlockiv;
		public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int* @params) => p_glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetActiveUniformBlockName_t(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName);
		private static glGetActiveUniformBlockName_t p_glGetActiveUniformBlockName;
		public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName) => p_glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUniformBlockBinding_t(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
		private static glUniformBlockBinding_t p_glUniformBlockBinding;
		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) => p_glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawArraysInstanced_t(PrimitiveType mode, int first, int count, int instancecount);
		private static glDrawArraysInstanced_t p_glDrawArraysInstanced;
		public static void glDrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount) => p_glDrawArraysInstanced(mode, first, count, instancecount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsInstanced_t(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount);
		private static glDrawElementsInstanced_t p_glDrawElementsInstanced;
		public static void glDrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount) => p_glDrawElementsInstanced(mode, count, type, indices, instancecount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr glFenceSync_t(SyncCondition condition, uint flags);
		private static glFenceSync_t p_glFenceSync;
		public static IntPtr glFenceSync(SyncCondition condition, uint flags) => p_glFenceSync(condition, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsSync_t(IntPtr sync);
		private static glIsSync_t p_glIsSync;
		public static bool glIsSync(IntPtr sync) => p_glIsSync(sync);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteSync_t(IntPtr sync);
		private static glDeleteSync_t p_glDeleteSync;
		public static void glDeleteSync(IntPtr sync) => p_glDeleteSync(sync);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate SyncStatus glClientWaitSync_t(IntPtr sync, uint flags, ulong timeout);
		private static glClientWaitSync_t p_glClientWaitSync;
		public static SyncStatus glClientWaitSync(IntPtr sync, uint flags, ulong timeout) => p_glClientWaitSync(sync, flags, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glWaitSync_t(IntPtr sync, uint flags, ulong timeout);
		private static glWaitSync_t p_glWaitSync;
		public static void glWaitSync(IntPtr sync, uint flags, ulong timeout) => p_glWaitSync(sync, flags, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetInteger64v_t(GetPName pname, long* data);
		private static glGetInteger64v_t p_glGetInteger64v;
		public static void glGetInteger64v(GetPName pname, long* data) => p_glGetInteger64v(pname, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSynciv_t(IntPtr sync, SyncParameterName pname, int bufSize, int* length, int* values);
		private static glGetSynciv_t p_glGetSynciv;
		public static void glGetSynciv(IntPtr sync, SyncParameterName pname, int bufSize, int* length, int* values) => p_glGetSynciv(sync, pname, bufSize, length, values);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetInteger64i_v_t(TypeEnum target, uint index, long* data);
		private static glGetInteger64i_v_t p_glGetInteger64i_v;
		public static void glGetInteger64i_v(TypeEnum target, uint index, long* data) => p_glGetInteger64i_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBufferParameteri64v_t(BufferTargetARB target, uint pname, long* @params);
		private static glGetBufferParameteri64v_t p_glGetBufferParameteri64v;
		public static void glGetBufferParameteri64v(BufferTargetARB target, uint pname, long* @params) => p_glGetBufferParameteri64v(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenSamplers_t(int count, uint* samplers);
		private static glGenSamplers_t p_glGenSamplers;
		public static void glGenSamplers(int count, uint* samplers) => p_glGenSamplers(count, samplers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteSamplers_t(int count, uint* samplers);
		private static glDeleteSamplers_t p_glDeleteSamplers;
		public static void glDeleteSamplers(int count, uint* samplers) => p_glDeleteSamplers(count, samplers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsSampler_t(uint sampler);
		private static glIsSampler_t p_glIsSampler;
		public static bool glIsSampler(uint sampler) => p_glIsSampler(sampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindSampler_t(uint unit, uint sampler);
		private static glBindSampler_t p_glBindSampler;
		public static void glBindSampler(uint unit, uint sampler) => p_glBindSampler(unit, sampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameteri_t(uint sampler, SamplerParameterName pname, int param);
		private static glSamplerParameteri_t p_glSamplerParameteri;
		public static void glSamplerParameteri(uint sampler, SamplerParameterName pname, int param) => p_glSamplerParameteri(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameteriv_t(uint sampler, SamplerParameterName pname, int* param);
		private static glSamplerParameteriv_t p_glSamplerParameteriv;
		public static void glSamplerParameteriv(uint sampler, SamplerParameterName pname, int* param) => p_glSamplerParameteriv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterf_t(uint sampler, SamplerParameterName pname, float param);
		private static glSamplerParameterf_t p_glSamplerParameterf;
		public static void glSamplerParameterf(uint sampler, SamplerParameterName pname, float param) => p_glSamplerParameterf(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterfv_t(uint sampler, SamplerParameterName pname, float* param);
		private static glSamplerParameterfv_t p_glSamplerParameterfv;
		public static void glSamplerParameterfv(uint sampler, SamplerParameterName pname, float* param) => p_glSamplerParameterfv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameteriv_t(uint sampler, SamplerParameterName pname, int* @params);
		private static glGetSamplerParameteriv_t p_glGetSamplerParameteriv;
		public static void glGetSamplerParameteriv(uint sampler, SamplerParameterName pname, int* @params) => p_glGetSamplerParameteriv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameterfv_t(uint sampler, SamplerParameterName pname, float* @params);
		private static glGetSamplerParameterfv_t p_glGetSamplerParameterfv;
		public static void glGetSamplerParameterfv(uint sampler, SamplerParameterName pname, float* @params) => p_glGetSamplerParameterfv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexAttribDivisor_t(uint index, uint divisor);
		private static glVertexAttribDivisor_t p_glVertexAttribDivisor;
		public static void glVertexAttribDivisor(uint index, uint divisor) => p_glVertexAttribDivisor(index, divisor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindTransformFeedback_t(BindTransformFeedbackTarget target, uint id);
		private static glBindTransformFeedback_t p_glBindTransformFeedback;
		public static void glBindTransformFeedback(BindTransformFeedbackTarget target, uint id) => p_glBindTransformFeedback(target, id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteTransformFeedbacks_t(int n, uint* ids);
		private static glDeleteTransformFeedbacks_t p_glDeleteTransformFeedbacks;
		public static void glDeleteTransformFeedbacks(int n, uint* ids) => p_glDeleteTransformFeedbacks(n, ids);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenTransformFeedbacks_t(int n, uint* ids);
		private static glGenTransformFeedbacks_t p_glGenTransformFeedbacks;
		public static void glGenTransformFeedbacks(int n, uint* ids) => p_glGenTransformFeedbacks(n, ids);

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
		private delegate void glGetProgramBinary_t(uint program, int bufSize, int* length, IntPtr binaryFormat, void* binary);
		private static glGetProgramBinary_t p_glGetProgramBinary;
		public static void glGetProgramBinary(uint program, int bufSize, int* length, IntPtr binaryFormat, void* binary) => p_glGetProgramBinary(program, bufSize, length, binaryFormat, binary);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramBinary_t(uint program, uint binaryFormat, void* binary, int length);
		private static glProgramBinary_t p_glProgramBinary;
		public static void glProgramBinary(uint program, uint binaryFormat, void* binary, int length) => p_glProgramBinary(program, binaryFormat, binary, length);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramParameteri_t(uint program, ProgramParameterPName pname, int value);
		private static glProgramParameteri_t p_glProgramParameteri;
		public static void glProgramParameteri(uint program, ProgramParameterPName pname, int value) => p_glProgramParameteri(program, pname, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateFramebuffer_t(FramebufferTarget target, int numAttachments, IntPtr attachments);
		private static glInvalidateFramebuffer_t p_glInvalidateFramebuffer;
		public static void glInvalidateFramebuffer(FramebufferTarget target, int numAttachments, IntPtr attachments) => p_glInvalidateFramebuffer(target, numAttachments, attachments);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glInvalidateSubFramebuffer_t(uint target, int numAttachments, IntPtr attachments, int x, int y, int width, int height);
		private static glInvalidateSubFramebuffer_t p_glInvalidateSubFramebuffer;
		public static void glInvalidateSubFramebuffer(uint target, int numAttachments, IntPtr attachments, int x, int y, int width, int height) => p_glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage2D_t(TextureTarget target, int levels, InternalFormat internalformat, int width, int height);
		private static glTexStorage2D_t p_glTexStorage2D;
		public static void glTexStorage2D(TextureTarget target, int levels, InternalFormat internalformat, int width, int height) => p_glTexStorage2D(target, levels, internalformat, width, height);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage3D_t(TextureTarget target, int levels, InternalFormat internalformat, int width, int height, int depth);
		private static glTexStorage3D_t p_glTexStorage3D;
		public static void glTexStorage3D(TextureTarget target, int levels, InternalFormat internalformat, int width, int height, int depth) => p_glTexStorage3D(target, levels, internalformat, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetInternalformativ_t(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int bufSize, int* @params);
		private static glGetInternalformativ_t p_glGetInternalformativ;
		public static void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int bufSize, int* @params) => p_glGetInternalformativ(target, internalformat, pname, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDispatchCompute_t(uint num_groups_x, uint num_groups_y, uint num_groups_z);
		private static glDispatchCompute_t p_glDispatchCompute;
		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => p_glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDispatchComputeIndirect_t(IntPtr indirect);
		private static glDispatchComputeIndirect_t p_glDispatchComputeIndirect;
		public static void glDispatchComputeIndirect(IntPtr indirect) => p_glDispatchComputeIndirect(indirect);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawArraysIndirect_t(PrimitiveType mode, void* indirect);
		private static glDrawArraysIndirect_t p_glDrawArraysIndirect;
		public static void glDrawArraysIndirect(PrimitiveType mode, void* indirect) => p_glDrawArraysIndirect(mode, indirect);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsIndirect_t(PrimitiveType mode, DrawElementsType type, void* indirect);
		private static glDrawElementsIndirect_t p_glDrawElementsIndirect;
		public static void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => p_glDrawElementsIndirect(mode, type, indirect);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferParameteri_t(FramebufferTarget target, FramebufferParameterName pname, int param);
		private static glFramebufferParameteri_t p_glFramebufferParameteri;
		public static void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => p_glFramebufferParameteri(target, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetFramebufferParameteriv_t(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* @params);
		private static glGetFramebufferParameteriv_t p_glGetFramebufferParameteriv;
		public static void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* @params) => p_glGetFramebufferParameteriv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramInterfaceiv_t(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int* @params);
		private static glGetProgramInterfaceiv_t p_glGetProgramInterfaceiv;
		public static void glGetProgramInterfaceiv(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int* @params) => p_glGetProgramInterfaceiv(program, programInterface, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetProgramResourceIndex_t(uint program, ProgramInterface programInterface, char* name);
		private static glGetProgramResourceIndex_t p_glGetProgramResourceIndex;
		public static uint glGetProgramResourceIndex(uint program, ProgramInterface programInterface, char* name) => p_glGetProgramResourceIndex(program, programInterface, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramResourceName_t(uint program, ProgramInterface programInterface, uint index, int bufSize, int* length, char* name);
		private static glGetProgramResourceName_t p_glGetProgramResourceName;
		public static void glGetProgramResourceName(uint program, ProgramInterface programInterface, uint index, int bufSize, int* length, char* name) => p_glGetProgramResourceName(program, programInterface, index, bufSize, length, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramResourceiv_t(uint program, ProgramInterface programInterface, uint index, int propCount, IntPtr props, int bufSize, int* length, int* @params);
		private static glGetProgramResourceiv_t p_glGetProgramResourceiv;
		public static void glGetProgramResourceiv(uint program, ProgramInterface programInterface, uint index, int propCount, IntPtr props, int bufSize, int* length, int* @params) => p_glGetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate int glGetProgramResourceLocation_t(uint program, ProgramInterface programInterface, char* name);
		private static glGetProgramResourceLocation_t p_glGetProgramResourceLocation;
		public static int glGetProgramResourceLocation(uint program, ProgramInterface programInterface, char* name) => p_glGetProgramResourceLocation(program, programInterface, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glUseProgramStages_t(uint pipeline, uint stages, uint program);
		private static glUseProgramStages_t p_glUseProgramStages;
		public static void glUseProgramStages(uint pipeline, uint stages, uint program) => p_glUseProgramStages(pipeline, stages, program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glActiveShaderProgram_t(uint pipeline, uint program);
		private static glActiveShaderProgram_t p_glActiveShaderProgram;
		public static void glActiveShaderProgram(uint pipeline, uint program) => p_glActiveShaderProgram(pipeline, program);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glCreateShaderProgramv_t(ShaderType type, int count, IntPtr strings);
		private static glCreateShaderProgramv_t p_glCreateShaderProgramv;
		public static uint glCreateShaderProgramv(ShaderType type, int count, IntPtr strings) => p_glCreateShaderProgramv(type, count, strings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindProgramPipeline_t(uint pipeline);
		private static glBindProgramPipeline_t p_glBindProgramPipeline;
		public static void glBindProgramPipeline(uint pipeline) => p_glBindProgramPipeline(pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDeleteProgramPipelines_t(int n, uint* pipelines);
		private static glDeleteProgramPipelines_t p_glDeleteProgramPipelines;
		public static void glDeleteProgramPipelines(int n, uint* pipelines) => p_glDeleteProgramPipelines(n, pipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGenProgramPipelines_t(int n, uint* pipelines);
		private static glGenProgramPipelines_t p_glGenProgramPipelines;
		public static void glGenProgramPipelines(int n, uint* pipelines) => p_glGenProgramPipelines(n, pipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsProgramPipeline_t(uint pipeline);
		private static glIsProgramPipeline_t p_glIsProgramPipeline;
		public static bool glIsProgramPipeline(uint pipeline) => p_glIsProgramPipeline(pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramPipelineiv_t(uint pipeline, PipelineParameterName pname, int* @params);
		private static glGetProgramPipelineiv_t p_glGetProgramPipelineiv;
		public static void glGetProgramPipelineiv(uint pipeline, PipelineParameterName pname, int* @params) => p_glGetProgramPipelineiv(pipeline, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1i_t(uint program, int location, int v0);
		private static glProgramUniform1i_t p_glProgramUniform1i;
		public static void glProgramUniform1i(uint program, int location, int v0) => p_glProgramUniform1i(program, location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2i_t(uint program, int location, int v0, int v1);
		private static glProgramUniform2i_t p_glProgramUniform2i;
		public static void glProgramUniform2i(uint program, int location, int v0, int v1) => p_glProgramUniform2i(program, location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3i_t(uint program, int location, int v0, int v1, int v2);
		private static glProgramUniform3i_t p_glProgramUniform3i;
		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2) => p_glProgramUniform3i(program, location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4i_t(uint program, int location, int v0, int v1, int v2, int v3);
		private static glProgramUniform4i_t p_glProgramUniform4i;
		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) => p_glProgramUniform4i(program, location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1ui_t(uint program, int location, uint v0);
		private static glProgramUniform1ui_t p_glProgramUniform1ui;
		public static void glProgramUniform1ui(uint program, int location, uint v0) => p_glProgramUniform1ui(program, location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2ui_t(uint program, int location, uint v0, uint v1);
		private static glProgramUniform2ui_t p_glProgramUniform2ui;
		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1) => p_glProgramUniform2ui(program, location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3ui_t(uint program, int location, uint v0, uint v1, uint v2);
		private static glProgramUniform3ui_t p_glProgramUniform3ui;
		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) => p_glProgramUniform3ui(program, location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4ui_t(uint program, int location, uint v0, uint v1, uint v2, uint v3);
		private static glProgramUniform4ui_t p_glProgramUniform4ui;
		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) => p_glProgramUniform4ui(program, location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1f_t(uint program, int location, float v0);
		private static glProgramUniform1f_t p_glProgramUniform1f;
		public static void glProgramUniform1f(uint program, int location, float v0) => p_glProgramUniform1f(program, location, v0);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2f_t(uint program, int location, float v0, float v1);
		private static glProgramUniform2f_t p_glProgramUniform2f;
		public static void glProgramUniform2f(uint program, int location, float v0, float v1) => p_glProgramUniform2f(program, location, v0, v1);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3f_t(uint program, int location, float v0, float v1, float v2);
		private static glProgramUniform3f_t p_glProgramUniform3f;
		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2) => p_glProgramUniform3f(program, location, v0, v1, v2);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4f_t(uint program, int location, float v0, float v1, float v2, float v3);
		private static glProgramUniform4f_t p_glProgramUniform4f;
		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) => p_glProgramUniform4f(program, location, v0, v1, v2, v3);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1iv_t(uint program, int location, int count, int* value);
		private static glProgramUniform1iv_t p_glProgramUniform1iv;
		public static void glProgramUniform1iv(uint program, int location, int count, int* value) => p_glProgramUniform1iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2iv_t(uint program, int location, int count, int* value);
		private static glProgramUniform2iv_t p_glProgramUniform2iv;
		public static void glProgramUniform2iv(uint program, int location, int count, int* value) => p_glProgramUniform2iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3iv_t(uint program, int location, int count, int* value);
		private static glProgramUniform3iv_t p_glProgramUniform3iv;
		public static void glProgramUniform3iv(uint program, int location, int count, int* value) => p_glProgramUniform3iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4iv_t(uint program, int location, int count, int* value);
		private static glProgramUniform4iv_t p_glProgramUniform4iv;
		public static void glProgramUniform4iv(uint program, int location, int count, int* value) => p_glProgramUniform4iv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1uiv_t(uint program, int location, int count, uint* value);
		private static glProgramUniform1uiv_t p_glProgramUniform1uiv;
		public static void glProgramUniform1uiv(uint program, int location, int count, uint* value) => p_glProgramUniform1uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2uiv_t(uint program, int location, int count, uint* value);
		private static glProgramUniform2uiv_t p_glProgramUniform2uiv;
		public static void glProgramUniform2uiv(uint program, int location, int count, uint* value) => p_glProgramUniform2uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3uiv_t(uint program, int location, int count, uint* value);
		private static glProgramUniform3uiv_t p_glProgramUniform3uiv;
		public static void glProgramUniform3uiv(uint program, int location, int count, uint* value) => p_glProgramUniform3uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4uiv_t(uint program, int location, int count, uint* value);
		private static glProgramUniform4uiv_t p_glProgramUniform4uiv;
		public static void glProgramUniform4uiv(uint program, int location, int count, uint* value) => p_glProgramUniform4uiv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform1fv_t(uint program, int location, int count, float* value);
		private static glProgramUniform1fv_t p_glProgramUniform1fv;
		public static void glProgramUniform1fv(uint program, int location, int count, float* value) => p_glProgramUniform1fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform2fv_t(uint program, int location, int count, float* value);
		private static glProgramUniform2fv_t p_glProgramUniform2fv;
		public static void glProgramUniform2fv(uint program, int location, int count, float* value) => p_glProgramUniform2fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform3fv_t(uint program, int location, int count, float* value);
		private static glProgramUniform3fv_t p_glProgramUniform3fv;
		public static void glProgramUniform3fv(uint program, int location, int count, float* value) => p_glProgramUniform3fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniform4fv_t(uint program, int location, int count, float* value);
		private static glProgramUniform4fv_t p_glProgramUniform4fv;
		public static void glProgramUniform4fv(uint program, int location, int count, float* value) => p_glProgramUniform4fv(program, location, count, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix2fv_t p_glProgramUniformMatrix2fv;
		public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix2fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix3fv_t p_glProgramUniformMatrix3fv;
		public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix3fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix4fv_t p_glProgramUniformMatrix4fv;
		public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix4fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2x3fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix2x3fv_t p_glProgramUniformMatrix2x3fv;
		public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix2x3fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3x2fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix3x2fv_t p_glProgramUniformMatrix3x2fv;
		public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix3x2fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix2x4fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix2x4fv_t p_glProgramUniformMatrix2x4fv;
		public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix2x4fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4x2fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix4x2fv_t p_glProgramUniformMatrix4x2fv;
		public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix4x2fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix3x4fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix3x4fv_t p_glProgramUniformMatrix3x4fv;
		public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix3x4fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glProgramUniformMatrix4x3fv_t(uint program, int location, int count, bool transpose, float* value);
		private static glProgramUniformMatrix4x3fv_t p_glProgramUniformMatrix4x3fv;
		public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value) => p_glProgramUniformMatrix4x3fv(program, location, count, transpose, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glValidateProgramPipeline_t(uint pipeline);
		private static glValidateProgramPipeline_t p_glValidateProgramPipeline;
		public static void glValidateProgramPipeline(uint pipeline) => p_glValidateProgramPipeline(pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetProgramPipelineInfoLog_t(uint pipeline, int bufSize, int* length, char* infoLog);
		private static glGetProgramPipelineInfoLog_t p_glGetProgramPipelineInfoLog;
		public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog) => p_glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBindImageTexture_t(uint unit, uint texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format);
		private static glBindImageTexture_t p_glBindImageTexture;
		public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format) => p_glBindImageTexture(unit, texture, level, layered, layer, access, format);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetBooleani_v_t(BufferTargetARB target, uint index, bool* data);
		private static glGetBooleani_v_t p_glGetBooleani_v;
		public static void glGetBooleani_v(BufferTargetARB target, uint index, bool* data) => p_glGetBooleani_v(target, index, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMemoryBarrier_t(uint barriers);
		private static glMemoryBarrier_t p_glMemoryBarrier;
		public static void glMemoryBarrier(uint barriers) => p_glMemoryBarrier(barriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMemoryBarrierByRegion_t(uint barriers);
		private static glMemoryBarrierByRegion_t p_glMemoryBarrierByRegion;
		public static void glMemoryBarrierByRegion(uint barriers) => p_glMemoryBarrierByRegion(barriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage2DMultisample_t(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations);
		private static glTexStorage2DMultisample_t p_glTexStorage2DMultisample;
		public static void glTexStorage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations) => p_glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetMultisamplefv_t(uint pname, uint index, float* val);
		private static glGetMultisamplefv_t p_glGetMultisamplefv;
		public static void glGetMultisamplefv(uint pname, uint index, float* val) => p_glGetMultisamplefv(pname, index, val);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSampleMaski_t(uint maskNumber, uint mask);
		private static glSampleMaski_t p_glSampleMaski;
		public static void glSampleMaski(uint maskNumber, uint mask) => p_glSampleMaski(maskNumber, mask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexLevelParameteriv_t(TextureTarget target, int level, GetTextureParameter pname, int* @params);
		private static glGetTexLevelParameteriv_t p_glGetTexLevelParameteriv;
		public static void glGetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* @params) => p_glGetTexLevelParameteriv(target, level, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexLevelParameterfv_t(TextureTarget target, int level, GetTextureParameter pname, float* @params);
		private static glGetTexLevelParameterfv_t p_glGetTexLevelParameterfv;
		public static void glGetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* @params) => p_glGetTexLevelParameterfv(target, level, pname, @params);

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
		private delegate void glVertexAttribBinding_t(uint attribindex, uint bindingindex);
		private static glVertexAttribBinding_t p_glVertexAttribBinding;
		public static void glVertexAttribBinding(uint attribindex, uint bindingindex) => p_glVertexAttribBinding(attribindex, bindingindex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glVertexBindingDivisor_t(uint bindingindex, uint divisor);
		private static glVertexBindingDivisor_t p_glVertexBindingDivisor;
		public static void glVertexBindingDivisor(uint bindingindex, uint divisor) => p_glVertexBindingDivisor(bindingindex, divisor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendBarrier_t();
		private static glBlendBarrier_t p_glBlendBarrier;
		public static void glBlendBarrier() => p_glBlendBarrier();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glCopyImageSubData_t(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		private static glCopyImageSubData_t p_glCopyImageSubData;
		public static void glCopyImageSubData(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => p_glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDebugMessageControl_t(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled);
		private static glDebugMessageControl_t p_glDebugMessageControl;
		public static void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => p_glDebugMessageControl(source, type, severity, count, ids, enabled);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDebugMessageInsert_t(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* buf);
		private static glDebugMessageInsert_t p_glDebugMessageInsert;
		public static void glDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* buf) => p_glDebugMessageInsert(source, type, id, severity, length, buf);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDebugMessageCallback_t(IntPtr callback, void* userParam);
		private static glDebugMessageCallback_t p_glDebugMessageCallback;
		public static void glDebugMessageCallback(IntPtr callback, void* userParam) => p_glDebugMessageCallback(callback, userParam);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint glGetDebugMessageLog_t(uint count, int bufSize, IntPtr sources, IntPtr types, uint* ids, IntPtr severities, int* lengths, char* messageLog);
		private static glGetDebugMessageLog_t p_glGetDebugMessageLog;
		public static uint glGetDebugMessageLog(uint count, int bufSize, IntPtr sources, IntPtr types, uint* ids, IntPtr severities, int* lengths, char* messageLog) => p_glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPushDebugGroup_t(DebugSource source, uint id, int length, char* message);
		private static glPushDebugGroup_t p_glPushDebugGroup;
		public static void glPushDebugGroup(DebugSource source, uint id, int length, char* message) => p_glPushDebugGroup(source, id, length, message);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPopDebugGroup_t();
		private static glPopDebugGroup_t p_glPopDebugGroup;
		public static void glPopDebugGroup() => p_glPopDebugGroup();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glObjectLabel_t(ObjectIdentifier identifier, uint name, int length, char* label);
		private static glObjectLabel_t p_glObjectLabel;
		public static void glObjectLabel(ObjectIdentifier identifier, uint name, int length, char* label) => p_glObjectLabel(identifier, name, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetObjectLabel_t(uint identifier, uint name, int bufSize, int* length, char* label);
		private static glGetObjectLabel_t p_glGetObjectLabel;
		public static void glGetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label) => p_glGetObjectLabel(identifier, name, bufSize, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glObjectPtrLabel_t(void* ptr, int length, char* label);
		private static glObjectPtrLabel_t p_glObjectPtrLabel;
		public static void glObjectPtrLabel(void* ptr, int length, char* label) => p_glObjectPtrLabel(ptr, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetObjectPtrLabel_t(void* ptr, int bufSize, int* length, char* label);
		private static glGetObjectPtrLabel_t p_glGetObjectPtrLabel;
		public static void glGetObjectPtrLabel(void* ptr, int bufSize, int* length, char* label) => p_glGetObjectPtrLabel(ptr, bufSize, length, label);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glEnablei_t(EnableCap target, uint index);
		private static glEnablei_t p_glEnablei;
		public static void glEnablei(EnableCap target, uint index) => p_glEnablei(target, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDisablei_t(EnableCap target, uint index);
		private static glDisablei_t p_glDisablei;
		public static void glDisablei(EnableCap target, uint index) => p_glDisablei(target, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquationi_t(uint buf, BlendEquationModeEXT mode);
		private static glBlendEquationi_t p_glBlendEquationi;
		public static void glBlendEquationi(uint buf, BlendEquationModeEXT mode) => p_glBlendEquationi(buf, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendEquationSeparatei_t(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
		private static glBlendEquationSeparatei_t p_glBlendEquationSeparatei;
		public static void glBlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => p_glBlendEquationSeparatei(buf, modeRGB, modeAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFunci_t(uint buf, BlendingFactor src, BlendingFactor dst);
		private static glBlendFunci_t p_glBlendFunci;
		public static void glBlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => p_glBlendFunci(buf, src, dst);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glBlendFuncSeparatei_t(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
		private static glBlendFuncSeparatei_t p_glBlendFuncSeparatei;
		public static void glBlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => p_glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glColorMaski_t(uint index, bool r, bool g, bool b, bool a);
		private static glColorMaski_t p_glColorMaski;
		public static void glColorMaski(uint index, bool r, bool g, bool b, bool a) => p_glColorMaski(index, r, g, b, a);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate bool glIsEnabledi_t(EnableCap target, uint index);
		private static glIsEnabledi_t p_glIsEnabledi;
		public static bool glIsEnabledi(EnableCap target, uint index) => p_glIsEnabledi(target, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsBaseVertex_t(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex);
		private static glDrawElementsBaseVertex_t p_glDrawElementsBaseVertex;
		public static void glDrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => p_glDrawElementsBaseVertex(mode, count, type, indices, basevertex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawRangeElementsBaseVertex_t(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex);
		private static glDrawRangeElementsBaseVertex_t p_glDrawRangeElementsBaseVertex;
		public static void glDrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => p_glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glDrawElementsInstancedBaseVertex_t(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex);
		private static glDrawElementsInstancedBaseVertex_t p_glDrawElementsInstancedBaseVertex;
		public static void glDrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => p_glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glFramebufferTexture_t(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
		private static glFramebufferTexture_t p_glFramebufferTexture;
		public static void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level) => p_glFramebufferTexture(target, attachment, texture, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPrimitiveBoundingBox_t(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
		private static glPrimitiveBoundingBox_t p_glPrimitiveBoundingBox;
		public static void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => p_glPrimitiveBoundingBox(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate GraphicsResetStatus glGetGraphicsResetStatus_t();
		private static glGetGraphicsResetStatus_t p_glGetGraphicsResetStatus;
		public static GraphicsResetStatus glGetGraphicsResetStatus() => p_glGetGraphicsResetStatus();

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glReadnPixels_t(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data);
		private static glReadnPixels_t p_glReadnPixels;
		public static void glReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => p_glReadnPixels(x, y, width, height, format, type, bufSize, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnUniformfv_t(uint program, int location, int bufSize, float* @params);
		private static glGetnUniformfv_t p_glGetnUniformfv;
		public static void glGetnUniformfv(uint program, int location, int bufSize, float* @params) => p_glGetnUniformfv(program, location, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnUniformiv_t(uint program, int location, int bufSize, int* @params);
		private static glGetnUniformiv_t p_glGetnUniformiv;
		public static void glGetnUniformiv(uint program, int location, int bufSize, int* @params) => p_glGetnUniformiv(program, location, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetnUniformuiv_t(uint program, int location, int bufSize, uint* @params);
		private static glGetnUniformuiv_t p_glGetnUniformuiv;
		public static void glGetnUniformuiv(uint program, int location, int bufSize, uint* @params) => p_glGetnUniformuiv(program, location, bufSize, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glMinSampleShading_t(float value);
		private static glMinSampleShading_t p_glMinSampleShading;
		public static void glMinSampleShading(float value) => p_glMinSampleShading(value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glPatchParameteri_t(PatchParameterName pname, int value);
		private static glPatchParameteri_t p_glPatchParameteri;
		public static void glPatchParameteri(PatchParameterName pname, int value) => p_glPatchParameteri(pname, value);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterIiv_t(TextureTarget target, TextureParameterName pname, int* @params);
		private static glTexParameterIiv_t p_glTexParameterIiv;
		public static void glTexParameterIiv(TextureTarget target, TextureParameterName pname, int* @params) => p_glTexParameterIiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexParameterIuiv_t(TextureTarget target, TextureParameterName pname, uint* @params);
		private static glTexParameterIuiv_t p_glTexParameterIuiv;
		public static void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* @params) => p_glTexParameterIuiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameterIiv_t(TextureTarget target, GetTextureParameter pname, int* @params);
		private static glGetTexParameterIiv_t p_glGetTexParameterIiv;
		public static void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* @params) => p_glGetTexParameterIiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetTexParameterIuiv_t(TextureTarget target, GetTextureParameter pname, uint* @params);
		private static glGetTexParameterIuiv_t p_glGetTexParameterIuiv;
		public static void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* @params) => p_glGetTexParameterIuiv(target, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterIiv_t(uint sampler, SamplerParameterName pname, int* param);
		private static glSamplerParameterIiv_t p_glSamplerParameterIiv;
		public static void glSamplerParameterIiv(uint sampler, SamplerParameterName pname, int* param) => p_glSamplerParameterIiv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glSamplerParameterIuiv_t(uint sampler, SamplerParameterName pname, uint* param);
		private static glSamplerParameterIuiv_t p_glSamplerParameterIuiv;
		public static void glSamplerParameterIuiv(uint sampler, SamplerParameterName pname, uint* param) => p_glSamplerParameterIuiv(sampler, pname, param);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameterIiv_t(uint sampler, SamplerParameterName pname, int* @params);
		private static glGetSamplerParameterIiv_t p_glGetSamplerParameterIiv;
		public static void glGetSamplerParameterIiv(uint sampler, SamplerParameterName pname, int* @params) => p_glGetSamplerParameterIiv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glGetSamplerParameterIuiv_t(uint sampler, SamplerParameterName pname, uint* @params);
		private static glGetSamplerParameterIuiv_t p_glGetSamplerParameterIuiv;
		public static void glGetSamplerParameterIuiv(uint sampler, SamplerParameterName pname, uint* @params) => p_glGetSamplerParameterIuiv(sampler, pname, @params);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexBuffer_t(TextureTarget target, InternalFormat internalformat, uint buffer);
		private static glTexBuffer_t p_glTexBuffer;
		public static void glTexBuffer(TextureTarget target, InternalFormat internalformat, uint buffer) => p_glTexBuffer(target, internalformat, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexBufferRange_t(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, int size);
		private static glTexBufferRange_t p_glTexBufferRange;
		public static void glTexBufferRange(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, int size) => p_glTexBufferRange(target, internalformat, buffer, offset, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void glTexStorage3DMultisample_t(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private static glTexStorage3DMultisample_t p_glTexStorage3DMultisample;
		public static void glTexStorage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => p_glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);

		public static void LoadGetString(IntPtr glContext, Func<string, IntPtr> getProcAddress)
		{
			s_getProcAddress = getProcAddress;
			LoadFunction("glGetString", out p_glGetString);
		}

		public static void LoadAllFunctions(IntPtr glContext, Func<string, IntPtr> getProcAddress)
		{
			s_getProcAddress = getProcAddress;

			LoadFunction("glAlphaFunc", out p_glAlphaFunc);
			LoadFunction("glClearColor", out p_glClearColor);
			LoadFunction("glClearDepthf", out p_glClearDepthf);
			LoadFunction("glClipPlanef", out p_glClipPlanef);
			LoadFunction("glColor4f", out p_glColor4f);
			LoadFunction("glDepthRangef", out p_glDepthRangef);
			LoadFunction("glFogf", out p_glFogf);
			LoadFunction("glFogfv", out p_glFogfv);
			LoadFunction("glFrustumf", out p_glFrustumf);
			LoadFunction("glGetClipPlanef", out p_glGetClipPlanef);
			LoadFunction("glGetFloatv", out p_glGetFloatv);
			LoadFunction("glGetLightfv", out p_glGetLightfv);
			LoadFunction("glGetMaterialfv", out p_glGetMaterialfv);
			LoadFunction("glGetTexEnvfv", out p_glGetTexEnvfv);
			LoadFunction("glGetTexParameterfv", out p_glGetTexParameterfv);
			LoadFunction("glLightModelf", out p_glLightModelf);
			LoadFunction("glLightModelfv", out p_glLightModelfv);
			LoadFunction("glLightf", out p_glLightf);
			LoadFunction("glLightfv", out p_glLightfv);
			LoadFunction("glLineWidth", out p_glLineWidth);
			LoadFunction("glLoadMatrixf", out p_glLoadMatrixf);
			LoadFunction("glMaterialf", out p_glMaterialf);
			LoadFunction("glMaterialfv", out p_glMaterialfv);
			LoadFunction("glMultMatrixf", out p_glMultMatrixf);
			LoadFunction("glMultiTexCoord4f", out p_glMultiTexCoord4f);
			LoadFunction("glNormal3f", out p_glNormal3f);
			LoadFunction("glOrthof", out p_glOrthof);
			LoadFunction("glPointParameterf", out p_glPointParameterf);
			LoadFunction("glPointParameterfv", out p_glPointParameterfv);
			LoadFunction("glPointSize", out p_glPointSize);
			LoadFunction("glPolygonOffset", out p_glPolygonOffset);
			LoadFunction("glRotatef", out p_glRotatef);
			LoadFunction("glScalef", out p_glScalef);
			LoadFunction("glTexEnvf", out p_glTexEnvf);
			LoadFunction("glTexEnvfv", out p_glTexEnvfv);
			LoadFunction("glTexParameterf", out p_glTexParameterf);
			LoadFunction("glTexParameterfv", out p_glTexParameterfv);
			LoadFunction("glTranslatef", out p_glTranslatef);
			LoadFunction("glActiveTexture", out p_glActiveTexture);
			LoadFunction("glAlphaFuncx", out p_glAlphaFuncx);
			LoadFunction("glBindBuffer", out p_glBindBuffer);
			LoadFunction("glBindTexture", out p_glBindTexture);
			LoadFunction("glBlendFunc", out p_glBlendFunc);
			LoadFunction("glBufferData", out p_glBufferData);
			LoadFunction("glBufferSubData", out p_glBufferSubData);
			LoadFunction("glClear", out p_glClear);
			LoadFunction("glClearColorx", out p_glClearColorx);
			LoadFunction("glClearDepthx", out p_glClearDepthx);
			LoadFunction("glClearStencil", out p_glClearStencil);
			LoadFunction("glClientActiveTexture", out p_glClientActiveTexture);
			LoadFunction("glClipPlanex", out p_glClipPlanex);
			LoadFunction("glColor4ub", out p_glColor4ub);
			LoadFunction("glColor4x", out p_glColor4x);
			LoadFunction("glColorMask", out p_glColorMask);
			LoadFunction("glColorPointer", out p_glColorPointer);
			LoadFunction("glCompressedTexImage2D", out p_glCompressedTexImage2D);
			LoadFunction("glCompressedTexSubImage2D", out p_glCompressedTexSubImage2D);
			LoadFunction("glCopyTexImage2D", out p_glCopyTexImage2D);
			LoadFunction("glCopyTexSubImage2D", out p_glCopyTexSubImage2D);
			LoadFunction("glCullFace", out p_glCullFace);
			LoadFunction("glDeleteBuffers", out p_glDeleteBuffers);
			LoadFunction("glDeleteTextures", out p_glDeleteTextures);
			LoadFunction("glDepthFunc", out p_glDepthFunc);
			LoadFunction("glDepthMask", out p_glDepthMask);
			LoadFunction("glDepthRangex", out p_glDepthRangex);
			LoadFunction("glDisable", out p_glDisable);
			LoadFunction("glDisableClientState", out p_glDisableClientState);
			LoadFunction("glDrawArrays", out p_glDrawArrays);
			LoadFunction("glDrawElements", out p_glDrawElements);
			LoadFunction("glEnable", out p_glEnable);
			LoadFunction("glEnableClientState", out p_glEnableClientState);
			LoadFunction("glFinish", out p_glFinish);
			LoadFunction("glFlush", out p_glFlush);
			LoadFunction("glFogx", out p_glFogx);
			LoadFunction("glFogxv", out p_glFogxv);
			LoadFunction("glFrontFace", out p_glFrontFace);
			LoadFunction("glFrustumx", out p_glFrustumx);
			LoadFunction("glGetBooleanv", out p_glGetBooleanv);
			LoadFunction("glGetBufferParameteriv", out p_glGetBufferParameteriv);
			LoadFunction("glGetClipPlanex", out p_glGetClipPlanex);
			LoadFunction("glGenBuffers", out p_glGenBuffers);
			LoadFunction("glGenTextures", out p_glGenTextures);
			LoadFunction("glGetError", out p_glGetError);
			LoadFunction("glGetFixedv", out p_glGetFixedv);
			LoadFunction("glGetIntegerv", out p_glGetIntegerv);
			LoadFunction("glGetLightxv", out p_glGetLightxv);
			LoadFunction("glGetMaterialxv", out p_glGetMaterialxv);
			LoadFunction("glGetPointerv", out p_glGetPointerv);
			LoadFunction("glGetString", out p_glGetString);
			LoadFunction("glGetTexEnviv", out p_glGetTexEnviv);
			LoadFunction("glGetTexEnvxv", out p_glGetTexEnvxv);
			LoadFunction("glGetTexParameteriv", out p_glGetTexParameteriv);
			LoadFunction("glGetTexParameterxv", out p_glGetTexParameterxv);
			LoadFunction("glHint", out p_glHint);
			LoadFunction("glIsBuffer", out p_glIsBuffer);
			LoadFunction("glIsEnabled", out p_glIsEnabled);
			LoadFunction("glIsTexture", out p_glIsTexture);
			LoadFunction("glLightModelx", out p_glLightModelx);
			LoadFunction("glLightModelxv", out p_glLightModelxv);
			LoadFunction("glLightx", out p_glLightx);
			LoadFunction("glLightxv", out p_glLightxv);
			LoadFunction("glLineWidthx", out p_glLineWidthx);
			LoadFunction("glLoadIdentity", out p_glLoadIdentity);
			LoadFunction("glLoadMatrixx", out p_glLoadMatrixx);
			LoadFunction("glLogicOp", out p_glLogicOp);
			LoadFunction("glMaterialx", out p_glMaterialx);
			LoadFunction("glMaterialxv", out p_glMaterialxv);
			LoadFunction("glMatrixMode", out p_glMatrixMode);
			LoadFunction("glMultMatrixx", out p_glMultMatrixx);
			LoadFunction("glMultiTexCoord4x", out p_glMultiTexCoord4x);
			LoadFunction("glNormal3x", out p_glNormal3x);
			LoadFunction("glNormalPointer", out p_glNormalPointer);
			LoadFunction("glOrthox", out p_glOrthox);
			LoadFunction("glPixelStorei", out p_glPixelStorei);
			LoadFunction("glPointParameterx", out p_glPointParameterx);
			LoadFunction("glPointParameterxv", out p_glPointParameterxv);
			LoadFunction("glPointSizex", out p_glPointSizex);
			LoadFunction("glPolygonOffsetx", out p_glPolygonOffsetx);
			LoadFunction("glPopMatrix", out p_glPopMatrix);
			LoadFunction("glPushMatrix", out p_glPushMatrix);
			LoadFunction("glReadPixels", out p_glReadPixels);
			LoadFunction("glRotatex", out p_glRotatex);
			LoadFunction("glSampleCoverage", out p_glSampleCoverage);
			LoadFunction("glSampleCoveragex", out p_glSampleCoveragex);
			LoadFunction("glScalex", out p_glScalex);
			LoadFunction("glScissor", out p_glScissor);
			LoadFunction("glShadeModel", out p_glShadeModel);
			LoadFunction("glStencilFunc", out p_glStencilFunc);
			LoadFunction("glStencilMask", out p_glStencilMask);
			LoadFunction("glStencilOp", out p_glStencilOp);
			LoadFunction("glTexCoordPointer", out p_glTexCoordPointer);
			LoadFunction("glTexEnvi", out p_glTexEnvi);
			LoadFunction("glTexEnvx", out p_glTexEnvx);
			LoadFunction("glTexEnviv", out p_glTexEnviv);
			LoadFunction("glTexEnvxv", out p_glTexEnvxv);
			LoadFunction("glTexImage2D", out p_glTexImage2D);
			LoadFunction("glTexParameteri", out p_glTexParameteri);
			LoadFunction("glTexParameterx", out p_glTexParameterx);
			LoadFunction("glTexParameteriv", out p_glTexParameteriv);
			LoadFunction("glTexParameterxv", out p_glTexParameterxv);
			LoadFunction("glTexSubImage2D", out p_glTexSubImage2D);
			LoadFunction("glTranslatex", out p_glTranslatex);
			LoadFunction("glVertexPointer", out p_glVertexPointer);
			LoadFunction("glViewport", out p_glViewport);
			LoadFunction("glAttachShader", out p_glAttachShader);
			LoadFunction("glBindAttribLocation", out p_glBindAttribLocation);
			LoadFunction("glBindFramebuffer", out p_glBindFramebuffer);
			LoadFunction("glBindRenderbuffer", out p_glBindRenderbuffer);
			LoadFunction("glBlendColor", out p_glBlendColor);
			LoadFunction("glBlendEquation", out p_glBlendEquation);
			LoadFunction("glBlendEquationSeparate", out p_glBlendEquationSeparate);
			LoadFunction("glBlendFuncSeparate", out p_glBlendFuncSeparate);
			LoadFunction("glCheckFramebufferStatus", out p_glCheckFramebufferStatus);
			LoadFunction("glCompileShader", out p_glCompileShader);
			LoadFunction("glCreateProgram", out p_glCreateProgram);
			LoadFunction("glCreateShader", out p_glCreateShader);
			LoadFunction("glDeleteFramebuffers", out p_glDeleteFramebuffers);
			LoadFunction("glDeleteProgram", out p_glDeleteProgram);
			LoadFunction("glDeleteRenderbuffers", out p_glDeleteRenderbuffers);
			LoadFunction("glDeleteShader", out p_glDeleteShader);
			LoadFunction("glDetachShader", out p_glDetachShader);
			LoadFunction("glDisableVertexAttribArray", out p_glDisableVertexAttribArray);
			LoadFunction("glEnableVertexAttribArray", out p_glEnableVertexAttribArray);
			LoadFunction("glFramebufferRenderbuffer", out p_glFramebufferRenderbuffer);
			LoadFunction("glFramebufferTexture2D", out p_glFramebufferTexture2D);
			LoadFunction("glGenerateMipmap", out p_glGenerateMipmap);
			LoadFunction("glGenFramebuffers", out p_glGenFramebuffers);
			LoadFunction("glGenRenderbuffers", out p_glGenRenderbuffers);
			LoadFunction("glGetActiveAttrib", out p_glGetActiveAttrib);
			LoadFunction("glGetActiveUniform", out p_glGetActiveUniform);
			LoadFunction("glGetAttachedShaders", out p_glGetAttachedShaders);
			LoadFunction("glGetAttribLocation", out p_glGetAttribLocation);
			LoadFunction("glGetFramebufferAttachmentParameteriv", out p_glGetFramebufferAttachmentParameteriv);
			LoadFunction("glGetProgramiv", out p_glGetProgramiv);
			LoadFunction("glGetProgramInfoLog", out p_glGetProgramInfoLog);
			LoadFunction("glGetRenderbufferParameteriv", out p_glGetRenderbufferParameteriv);
			LoadFunction("glGetShaderiv", out p_glGetShaderiv);
			LoadFunction("glGetShaderInfoLog", out p_glGetShaderInfoLog);
			LoadFunction("glGetShaderPrecisionFormat", out p_glGetShaderPrecisionFormat);
			LoadFunction("glGetShaderSource", out p_glGetShaderSource);
			LoadFunction("glGetUniformfv", out p_glGetUniformfv);
			LoadFunction("glGetUniformiv", out p_glGetUniformiv);
			LoadFunction("glGetUniformLocation", out p_glGetUniformLocation);
			LoadFunction("glGetVertexAttribfv", out p_glGetVertexAttribfv);
			LoadFunction("glGetVertexAttribiv", out p_glGetVertexAttribiv);
			LoadFunction("glGetVertexAttribPointerv", out p_glGetVertexAttribPointerv);
			LoadFunction("glIsFramebuffer", out p_glIsFramebuffer);
			LoadFunction("glIsProgram", out p_glIsProgram);
			LoadFunction("glIsRenderbuffer", out p_glIsRenderbuffer);
			LoadFunction("glIsShader", out p_glIsShader);
			LoadFunction("glLinkProgram", out p_glLinkProgram);
			LoadFunction("glReleaseShaderCompiler", out p_glReleaseShaderCompiler);
			LoadFunction("glRenderbufferStorage", out p_glRenderbufferStorage);
			LoadFunction("glShaderBinary", out p_glShaderBinary);
			LoadFunction("glShaderSource", out p_glShaderSource);
			LoadFunction("glStencilFuncSeparate", out p_glStencilFuncSeparate);
			LoadFunction("glStencilMaskSeparate", out p_glStencilMaskSeparate);
			LoadFunction("glStencilOpSeparate", out p_glStencilOpSeparate);
			LoadFunction("glUniform1f", out p_glUniform1f);
			LoadFunction("glUniform1fv", out p_glUniform1fv);
			LoadFunction("glUniform1i", out p_glUniform1i);
			LoadFunction("glUniform1iv", out p_glUniform1iv);
			LoadFunction("glUniform2f", out p_glUniform2f);
			LoadFunction("glUniform2fv", out p_glUniform2fv);
			LoadFunction("glUniform2i", out p_glUniform2i);
			LoadFunction("glUniform2iv", out p_glUniform2iv);
			LoadFunction("glUniform3f", out p_glUniform3f);
			LoadFunction("glUniform3fv", out p_glUniform3fv);
			LoadFunction("glUniform3i", out p_glUniform3i);
			LoadFunction("glUniform3iv", out p_glUniform3iv);
			LoadFunction("glUniform4f", out p_glUniform4f);
			LoadFunction("glUniform4fv", out p_glUniform4fv);
			LoadFunction("glUniform4i", out p_glUniform4i);
			LoadFunction("glUniform4iv", out p_glUniform4iv);
			LoadFunction("glUniformMatrix2fv", out p_glUniformMatrix2fv);
			LoadFunction("glUniformMatrix3fv", out p_glUniformMatrix3fv);
			LoadFunction("glUniformMatrix4fv", out p_glUniformMatrix4fv);
			LoadFunction("glUseProgram", out p_glUseProgram);
			LoadFunction("glValidateProgram", out p_glValidateProgram);
			LoadFunction("glVertexAttrib1f", out p_glVertexAttrib1f);
			LoadFunction("glVertexAttrib1fv", out p_glVertexAttrib1fv);
			LoadFunction("glVertexAttrib2f", out p_glVertexAttrib2f);
			LoadFunction("glVertexAttrib2fv", out p_glVertexAttrib2fv);
			LoadFunction("glVertexAttrib3f", out p_glVertexAttrib3f);
			LoadFunction("glVertexAttrib3fv", out p_glVertexAttrib3fv);
			LoadFunction("glVertexAttrib4f", out p_glVertexAttrib4f);
			LoadFunction("glVertexAttrib4fv", out p_glVertexAttrib4fv);
			LoadFunction("glVertexAttribPointer", out p_glVertexAttribPointer);
			LoadFunction("glReadBuffer", out p_glReadBuffer);
			LoadFunction("glDrawRangeElements", out p_glDrawRangeElements);
			LoadFunction("glTexImage3D", out p_glTexImage3D);
			LoadFunction("glTexSubImage3D", out p_glTexSubImage3D);
			LoadFunction("glCopyTexSubImage3D", out p_glCopyTexSubImage3D);
			LoadFunction("glCompressedTexImage3D", out p_glCompressedTexImage3D);
			LoadFunction("glCompressedTexSubImage3D", out p_glCompressedTexSubImage3D);
			LoadFunction("glGenQueries", out p_glGenQueries);
			LoadFunction("glDeleteQueries", out p_glDeleteQueries);
			LoadFunction("glIsQuery", out p_glIsQuery);
			LoadFunction("glBeginQuery", out p_glBeginQuery);
			LoadFunction("glEndQuery", out p_glEndQuery);
			LoadFunction("glGetQueryiv", out p_glGetQueryiv);
			LoadFunction("glGetQueryObjectuiv", out p_glGetQueryObjectuiv);
			LoadFunction("glUnmapBuffer", out p_glUnmapBuffer);
			LoadFunction("glGetBufferPointerv", out p_glGetBufferPointerv);
			LoadFunction("glDrawBuffers", out p_glDrawBuffers);
			LoadFunction("glUniformMatrix2x3fv", out p_glUniformMatrix2x3fv);
			LoadFunction("glUniformMatrix3x2fv", out p_glUniformMatrix3x2fv);
			LoadFunction("glUniformMatrix2x4fv", out p_glUniformMatrix2x4fv);
			LoadFunction("glUniformMatrix4x2fv", out p_glUniformMatrix4x2fv);
			LoadFunction("glUniformMatrix3x4fv", out p_glUniformMatrix3x4fv);
			LoadFunction("glUniformMatrix4x3fv", out p_glUniformMatrix4x3fv);
			LoadFunction("glBlitFramebuffer", out p_glBlitFramebuffer);
			LoadFunction("glRenderbufferStorageMultisample", out p_glRenderbufferStorageMultisample);
			LoadFunction("glFramebufferTextureLayer", out p_glFramebufferTextureLayer);
			LoadFunction("glMapBufferRange", out p_glMapBufferRange);
			LoadFunction("glFlushMappedBufferRange", out p_glFlushMappedBufferRange);
			LoadFunction("glBindVertexArray", out p_glBindVertexArray);
			LoadFunction("glDeleteVertexArrays", out p_glDeleteVertexArrays);
			LoadFunction("glGenVertexArrays", out p_glGenVertexArrays);
			LoadFunction("glIsVertexArray", out p_glIsVertexArray);
			LoadFunction("glGetIntegeri_v", out p_glGetIntegeri_v);
			LoadFunction("glBeginTransformFeedback", out p_glBeginTransformFeedback);
			LoadFunction("glEndTransformFeedback", out p_glEndTransformFeedback);
			LoadFunction("glBindBufferRange", out p_glBindBufferRange);
			LoadFunction("glBindBufferBase", out p_glBindBufferBase);
			LoadFunction("glTransformFeedbackVaryings", out p_glTransformFeedbackVaryings);
			LoadFunction("glGetTransformFeedbackVarying", out p_glGetTransformFeedbackVarying);
			LoadFunction("glVertexAttribIPointer", out p_glVertexAttribIPointer);
			LoadFunction("glGetVertexAttribIiv", out p_glGetVertexAttribIiv);
			LoadFunction("glGetVertexAttribIuiv", out p_glGetVertexAttribIuiv);
			LoadFunction("glVertexAttribI4i", out p_glVertexAttribI4i);
			LoadFunction("glVertexAttribI4ui", out p_glVertexAttribI4ui);
			LoadFunction("glVertexAttribI4iv", out p_glVertexAttribI4iv);
			LoadFunction("glVertexAttribI4uiv", out p_glVertexAttribI4uiv);
			LoadFunction("glGetUniformuiv", out p_glGetUniformuiv);
			LoadFunction("glGetFragDataLocation", out p_glGetFragDataLocation);
			LoadFunction("glUniform1ui", out p_glUniform1ui);
			LoadFunction("glUniform2ui", out p_glUniform2ui);
			LoadFunction("glUniform3ui", out p_glUniform3ui);
			LoadFunction("glUniform4ui", out p_glUniform4ui);
			LoadFunction("glUniform1uiv", out p_glUniform1uiv);
			LoadFunction("glUniform2uiv", out p_glUniform2uiv);
			LoadFunction("glUniform3uiv", out p_glUniform3uiv);
			LoadFunction("glUniform4uiv", out p_glUniform4uiv);
			LoadFunction("glClearBufferiv", out p_glClearBufferiv);
			LoadFunction("glClearBufferuiv", out p_glClearBufferuiv);
			LoadFunction("glClearBufferfv", out p_glClearBufferfv);
			LoadFunction("glClearBufferfi", out p_glClearBufferfi);
			LoadFunction("glGetStringi", out p_glGetStringi);
			LoadFunction("glCopyBufferSubData", out p_glCopyBufferSubData);
			LoadFunction("glGetUniformIndices", out p_glGetUniformIndices);
			LoadFunction("glGetActiveUniformsiv", out p_glGetActiveUniformsiv);
			LoadFunction("glGetUniformBlockIndex", out p_glGetUniformBlockIndex);
			LoadFunction("glGetActiveUniformBlockiv", out p_glGetActiveUniformBlockiv);
			LoadFunction("glGetActiveUniformBlockName", out p_glGetActiveUniformBlockName);
			LoadFunction("glUniformBlockBinding", out p_glUniformBlockBinding);
			LoadFunction("glDrawArraysInstanced", out p_glDrawArraysInstanced);
			LoadFunction("glDrawElementsInstanced", out p_glDrawElementsInstanced);
			LoadFunction("glFenceSync", out p_glFenceSync);
			LoadFunction("glIsSync", out p_glIsSync);
			LoadFunction("glDeleteSync", out p_glDeleteSync);
			LoadFunction("glClientWaitSync", out p_glClientWaitSync);
			LoadFunction("glWaitSync", out p_glWaitSync);
			LoadFunction("glGetInteger64v", out p_glGetInteger64v);
			LoadFunction("glGetSynciv", out p_glGetSynciv);
			LoadFunction("glGetInteger64i_v", out p_glGetInteger64i_v);
			LoadFunction("glGetBufferParameteri64v", out p_glGetBufferParameteri64v);
			LoadFunction("glGenSamplers", out p_glGenSamplers);
			LoadFunction("glDeleteSamplers", out p_glDeleteSamplers);
			LoadFunction("glIsSampler", out p_glIsSampler);
			LoadFunction("glBindSampler", out p_glBindSampler);
			LoadFunction("glSamplerParameteri", out p_glSamplerParameteri);
			LoadFunction("glSamplerParameteriv", out p_glSamplerParameteriv);
			LoadFunction("glSamplerParameterf", out p_glSamplerParameterf);
			LoadFunction("glSamplerParameterfv", out p_glSamplerParameterfv);
			LoadFunction("glGetSamplerParameteriv", out p_glGetSamplerParameteriv);
			LoadFunction("glGetSamplerParameterfv", out p_glGetSamplerParameterfv);
			LoadFunction("glVertexAttribDivisor", out p_glVertexAttribDivisor);
			LoadFunction("glBindTransformFeedback", out p_glBindTransformFeedback);
			LoadFunction("glDeleteTransformFeedbacks", out p_glDeleteTransformFeedbacks);
			LoadFunction("glGenTransformFeedbacks", out p_glGenTransformFeedbacks);
			LoadFunction("glIsTransformFeedback", out p_glIsTransformFeedback);
			LoadFunction("glPauseTransformFeedback", out p_glPauseTransformFeedback);
			LoadFunction("glResumeTransformFeedback", out p_glResumeTransformFeedback);
			LoadFunction("glGetProgramBinary", out p_glGetProgramBinary);
			LoadFunction("glProgramBinary", out p_glProgramBinary);
			LoadFunction("glProgramParameteri", out p_glProgramParameteri);
			LoadFunction("glInvalidateFramebuffer", out p_glInvalidateFramebuffer);
			LoadFunction("glInvalidateSubFramebuffer", out p_glInvalidateSubFramebuffer);
			LoadFunction("glTexStorage2D", out p_glTexStorage2D);
			LoadFunction("glTexStorage3D", out p_glTexStorage3D);
			LoadFunction("glGetInternalformativ", out p_glGetInternalformativ);
			LoadFunction("glDispatchCompute", out p_glDispatchCompute);
			LoadFunction("glDispatchComputeIndirect", out p_glDispatchComputeIndirect);
			LoadFunction("glDrawArraysIndirect", out p_glDrawArraysIndirect);
			LoadFunction("glDrawElementsIndirect", out p_glDrawElementsIndirect);
			LoadFunction("glFramebufferParameteri", out p_glFramebufferParameteri);
			LoadFunction("glGetFramebufferParameteriv", out p_glGetFramebufferParameteriv);
			LoadFunction("glGetProgramInterfaceiv", out p_glGetProgramInterfaceiv);
			LoadFunction("glGetProgramResourceIndex", out p_glGetProgramResourceIndex);
			LoadFunction("glGetProgramResourceName", out p_glGetProgramResourceName);
			LoadFunction("glGetProgramResourceiv", out p_glGetProgramResourceiv);
			LoadFunction("glGetProgramResourceLocation", out p_glGetProgramResourceLocation);
			LoadFunction("glUseProgramStages", out p_glUseProgramStages);
			LoadFunction("glActiveShaderProgram", out p_glActiveShaderProgram);
			LoadFunction("glCreateShaderProgramv", out p_glCreateShaderProgramv);
			LoadFunction("glBindProgramPipeline", out p_glBindProgramPipeline);
			LoadFunction("glDeleteProgramPipelines", out p_glDeleteProgramPipelines);
			LoadFunction("glGenProgramPipelines", out p_glGenProgramPipelines);
			LoadFunction("glIsProgramPipeline", out p_glIsProgramPipeline);
			LoadFunction("glGetProgramPipelineiv", out p_glGetProgramPipelineiv);
			LoadFunction("glProgramUniform1i", out p_glProgramUniform1i);
			LoadFunction("glProgramUniform2i", out p_glProgramUniform2i);
			LoadFunction("glProgramUniform3i", out p_glProgramUniform3i);
			LoadFunction("glProgramUniform4i", out p_glProgramUniform4i);
			LoadFunction("glProgramUniform1ui", out p_glProgramUniform1ui);
			LoadFunction("glProgramUniform2ui", out p_glProgramUniform2ui);
			LoadFunction("glProgramUniform3ui", out p_glProgramUniform3ui);
			LoadFunction("glProgramUniform4ui", out p_glProgramUniform4ui);
			LoadFunction("glProgramUniform1f", out p_glProgramUniform1f);
			LoadFunction("glProgramUniform2f", out p_glProgramUniform2f);
			LoadFunction("glProgramUniform3f", out p_glProgramUniform3f);
			LoadFunction("glProgramUniform4f", out p_glProgramUniform4f);
			LoadFunction("glProgramUniform1iv", out p_glProgramUniform1iv);
			LoadFunction("glProgramUniform2iv", out p_glProgramUniform2iv);
			LoadFunction("glProgramUniform3iv", out p_glProgramUniform3iv);
			LoadFunction("glProgramUniform4iv", out p_glProgramUniform4iv);
			LoadFunction("glProgramUniform1uiv", out p_glProgramUniform1uiv);
			LoadFunction("glProgramUniform2uiv", out p_glProgramUniform2uiv);
			LoadFunction("glProgramUniform3uiv", out p_glProgramUniform3uiv);
			LoadFunction("glProgramUniform4uiv", out p_glProgramUniform4uiv);
			LoadFunction("glProgramUniform1fv", out p_glProgramUniform1fv);
			LoadFunction("glProgramUniform2fv", out p_glProgramUniform2fv);
			LoadFunction("glProgramUniform3fv", out p_glProgramUniform3fv);
			LoadFunction("glProgramUniform4fv", out p_glProgramUniform4fv);
			LoadFunction("glProgramUniformMatrix2fv", out p_glProgramUniformMatrix2fv);
			LoadFunction("glProgramUniformMatrix3fv", out p_glProgramUniformMatrix3fv);
			LoadFunction("glProgramUniformMatrix4fv", out p_glProgramUniformMatrix4fv);
			LoadFunction("glProgramUniformMatrix2x3fv", out p_glProgramUniformMatrix2x3fv);
			LoadFunction("glProgramUniformMatrix3x2fv", out p_glProgramUniformMatrix3x2fv);
			LoadFunction("glProgramUniformMatrix2x4fv", out p_glProgramUniformMatrix2x4fv);
			LoadFunction("glProgramUniformMatrix4x2fv", out p_glProgramUniformMatrix4x2fv);
			LoadFunction("glProgramUniformMatrix3x4fv", out p_glProgramUniformMatrix3x4fv);
			LoadFunction("glProgramUniformMatrix4x3fv", out p_glProgramUniformMatrix4x3fv);
			LoadFunction("glValidateProgramPipeline", out p_glValidateProgramPipeline);
			LoadFunction("glGetProgramPipelineInfoLog", out p_glGetProgramPipelineInfoLog);
			LoadFunction("glBindImageTexture", out p_glBindImageTexture);
			LoadFunction("glGetBooleani_v", out p_glGetBooleani_v);
			LoadFunction("glMemoryBarrier", out p_glMemoryBarrier);
			LoadFunction("glMemoryBarrierByRegion", out p_glMemoryBarrierByRegion);
			LoadFunction("glTexStorage2DMultisample", out p_glTexStorage2DMultisample);
			LoadFunction("glGetMultisamplefv", out p_glGetMultisamplefv);
			LoadFunction("glSampleMaski", out p_glSampleMaski);
			LoadFunction("glGetTexLevelParameteriv", out p_glGetTexLevelParameteriv);
			LoadFunction("glGetTexLevelParameterfv", out p_glGetTexLevelParameterfv);
			LoadFunction("glBindVertexBuffer", out p_glBindVertexBuffer);
			LoadFunction("glVertexAttribFormat", out p_glVertexAttribFormat);
			LoadFunction("glVertexAttribIFormat", out p_glVertexAttribIFormat);
			LoadFunction("glVertexAttribBinding", out p_glVertexAttribBinding);
			LoadFunction("glVertexBindingDivisor", out p_glVertexBindingDivisor);
			LoadFunction("glBlendBarrier", out p_glBlendBarrier);
			LoadFunction("glCopyImageSubData", out p_glCopyImageSubData);
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
			LoadFunction("glEnablei", out p_glEnablei);
			LoadFunction("glDisablei", out p_glDisablei);
			LoadFunction("glBlendEquationi", out p_glBlendEquationi);
			LoadFunction("glBlendEquationSeparatei", out p_glBlendEquationSeparatei);
			LoadFunction("glBlendFunci", out p_glBlendFunci);
			LoadFunction("glBlendFuncSeparatei", out p_glBlendFuncSeparatei);
			LoadFunction("glColorMaski", out p_glColorMaski);
			LoadFunction("glIsEnabledi", out p_glIsEnabledi);
			LoadFunction("glDrawElementsBaseVertex", out p_glDrawElementsBaseVertex);
			LoadFunction("glDrawRangeElementsBaseVertex", out p_glDrawRangeElementsBaseVertex);
			LoadFunction("glDrawElementsInstancedBaseVertex", out p_glDrawElementsInstancedBaseVertex);
			LoadFunction("glFramebufferTexture", out p_glFramebufferTexture);
			LoadFunction("glPrimitiveBoundingBox", out p_glPrimitiveBoundingBox);
			LoadFunction("glGetGraphicsResetStatus", out p_glGetGraphicsResetStatus);
			LoadFunction("glReadnPixels", out p_glReadnPixels);
			LoadFunction("glGetnUniformfv", out p_glGetnUniformfv);
			LoadFunction("glGetnUniformiv", out p_glGetnUniformiv);
			LoadFunction("glGetnUniformuiv", out p_glGetnUniformuiv);
			LoadFunction("glMinSampleShading", out p_glMinSampleShading);
			LoadFunction("glPatchParameteri", out p_glPatchParameteri);
			LoadFunction("glTexParameterIiv", out p_glTexParameterIiv);
			LoadFunction("glTexParameterIuiv", out p_glTexParameterIuiv);
			LoadFunction("glGetTexParameterIiv", out p_glGetTexParameterIiv);
			LoadFunction("glGetTexParameterIuiv", out p_glGetTexParameterIuiv);
			LoadFunction("glSamplerParameterIiv", out p_glSamplerParameterIiv);
			LoadFunction("glSamplerParameterIuiv", out p_glSamplerParameterIuiv);
			LoadFunction("glGetSamplerParameterIiv", out p_glGetSamplerParameterIiv);
			LoadFunction("glGetSamplerParameterIuiv", out p_glGetSamplerParameterIuiv);
			LoadFunction("glTexBuffer", out p_glTexBuffer);
			LoadFunction("glTexBufferRange", out p_glTexBufferRange);
			LoadFunction("glTexStorage3DMultisample", out p_glTexStorage3DMultisample);
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
