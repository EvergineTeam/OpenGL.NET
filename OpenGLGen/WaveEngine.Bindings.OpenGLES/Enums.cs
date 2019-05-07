using System;

namespace WaveEngine.Bindings.OpenGLES
{
	public enum Extensions : uint
	{
		VersionEsCl10 = 1,
		VersionEsCm11 = 1,
		VersionEsCl11 = 1,
		RescaleNormal = 0x803A,
		MaxTextureUnits = 0x84E2,
		UnsignedShort565 = 0x8363,
		ClientActiveTexture = 0x84E1,
		VertexArrayBufferBinding = 0x8896,
		NormalArrayBufferBinding = 0x8897,
		ColorArrayBufferBinding = 0x8898,
		TextureCoordArrayBufferBinding = 0x889A,
		Subtract = 0x84E7,
		Combine = 0x8570,
		CombineRgb = 0x8571,
		CombineAlpha = 0x8572,
		RgbScale = 0x8573,
		AddSigned = 0x8574,
		Interpolate = 0x8575,
		Previous = 0x8578,
		Operand0Rgb = 0x8590,
		Operand1Rgb = 0x8591,
		Operand2Rgb = 0x8592,
		Operand0Alpha = 0x8598,
		Operand1Alpha = 0x8599,
		Operand2Alpha = 0x859A,
		Src0Rgb = 0x8580,
		Src1Rgb = 0x8581,
		Src2Rgb = 0x8582,
		Src0Alpha = 0x8588,
		Src2Alpha = 0x858A,
		Dot3Rgb = 0x86AE,
		Dot3Rgba = 0x86AF,
		BlendEquation = 0x8009,
		MirroredRepeat = 0x8370,
		VertexAttribArrayPointer = 0x8645,
		ShaderBinaryFormats = 0x8DF8,
		Rgb565 = 0x8D62,
		StencilIndex8 = 0x8D48,
		FramebufferAttachmentObjectType = 0x8CD0,
		StencilAttachment = 0x8D20,
		FramebufferIncompleteDimensions = 0x8CD9,
		FramebufferBinding = 0x8CA6,
		DepthComponent24 = 0x81A6,
		BufferMapPointer = 0x88BD,
		DrawBuffer0 = 0x8825,
		DrawBuffer1 = 0x8826,
		DrawBuffer2 = 0x8827,
		DrawBuffer3 = 0x8828,
		DrawBuffer4 = 0x8829,
		DrawBuffer5 = 0x882A,
		DrawBuffer6 = 0x882B,
		DrawBuffer7 = 0x882C,
		DrawBuffer8 = 0x882D,
		DrawBuffer9 = 0x882E,
		DrawBuffer10 = 0x882F,
		DrawBuffer11 = 0x8830,
		DrawBuffer12 = 0x8831,
		DrawBuffer13 = 0x8832,
		DrawBuffer14 = 0x8833,
		DrawBuffer15 = 0x8834,
		CompareRefToTexture = 0x884E,
		Rgb32f = 0x8815,
		UnsignedInt5999Rev = 0x8C3E,
		MaxTransformFeedbackSeparateComponents = 0x8C80,
		MaxTransformFeedbackInterleavedComponents = 0x8C8A,
		MaxTransformFeedbackSeparateAttribs = 0x8C8B,
		InterleavedAttribs = 0x8C8C,
		SeparateAttribs = 0x8C8D,
		Sampler2dArray = 0x8DC1,
		Sampler2dArrayShadow = 0x8DC4,
		SamplerCubeShadow = 0x8DC5,
		UnsignedIntVec2 = 0x8DC6,
		UnsignedIntVec3 = 0x8DC7,
		UnsignedIntVec4 = 0x8DC8,
		IntSampler2d = 0x8DCA,
		IntSampler3d = 0x8DCB,
		IntSamplerCube = 0x8DCC,
		IntSampler2dArray = 0x8DCF,
		UnsignedIntSampler2d = 0x8DD2,
		UnsignedIntSampler3d = 0x8DD3,
		UnsignedIntSamplerCube = 0x8DD4,
		UnsignedIntSampler2dArray = 0x8DD7,
		Float32UnsignedInt248Rev = 0x8DAD,
		FramebufferDefault = 0x8218,
		UnsignedInt248 = 0x84FA,
		UnsignedNormalized = 0x8C17,
		MaxSamples = 0x8D57,
		SignedNormalized = 0x8F9C,
		CopyReadBufferBinding = 0x8F36,
		CopyWriteBufferBinding = 0x8F37,
		InvalidIndex = 0xFFFFFFFF,
		SyncFence = 0x9116,
		Unsignaled = 0x9118,
		Signaled = 0x9119,
		TransformFeedbackBinding = 0x8E25,
		TextureImmutableFormat = 0x912F,
		TextureImmutableLevels = 0x82DF,
		MaxComputeImageUniforms = 0x91BD,
		MaxComputeSharedMemorySize = 0x8262,
		DrawIndirectBufferBinding = 0x8F43,
		NameLength = 0x92F9,
		Type = 0x92FA,
		ArraySize = 0x92FB,
		Offset = 0x92FC,
		BlockIndex = 0x92FD,
		ArrayStride = 0x92FE,
		MatrixStride = 0x92FF,
		IsRowMajor = 0x9300,
		AtomicCounterBufferIndex = 0x9301,
		BufferBinding = 0x9302,
		BufferDataSize = 0x9303,
		NumActiveVariables = 0x9304,
		ActiveVariables = 0x9305,
		ReferencedByVertexShader = 0x9306,
		ReferencedByFragmentShader = 0x930A,
		ReferencedByComputeShader = 0x930B,
		TopLevelArraySize = 0x930C,
		TopLevelArrayStride = 0x930D,
		Location = 0x930E,
		AtomicCounterBufferStart = 0x92C2,
		AtomicCounterBufferSize = 0x92C3,
		MaxVertexAtomicCounterBuffers = 0x92CC,
		MaxFragmentAtomicCounterBuffers = 0x92D0,
		MaxCombinedAtomicCounterBuffers = 0x92D1,
		MaxAtomicCounterBufferSize = 0x92D8,
		MaxAtomicCounterBufferBindings = 0x92DC,
		UnsignedIntAtomicCounter = 0x92DB,
		MaxImageUnits = 0x8F38,
		MaxVertexImageUniforms = 0x90CA,
		MaxFragmentImageUniforms = 0x90CE,
		MaxCombinedImageUniforms = 0x90CF,
		ImageBindingName = 0x8F3A,
		ImageBindingLevel = 0x8F3B,
		ImageBindingLayered = 0x8F3C,
		ImageBindingLayer = 0x8F3D,
		ImageBindingAccess = 0x8F3E,
		ImageBindingFormat = 0x906E,
		Image2d = 0x904D,
		Image3d = 0x904E,
		ImageCube = 0x9050,
		Image2dArray = 0x9053,
		IntImage2d = 0x9058,
		IntImage3d = 0x9059,
		IntImageCube = 0x905B,
		IntImage2dArray = 0x905E,
		UnsignedIntImage2d = 0x9063,
		UnsignedIntImage3d = 0x9064,
		UnsignedIntImageCube = 0x9066,
		UnsignedIntImage2dArray = 0x9069,
		ImageFormatCompatibilityBySize = 0x90C8,
		ImageFormatCompatibilityByClass = 0x90C9,
		MaxShaderStorageBlockSize = 0x90DE,
		MaxCombinedShaderOutputResources = 0x8F39,
		MinProgramTextureGatherOffset = 0x8E5E,
		MaxProgramTextureGatherOffset = 0x8E5F,
		SamplePosition = 0x8E50,
		SampleMaskValue = 0x8E52,
		TextureSamples = 0x9106,
		TextureFixedSampleLocations = 0x9107,
		TextureDepth = 0x8071,
		TextureDepthSize = 0x884A,
		TextureStencilSize = 0x88F1,
		TextureSharedSize = 0x8C3F,
		TextureRedType = 0x8C10,
		TextureGreenType = 0x8C11,
		TextureBlueType = 0x8C12,
		TextureAlphaType = 0x8C13,
		TextureDepthType = 0x8C16,
		Sampler2dMultisample = 0x9108,
		IntSampler2dMultisample = 0x9109,
		UnsignedIntSampler2dMultisample = 0x910A,
		VertexAttribBinding = 0x82D4,
		VertexBindingBuffer = 0x8F4F,
		MaxVertexAttribStride = 0x82E5,
		MultisampleLineWidthRange = 0x9381,
		MultisampleLineWidthGranularity = 0x9382,
		Multiply = 0x9294,
		Screen = 0x9295,
		Overlay = 0x9296,
		Darken = 0x9297,
		Lighten = 0x9298,
		Colordodge = 0x9299,
		Colorburn = 0x929A,
		Hardlight = 0x929B,
		Softlight = 0x929C,
		Difference = 0x929E,
		Exclusion = 0x92A0,
		HslHue = 0x92AD,
		HslSaturation = 0x92AE,
		HslColor = 0x92AF,
		HslLuminosity = 0x92B0,
		DebugNextLoggedMessageLength = 0x8243,
		MaxDebugMessageLength = 0x9143,
		MaxDebugLoggedMessages = 0x9144,
		DebugLoggedMessages = 0x9145,
		GeometryShaderInvocations = 0x887F,
		MaxGeometryOutputVertices = 0x8DE0,
		MaxGeometryTotalOutputComponents = 0x8DE1,
		MaxGeometryShaderInvocations = 0x8E5A,
		MaxGeometryAtomicCounterBuffers = 0x92CF,
		MaxGeometryImageUniforms = 0x90CD,
		UndefinedVertex = 0x8260,
		ReferencedByGeometryShader = 0x9309,
		PrimitiveBoundingBox = 0x92BE,
		LoseContextOnReset = 0x8252,
		ResetNotificationStrategy = 0x8256,
		NoResetNotification = 0x8261,
		ContextLost = 0x0507,
		MinSampleShadingValue = 0x8C37,
		MinFragmentInterpolationOffset = 0x8E5B,
		MaxFragmentInterpolationOffset = 0x8E5C,
		FragmentInterpolationOffsetBits = 0x8E5D,
		TessControlOutputVertices = 0x8E75,
		TessGenMode = 0x8E76,
		TessGenSpacing = 0x8E77,
		TessGenVertexOrder = 0x8E78,
		TessGenPointMode = 0x8E79,
		Isolines = 0x8E7A,
		FractionalOdd = 0x8E7B,
		FractionalEven = 0x8E7C,
		MaxPatchVertices = 0x8E7D,
		MaxTessGenLevel = 0x8E7E,
		MaxTessControlUniformComponents = 0x8E7F,
		MaxTessEvaluationUniformComponents = 0x8E80,
		MaxTessControlTextureImageUnits = 0x8E81,
		MaxTessEvaluationTextureImageUnits = 0x8E82,
		MaxTessControlOutputComponents = 0x8E83,
		MaxTessPatchComponents = 0x8E84,
		MaxTessControlTotalOutputComponents = 0x8E85,
		MaxTessEvaluationOutputComponents = 0x8E86,
		MaxTessControlUniformBlocks = 0x8E89,
		MaxTessEvaluationUniformBlocks = 0x8E8A,
		MaxTessControlInputComponents = 0x886C,
		MaxTessEvaluationInputComponents = 0x886D,
		MaxCombinedTessControlUniformComponents = 0x8E1E,
		MaxCombinedTessEvaluationUniformComponents = 0x8E1F,
		MaxTessControlAtomicCounterBuffers = 0x92CD,
		MaxTessEvaluationAtomicCounterBuffers = 0x92CE,
		MaxTessControlImageUniforms = 0x90CB,
		MaxTessEvaluationImageUniforms = 0x90CC,
		PrimitiveRestartForPatchesSupported = 0x8221,
		IsPerPatch = 0x92E7,
		ReferencedByTessControlShader = 0x9307,
		ReferencedByTessEvaluationShader = 0x9308,
		TextureBufferBinding = 0x8C2A,
		TextureBufferDataStoreBinding = 0x8C2D,
		SamplerBuffer = 0x8DC2,
		IntSamplerBuffer = 0x8DD0,
		UnsignedIntSamplerBuffer = 0x8DD8,
		ImageBuffer = 0x9051,
		IntImageBuffer = 0x905C,
		UnsignedIntImageBuffer = 0x9067,
		TextureBufferOffset = 0x919D,
		TextureBufferSize = 0x919E,
		CompressedRgbaAstc4x4 = 0x93B0,
		CompressedRgbaAstc5x4 = 0x93B1,
		CompressedRgbaAstc5x5 = 0x93B2,
		CompressedRgbaAstc6x5 = 0x93B3,
		CompressedRgbaAstc6x6 = 0x93B4,
		CompressedRgbaAstc8x5 = 0x93B5,
		CompressedRgbaAstc8x6 = 0x93B6,
		CompressedRgbaAstc8x8 = 0x93B7,
		CompressedRgbaAstc10x5 = 0x93B8,
		CompressedRgbaAstc10x6 = 0x93B9,
		CompressedRgbaAstc10x8 = 0x93BA,
		CompressedRgbaAstc10x10 = 0x93BB,
		CompressedRgbaAstc12x10 = 0x93BC,
		CompressedRgbaAstc12x12 = 0x93BD,
		CompressedSrgb8Alpha8Astc4x4 = 0x93D0,
		CompressedSrgb8Alpha8Astc5x4 = 0x93D1,
		CompressedSrgb8Alpha8Astc5x5 = 0x93D2,
		CompressedSrgb8Alpha8Astc6x5 = 0x93D3,
		CompressedSrgb8Alpha8Astc6x6 = 0x93D4,
		CompressedSrgb8Alpha8Astc8x5 = 0x93D5,
		CompressedSrgb8Alpha8Astc8x6 = 0x93D6,
		CompressedSrgb8Alpha8Astc8x8 = 0x93D7,
		CompressedSrgb8Alpha8Astc10x5 = 0x93D8,
		CompressedSrgb8Alpha8Astc10x6 = 0x93D9,
		CompressedSrgb8Alpha8Astc10x8 = 0x93DA,
		CompressedSrgb8Alpha8Astc10x10 = 0x93DB,
		CompressedSrgb8Alpha8Astc12x10 = 0x93DC,
		CompressedSrgb8Alpha8Astc12x12 = 0x93DD,
		TextureBindingCubeMapArray = 0x900A,
		SamplerCubeMapArray = 0x900C,
		SamplerCubeMapArrayShadow = 0x900D,
		IntSamplerCubeMapArray = 0x900E,
		UnsignedIntSamplerCubeMapArray = 0x900F,
		ImageCubeMapArray = 0x9054,
		IntImageCubeMapArray = 0x905F,
		UnsignedIntImageCubeMapArray = 0x906A,
		Sampler2dMultisampleArray = 0x910B,
		IntSampler2dMultisampleArray = 0x910C,
		UnsignedIntSampler2dMultisampleArray = 0x910D,
	}

