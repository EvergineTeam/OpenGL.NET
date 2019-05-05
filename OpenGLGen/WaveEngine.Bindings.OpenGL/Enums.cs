using System;

namespace WaveEngine.Bindings.OpenGL
{
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
		ConstantColor = 0x8001,
		OneMinusConstantColor = 0x8002,
		ConstantAlpha = 0x8003,
		OneMinusConstantAlpha = 0x8004,
		Src1Alpha = 0x8589,
		Src1Color = 0x88F9,
		OneMinusSrc1Color = 0x88FA,
		OneMinusSrc1Alpha = 0x88FB,
	}

	public enum DrawBufferMode : uint
	{
		None = 0,
		FrontLeft = 0x0400,
		FrontRight = 0x0401,
		BackLeft = 0x0402,
		BackRight = 0x0403,
		Left = 0x0406,
		Right = 0x0407,
	}

	public enum ColorMaterialFace : uint
	{
		Front = 0x0404,
		Back = 0x0405,
		FrontAndBack = 0x0408,
	}

	public enum ErrorCode : uint
	{
		NoError = 0,
		InvalidEnum = 0x0500,
		InvalidValue = 0x0501,
		InvalidOperation = 0x0502,
		OutOfMemory = 0x0505,
		InvalidFramebufferOperation = 0x0506,
		StackUnderflow = 0x0504,
		StackOverflow = 0x0503,
	}

	public enum FrontFaceDirection : uint
	{
		Cw = 0x0900,
		Ccw = 0x0901,
	}

	public enum GetPName : uint
	{
		PointSize = 0x0B11,
		PointSizeRange = 0x0B12,
		PointSizeGranularity = 0x0B13,
		LineWidth = 0x0B21,
		LineWidthRange = 0x0B22,
		LineWidthGranularity = 0x0B23,
		PolygonMode = 0x0B40,
		CullFaceMode = 0x0B45,
		FrontFace = 0x0B46,
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
		Viewport = 0x0BA2,
		BlendDst = 0x0BE0,
		BlendSrc = 0x0BE1,
		LogicOpMode = 0x0BF0,
		DrawBuffer = 0x0C01,
		ReadBuffer = 0x0C02,
		ScissorBox = 0x0C10,
		ColorClearValue = 0x0C22,
		ColorWritemask = 0x0C23,
		Doublebuffer = 0x0C32,
		Stereo = 0x0C33,
		LineSmoothHint = 0x0C52,
		PolygonSmoothHint = 0x0C53,
		UnpackSwapBytes = 0x0CF0,
		UnpackLsbFirst = 0x0CF1,
		UnpackRowLength = 0x0CF2,
		UnpackSkipRows = 0x0CF3,
		UnpackSkipPixels = 0x0CF4,
		UnpackAlignment = 0x0CF5,
		PackSwapBytes = 0x0D00,
		PackLsbFirst = 0x0D01,
		PackRowLength = 0x0D02,
		PackSkipRows = 0x0D03,
		PackSkipPixels = 0x0D04,
		PackAlignment = 0x0D05,
		MaxTextureSize = 0x0D33,
		MaxViewportDims = 0x0D3A,
		SubpixelBits = 0x0D50,
		PolygonOffsetUnits = 0x2A00,
		PolygonOffsetFactor = 0x8038,
		TextureBinding1d = 0x8068,
		TextureBinding2d = 0x8069,
		TextureBinding3d = 0x806A,
		Max3dTextureSize = 0x8073,
		MaxElementsVertices = 0x80E8,
		MaxElementsIndices = 0x80E9,
		SmoothPointSizeRange = 0x0B12,
		SmoothPointSizeGranularity = 0x0B13,
		SmoothLineWidthRange = 0x0B22,
		SmoothLineWidthGranularity = 0x0B23,
		AliasedLineWidthRange = 0x846E,
		ActiveTexture = 0x84E0,
		SampleBuffers = 0x80A8,
		Samples = 0x80A9,
		SampleCoverageValue = 0x80AA,
		SampleCoverageInvert = 0x80AB,
		TextureBindingCubeMap = 0x8514,
		MaxCubeMapTextureSize = 0x851C,
		NumCompressedTextureFormats = 0x86A2,
		CompressedTextureFormats = 0x86A3,
		BlendDstRgb = 0x80C8,
		BlendSrcRgb = 0x80C9,
		BlendDstAlpha = 0x80CA,
		BlendSrcAlpha = 0x80CB,
		PointFadeThresholdSize = 0x8128,
		MaxTextureLodBias = 0x84FD,
		BlendColor = 0x8005,
		ArrayBufferBinding = 0x8894,
		ElementArrayBufferBinding = 0x8895,
		BlendEquationRgb = 0x8009,
		StencilBackFunc = 0x8800,
		StencilBackFail = 0x8801,
		StencilBackPassDepthFail = 0x8802,
		StencilBackPassDepthPass = 0x8803,
		MaxDrawBuffers = 0x8824,
		BlendEquationAlpha = 0x883D,
		MaxVertexAttribs = 0x8869,
		MaxTextureImageUnits = 0x8872,
		MaxFragmentUniformComponents = 0x8B49,
		MaxVertexUniformComponents = 0x8B4A,
		MaxVaryingFloats = 0x8B4B,
		MaxVertexTextureImageUnits = 0x8B4C,
		MaxCombinedTextureImageUnits = 0x8B4D,
		CurrentProgram = 0x8B8D,
		StencilBackRef = 0x8CA3,
		StencilBackValueMask = 0x8CA4,
		StencilBackWritemask = 0x8CA5,
		PixelPackBufferBinding = 0x88ED,
		PixelUnpackBufferBinding = 0x88EF,
		MaxClipDistances = 0x0D32,
		MajorVersion = 0x821B,
		MinorVersion = 0x821C,
		NumExtensions = 0x821D,
		ContextFlags = 0x821E,
		MaxArrayTextureLayers = 0x88FF,
		MinProgramTexelOffset = 0x8904,
		MaxProgramTexelOffset = 0x8905,
		MaxVaryingComponents = 0x8B4B,
		TextureBinding1dArray = 0x8C1C,
		TextureBinding2dArray = 0x8C1D,
		TransformFeedbackBufferStart = 0x8C84,
		TransformFeedbackBufferSize = 0x8C85,
		TransformFeedbackBufferBinding = 0x8C8F,
		MaxRenderbufferSize = 0x84E8,
		DrawFramebufferBinding = 0x8CA6,
		RenderbufferBinding = 0x8CA7,
		ReadFramebufferBinding = 0x8CAA,
		VertexArrayBinding = 0x85B5,
		MaxTextureBufferSize = 0x8C2B,
		TextureBindingBuffer = 0x8C2C,
		TextureBindingRectangle = 0x84F6,
		MaxRectangleTextureSize = 0x84F8,
		PrimitiveRestartIndex = 0x8F9E,
		UniformBufferBinding = 0x8A28,
		UniformBufferStart = 0x8A29,
		UniformBufferSize = 0x8A2A,
		MaxVertexUniformBlocks = 0x8A2B,
		MaxGeometryUniformBlocks = 0x8A2C,
		MaxFragmentUniformBlocks = 0x8A2D,
		MaxCombinedUniformBlocks = 0x8A2E,
		MaxUniformBufferBindings = 0x8A2F,
		MaxUniformBlockSize = 0x8A30,
		MaxCombinedVertexUniformComponents = 0x8A31,
		MaxCombinedGeometryUniformComponents = 0x8A32,
		MaxCombinedFragmentUniformComponents = 0x8A33,
		UniformBufferOffsetAlignment = 0x8A34,
		MaxGeometryTextureImageUnits = 0x8C29,
		MaxGeometryUniformComponents = 0x8DDF,
		MaxVertexOutputComponents = 0x9122,
		MaxGeometryInputComponents = 0x9123,
		MaxGeometryOutputComponents = 0x9124,
		MaxFragmentInputComponents = 0x9125,
		ProvokingVertex = 0x8E4F,
		MaxServerWaitTimeout = 0x9111,
		MaxSampleMaskWords = 0x8E59,
		TextureBinding2dMultisample = 0x9104,
		TextureBinding2dMultisampleArray = 0x9105,
		MaxColorTextureSamples = 0x910E,
		MaxDepthTextureSamples = 0x910F,
		MaxIntegerSamples = 0x9110,
		MaxDualSourceDrawBuffers = 0x88FC,
		SamplerBinding = 0x8919,
		Timestamp = 0x8E28,
		ImplementationColorReadType = 0x8B9A,
		ImplementationColorReadFormat = 0x8B9B,
		ShaderCompiler = 0x8DFA,
		NumShaderBinaryFormats = 0x8DF9,
		MaxVertexUniformVectors = 0x8DFB,
		MaxVaryingVectors = 0x8DFC,
		MaxFragmentUniformVectors = 0x8DFD,
		NumProgramBinaryFormats = 0x87FE,
		ProgramBinaryFormats = 0x87FF,
		ProgramPipelineBinding = 0x825A,
		MaxViewports = 0x825B,
		ViewportSubpixelBits = 0x825C,
		ViewportBoundsRange = 0x825D,
		LayerProvokingVertex = 0x825E,
		ViewportIndexProvokingVertex = 0x825F,
		MinMapBufferAlignment = 0x90BC,
		MaxVertexAtomicCounters = 0x92D2,
		MaxTessControlAtomicCounters = 0x92D3,
		MaxTessEvaluationAtomicCounters = 0x92D4,
		MaxGeometryAtomicCounters = 0x92D5,
		MaxFragmentAtomicCounters = 0x92D6,
		MaxCombinedAtomicCounters = 0x92D7,
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
		MaxDebugGroupStackDepth = 0x826C,
		DebugGroupStackDepth = 0x826D,
		MaxLabelLength = 0x82E8,
		MaxUniformLocations = 0x826E,
		MaxFramebufferWidth = 0x9315,
		MaxFramebufferHeight = 0x9316,
		MaxFramebufferLayers = 0x9317,
		MaxFramebufferSamples = 0x9318,
		ShaderStorageBufferBinding = 0x90D3,
		ShaderStorageBufferStart = 0x90D4,
		ShaderStorageBufferSize = 0x90D5,
		MaxVertexShaderStorageBlocks = 0x90D6,
		MaxGeometryShaderStorageBlocks = 0x90D7,
		MaxTessControlShaderStorageBlocks = 0x90D8,
		MaxTessEvaluationShaderStorageBlocks = 0x90D9,
		MaxFragmentShaderStorageBlocks = 0x90DA,
		MaxComputeShaderStorageBlocks = 0x90DB,
		MaxCombinedShaderStorageBlocks = 0x90DC,
		MaxShaderStorageBufferBindings = 0x90DD,
		ShaderStorageBufferOffsetAlignment = 0x90DF,
		TextureBufferOffsetAlignment = 0x919F,
		VertexBindingDivisor = 0x82D6,
		VertexBindingOffset = 0x82D7,
		VertexBindingStride = 0x82D8,
		MaxVertexAttribRelativeOffset = 0x82D9,
		MaxVertexAttribBindings = 0x82DA,
	}

	public enum EnableCap : uint
	{
		LineSmooth = 0x0B20,
		PolygonSmooth = 0x0B41,
		CullFace = 0x0B44,
		DepthTest = 0x0B71,
		StencilTest = 0x0B90,
		Dither = 0x0BD0,
		Blend = 0x0BE2,
		ScissorTest = 0x0C11,
		Texture1d = 0x0DE0,
		Texture2d = 0x0DE1,
		ColorLogicOp = 0x0BF2,
		PolygonOffsetPoint = 0x2A01,
		PolygonOffsetLine = 0x2A02,
		PolygonOffsetFill = 0x8037,
		Multisample = 0x809D,
		SampleAlphaToCoverage = 0x809E,
		SampleAlphaToOne = 0x809F,
		SampleCoverage = 0x80A0,
		RasterizerDiscard = 0x8C89,
		FramebufferSrgb = 0x8DB9,
		PrimitiveRestart = 0x8F9D,
		ProgramPointSize = 0x8642,
		DepthClamp = 0x864F,
		TextureCubeMapSeamless = 0x884F,
		SampleMask = 0x8E51,
		SampleShading = 0x8C36,
		PrimitiveRestartFixedIndex = 0x8D69,
		DebugOutputSynchronous = 0x8242,
		VertexArray = 0x8074,
		DebugOutput = 0x92E0,
	}

	public enum GetTextureParameter : uint
	{
		TextureWidth = 0x1000,
		TextureHeight = 0x1001,
		TextureBorderColor = 0x1004,
		TextureMagFilter = 0x2800,
		TextureMinFilter = 0x2801,
		TextureWrapS = 0x2802,
		TextureWrapT = 0x2803,
	}

	public enum HintMode : uint
	{
		DontCare = 0x1100,
		Fastest = 0x1101,
		Nicest = 0x1102,
	}

	public enum ColorPointerType : uint
	{
		Byte = 0x1400,
		UnsignedByte = 0x1401,
		Short = 0x1402,
		UnsignedShort = 0x1403,
		Int = 0x1404,
		UnsignedInt = 0x1405,
		Float = 0x1406,
		Double = 0x140A,
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

	public enum MatrixMode : uint
	{
		Texture = 0x1702,
	}

	public enum PixelCopyType : uint
	{
		Color = 0x1800,
		Depth = 0x1801,
		Stencil = 0x1802,
	}

	public enum PixelFormat : uint
	{
		StencilIndex = 0x1901,
		DepthComponent = 0x1902,
		Red = 0x1903,
		Green = 0x1904,
		Blue = 0x1905,
		Alpha = 0x1906,
		Rgb = 0x1907,
		Rgba = 0x1908,
		Bgr = 0x80E0,
		Bgra = 0x80E1,
		RedInteger = 0x8D94,
		GreenInteger = 0x8D95,
		BlueInteger = 0x8D96,
		RgbInteger = 0x8D98,
		RgbaInteger = 0x8D99,
		BgrInteger = 0x8D9A,
		BgraInteger = 0x8D9B,
		DepthStencil = 0x84F9,
		Rg = 0x8227,
		RgInteger = 0x8228,
	}

	public enum MeshMode1 : uint
	{
		Point = 0x1B00,
		Line = 0x1B01,
	}

	public enum MeshMode2 : uint
	{
		Fill = 0x1B02,
	}

	public enum LightEnvModeSGIX : uint
	{
		Replace = 0x1E01,
	}

	public enum StringName : uint
	{
		Vendor = 0x1F00,
		Renderer = 0x1F01,
		Version = 0x1F02,
		Extensions = 0x1F03,
		ShadingLanguageVersion = 0x8B8C,
	}

	public enum TextureMagFilter : uint
	{
		Nearest = 0x2600,
	}

	public enum FogMode : uint
	{
		Linear = 0x2601,
	}

	public enum TextureMinFilter : uint
	{
		NearestMipmapNearest = 0x2700,
		LinearMipmapNearest = 0x2701,
		NearestMipmapLinear = 0x2702,
		LinearMipmapLinear = 0x2703,
	}

	public enum TextureWrapMode : uint
	{
		Repeat = 0x2901,
		ClampToEdge = 0x812F,
		ClampToBorder = 0x812D,
	}

	public enum PixelType : uint
	{
		UnsignedByte332 = 0x8032,
		UnsignedShort4444 = 0x8033,
		UnsignedShort5551 = 0x8034,
		UnsignedInt8888 = 0x8035,
		UnsignedInt1010102 = 0x8036,
	}

	public enum ClipPlaneName : uint
	{
		ClipDistance0 = 0x3000,
		ClipDistance1 = 0x3001,
		ClipDistance2 = 0x3002,
		ClipDistance3 = 0x3003,
		ClipDistance4 = 0x3004,
		ClipDistance5 = 0x3005,
		ClipDistance6 = 0x3006,
		ClipDistance7 = 0x3007,
	}

	public enum CullFaceMode : uint
	{
		Back = 0x0405,
		Front = 0x0404,
		FrontAndBack = 0x0408,
	}

	public enum HintTarget : uint
	{
		AllowDrawFrgHintPgi = 0x1A210,
		AllowDrawMemHintPgi = 0x1A211,
		AllowDrawObjHintPgi = 0x1A20E,
		AllowDrawWinHintPgi = 0x1A20F,
		AlwaysFastHintPgi = 0x1A20C,
		AlwaysSoftHintPgi = 0x1A20D,
		BackNormalsHintPgi = 0x1A223,
		BinningControlHintQcom = 0x8FB0,
		ClipFarHintPgi = 0x1A221,
		ClipNearHintPgi = 0x1A220,
		ClipVolumeClippingHintExt = 0x80F0,
		ConserveMemoryHintPgi = 0x1A1FD,
		ConvolutionHintSgix = 0x8316,
		FragmentShaderDerivativeHint = 0x8B8B,
		FragmentShaderDerivativeHintArb = 0x8B8B,
		FragmentShaderDerivativeHintOes = 0x8B8B,
		FullStippleHintPgi = 0x1A219,
		GenerateMipmapHintSgis = 0x8192,
		LineQualityHintSgix = 0x835B,
		LineSmoothHint = 0x0C52,
		MaterialSideHintPgi = 0x1A22C,
		MaxVertexHintPgi = 0x1A22D,
		MultisampleFilterHintNv = 0x8534,
		NativeGraphicsBeginHintPgi = 0x1A203,
		NativeGraphicsEndHintPgi = 0x1A204,
		PackCmykHintExt = 0x800E,
		PhongHintWin = 0x80EB,
		PolygonSmoothHint = 0x0C53,
		PreferDoublebufferHintPgi = 0x1A1F8,
		ProgramBinaryRetrievableHint = 0x8257,
		ReclaimMemoryHintPgi = 0x1A1FE,
		ScalebiasHintSgix = 0x8322,
		StrictDepthfuncHintPgi = 0x1A216,
		StrictLightingHintPgi = 0x1A217,
		StrictScissorHintPgi = 0x1A218,
		TextureCompressionHint = 0x84EF,
		TextureCompressionHintArb = 0x84EF,
		TextureMultiBufferHintSgix = 0x812E,
		TextureStorageHintApple = 0x85BC,
		TransformHintApple = 0x85B1,
		UnpackCmykHintExt = 0x800F,
		VertexArrayStorageHintApple = 0x851F,
		VertexConsistentHintPgi = 0x1A22B,
		VertexDataHintPgi = 0x1A22A,
		VertexPreclipHintSgix = 0x83EF,
		VertexPreclipSgix = 0x83EE,
		WideLineHintPgi = 0x1A222,
	}

	public enum MaterialFace : uint
	{
		Back = 0x0405,
		Front = 0x0404,
		FrontAndBack = 0x0408,
	}

	public enum PolygonMode : uint
	{
		Fill = 0x1B02,
		Line = 0x1B01,
		Point = 0x1B00,
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

	public enum TextureParameterName : uint
	{
		DetailTextureLevelSgis = 0x809A,
		DetailTextureModeSgis = 0x809B,
		DualTextureSelectSgis = 0x8124,
		GenerateMipmapSgis = 0x8191,
		PostTextureFilterBiasSgix = 0x8179,
		PostTextureFilterScaleSgix = 0x817A,
		QuadTextureSelectSgis = 0x8125,
		ShadowAmbientSgix = 0x80BF,
		TextureBorderColor = 0x1004,
		TextureClipmapCenterSgix = 0x8171,
		TextureClipmapDepthSgix = 0x8176,
		TextureClipmapFrameSgix = 0x8172,
		TextureClipmapLodOffsetSgix = 0x8175,
		TextureClipmapOffsetSgix = 0x8173,
		TextureClipmapVirtualDepthSgix = 0x8174,
		TextureCompareSgix = 0x819A,
		TextureLodBiasRSgix = 0x8190,
		TextureLodBiasSSgix = 0x818E,
		TextureLodBiasTSgix = 0x818F,
		TextureMagFilter = 0x2800,
		TextureMaxClampRSgix = 0x836B,
		TextureMaxClampSSgix = 0x8369,
		TextureMaxClampTSgix = 0x836A,
		TextureMinFilter = 0x2801,
		TexturePriorityExt = 0x8066,
		TextureWrapQSgis = 0x8137,
		TextureWrapR = 0x8072,
		TextureWrapRExt = 0x8072,
		TextureWrapROes = 0x8072,
		TextureWrapS = 0x2802,
		TextureWrapT = 0x2803,
		TextureBaseLevel = 0x813C,
		TextureCompareMode = 0x884C,
		TextureCompareFunc = 0x884D,
		TextureLodBias = 0x8501,
		TextureMinLod = 0x813A,
		TextureMaxLod = 0x813B,
		TextureMaxLevel = 0x813D,
		TextureSwizzleR = 0x8E42,
		TextureSwizzleG = 0x8E43,
		TextureSwizzleB = 0x8E44,
		TextureSwizzleA = 0x8E45,
		TextureSwizzleRgba = 0x8E46,
		TextureTilingExt = 0x9580,
		DepthStencilTextureMode = 0x90EA,
		DetailTextureFuncPointsSgis = 0x809C,
		SharpenTextureFuncPointsSgis = 0x80B0,
		Texture4dsizeSgis = 0x8136,
		TextureAlphaSize = 0x805F,
		TextureBaseLevelSgis = 0x813C,
		TextureBlueSize = 0x805E,
		TextureBorderColorNv = 0x1004,
		TextureCompareOperatorSgix = 0x819B,
		TextureDepthExt = 0x8071,
		TextureFilter4SizeSgis = 0x8147,
		TextureGequalRSgix = 0x819D,
		TextureGreenSize = 0x805D,
		TextureHeight = 0x1001,
		TextureInternalFormat = 0x1003,
		TextureLequalRSgix = 0x819C,
		TextureMaxLevelSgis = 0x813D,
		TextureMaxLodSgis = 0x813B,
		TextureMinLodSgis = 0x813A,
		TextureRedSize = 0x805C,
		TextureWidth = 0x1000,
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

	public enum ReadBufferMode : uint
	{
		Back = 0x0405,
		BackLeft = 0x0402,
		BackRight = 0x0403,
		Front = 0x0404,
		FrontLeft = 0x0400,
		FrontRight = 0x0401,
		Left = 0x0406,
		Right = 0x0407,
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
	}

	public enum LightModelParameter : uint
	{
		LightModelColorControlExt = 0x81F8,
	}

	public enum MapTarget : uint
	{
		GeometryDeformationSgix = 0x8194,
		TextureDeformationSgix = 0x8195,
	}

	public enum PixelTransferParameter : uint
	{
		PostColorMatrixAlphaBias = 0x80BB,
		PostColorMatrixAlphaBiasSgi = 0x80BB,
		PostColorMatrixAlphaScale = 0x80B7,
		PostColorMatrixAlphaScaleSgi = 0x80B7,
		PostColorMatrixBlueBias = 0x80BA,
		PostColorMatrixBlueBiasSgi = 0x80BA,
		PostColorMatrixBlueScale = 0x80B6,
		PostColorMatrixBlueScaleSgi = 0x80B6,
		PostColorMatrixGreenBias = 0x80B9,
		PostColorMatrixGreenBiasSgi = 0x80B9,
		PostColorMatrixGreenScale = 0x80B5,
		PostColorMatrixGreenScaleSgi = 0x80B5,
		PostColorMatrixRedBias = 0x80B8,
		PostColorMatrixRedBiasSgi = 0x80B8,
		PostColorMatrixRedScale = 0x80B4,
		PostColorMatrixRedScaleSgi = 0x80B4,
		PostConvolutionAlphaBias = 0x8023,
		PostConvolutionAlphaBiasExt = 0x8023,
		PostConvolutionAlphaScale = 0x801F,
		PostConvolutionAlphaScaleExt = 0x801F,
		PostConvolutionBlueBias = 0x8022,
		PostConvolutionBlueBiasExt = 0x8022,
		PostConvolutionBlueScale = 0x801E,
		PostConvolutionBlueScaleExt = 0x801E,
		PostConvolutionGreenBias = 0x8021,
		PostConvolutionGreenBiasExt = 0x8021,
		PostConvolutionGreenScale = 0x801D,
		PostConvolutionGreenScaleExt = 0x801D,
		PostConvolutionRedBias = 0x8020,
		PostConvolutionRedBiasExt = 0x8020,
		PostConvolutionRedScale = 0x801C,
		PostConvolutionRedScaleExt = 0x801C,
	}

	public enum InternalFormat : uint
	{
		R3G3B2 = 0x2A10,
		Rgb4 = 0x804F,
		Rgb5 = 0x8050,
		Rgb8 = 0x8051,
		Rgb10 = 0x8052,
		Rgb12 = 0x8053,
		Rgb16 = 0x8054,
		Rgba4 = 0x8056,
		Rgb5A1 = 0x8057,
		Rgba8 = 0x8058,
		Rgb10A2 = 0x8059,
		Rgba12 = 0x805A,
		Rgba16 = 0x805B,
		CompressedRgb = 0x84ED,
		CompressedRgba = 0x84EE,
		DepthComponent16 = 0x81A5,
		Srgb = 0x8C40,
		Srgb8 = 0x8C41,
		SrgbAlpha = 0x8C42,
		Srgb8Alpha8 = 0x8C43,
		CompressedSrgb = 0x8C48,
		CompressedSrgbAlpha = 0x8C49,
		CompressedRed = 0x8225,
		CompressedRg = 0x8226,
		Rgba32f = 0x8814,
		Rgba16f = 0x881A,
		Rgb16f = 0x881B,
		R11fG11fB10f = 0x8C3A,
		Rgb9E5 = 0x8C3D,
		Rgba32ui = 0x8D70,
		Rgb32ui = 0x8D71,
		Rgba16ui = 0x8D76,
		Rgb16ui = 0x8D77,
		Rgba8ui = 0x8D7C,
		Rgb8ui = 0x8D7D,
		Rgba32i = 0x8D82,
		Rgb32i = 0x8D83,
		Rgba16i = 0x8D88,
		Rgb16i = 0x8D89,
		Rgba8i = 0x8D8E,
		Rgb8i = 0x8D8F,
		DepthComponent32f = 0x8CAC,
		Depth32fStencil8 = 0x8CAD,
		Depth24Stencil8 = 0x88F0,
		CompressedRedRgtc1 = 0x8DBB,
		CompressedSignedRedRgtc1 = 0x8DBC,
		CompressedRgRgtc2 = 0x8DBD,
		CompressedSignedRgRgtc2 = 0x8DBE,
		R8 = 0x8229,
		R16 = 0x822A,
		Rg8 = 0x822B,
		Rg16 = 0x822C,
		R16f = 0x822D,
		R32f = 0x822E,
		Rg16f = 0x822F,
		Rg32f = 0x8230,
		R8i = 0x8231,
		R8ui = 0x8232,
		R16i = 0x8233,
		R16ui = 0x8234,
		R32i = 0x8235,
		R32ui = 0x8236,
		Rg8i = 0x8237,
		Rg8ui = 0x8238,
		Rg16i = 0x8239,
		Rg16ui = 0x823A,
		Rg32i = 0x823B,
		Rg32ui = 0x823C,
		R8Snorm = 0x8F94,
		Rg8Snorm = 0x8F95,
		Rgb8Snorm = 0x8F96,
		Rgba8Snorm = 0x8F97,
		R16Snorm = 0x8F98,
		Rg16Snorm = 0x8F99,
		Rgb16Snorm = 0x8F9A,
		Rgb10A2ui = 0x906F,
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
		CompressedR11Eac = 0x9270,
		CompressedSignedR11Eac = 0x9271,
		CompressedRg11Eac = 0x9272,
		CompressedSignedRg11Eac = 0x9273,
	}

	public enum Extensions : uint
	{
		Rgba2 = 0x8055,
		TextureDepth = 0x8071,
		UnsignedByte233Rev = 0x8362,
		UnsignedShort565 = 0x8363,
		UnsignedShort565Rev = 0x8364,
		UnsignedShort4444Rev = 0x8365,
		UnsignedShort1555Rev = 0x8366,
		UnsignedInt8888Rev = 0x8367,
		TextureCompressedImageSize = 0x86A0,
		DepthComponent24 = 0x81A6,
		DepthComponent32 = 0x81A7,
		MirroredRepeat = 0x8370,
		TextureDepthSize = 0x884A,
		BlendEquation = 0x8009,
		BufferMapPointer = 0x88BD,
		VertexProgramPointSize = 0x8642,
		VertexAttribArrayPointer = 0x8645,
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
		PointSpriteCoordOrigin = 0x8CA0,
		CompareRefToTexture = 0x884E,
		Rgb32f = 0x8815,
		ClampReadColor = 0x891C,
		FixedOnly = 0x891D,
		UnsignedInt5999Rev = 0x8C3E,
		TextureSharedSize = 0x8C3F,
		MaxTransformFeedbackSeparateComponents = 0x8C80,
		MaxTransformFeedbackInterleavedComponents = 0x8C8A,
		MaxTransformFeedbackSeparateAttribs = 0x8C8B,
		InterleavedAttribs = 0x8C8C,
		SeparateAttribs = 0x8C8D,
		Sampler1dArray = 0x8DC0,
		Sampler2dArray = 0x8DC1,
		Sampler1dArrayShadow = 0x8DC3,
		Sampler2dArrayShadow = 0x8DC4,
		SamplerCubeShadow = 0x8DC5,
		UnsignedIntVec2 = 0x8DC6,
		UnsignedIntVec3 = 0x8DC7,
		UnsignedIntVec4 = 0x8DC8,
		IntSampler1d = 0x8DC9,
		IntSampler2d = 0x8DCA,
		IntSampler3d = 0x8DCB,
		IntSamplerCube = 0x8DCC,
		IntSampler1dArray = 0x8DCE,
		IntSampler2dArray = 0x8DCF,
		UnsignedIntSampler1d = 0x8DD1,
		UnsignedIntSampler2d = 0x8DD2,
		UnsignedIntSampler3d = 0x8DD3,
		UnsignedIntSamplerCube = 0x8DD4,
		UnsignedIntSampler1dArray = 0x8DD6,
		UnsignedIntSampler2dArray = 0x8DD7,
		Float32UnsignedInt248Rev = 0x8DAD,
		FramebufferDefault = 0x8218,
		UnsignedInt248 = 0x84FA,
		TextureStencilSize = 0x88F1,
		TextureRedType = 0x8C10,
		TextureGreenType = 0x8C11,
		TextureBlueType = 0x8C12,
		TextureAlphaType = 0x8C13,
		TextureDepthType = 0x8C16,
		UnsignedNormalized = 0x8C17,
		FramebufferBinding = 0x8CA6,
		FramebufferAttachmentObjectType = 0x8CD0,
		StencilAttachment = 0x8D20,
		StencilIndex1 = 0x8D46,
		StencilIndex4 = 0x8D47,
		StencilIndex8 = 0x8D48,
		StencilIndex16 = 0x8D49,
		MaxSamples = 0x8D57,
		SamplerBuffer = 0x8DC2,
		IntSampler2dRect = 0x8DCD,
		IntSamplerBuffer = 0x8DD0,
		UnsignedIntSampler2dRect = 0x8DD5,
		UnsignedIntSamplerBuffer = 0x8DD8,
		TextureBufferDataStoreBinding = 0x8C2D,
		Rgba16Snorm = 0x8F9B,
		SignedNormalized = 0x8F9C,
		InvalidIndex = 0xFFFFFFFF,
		MaxGeometryOutputVertices = 0x8DE0,
		MaxGeometryTotalOutputComponents = 0x8DE1,
		ContextProfileMask = 0x9126,
		QuadsFollowProvokingVertexConvention = 0x8E4C,
		SyncFence = 0x9116,
		Unsignaled = 0x9118,
		Signaled = 0x9119,
		SamplePosition = 0x8E50,
		SampleMaskValue = 0x8E52,
		TextureSamples = 0x9106,
		TextureFixedSampleLocations = 0x9107,
		Sampler2dMultisample = 0x9108,
		IntSampler2dMultisample = 0x9109,
		UnsignedIntSampler2dMultisample = 0x910A,
		Sampler2dMultisampleArray = 0x910B,
		IntSampler2dMultisampleArray = 0x910C,
		UnsignedIntSampler2dMultisampleArray = 0x910D,
		MinSampleShadingValue = 0x8C37,
		MinProgramTextureGatherOffset = 0x8E5E,
		MaxProgramTextureGatherOffset = 0x8E5F,
		TextureBindingCubeMapArray = 0x900A,
		SamplerCubeMapArray = 0x900C,
		SamplerCubeMapArrayShadow = 0x900D,
		IntSamplerCubeMapArray = 0x900E,
		UnsignedIntSamplerCubeMapArray = 0x900F,
		DrawIndirectBufferBinding = 0x8F43,
		GeometryShaderInvocations = 0x887F,
		MaxGeometryShaderInvocations = 0x8E5A,
		MinFragmentInterpolationOffset = 0x8E5B,
		MaxFragmentInterpolationOffset = 0x8E5C,
		FragmentInterpolationOffsetBits = 0x8E5D,
		MaxVertexStreams = 0x8E71,
		DoubleVec2 = 0x8FFC,
		DoubleVec3 = 0x8FFD,
		DoubleVec4 = 0x8FFE,
		DoubleMat2 = 0x8F46,
		DoubleMat3 = 0x8F47,
		DoubleMat4 = 0x8F48,
		DoubleMat2x3 = 0x8F49,
		DoubleMat2x4 = 0x8F4A,
		DoubleMat3x2 = 0x8F4B,
		DoubleMat3x4 = 0x8F4C,
		DoubleMat4x2 = 0x8F4D,
		DoubleMat4x3 = 0x8F4E,
		MaxSubroutines = 0x8DE7,
		MaxSubroutineUniformLocations = 0x8DE8,
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
		TransformFeedbackBufferPaused = 0x8E23,
		TransformFeedbackBufferActive = 0x8E24,
		TransformFeedbackBinding = 0x8E25,
		MaxTransformFeedbackBuffers = 0x8E70,
		ShaderBinaryFormats = 0x8DF8,
		Rgb565 = 0x8D62,
		UndefinedVertex = 0x8260,
		CopyReadBufferBinding = 0x8F36,
		CopyWriteBufferBinding = 0x8F37,
		UnpackCompressedBlockWidth = 0x9127,
		UnpackCompressedBlockHeight = 0x9128,
		UnpackCompressedBlockDepth = 0x9129,
		UnpackCompressedBlockSize = 0x912A,
		PackCompressedBlockWidth = 0x912B,
		PackCompressedBlockHeight = 0x912C,
		PackCompressedBlockDepth = 0x912D,
		PackCompressedBlockSize = 0x912E,
		AtomicCounterBufferStart = 0x92C2,
		AtomicCounterBufferSize = 0x92C3,
		MaxVertexAtomicCounterBuffers = 0x92CC,
		MaxTessControlAtomicCounterBuffers = 0x92CD,
		MaxTessEvaluationAtomicCounterBuffers = 0x92CE,
		MaxGeometryAtomicCounterBuffers = 0x92CF,
		MaxFragmentAtomicCounterBuffers = 0x92D0,
		MaxCombinedAtomicCounterBuffers = 0x92D1,
		MaxAtomicCounterBufferSize = 0x92D8,
		MaxAtomicCounterBufferBindings = 0x92DC,
		UnsignedIntAtomicCounter = 0x92DB,
		MaxImageUnits = 0x8F38,
		MaxCombinedImageUnitsAndFragmentOutputs = 0x8F39,
		ImageBindingName = 0x8F3A,
		ImageBindingLevel = 0x8F3B,
		ImageBindingLayered = 0x8F3C,
		ImageBindingLayer = 0x8F3D,
		ImageBindingAccess = 0x8F3E,
		Image1d = 0x904C,
		Image2d = 0x904D,
		Image3d = 0x904E,
		Image2dRect = 0x904F,
		ImageCube = 0x9050,
		ImageBuffer = 0x9051,
		Image1dArray = 0x9052,
		Image2dArray = 0x9053,
		ImageCubeMapArray = 0x9054,
		Image2dMultisample = 0x9055,
		Image2dMultisampleArray = 0x9056,
		IntImage1d = 0x9057,
		IntImage2d = 0x9058,
		IntImage3d = 0x9059,
		IntImage2dRect = 0x905A,
		IntImageCube = 0x905B,
		IntImageBuffer = 0x905C,
		IntImage1dArray = 0x905D,
		IntImage2dArray = 0x905E,
		IntImageCubeMapArray = 0x905F,
		IntImage2dMultisample = 0x9060,
		IntImage2dMultisampleArray = 0x9061,
		UnsignedIntImage1d = 0x9062,
		UnsignedIntImage2d = 0x9063,
		UnsignedIntImage3d = 0x9064,
		UnsignedIntImage2dRect = 0x9065,
		UnsignedIntImageCube = 0x9066,
		UnsignedIntImageBuffer = 0x9067,
		UnsignedIntImage1dArray = 0x9068,
		UnsignedIntImage2dArray = 0x9069,
		UnsignedIntImageCubeMapArray = 0x906A,
		UnsignedIntImage2dMultisample = 0x906B,
		UnsignedIntImage2dMultisampleArray = 0x906C,
		MaxImageSamples = 0x906D,
		ImageBindingFormat = 0x906E,
		ImageFormatCompatibilityBySize = 0x90C8,
		ImageFormatCompatibilityByClass = 0x90C9,
		MaxVertexImageUniforms = 0x90CA,
		MaxTessControlImageUniforms = 0x90CB,
		MaxTessEvaluationImageUniforms = 0x90CC,
		MaxGeometryImageUniforms = 0x90CD,
		MaxFragmentImageUniforms = 0x90CE,
		MaxCombinedImageUniforms = 0x90CF,
		TextureImmutableFormat = 0x912F,
		NumShadingLanguageVersions = 0x82E9,
		MaxComputeImageUniforms = 0x91BD,
		MaxComputeSharedMemorySize = 0x8262,
		DebugNextLoggedMessageLength = 0x8243,
		MaxDebugMessageLength = 0x9143,
		MaxDebugLoggedMessages = 0x9144,
		DebugLoggedMessages = 0x9145,
		MaxCombinedDimensions = 0x8282,
		DepthComponents = 0x8284,
		StencilComponents = 0x8285,
		ManualGenerateMipmap = 0x8294,
		FullSupport = 0x82B7,
		CaveatSupport = 0x82B8,
		ImageClass4X32 = 0x82B9,
		ImageClass2X32 = 0x82BA,
		ImageClass1X32 = 0x82BB,
		ImageClass4X16 = 0x82BC,
		ImageClass2X16 = 0x82BD,
		ImageClass1X16 = 0x82BE,
		ImageClass4X8 = 0x82BF,
		ImageClass2X8 = 0x82C0,
		ImageClass1X8 = 0x82C1,
		ImageClass111110 = 0x82C2,
		ImageClass1010102 = 0x82C3,
		ViewClass128Bits = 0x82C4,
		ViewClass96Bits = 0x82C5,
		ViewClass64Bits = 0x82C6,
		ViewClass48Bits = 0x82C7,
		ViewClass32Bits = 0x82C8,
		ViewClass24Bits = 0x82C9,
		ViewClass16Bits = 0x82CA,
		ViewClass8Bits = 0x82CB,
		ViewClassS3tcDxt1Rgb = 0x82CC,
		ViewClassS3tcDxt1Rgba = 0x82CD,
		ViewClassS3tcDxt3Rgba = 0x82CE,
		ViewClassS3tcDxt5Rgba = 0x82CF,
		ViewClassRgtc1Red = 0x82D0,
		ViewClassRgtc2Rg = 0x82D1,
		ViewClassBptcUnorm = 0x82D2,
		ViewClassBptcFloat = 0x82D3,
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
		ReferencedByTessControlShader = 0x9307,
		ReferencedByTessEvaluationShader = 0x9308,
		ReferencedByGeometryShader = 0x9309,
		ReferencedByFragmentShader = 0x930A,
		ReferencedByComputeShader = 0x930B,
		TopLevelArraySize = 0x930C,
		TopLevelArrayStride = 0x930D,
		Location = 0x930E,
		LocationIndex = 0x930F,
		IsPerPatch = 0x92E7,
		MaxShaderStorageBlockSize = 0x90DE,
		MaxCombinedShaderOutputResources = 0x8F39,
		TextureBufferOffset = 0x919D,
		TextureBufferSize = 0x919E,
		TextureViewMinLevel = 0x82DB,
		TextureViewNumLevels = 0x82DC,
		TextureViewMinLayer = 0x82DD,
		TextureViewNumLayers = 0x82DE,
		TextureImmutableLevels = 0x82DF,
		VertexAttribBinding = 0x82D4,
		VertexBindingBuffer = 0x8F4F,
		DisplayList = 0x82E7,
		MaxVertexAttribStride = 0x82E5,
		PrimitiveRestartForPatchesSupported = 0x8221,
		TextureBufferBinding = 0x8C2A,
		LocationComponent = 0x934A,
		TransformFeedbackBufferIndex = 0x934B,
		TransformFeedbackBufferStride = 0x934C,
		QueryBufferBinding = 0x9193,
		MirrorClampToEdge = 0x8743,
		ContextLost = 0x0507,
		ClipOrigin = 0x935C,
		ClipDepthMode = 0x935D,
		QueryWaitInverted = 0x8E17,
		QueryNoWaitInverted = 0x8E18,
		QueryByRegionWaitInverted = 0x8E19,
		QueryByRegionNoWaitInverted = 0x8E1A,
		MaxCullDistances = 0x82F9,
		MaxCombinedClipAndCullDistances = 0x82FA,
		TextureTarget = 0x1006,
		ResetNotificationStrategy = 0x8256,
		LoseContextOnReset = 0x8252,
		NoResetNotification = 0x8261,
		ContextReleaseBehavior = 0x82FB,
		ContextReleaseBehaviorFlush = 0x82FC,
		ShaderBinaryFormatSpirV = 0x9551,
		SpirVBinary = 0x9552,
		ParameterBufferBinding = 0x80EF,
		VerticesSubmitted = 0x82EE,
		PrimitivesSubmitted = 0x82EF,
		VertexShaderInvocations = 0x82F0,
		TessControlShaderPatches = 0x82F1,
		TessEvaluationShaderInvocations = 0x82F2,
		GeometryShaderPrimitivesEmitted = 0x82F3,
		FragmentShaderInvocations = 0x82F4,
		ComputeShaderInvocations = 0x82F5,
		ClippingInputPrimitives = 0x82F6,
		ClippingOutputPrimitives = 0x82F7,
		PolygonOffsetClamp = 0x8E1B,
		SpirVExtensions = 0x9553,
		NumSpirVExtensions = 0x9554,
		TextureMaxAnisotropy = 0x84FE,
		MaxTextureMaxAnisotropy = 0x84FF,
		TransformFeedbackOverflow = 0x82EC,
		TransformFeedbackStreamOverflow = 0x82ED,
	}

	public enum DrawElementsType : uint
	{
		UnsignedByte = 0x1401,
		UnsignedShort = 0x1403,
		UnsignedInt = 0x1405,
	}

	public enum IndexPointerType : uint
	{
		Double = 0x140A,
		Float = 0x1406,
		Int = 0x1404,
		Short = 0x1402,
	}

	public enum NormalPointerType : uint
	{
		Byte = 0x1400,
		Double = 0x140A,
		Float = 0x1406,
		Int = 0x1404,
		Short = 0x1402,
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

	public enum VertexAttribType : uint
	{
		UnsignedInt2101010Rev = 0x8368,
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

	public enum InternalFormatPName : uint
	{
		TextureCompressed = 0x86A1,
		NumSampleCounts = 0x9380,
		ImageFormatCompatibilityType = 0x90C7,
		InternalformatSupported = 0x826F,
		InternalformatPreferred = 0x8270,
		InternalformatRedSize = 0x8271,
		InternalformatGreenSize = 0x8272,
		InternalformatBlueSize = 0x8273,
		InternalformatAlphaSize = 0x8274,
		InternalformatDepthSize = 0x8275,
		InternalformatStencilSize = 0x8276,
		InternalformatSharedSize = 0x8277,
		InternalformatRedType = 0x8278,
		InternalformatGreenType = 0x8279,
		InternalformatBlueType = 0x827A,
		InternalformatAlphaType = 0x827B,
		InternalformatDepthType = 0x827C,
		InternalformatStencilType = 0x827D,
		MaxWidth = 0x827E,
		MaxHeight = 0x827F,
		MaxDepth = 0x8280,
		MaxLayers = 0x8281,
		ColorComponents = 0x8283,
		ColorRenderable = 0x8286,
		DepthRenderable = 0x8287,
		StencilRenderable = 0x8288,
		FramebufferRenderable = 0x8289,
		FramebufferRenderableLayered = 0x828A,
		FramebufferBlend = 0x828B,
		ReadPixels = 0x828C,
		ReadPixelsFormat = 0x828D,
		ReadPixelsType = 0x828E,
		TextureImageFormat = 0x828F,
		TextureImageType = 0x8290,
		GetTextureImageFormat = 0x8291,
		GetTextureImageType = 0x8292,
		Mipmap = 0x8293,
		AutoGenerateMipmap = 0x8295,
		ColorEncoding = 0x8296,
		SrgbRead = 0x8297,
		SrgbWrite = 0x8298,
		Filter = 0x829A,
		VertexTexture = 0x829B,
		TessControlTexture = 0x829C,
		TessEvaluationTexture = 0x829D,
		GeometryTexture = 0x829E,
		FragmentTexture = 0x829F,
		ComputeTexture = 0x82A0,
		TextureShadow = 0x82A1,
		TextureGather = 0x82A2,
		TextureGatherShadow = 0x82A3,
		ShaderImageLoad = 0x82A4,
		ShaderImageStore = 0x82A5,
		ShaderImageAtomic = 0x82A6,
		ImageTexelSize = 0x82A7,
		ImageCompatibilityClass = 0x82A8,
		ImagePixelFormat = 0x82A9,
		ImagePixelType = 0x82AA,
		SimultaneousTextureAndDepthTest = 0x82AC,
		SimultaneousTextureAndStencilTest = 0x82AD,
		SimultaneousTextureAndDepthWrite = 0x82AE,
		SimultaneousTextureAndStencilWrite = 0x82AF,
		TextureCompressedBlockWidth = 0x82B1,
		TextureCompressedBlockHeight = 0x82B2,
		TextureCompressedBlockSize = 0x82B3,
		ClearBuffer = 0x82B4,
		TextureView = 0x82B5,
		ViewCompatibilityClass = 0x82B6,
		ClearTexture = 0x9365,
	}

	public enum BlendEquationModeEXT : uint
	{
		FuncAdd = 0x8006,
		FuncReverseSubtract = 0x800B,
		FuncSubtract = 0x800A,
		Min = 0x8007,
		Max = 0x8008,
	}

	public enum FogPointerTypeEXT : uint
	{
		Float = 0x1406,
		Double = 0x140A,
	}

	public enum VertexBufferObjectParameter : uint
	{
		BufferSize = 0x8764,
		BufferUsage = 0x8765,
		BufferAccess = 0x88BB,
		BufferMapped = 0x88BC,
		BufferAccessFlags = 0x911F,
		BufferMapLength = 0x9120,
		BufferMapOffset = 0x9121,
		BufferImmutableStorage = 0x821F,
		BufferStorageFlags = 0x8220,
	}

	public enum QueryParameterName : uint
	{
		QueryCounterBits = 0x8864,
		CurrentQuery = 0x8865,
	}

	public enum QueryObjectParameterName : uint
	{
		QueryResult = 0x8866,
		QueryResultAvailable = 0x8867,
		QueryResultNoWait = 0x9194,
		QueryTarget = 0x82EA,
	}

	public enum BufferTargetARB : uint
	{
		ArrayBuffer = 0x8892,
		ElementArrayBuffer = 0x8893,
		PixelPackBuffer = 0x88EB,
		PixelUnpackBuffer = 0x88EC,
		TransformFeedbackBuffer = 0x8C8E,
		TextureBuffer = 0x8C2A,
		CopyReadBuffer = 0x8F36,
		CopyWriteBuffer = 0x8F37,
		UniformBuffer = 0x8A11,
		ParameterBuffer = 0x80EE,
	}

	public enum VertexAttribEnum : uint
	{
		VertexAttribArrayBufferBinding = 0x889F,
		CurrentVertexAttrib = 0x8626,
	}

	public enum BufferAccessARB : uint
	{
		ReadOnly = 0x88B8,
		WriteOnly = 0x88B9,
		ReadWrite = 0x88BA,
	}

	public enum BufferUsageARB : uint
	{
		StreamDraw = 0x88E0,
		StreamRead = 0x88E1,
		StreamCopy = 0x88E2,
		StaticDraw = 0x88E4,
		StaticRead = 0x88E5,
		StaticCopy = 0x88E6,
		DynamicDraw = 0x88E8,
		DynamicRead = 0x88E9,
		DynamicCopy = 0x88EA,
	}

	public enum QueryTarget : uint
	{
		SamplesPassed = 0x8914,
		PrimitivesGenerated = 0x8C87,
		TransformFeedbackPrimitivesWritten = 0x8C88,
		AnySamplesPassed = 0x8C2F,
		TimeElapsed = 0x88BF,
		AnySamplesPassedConservative = 0x8D6A,
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
		VertexAttribArrayLong = 0x874E,
		VertexAttribRelativeOffset = 0x82D5,
	}

	public enum ShaderType : uint
	{
		FragmentShader = 0x8B30,
		VertexShader = 0x8B31,
		GeometryShader = 0x8DD9,
		TessEvaluationShader = 0x8E87,
		TessControlShader = 0x8E88,
		ComputeShader = 0x91B9,
	}

	public enum ShaderParameterName : uint
	{
		ShaderType = 0x8B4F,
		DeleteStatus = 0x8B80,
		CompileStatus = 0x8B81,
		InfoLogLength = 0x8B84,
		ShaderSourceLength = 0x8B88,
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
		Sampler1d = 0x8B5D,
		Sampler2d = 0x8B5E,
		Sampler3d = 0x8B5F,
		SamplerCube = 0x8B60,
		Sampler1dShadow = 0x8B61,
		Sampler2dShadow = 0x8B62,
		FloatMat2x3 = 0x8B65,
		FloatMat2x4 = 0x8B66,
		FloatMat3x2 = 0x8B67,
		FloatMat3x4 = 0x8B68,
		FloatMat4x2 = 0x8B69,
		FloatMat4x3 = 0x8B6A,
		Sampler2dRect = 0x8B63,
		Sampler2dRectShadow = 0x8B64,
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
		GeometryVerticesOut = 0x8916,
		GeometryInputType = 0x8917,
		GeometryOutputType = 0x8918,
		ProgramBinaryLength = 0x8741,
		ActiveAtomicCounterBuffers = 0x92D9,
		ComputeWorkGroupSize = 0x8267,
	}

	public enum ClipControlOrigin : uint
	{
		LowerLeft = 0x8CA1,
		UpperLeft = 0x8CA2,
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

	public enum ContextFlagMask : uint
	{
		ContextFlagForwardCompatibleBit = 0x00000001,
		ContextFlagDebugBit = 0x00000002,
		ContextFlagRobustAccessBit = 0x00000004,
		ContextFlagNoErrorBit = 0x00000008,
	}

	public enum TypeEnum : uint
	{
		QueryWait = 0x8E13,
		QueryNoWait = 0x8E14,
		QueryByRegionWait = 0x8E15,
		QueryByRegionNoWait = 0x8E16,
	}

	public enum FramebufferAttachmentParameterName : uint
	{
		FramebufferAttachmentColorEncoding = 0x8210,
		FramebufferAttachmentComponentType = 0x8211,
		FramebufferAttachmentRedSize = 0x8212,
		FramebufferAttachmentGreenSize = 0x8213,
		FramebufferAttachmentBlueSize = 0x8214,
		FramebufferAttachmentAlphaSize = 0x8215,
		FramebufferAttachmentDepthSize = 0x8216,
		FramebufferAttachmentStencilSize = 0x8217,
		FramebufferAttachmentObjectName = 0x8CD1,
		FramebufferAttachmentTextureLevel = 0x8CD2,
		FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
		FramebufferAttachmentTextureLayer = 0x8CD4,
		FramebufferAttachmentLayered = 0x8DA7,
	}

	public enum FramebufferStatus : uint
	{
		FramebufferUndefined = 0x8219,
		FramebufferComplete = 0x8CD5,
		FramebufferIncompleteAttachment = 0x8CD6,
		FramebufferIncompleteMissingAttachment = 0x8CD7,
		FramebufferIncompleteDrawBuffer = 0x8CDB,
		FramebufferIncompleteReadBuffer = 0x8CDC,
		FramebufferUnsupported = 0x8CDD,
		FramebufferIncompleteMultisample = 0x8D56,
		FramebufferIncompleteLayerTargets = 0x8DA8,
	}

	public enum FramebufferAttachment : uint
	{
		DepthStencilAttachment = 0x821A,
		MaxColorAttachments = 0x8CDF,
		ColorAttachment0 = 0x8CE0,
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
		DepthAttachment = 0x8D00,
	}

	public enum FramebufferTarget : uint
	{
		ReadFramebuffer = 0x8CA8,
		DrawFramebuffer = 0x8CA9,
		Framebuffer = 0x8D40,
	}

	public enum RenderbufferParameterName : uint
	{
		RenderbufferSamples = 0x8CAB,
		RenderbufferWidth = 0x8D42,
		RenderbufferHeight = 0x8D43,
		RenderbufferInternalFormat = 0x8D44,
		RenderbufferRedSize = 0x8D50,
		RenderbufferGreenSize = 0x8D51,
		RenderbufferBlueSize = 0x8D52,
		RenderbufferAlphaSize = 0x8D53,
		RenderbufferDepthSize = 0x8D54,
		RenderbufferStencilSize = 0x8D55,
	}

	public enum RenderbufferTarget : uint
	{
		Renderbuffer = 0x8D41,
	}

	public enum BufferStorageMask : uint
	{
		MapReadBit = 0x0001,
		MapWriteBit = 0x0002,
		MapPersistentBit = 0x0040,
		MapCoherentBit = 0x0080,
		DynamicStorageBit = 0x0100,
		ClientStorageBit = 0x0200,
	}

	public enum MapBufferAccessMask : uint
	{
		MapInvalidateRangeBit = 0x0004,
		MapInvalidateBufferBit = 0x0008,
		MapFlushExplicitBit = 0x0010,
		MapUnsynchronizedBit = 0x0020,
	}

	public enum Buffer : uint
	{
		Color = 0x1800,
		Depth = 0x1801,
		Stencil = 0x1802,
	}

	public enum BlitFramebufferFilter : uint
	{
		Nearest = 0x2600,
		Linear = 0x2601,
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
		UniformAtomicCounterBufferIndex = 0x92DA,
	}

	public enum UniformBlockPName : uint
	{
		UniformBlockBinding = 0x8A3F,
		UniformBlockDataSize = 0x8A40,
		UniformBlockNameLength = 0x8A41,
		UniformBlockActiveUniforms = 0x8A42,
		UniformBlockActiveUniformIndices = 0x8A43,
		UniformBlockReferencedByVertexShader = 0x8A44,
		UniformBlockReferencedByGeometryShader = 0x8A45,
		UniformBlockReferencedByFragmentShader = 0x8A46,
		UniformBlockReferencedByTessControlShader = 0x84F0,
		UniformBlockReferencedByTessEvaluationShader = 0x84F1,
		UniformBlockReferencedByComputeShader = 0x90EC,
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

	public enum ContextProfileMask : uint
	{
		ContextCoreProfileBit = 0x00000001,
		ContextCompatibilityProfileBit = 0x00000002,
	}

	public enum VertexProvokingMode : uint
	{
		FirstVertexConvention = 0x8E4D,
		LastVertexConvention = 0x8E4E,
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

	public enum QueryCounterTarget : uint
	{
		Timestamp = 0x8E28,
	}

	public enum ProgramStagePName : uint
	{
		ActiveSubroutines = 0x8DE5,
		ActiveSubroutineUniforms = 0x8DE6,
		ActiveSubroutineUniformLocations = 0x8E47,
		ActiveSubroutineMaxLength = 0x8E48,
		ActiveSubroutineUniformMaxLength = 0x8E49,
	}

	public enum SubroutineParameterName : uint
	{
		NumCompatibleSubroutines = 0x8E4A,
		CompatibleSubroutines = 0x8E4B,
	}

	public enum PatchParameterName : uint
	{
		PatchVertices = 0x8E72,
		PatchDefaultInnerLevel = 0x8E73,
		PatchDefaultOuterLevel = 0x8E74,
	}

	public enum BindTransformFeedbackTarget : uint
	{
		TransformFeedback = 0x8E22,
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

	public enum UseProgramStageMask : uint
	{
		VertexShaderBit = 0x00000001,
		FragmentShaderBit = 0x00000002,
		GeometryShaderBit = 0x00000004,
		TessControlShaderBit = 0x00000008,
		TessEvaluationShaderBit = 0x00000010,
		AllShaderBits = 0xFFFFFFFF,
		ComputeShaderBit = 0x00000020,
	}

	public enum ProgramParameterPName : uint
	{
		ProgramSeparable = 0x8258,
	}

	public enum PipelineParameterName : uint
	{
		ActiveProgram = 0x8259,
	}

	public enum TransformFeedbackPName : uint
	{
		TransformFeedbackActive = 0x8E24,
		TransformFeedbackPaused = 0x8E23,
	}

	public enum AtomicCounterBufferPName : uint
	{
		AtomicCounterBufferBinding = 0x92C1,
		AtomicCounterBufferDataSize = 0x92C4,
		AtomicCounterBufferActiveAtomicCounters = 0x92C5,
		AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
		AtomicCounterBufferReferencedByVertexShader = 0x92C7,
		AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
		AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
		AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
		AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
		AtomicCounterBufferReferencedByComputeShader = 0x90ED,
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
		ClientMappedBufferBarrierBit = 0x00004000,
		QueryBufferBarrierBit = 0x00008000,
	}

	public enum GetPointervPName : uint
	{
		DebugCallbackFunction = 0x8244,
		DebugCallbackUserParam = 0x8245,
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
		DebugSeverityHigh = 0x9146,
		DebugSeverityMedium = 0x9147,
		DebugSeverityLow = 0x9148,
		DebugSeverityNotification = 0x826B,
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

	public enum FramebufferParameterName : uint
	{
		FramebufferDefaultWidth = 0x9310,
		FramebufferDefaultHeight = 0x9311,
		FramebufferDefaultLayers = 0x9312,
		FramebufferDefaultSamples = 0x9313,
		FramebufferDefaultFixedSampleLocations = 0x9314,
	}

	public enum ProgramInterface : uint
	{
		Uniform = 0x92E1,
		UniformBlock = 0x92E2,
		ProgramInput = 0x92E3,
		ProgramOutput = 0x92E4,
		BufferVariable = 0x92E5,
		ShaderStorageBlock = 0x92E6,
		VertexSubroutine = 0x92E8,
		TessControlSubroutine = 0x92E9,
		TessEvaluationSubroutine = 0x92EA,
		GeometrySubroutine = 0x92EB,
		FragmentSubroutine = 0x92EC,
		ComputeSubroutine = 0x92ED,
		VertexSubroutineUniform = 0x92EE,
		TessControlSubroutineUniform = 0x92EF,
		TessEvaluationSubroutineUniform = 0x92F0,
		GeometrySubroutineUniform = 0x92F1,
		FragmentSubroutineUniform = 0x92F2,
		ComputeSubroutineUniform = 0x92F3,
		TransformFeedbackVarying = 0x92F4,
	}

	public enum ProgramInterfacePName : uint
	{
		ActiveResources = 0x92F5,
		MaxNameLength = 0x92F6,
		MaxNumActiveVariables = 0x92F7,
		MaxNumCompatibleSubroutines = 0x92F8,
	}

	public enum BufferStorageTarget : uint
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

	public enum ClipControlDepth : uint
	{
		NegativeOneToOne = 0x935E,
		ZeroToOne = 0x935F,
	}

	public enum GraphicsResetStatus : uint
	{
		GuiltyContextReset = 0x8253,
		InnocentContextReset = 0x8254,
		UnknownContextReset = 0x8255,
	}

	public enum VertexBufferObjectUsage : uint
	{
		StreamDraw = 0x88E0,
		StreamRead = 0x88E1,
		StreamCopy = 0x88E2,
		StaticDraw = 0x88E4,
		StaticRead = 0x88E5,
		StaticCopy = 0x88E6,
		DynamicDraw = 0x88E8,
		DynamicRead = 0x88E9,
		DynamicCopy = 0x88EA,
	}

	public enum ColorBuffer : uint
	{
		None = 0,
		FrontLeft = 0x0400,
		FrontRight = 0x0401,
		BackLeft = 0x0402,
		BackRight = 0x0403,
		Front = 0x0404,
		Back = 0x0405,
		Left = 0x0406,
		Right = 0x0407,
		FrontAndBack = 0x0408,
		ColorAttachment0 = 0x8CE0,
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

	public enum GetFramebufferParameter : uint
	{
		FramebufferDefaultWidth = 0x9310,
		FramebufferDefaultHeight = 0x9311,
		FramebufferDefaultLayers = 0x9312,
		FramebufferDefaultSamples = 0x9313,
		FramebufferDefaultFixedSampleLocations = 0x9314,
		Doublebuffer = 0x0C32,
		ImplementationColorReadFormat = 0x8B9B,
		ImplementationColorReadType = 0x8B9A,
		Samples = 0x80A9,
		SampleBuffers = 0x80A8,
		Stereo = 0x0C33,
	}

	public enum MapQuery : uint
	{
		Coeff = 0x0A00,
		Order = 0x0A01,
		Domain = 0x0A02,
	}

	public enum PixelMap : uint
	{
		PixelMapAToA = 0x0C79,
		PixelMapBToB = 0x0C78,
		PixelMapGToG = 0x0C77,
		PixelMapIToA = 0x0C75,
		PixelMapIToB = 0x0C74,
		PixelMapIToG = 0x0C73,
		PixelMapIToI = 0x0C70,
		PixelMapIToR = 0x0C72,
		PixelMapRToR = 0x0C76,
		PixelMapSToS = 0x0C71,
	}

	public enum ColorTableTarget : uint
	{
		ColorTable = 0x80D0,
		PostConvolutionColorTable = 0x80D1,
		PostColorMatrixColorTable = 0x80D2,
	}

	public enum ConvolutionTarget : uint
	{
		Convolution1d = 0x8010,
		Convolution2d = 0x8011,
	}

	public enum SeparableTargetEXT : uint
	{
		Separable2d = 0x8012,
		Separable2dExt = 0x8012,
	}

	public enum HistogramTargetEXT : uint
	{
		Histogram = 0x8024,
		HistogramExt = 0x8024,
		ProxyHistogram = 0x8025,
		ProxyHistogramExt = 0x8025,
	}

	public enum MinmaxTargetEXT : uint
	{
		Minmax = 0x802E,
		MinmaxExt = 0x802E,
	}
}
