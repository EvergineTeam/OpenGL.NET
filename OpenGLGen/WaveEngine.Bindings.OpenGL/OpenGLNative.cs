using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.OpenGL
{
	public static unsafe class OpenGLNative
	{
		private static Func<string, IntPtr> s_getProcAddress;

		private const CallingConvention CallConv = CallingConvention.Winapi;

		//glCullFace
		//glFrontFace
		//glHint
		//glLineWidth
		//glPointSize
		//glPolygonMode
		//glScissor
		//glTexParameterf
		//glTexParameterfv
		//glTexParameteri
		//glTexParameteriv
		//glTexImage1D
		//glTexImage2D
		//glDrawBuffer
		//glClear
		//glClearColor
		//glClearStencil
		//glClearDepth
		//glStencilMask
		//glColorMask
		//glDepthMask
		//glDisable
		//glEnable
		//glFinish
		//glFlush
		//glBlendFunc
		//glLogicOp
		//glStencilFunc
		//glStencilOp
		//glDepthFunc
		//glPixelStoref
		//glPixelStorei
		//glReadBuffer
		//glReadPixels
		//glGetBooleanv
		//glGetDoublev
		//glGetError
		//glGetFloatv
		//glGetIntegerv
		//glGetString
		//glGetTexImage
		//glGetTexParameterfv
		//glGetTexParameteriv
		//glGetTexLevelParameterfv
		//glGetTexLevelParameteriv
		//glIsEnabled
		//glDepthRange
		//glViewport
		//glDrawArrays
		//glDrawElements
		//glPolygonOffset
		//glCopyTexImage1D
		//glCopyTexImage2D
		//glCopyTexSubImage1D
		//glCopyTexSubImage2D
		//glTexSubImage1D
		//glTexSubImage2D
		//glBindTexture
		//glDeleteTextures
		//glGenTextures
		//glIsTexture
		//glDrawRangeElements
		//glTexImage3D
		//glTexSubImage3D
		//glCopyTexSubImage3D
		//glActiveTexture
		//glSampleCoverage
		//glCompressedTexImage3D
		//glCompressedTexImage2D
		//glCompressedTexImage1D
		//glCompressedTexSubImage3D
		//glCompressedTexSubImage2D
		//glCompressedTexSubImage1D
		//glGetCompressedTexImage
		//glBlendFuncSeparate
		//glMultiDrawArrays
		//glMultiDrawElements
		//glPointParameterf
		//glPointParameterfv
		//glPointParameteri
		//glPointParameteriv
		//glBlendColor
		//glBlendEquation
		//glGenQueries
		//glDeleteQueries
		//glIsQuery
		//glBeginQuery
		//glEndQuery
		//glGetQueryiv
		//glGetQueryObjectiv
		//glGetQueryObjectuiv
		//glBindBuffer
		//glDeleteBuffers
		//glGenBuffers
		//glIsBuffer
		//glBufferData
		//glBufferSubData
		//glGetBufferSubData
		//glMapBuffer
		//glUnmapBuffer
		//glGetBufferParameteriv
		//glGetBufferPointerv
		//glBlendEquationSeparate
		//glDrawBuffers
		//glStencilOpSeparate
		//glStencilFuncSeparate
		//glStencilMaskSeparate
		//glAttachShader
		//glBindAttribLocation
		//glCompileShader
		//glCreateProgram
		//glCreateShader
		//glDeleteProgram
		//glDeleteShader
		//glDetachShader
		//glDisableVertexAttribArray
		//glEnableVertexAttribArray
		//glGetActiveAttrib
		//glGetActiveUniform
		//glGetAttachedShaders
		//glGetAttribLocation
		//glGetProgramiv
		//glGetProgramInfoLog
		//glGetShaderiv
		//glGetShaderInfoLog
		//glGetShaderSource
		//glGetUniformLocation
		//glGetUniformfv
		//glGetUniformiv
		//glGetVertexAttribdv
		//glGetVertexAttribfv
		//glGetVertexAttribiv
		//glGetVertexAttribPointerv
		//glIsProgram
		//glIsShader
		//glLinkProgram
		//glShaderSource
		//glUseProgram
		//glUniform1f
		//glUniform2f
		//glUniform3f
		//glUniform4f
		//glUniform1i
		//glUniform2i
		//glUniform3i
		//glUniform4i
		//glUniform1fv
		//glUniform2fv
		//glUniform3fv
		//glUniform4fv
		//glUniform1iv
		//glUniform2iv
		//glUniform3iv
		//glUniform4iv
		//glUniformMatrix2fv
		//glUniformMatrix3fv
		//glUniformMatrix4fv
		//glValidateProgram
		//glVertexAttrib1d
		//glVertexAttrib1dv
		//glVertexAttrib1f
		//glVertexAttrib1fv
		//glVertexAttrib1s
		//glVertexAttrib1sv
		//glVertexAttrib2d
		//glVertexAttrib2dv
		//glVertexAttrib2f
		//glVertexAttrib2fv
		//glVertexAttrib2s
		//glVertexAttrib2sv
		//glVertexAttrib3d
		//glVertexAttrib3dv
		//glVertexAttrib3f
		//glVertexAttrib3fv
		//glVertexAttrib3s
		//glVertexAttrib3sv
		//glVertexAttrib4Nbv
		//glVertexAttrib4Niv
		//glVertexAttrib4Nsv
		//glVertexAttrib4Nub
		//glVertexAttrib4Nubv
		//glVertexAttrib4Nuiv
		//glVertexAttrib4Nusv
		//glVertexAttrib4bv
		//glVertexAttrib4d
		//glVertexAttrib4dv
		//glVertexAttrib4f
		//glVertexAttrib4fv
		//glVertexAttrib4iv
		//glVertexAttrib4s
		//glVertexAttrib4sv
		//glVertexAttrib4ubv
		//glVertexAttrib4uiv
		//glVertexAttrib4usv
		//glVertexAttribPointer
		//glUniformMatrix2x3fv
		//glUniformMatrix3x2fv
		//glUniformMatrix2x4fv
		//glUniformMatrix4x2fv
		//glUniformMatrix3x4fv
		//glUniformMatrix4x3fv
		//glColorMaski
		//glGetBooleani_v
		//glGetIntegeri_v
		//glEnablei
		//glDisablei
		//glIsEnabledi
		//glBeginTransformFeedback
		//glEndTransformFeedback
		//glBindBufferRange
		//glBindBufferBase
		//glTransformFeedbackVaryings
		//glGetTransformFeedbackVarying
		//glClampColor
		//glBeginConditionalRender
		//glEndConditionalRender
		//glVertexAttribIPointer
		//glGetVertexAttribIiv
		//glGetVertexAttribIuiv
		//glVertexAttribI1i
		//glVertexAttribI2i
		//glVertexAttribI3i
		//glVertexAttribI4i
		//glVertexAttribI1ui
		//glVertexAttribI2ui
		//glVertexAttribI3ui
		//glVertexAttribI4ui
		//glVertexAttribI1iv
		//glVertexAttribI2iv
		//glVertexAttribI3iv
		//glVertexAttribI4iv
		//glVertexAttribI1uiv
		//glVertexAttribI2uiv
		//glVertexAttribI3uiv
		//glVertexAttribI4uiv
		//glVertexAttribI4bv
		//glVertexAttribI4sv
		//glVertexAttribI4ubv
		//glVertexAttribI4usv
		//glGetUniformuiv
		//glBindFragDataLocation
		//glGetFragDataLocation
		//glUniform1ui
		//glUniform2ui
		//glUniform3ui
		//glUniform4ui
		//glUniform1uiv
		//glUniform2uiv
		//glUniform3uiv
		//glUniform4uiv
		//glTexParameterIiv
		//glTexParameterIuiv
		//glGetTexParameterIiv
		//glGetTexParameterIuiv
		//glClearBufferiv
		//glClearBufferuiv
		//glClearBufferfv
		//glClearBufferfi
		//glGetStringi
		//glIsRenderbuffer
		//glBindRenderbuffer
		//glDeleteRenderbuffers
		//glGenRenderbuffers
		//glRenderbufferStorage
		//glGetRenderbufferParameteriv
		//glIsFramebuffer
		//glBindFramebuffer
		//glDeleteFramebuffers
		//glGenFramebuffers
		//glCheckFramebufferStatus
		//glFramebufferTexture1D
		//glFramebufferTexture2D
		//glFramebufferTexture3D
		//glFramebufferRenderbuffer
		//glGetFramebufferAttachmentParameteriv
		//glGenerateMipmap
		//glBlitFramebuffer
		//glRenderbufferStorageMultisample
		//glFramebufferTextureLayer
		//glMapBufferRange
		//glFlushMappedBufferRange
		//glBindVertexArray
		//glDeleteVertexArrays
		//glGenVertexArrays
		//glIsVertexArray
		//glDrawArraysInstanced
		//glDrawElementsInstanced
		//glTexBuffer
		//glPrimitiveRestartIndex
		//glCopyBufferSubData
		//glGetUniformIndices
		//glGetActiveUniformsiv
		//glGetActiveUniformName
		//glGetUniformBlockIndex
		//glGetActiveUniformBlockiv
		//glGetActiveUniformBlockName
		//glUniformBlockBinding
		//glBindBufferRange
		//glBindBufferBase
		//glGetIntegeri_v
		//glDrawElementsBaseVertex
		//glDrawRangeElementsBaseVertex
		//glDrawElementsInstancedBaseVertex
		//glMultiDrawElementsBaseVertex
		//glProvokingVertex
		//glFenceSync
		//glIsSync
		//glDeleteSync
		//glClientWaitSync
		//glWaitSync
		//glGetInteger64v
		//glGetSynciv
		//glGetInteger64i_v
		//glGetBufferParameteri64v
		//glFramebufferTexture
		//glTexImage2DMultisample
		//glTexImage3DMultisample
		//glGetMultisamplefv
		//glSampleMaski
		//glBindFragDataLocationIndexed
		//glGetFragDataIndex
		//glGenSamplers
		//glDeleteSamplers
		//glIsSampler
		//glBindSampler
		//glSamplerParameteri
		//glSamplerParameteriv
		//glSamplerParameterf
		//glSamplerParameterfv
		//glSamplerParameterIiv
		//glSamplerParameterIuiv
		//glGetSamplerParameteriv
		//glGetSamplerParameterIiv
		//glGetSamplerParameterfv
		//glGetSamplerParameterIuiv
		//glQueryCounter
		//glGetQueryObjecti64v
		//glGetQueryObjectui64v
		//glVertexAttribDivisor
		//glVertexAttribP1ui
		//glVertexAttribP1uiv
		//glVertexAttribP2ui
		//glVertexAttribP2uiv
		//glVertexAttribP3ui
		//glVertexAttribP3uiv
		//glVertexAttribP4ui
		//glVertexAttribP4uiv
		//glVertexP2ui
		//glVertexP2uiv
		//glVertexP3ui
		//glVertexP3uiv
		//glVertexP4ui
		//glVertexP4uiv
		//glTexCoordP1ui
		//glTexCoordP1uiv
		//glTexCoordP2ui
		//glTexCoordP2uiv
		//glTexCoordP3ui
		//glTexCoordP3uiv
		//glTexCoordP4ui
		//glTexCoordP4uiv
		//glMultiTexCoordP1ui
		//glMultiTexCoordP1uiv
		//glMultiTexCoordP2ui
		//glMultiTexCoordP2uiv
		//glMultiTexCoordP3ui
		//glMultiTexCoordP3uiv
		//glMultiTexCoordP4ui
		//glMultiTexCoordP4uiv
		//glNormalP3ui
		//glNormalP3uiv
		//glColorP3ui
		//glColorP3uiv
		//glColorP4ui
		//glColorP4uiv
		//glSecondaryColorP3ui
		//glSecondaryColorP3uiv
		//glMinSampleShading
		//glBlendEquationi
		//glBlendEquationSeparatei
		//glBlendFunci
		//glBlendFuncSeparatei
		//glDrawArraysIndirect
		//glDrawElementsIndirect
		//glUniform1d
		//glUniform2d
		//glUniform3d
		//glUniform4d
		//glUniform1dv
		//glUniform2dv
		//glUniform3dv
		//glUniform4dv
		//glUniformMatrix2dv
		//glUniformMatrix3dv
		//glUniformMatrix4dv
		//glUniformMatrix2x3dv
		//glUniformMatrix2x4dv
		//glUniformMatrix3x2dv
		//glUniformMatrix3x4dv
		//glUniformMatrix4x2dv
		//glUniformMatrix4x3dv
		//glGetUniformdv
		//glGetSubroutineUniformLocation
		//glGetSubroutineIndex
		//glGetActiveSubroutineUniformiv
		//glGetActiveSubroutineUniformName
		//glGetActiveSubroutineName
		//glUniformSubroutinesuiv
		//glGetUniformSubroutineuiv
		//glGetProgramStageiv
		//glPatchParameteri
		//glPatchParameterfv
		//glBindTransformFeedback
		//glDeleteTransformFeedbacks
		//glGenTransformFeedbacks
		//glIsTransformFeedback
		//glPauseTransformFeedback
		//glResumeTransformFeedback
		//glDrawTransformFeedback
		//glDrawTransformFeedbackStream
		//glBeginQueryIndexed
		//glEndQueryIndexed
		//glGetQueryIndexediv
		//glReleaseShaderCompiler
		//glShaderBinary
		//glGetShaderPrecisionFormat
		//glDepthRangef
		//glClearDepthf
		//glGetProgramBinary
		//glProgramBinary
		//glProgramParameteri
		//glUseProgramStages
		//glActiveShaderProgram
		//glCreateShaderProgramv
		//glBindProgramPipeline
		//glDeleteProgramPipelines
		//glGenProgramPipelines
		//glIsProgramPipeline
		//glGetProgramPipelineiv
		//glProgramParameteri
		//glProgramUniform1i
		//glProgramUniform1iv
		//glProgramUniform1f
		//glProgramUniform1fv
		//glProgramUniform1d
		//glProgramUniform1dv
		//glProgramUniform1ui
		//glProgramUniform1uiv
		//glProgramUniform2i
		//glProgramUniform2iv
		//glProgramUniform2f
		//glProgramUniform2fv
		//glProgramUniform2d
		//glProgramUniform2dv
		//glProgramUniform2ui
		//glProgramUniform2uiv
		//glProgramUniform3i
		//glProgramUniform3iv
		//glProgramUniform3f
		//glProgramUniform3fv
		//glProgramUniform3d
		//glProgramUniform3dv
		//glProgramUniform3ui
		//glProgramUniform3uiv
		//glProgramUniform4i
		//glProgramUniform4iv
		//glProgramUniform4f
		//glProgramUniform4fv
		//glProgramUniform4d
		//glProgramUniform4dv
		//glProgramUniform4ui
		//glProgramUniform4uiv
		//glProgramUniformMatrix2fv
		//glProgramUniformMatrix3fv
		//glProgramUniformMatrix4fv
		//glProgramUniformMatrix2dv
		//glProgramUniformMatrix3dv
		//glProgramUniformMatrix4dv
		//glProgramUniformMatrix2x3fv
		//glProgramUniformMatrix3x2fv
		//glProgramUniformMatrix2x4fv
		//glProgramUniformMatrix4x2fv
		//glProgramUniformMatrix3x4fv
		//glProgramUniformMatrix4x3fv
		//glProgramUniformMatrix2x3dv
		//glProgramUniformMatrix3x2dv
		//glProgramUniformMatrix2x4dv
		//glProgramUniformMatrix4x2dv
		//glProgramUniformMatrix3x4dv
		//glProgramUniformMatrix4x3dv
		//glValidateProgramPipeline
		//glGetProgramPipelineInfoLog
		//glVertexAttribL1d
		//glVertexAttribL2d
		//glVertexAttribL3d
		//glVertexAttribL4d
		//glVertexAttribL1dv
		//glVertexAttribL2dv
		//glVertexAttribL3dv
		//glVertexAttribL4dv
		//glVertexAttribLPointer
		//glGetVertexAttribLdv
		//glViewportArrayv
		//glViewportIndexedf
		//glViewportIndexedfv
		//glScissorArrayv
		//glScissorIndexed
		//glScissorIndexedv
		//glDepthRangeArrayv
		//glDepthRangeIndexed
		//glGetFloati_v
		//glGetDoublei_v
		//glDrawArraysInstancedBaseInstance
		//glDrawElementsInstancedBaseInstance
		//glDrawElementsInstancedBaseVertexBaseInstance
		//glGetInternalformativ
		//glGetActiveAtomicCounterBufferiv
		//glBindImageTexture
		//glMemoryBarrier
		//glTexStorage1D
		//glTexStorage2D
		//glTexStorage3D
		//glDrawTransformFeedbackInstanced
		//glDrawTransformFeedbackStreamInstanced
		//glClearBufferData
		//glClearBufferSubData
		//glDispatchCompute
		//glDispatchComputeIndirect
		//glCopyImageSubData
		//glFramebufferParameteri
		//glGetFramebufferParameteriv
		//glGetInternalformati64v
		//glInvalidateTexSubImage
		//glInvalidateTexImage
		//glInvalidateBufferSubData
		//glInvalidateBufferData
		//glInvalidateFramebuffer
		//glInvalidateSubFramebuffer
		//glMultiDrawArraysIndirect
		//glMultiDrawElementsIndirect
		//glGetProgramInterfaceiv
		//glGetProgramResourceIndex
		//glGetProgramResourceName
		//glGetProgramResourceiv
		//glGetProgramResourceLocation
		//glGetProgramResourceLocationIndex
		//glShaderStorageBlockBinding
		//glTexBufferRange
		//glTexStorage2DMultisample
		//glTexStorage3DMultisample
		//glTextureView
		//glBindVertexBuffer
		//glVertexAttribFormat
		//glVertexAttribIFormat
		//glVertexAttribLFormat
		//glVertexAttribBinding
		//glVertexBindingDivisor
		//glDebugMessageControl
		//glDebugMessageInsert
		//glDebugMessageCallback
		//glGetDebugMessageLog
		//glPushDebugGroup
		//glPopDebugGroup
		//glObjectLabel
		//glGetObjectLabel
		//glObjectPtrLabel
		//glGetObjectPtrLabel
		//glGetPointerv
		//glBufferStorage
		//glClearTexImage
		//glClearTexSubImage
		//glBindBuffersBase
		//glBindBuffersRange
		//glBindTextures
		//glBindSamplers
		//glBindImageTextures
		//glBindVertexBuffers
		//glClipControl
		//glCreateTransformFeedbacks
		//glTransformFeedbackBufferBase
		//glTransformFeedbackBufferRange
		//glGetTransformFeedbackiv
		//glGetTransformFeedbacki_v
		//glGetTransformFeedbacki64_v
		//glCreateBuffers
		//glNamedBufferStorage
		//glNamedBufferData
		//glNamedBufferSubData
		//glCopyNamedBufferSubData
		//glClearNamedBufferData
		//glClearNamedBufferSubData
		//glMapNamedBuffer
		//glMapNamedBufferRange
		//glUnmapNamedBuffer
		//glFlushMappedNamedBufferRange
		//glGetNamedBufferParameteriv
		//glGetNamedBufferParameteri64v
		//glGetNamedBufferPointerv
		//glGetNamedBufferSubData
		//glCreateFramebuffers
		//glNamedFramebufferRenderbuffer
		//glNamedFramebufferParameteri
		//glNamedFramebufferTexture
		//glNamedFramebufferTextureLayer
		//glNamedFramebufferDrawBuffer
		//glNamedFramebufferDrawBuffers
		//glNamedFramebufferReadBuffer
		//glInvalidateNamedFramebufferData
		//glInvalidateNamedFramebufferSubData
		//glClearNamedFramebufferiv
		//glClearNamedFramebufferuiv
		//glClearNamedFramebufferfv
		//glClearNamedFramebufferfi
		//glBlitNamedFramebuffer
		//glCheckNamedFramebufferStatus
		//glGetNamedFramebufferParameteriv
		//glGetNamedFramebufferAttachmentParameteriv
		//glCreateRenderbuffers
		//glNamedRenderbufferStorage
		//glNamedRenderbufferStorageMultisample
		//glGetNamedRenderbufferParameteriv
		//glCreateTextures
		//glTextureBuffer
		//glTextureBufferRange
		//glTextureStorage1D
		//glTextureStorage2D
		//glTextureStorage3D
		//glTextureStorage2DMultisample
		//glTextureStorage3DMultisample
		//glTextureSubImage1D
		//glTextureSubImage2D
		//glTextureSubImage3D
		//glCompressedTextureSubImage1D
		//glCompressedTextureSubImage2D
		//glCompressedTextureSubImage3D
		//glCopyTextureSubImage1D
		//glCopyTextureSubImage2D
		//glCopyTextureSubImage3D
		//glTextureParameterf
		//glTextureParameterfv
		//glTextureParameteri
		//glTextureParameterIiv
		//glTextureParameterIuiv
		//glTextureParameteriv
		//glGenerateTextureMipmap
		//glBindTextureUnit
		//glGetTextureImage
		//glGetCompressedTextureImage
		//glGetTextureLevelParameterfv
		//glGetTextureLevelParameteriv
		//glGetTextureParameterfv
		//glGetTextureParameterIiv
		//glGetTextureParameterIuiv
		//glGetTextureParameteriv
		//glCreateVertexArrays
		//glDisableVertexArrayAttrib
		//glEnableVertexArrayAttrib
		//glVertexArrayElementBuffer
		//glVertexArrayVertexBuffer
		//glVertexArrayVertexBuffers
		//glVertexArrayAttribBinding
		//glVertexArrayAttribFormat
		//glVertexArrayAttribIFormat
		//glVertexArrayAttribLFormat
		//glVertexArrayBindingDivisor
		//glGetVertexArrayiv
		//glGetVertexArrayIndexediv
		//glGetVertexArrayIndexed64iv
		//glCreateSamplers
		//glCreateProgramPipelines
		//glCreateQueries
		//glGetQueryBufferObjecti64v
		//glGetQueryBufferObjectiv
		//glGetQueryBufferObjectui64v
		//glGetQueryBufferObjectuiv
		//glMemoryBarrierByRegion
		//glGetTextureSubImage
		//glGetCompressedTextureSubImage
		//glGetGraphicsResetStatus
		//glGetnCompressedTexImage
		//glGetnTexImage
		//glGetnUniformdv
		//glGetnUniformfv
		//glGetnUniformiv
		//glGetnUniformuiv
		//glReadnPixels
		//glGetnMapdv
		//glGetnMapfv
		//glGetnMapiv
		//glGetnPixelMapfv
		//glGetnPixelMapuiv
		//glGetnPixelMapusv
		//glGetnPolygonStipple
		//glGetnColorTable
		//glGetnConvolutionFilter
		//glGetnSeparableFilter
		//glGetnHistogram
		//glGetnMinmax
		//glTextureBarrier
		//glSpecializeShader
		//glMultiDrawArraysIndirectCount
		//glMultiDrawElementsIndirectCount
		//glPolygonOffsetClamp

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
			LoadFunction("glBindBufferRange", out p_glBindBufferRange);
			LoadFunction("glBindBufferBase", out p_glBindBufferBase);
			LoadFunction("glGetIntegeri_v", out p_glGetIntegeri_v);
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
			LoadFunction("glProgramParameteri", out p_glProgramParameteri);
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