	public enum AttribMask : uint
	{
		DepthBufferBit = 0x00000100,
		StencilBufferBit = 0x00000400,
		ColorBufferBit = 0x00004000,
	}

	public enum PrimitiveType : uint
	{
		Points = 0x0000,
		Lines = 0x0001,
		LineLoop = 0x0002,
		LineStrip = 0x0003,
		Triangles = 0x0004,
		TriangleStrip = 0x0005,
		TriangleFan = 0x0006,
		LinesAdjacency = 0x000A,
		LineStripAdjacency = 0x000B,
		TrianglesAdjacency = 0x000C,
		TriangleStripAdjacency = 0x000D,
		Patches = 0x000E,
		Quads = 0x0007,
	}

	public enum AlphaFunction : uint
	{
		Never = 0x0200,
		Less = 0x0201,
		Equal = 0x0202,
		Lequal = 0x0203,
		Greater = 0x0204,
		Notequal = 0x0205,
		Gequal = 0x0206,
		Always = 0x0207,
	}

	public enum StencilOp : uint
	{
		Zero = 0,
		Keep = 0x1E00,
		Incr = 0x1E02,
		Decr = 0x1E03,
		IncrWrap = 0x8507,
		DecrWrap = 0x8508,
	}

	public enum BlendingFactor : uint
	{
		One = 1,
		SrcColor = 0x0300,
		OneMinusSrcColor = 0x0301,
		SrcAlpha = 0x0302,
		OneMinusSrcAlpha = 0x0303,
		DstAlpha = 0x0304,
		OneMinusDstAlpha = 0x0305,
		DstColor = 0x0306,
		OneMinusDstColor = 0x0307,
		SrcAlphaSaturate = 0x0308,
		Src1Alpha = 0x8589,
		ConstantColor = 0x8001,
		OneMinusConstantColor = 0x8002,
		ConstantAlpha = 0x8003,
		OneMinusConstantAlpha = 0x8004,
	}

	public enum ClipPlaneName : uint
	{
		ClipPlane0 = 0x3000,
		ClipPlane1 = 0x3001,
		ClipPlane2 = 0x3002,
		ClipPlane3 = 0x3003,
		ClipPlane4 = 0x3004,
		ClipPlane5 = 0x3005,
	}

	public enum ColorMaterialFace : uint
	{
		Front = 0x0404,
		Back = 0x0405,
		FrontAndBack = 0x0408,
	}

	public enum EnableCap : uint
	{
		Fog = 0x0B60,
		Lighting = 0x0B50,
		Texture2d = 0x0DE1,
		CullFace = 0x0B44,
		AlphaTest = 0x0BC0,
		Blend = 0x0BE2,
		ColorLogicOp = 0x0BF2,
		Dither = 0x0BD0,
		StencilTest = 0x0B90,
		DepthTest = 0x0B71,
		PointSmooth = 0x0B10,
		LineSmooth = 0x0B20,
		ScissorTest = 0x0C11,
		ColorMaterial = 0x0B57,
		Normalize = 0x0BA1,
		VertexArray = 0x8074,
		NormalArray = 0x8075,
		ColorArray = 0x8076,
		TextureCoordArray = 0x8078,
		Multisample = 0x809D,
		SampleAlphaToCoverage = 0x809E,
		SampleAlphaToOne = 0x809F,
		SampleCoverage = 0x80A0,
		PolygonOffsetFill = 0x8037,
		Light0 = 0x4000,
		Light1 = 0x4001,
		Light2 = 0x4002,
		Light3 = 0x4003,
		Light4 = 0x4004,
		Light5 = 0x4005,
		Light6 = 0x4006,
		Light7 = 0x4007,
		RasterizerDiscard = 0x8C89,
		PrimitiveRestartFixedIndex = 0x8D69,
		SampleMask = 0x8E51,
		DebugOutputSynchronous = 0x8242,
		DebugOutput = 0x92E0,
		SampleShading = 0x8C36,
	}

	public enum ErrorCode : uint
	{
		NoError = 0,
		InvalidEnum = 0x0500,
		InvalidValue = 0x0501,
		InvalidOperation = 0x0502,
		StackOverflow = 0x0503,
		StackUnderflow = 0x0504,
		OutOfMemory = 0x0505,
		InvalidFramebufferOperation = 0x0506,
	}

	public enum FogMode : uint
	{
		Exp = 0x0800,
		Exp2 = 0x0801,
		Linear = 0x2601,
	}

	public enum FogParameter : uint
	{
		FogDensity = 0x0B62,
		FogStart = 0x0B63,
		FogEnd = 0x0B64,
		FogMode = 0x0B65,
		FogColor = 0x0B66,
	}

	public enum FrontFaceDirection : uint
	{
		Cw = 0x0900,
		Ccw = 0x0901,
	}

	public enum GetPName : uint
	{
		CurrentColor = 0x0B00,
		CurrentNormal = 0x0B02,
		CurrentTextureCoords = 0x0B03,
		PointSize = 0x0B11,
		PointFadeThresholdSize = 0x8128,
		SmoothPointSizeRange = 0x0B12,
		LineWidth = 0x0B21,
		SmoothLineWidthRange = 0x0B22,
		AliasedPointSizeRange = 0x846D,
		AliasedLineWidthRange = 0x846E,
		CullFaceMode = 0x0B45,
		FrontFace = 0x0B46,
		ShadeModel = 0x0B54,
		DepthRange = 0x0B70,
		DepthWritemask = 0x0B72,
		DepthClearValue = 0x0B73,
		DepthFunc = 0x0B74,
		StencilClearValue = 0x0B91,
		StencilFunc = 0x0B92,
		StencilValueMask = 0x0B93,
		StencilFail = 0x0B94,
		StencilPassDepthFail = 0x0B95,
		StencilPassDepthPass = 0x0B96,
		StencilRef = 0x0B97,
		StencilWritemask = 0x0B98,
		MatrixMode = 0x0BA0,
		Viewport = 0x0BA2,
		ModelviewStackDepth = 0x0BA3,
		ProjectionStackDepth = 0x0BA4,
		TextureStackDepth = 0x0BA5,
		ModelviewMatrix = 0x0BA6,
		ProjectionMatrix = 0x0BA7,
		TextureMatrix = 0x0BA8,
		AlphaTestFunc = 0x0BC1,
		AlphaTestRef = 0x0BC2,
		BlendDst = 0x0BE0,
		BlendSrc = 0x0BE1,
		LogicOpMode = 0x0BF0,
		ScissorBox = 0x0C10,
		ColorClearValue = 0x0C22,
		ColorWritemask = 0x0C23,
		MaxLights = 0x0D31,
		MaxClipPlanes = 0x0D32,
		MaxTextureSize = 0x0D33,
		MaxModelviewStackDepth = 0x0D36,
		MaxProjectionStackDepth = 0x0D38,
		MaxTextureStackDepth = 0x0D39,
		MaxViewportDims = 0x0D3A,
		SubpixelBits = 0x0D50,
		RedBits = 0x0D52,
		GreenBits = 0x0D53,
		BlueBits = 0x0D54,
		AlphaBits = 0x0D55,
		DepthBits = 0x0D56,
		StencilBits = 0x0D57,
		PolygonOffsetUnits = 0x2A00,
		PolygonOffsetFactor = 0x8038,
		TextureBinding2d = 0x8069,
		VertexArraySize = 0x807A,
		VertexArrayType = 0x807B,
		VertexArrayStride = 0x807C,
		NormalArrayType = 0x807E,
		NormalArrayStride = 0x807F,
		ColorArraySize = 0x8081,
		ColorArrayType = 0x8082,
		ColorArrayStride = 0x8083,
		TextureCoordArraySize = 0x8088,
		TextureCoordArrayType = 0x8089,
		TextureCoordArrayStride = 0x808A,
		SampleBuffers = 0x80A8,
		Samples = 0x80A9,
		SampleCoverageValue = 0x80AA,
		SampleCoverageInvert = 0x80AB,
		NumCompressedTextureFormats = 0x86A2,
		CompressedTextureFormats = 0x86A3,
		PerspectiveCorrectionHint = 0x0C50,
		PointSmoothHint = 0x0C51,
		LineSmoothHint = 0x0C52,
		FogHint = 0x0C54,
		LightModelAmbient = 0x0B53,
		LightModelTwoSide = 0x0B52,
		UnpackAlignment = 0x0CF5,
		PackAlignment = 0x0D05,
		ActiveTexture = 0x84E0,
		ArrayBufferBinding = 0x8894,
		ElementArrayBufferBinding = 0x8895,
		AlphaScale = 0x0D1C,
		BlendEquationRgb = 0x8009,
		BlendEquationAlpha = 0x883D,
		BlendDstRgb = 0x80C8,
		BlendSrcRgb = 0x80C9,
		BlendDstAlpha = 0x80CA,
		BlendSrcAlpha = 0x80CB,
		BlendColor = 0x8005,
		StencilBackFunc = 0x8800,
		StencilBackFail = 0x8801,
		StencilBackPassDepthFail = 0x8802,
		StencilBackPassDepthPass = 0x8803,
		StencilBackRef = 0x8CA3,
		StencilBackValueMask = 0x8CA4,
		StencilBackWritemask = 0x8CA5,
		MaxVertexAttribs = 0x8869,
		MaxVertexUniformVectors = 0x8DFB,
		MaxVaryingVectors = 0x8DFC,
		MaxCombinedTextureImageUnits = 0x8B4D,
		MaxVertexTextureImageUnits = 0x8B4C,
		MaxTextureImageUnits = 0x8872,
		MaxFragmentUniformVectors = 0x8DFD,
		CurrentProgram = 0x8B8D,
		TextureBindingCubeMap = 0x8514,
		MaxCubeMapTextureSize = 0x851C,
		ImplementationColorReadType = 0x8B9A,
		ImplementationColorReadFormat = 0x8B9B,
		ShaderCompiler = 0x8DFA,
		NumShaderBinaryFormats = 0x8DF9,
		RenderbufferBinding = 0x8CA7,
		MaxRenderbufferSize = 0x84E8,
		ReadBuffer = 0x0C02,
		TextureBinding3d = 0x806A,
		Max3dTextureSize = 0x8073,
		MaxElementsVertices = 0x80E8,
		MaxElementsIndices = 0x80E9,
		MaxTextureLodBias = 0x84FD,
		MaxDrawBuffers = 0x8824,
		MaxFragmentUniformComponents = 0x8B49,
		MaxVertexUniformComponents = 0x8B4A,
		FragmentShaderDerivativeHint = 0x8B8B,
		PixelPackBufferBinding = 0x88ED,
		PixelUnpackBufferBinding = 0x88EF,
		MajorVersion = 0x821B,
		MinorVersion = 0x821C,
		NumExtensions = 0x821D,
		MaxArrayTextureLayers = 0x88FF,
		MinProgramTexelOffset = 0x8904,
		MaxProgramTexelOffset = 0x8905,
		MaxVaryingComponents = 0x8B4B,
		TextureBinding2dArray = 0x8C1D,
		TransformFeedbackBufferStart = 0x8C84,
		TransformFeedbackBufferSize = 0x8C85,
		TransformFeedbackBufferBinding = 0x8C8F,
		DrawFramebufferBinding = 0x8CA6,
		ReadFramebufferBinding = 0x8CAA,
		VertexArrayBinding = 0x85B5,
		UniformBufferBinding = 0x8A28,
		UniformBufferStart = 0x8A29,
		UniformBufferSize = 0x8A2A,
		MaxVertexUniformBlocks = 0x8A2B,
		MaxFragmentUniformBlocks = 0x8A2D,
		MaxCombinedUniformBlocks = 0x8A2E,
		MaxUniformBufferBindings = 0x8A2F,
		MaxUniformBlockSize = 0x8A30,
		MaxCombinedVertexUniformComponents = 0x8A31,
		MaxCombinedFragmentUniformComponents = 0x8A33,
		UniformBufferOffsetAlignment = 0x8A34,
		MaxVertexOutputComponents = 0x9122,
		MaxFragmentInputComponents = 0x9125,
		MaxServerWaitTimeout = 0x9111,
		SamplerBinding = 0x8919,
		NumProgramBinaryFormats = 0x87FE,
		ProgramBinaryFormats = 0x87FF,
		MaxElementIndex = 0x8D6B,
		MaxComputeUniformBlocks = 0x91BB,
		MaxComputeTextureImageUnits = 0x91BC,
		MaxComputeUniformComponents = 0x8263,
		MaxComputeAtomicCounterBuffers = 0x8264,
		MaxComputeAtomicCounters = 0x8265,
		MaxCombinedComputeUniformComponents = 0x8266,
		MaxComputeWorkGroupInvocations = 0x90EB,
		MaxComputeWorkGroupCount = 0x91BE,
		MaxComputeWorkGroupSize = 0x91BF,
		DispatchIndirectBufferBinding = 0x90EF,
		MaxUniformLocations = 0x826E,
		MaxFramebufferWidth = 0x9315,
		MaxFramebufferHeight = 0x9316,
		MaxFramebufferSamples = 0x9318,
		ProgramPipelineBinding = 0x825A,
		MaxVertexAtomicCounters = 0x92D2,
		MaxFragmentAtomicCounters = 0x92D6,
		MaxCombinedAtomicCounters = 0x92D7,
		ShaderStorageBufferBinding = 0x90D3,
		ShaderStorageBufferStart = 0x90D4,
		ShaderStorageBufferSize = 0x90D5,
		MaxVertexShaderStorageBlocks = 0x90D6,
		MaxFragmentShaderStorageBlocks = 0x90DA,
		MaxComputeShaderStorageBlocks = 0x90DB,
		MaxCombinedShaderStorageBlocks = 0x90DC,
		MaxShaderStorageBufferBindings = 0x90DD,
		ShaderStorageBufferOffsetAlignment = 0x90DF,
		MaxSampleMaskWords = 0x8E59,
		MaxColorTextureSamples = 0x910E,
		MaxDepthTextureSamples = 0x910F,
		MaxIntegerSamples = 0x9110,
		TextureBinding2dMultisample = 0x9104,
		VertexBindingDivisor = 0x82D6,
		VertexBindingOffset = 0x82D7,
		VertexBindingStride = 0x82D8,
		MaxVertexAttribRelativeOffset = 0x82D9,
		MaxVertexAttribBindings = 0x82DA,
		MaxDebugGroupStackDepth = 0x826C,
		DebugGroupStackDepth = 0x826D,
		MaxLabelLength = 0x82E8,
		LayerProvokingVertex = 0x825E,
		MaxGeometryUniformComponents = 0x8DDF,
		MaxGeometryUniformBlocks = 0x8A2C,
		MaxCombinedGeometryUniformComponents = 0x8A32,
		MaxGeometryInputComponents = 0x9123,
		MaxGeometryOutputComponents = 0x9124,
		MaxGeometryTextureImageUnits = 0x8C29,
		MaxGeometryAtomicCounters = 0x92D5,
		MaxGeometryShaderStorageBlocks = 0x90D7,
		MaxFramebufferLayers = 0x9317,
		ContextFlags = 0x821E,
		MaxTessControlAtomicCounters = 0x92D3,
		MaxTessEvaluationAtomicCounters = 0x92D4,
		MaxTessControlShaderStorageBlocks = 0x90D8,
		MaxTessEvaluationShaderStorageBlocks = 0x90D9,
		MaxTextureBufferSize = 0x8C2B,
		TextureBindingBuffer = 0x8C2C,
		TextureBufferOffsetAlignment = 0x919F,
		TextureBinding2dMultisampleArray = 0x9105,
	}

	public enum PointParameterNameSGIS : uint
	{
		PointSizeMin = 0x8126,
		PointSizeMax = 0x8127,
		PointDistanceAttenuation = 0x8129,
	}

	public enum GetPointervPName : uint
	{
		VertexArrayPointer = 0x808E,
		NormalArrayPointer = 0x808F,
		ColorArrayPointer = 0x8090,
		TextureCoordArrayPointer = 0x8092,
		DebugCallbackFunction = 0x8244,
		DebugCallbackUserParam = 0x8245,
	}

	public enum HintMode : uint
	{
		DontCare = 0x1100,
		Fastest = 0x1101,
		Nicest = 0x1102,
	}

	public enum HintTarget : uint
	{
		GenerateMipmapHint = 0x8192,
		ProgramBinaryRetrievableHint = 0x8257,
	}

	public enum ColorMaterialParameter : uint
	{
		Ambient = 0x1200,
		Diffuse = 0x1201,
		Specular = 0x1202,
		Emission = 0x1600,
		AmbientAndDiffuse = 0x1602,
	}

	public enum LightParameter : uint
	{
		Position = 0x1203,
		SpotDirection = 0x1204,
		SpotExponent = 0x1205,
		SpotCutoff = 0x1206,
		ConstantAttenuation = 0x1207,
		LinearAttenuation = 0x1208,
		QuadraticAttenuation = 0x1209,
	}

	public enum ColorPointerType : uint
	{
		Byte = 0x1400,
		UnsignedByte = 0x1401,
		Short = 0x1402,
		UnsignedShort = 0x1403,
		Float = 0x1406,
	}

	public enum VertexAttribType : uint
	{
		Fixed = 0x140C,
	}

	public enum LogicOp : uint
	{
		Clear = 0x1500,
		And = 0x1501,
		AndReverse = 0x1502,
		Copy = 0x1503,
		AndInverted = 0x1504,
		Noop = 0x1505,
		Xor = 0x1506,
		Or = 0x1507,
		Nor = 0x1508,
		Equiv = 0x1509,
		Invert = 0x150A,
		OrReverse = 0x150B,
		CopyInverted = 0x150C,
		OrInverted = 0x150D,
		Nand = 0x150E,
		Set = 0x150F,
	}

	public enum MaterialParameter : uint
	{
		Shininess = 0x1601,
	}

	public enum MatrixMode : uint
	{
		Modelview = 0x1700,
		Projection = 0x1701,
		Texture = 0x1702,
	}

	public enum PixelFormat : uint
	{
		Alpha = 0x1906,
		Rgb = 0x1907,
		Rgba = 0x1908,
		Luminance = 0x1909,
		LuminanceAlpha = 0x190A,
		RedInteger = 0x8D94,
		RgbInteger = 0x8D98,
		RgbaInteger = 0x8D99,
		RgInteger = 0x8228,
		Green = 0x1904,
		Blue = 0x1905,
		StencilIndex = 0x1901,
	}

	public enum PixelType : uint
	{
		UnsignedShort4444 = 0x8033,
		UnsignedShort5551 = 0x8034,
	}

	public enum ShadingModel : uint
	{
		Flat = 0x1D00,
		Smooth = 0x1D01,
	}

	public enum LightEnvModeSGIX : uint
	{
		Replace = 0x1E01,
		Modulate = 0x2100,
	}

	public enum StringName : uint
	{
		Vendor = 0x1F00,
		Renderer = 0x1F01,
		Version = 0x1F02,
		Extensions = 0x1F03,
		ShadingLanguageVersion = 0x8B8C,
	}

	public enum TextureEnvMode : uint
	{
		Decal = 0x2101,
	}

	public enum AccumOp : uint
	{
		Add = 0x0104,
	}

	public enum TextureEnvParameter : uint
	{
		TextureEnvMode = 0x2200,
		TextureEnvColor = 0x2201,
	}

	public enum TextureEnvTarget : uint
	{
		TextureEnv = 0x2300,
	}

	public enum TextureMagFilter : uint
	{
		Nearest = 0x2600,
	}

	public enum TextureMinFilter : uint
	{
		NearestMipmapNearest = 0x2700,
		LinearMipmapNearest = 0x2701,
		NearestMipmapLinear = 0x2702,
		LinearMipmapLinear = 0x2703,
	}

	public enum GetTextureParameter : uint
	{
		TextureMagFilter = 0x2800,
		TextureMinFilter = 0x2801,
		TextureWrapS = 0x2802,
		TextureWrapT = 0x2803,
		TextureWidth = 0x1000,
		TextureHeight = 0x1001,
		TextureInternalFormat = 0x1003,
		TextureRedSize = 0x805C,
		TextureGreenSize = 0x805D,
		TextureBlueSize = 0x805E,
		TextureAlphaSize = 0x805F,
	}

	public enum TextureParameterName : uint
	{
		GenerateMipmap = 0x8191,
		TextureWrapR = 0x8072,
		TextureMinLod = 0x813A,
		TextureMaxLod = 0x813B,
		TextureBaseLevel = 0x813C,
		TextureMaxLevel = 0x813D,
		TextureCompareMode = 0x884C,
		TextureCompareFunc = 0x884D,
		TextureSwizzleR = 0x8E42,
		TextureSwizzleG = 0x8E43,
		TextureSwizzleB = 0x8E44,
		TextureSwizzleA = 0x8E45,
		DepthStencilTextureMode = 0x90EA,
	}

	public enum TextureUnit : uint
	{
		Texture0 = 0x84C0,
		Texture1 = 0x84C1,
		Texture2 = 0x84C2,
		Texture3 = 0x84C3,
		Texture4 = 0x84C4,
		Texture5 = 0x84C5,
		Texture6 = 0x84C6,
		Texture7 = 0x84C7,
		Texture8 = 0x84C8,
		Texture9 = 0x84C9,
		Texture10 = 0x84CA,
		Texture11 = 0x84CB,
		Texture12 = 0x84CC,
		Texture13 = 0x84CD,
		Texture14 = 0x84CE,
		Texture15 = 0x84CF,
		Texture16 = 0x84D0,
		Texture17 = 0x84D1,
		Texture18 = 0x84D2,
		Texture19 = 0x84D3,
		Texture20 = 0x84D4,
		Texture21 = 0x84D5,
		Texture22 = 0x84D6,
		Texture23 = 0x84D7,
		Texture24 = 0x84D8,
		Texture25 = 0x84D9,
		Texture26 = 0x84DA,
		Texture27 = 0x84DB,
		Texture28 = 0x84DC,
		Texture29 = 0x84DD,
		Texture30 = 0x84DE,
		Texture31 = 0x84DF,
	}

	public enum TextureWrapMode : uint
	{
		Repeat = 0x2901,
		ClampToEdge = 0x812F,
		ClampToBorder = 0x812D,
	}

	public enum BufferTargetARB : uint
	{
		ArrayBuffer = 0x8892,
		ElementArrayBuffer = 0x8893,
		PixelPackBuffer = 0x88EB,
		PixelUnpackBuffer = 0x88EC,
		TransformFeedbackBuffer = 0x8C8E,
		CopyReadBuffer = 0x8F36,
		CopyWriteBuffer = 0x8F37,
		UniformBuffer = 0x8A11,
	}

	public enum BufferUsageARB : uint
	{
		StaticDraw = 0x88E4,
		DynamicDraw = 0x88E8,
		StreamDraw = 0x88E0,
		StreamRead = 0x88E1,
		StreamCopy = 0x88E2,
		StaticRead = 0x88E5,
		StaticCopy = 0x88E6,
		DynamicRead = 0x88E9,
		DynamicCopy = 0x88EA,
	}

	public enum VertexBufferObjectParameter : uint
	{
		BufferSize = 0x8764,
		BufferUsage = 0x8765,
		BufferMapped = 0x88BC,
		BufferAccessFlags = 0x911F,
		BufferMapLength = 0x9120,
		BufferMapOffset = 0x9121,
	}

	public enum PathGenMode : uint
	{
		Constant = 0x8576,
	}

	public enum PathColor : uint
	{
		PrimaryColor = 0x8577,
	}

	public enum LightName : uint
	{
		FragmentLight0Sgix = 0x840C,
		FragmentLight1Sgix = 0x840D,
		FragmentLight2Sgix = 0x840E,
		FragmentLight3Sgix = 0x840F,
		FragmentLight4Sgix = 0x8410,
		FragmentLight5Sgix = 0x8411,
		FragmentLight6Sgix = 0x8412,
		FragmentLight7Sgix = 0x8413,
		Light0 = 0x4000,
		Light1 = 0x4001,
		Light2 = 0x4002,
		Light3 = 0x4003,
		Light4 = 0x4004,
		Light5 = 0x4005,
		Light6 = 0x4006,
		Light7 = 0x4007,
	}

	public enum MaterialFace : uint
	{
		Back = 0x0405,
		Front = 0x0404,
		FrontAndBack = 0x0408,
	}

	public enum TextureTarget : uint
	{
		DetailTexture2dSgis = 0x8095,
		ProxyTexture1d = 0x8063,
		ProxyTexture1dArray = 0x8C19,
		ProxyTexture1dArrayExt = 0x8C19,
		ProxyTexture1dExt = 0x8063,
		ProxyTexture2d = 0x8064,
		ProxyTexture2dArray = 0x8C1B,
		ProxyTexture2dArrayExt = 0x8C1B,
		ProxyTexture2dExt = 0x8064,
		ProxyTexture2dMultisample = 0x9101,
		ProxyTexture2dMultisampleArray = 0x9103,
		ProxyTexture3d = 0x8070,
		ProxyTexture3dExt = 0x8070,
		ProxyTexture4dSgis = 0x8135,
		ProxyTextureCubeMap = 0x851B,
		ProxyTextureCubeMapArb = 0x851B,
		ProxyTextureCubeMapExt = 0x851B,
		ProxyTextureCubeMapArray = 0x900B,
		ProxyTextureCubeMapArrayArb = 0x900B,
		ProxyTextureRectangle = 0x84F7,
		ProxyTextureRectangleArb = 0x84F7,
		ProxyTextureRectangleNv = 0x84F7,
		Texture1d = 0x0DE0,
		Texture2d = 0x0DE1,
		Texture3d = 0x806F,
		Texture3dExt = 0x806F,
		Texture3dOes = 0x806F,
		Texture4dSgis = 0x8134,
		TextureRectangle = 0x84F5,
		TextureCubeMap = 0x8513,
		TextureCubeMapPositiveX = 0x8515,
		TextureCubeMapNegativeX = 0x8516,
		TextureCubeMapPositiveY = 0x8517,
		TextureCubeMapNegativeY = 0x8518,
		TextureCubeMapPositiveZ = 0x8519,
		TextureCubeMapNegativeZ = 0x851A,
		TextureCubeMapArray = 0x9009,
		TextureCubeMapArrayArb = 0x9009,
		TextureCubeMapArrayExt = 0x9009,
		TextureCubeMapArrayOes = 0x9009,
		Texture1dArray = 0x8C18,
		Texture2dArray = 0x8C1A,
		Texture2dMultisample = 0x9100,
		Texture2dMultisampleArray = 0x9102,
	}

	public enum LightModelParameter : uint
	{
		LightModelAmbient = 0x0B53,
		LightModelColorControl = 0x81F8,
		LightModelColorControlExt = 0x81F8,
		LightModelLocalViewer = 0x0B51,
		LightModelTwoSide = 0x0B52,
	}

	public enum InternalFormat : uint
	{
		Alpha12 = 0x803D,
		Alpha16 = 0x803E,
		Alpha4 = 0x803B,
		Alpha8 = 0x803C,
		DualAlpha12Sgis = 0x8112,
		DualAlpha16Sgis = 0x8113,
		DualAlpha4Sgis = 0x8110,
		DualAlpha8Sgis = 0x8111,
		DualIntensity12Sgis = 0x811A,
		DualIntensity16Sgis = 0x811B,
		DualIntensity4Sgis = 0x8118,
		DualIntensity8Sgis = 0x8119,
		DualLuminance12Sgis = 0x8116,
		DualLuminance16Sgis = 0x8117,
		DualLuminance4Sgis = 0x8114,
		DualLuminance8Sgis = 0x8115,
		DualLuminanceAlpha4Sgis = 0x811C,
		DualLuminanceAlpha8Sgis = 0x811D,
		Intensity = 0x8049,
		Intensity12 = 0x804C,
		Intensity16 = 0x804D,
		Intensity4 = 0x804A,
		Intensity8 = 0x804B,
		Luminance12 = 0x8041,
		Luminance12Alpha12 = 0x8047,
		Luminance12Alpha4 = 0x8046,
		Luminance16 = 0x8042,
		Luminance16Alpha16 = 0x8048,
		Luminance4 = 0x803F,
		Luminance4Alpha4 = 0x8043,
		Luminance6Alpha2 = 0x8044,
		Luminance8 = 0x8040,
		Luminance8Alpha8 = 0x8045,
		QuadAlpha4Sgis = 0x811E,
		QuadAlpha8Sgis = 0x811F,
		QuadIntensity4Sgis = 0x8122,
		QuadIntensity8Sgis = 0x8123,
		QuadLuminance4Sgis = 0x8120,
		QuadLuminance8Sgis = 0x8121,
		Red = 0x1903,
		RedExt = 0x1903,
		R8 = 0x8229,
		R8Ext = 0x8229,
		R8Snorm = 0x8F94,
		R16 = 0x822A,
		R16Ext = 0x822A,
		R16Snorm = 0x8F98,
		R16SnormExt = 0x8F98,
		R16f = 0x822D,
		R16fExt = 0x822D,
		R32f = 0x822E,
		R32fExt = 0x822E,
		R8i = 0x8231,
		R16i = 0x8233,
		R32i = 0x8235,
		R8ui = 0x8232,
		R16ui = 0x8234,
		R32ui = 0x8236,
		Rg = 0x8227,
		Rg8 = 0x822B,
		Rg8Ext = 0x822B,
		Rg8Snorm = 0x8F95,
		Rg16 = 0x822C,
		Rg16Ext = 0x822C,
		Rg16Snorm = 0x8F99,
		Rg16SnormExt = 0x8F99,
		Rg16f = 0x822F,
		Rg16fExt = 0x822F,
		Rg32f = 0x8230,
		Rg32fExt = 0x8230,
		Rg8i = 0x8237,
		Rg16i = 0x8239,
		Rg32i = 0x823B,
		Rg8ui = 0x8238,
		Rg16ui = 0x823A,
		Rg32ui = 0x823C,
		Rgb = 0x1907,
		Rgb2Ext = 0x804E,
		Rgb4 = 0x804F,
		Rgb4Ext = 0x804F,
		Rgb5 = 0x8050,
		Rgb5Ext = 0x8050,
		Rgb8 = 0x8051,
		Rgb8Ext = 0x8051,
		Rgb8Oes = 0x8051,
		Rgb8Snorm = 0x8F96,
		Rgb10 = 0x8052,
		Rgb10Ext = 0x8052,
		Rgb12 = 0x8053,
		Rgb12Ext = 0x8053,
		Rgb16 = 0x8054,
		Rgb16Ext = 0x8054,
		Rgb16f = 0x881B,
		Rgb16fArb = 0x881B,
		Rgb16fExt = 0x881B,
		Rgb16Snorm = 0x8F9A,
		Rgb16SnormExt = 0x8F9A,
		Rgb8i = 0x8D8F,
		Rgb16i = 0x8D89,
		Rgb32i = 0x8D83,
		Rgb8ui = 0x8D7D,
		Rgb16ui = 0x8D77,
		Rgb32ui = 0x8D71,
		Srgb = 0x8C40,
		SrgbExt = 0x8C40,
		SrgbAlpha = 0x8C42,
		SrgbAlphaExt = 0x8C42,
		Srgb8 = 0x8C41,
		Srgb8Ext = 0x8C41,
		Srgb8Nv = 0x8C41,
		Srgb8Alpha8 = 0x8C43,
		Srgb8Alpha8Ext = 0x8C43,
		R3G3B2 = 0x2A10,
		R11fG11fB10f = 0x8C3A,
		R11fG11fB10fApple = 0x8C3A,
		R11fG11fB10fExt = 0x8C3A,
		Rgb9E5 = 0x8C3D,
		Rgb9E5Apple = 0x8C3D,
		Rgb9E5Ext = 0x8C3D,
		Rgba = 0x1908,
		Rgba4 = 0x8056,
		Rgba4Ext = 0x8056,
		Rgba4Oes = 0x8056,
		Rgb5A1 = 0x8057,
		Rgb5A1Ext = 0x8057,
		Rgb5A1Oes = 0x8057,
		Rgba8 = 0x8058,
		Rgba8Ext = 0x8058,
		Rgba8Oes = 0x8058,
		Rgba8Snorm = 0x8F97,
		Rgb10A2 = 0x8059,
		Rgb10A2Ext = 0x8059,
		Rgba12 = 0x805A,
		Rgba12Ext = 0x805A,
		Rgba16 = 0x805B,
		Rgba16Ext = 0x805B,
		Rgba16f = 0x881A,
		Rgba16fArb = 0x881A,
		Rgba16fExt = 0x881A,
		Rgba32f = 0x8814,
		Rgba32fArb = 0x8814,
		Rgba32fExt = 0x8814,
		Rgba8i = 0x8D8E,
		Rgba16i = 0x8D88,
		Rgba32i = 0x8D82,
		Rgba8ui = 0x8D7C,
		Rgba16ui = 0x8D76,
		Rgba32ui = 0x8D70,
		Rgb10A2ui = 0x906F,
		DepthComponent = 0x1902,
		DepthComponent16 = 0x81A5,
		DepthComponent16Arb = 0x81A5,
		DepthComponent16Oes = 0x81A5,
		DepthComponent16Sgix = 0x81A5,
		DepthComponent24Arb = 0x81A6,
		DepthComponent24Oes = 0x81A6,
		DepthComponent24Sgix = 0x81A6,
		DepthComponent32Arb = 0x81A7,
		DepthComponent32Oes = 0x81A7,
		DepthComponent32Sgix = 0x81A7,
		DepthComponent32f = 0x8CAC,
		DepthComponent32fNv = 0x8DAB,
		DepthStencil = 0x84F9,
		DepthStencilExt = 0x84F9,
		DepthStencilMesa = 0x8750,
		DepthStencilNv = 0x84F9,
		DepthStencilOes = 0x84F9,
		Depth24Stencil8 = 0x88F0,
		Depth24Stencil8Ext = 0x88F0,
		Depth24Stencil8Oes = 0x88F0,
		Depth32fStencil8 = 0x8CAD,
		Depth32fStencil8Nv = 0x8DAC,
		CompressedRed = 0x8225,
		CompressedRg = 0x8226,
		CompressedRgb = 0x84ED,
		CompressedRgba = 0x84EE,
		CompressedSrgb = 0x8C48,
		CompressedSrgbAlpha = 0x8C49,
		CompressedRedRgtc1 = 0x8DBB,
		CompressedRedRgtc1Ext = 0x8DBB,
		CompressedSignedRedRgtc1 = 0x8DBC,
		CompressedSignedRedRgtc1Ext = 0x8DBC,
		CompressedR11Eac = 0x9270,
		CompressedSignedR11Eac = 0x9271,
		CompressedRgRgtc2 = 0x8DBD,
		CompressedSignedRgRgtc2 = 0x8DBE,
		CompressedRgbaBptcUnorm = 0x8E8C,
		CompressedSrgbAlphaBptcUnorm = 0x8E8D,
		CompressedRgbBptcSignedFloat = 0x8E8E,
		CompressedRgbBptcUnsignedFloat = 0x8E8F,
		CompressedRgb8Etc2 = 0x9274,
		CompressedSrgb8Etc2 = 0x9275,
		CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
		CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
		CompressedRgba8Etc2Eac = 0x9278,
		CompressedSrgb8Alpha8Etc2Eac = 0x9279,
		CompressedRg11Eac = 0x9272,
		CompressedSignedRg11Eac = 0x9273,
		CompressedRgbS3tcDxt1Ext = 0x83F0,
		CompressedSrgbS3tcDxt1Ext = 0x8C4C,
		CompressedRgbaS3tcDxt1Ext = 0x83F1,
		CompressedSrgbAlphaS3tcDxt1Ext = 0x8C4D,
		CompressedRgbaS3tcDxt3Ext = 0x83F2,
		CompressedSrgbAlphaS3tcDxt3Ext = 0x8C4E,
		CompressedRgbaS3tcDxt5Ext = 0x83F3,
		CompressedSrgbAlphaS3tcDxt5Ext = 0x8C4F,
	}

	public enum CullFaceMode : uint
	{
		Back = 0x0405,
		Front = 0x0404,
		FrontAndBack = 0x0408,
	}

	public enum DepthFunction : uint
	{
		Always = 0x0207,
		Equal = 0x0202,
		Gequal = 0x0206,
		Greater = 0x0204,
		Lequal = 0x0203,
		Less = 0x0201,
		Never = 0x0200,
		Notequal = 0x0205,
	}

	public enum DrawElementsType : uint
	{
		UnsignedByte = 0x1401,
		UnsignedShort = 0x1403,
		UnsignedInt = 0x1405,
	}

	public enum FogPName : uint
	{
		FogMode = 0x0B65,
		FogDensity = 0x0B62,
		FogStart = 0x0B63,
		FogEnd = 0x0B64,
		FogIndex = 0x0B61,
		FogCoordSrc = 0x8450,
	}

	public enum NormalPointerType : uint
	{
		Byte = 0x1400,
		Double = 0x140A,
		Float = 0x1406,
		Int = 0x1404,
		Short = 0x1402,
	}

	public enum PixelStoreParameter : uint
	{
		PackAlignment = 0x0D05,
		PackImageDepthSgis = 0x8131,
		PackImageHeight = 0x806C,
		PackImageHeightExt = 0x806C,
		PackLsbFirst = 0x0D01,
		PackResampleOml = 0x8984,
		PackResampleSgix = 0x842E,
		PackRowLength = 0x0D02,
		PackSkipImages = 0x806B,
		PackSkipImagesExt = 0x806B,
		PackSkipPixels = 0x0D04,
		PackSkipRows = 0x0D03,
		PackSkipVolumesSgis = 0x8130,
		PackSubsampleRateSgix = 0x85A0,
		PackSwapBytes = 0x0D00,
		PixelTileCacheSizeSgix = 0x8145,
		PixelTileGridDepthSgix = 0x8144,
		PixelTileGridHeightSgix = 0x8143,
		PixelTileGridWidthSgix = 0x8142,
		PixelTileHeightSgix = 0x8141,
		PixelTileWidthSgix = 0x8140,
		UnpackAlignment = 0x0CF5,
		UnpackImageDepthSgis = 0x8133,
		UnpackImageHeight = 0x806E,
		UnpackImageHeightExt = 0x806E,
		UnpackLsbFirst = 0x0CF1,
		UnpackResampleOml = 0x8985,
		UnpackResampleSgix = 0x842F,
		UnpackRowLength = 0x0CF2,
		UnpackRowLengthExt = 0x0CF2,
		UnpackSkipImages = 0x806D,
		UnpackSkipImagesExt = 0x806D,
		UnpackSkipPixels = 0x0CF4,
		UnpackSkipPixelsExt = 0x0CF4,
		UnpackSkipRows = 0x0CF3,
		UnpackSkipRowsExt = 0x0CF3,
		UnpackSkipVolumesSgis = 0x8132,
		UnpackSubsampleRateSgix = 0x85A1,
		UnpackSwapBytes = 0x0CF0,
	}

	public enum StencilFunction : uint
	{
		Always = 0x0207,
		Equal = 0x0202,
		Gequal = 0x0206,
		Greater = 0x0204,
		Lequal = 0x0203,
		Less = 0x0201,
		Never = 0x0200,
		Notequal = 0x0205,
	}

	public enum TexCoordPointerType : uint
	{
		Double = 0x140A,
		Float = 0x1406,
		Int = 0x1404,
		Short = 0x1402,
	}

	public enum VertexPointerType : uint
	{
		Double = 0x140A,
		Float = 0x1406,
		Int = 0x1404,
		Short = 0x1402,
	}

	public enum BlendEquationModeEXT : uint
	{
		FuncAdd = 0x8006,
		FuncSubtract = 0x800A,
		FuncReverseSubtract = 0x800B,
		Min = 0x8007,
		Max = 0x8008,
	}

	public enum VertexAttribEnum : uint
	{
		CurrentVertexAttrib = 0x8626,
		VertexAttribArrayBufferBinding = 0x889F,
	}

	public enum ShaderType : uint
	{
		FragmentShader = 0x8B30,
		VertexShader = 0x8B31,
		ComputeShader = 0x91B9,
		GeometryShader = 0x8DD9,
		TessControlShader = 0x8E88,
		TessEvaluationShader = 0x8E87,
	}

	public enum ShaderParameterName : uint
	{
		ShaderType = 0x8B4F,
		DeleteStatus = 0x8B80,
		CompileStatus = 0x8B81,
		InfoLogLength = 0x8B84,
		ShaderSourceLength = 0x8B88,
	}

	public enum ProgramPropertyARB : uint
	{
		LinkStatus = 0x8B82,
		ValidateStatus = 0x8B83,
		AttachedShaders = 0x8B85,
		ActiveUniforms = 0x8B86,
		ActiveUniformMaxLength = 0x8B87,
		ActiveAttributes = 0x8B89,
		ActiveAttributeMaxLength = 0x8B8A,
		TransformFeedbackVaryingMaxLength = 0x8C76,
		TransformFeedbackBufferMode = 0x8C7F,
		TransformFeedbackVaryings = 0x8C83,
		ActiveUniformBlockMaxNameLength = 0x8A35,
		ActiveUniformBlocks = 0x8A36,
		ProgramBinaryLength = 0x8741,
		ComputeWorkGroupSize = 0x8267,
		ActiveAtomicCounterBuffers = 0x92D9,
		GeometryVerticesOut = 0x8916,
		GeometryInputType = 0x8917,
		GeometryOutputType = 0x8918,
	}

	public enum AttributeType : uint
	{
		FloatVec2 = 0x8B50,
		FloatVec3 = 0x8B51,
		FloatVec4 = 0x8B52,
		IntVec2 = 0x8B53,
		IntVec3 = 0x8B54,
		IntVec4 = 0x8B55,
		Bool = 0x8B56,
		BoolVec2 = 0x8B57,
		BoolVec3 = 0x8B58,
		BoolVec4 = 0x8B59,
		FloatMat2 = 0x8B5A,
		FloatMat3 = 0x8B5B,
		FloatMat4 = 0x8B5C,
		Sampler2d = 0x8B5E,
		SamplerCube = 0x8B60,
		Sampler3d = 0x8B5F,
		Sampler2dShadow = 0x8B62,
		FloatMat2x3 = 0x8B65,
		FloatMat2x4 = 0x8B66,
		FloatMat3x2 = 0x8B67,
		FloatMat3x4 = 0x8B68,
		FloatMat4x2 = 0x8B69,
		FloatMat4x3 = 0x8B6A,
	}

	public enum VertexArrayPName : uint
	{
		VertexAttribArrayEnabled = 0x8622,
		VertexAttribArraySize = 0x8623,
		VertexAttribArrayStride = 0x8624,
		VertexAttribArrayType = 0x8625,
		VertexAttribArrayNormalized = 0x886A,
		VertexAttribArrayInteger = 0x88FD,
		VertexAttribArrayDivisor = 0x88FE,
		VertexAttribRelativeOffset = 0x82D5,
	}

	public enum PrecisionType : uint
	{
		LowFloat = 0x8DF0,
		MediumFloat = 0x8DF1,
		HighFloat = 0x8DF2,
		LowInt = 0x8DF3,
		MediumInt = 0x8DF4,
		HighInt = 0x8DF5,
	}

	public enum FramebufferTarget : uint
	{
		Framebuffer = 0x8D40,
		ReadFramebuffer = 0x8CA8,
		DrawFramebuffer = 0x8CA9,
	}

	public enum RenderbufferTarget : uint
	{
		Renderbuffer = 0x8D41,
	}

	public enum RenderbufferParameterName : uint
	{
		RenderbufferWidth = 0x8D42,
		RenderbufferHeight = 0x8D43,
		RenderbufferInternalFormat = 0x8D44,
		RenderbufferRedSize = 0x8D50,
		RenderbufferGreenSize = 0x8D51,
		RenderbufferBlueSize = 0x8D52,
		RenderbufferAlphaSize = 0x8D53,
		RenderbufferDepthSize = 0x8D54,
		RenderbufferStencilSize = 0x8D55,
		RenderbufferSamples = 0x8CAB,
	}

	public enum FramebufferAttachmentParameterName : uint
	{
		FramebufferAttachmentObjectName = 0x8CD1,
		FramebufferAttachmentTextureLevel = 0x8CD2,
		FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
		FramebufferAttachmentColorEncoding = 0x8210,
		FramebufferAttachmentComponentType = 0x8211,
		FramebufferAttachmentRedSize = 0x8212,
		FramebufferAttachmentGreenSize = 0x8213,
		FramebufferAttachmentBlueSize = 0x8214,
		FramebufferAttachmentAlphaSize = 0x8215,
		FramebufferAttachmentDepthSize = 0x8216,
		FramebufferAttachmentStencilSize = 0x8217,
		FramebufferAttachmentTextureLayer = 0x8CD4,
		FramebufferAttachmentLayered = 0x8DA7,
	}

	public enum FramebufferAttachment : uint
	{
		ColorAttachment0 = 0x8CE0,
		DepthAttachment = 0x8D00,
		DepthStencilAttachment = 0x821A,
		MaxColorAttachments = 0x8CDF,
		ColorAttachment1 = 0x8CE1,
		ColorAttachment2 = 0x8CE2,
		ColorAttachment3 = 0x8CE3,
		ColorAttachment4 = 0x8CE4,
		ColorAttachment5 = 0x8CE5,
		ColorAttachment6 = 0x8CE6,
		ColorAttachment7 = 0x8CE7,
		ColorAttachment8 = 0x8CE8,
		ColorAttachment9 = 0x8CE9,
		ColorAttachment10 = 0x8CEA,
		ColorAttachment11 = 0x8CEB,
		ColorAttachment12 = 0x8CEC,
		ColorAttachment13 = 0x8CED,
		ColorAttachment14 = 0x8CEE,
		ColorAttachment15 = 0x8CEF,
		ColorAttachment16 = 0x8CF0,
		ColorAttachment17 = 0x8CF1,
		ColorAttachment18 = 0x8CF2,
		ColorAttachment19 = 0x8CF3,
		ColorAttachment20 = 0x8CF4,
		ColorAttachment21 = 0x8CF5,
		ColorAttachment22 = 0x8CF6,
		ColorAttachment23 = 0x8CF7,
		ColorAttachment24 = 0x8CF8,
		ColorAttachment25 = 0x8CF9,
		ColorAttachment26 = 0x8CFA,
		ColorAttachment27 = 0x8CFB,
		ColorAttachment28 = 0x8CFC,
		ColorAttachment29 = 0x8CFD,
		ColorAttachment30 = 0x8CFE,
		ColorAttachment31 = 0x8CFF,
	}

	public enum DrawBufferMode : uint
	{
		None = 0,
	}

	public enum FramebufferStatus : uint
	{
		FramebufferComplete = 0x8CD5,
		FramebufferIncompleteAttachment = 0x8CD6,
		FramebufferIncompleteMissingAttachment = 0x8CD7,
		FramebufferUnsupported = 0x8CDD,
		FramebufferUndefined = 0x8219,
		FramebufferIncompleteMultisample = 0x8D56,
		FramebufferIncompleteLayerTargets = 0x8DA8,
	}

	public enum StencilFaceDirection : uint
	{
		Front = 0x0404,
		Back = 0x0405,
		FrontAndBack = 0x0408,
	}

	public enum VertexAttribPointerType : uint
	{
		Byte = 0x1400,
		UnsignedByte = 0x1401,
		Short = 0x1402,
		UnsignedShort = 0x1403,
		Int = 0x1404,
		UnsignedInt = 0x1405,
		Float = 0x1406,
		Double = 0x140A,
		HalfFloat = 0x140B,
		Fixed = 0x140C,
		Int2101010Rev = 0x8D9F,
		UnsignedInt2101010Rev = 0x8368,
		UnsignedInt10f11f11fRev = 0x8C3B,
	}

	public enum PixelCopyType : uint
	{
		Color = 0x1800,
		Depth = 0x1801,
		Stencil = 0x1802,
	}

	public enum QueryParameterName : uint
	{
		CurrentQuery = 0x8865,
	}

	public enum QueryObjectParameterName : uint
	{
		QueryResult = 0x8866,
		QueryResultAvailable = 0x8867,
	}

	public enum QueryTarget : uint
	{
		TransformFeedbackPrimitivesWritten = 0x8C88,
		AnySamplesPassed = 0x8C2F,
		AnySamplesPassedConservative = 0x8D6A,
		PrimitivesGenerated = 0x8C87,
	}

	public enum BufferStorageMask : uint
	{
		MapReadBit = 0x0001,
		MapWriteBit = 0x0002,
	}

	public enum MapBufferAccessMask : uint
	{
		MapInvalidateRangeBit = 0x0004,
		MapInvalidateBufferBit = 0x0008,
		MapFlushExplicitBit = 0x0010,
		MapUnsynchronizedBit = 0x0020,
	}

	public enum UniformPName : uint
	{
		UniformType = 0x8A37,
		UniformSize = 0x8A38,
		UniformNameLength = 0x8A39,
		UniformBlockIndex = 0x8A3A,
		UniformOffset = 0x8A3B,
		UniformArrayStride = 0x8A3C,
		UniformMatrixStride = 0x8A3D,
		UniformIsRowMajor = 0x8A3E,
	}

	public enum UniformBlockPName : uint
	{
		UniformBlockBinding = 0x8A3F,
		UniformBlockDataSize = 0x8A40,
		UniformBlockNameLength = 0x8A41,
		UniformBlockActiveUniforms = 0x8A42,
		UniformBlockActiveUniformIndices = 0x8A43,
		UniformBlockReferencedByVertexShader = 0x8A44,
		UniformBlockReferencedByFragmentShader = 0x8A46,
	}

	public enum SyncParameterName : uint
	{
		ObjectType = 0x9112,
		SyncCondition = 0x9113,
		SyncStatus = 0x9114,
		SyncFlags = 0x9115,
	}

	public enum SyncCondition : uint
	{
		SyncGpuCommandsComplete = 0x9117,
	}

	public enum SyncStatus : uint
	{
		AlreadySignaled = 0x911A,
		TimeoutExpired = 0x911B,
		ConditionSatisfied = 0x911C,
		WaitFailed = 0x911D,
	}

	public enum SyncObjectMask : uint
	{
		SyncFlushCommandsBit = 0x00000001,
	}

	public enum BindTransformFeedbackTarget : uint
	{
		TransformFeedback = 0x8E22,
	}

	public enum TransformFeedbackPName : uint
	{
		TransformFeedbackPaused = 0x8E23,
		TransformFeedbackActive = 0x8E24,
	}

	public enum InternalFormatPName : uint
	{
		NumSampleCounts = 0x9380,
		ImageFormatCompatibilityType = 0x90C7,
		TextureCompressed = 0x86A1,
	}

	public enum ReadBufferMode : uint
	{
		Aux0 = 0x0409,
		Aux1 = 0x040A,
		Aux2 = 0x040B,
		Aux3 = 0x040C,
		Back = 0x0405,
		BackLeft = 0x0402,
		BackRight = 0x0403,
		Front = 0x0404,
		FrontLeft = 0x0400,
		FrontRight = 0x0401,
		Left = 0x0406,
		Right = 0x0407,
	}

	public enum BlitFramebufferFilter : uint
	{
		Nearest = 0x2600,
		Linear = 0x2601,
	}

	public enum TypeEnum : uint
	{
		QueryWait = 0x8E13,
		QueryNoWait = 0x8E14,
		QueryByRegionWait = 0x8E15,
		QueryByRegionNoWait = 0x8E16,
	}

	public enum Buffer : uint
	{
		Color = 0x1800,
		Depth = 0x1801,
		Stencil = 0x1802,
	}

	public enum CopyBufferSubDataTarget : uint
	{
		ArrayBuffer = 0x8892,
		AtomicCounterBuffer = 0x92C0,
		CopyReadBuffer = 0x8F36,
		CopyWriteBuffer = 0x8F37,
		DispatchIndirectBuffer = 0x90EE,
		DrawIndirectBuffer = 0x8F3F,
		ElementArrayBuffer = 0x8893,
		PixelPackBuffer = 0x88EB,
		PixelUnpackBuffer = 0x88EC,
		QueryBuffer = 0x9192,
		ShaderStorageBuffer = 0x90D2,
		TextureBuffer = 0x8C2A,
		TransformFeedbackBuffer = 0x8C8E,
		UniformBuffer = 0x8A11,
	}

	public enum SamplerParameterName : uint
	{
		TextureWrapS = 0x2802,
		TextureWrapT = 0x2803,
		TextureWrapR = 0x8072,
		TextureMinFilter = 0x2801,
		TextureMagFilter = 0x2800,
		TextureBorderColor = 0x1004,
		TextureMinLod = 0x813A,
		TextureMaxLod = 0x813B,
		TextureCompareMode = 0x884C,
		TextureCompareFunc = 0x884D,
	}

	public enum ProgramParameterPName : uint
	{
		ProgramBinaryRetrievableHint = 0x8257,
		ProgramSeparable = 0x8258,
	}

	public enum UseProgramStageMask : uint
	{
		ComputeShaderBit = 0x00000020,
		VertexShaderBit = 0x00000001,
		FragmentShaderBit = 0x00000002,
		AllShaderBits = 0xFFFFFFFF,
		GeometryShaderBit = 0x00000004,
		TessControlShaderBit = 0x00000008,
		TessEvaluationShaderBit = 0x00000010,
	}

	public enum FramebufferParameterName : uint
	{
		FramebufferDefaultWidth = 0x9310,
		FramebufferDefaultHeight = 0x9311,
		FramebufferDefaultSamples = 0x9313,
		FramebufferDefaultFixedSampleLocations = 0x9314,
		FramebufferDefaultLayers = 0x9312,
	}

	public enum ProgramInterface : uint
	{
		Uniform = 0x92E1,
		UniformBlock = 0x92E2,
		ProgramInput = 0x92E3,
		ProgramOutput = 0x92E4,
		BufferVariable = 0x92E5,
		ShaderStorageBlock = 0x92E6,
		TransformFeedbackVarying = 0x92F4,
	}

	public enum ProgramInterfacePName : uint
	{
		ActiveResources = 0x92F5,
		MaxNameLength = 0x92F6,
		MaxNumActiveVariables = 0x92F7,
	}

	public enum PipelineParameterName : uint
	{
		ActiveProgram = 0x8259,
	}

	public enum AtomicCounterBufferPName : uint
	{
		AtomicCounterBufferBinding = 0x92C1,
	}

	public enum MemoryBarrierMask : uint
	{
		VertexAttribArrayBarrierBit = 0x00000001,
		ElementArrayBarrierBit = 0x00000002,
		UniformBarrierBit = 0x00000004,
		TextureFetchBarrierBit = 0x00000008,
		ShaderImageAccessBarrierBit = 0x00000020,
		CommandBarrierBit = 0x00000040,
		PixelBufferBarrierBit = 0x00000080,
		TextureUpdateBarrierBit = 0x00000100,
		BufferUpdateBarrierBit = 0x00000200,
		FramebufferBarrierBit = 0x00000400,
		TransformFeedbackBarrierBit = 0x00000800,
		AtomicCounterBarrierBit = 0x00001000,
		AllBarrierBits = 0xFFFFFFFF,
		ShaderStorageBarrierBit = 0x00002000,
	}

	public enum BufferAccessARB : uint
	{
		ReadOnly = 0x88B8,
		WriteOnly = 0x88B9,
		ReadWrite = 0x88BA,
	}

	public enum DebugSource : uint
	{
		DebugSourceApi = 0x8246,
		DebugSourceWindowSystem = 0x8247,
		DebugSourceShaderCompiler = 0x8248,
		DebugSourceThirdParty = 0x8249,
		DebugSourceApplication = 0x824A,
		DebugSourceOther = 0x824B,
	}

	public enum DebugType : uint
	{
		DebugTypeError = 0x824C,
		DebugTypeDeprecatedBehavior = 0x824D,
		DebugTypeUndefinedBehavior = 0x824E,
		DebugTypePortability = 0x824F,
		DebugTypePerformance = 0x8250,
		DebugTypeOther = 0x8251,
		DebugTypeMarker = 0x8268,
		DebugTypePushGroup = 0x8269,
		DebugTypePopGroup = 0x826A,
	}

	public enum DebugSeverity : uint
	{
		DebugSeverityNotification = 0x826B,
		DebugSeverityHigh = 0x9146,
		DebugSeverityMedium = 0x9147,
		DebugSeverityLow = 0x9148,
	}

	public enum ObjectIdentifier : uint
	{
		Buffer = 0x82E0,
		Shader = 0x82E1,
		Program = 0x82E2,
		Query = 0x82E3,
		ProgramPipeline = 0x82E4,
		Sampler = 0x82E6,
	}

	public enum ContextFlagMask : uint
	{
		ContextFlagDebugBit = 0x00000002,
		ContextFlagRobustAccessBit = 0x00000004,
	}

	public enum VertexProvokingMode : uint
	{
		FirstVertexConvention = 0x8E4D,
		LastVertexConvention = 0x8E4E,
	}

	public enum GraphicsResetStatus : uint
	{
		GuiltyContextReset = 0x8253,
		InnocentContextReset = 0x8254,
		UnknownContextReset = 0x8255,
	}

	public enum PatchParameterName : uint
	{
		PatchVertices = 0x8E72,
	}
}
