using Raylib_CSharp.Rendering.Gl.Contexts;

namespace Raylib_CSharp;

public struct GLSync {

	public IntPtr Value;

	public GLSync(IntPtr value) {
		Value = value;
	}
}

public static class Gl {

	public const int ActiveAtomicCounterBuffers_ = 0x92D9;
	public const int ActiveAttributes_ = 0x8B89;
	public const int ActiveAttributeMaxLength_ = 0x8B8A;
	public const int ActiveProgram_ = 0x8259;
	public const int ActiveResources_ = 0x92F5;
	public const int ActiveSubroutines_ = 0x8DE5;
	public const int ActiveSubroutineMaxLength_ = 0x8E48;
	public const int ActiveSubroutineUniforms_ = 0x8DE6;
	public const int ActiveSubroutineUniformLocations_ = 0x8E47;
	public const int ActiveSubroutineUniformMaxLength_ = 0x8E49;
	public const int ActiveTexture_ = 0x84E0;
	public const int ActiveTextureArb_ = 0x84E0;
	public const int ActiveUniforms_ = 0x8B86;
	public const int ActiveUniformBlocks_ = 0x8A36;
	public const int ActiveUniformBlockMaxNameLength_ = 0x8A35;
	public const int ActiveUniformMaxLength_ = 0x8B87;
	public const int ActiveVariables_ = 0x9305;
	public const int AliasedLineWidthRange_ = 0x846E;
	public const uint AllBarrierBits_ = 0xFFFFFFFF;
	public const uint AllShaderBits_ = 0xFFFFFFFF;
	public const int Alpha_ = 0x1906;
	public const int Alpha16fArb_ = 0x881C;
	public const int Alpha32fArb_ = 0x8816;
	public const int AlreadySignaled_ = 0x911A;
	public const int Always_ = 0x0207;
	public const int And_ = 0x1501;
	public const int AndInverted_ = 0x1504;
	public const int AndReverse_ = 0x1502;
	public const int AnySamplesPassed_ = 0x8C2F;
	public const int AnySamplesPassedConservative_ = 0x8D6A;
	public const int ArrayBuffer_ = 0x8892;
	public const int ArrayBufferArb_ = 0x8892;
	public const int ArrayBufferBinding_ = 0x8894;
	public const int ArrayBufferBindingArb_ = 0x8894;
	public const int ArraySize_ = 0x92FB;
	public const int ArrayStride_ = 0x92FE;
	public const int AtomicCounterBarrierBit_ = 0x00001000;
	public const int AtomicCounterBuffer_ = 0x92C0;
	public const int AtomicCounterBufferActiveAtomicCounters_ = 0x92C5;
	public const int AtomicCounterBufferActiveAtomicCounterIndices_ = 0x92C6;
	public const int AtomicCounterBufferBinding_ = 0x92C1;
	public const int AtomicCounterBufferDataSize_ = 0x92C4;
	public const int AtomicCounterBufferIndex_ = 0x9301;
	public const int AtomicCounterBufferReferencedByComputeShader_ = 0x90ED;
	public const int AtomicCounterBufferReferencedByFragmentShader_ = 0x92CB;
	public const int AtomicCounterBufferReferencedByGeometryShader_ = 0x92CA;
	public const int AtomicCounterBufferReferencedByTessControlShader_ = 0x92C8;
	public const int AtomicCounterBufferReferencedByTessEvaluationShader_ = 0x92C9;
	public const int AtomicCounterBufferReferencedByVertexShader_ = 0x92C7;
	public const int AtomicCounterBufferSize_ = 0x92C3;
	public const int AtomicCounterBufferStart_ = 0x92C2;
	public const int AttachedShaders_ = 0x8B85;
	public const int AutoGenerateMipmap_ = 0x8295;
	public const int Back_ = 0x0405;
	public const int BackLeft_ = 0x0402;
	public const int BackRight_ = 0x0403;
	public const int Bgr_ = 0x80E0;
	public const int Bgra_ = 0x80E1;
	public const int BgraInteger_ = 0x8D9B;
	public const int BgrInteger_ = 0x8D9A;
	public const int Blend_ = 0x0BE2;
	public const int BlendColor_ = 0x8005;
	public const int BlendDst_ = 0x0BE0;
	public const int BlendDstAlpha_ = 0x80CA;
	public const int BlendDstRgb_ = 0x80C8;
	public const int BlendEquation_ = 0x8009;
	public const int BlendEquationAlpha_ = 0x883D;
	public const int BlendEquationRgb_ = 0x8009;
	public const int BlendSrc_ = 0x0BE1;
	public const int BlendSrcAlpha_ = 0x80CB;
	public const int BlendSrcRgb_ = 0x80C9;
	public const int BlockIndex_ = 0x92FD;
	public const int Blue_ = 0x1905;
	public const int BlueInteger_ = 0x8D96;
	public const int Bool_ = 0x8B56;
	public const int BoolArb_ = 0x8B56;
	public const int BoolVec2_ = 0x8B57;
	public const int BoolVec2Arb_ = 0x8B57;
	public const int BoolVec3_ = 0x8B58;
	public const int BoolVec3Arb_ = 0x8B58;
	public const int BoolVec4_ = 0x8B59;
	public const int BoolVec4Arb_ = 0x8B59;
	public const int Buffer_ = 0x82E0;
	public const int BufferAccess_ = 0x88BB;
	public const int BufferAccessArb_ = 0x88BB;
	public const int BufferAccessFlags_ = 0x911F;
	public const int BufferBinding_ = 0x9302;
	public const int BufferDataSize_ = 0x9303;
	public const int BufferImmutableStorage_ = 0x821F;
	public const int BufferMapped_ = 0x88BC;
	public const int BufferMappedArb_ = 0x88BC;
	public const int BufferMapLength_ = 0x9120;
	public const int BufferMapOffset_ = 0x9121;
	public const int BufferMapPointer_ = 0x88BD;
	public const int BufferMapPointerArb_ = 0x88BD;
	public const int BufferSize_ = 0x8764;
	public const int BufferSizeArb_ = 0x8764;
	public const int BufferStorageFlags_ = 0x8220;
	public const int BufferUpdateBarrierBit_ = 0x00000200;
	public const int BufferUsage_ = 0x8765;
	public const int BufferUsageArb_ = 0x8765;
	public const int BufferVariable_ = 0x92E5;
	public const int Byte_ = 0x1400;
	public const int CaveatSupport_ = 0x82B8;
	public const int Ccw_ = 0x0901;
	public const int ClampFragmentColorArb_ = 0x891B;
	public const int ClampReadColor_ = 0x891C;
	public const int ClampReadColorArb_ = 0x891C;
	public const int ClampToBorder_ = 0x812D;
	public const int ClampToBorderArb_ = 0x812D;
	public const int ClampToEdge_ = 0x812F;
	public const int ClampVertexColorArb_ = 0x891A;
	public const int Clear_ = 0x1500;
	public const int ClearBuffer_ = 0x82B4;
	public const int ClearTexture_ = 0x9365;
	public const int ClientActiveTextureArb_ = 0x84E1;
	public const int ClientMappedBufferBarrierBit_ = 0x00004000;
	public const int ClientStorageBit_ = 0x0200;
	public const int ClippingInputPrimitives_ = 0x82F6;
	public const int ClippingInputPrimitivesArb_ = 0x82F6;
	public const int ClippingOutputPrimitives_ = 0x82F7;
	public const int ClippingOutputPrimitivesArb_ = 0x82F7;
	public const int ClipDistance0_ = 0x3000;
	public const int ClipDistance1_ = 0x3001;
	public const int ClipDistance2_ = 0x3002;
	public const int ClipDistance3_ = 0x3003;
	public const int ClipDistance4_ = 0x3004;
	public const int ClipDistance5_ = 0x3005;
	public const int ClipDistance6_ = 0x3006;
	public const int ClipDistance7_ = 0x3007;
	public const int Color_ = 0x1800;
	public const int ColorArrayBufferBindingArb_ = 0x8898;
	public const int ColorAttachment0_ = 0x8CE0;
	public const int ColorAttachment0Ext_ = 0x8CE0;
	public const int ColorAttachment1_ = 0x8CE1;
	public const int ColorAttachment10_ = 0x8CEA;
	public const int ColorAttachment10Ext_ = 0x8CEA;
	public const int ColorAttachment11_ = 0x8CEB;
	public const int ColorAttachment11Ext_ = 0x8CEB;
	public const int ColorAttachment12_ = 0x8CEC;
	public const int ColorAttachment12Ext_ = 0x8CEC;
	public const int ColorAttachment13_ = 0x8CED;
	public const int ColorAttachment13Ext_ = 0x8CED;
	public const int ColorAttachment14_ = 0x8CEE;
	public const int ColorAttachment14Ext_ = 0x8CEE;
	public const int ColorAttachment15_ = 0x8CEF;
	public const int ColorAttachment15Ext_ = 0x8CEF;
	public const int ColorAttachment16_ = 0x8CF0;
	public const int ColorAttachment17_ = 0x8CF1;
	public const int ColorAttachment18_ = 0x8CF2;
	public const int ColorAttachment19_ = 0x8CF3;
	public const int ColorAttachment1Ext_ = 0x8CE1;
	public const int ColorAttachment2_ = 0x8CE2;
	public const int ColorAttachment20_ = 0x8CF4;
	public const int ColorAttachment21_ = 0x8CF5;
	public const int ColorAttachment22_ = 0x8CF6;
	public const int ColorAttachment23_ = 0x8CF7;
	public const int ColorAttachment24_ = 0x8CF8;
	public const int ColorAttachment25_ = 0x8CF9;
	public const int ColorAttachment26_ = 0x8CFA;
	public const int ColorAttachment27_ = 0x8CFB;
	public const int ColorAttachment28_ = 0x8CFC;
	public const int ColorAttachment29_ = 0x8CFD;
	public const int ColorAttachment2Ext_ = 0x8CE2;
	public const int ColorAttachment3_ = 0x8CE3;
	public const int ColorAttachment30_ = 0x8CFE;
	public const int ColorAttachment31_ = 0x8CFF;
	public const int ColorAttachment3Ext_ = 0x8CE3;
	public const int ColorAttachment4_ = 0x8CE4;
	public const int ColorAttachment4Ext_ = 0x8CE4;
	public const int ColorAttachment5_ = 0x8CE5;
	public const int ColorAttachment5Ext_ = 0x8CE5;
	public const int ColorAttachment6_ = 0x8CE6;
	public const int ColorAttachment6Ext_ = 0x8CE6;
	public const int ColorAttachment7_ = 0x8CE7;
	public const int ColorAttachment7Ext_ = 0x8CE7;
	public const int ColorAttachment8_ = 0x8CE8;
	public const int ColorAttachment8Ext_ = 0x8CE8;
	public const int ColorAttachment9_ = 0x8CE9;
	public const int ColorAttachment9Ext_ = 0x8CE9;
	public const int ColorBufferBit_ = 0x00004000;
	public const int ColorClearValue_ = 0x0C22;
	public const int ColorComponents_ = 0x8283;
	public const int ColorEncoding_ = 0x8296;
	public const int ColorLogicOp_ = 0x0BF2;
	public const int ColorRenderable_ = 0x8286;
	public const int ColorSumArb_ = 0x8458;
	public const int ColorWritemask_ = 0x0C23;
	public const int CommandBarrierBit_ = 0x00000040;
	public const int CompareRefToTexture_ = 0x884E;
	public const int CompatibleSubroutines_ = 0x8E4B;
	public const int CompileStatus_ = 0x8B81;
	public const int CompressedAlphaArb_ = 0x84E9;
	public const int CompressedIntensityArb_ = 0x84EC;
	public const int CompressedLuminanceAlphaArb_ = 0x84EB;
	public const int CompressedLuminanceArb_ = 0x84EA;
	public const int CompressedR11Eac_ = 0x9270;
	public const int CompressedRed_ = 0x8225;
	public const int CompressedRedRgtc1_ = 0x8DBB;
	public const int CompressedRg_ = 0x8226;
	public const int CompressedRg11Eac_ = 0x9272;
	public const int CompressedRgb_ = 0x84ED;
	public const int CompressedRgb8Etc2_ = 0x9274;
	public const int CompressedRgb8PunchthroughAlpha1Etc2_ = 0x9276;
	public const int CompressedRgba_ = 0x84EE;
	public const int CompressedRgba8Etc2Eac_ = 0x9278;
	public const int CompressedRgbaArb_ = 0x84EE;
	public const int CompressedRgbaAstc10x10Khr_ = 0x93BB;
	public const int CompressedRgbaAstc10x5Khr_ = 0x93B8;
	public const int CompressedRgbaAstc10x6Khr_ = 0x93B9;
	public const int CompressedRgbaAstc10x8Khr_ = 0x93BA;
	public const int CompressedRgbaAstc12x10Khr_ = 0x93BC;
	public const int CompressedRgbaAstc12x12Khr_ = 0x93BD;
	public const int CompressedRgbaAstc4x4Khr_ = 0x93B0;
	public const int CompressedRgbaAstc5x4Khr_ = 0x93B1;
	public const int CompressedRgbaAstc5x5Khr_ = 0x93B2;
	public const int CompressedRgbaAstc6x5Khr_ = 0x93B3;
	public const int CompressedRgbaAstc6x6Khr_ = 0x93B4;
	public const int CompressedRgbaAstc8x5Khr_ = 0x93B5;
	public const int CompressedRgbaAstc8x6Khr_ = 0x93B6;
	public const int CompressedRgbaAstc8x8Khr_ = 0x93B7;
	public const int CompressedRgbaBptcUnorm_ = 0x8E8C;
	public const int CompressedRgbaS3tcDxt1Ext_ = 0x83F1;
	public const int CompressedRgbaS3tcDxt3Ext_ = 0x83F2;
	public const int CompressedRgbaS3tcDxt5Ext_ = 0x83F3;
	public const int CompressedRgbArb_ = 0x84ED;
	public const int CompressedRgbBptcSignedFloat_ = 0x8E8E;
	public const int CompressedRgbBptcUnsignedFloat_ = 0x8E8F;
	public const int CompressedRgbS3tcDxt1Ext_ = 0x83F0;
	public const int CompressedRgRgtc2_ = 0x8DBD;
	public const int CompressedSignedR11Eac_ = 0x9271;
	public const int CompressedSignedRedRgtc1_ = 0x8DBC;
	public const int CompressedSignedRg11Eac_ = 0x9273;
	public const int CompressedSignedRgRgtc2_ = 0x8DBE;
	public const int CompressedSrgb_ = 0x8C48;
	public const int CompressedSrgb8Alpha8Astc10x10Khr_ = 0x93DB;
	public const int CompressedSrgb8Alpha8Astc10x5Khr_ = 0x93D8;
	public const int CompressedSrgb8Alpha8Astc10x6Khr_ = 0x93D9;
	public const int CompressedSrgb8Alpha8Astc10x8Khr_ = 0x93DA;
	public const int CompressedSrgb8Alpha8Astc12x10Khr_ = 0x93DC;
	public const int CompressedSrgb8Alpha8Astc12x12Khr_ = 0x93DD;
	public const int CompressedSrgb8Alpha8Astc4x4Khr_ = 0x93D0;
	public const int CompressedSrgb8Alpha8Astc5x4Khr_ = 0x93D1;
	public const int CompressedSrgb8Alpha8Astc5x5Khr_ = 0x93D2;
	public const int CompressedSrgb8Alpha8Astc6x5Khr_ = 0x93D3;
	public const int CompressedSrgb8Alpha8Astc6x6Khr_ = 0x93D4;
	public const int CompressedSrgb8Alpha8Astc8x5Khr_ = 0x93D5;
	public const int CompressedSrgb8Alpha8Astc8x6Khr_ = 0x93D6;
	public const int CompressedSrgb8Alpha8Astc8x8Khr_ = 0x93D7;
	public const int CompressedSrgb8Alpha8Etc2Eac_ = 0x9279;
	public const int CompressedSrgb8Etc2_ = 0x9275;
	public const int CompressedSrgb8PunchthroughAlpha1Etc2_ = 0x9277;
	public const int CompressedSrgbAlpha_ = 0x8C49;
	public const int CompressedSrgbAlphaBptcUnorm_ = 0x8E8D;
	public const int CompressedTextureFormats_ = 0x86A3;
	public const int CompressedTextureFormatsArb_ = 0x86A3;
	public const int ComputeShader_ = 0x91B9;
	public const int ComputeShaderBit_ = 0x00000020;
	public const int ComputeShaderInvocations_ = 0x82F5;
	public const int ComputeShaderInvocationsArb_ = 0x82F5;
	public const int ComputeSubroutine_ = 0x92ED;
	public const int ComputeSubroutineUniform_ = 0x92F3;
	public const int ComputeTexture_ = 0x82A0;
	public const int ComputeWorkGroupSize_ = 0x8267;
	public const int ConditionSatisfied_ = 0x911C;
	public const int ConstantAlpha_ = 0x8003;
	public const int ConstantColor_ = 0x8001;
	public const int ContextCompatibilityProfileBit_ = 0x00000002;
	public const int ContextCoreProfileBit_ = 0x00000001;
	public const int ContextFlags_ = 0x821E;
	public const int ContextFlagDebugBit_ = 0x00000002;
	public const int ContextFlagForwardCompatibleBit_ = 0x00000001;
	public const int ContextProfileMask_ = 0x9126;
	public const int Copy_ = 0x1503;
	public const int CopyInverted_ = 0x150C;
	public const int CopyReadBuffer_ = 0x8F36;
	public const int CopyReadBufferBinding_ = 0x8F36;
	public const int CopyWriteBuffer_ = 0x8F37;
	public const int CopyWriteBufferBinding_ = 0x8F37;
	public const int CullFace_ = 0x0B44;
	public const int CullFaceMode_ = 0x0B45;
	public const int CurrentFogCoordinateExt_ = 0x8453;
	public const int CurrentMatrixArb_ = 0x8641;
	public const int CurrentMatrixStackDepthArb_ = 0x8640;
	public const int CurrentProgram_ = 0x8B8D;
	public const int CurrentQuery_ = 0x8865;
	public const int CurrentQueryArb_ = 0x8865;
	public const int CurrentVertexAttrib_ = 0x8626;
	public const int CurrentVertexAttribArb_ = 0x8626;
	public const int Cw_ = 0x0900;
	public const int DebugCallbackFunction_ = 0x8244;
	public const int DebugCallbackFunctionArb_ = 0x8244;
	public const int DebugCallbackUserParam_ = 0x8245;
	public const int DebugCallbackUserParamArb_ = 0x8245;
	public const int DebugGroupStackDepth_ = 0x826D;
	public const int DebugLoggedMessages_ = 0x9145;
	public const int DebugLoggedMessagesArb_ = 0x9145;
	public const int DebugNextLoggedMessageLength_ = 0x8243;
	public const int DebugNextLoggedMessageLengthArb_ = 0x8243;
	public const int DebugOutput_ = 0x92E0;
	public const int DebugOutputSynchronous_ = 0x8242;
	public const int DebugOutputSynchronousArb_ = 0x8242;
	public const int DebugSeverityHigh_ = 0x9146;
	public const int DebugSeverityHighArb_ = 0x9146;
	public const int DebugSeverityLow_ = 0x9148;
	public const int DebugSeverityLowArb_ = 0x9148;
	public const int DebugSeverityMedium_ = 0x9147;
	public const int DebugSeverityMediumArb_ = 0x9147;
	public const int DebugSeverityNotification_ = 0x826B;
	public const int DebugSourceApi_ = 0x8246;
	public const int DebugSourceApiArb_ = 0x8246;
	public const int DebugSourceApplication_ = 0x824A;
	public const int DebugSourceApplicationArb_ = 0x824A;
	public const int DebugSourceOther_ = 0x824B;
	public const int DebugSourceOtherArb_ = 0x824B;
	public const int DebugSourceShaderCompiler_ = 0x8248;
	public const int DebugSourceShaderCompilerArb_ = 0x8248;
	public const int DebugSourceThirdParty_ = 0x8249;
	public const int DebugSourceThirdPartyArb_ = 0x8249;
	public const int DebugSourceWindowSystem_ = 0x8247;
	public const int DebugSourceWindowSystemArb_ = 0x8247;
	public const int DebugTypeDeprecatedBehavior_ = 0x824D;
	public const int DebugTypeDeprecatedBehaviorArb_ = 0x824D;
	public const int DebugTypeError_ = 0x824C;
	public const int DebugTypeErrorArb_ = 0x824C;
	public const int DebugTypeMarker_ = 0x8268;
	public const int DebugTypeOther_ = 0x8251;
	public const int DebugTypeOtherArb_ = 0x8251;
	public const int DebugTypePerformance_ = 0x8250;
	public const int DebugTypePerformanceArb_ = 0x8250;
	public const int DebugTypePopGroup_ = 0x826A;
	public const int DebugTypePortability_ = 0x824F;
	public const int DebugTypePortabilityArb_ = 0x824F;
	public const int DebugTypePushGroup_ = 0x8269;
	public const int DebugTypeUndefinedBehavior_ = 0x824E;
	public const int DebugTypeUndefinedBehaviorArb_ = 0x824E;
	public const int Decr_ = 0x1E03;
	public const int DecrWrap_ = 0x8508;
	public const int DeleteStatus_ = 0x8B80;
	public const int Depth_ = 0x1801;
	public const int Depth24Stencil8_ = 0x88F0;
	public const int Depth32fStencil8_ = 0x8CAD;
	public const int DepthAttachment_ = 0x8D00;
	public const int DepthAttachmentExt_ = 0x8D00;
	public const int DepthBufferBit_ = 0x00000100;
	public const int DepthClamp_ = 0x864F;
	public const int DepthClearValue_ = 0x0B73;
	public const int DepthComponent_ = 0x1902;
	public const int DepthComponent16_ = 0x81A5;
	public const int DepthComponent16Arb_ = 0x81A5;
	public const int DepthComponent24_ = 0x81A6;
	public const int DepthComponent24Arb_ = 0x81A6;
	public const int DepthComponent32_ = 0x81A7;
	public const int DepthComponent32f_ = 0x8CAC;
	public const int DepthComponent32Arb_ = 0x81A7;
	public const int DepthComponents_ = 0x8284;
	public const int DepthFunc_ = 0x0B74;
	public const int DepthRange_ = 0x0B70;
	public const int DepthRenderable_ = 0x8287;
	public const int DepthStencil_ = 0x84F9;
	public const int DepthStencilAttachment_ = 0x821A;
	public const int DepthStencilTextureMode_ = 0x90EA;
	public const int DepthTest_ = 0x0B71;
	public const int DepthTextureModeArb_ = 0x884B;
	public const int DepthWritemask_ = 0x0B72;
	public const int DispatchIndirectBuffer_ = 0x90EE;
	public const int DispatchIndirectBufferBinding_ = 0x90EF;
	public const int Dither_ = 0x0BD0;
	public const int DontCare_ = 0x1100;
	public const int Double_ = 0x140A;
	public const int Doublebuffer_ = 0x0C32;
	public const int DoubleMat2_ = 0x8F46;
	public const int DoubleMat2x3_ = 0x8F49;
	public const int DoubleMat2x4_ = 0x8F4A;
	public const int DoubleMat3_ = 0x8F47;
	public const int DoubleMat3x2_ = 0x8F4B;
	public const int DoubleMat3x4_ = 0x8F4C;
	public const int DoubleMat4_ = 0x8F48;
	public const int DoubleMat4x2_ = 0x8F4D;
	public const int DoubleMat4x3_ = 0x8F4E;
	public const int DoubleVec2_ = 0x8FFC;
	public const int DoubleVec3_ = 0x8FFD;
	public const int DoubleVec4_ = 0x8FFE;
	public const int DrawBuffer_ = 0x0C01;
	public const int DrawBuffer0_ = 0x8825;
	public const int DrawBuffer0Arb_ = 0x8825;
	public const int DrawBuffer1_ = 0x8826;
	public const int DrawBuffer10_ = 0x882F;
	public const int DrawBuffer10Arb_ = 0x882F;
	public const int DrawBuffer11_ = 0x8830;
	public const int DrawBuffer11Arb_ = 0x8830;
	public const int DrawBuffer12_ = 0x8831;
	public const int DrawBuffer12Arb_ = 0x8831;
	public const int DrawBuffer13_ = 0x8832;
	public const int DrawBuffer13Arb_ = 0x8832;
	public const int DrawBuffer14_ = 0x8833;
	public const int DrawBuffer14Arb_ = 0x8833;
	public const int DrawBuffer15_ = 0x8834;
	public const int DrawBuffer15Arb_ = 0x8834;
	public const int DrawBuffer1Arb_ = 0x8826;
	public const int DrawBuffer2_ = 0x8827;
	public const int DrawBuffer2Arb_ = 0x8827;
	public const int DrawBuffer3_ = 0x8828;
	public const int DrawBuffer3Arb_ = 0x8828;
	public const int DrawBuffer4_ = 0x8829;
	public const int DrawBuffer4Arb_ = 0x8829;
	public const int DrawBuffer5_ = 0x882A;
	public const int DrawBuffer5Arb_ = 0x882A;
	public const int DrawBuffer6_ = 0x882B;
	public const int DrawBuffer6Arb_ = 0x882B;
	public const int DrawBuffer7_ = 0x882C;
	public const int DrawBuffer7Arb_ = 0x882C;
	public const int DrawBuffer8_ = 0x882D;
	public const int DrawBuffer8Arb_ = 0x882D;
	public const int DrawBuffer9_ = 0x882E;
	public const int DrawBuffer9Arb_ = 0x882E;
	public const int DrawFramebuffer_ = 0x8CA9;
	public const int DrawFramebufferBinding_ = 0x8CA6;
	public const int DrawFramebufferBindingExt_ = 0x8CA6;
	public const int DrawFramebufferExt_ = 0x8CA9;
	public const int DrawIndirectBuffer_ = 0x8F3F;
	public const int DrawIndirectBufferBinding_ = 0x8F43;
	public const int DstAlpha_ = 0x0304;
	public const int DstColor_ = 0x0306;
	public const int DynamicCopy_ = 0x88EA;
	public const int DynamicCopyArb_ = 0x88EA;
	public const int DynamicDraw_ = 0x88E8;
	public const int DynamicDrawArb_ = 0x88E8;
	public const int DynamicRead_ = 0x88E9;
	public const int DynamicReadArb_ = 0x88E9;
	public const int DynamicStorageBit_ = 0x0100;
	public const int EdgeFlagArrayBufferBindingArb_ = 0x889B;
	public const int ElementArrayBarrierBit_ = 0x00000002;
	public const int ElementArrayBuffer_ = 0x8893;
	public const int ElementArrayBufferArb_ = 0x8893;
	public const int ElementArrayBufferBinding_ = 0x8895;
	public const int ElementArrayBufferBindingArb_ = 0x8895;
	public const int Equal_ = 0x0202;
	public const int Equiv_ = 0x1509;
	public const int Extensions_ = 0x1F03;
	public const int False_ = 0;
	public const int Fastest_ = 0x1101;
	public const int Fill_ = 0x1B02;
	public const int Filter_ = 0x829A;
	public const int FirstVertexConvention_ = 0x8E4D;
	public const int Fixed_ = 0x140C;
	public const int FixedOes_ = 0x140C;
	public const int FixedOnly_ = 0x891D;
	public const int FixedOnlyArb_ = 0x891D;
	public const int Float_ = 0x1406;
	public const int Float32UnsignedInt248Rev_ = 0x8DAD;
	public const int FloatMat2_ = 0x8B5A;
	public const int FloatMat2Arb_ = 0x8B5A;
	public const int FloatMat2x3_ = 0x8B65;
	public const int FloatMat2x4_ = 0x8B66;
	public const int FloatMat3_ = 0x8B5B;
	public const int FloatMat3Arb_ = 0x8B5B;
	public const int FloatMat3x2_ = 0x8B67;
	public const int FloatMat3x4_ = 0x8B68;
	public const int FloatMat4_ = 0x8B5C;
	public const int FloatMat4Arb_ = 0x8B5C;
	public const int FloatMat4x2_ = 0x8B69;
	public const int FloatMat4x3_ = 0x8B6A;
	public const int FloatVec2_ = 0x8B50;
	public const int FloatVec2Arb_ = 0x8B50;
	public const int FloatVec3_ = 0x8B51;
	public const int FloatVec3Arb_ = 0x8B51;
	public const int FloatVec4_ = 0x8B52;
	public const int FloatVec4Arb_ = 0x8B52;
	public const int FogCoordinateArrayBufferBindingArb_ = 0x889D;
	public const int FogCoordinateArrayExt_ = 0x8457;
	public const int FogCoordinateArrayPointerExt_ = 0x8456;
	public const int FogCoordinateArrayStrideExt_ = 0x8455;
	public const int FogCoordinateArrayTypeExt_ = 0x8454;
	public const int FogCoordinateExt_ = 0x8451;
	public const int FogCoordinateSourceExt_ = 0x8450;
	public const int FractionalEven_ = 0x8E7C;
	public const int FractionalOdd_ = 0x8E7B;
	public const int FragmentDepthExt_ = 0x8452;
	public const int FragmentInterpolationOffsetBits_ = 0x8E5D;
	public const int FragmentProgramArb_ = 0x8804;
	public const int FragmentShader_ = 0x8B30;
	public const int FragmentShaderArb_ = 0x8B30;
	public const int FragmentShaderBit_ = 0x00000002;
	public const int FragmentShaderDerivativeHint_ = 0x8B8B;
	public const int FragmentShaderDerivativeHintArb_ = 0x8B8B;
	public const int FragmentShaderInvocations_ = 0x82F4;
	public const int FragmentShaderInvocationsArb_ = 0x82F4;
	public const int FragmentSubroutine_ = 0x92EC;
	public const int FragmentSubroutineUniform_ = 0x92F2;
	public const int FragmentTexture_ = 0x829F;
	public const int Framebuffer_ = 0x8D40;
	public const int FramebufferAttachmentAlphaSize_ = 0x8215;
	public const int FramebufferAttachmentBlueSize_ = 0x8214;
	public const int FramebufferAttachmentColorEncoding_ = 0x8210;
	public const int FramebufferAttachmentComponentType_ = 0x8211;
	public const int FramebufferAttachmentDepthSize_ = 0x8216;
	public const int FramebufferAttachmentGreenSize_ = 0x8213;
	public const int FramebufferAttachmentLayered_ = 0x8DA7;
	public const int FramebufferAttachmentLayeredArb_ = 0x8DA7;
	public const int FramebufferAttachmentObjectName_ = 0x8CD1;
	public const int FramebufferAttachmentObjectNameExt_ = 0x8CD1;
	public const int FramebufferAttachmentObjectType_ = 0x8CD0;
	public const int FramebufferAttachmentObjectTypeExt_ = 0x8CD0;
	public const int FramebufferAttachmentRedSize_ = 0x8212;
	public const int FramebufferAttachmentStencilSize_ = 0x8217;
	public const int FramebufferAttachmentTexture3dZoffsetExt_ = 0x8CD4;
	public const int FramebufferAttachmentTextureCubeMapFace_ = 0x8CD3;
	public const int FramebufferAttachmentTextureCubeMapFaceExt_ = 0x8CD3;
	public const int FramebufferAttachmentTextureLayer_ = 0x8CD4;
	public const int FramebufferAttachmentTextureLevel_ = 0x8CD2;
	public const int FramebufferAttachmentTextureLevelExt_ = 0x8CD2;
	public const int FramebufferBarrierBit_ = 0x00000400;
	public const int FramebufferBinding_ = 0x8CA6;
	public const int FramebufferBindingExt_ = 0x8CA6;
	public const int FramebufferBlend_ = 0x828B;
	public const int FramebufferComplete_ = 0x8CD5;
	public const int FramebufferCompleteExt_ = 0x8CD5;
	public const int FramebufferDefault_ = 0x8218;
	public const int FramebufferDefaultFixedSampleLocations_ = 0x9314;
	public const int FramebufferDefaultHeight_ = 0x9311;
	public const int FramebufferDefaultLayers_ = 0x9312;
	public const int FramebufferDefaultSamples_ = 0x9313;
	public const int FramebufferDefaultWidth_ = 0x9310;
	public const int FramebufferExt_ = 0x8D40;
	public const int FramebufferIncompleteAttachment_ = 0x8CD6;
	public const int FramebufferIncompleteAttachmentExt_ = 0x8CD6;
	public const int FramebufferIncompleteDimensionsExt_ = 0x8CD9;
	public const int FramebufferIncompleteDrawBuffer_ = 0x8CDB;
	public const int FramebufferIncompleteDrawBufferExt_ = 0x8CDB;
	public const int FramebufferIncompleteFormatsExt_ = 0x8CDA;
	public const int FramebufferIncompleteLayerCountArb_ = 0x8DA9;
	public const int FramebufferIncompleteLayerTargets_ = 0x8DA8;
	public const int FramebufferIncompleteLayerTargetsArb_ = 0x8DA8;
	public const int FramebufferIncompleteMissingAttachment_ = 0x8CD7;
	public const int FramebufferIncompleteMissingAttachmentExt_ = 0x8CD7;
	public const int FramebufferIncompleteMultisample_ = 0x8D56;
	public const int FramebufferIncompleteMultisampleExt_ = 0x8D56;
	public const int FramebufferIncompleteReadBuffer_ = 0x8CDC;
	public const int FramebufferIncompleteReadBufferExt_ = 0x8CDC;
	public const int FramebufferProgrammableSampleLocationsArb_ = 0x9342;
	public const int FramebufferRenderable_ = 0x8289;
	public const int FramebufferRenderableLayered_ = 0x828A;
	public const int FramebufferSampleLocationPixelGridArb_ = 0x9343;
	public const int FramebufferSrgb_ = 0x8DB9;
	public const int FramebufferSrgbCapableExt_ = 0x8DBA;
	public const int FramebufferSrgbExt_ = 0x8DB9;
	public const int FramebufferUndefined_ = 0x8219;
	public const int FramebufferUnsupported_ = 0x8CDD;
	public const int FramebufferUnsupportedExt_ = 0x8CDD;
	public const int Front_ = 0x0404;
	public const int FrontAndBack_ = 0x0408;
	public const int FrontFace_ = 0x0B46;
	public const int FrontLeft_ = 0x0400;
	public const int FrontRight_ = 0x0401;
	public const int FullSupport_ = 0x82B7;
	public const int FuncAdd_ = 0x8006;
	public const int FuncReverseSubtract_ = 0x800B;
	public const int FuncSubtract_ = 0x800A;
	public const int GeometryInputType_ = 0x8917;
	public const int GeometryInputTypeArb_ = 0x8DDB;
	public const int GeometryOutputType_ = 0x8918;
	public const int GeometryOutputTypeArb_ = 0x8DDC;
	public const int GeometryShader_ = 0x8DD9;
	public const int GeometryShaderArb_ = 0x8DD9;
	public const int GeometryShaderBit_ = 0x00000004;
	public const int GeometryShaderInvocations_ = 0x887F;
	public const int GeometryShaderPrimitivesEmitted_ = 0x82F3;
	public const int GeometryShaderPrimitivesEmittedArb_ = 0x82F3;
	public const int GeometrySubroutine_ = 0x92EB;
	public const int GeometrySubroutineUniform_ = 0x92F1;
	public const int GeometryTexture_ = 0x829E;
	public const int GeometryVerticesOut_ = 0x8916;
	public const int GeometryVerticesOutArb_ = 0x8DDA;
	public const int Gequal_ = 0x0206;
	public const int GetTextureImageFormat_ = 0x8291;
	public const int GetTextureImageType_ = 0x8292;
	public const int Greater_ = 0x0204;
	public const int Green_ = 0x1904;
	public const int GreenInteger_ = 0x8D95;
	public const int HalfFloat_ = 0x140B;
	public const int HalfFloatArb_ = 0x140B;
	public const int HighFloat_ = 0x8DF2;
	public const int HighInt_ = 0x8DF5;
	public const int Image1d_ = 0x904C;
	public const int Image1dArray_ = 0x9052;
	public const int Image2d_ = 0x904D;
	public const int Image2dArray_ = 0x9053;
	public const int Image2dMultisample_ = 0x9055;
	public const int Image2dMultisampleArray_ = 0x9056;
	public const int Image2dRect_ = 0x904F;
	public const int Image3d_ = 0x904E;
	public const int ImageBindingAccess_ = 0x8F3E;
	public const int ImageBindingFormat_ = 0x906E;
	public const int ImageBindingLayer_ = 0x8F3D;
	public const int ImageBindingLayered_ = 0x8F3C;
	public const int ImageBindingLevel_ = 0x8F3B;
	public const int ImageBindingName_ = 0x8F3A;
	public const int ImageBuffer_ = 0x9051;
	public const int ImageClass1010102_ = 0x82C3;
	public const int ImageClass111110_ = 0x82C2;
	public const int ImageClass1X16_ = 0x82BE;
	public const int ImageClass1X32_ = 0x82BB;
	public const int ImageClass1X8_ = 0x82C1;
	public const int ImageClass2X16_ = 0x82BD;
	public const int ImageClass2X32_ = 0x82BA;
	public const int ImageClass2X8_ = 0x82C0;
	public const int ImageClass4X16_ = 0x82BC;
	public const int ImageClass4X32_ = 0x82B9;
	public const int ImageClass4X8_ = 0x82BF;
	public const int ImageCompatibilityClass_ = 0x82A8;
	public const int ImageCube_ = 0x9050;
	public const int ImageCubeMapArray_ = 0x9054;
	public const int ImageFormatCompatibilityByClass_ = 0x90C9;
	public const int ImageFormatCompatibilityBySize_ = 0x90C8;
	public const int ImageFormatCompatibilityType_ = 0x90C7;
	public const int ImagePixelFormat_ = 0x82A9;
	public const int ImagePixelType_ = 0x82AA;
	public const int ImageTexelSize_ = 0x82A7;
	public const int ImplementationColorReadFormat_ = 0x8B9B;
	public const int ImplementationColorReadType_ = 0x8B9A;
	public const int Incr_ = 0x1E02;
	public const int IncrWrap_ = 0x8507;
	public const int IndexArrayBufferBindingArb_ = 0x8899;
	public const int InfoLogLength_ = 0x8B84;
	public const int Int_ = 0x1404;
	public const int Int64Arb_ = 0x140E;
	public const int Int64Vec2Arb_ = 0x8FE9;
	public const int Int64Vec3Arb_ = 0x8FEA;
	public const int Int64Vec4Arb_ = 0x8FEB;
	public const int Intensity16fArb_ = 0x881D;
	public const int Intensity32fArb_ = 0x8817;
	public const int InterleavedAttribs_ = 0x8C8C;
	public const int InternalformatAlphaSize_ = 0x8274;
	public const int InternalformatAlphaType_ = 0x827B;
	public const int InternalformatBlueSize_ = 0x8273;
	public const int InternalformatBlueType_ = 0x827A;
	public const int InternalformatDepthSize_ = 0x8275;
	public const int InternalformatDepthType_ = 0x827C;
	public const int InternalformatGreenSize_ = 0x8272;
	public const int InternalformatGreenType_ = 0x8279;
	public const int InternalformatPreferred_ = 0x8270;
	public const int InternalformatRedSize_ = 0x8271;
	public const int InternalformatRedType_ = 0x8278;
	public const int InternalformatSharedSize_ = 0x8277;
	public const int InternalformatStencilSize_ = 0x8276;
	public const int InternalformatStencilType_ = 0x827D;
	public const int InternalformatSupported_ = 0x826F;
	public const int Int2101010Rev_ = 0x8D9F;
	public const int IntImage1d_ = 0x9057;
	public const int IntImage1dArray_ = 0x905D;
	public const int IntImage2d_ = 0x9058;
	public const int IntImage2dArray_ = 0x905E;
	public const int IntImage2dMultisample_ = 0x9060;
	public const int IntImage2dMultisampleArray_ = 0x9061;
	public const int IntImage2dRect_ = 0x905A;
	public const int IntImage3d_ = 0x9059;
	public const int IntImageBuffer_ = 0x905C;
	public const int IntImageCube_ = 0x905B;
	public const int IntImageCubeMapArray_ = 0x905F;
	public const int IntSampler1d_ = 0x8DC9;
	public const int IntSampler1dArray_ = 0x8DCE;
	public const int IntSampler2d_ = 0x8DCA;
	public const int IntSampler2dArray_ = 0x8DCF;
	public const int IntSampler2dMultisample_ = 0x9109;
	public const int IntSampler2dMultisampleArray_ = 0x910C;
	public const int IntSampler2dRect_ = 0x8DCD;
	public const int IntSampler3d_ = 0x8DCB;
	public const int IntSamplerBuffer_ = 0x8DD0;
	public const int IntSamplerCube_ = 0x8DCC;
	public const int IntSamplerCubeMapArray_ = 0x900E;
	public const int IntSamplerCubeMapArrayArb_ = 0x900E;
	public const int IntVec2_ = 0x8B53;
	public const int IntVec2Arb_ = 0x8B53;
	public const int IntVec3_ = 0x8B54;
	public const int IntVec3Arb_ = 0x8B54;
	public const int IntVec4_ = 0x8B55;
	public const int IntVec4Arb_ = 0x8B55;
	public const int InvalidEnum_ = 0x0500;
	public const int InvalidFramebufferOperation_ = 0x0506;
	public const int InvalidFramebufferOperationExt_ = 0x0506;
	public const uint InvalidIndex_ = 0xFFFFFFFF;
	public const int InvalidOperation_ = 0x0502;
	public const int InvalidValue_ = 0x0501;
	public const int Invert_ = 0x150A;
	public const int Isolines_ = 0x8E7A;
	public const int IsPerPatch_ = 0x92E7;
	public const int IsRowMajor_ = 0x9300;
	public const int Keep_ = 0x1E00;
	public const int LastVertexConvention_ = 0x8E4E;
	public const int LayerProvokingVertex_ = 0x825E;
	public const int Left_ = 0x0406;
	public const int Lequal_ = 0x0203;
	public const int Less_ = 0x0201;
	public const int Line_ = 0x1B01;
	public const int Linear_ = 0x2601;
	public const int LinearMipmapLinear_ = 0x2703;
	public const int LinearMipmapNearest_ = 0x2701;
	public const int Lines_ = 0x0001;
	public const int LinesAdjacency_ = 0x000A;
	public const int LinesAdjacencyArb_ = 0x000A;
	public const int LineLoop_ = 0x0002;
	public const int LineSmooth_ = 0x0B20;
	public const int LineSmoothHint_ = 0x0C52;
	public const int LineStrip_ = 0x0003;
	public const int LineStripAdjacency_ = 0x000B;
	public const int LineStripAdjacencyArb_ = 0x000B;
	public const int LineWidth_ = 0x0B21;
	public const int LineWidthGranularity_ = 0x0B23;
	public const int LineWidthRange_ = 0x0B22;
	public const int LinkStatus_ = 0x8B82;
	public const int Location_ = 0x930E;
	public const int LocationComponent_ = 0x934A;
	public const int LocationIndex_ = 0x930F;
	public const int LogicOpMode_ = 0x0BF0;
	public const int LowerLeft_ = 0x8CA1;
	public const int LowFloat_ = 0x8DF0;
	public const int LowInt_ = 0x8DF3;
	public const int Luminance16fArb_ = 0x881E;
	public const int Luminance32fArb_ = 0x8818;
	public const int LuminanceAlpha16fArb_ = 0x881F;
	public const int LuminanceAlpha32fArb_ = 0x8819;
	public const int MajorVersion_ = 0x821B;
	public const int ManualGenerateMipmap_ = 0x8294;
	public const int MapCoherentBit_ = 0x0080;
	public const int MapFlushExplicitBit_ = 0x0010;
	public const int MapInvalidateBufferBit_ = 0x0008;
	public const int MapInvalidateRangeBit_ = 0x0004;
	public const int MapPersistentBit_ = 0x0040;
	public const int MapReadBit_ = 0x0001;
	public const int MapUnsynchronizedBit_ = 0x0020;
	public const int MapWriteBit_ = 0x0002;
	public const int Matrix0Arb_ = 0x88C0;
	public const int Matrix10Arb_ = 0x88CA;
	public const int Matrix11Arb_ = 0x88CB;
	public const int Matrix12Arb_ = 0x88CC;
	public const int Matrix13Arb_ = 0x88CD;
	public const int Matrix14Arb_ = 0x88CE;
	public const int Matrix15Arb_ = 0x88CF;
	public const int Matrix16Arb_ = 0x88D0;
	public const int Matrix17Arb_ = 0x88D1;
	public const int Matrix18Arb_ = 0x88D2;
	public const int Matrix19Arb_ = 0x88D3;
	public const int Matrix1Arb_ = 0x88C1;
	public const int Matrix20Arb_ = 0x88D4;
	public const int Matrix21Arb_ = 0x88D5;
	public const int Matrix22Arb_ = 0x88D6;
	public const int Matrix23Arb_ = 0x88D7;
	public const int Matrix24Arb_ = 0x88D8;
	public const int Matrix25Arb_ = 0x88D9;
	public const int Matrix26Arb_ = 0x88DA;
	public const int Matrix27Arb_ = 0x88DB;
	public const int Matrix28Arb_ = 0x88DC;
	public const int Matrix29Arb_ = 0x88DD;
	public const int Matrix2Arb_ = 0x88C2;
	public const int Matrix30Arb_ = 0x88DE;
	public const int Matrix31Arb_ = 0x88DF;
	public const int Matrix3Arb_ = 0x88C3;
	public const int Matrix4Arb_ = 0x88C4;
	public const int Matrix5Arb_ = 0x88C5;
	public const int Matrix6Arb_ = 0x88C6;
	public const int Matrix7Arb_ = 0x88C7;
	public const int Matrix8Arb_ = 0x88C8;
	public const int Matrix9Arb_ = 0x88C9;
	public const int MatrixStride_ = 0x92FF;
	public const int Max_ = 0x8008;
	public const int Max3dTextureSize_ = 0x8073;
	public const int MaxArrayTextureLayers_ = 0x88FF;
	public const int MaxAtomicCounterBufferBindings_ = 0x92DC;
	public const int MaxAtomicCounterBufferSize_ = 0x92D8;
	public const int MaxClipDistances_ = 0x0D32;
	public const int MaxColorAttachments_ = 0x8CDF;
	public const int MaxColorAttachmentsExt_ = 0x8CDF;
	public const int MaxColorTextureSamples_ = 0x910E;
	public const int MaxCombinedAtomicCounters_ = 0x92D7;
	public const int MaxCombinedAtomicCounterBuffers_ = 0x92D1;
	public const int MaxCombinedComputeUniformComponents_ = 0x8266;
	public const int MaxCombinedDimensions_ = 0x8282;
	public const int MaxCombinedFragmentUniformComponents_ = 0x8A33;
	public const int MaxCombinedGeometryUniformComponents_ = 0x8A32;
	public const int MaxCombinedImageUniforms_ = 0x90CF;
	public const int MaxCombinedImageUnitsAndFragmentOutputs_ = 0x8F39;
	public const int MaxCombinedShaderOutputResources_ = 0x8F39;
	public const int MaxCombinedShaderStorageBlocks_ = 0x90DC;
	public const int MaxCombinedTessControlUniformComponents_ = 0x8E1E;
	public const int MaxCombinedTessEvaluationUniformComponents_ = 0x8E1F;
	public const int MaxCombinedTextureImageUnits_ = 0x8B4D;
	public const int MaxCombinedTextureImageUnitsArb_ = 0x8B4D;
	public const int MaxCombinedUniformBlocks_ = 0x8A2E;
	public const int MaxCombinedVertexUniformComponents_ = 0x8A31;
	public const int MaxComputeAtomicCounters_ = 0x8265;
	public const int MaxComputeAtomicCounterBuffers_ = 0x8264;
	public const int MaxComputeFixedGroupInvocationsArb_ = 0x90EB;
	public const int MaxComputeFixedGroupSizeArb_ = 0x91BF;
	public const int MaxComputeImageUniforms_ = 0x91BD;
	public const int MaxComputeShaderStorageBlocks_ = 0x90DB;
	public const int MaxComputeSharedMemorySize_ = 0x8262;
	public const int MaxComputeTextureImageUnits_ = 0x91BC;
	public const int MaxComputeUniformBlocks_ = 0x91BB;
	public const int MaxComputeUniformComponents_ = 0x8263;
	public const int MaxComputeVariableGroupInvocationsArb_ = 0x9344;
	public const int MaxComputeVariableGroupSizeArb_ = 0x9345;
	public const int MaxComputeWorkGroupCount_ = 0x91BE;
	public const int MaxComputeWorkGroupInvocations_ = 0x90EB;
	public const int MaxComputeWorkGroupSize_ = 0x91BF;
	public const int MaxCubeMapTextureSize_ = 0x851C;
	public const int MaxCubeMapTextureSizeArb_ = 0x851C;
	public const int MaxDebugGroupStackDepth_ = 0x826C;
	public const int MaxDebugLoggedMessages_ = 0x9144;
	public const int MaxDebugLoggedMessagesArb_ = 0x9144;
	public const int MaxDebugMessageLength_ = 0x9143;
	public const int MaxDebugMessageLengthArb_ = 0x9143;
	public const int MaxDepth_ = 0x8280;
	public const int MaxDepthTextureSamples_ = 0x910F;
	public const int MaxDrawBuffers_ = 0x8824;
	public const int MaxDrawBuffersArb_ = 0x8824;
	public const int MaxDualSourceDrawBuffers_ = 0x88FC;
	public const int MaxElementsIndices_ = 0x80E9;
	public const int MaxElementsVertices_ = 0x80E8;
	public const int MaxElementIndex_ = 0x8D6B;
	public const int MaxFragmentAtomicCounters_ = 0x92D6;
	public const int MaxFragmentAtomicCounterBuffers_ = 0x92D0;
	public const int MaxFragmentImageUniforms_ = 0x90CE;
	public const int MaxFragmentInputComponents_ = 0x9125;
	public const int MaxFragmentInterpolationOffset_ = 0x8E5C;
	public const int MaxFragmentShaderStorageBlocks_ = 0x90DA;
	public const int MaxFragmentUniformBlocks_ = 0x8A2D;
	public const int MaxFragmentUniformComponents_ = 0x8B49;
	public const int MaxFragmentUniformComponentsArb_ = 0x8B49;
	public const int MaxFragmentUniformVectors_ = 0x8DFD;
	public const int MaxFramebufferHeight_ = 0x9316;
	public const int MaxFramebufferLayers_ = 0x9317;
	public const int MaxFramebufferSamples_ = 0x9318;
	public const int MaxFramebufferWidth_ = 0x9315;
	public const int MaxGeometryAtomicCounters_ = 0x92D5;
	public const int MaxGeometryAtomicCounterBuffers_ = 0x92CF;
	public const int MaxGeometryImageUniforms_ = 0x90CD;
	public const int MaxGeometryInputComponents_ = 0x9123;
	public const int MaxGeometryOutputComponents_ = 0x9124;
	public const int MaxGeometryOutputVertices_ = 0x8DE0;
	public const int MaxGeometryOutputVerticesArb_ = 0x8DE0;
	public const int MaxGeometryShaderInvocations_ = 0x8E5A;
	public const int MaxGeometryShaderStorageBlocks_ = 0x90D7;
	public const int MaxGeometryTextureImageUnits_ = 0x8C29;
	public const int MaxGeometryTextureImageUnitsArb_ = 0x8C29;
	public const int MaxGeometryTotalOutputComponents_ = 0x8DE1;
	public const int MaxGeometryTotalOutputComponentsArb_ = 0x8DE1;
	public const int MaxGeometryUniformBlocks_ = 0x8A2C;
	public const int MaxGeometryUniformComponents_ = 0x8DDF;
	public const int MaxGeometryUniformComponentsArb_ = 0x8DDF;
	public const int MaxGeometryVaryingComponentsArb_ = 0x8DDD;
	public const int MaxHeight_ = 0x827F;
	public const int MaxImageSamples_ = 0x906D;
	public const int MaxImageUnits_ = 0x8F38;
	public const int MaxIntegerSamples_ = 0x9110;
	public const int MaxLabelLength_ = 0x82E8;
	public const int MaxLayers_ = 0x8281;
	public const int MaxNameLength_ = 0x92F6;
	public const int MaxNumActiveVariables_ = 0x92F7;
	public const int MaxNumCompatibleSubroutines_ = 0x92F8;
	public const int MaxPatchVertices_ = 0x8E7D;
	public const int MaxProgramAddressRegistersArb_ = 0x88B1;
	public const int MaxProgramAluInstructionsArb_ = 0x880B;
	public const int MaxProgramAttribsArb_ = 0x88AD;
	public const int MaxProgramEnvParametersArb_ = 0x88B5;
	public const int MaxProgramInstructionsArb_ = 0x88A1;
	public const int MaxProgramLocalParametersArb_ = 0x88B4;
	public const int MaxProgramMatricesArb_ = 0x862F;
	public const int MaxProgramMatrixStackDepthArb_ = 0x862E;
	public const int MaxProgramNativeAddressRegistersArb_ = 0x88B3;
	public const int MaxProgramNativeAluInstructionsArb_ = 0x880E;
	public const int MaxProgramNativeAttribsArb_ = 0x88AF;
	public const int MaxProgramNativeInstructionsArb_ = 0x88A3;
	public const int MaxProgramNativeParametersArb_ = 0x88AB;
	public const int MaxProgramNativeTemporariesArb_ = 0x88A7;
	public const int MaxProgramNativeTexIndirectionsArb_ = 0x8810;
	public const int MaxProgramNativeTexInstructionsArb_ = 0x880F;
	public const int MaxProgramParametersArb_ = 0x88A9;
	public const int MaxProgramTemporariesArb_ = 0x88A5;
	public const int MaxProgramTexelOffset_ = 0x8905;
	public const int MaxProgramTextureGatherOffset_ = 0x8E5F;
	public const int MaxProgramTexIndirectionsArb_ = 0x880D;
	public const int MaxProgramTexInstructionsArb_ = 0x880C;
	public const int MaxRectangleTextureSize_ = 0x84F8;
	public const int MaxRenderbufferSize_ = 0x84E8;
	public const int MaxRenderbufferSizeExt_ = 0x84E8;
	public const int MaxSamples_ = 0x8D57;
	public const int MaxSamplesExt_ = 0x8D57;
	public const int MaxSampleMaskWords_ = 0x8E59;
	public const int MaxServerWaitTimeout_ = 0x9111;
	public const int MaxShaderStorageBlockSize_ = 0x90DE;
	public const int MaxShaderStorageBufferBindings_ = 0x90DD;
	public const int MaxSubroutines_ = 0x8DE7;
	public const int MaxSubroutineUniformLocations_ = 0x8DE8;
	public const int MaxTessControlAtomicCounters_ = 0x92D3;
	public const int MaxTessControlAtomicCounterBuffers_ = 0x92CD;
	public const int MaxTessControlImageUniforms_ = 0x90CB;
	public const int MaxTessControlInputComponents_ = 0x886C;
	public const int MaxTessControlOutputComponents_ = 0x8E83;
	public const int MaxTessControlShaderStorageBlocks_ = 0x90D8;
	public const int MaxTessControlTextureImageUnits_ = 0x8E81;
	public const int MaxTessControlTotalOutputComponents_ = 0x8E85;
	public const int MaxTessControlUniformBlocks_ = 0x8E89;
	public const int MaxTessControlUniformComponents_ = 0x8E7F;
	public const int MaxTessEvaluationAtomicCounters_ = 0x92D4;
	public const int MaxTessEvaluationAtomicCounterBuffers_ = 0x92CE;
	public const int MaxTessEvaluationImageUniforms_ = 0x90CC;
	public const int MaxTessEvaluationInputComponents_ = 0x886D;
	public const int MaxTessEvaluationOutputComponents_ = 0x8E86;
	public const int MaxTessEvaluationShaderStorageBlocks_ = 0x90D9;
	public const int MaxTessEvaluationTextureImageUnits_ = 0x8E82;
	public const int MaxTessEvaluationUniformBlocks_ = 0x8E8A;
	public const int MaxTessEvaluationUniformComponents_ = 0x8E80;
	public const int MaxTessGenLevel_ = 0x8E7E;
	public const int MaxTessPatchComponents_ = 0x8E84;
	public const int MaxTextureBufferSize_ = 0x8C2B;
	public const int MaxTextureCoordsArb_ = 0x8871;
	public const int MaxTextureImageUnits_ = 0x8872;
	public const int MaxTextureImageUnitsArb_ = 0x8872;
	public const int MaxTextureLodBias_ = 0x84FD;
	public const int MaxTextureMaxAnisotropy_ = 0x84FF;
	public const int MaxTextureMaxAnisotropyExt_ = 0x84FF;
	public const int MaxTextureSize_ = 0x0D33;
	public const int MaxTextureUnitsArb_ = 0x84E2;
	public const int MaxTransformFeedbackBuffers_ = 0x8E70;
	public const int MaxTransformFeedbackInterleavedComponents_ = 0x8C8A;
	public const int MaxTransformFeedbackSeparateAttribs_ = 0x8C8B;
	public const int MaxTransformFeedbackSeparateComponents_ = 0x8C80;
	public const int MaxUniformBlockSize_ = 0x8A30;
	public const int MaxUniformBufferBindings_ = 0x8A2F;
	public const int MaxUniformLocations_ = 0x826E;
	public const int MaxVaryingComponents_ = 0x8B4B;
	public const int MaxVaryingFloats_ = 0x8B4B;
	public const int MaxVaryingFloatsArb_ = 0x8B4B;
	public const int MaxVaryingVectors_ = 0x8DFC;
	public const int MaxVertexAtomicCounters_ = 0x92D2;
	public const int MaxVertexAtomicCounterBuffers_ = 0x92CC;
	public const int MaxVertexAttribs_ = 0x8869;
	public const int MaxVertexAttribsArb_ = 0x8869;
	public const int MaxVertexAttribBindings_ = 0x82DA;
	public const int MaxVertexAttribRelativeOffset_ = 0x82D9;
	public const int MaxVertexImageUniforms_ = 0x90CA;
	public const int MaxVertexOutputComponents_ = 0x9122;
	public const int MaxVertexShaderStorageBlocks_ = 0x90D6;
	public const int MaxVertexStreams_ = 0x8E71;
	public const int MaxVertexTextureImageUnits_ = 0x8B4C;
	public const int MaxVertexTextureImageUnitsArb_ = 0x8B4C;
	public const int MaxVertexUniformBlocks_ = 0x8A2B;
	public const int MaxVertexUniformComponents_ = 0x8B4A;
	public const int MaxVertexUniformComponentsArb_ = 0x8B4A;
	public const int MaxVertexUniformVectors_ = 0x8DFB;
	public const int MaxVertexVaryingComponentsArb_ = 0x8DDE;
	public const int MaxViewports_ = 0x825B;
	public const int MaxViewportDims_ = 0x0D3A;
	public const int MaxWidth_ = 0x827E;
	public const int MediumFloat_ = 0x8DF1;
	public const int MediumInt_ = 0x8DF4;
	public const int Min_ = 0x8007;
	public const int MinorVersion_ = 0x821C;
	public const int MinFragmentInterpolationOffset_ = 0x8E5B;
	public const int MinMapBufferAlignment_ = 0x90BC;
	public const int MinProgramTexelOffset_ = 0x8904;
	public const int MinProgramTextureGatherOffset_ = 0x8E5E;
	public const int MinSampleShadingValue_ = 0x8C37;
	public const int MinSampleShadingValueArb_ = 0x8C37;
	public const int Mipmap_ = 0x8293;
	public const int MirroredRepeat_ = 0x8370;
	public const int MirroredRepeatArb_ = 0x8370;
	public const int MirrorClampExt_ = 0x8742;
	public const int MirrorClampToBorderExt_ = 0x8912;
	public const int MirrorClampToEdge_ = 0x8743;
	public const int MirrorClampToEdgeExt_ = 0x8743;
	public const int Multisample_ = 0x809D;
	public const int MultisampleArb_ = 0x809D;
	public const int MultisampleBitArb_ = 0x20000000;
	public const int MultisampleLineWidthGranularityArb_ = 0x9382;
	public const int MultisampleLineWidthRangeArb_ = 0x9381;
	public const int NamedStringLengthArb_ = 0x8DE9;
	public const int NamedStringTypeArb_ = 0x8DEA;
	public const int NameLength_ = 0x92F9;
	public const int Nand_ = 0x150E;
	public const int Nearest_ = 0x2600;
	public const int NearestMipmapLinear_ = 0x2702;
	public const int NearestMipmapNearest_ = 0x2700;
	public const int Never_ = 0x0200;
	public const int Nicest_ = 0x1102;
	public const int None_ = 0;
	public const int Noop_ = 0x1505;
	public const int Nor_ = 0x1508;
	public const int NormalArrayBufferBindingArb_ = 0x8897;
	public const int NormalMapArb_ = 0x8511;
	public const int Notequal_ = 0x0205;
	public const int NoError_ = 0;
	public const int NumActiveVariables_ = 0x9304;
	public const int NumCompatibleSubroutines_ = 0x8E4A;
	public const int NumCompressedTextureFormats_ = 0x86A2;
	public const int NumCompressedTextureFormatsArb_ = 0x86A2;
	public const int NumExtensions_ = 0x821D;
	public const int NumProgramBinaryFormats_ = 0x87FE;
	public const int NumSampleCounts_ = 0x9380;
	public const int NumShaderBinaryFormats_ = 0x8DF9;
	public const int NumShadingLanguageVersions_ = 0x82E9;
	public const int NumSpirVExtensions_ = 0x9554;
	public const int ObjectActiveAttributesArb_ = 0x8B89;
	public const int ObjectActiveAttributeMaxLengthArb_ = 0x8B8A;
	public const int ObjectActiveUniformsArb_ = 0x8B86;
	public const int ObjectActiveUniformMaxLengthArb_ = 0x8B87;
	public const int ObjectAttachedObjectsArb_ = 0x8B85;
	public const int ObjectCompileStatusArb_ = 0x8B81;
	public const int ObjectDeleteStatusArb_ = 0x8B80;
	public const int ObjectInfoLogLengthArb_ = 0x8B84;
	public const int ObjectLinkStatusArb_ = 0x8B82;
	public const int ObjectShaderSourceLengthArb_ = 0x8B88;
	public const int ObjectSubtypeArb_ = 0x8B4F;
	public const int ObjectType_ = 0x9112;
	public const int ObjectTypeArb_ = 0x8B4E;
	public const int ObjectValidateStatusArb_ = 0x8B83;
	public const int Offset_ = 0x92FC;
	public const int One_ = 1;
	public const int OneMinusConstantAlpha_ = 0x8004;
	public const int OneMinusConstantColor_ = 0x8002;
	public const int OneMinusDstAlpha_ = 0x0305;
	public const int OneMinusDstColor_ = 0x0307;
	public const int OneMinusSrc1Alpha_ = 0x88FB;
	public const int OneMinusSrc1Color_ = 0x88FA;
	public const int OneMinusSrcAlpha_ = 0x0303;
	public const int OneMinusSrcColor_ = 0x0301;
	public const int Or_ = 0x1507;
	public const int OrInverted_ = 0x150D;
	public const int OrReverse_ = 0x150B;
	public const int OutOfMemory_ = 0x0505;
	public const int PackAlignment_ = 0x0D05;
	public const int PackCompressedBlockDepth_ = 0x912D;
	public const int PackCompressedBlockHeight_ = 0x912C;
	public const int PackCompressedBlockSize_ = 0x912E;
	public const int PackCompressedBlockWidth_ = 0x912B;
	public const int PackImageHeight_ = 0x806C;
	public const int PackLsbFirst_ = 0x0D01;
	public const int PackRowLength_ = 0x0D02;
	public const int PackSkipImages_ = 0x806B;
	public const int PackSkipPixels_ = 0x0D04;
	public const int PackSkipRows_ = 0x0D03;
	public const int PackSwapBytes_ = 0x0D00;
	public const int Palette4R5G6B5Oes_ = 0x8B92;
	public const int Palette4Rgb5A1Oes_ = 0x8B94;
	public const int Palette4Rgb8Oes_ = 0x8B90;
	public const int Palette4Rgba4Oes_ = 0x8B93;
	public const int Palette4Rgba8Oes_ = 0x8B91;
	public const int Palette8R5G6B5Oes_ = 0x8B97;
	public const int Palette8Rgb5A1Oes_ = 0x8B99;
	public const int Palette8Rgb8Oes_ = 0x8B95;
	public const int Palette8Rgba4Oes_ = 0x8B98;
	public const int Palette8Rgba8Oes_ = 0x8B96;
	public const int Patches_ = 0x000E;
	public const int PatchDefaultInnerLevel_ = 0x8E73;
	public const int PatchDefaultOuterLevel_ = 0x8E74;
	public const int PatchVertices_ = 0x8E72;
	public const int PixelBufferBarrierBit_ = 0x00000080;
	public const int PixelPackBuffer_ = 0x88EB;
	public const int PixelPackBufferBinding_ = 0x88ED;
	public const int PixelUnpackBuffer_ = 0x88EC;
	public const int PixelUnpackBufferBinding_ = 0x88EF;
	public const int Point_ = 0x1B00;
	public const int Points_ = 0x0000;
	public const int PointFadeThresholdSize_ = 0x8128;
	public const int PointSize_ = 0x0B11;
	public const int PointSizeGranularity_ = 0x0B13;
	public const int PointSizeRange_ = 0x0B12;
	public const int PointSpriteCoordOrigin_ = 0x8CA0;
	public const int PolygonMode_ = 0x0B40;
	public const int PolygonOffsetFactor_ = 0x8038;
	public const int PolygonOffsetFill_ = 0x8037;
	public const int PolygonOffsetLine_ = 0x2A02;
	public const int PolygonOffsetPoint_ = 0x2A01;
	public const int PolygonOffsetUnits_ = 0x2A00;
	public const int PolygonSmooth_ = 0x0B41;
	public const int PolygonSmoothHint_ = 0x0C53;
	public const int PrimitivesGenerated_ = 0x8C87;
	public const int PrimitivesSubmitted_ = 0x82EF;
	public const int PrimitivesSubmittedArb_ = 0x82EF;
	public const int PrimitiveBoundingBoxArb_ = 0x92BE;
	public const int PrimitiveRestart_ = 0x8F9D;
	public const int PrimitiveRestartFixedIndex_ = 0x8D69;
	public const int PrimitiveRestartIndex_ = 0x8F9E;
	public const int Program_ = 0x82E2;
	public const int ProgrammableSampleLocationArb_ = 0x9341;
	public const int ProgrammableSampleLocationTableSizeArb_ = 0x9340;
	public const int ProgramAddressRegistersArb_ = 0x88B0;
	public const int ProgramAluInstructionsArb_ = 0x8805;
	public const int ProgramAttribsArb_ = 0x88AC;
	public const int ProgramBinaryFormats_ = 0x87FF;
	public const int ProgramBinaryLength_ = 0x8741;
	public const int ProgramBinaryRetrievableHint_ = 0x8257;
	public const int ProgramBindingArb_ = 0x8677;
	public const int ProgramErrorPositionArb_ = 0x864B;
	public const int ProgramErrorStringArb_ = 0x8874;
	public const int ProgramFormatArb_ = 0x8876;
	public const int ProgramFormatAsciiArb_ = 0x8875;
	public const int ProgramInput_ = 0x92E3;
	public const int ProgramInstructionsArb_ = 0x88A0;
	public const int ProgramLengthArb_ = 0x8627;
	public const int ProgramNativeAddressRegistersArb_ = 0x88B2;
	public const int ProgramNativeAluInstructionsArb_ = 0x8808;
	public const int ProgramNativeAttribsArb_ = 0x88AE;
	public const int ProgramNativeInstructionsArb_ = 0x88A2;
	public const int ProgramNativeParametersArb_ = 0x88AA;
	public const int ProgramNativeTemporariesArb_ = 0x88A6;
	public const int ProgramNativeTexIndirectionsArb_ = 0x880A;
	public const int ProgramNativeTexInstructionsArb_ = 0x8809;
	public const int ProgramObjectArb_ = 0x8B40;
	public const int ProgramOutput_ = 0x92E4;
	public const int ProgramParametersArb_ = 0x88A8;
	public const int ProgramPipeline_ = 0x82E4;
	public const int ProgramPipelineBinding_ = 0x825A;
	public const int ProgramPointSize_ = 0x8642;
	public const int ProgramPointSizeArb_ = 0x8642;
	public const int ProgramSeparable_ = 0x8258;
	public const int ProgramStringArb_ = 0x8628;
	public const int ProgramTemporariesArb_ = 0x88A4;
	public const int ProgramTexIndirectionsArb_ = 0x8807;
	public const int ProgramTexInstructionsArb_ = 0x8806;
	public const int ProgramUnderNativeLimitsArb_ = 0x88B6;
	public const int ProvokingVertex_ = 0x8E4F;
	public const int ProxyTexture1d_ = 0x8063;
	public const int ProxyTexture1dArray_ = 0x8C19;
	public const int ProxyTexture2d_ = 0x8064;
	public const int ProxyTexture2dArray_ = 0x8C1B;
	public const int ProxyTexture2dMultisample_ = 0x9101;
	public const int ProxyTexture2dMultisampleArray_ = 0x9103;
	public const int ProxyTexture3d_ = 0x8070;
	public const int ProxyTextureCubeMap_ = 0x851B;
	public const int ProxyTextureCubeMapArb_ = 0x851B;
	public const int ProxyTextureCubeMapArray_ = 0x900B;
	public const int ProxyTextureCubeMapArrayArb_ = 0x900B;
	public const int ProxyTextureRectangle_ = 0x84F7;
	public const int Quads_ = 0x0007;
	public const int QuadsFollowProvokingVertexConvention_ = 0x8E4C;
	public const int Query_ = 0x82E3;
	public const int QueryBuffer_ = 0x9192;
	public const int QueryBufferBarrierBit_ = 0x00008000;
	public const int QueryBufferBinding_ = 0x9193;
	public const int QueryByRegionNoWait_ = 0x8E16;
	public const int QueryByRegionWait_ = 0x8E15;
	public const int QueryCounterBits_ = 0x8864;
	public const int QueryCounterBitsArb_ = 0x8864;
	public const int QueryNoWait_ = 0x8E14;
	public const int QueryResult_ = 0x8866;
	public const int QueryResultArb_ = 0x8866;
	public const int QueryResultAvailable_ = 0x8867;
	public const int QueryResultAvailableArb_ = 0x8867;
	public const int QueryResultNoWait_ = 0x9194;
	public const int QueryTarget_ = 0x82EA;
	public const int QueryWait_ = 0x8E13;
	public const int R11fG11fB10f_ = 0x8C3A;
	public const int R16_ = 0x822A;
	public const int R16f_ = 0x822D;
	public const int R16i_ = 0x8233;
	public const int R16ui_ = 0x8234;
	public const int R16Snorm_ = 0x8F98;
	public const int R32f_ = 0x822E;
	public const int R32i_ = 0x8235;
	public const int R32ui_ = 0x8236;
	public const int R3G3B2_ = 0x2A10;
	public const int R8_ = 0x8229;
	public const int R8i_ = 0x8231;
	public const int R8ui_ = 0x8232;
	public const int R8Snorm_ = 0x8F94;
	public const int RasterizerDiscard_ = 0x8C89;
	public const int ReadBuffer_ = 0x0C02;
	public const int ReadFramebuffer_ = 0x8CA8;
	public const int ReadFramebufferBinding_ = 0x8CAA;
	public const int ReadFramebufferBindingExt_ = 0x8CAA;
	public const int ReadFramebufferExt_ = 0x8CA8;
	public const int ReadOnly_ = 0x88B8;
	public const int ReadOnlyArb_ = 0x88B8;
	public const int ReadPixels_ = 0x828C;
	public const int ReadPixelsFormat_ = 0x828D;
	public const int ReadPixelsType_ = 0x828E;
	public const int ReadWrite_ = 0x88BA;
	public const int ReadWriteArb_ = 0x88BA;
	public const int Red_ = 0x1903;
	public const int RedInteger_ = 0x8D94;
	public const int ReferencedByComputeShader_ = 0x930B;
	public const int ReferencedByFragmentShader_ = 0x930A;
	public const int ReferencedByGeometryShader_ = 0x9309;
	public const int ReferencedByTessControlShader_ = 0x9307;
	public const int ReferencedByTessEvaluationShader_ = 0x9308;
	public const int ReferencedByVertexShader_ = 0x9306;
	public const int ReflectionMapArb_ = 0x8512;
	public const int Renderbuffer_ = 0x8D41;
	public const int RenderbufferAlphaSize_ = 0x8D53;
	public const int RenderbufferAlphaSizeExt_ = 0x8D53;
	public const int RenderbufferBinding_ = 0x8CA7;
	public const int RenderbufferBindingExt_ = 0x8CA7;
	public const int RenderbufferBlueSize_ = 0x8D52;
	public const int RenderbufferBlueSizeExt_ = 0x8D52;
	public const int RenderbufferDepthSize_ = 0x8D54;
	public const int RenderbufferDepthSizeExt_ = 0x8D54;
	public const int RenderbufferExt_ = 0x8D41;
	public const int RenderbufferGreenSize_ = 0x8D51;
	public const int RenderbufferGreenSizeExt_ = 0x8D51;
	public const int RenderbufferHeight_ = 0x8D43;
	public const int RenderbufferHeightExt_ = 0x8D43;
	public const int RenderbufferInternalFormat_ = 0x8D44;
	public const int RenderbufferInternalFormatExt_ = 0x8D44;
	public const int RenderbufferRedSize_ = 0x8D50;
	public const int RenderbufferRedSizeExt_ = 0x8D50;
	public const int RenderbufferSamples_ = 0x8CAB;
	public const int RenderbufferSamplesExt_ = 0x8CAB;
	public const int RenderbufferStencilSize_ = 0x8D55;
	public const int RenderbufferStencilSizeExt_ = 0x8D55;
	public const int RenderbufferWidth_ = 0x8D42;
	public const int RenderbufferWidthExt_ = 0x8D42;
	public const int Renderer_ = 0x1F01;
	public const int Repeat_ = 0x2901;
	public const int Replace_ = 0x1E01;
	public const int Rg_ = 0x8227;
	public const int Rg16_ = 0x822C;
	public const int Rg16f_ = 0x822F;
	public const int Rg16i_ = 0x8239;
	public const int Rg16ui_ = 0x823A;
	public const int Rg16Snorm_ = 0x8F99;
	public const int Rg32f_ = 0x8230;
	public const int Rg32i_ = 0x823B;
	public const int Rg32ui_ = 0x823C;
	public const int Rg8_ = 0x822B;
	public const int Rg8i_ = 0x8237;
	public const int Rg8ui_ = 0x8238;
	public const int Rg8Snorm_ = 0x8F95;
	public const int Rgb_ = 0x1907;
	public const int Rgb10_ = 0x8052;
	public const int Rgb10A2_ = 0x8059;
	public const int Rgb10A2ui_ = 0x906F;
	public const int Rgb12_ = 0x8053;
	public const int Rgb16_ = 0x8054;
	public const int Rgb16f_ = 0x881B;
	public const int Rgb16fArb_ = 0x881B;
	public const int Rgb16i_ = 0x8D89;
	public const int Rgb16ui_ = 0x8D77;
	public const int Rgb16Snorm_ = 0x8F9A;
	public const int Rgb32f_ = 0x8815;
	public const int Rgb32fArb_ = 0x8815;
	public const int Rgb32i_ = 0x8D83;
	public const int Rgb32ui_ = 0x8D71;
	public const int Rgb4_ = 0x804F;
	public const int Rgb5_ = 0x8050;
	public const int Rgb565_ = 0x8D62;
	public const int Rgb5A1_ = 0x8057;
	public const int Rgb8_ = 0x8051;
	public const int Rgb8i_ = 0x8D8F;
	public const int Rgb8ui_ = 0x8D7D;
	public const int Rgb8Snorm_ = 0x8F96;
	public const int Rgb9E5_ = 0x8C3D;
	public const int Rgba_ = 0x1908;
	public const int Rgba12_ = 0x805A;
	public const int Rgba16_ = 0x805B;
	public const int Rgba16f_ = 0x881A;
	public const int Rgba16fArb_ = 0x881A;
	public const int Rgba16i_ = 0x8D88;
	public const int Rgba16ui_ = 0x8D76;
	public const int Rgba16Snorm_ = 0x8F9B;
	public const int Rgba2_ = 0x8055;
	public const int Rgba32f_ = 0x8814;
	public const int Rgba32fArb_ = 0x8814;
	public const int Rgba32i_ = 0x8D82;
	public const int Rgba32ui_ = 0x8D70;
	public const int Rgba4_ = 0x8056;
	public const int Rgba8_ = 0x8058;
	public const int Rgba8i_ = 0x8D8E;
	public const int Rgba8ui_ = 0x8D7C;
	public const int Rgba8Snorm_ = 0x8F97;
	public const int RgbaFloatModeArb_ = 0x8820;
	public const int RgbaInteger_ = 0x8D99;
	public const int RgbInteger_ = 0x8D98;
	public const int RgInteger_ = 0x8228;
	public const int Right_ = 0x0407;
	public const int Sampler_ = 0x82E6;
	public const int Sampler1d_ = 0x8B5D;
	public const int Sampler1dArb_ = 0x8B5D;
	public const int Sampler1dArray_ = 0x8DC0;
	public const int Sampler1dArrayShadow_ = 0x8DC3;
	public const int Sampler1dShadow_ = 0x8B61;
	public const int Sampler1dShadowArb_ = 0x8B61;
	public const int Sampler2d_ = 0x8B5E;
	public const int Sampler2dArb_ = 0x8B5E;
	public const int Sampler2dArray_ = 0x8DC1;
	public const int Sampler2dArrayShadow_ = 0x8DC4;
	public const int Sampler2dMultisample_ = 0x9108;
	public const int Sampler2dMultisampleArray_ = 0x910B;
	public const int Sampler2dRect_ = 0x8B63;
	public const int Sampler2dRectArb_ = 0x8B63;
	public const int Sampler2dRectShadow_ = 0x8B64;
	public const int Sampler2dRectShadowArb_ = 0x8B64;
	public const int Sampler2dShadow_ = 0x8B62;
	public const int Sampler2dShadowArb_ = 0x8B62;
	public const int Sampler3d_ = 0x8B5F;
	public const int Sampler3dArb_ = 0x8B5F;
	public const int SamplerBinding_ = 0x8919;
	public const int SamplerBuffer_ = 0x8DC2;
	public const int SamplerCube_ = 0x8B60;
	public const int SamplerCubeArb_ = 0x8B60;
	public const int SamplerCubeMapArray_ = 0x900C;
	public const int SamplerCubeMapArrayArb_ = 0x900C;
	public const int SamplerCubeMapArrayShadow_ = 0x900D;
	public const int SamplerCubeMapArrayShadowArb_ = 0x900D;
	public const int SamplerCubeShadow_ = 0x8DC5;
	public const int Samples_ = 0x80A9;
	public const int SamplesArb_ = 0x80A9;
	public const int SamplesPassed_ = 0x8914;
	public const int SamplesPassedArb_ = 0x8914;
	public const int SampleAlphaToCoverage_ = 0x809E;
	public const int SampleAlphaToCoverageArb_ = 0x809E;
	public const int SampleAlphaToOne_ = 0x809F;
	public const int SampleAlphaToOneArb_ = 0x809F;
	public const int SampleBuffers_ = 0x80A8;
	public const int SampleBuffersArb_ = 0x80A8;
	public const int SampleCoverage_ = 0x80A0;
	public const int SampleCoverageArb_ = 0x80A0;
	public const int SampleCoverageInvert_ = 0x80AB;
	public const int SampleCoverageInvertArb_ = 0x80AB;
	public const int SampleCoverageValue_ = 0x80AA;
	public const int SampleCoverageValueArb_ = 0x80AA;
	public const int SampleLocationArb_ = 0x8E50;
	public const int SampleLocationPixelGridHeightArb_ = 0x933F;
	public const int SampleLocationPixelGridWidthArb_ = 0x933E;
	public const int SampleLocationSubpixelBitsArb_ = 0x933D;
	public const int SampleMask_ = 0x8E51;
	public const int SampleMaskValue_ = 0x8E52;
	public const int SamplePosition_ = 0x8E50;
	public const int SampleShading_ = 0x8C36;
	public const int SampleShadingArb_ = 0x8C36;
	public const int ScissorBox_ = 0x0C10;
	public const int ScissorTest_ = 0x0C11;
	public const int SecondaryColorArrayBufferBindingArb_ = 0x889C;
	public const int SeparateAttribs_ = 0x8C8D;
	public const int Set_ = 0x150F;
	public const int Shader_ = 0x82E1;
	public const int ShaderBinaryFormats_ = 0x8DF8;
	public const int ShaderBinaryFormatSpirV_ = 0x9551;
	public const int ShaderBinaryFormatSpirVArb_ = 0x9551;
	public const int ShaderCompiler_ = 0x8DFA;
	public const int ShaderImageAccessBarrierBit_ = 0x00000020;
	public const int ShaderImageAtomic_ = 0x82A6;
	public const int ShaderImageLoad_ = 0x82A4;
	public const int ShaderImageStore_ = 0x82A5;
	public const int ShaderIncludeArb_ = 0x8DAE;
	public const int ShaderObjectArb_ = 0x8B48;
	public const int ShaderSourceLength_ = 0x8B88;
	public const int ShaderStorageBarrierBit_ = 0x00002000;
	public const int ShaderStorageBlock_ = 0x92E6;
	public const int ShaderStorageBuffer_ = 0x90D2;
	public const int ShaderStorageBufferBinding_ = 0x90D3;
	public const int ShaderStorageBufferOffsetAlignment_ = 0x90DF;
	public const int ShaderStorageBufferSize_ = 0x90D5;
	public const int ShaderStorageBufferStart_ = 0x90D4;
	public const int ShaderType_ = 0x8B4F;
	public const int ShadingLanguageVersion_ = 0x8B8C;
	public const int ShadingLanguageVersionArb_ = 0x8B8C;
	public const int Short_ = 0x1402;
	public const int Signaled_ = 0x9119;
	public const int SignedNormalized_ = 0x8F9C;
	public const int SimultaneousTextureAndDepthTest_ = 0x82AC;
	public const int SimultaneousTextureAndDepthWrite_ = 0x82AE;
	public const int SimultaneousTextureAndStencilTest_ = 0x82AD;
	public const int SimultaneousTextureAndStencilWrite_ = 0x82AF;
	public const int SmoothLineWidthGranularity_ = 0x0B23;
	public const int SmoothLineWidthRange_ = 0x0B22;
	public const int SmoothPointSizeGranularity_ = 0x0B13;
	public const int SmoothPointSizeRange_ = 0x0B12;
	public const int Source1Alpha_ = 0x8589;
	public const int SpirVBinary_ = 0x9552;
	public const int SpirVBinaryArb_ = 0x9552;
	public const int SpirVExtensions_ = 0x9553;
	public const int Src1Alpha_ = 0x8589;
	public const int Src1Color_ = 0x88F9;
	public const int SrcAlpha_ = 0x0302;
	public const int SrcAlphaSaturate_ = 0x0308;
	public const int SrcColor_ = 0x0300;
	public const int Srgb_ = 0x8C40;
	public const int Srgb8_ = 0x8C41;
	public const int Srgb8Alpha8_ = 0x8C43;
	public const int SrgbAlpha_ = 0x8C42;
	public const int SrgbDecodeArb_ = 0x8299;
	public const int SrgbRead_ = 0x8297;
	public const int SrgbWrite_ = 0x8298;
	public const int StackOverflow_ = 0x0503;
	public const int StackUnderflow_ = 0x0504;
	public const int StaticCopy_ = 0x88E6;
	public const int StaticCopyArb_ = 0x88E6;
	public const int StaticDraw_ = 0x88E4;
	public const int StaticDrawArb_ = 0x88E4;
	public const int StaticRead_ = 0x88E5;
	public const int StaticReadArb_ = 0x88E5;
	public const int Stencil_ = 0x1802;
	public const int StencilAttachment_ = 0x8D20;
	public const int StencilAttachmentExt_ = 0x8D20;
	public const int StencilBackFail_ = 0x8801;
	public const int StencilBackFunc_ = 0x8800;
	public const int StencilBackPassDepthFail_ = 0x8802;
	public const int StencilBackPassDepthPass_ = 0x8803;
	public const int StencilBackRef_ = 0x8CA3;
	public const int StencilBackValueMask_ = 0x8CA4;
	public const int StencilBackWritemask_ = 0x8CA5;
	public const int StencilBufferBit_ = 0x00000400;
	public const int StencilClearValue_ = 0x0B91;
	public const int StencilComponents_ = 0x8285;
	public const int StencilFail_ = 0x0B94;
	public const int StencilFunc_ = 0x0B92;
	public const int StencilIndex_ = 0x1901;
	public const int StencilIndex1_ = 0x8D46;
	public const int StencilIndex16_ = 0x8D49;
	public const int StencilIndex16Ext_ = 0x8D49;
	public const int StencilIndex1Ext_ = 0x8D46;
	public const int StencilIndex4_ = 0x8D47;
	public const int StencilIndex4Ext_ = 0x8D47;
	public const int StencilIndex8_ = 0x8D48;
	public const int StencilIndex8Ext_ = 0x8D48;
	public const int StencilPassDepthFail_ = 0x0B95;
	public const int StencilPassDepthPass_ = 0x0B96;
	public const int StencilRef_ = 0x0B97;
	public const int StencilRenderable_ = 0x8288;
	public const int StencilTest_ = 0x0B90;
	public const int StencilValueMask_ = 0x0B93;
	public const int StencilWritemask_ = 0x0B98;
	public const int Stereo_ = 0x0C33;
	public const int StreamCopy_ = 0x88E2;
	public const int StreamCopyArb_ = 0x88E2;
	public const int StreamDraw_ = 0x88E0;
	public const int StreamDrawArb_ = 0x88E0;
	public const int StreamRead_ = 0x88E1;
	public const int StreamReadArb_ = 0x88E1;
	public const int SubpixelBits_ = 0x0D50;
	public const int SyncCondition_ = 0x9113;
	public const int SyncFence_ = 0x9116;
	public const int SyncFlags_ = 0x9115;
	public const int SyncFlushCommandsBit_ = 0x00000001;
	public const int SyncGpuCommandsComplete_ = 0x9117;
	public const int SyncStatus_ = 0x9114;
	public const int TessControlOutputVertices_ = 0x8E75;
	public const int TessControlShader_ = 0x8E88;
	public const int TessControlShaderBit_ = 0x00000008;
	public const int TessControlShaderPatches_ = 0x82F1;
	public const int TessControlShaderPatchesArb_ = 0x82F1;
	public const int TessControlSubroutine_ = 0x92E9;
	public const int TessControlSubroutineUniform_ = 0x92EF;
	public const int TessControlTexture_ = 0x829C;
	public const int TessEvaluationShader_ = 0x8E87;
	public const int TessEvaluationShaderBit_ = 0x00000010;
	public const int TessEvaluationShaderInvocations_ = 0x82F2;
	public const int TessEvaluationShaderInvocationsArb_ = 0x82F2;
	public const int TessEvaluationSubroutine_ = 0x92EA;
	public const int TessEvaluationSubroutineUniform_ = 0x92F0;
	public const int TessEvaluationTexture_ = 0x829D;
	public const int TessGenMode_ = 0x8E76;
	public const int TessGenPointMode_ = 0x8E79;
	public const int TessGenSpacing_ = 0x8E77;
	public const int TessGenVertexOrder_ = 0x8E78;
	public const int Texture_ = 0x1702;
	public const int Texture0_ = 0x84C0;
	public const int Texture0Arb_ = 0x84C0;
	public const int Texture1_ = 0x84C1;
	public const int Texture10_ = 0x84CA;
	public const int Texture10Arb_ = 0x84CA;
	public const int Texture11_ = 0x84CB;
	public const int Texture11Arb_ = 0x84CB;
	public const int Texture12_ = 0x84CC;
	public const int Texture12Arb_ = 0x84CC;
	public const int Texture13_ = 0x84CD;
	public const int Texture13Arb_ = 0x84CD;
	public const int Texture14_ = 0x84CE;
	public const int Texture14Arb_ = 0x84CE;
	public const int Texture15_ = 0x84CF;
	public const int Texture15Arb_ = 0x84CF;
	public const int Texture16_ = 0x84D0;
	public const int Texture16Arb_ = 0x84D0;
	public const int Texture17_ = 0x84D1;
	public const int Texture17Arb_ = 0x84D1;
	public const int Texture18_ = 0x84D2;
	public const int Texture18Arb_ = 0x84D2;
	public const int Texture19_ = 0x84D3;
	public const int Texture19Arb_ = 0x84D3;
	public const int Texture1Arb_ = 0x84C1;
	public const int Texture2_ = 0x84C2;
	public const int Texture20_ = 0x84D4;
	public const int Texture20Arb_ = 0x84D4;
	public const int Texture21_ = 0x84D5;
	public const int Texture21Arb_ = 0x84D5;
	public const int Texture22_ = 0x84D6;
	public const int Texture22Arb_ = 0x84D6;
	public const int Texture23_ = 0x84D7;
	public const int Texture23Arb_ = 0x84D7;
	public const int Texture24_ = 0x84D8;
	public const int Texture24Arb_ = 0x84D8;
	public const int Texture25_ = 0x84D9;
	public const int Texture25Arb_ = 0x84D9;
	public const int Texture26_ = 0x84DA;
	public const int Texture26Arb_ = 0x84DA;
	public const int Texture27_ = 0x84DB;
	public const int Texture27Arb_ = 0x84DB;
	public const int Texture28_ = 0x84DC;
	public const int Texture28Arb_ = 0x84DC;
	public const int Texture29_ = 0x84DD;
	public const int Texture29Arb_ = 0x84DD;
	public const int Texture2Arb_ = 0x84C2;
	public const int Texture3_ = 0x84C3;
	public const int Texture30_ = 0x84DE;
	public const int Texture30Arb_ = 0x84DE;
	public const int Texture31_ = 0x84DF;
	public const int Texture31Arb_ = 0x84DF;
	public const int Texture3Arb_ = 0x84C3;
	public const int Texture4_ = 0x84C4;
	public const int Texture4Arb_ = 0x84C4;
	public const int Texture5_ = 0x84C5;
	public const int Texture5Arb_ = 0x84C5;
	public const int Texture6_ = 0x84C6;
	public const int Texture6Arb_ = 0x84C6;
	public const int Texture7_ = 0x84C7;
	public const int Texture7Arb_ = 0x84C7;
	public const int Texture8_ = 0x84C8;
	public const int Texture8Arb_ = 0x84C8;
	public const int Texture9_ = 0x84C9;
	public const int Texture9Arb_ = 0x84C9;
	public const int Texture1d_ = 0x0DE0;
	public const int Texture1dArray_ = 0x8C18;
	public const int Texture2d_ = 0x0DE1;
	public const int Texture2dArray_ = 0x8C1A;
	public const int Texture2dMultisample_ = 0x9100;
	public const int Texture2dMultisampleArray_ = 0x9102;
	public const int Texture3d_ = 0x806F;
	public const int TextureAlphaSize_ = 0x805F;
	public const int TextureAlphaType_ = 0x8C13;
	public const int TextureAlphaTypeArb_ = 0x8C13;
	public const int TextureBaseLevel_ = 0x813C;
	public const int TextureBinding1d_ = 0x8068;
	public const int TextureBinding1dArray_ = 0x8C1C;
	public const int TextureBinding2d_ = 0x8069;
	public const int TextureBinding2dArray_ = 0x8C1D;
	public const int TextureBinding2dMultisample_ = 0x9104;
	public const int TextureBinding2dMultisampleArray_ = 0x9105;
	public const int TextureBinding3d_ = 0x806A;
	public const int TextureBindingBuffer_ = 0x8C2C;
	public const int TextureBindingCubeMap_ = 0x8514;
	public const int TextureBindingCubeMapArb_ = 0x8514;
	public const int TextureBindingCubeMapArray_ = 0x900A;
	public const int TextureBindingCubeMapArrayArb_ = 0x900A;
	public const int TextureBindingRectangle_ = 0x84F6;
	public const int TextureBlueSize_ = 0x805E;
	public const int TextureBlueType_ = 0x8C12;
	public const int TextureBlueTypeArb_ = 0x8C12;
	public const int TextureBorderColor_ = 0x1004;
	public const int TextureBuffer_ = 0x8C2A;
	public const int TextureBufferDataStoreBinding_ = 0x8C2D;
	public const int TextureBufferOffset_ = 0x919D;
	public const int TextureBufferOffsetAlignment_ = 0x919F;
	public const int TextureBufferSize_ = 0x919E;
	public const int TextureCompareFunc_ = 0x884D;
	public const int TextureCompareMode_ = 0x884C;
	public const int TextureCompressed_ = 0x86A1;
	public const int TextureCompressedArb_ = 0x86A1;
	public const int TextureCompressedBlockHeight_ = 0x82B2;
	public const int TextureCompressedBlockSize_ = 0x82B3;
	public const int TextureCompressedBlockWidth_ = 0x82B1;
	public const int TextureCompressedImageSize_ = 0x86A0;
	public const int TextureCompressedImageSizeArb_ = 0x86A0;
	public const int TextureCompressionHint_ = 0x84EF;
	public const int TextureCompressionHintArb_ = 0x84EF;
	public const int TextureCoordArrayBufferBindingArb_ = 0x889A;
	public const int TextureCubeMap_ = 0x8513;
	public const int TextureCubeMapArb_ = 0x8513;
	public const int TextureCubeMapArray_ = 0x9009;
	public const int TextureCubeMapArrayArb_ = 0x9009;
	public const int TextureCubeMapNegativeX_ = 0x8516;
	public const int TextureCubeMapNegativeXArb_ = 0x8516;
	public const int TextureCubeMapNegativeY_ = 0x8518;
	public const int TextureCubeMapNegativeYArb_ = 0x8518;
	public const int TextureCubeMapNegativeZ_ = 0x851A;
	public const int TextureCubeMapNegativeZArb_ = 0x851A;
	public const int TextureCubeMapPositiveX_ = 0x8515;
	public const int TextureCubeMapPositiveXArb_ = 0x8515;
	public const int TextureCubeMapPositiveY_ = 0x8517;
	public const int TextureCubeMapPositiveYArb_ = 0x8517;
	public const int TextureCubeMapPositiveZ_ = 0x8519;
	public const int TextureCubeMapPositiveZArb_ = 0x8519;
	public const int TextureCubeMapSeamless_ = 0x884F;
	public const int TextureDepth_ = 0x8071;
	public const int TextureDepthSize_ = 0x884A;
	public const int TextureDepthSizeArb_ = 0x884A;
	public const int TextureDepthType_ = 0x8C16;
	public const int TextureDepthTypeArb_ = 0x8C16;
	public const int TextureFetchBarrierBit_ = 0x00000008;
	public const int TextureFixedSampleLocations_ = 0x9107;
	public const int TextureGather_ = 0x82A2;
	public const int TextureGatherShadow_ = 0x82A3;
	public const int TextureGreenSize_ = 0x805D;
	public const int TextureGreenType_ = 0x8C11;
	public const int TextureGreenTypeArb_ = 0x8C11;
	public const int TextureHeight_ = 0x1001;
	public const int TextureImageFormat_ = 0x828F;
	public const int TextureImageType_ = 0x8290;
	public const int TextureImmutableFormat_ = 0x912F;
	public const int TextureImmutableLevels_ = 0x82DF;
	public const int TextureIntensityTypeArb_ = 0x8C15;
	public const int TextureInternalFormat_ = 0x1003;
	public const int TextureLodBias_ = 0x8501;
	public const int TextureLuminanceTypeArb_ = 0x8C14;
	public const int TextureMagFilter_ = 0x2800;
	public const int TextureMaxAnisotropy_ = 0x84FE;
	public const int TextureMaxAnisotropyExt_ = 0x84FE;
	public const int TextureMaxLevel_ = 0x813D;
	public const int TextureMaxLod_ = 0x813B;
	public const int TextureMinFilter_ = 0x2801;
	public const int TextureMinLod_ = 0x813A;
	public const int TextureRectangle_ = 0x84F5;
	public const int TextureReductionModeArb_ = 0x9366;
	public const int TextureRedSize_ = 0x805C;
	public const int TextureRedType_ = 0x8C10;
	public const int TextureRedTypeArb_ = 0x8C10;
	public const int TextureSamples_ = 0x9106;
	public const int TextureShadow_ = 0x82A1;
	public const int TextureSharedSize_ = 0x8C3F;
	public const int TextureStencilSize_ = 0x88F1;
	public const int TextureSwizzleA_ = 0x8E45;
	public const int TextureSwizzleB_ = 0x8E44;
	public const int TextureSwizzleG_ = 0x8E43;
	public const int TextureSwizzleR_ = 0x8E42;
	public const int TextureSwizzleRgba_ = 0x8E46;
	public const int TextureTarget_ = 0x1006;
	public const int TextureUpdateBarrierBit_ = 0x00000100;
	public const int TextureView_ = 0x82B5;
	public const int TextureViewMinLayer_ = 0x82DD;
	public const int TextureViewMinLevel_ = 0x82DB;
	public const int TextureViewNumLayers_ = 0x82DE;
	public const int TextureViewNumLevels_ = 0x82DC;
	public const int TextureWidth_ = 0x1000;
	public const int TextureWrapR_ = 0x8072;
	public const int TextureWrapS_ = 0x2802;
	public const int TextureWrapT_ = 0x2803;
	public const int TimeoutExpired_ = 0x911B;
	public const ulong TimeoutIgnored_ = 0xFFFFFFFFFFFFFFFF;
	public const int Timestamp_ = 0x8E28;
	public const int TimeElapsed_ = 0x88BF;
	public const int TopLevelArraySize_ = 0x930C;
	public const int TopLevelArrayStride_ = 0x930D;
	public const int TransformFeedback_ = 0x8E22;
	public const int TransformFeedbackActive_ = 0x8E24;
	public const int TransformFeedbackBarrierBit_ = 0x00000800;
	public const int TransformFeedbackBinding_ = 0x8E25;
	public const int TransformFeedbackBuffer_ = 0x8C8E;
	public const int TransformFeedbackBufferActive_ = 0x8E24;
	public const int TransformFeedbackBufferBinding_ = 0x8C8F;
	public const int TransformFeedbackBufferIndex_ = 0x934B;
	public const int TransformFeedbackBufferMode_ = 0x8C7F;
	public const int TransformFeedbackBufferPaused_ = 0x8E23;
	public const int TransformFeedbackBufferSize_ = 0x8C85;
	public const int TransformFeedbackBufferStart_ = 0x8C84;
	public const int TransformFeedbackBufferStride_ = 0x934C;
	public const int TransformFeedbackPaused_ = 0x8E23;
	public const int TransformFeedbackPrimitivesWritten_ = 0x8C88;
	public const int TransformFeedbackVarying_ = 0x92F4;
	public const int TransformFeedbackVaryings_ = 0x8C83;
	public const int TransformFeedbackVaryingMaxLength_ = 0x8C76;
	public const int TransposeColorMatrixArb_ = 0x84E6;
	public const int TransposeCurrentMatrixArb_ = 0x88B7;
	public const int TransposeModelviewMatrixArb_ = 0x84E3;
	public const int TransposeProjectionMatrixArb_ = 0x84E4;
	public const int TransposeTextureMatrixArb_ = 0x84E5;
	public const int Triangles_ = 0x0004;
	public const int TrianglesAdjacency_ = 0x000C;
	public const int TrianglesAdjacencyArb_ = 0x000C;
	public const int TriangleFan_ = 0x0006;
	public const int TriangleStrip_ = 0x0005;
	public const int TriangleStripAdjacency_ = 0x000D;
	public const int TriangleStripAdjacencyArb_ = 0x000D;
	public const int True_ = 1;
	public const int Type_ = 0x92FA;
	public const int UndefinedVertex_ = 0x8260;
	public const int Uniform_ = 0x92E1;
	public const int UniformArrayStride_ = 0x8A3C;
	public const int UniformAtomicCounterBufferIndex_ = 0x92DA;
	public const int UniformBarrierBit_ = 0x00000004;
	public const int UniformBlock_ = 0x92E2;
	public const int UniformBlockActiveUniforms_ = 0x8A42;
	public const int UniformBlockActiveUniformIndices_ = 0x8A43;
	public const int UniformBlockBinding_ = 0x8A3F;
	public const int UniformBlockDataSize_ = 0x8A40;
	public const int UniformBlockIndex_ = 0x8A3A;
	public const int UniformBlockNameLength_ = 0x8A41;
	public const int UniformBlockReferencedByComputeShader_ = 0x90EC;
	public const int UniformBlockReferencedByFragmentShader_ = 0x8A46;
	public const int UniformBlockReferencedByGeometryShader_ = 0x8A45;
	public const int UniformBlockReferencedByTessControlShader_ = 0x84F0;
	public const int UniformBlockReferencedByTessEvaluationShader_ = 0x84F1;
	public const int UniformBlockReferencedByVertexShader_ = 0x8A44;
	public const int UniformBuffer_ = 0x8A11;
	public const int UniformBufferBinding_ = 0x8A28;
	public const int UniformBufferOffsetAlignment_ = 0x8A34;
	public const int UniformBufferSize_ = 0x8A2A;
	public const int UniformBufferStart_ = 0x8A29;
	public const int UniformIsRowMajor_ = 0x8A3E;
	public const int UniformMatrixStride_ = 0x8A3D;
	public const int UniformNameLength_ = 0x8A39;
	public const int UniformOffset_ = 0x8A3B;
	public const int UniformSize_ = 0x8A38;
	public const int UniformType_ = 0x8A37;
	public const int UnpackAlignment_ = 0x0CF5;
	public const int UnpackCompressedBlockDepth_ = 0x9129;
	public const int UnpackCompressedBlockHeight_ = 0x9128;
	public const int UnpackCompressedBlockSize_ = 0x912A;
	public const int UnpackCompressedBlockWidth_ = 0x9127;
	public const int UnpackImageHeight_ = 0x806E;
	public const int UnpackLsbFirst_ = 0x0CF1;
	public const int UnpackRowLength_ = 0x0CF2;
	public const int UnpackSkipImages_ = 0x806D;
	public const int UnpackSkipPixels_ = 0x0CF4;
	public const int UnpackSkipRows_ = 0x0CF3;
	public const int UnpackSwapBytes_ = 0x0CF0;
	public const int Unsignaled_ = 0x9118;
	public const int UnsignedByte_ = 0x1401;
	public const int UnsignedByte233Rev_ = 0x8362;
	public const int UnsignedByte332_ = 0x8032;
	public const int UnsignedInt_ = 0x1405;
	public const int UnsignedInt64Arb_ = 0x140F;
	public const int UnsignedInt64Vec2Arb_ = 0x8FF5;
	public const int UnsignedInt64Vec3Arb_ = 0x8FF6;
	public const int UnsignedInt64Vec4Arb_ = 0x8FF7;
	public const int UnsignedInt10f11f11fRev_ = 0x8C3B;
	public const int UnsignedInt1010102_ = 0x8036;
	public const int UnsignedInt248_ = 0x84FA;
	public const int UnsignedInt2101010Rev_ = 0x8368;
	public const int UnsignedInt5999Rev_ = 0x8C3E;
	public const int UnsignedInt8888_ = 0x8035;
	public const int UnsignedInt8888Rev_ = 0x8367;
	public const int UnsignedIntAtomicCounter_ = 0x92DB;
	public const int UnsignedIntImage1d_ = 0x9062;
	public const int UnsignedIntImage1dArray_ = 0x9068;
	public const int UnsignedIntImage2d_ = 0x9063;
	public const int UnsignedIntImage2dArray_ = 0x9069;
	public const int UnsignedIntImage2dMultisample_ = 0x906B;
	public const int UnsignedIntImage2dMultisampleArray_ = 0x906C;
	public const int UnsignedIntImage2dRect_ = 0x9065;
	public const int UnsignedIntImage3d_ = 0x9064;
	public const int UnsignedIntImageBuffer_ = 0x9067;
	public const int UnsignedIntImageCube_ = 0x9066;
	public const int UnsignedIntImageCubeMapArray_ = 0x906A;
	public const int UnsignedIntSampler1d_ = 0x8DD1;
	public const int UnsignedIntSampler1dArray_ = 0x8DD6;
	public const int UnsignedIntSampler2d_ = 0x8DD2;
	public const int UnsignedIntSampler2dArray_ = 0x8DD7;
	public const int UnsignedIntSampler2dMultisample_ = 0x910A;
	public const int UnsignedIntSampler2dMultisampleArray_ = 0x910D;
	public const int UnsignedIntSampler2dRect_ = 0x8DD5;
	public const int UnsignedIntSampler3d_ = 0x8DD3;
	public const int UnsignedIntSamplerBuffer_ = 0x8DD8;
	public const int UnsignedIntSamplerCube_ = 0x8DD4;
	public const int UnsignedIntSamplerCubeMapArray_ = 0x900F;
	public const int UnsignedIntSamplerCubeMapArrayArb_ = 0x900F;
	public const int UnsignedIntVec2_ = 0x8DC6;
	public const int UnsignedIntVec3_ = 0x8DC7;
	public const int UnsignedIntVec4_ = 0x8DC8;
	public const int UnsignedNormalized_ = 0x8C17;
	public const int UnsignedNormalizedArb_ = 0x8C17;
	public const int UnsignedShort_ = 0x1403;
	public const int UnsignedShort1555Rev_ = 0x8366;
	public const int UnsignedShort4444_ = 0x8033;
	public const int UnsignedShort4444Rev_ = 0x8365;
	public const int UnsignedShort5551_ = 0x8034;
	public const int UnsignedShort565_ = 0x8363;
	public const int UnsignedShort565Rev_ = 0x8364;
	public const int UpperLeft_ = 0x8CA2;
	public const int ValidateStatus_ = 0x8B83;
	public const int Vendor_ = 0x1F00;
	public const int Version_ = 0x1F02;
	public const int VertexArray_ = 0x8074;
	public const int VertexArrayBinding_ = 0x85B5;
	public const int VertexArrayBufferBindingArb_ = 0x8896;
	public const int VertexAttribArrayBarrierBit_ = 0x00000001;
	public const int VertexAttribArrayBufferBinding_ = 0x889F;
	public const int VertexAttribArrayBufferBindingArb_ = 0x889F;
	public const int VertexAttribArrayDivisor_ = 0x88FE;
	public const int VertexAttribArrayDivisorArb_ = 0x88FE;
	public const int VertexAttribArrayEnabled_ = 0x8622;
	public const int VertexAttribArrayEnabledArb_ = 0x8622;
	public const int VertexAttribArrayInteger_ = 0x88FD;
	public const int VertexAttribArrayLong_ = 0x874E;
	public const int VertexAttribArrayNormalized_ = 0x886A;
	public const int VertexAttribArrayNormalizedArb_ = 0x886A;
	public const int VertexAttribArrayPointer_ = 0x8645;
	public const int VertexAttribArrayPointerArb_ = 0x8645;
	public const int VertexAttribArraySize_ = 0x8623;
	public const int VertexAttribArraySizeArb_ = 0x8623;
	public const int VertexAttribArrayStride_ = 0x8624;
	public const int VertexAttribArrayStrideArb_ = 0x8624;
	public const int VertexAttribArrayType_ = 0x8625;
	public const int VertexAttribArrayTypeArb_ = 0x8625;
	public const int VertexAttribBinding_ = 0x82D4;
	public const int VertexAttribRelativeOffset_ = 0x82D5;
	public const int VertexBindingBuffer_ = 0x8F4F;
	public const int VertexBindingDivisor_ = 0x82D6;
	public const int VertexBindingOffset_ = 0x82D7;
	public const int VertexBindingStride_ = 0x82D8;
	public const int VertexProgramArb_ = 0x8620;
	public const int VertexProgramPointSize_ = 0x8642;
	public const int VertexProgramPointSizeArb_ = 0x8642;
	public const int VertexProgramTwoSideArb_ = 0x8643;
	public const int VertexShader_ = 0x8B31;
	public const int VertexShaderArb_ = 0x8B31;
	public const int VertexShaderBit_ = 0x00000001;
	public const int VertexShaderInvocations_ = 0x82F0;
	public const int VertexShaderInvocationsArb_ = 0x82F0;
	public const int VertexSubroutine_ = 0x92E8;
	public const int VertexSubroutineUniform_ = 0x92EE;
	public const int VertexTexture_ = 0x829B;
	public const int VerticesSubmitted_ = 0x82EE;
	public const int VerticesSubmittedArb_ = 0x82EE;
	public const int Viewport_ = 0x0BA2;
	public const int ViewportBoundsRange_ = 0x825D;
	public const int ViewportIndexProvokingVertex_ = 0x825F;
	public const int ViewportSubpixelBits_ = 0x825C;
	public const int ViewClass128Bits_ = 0x82C4;
	public const int ViewClass16Bits_ = 0x82CA;
	public const int ViewClass24Bits_ = 0x82C9;
	public const int ViewClass32Bits_ = 0x82C8;
	public const int ViewClass48Bits_ = 0x82C7;
	public const int ViewClass64Bits_ = 0x82C6;
	public const int ViewClass8Bits_ = 0x82CB;
	public const int ViewClass96Bits_ = 0x82C5;
	public const int ViewClassAstc10x10Rgba_ = 0x9393;
	public const int ViewClassAstc10x5Rgba_ = 0x9390;
	public const int ViewClassAstc10x6Rgba_ = 0x9391;
	public const int ViewClassAstc10x8Rgba_ = 0x9392;
	public const int ViewClassAstc12x10Rgba_ = 0x9394;
	public const int ViewClassAstc12x12Rgba_ = 0x9395;
	public const int ViewClassAstc4x4Rgba_ = 0x9388;
	public const int ViewClassAstc5x4Rgba_ = 0x9389;
	public const int ViewClassAstc5x5Rgba_ = 0x938A;
	public const int ViewClassAstc6x5Rgba_ = 0x938B;
	public const int ViewClassAstc6x6Rgba_ = 0x938C;
	public const int ViewClassAstc8x5Rgba_ = 0x938D;
	public const int ViewClassAstc8x6Rgba_ = 0x938E;
	public const int ViewClassAstc8x8Rgba_ = 0x938F;
	public const int ViewClassBptcFloat_ = 0x82D3;
	public const int ViewClassBptcUnorm_ = 0x82D2;
	public const int ViewClassEacR11_ = 0x9383;
	public const int ViewClassEacRg11_ = 0x9384;
	public const int ViewClassEtc2EacRgba_ = 0x9387;
	public const int ViewClassEtc2Rgb_ = 0x9385;
	public const int ViewClassEtc2Rgba_ = 0x9386;
	public const int ViewClassRgtc1Red_ = 0x82D0;
	public const int ViewClassRgtc2Rg_ = 0x82D1;
	public const int ViewClassS3tcDxt1Rgb_ = 0x82CC;
	public const int ViewClassS3tcDxt1Rgba_ = 0x82CD;
	public const int ViewClassS3tcDxt3Rgba_ = 0x82CE;
	public const int ViewClassS3tcDxt5Rgba_ = 0x82CF;
	public const int ViewCompatibilityClass_ = 0x82B6;
	public const int WaitFailed_ = 0x911D;
	public const int WeightedAverageArb_ = 0x9367;
	public const int WeightArrayBufferBindingArb_ = 0x889E;
	public const int WriteOnly_ = 0x88B9;
	public const int WriteOnlyArb_ = 0x88B9;
	public const int Xor_ = 0x1506;
	public const int Zero_ = 0;

	public static NativeGlContext Context { get; private set; }

	/// <summary>
	/// The Gl class provides bindings for OpenGL functions.
	/// <summary>
	public static void Init() {
		Context = new NativeGlContext();
	}
    
	public static unsafe void AccumxOES(uint op, int value) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glAccumxOES"))(op, value);
	}

	public static unsafe void ActiveShaderProgram(uint pipeline, uint program) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glActiveShaderProgram"))(pipeline, program);
	}

	public static unsafe void ActiveTexture(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glActiveTexture"))(texture);
	}

	public static unsafe void ActiveTextureARB(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glActiveTextureARB"))(texture);
	}

	public static unsafe void AlphaFuncxOES(uint func, int reference) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glAlphaFuncxOES"))(func, reference);
	}

	public static unsafe void AttachObjectARB(uint containerObj, uint obj) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glAttachObjectARB"))(containerObj, obj);
	}

	public static unsafe void AttachShader(uint program, uint shader) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glAttachShader"))(program, shader);
	}

	public static unsafe void BeginConditionalRender(uint id, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBeginConditionalRender"))(id, mode);
	}

	public static unsafe void BeginQuery(uint target, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBeginQuery"))(target, id);
	}

	public static unsafe void BeginQueryARB(uint target, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBeginQueryARB"))(target, id);
	}

	public static unsafe void BeginQueryIndexed(uint target, uint index, uint id) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBeginQueryIndexed"))(target, index, id);
	}

	public static unsafe void BeginTransformFeedback(uint primitiveMode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBeginTransformFeedback"))(primitiveMode);
	}

	public static unsafe void BindAttribLocation(uint program, uint index, char* name) {
		((delegate* unmanaged<uint, uint, char*, void>) Context.GetProcAddress("glBindAttribLocation"))(program, index, name);
	}

	public static unsafe void BindAttribLocationARB(uint programObj, uint index, char* name) {
		((delegate* unmanaged<uint, uint, char*, void>) Context.GetProcAddress("glBindAttribLocationARB"))(programObj, index, name);
	}

	public static unsafe void BindBuffer(uint target, uint buffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindBuffer"))(target, buffer);
	}

	public static unsafe void BindBufferARB(uint target, uint buffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindBufferARB"))(target, buffer);
	}

	public static unsafe void BindBufferBase(uint target, uint index, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBindBufferBase"))(target, index, buffer);
	}

	public static unsafe void BindBufferRange(uint target, uint index, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glBindBufferRange"))(target, index, buffer, offset, size);
	}

	public static unsafe void BindBuffersBase(uint target, uint first, int count, uint* buffers) {
		((delegate* unmanaged<uint, uint, int, uint*, void>) Context.GetProcAddress("glBindBuffersBase"))(target, first, count, buffers);
	}

	public static unsafe void BindBuffersRange(uint target, uint first, int count, uint* buffers, int** offsets, nint* sizes) {
		((delegate* unmanaged<uint, uint, int, uint*, int**, nint*, void>) Context.GetProcAddress("glBindBuffersRange"))(target, first, count, buffers, offsets, sizes);
	}

	public static unsafe void BindFragDataLocation(uint program, uint color, char* name) {
		((delegate* unmanaged<uint, uint, char*, void>) Context.GetProcAddress("glBindFragDataLocation"))(program, color, name);
	}

	public static unsafe void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name) {
		((delegate* unmanaged<uint, uint, uint, char*, void>) Context.GetProcAddress("glBindFragDataLocationIndexed"))(program, colorNumber, index, name);
	}

	public static unsafe void BindFramebuffer(uint target, uint framebuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindFramebuffer"))(target, framebuffer);
	}

	public static unsafe void BindFramebufferEXT(uint target, uint framebuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindFramebufferEXT"))(target, framebuffer);
	}

	public static unsafe void BindImageTexture(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format) {
		((delegate* unmanaged<uint, uint, int, byte, int, uint, uint, void>) Context.GetProcAddress("glBindImageTexture"))(unit, texture, level, layered, layer, access, format);
	}

	public static unsafe void BindImageTextures(uint first, int count, uint* textures) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glBindImageTextures"))(first, count, textures);
	}

	public static unsafe void BindProgramARB(uint target, uint program) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindProgramARB"))(target, program);
	}

	public static unsafe void BindProgramPipeline(uint pipeline) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBindProgramPipeline"))(pipeline);
	}

	public static unsafe void BindRenderbuffer(uint target, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindRenderbuffer"))(target, renderbuffer);
	}

	public static unsafe void BindRenderbufferEXT(uint target, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindRenderbufferEXT"))(target, renderbuffer);
	}

	public static unsafe void BindSampler(uint unit, uint sampler) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindSampler"))(unit, sampler);
	}

	public static unsafe void BindSamplers(uint first, int count, uint* samplers) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glBindSamplers"))(first, count, samplers);
	}

	public static unsafe void BindTexture(uint target, uint texture) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindTexture"))(target, texture);
	}

	public static unsafe void BindTextureUnit(uint unit, uint texture) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindTextureUnit"))(unit, texture);
	}

	public static unsafe void BindTextures(uint first, int count, uint* textures) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glBindTextures"))(first, count, textures);
	}

	public static unsafe void BindTransformFeedback(uint target, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBindTransformFeedback"))(target, id);
	}

	public static unsafe void BindVertexArray(uint array) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBindVertexArray"))(array);
	}

	public static unsafe void BindVertexBuffer(uint bindingindex, uint buffer, int* offset, int stride) {
		((delegate* unmanaged<uint, uint, int*, int, void>) Context.GetProcAddress("glBindVertexBuffer"))(bindingindex, buffer, offset, stride);
	}

	public static unsafe void BindVertexBuffers(uint first, int count, uint* buffers, int** offsets, int* strides) {
		((delegate* unmanaged<uint, int, uint*, int**, int*, void>) Context.GetProcAddress("glBindVertexBuffers"))(first, count, buffers, offsets, strides);
	}

	public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) {
		((delegate* unmanaged<int, int, int, int, int, int, byte*, void>) Context.GetProcAddress("glBitmapxOES"))(width, height, xorig, yorig, xmove, ymove, bitmap);
	}

	public static unsafe void BlendColor(float red, float green, float blue, float alpha) {
		((delegate* unmanaged<float, float, float, float, void>) Context.GetProcAddress("glBlendColor"))(red, green, blue, alpha);
	}

	public static unsafe void BlendColorxOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glBlendColorxOES"))(red, green, blue, alpha);
	}

	public static unsafe void BlendEquation(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glBlendEquation"))(mode);
	}

	public static unsafe void BlendEquationSeparate(uint modeRGB, uint modeAlpha) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendEquationSeparate"))(modeRGB, modeAlpha);
	}

	public static unsafe void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendEquationSeparatei"))(buf, modeRGB, modeAlpha);
	}

	public static unsafe void BlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendEquationSeparateiARB"))(buf, modeRGB, modeAlpha);
	}

	public static unsafe void BlendEquationi(uint buf, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendEquationi"))(buf, mode);
	}

	public static unsafe void BlendEquationiARB(uint buf, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendEquationiARB"))(buf, mode);
	}

	public static unsafe void BlendFunc(uint sfactor, uint dfactor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glBlendFunc"))(sfactor, dfactor);
	}

	public static unsafe void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glBlendFuncSeparate"))(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
	}

	public static unsafe void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glBlendFuncSeparatei"))(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
	}

	public static unsafe void BlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glBlendFuncSeparateiARB"))(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
	}

	public static unsafe void BlendFunci(uint buf, uint src, uint dst) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendFunci"))(buf, src, dst);
	}

	public static unsafe void BlendFunciARB(uint buf, uint src, uint dst) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glBlendFunciARB"))(buf, src, dst);
	}

	public static unsafe void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		((delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void>) Context.GetProcAddress("glBlitFramebuffer"))(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	public static unsafe void BlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		((delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void>) Context.GetProcAddress("glBlitFramebufferEXT"))(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	public static unsafe void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		((delegate* unmanaged<uint, uint, int, int, int, int, int, int, int, int, uint, uint, void>) Context.GetProcAddress("glBlitNamedFramebuffer"))(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	public static unsafe void BufferData(uint target, nint size, void* data, uint usage) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glBufferData"))(target, size, data, usage);
	}

	public static unsafe void BufferDataARB(uint target, nint size, void* data, uint usage) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glBufferDataARB"))(target, size, data, usage);
	}

	public static unsafe void BufferStorage(uint target, nint size, void* data, uint flags) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glBufferStorage"))(target, size, data, flags);
	}

	public static unsafe void BufferSubData(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glBufferSubData"))(target, offset, size, data);
	}

	public static unsafe void BufferSubDataARB(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glBufferSubDataARB"))(target, offset, size, data);
	}

	public static unsafe uint CheckFramebufferStatus(uint target) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCheckFramebufferStatus"))(target);
	}

	public static unsafe uint CheckFramebufferStatusEXT(uint target) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCheckFramebufferStatusEXT"))(target);
	}

	public static unsafe uint CheckNamedFramebufferStatus(uint framebuffer, uint target) {
		return ((delegate* unmanaged<uint, uint, uint>) Context.GetProcAddress("glCheckNamedFramebufferStatus"))(framebuffer, target);
	}

	public static unsafe void ClampColor(uint target, uint clamp) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glClampColor"))(target, clamp);
	}

	public static unsafe void ClampColorARB(uint target, uint clamp) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glClampColorARB"))(target, clamp);
	}

	public static unsafe void Clear(uint mask) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glClear"))(mask);
	}

	public static unsafe void ClearAccumxOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glClearAccumxOES"))(red, green, blue, alpha);
	}

	public static unsafe void ClearBufferData(uint target, uint internalformat, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, uint, uint, void*, void>) Context.GetProcAddress("glClearBufferData"))(target, internalformat, format, type, data);
	}

	public static unsafe void ClearBufferSubData(uint target, uint internalformat, int* offset, nint size, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, int*, nint, uint, uint, void*, void>) Context.GetProcAddress("glClearBufferSubData"))(target, internalformat, offset, size, format, type, data);
	}

	public static unsafe void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) {
		((delegate* unmanaged<uint, int, float, int, void>) Context.GetProcAddress("glClearBufferfi"))(buffer, drawbuffer, depth, stencil);
	}

	public static unsafe void ClearBufferfv(uint buffer, int drawbuffer, float* value) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glClearBufferfv"))(buffer, drawbuffer, value);
	}

	public static unsafe void ClearBufferiv(uint buffer, int drawbuffer, int* value) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glClearBufferiv"))(buffer, drawbuffer, value);
	}

	public static unsafe void ClearBufferuiv(uint buffer, int drawbuffer, uint* value) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glClearBufferuiv"))(buffer, drawbuffer, value);
	}

	public static unsafe void ClearColor(float red, float green, float blue, float alpha) {
		((delegate* unmanaged<float, float, float, float, void>) Context.GetProcAddress("glClearColor"))(red, green, blue, alpha);
	}

	public static unsafe void ClearColorxOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glClearColorxOES"))(red, green, blue, alpha);
	}

	public static unsafe void ClearDepth(double depth) {
		((delegate* unmanaged<double, void>) Context.GetProcAddress("glClearDepth"))(depth);
	}

	public static unsafe void ClearDepthf(float d) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glClearDepthf"))(d);
	}

	public static unsafe void ClearDepthxOES(int depth) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glClearDepthxOES"))(depth);
	}

	public static unsafe void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, uint, uint, void*, void>) Context.GetProcAddress("glClearNamedBufferData"))(buffer, internalformat, format, type, data);
	}

	public static unsafe void ClearNamedBufferSubData(uint buffer, uint internalformat, int* offset, nint size, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, uint, int*, nint, uint, uint, void*, void>) Context.GetProcAddress("glClearNamedBufferSubData"))(buffer, internalformat, offset, size, format, type, data);
	}

	public static unsafe void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil) {
		((delegate* unmanaged<uint, uint, int, float, int, void>) Context.GetProcAddress("glClearNamedFramebufferfi"))(framebuffer, buffer, drawbuffer, depth, stencil);
	}

	public static unsafe void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value) {
		((delegate* unmanaged<uint, uint, int, float*, void>) Context.GetProcAddress("glClearNamedFramebufferfv"))(framebuffer, buffer, drawbuffer, value);
	}

	public static unsafe void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value) {
		((delegate* unmanaged<uint, uint, int, int*, void>) Context.GetProcAddress("glClearNamedFramebufferiv"))(framebuffer, buffer, drawbuffer, value);
	}

	public static unsafe void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value) {
		((delegate* unmanaged<uint, uint, int, uint*, void>) Context.GetProcAddress("glClearNamedFramebufferuiv"))(framebuffer, buffer, drawbuffer, value);
	}

	public static unsafe void ClearStencil(int s) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glClearStencil"))(s);
	}

	public static unsafe void ClearTexImage(uint texture, int level, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, int, uint, uint, void*, void>) Context.GetProcAddress("glClearTexImage"))(texture, level, format, type, data);
	}

	public static unsafe void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glClearTexSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
	}

	public static unsafe void ClientActiveTextureARB(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glClientActiveTextureARB"))(texture);
	}

	public static unsafe uint ClientWaitSync(GLSync sync, uint flags, nint timeout) {
		return ((delegate* unmanaged<GLSync, uint, nint, uint>) Context.GetProcAddress("glClientWaitSync"))(sync, flags, timeout);
	}

	public static unsafe void ClipPlanexOES(uint plane, int* equation) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glClipPlanexOES"))(plane, equation);
	}

	public static unsafe void Color3xOES(int red, int green, int blue) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glColor3xOES"))(red, green, blue);
	}

	public static unsafe void Color3xvOES(int* components) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glColor3xvOES"))(components);
	}

	public static unsafe void Color4xOES(int red, int green, int blue, int alpha) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glColor4xOES"))(red, green, blue, alpha);
	}

	public static unsafe void Color4xvOES(int* components) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glColor4xvOES"))(components);
	}

	public static unsafe void ColorMask(byte red, byte green, byte blue, byte alpha) {
		((delegate* unmanaged<byte, byte, byte, byte, void>) Context.GetProcAddress("glColorMask"))(red, green, blue, alpha);
	}

	public static unsafe void ColorMaski(uint index, byte r, byte g, byte b, byte a) {
		((delegate* unmanaged<uint, byte, byte, byte, byte, void>) Context.GetProcAddress("glColorMaski"))(index, r, g, b, a);
	}

	public static unsafe void CompileShader(uint shader) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glCompileShader"))(shader);
	}

	public static unsafe void CompileShaderARB(uint shaderObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glCompileShaderARB"))(shaderObj);
	}

	public static unsafe void CompileShaderIncludeARB(uint shader, int count, char** path, int* length) {
		((delegate* unmanaged<uint, int, char**, int*, void>) Context.GetProcAddress("glCompileShaderIncludeARB"))(shader, count, path, length);
	}

	public static unsafe void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage1D"))(target, level, internalformat, width, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage1DARB"))(target, level, internalformat, width, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage2D"))(target, level, internalformat, width, height, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage2DARB"))(target, level, internalformat, width, height, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage3D"))(target, level, internalformat, width, height, depth, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void>) Context.GetProcAddress("glCompressedTexImage3DARB"))(target, level, internalformat, width, height, depth, border, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage1D"))(target, level, xoffset, width, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage1DARB"))(target, level, xoffset, width, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage2D"))(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage2DARB"))(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage3D"))(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTexSubImage3DARB"))(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	public static unsafe void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTextureSubImage1D"))(texture, level, xoffset, width, format, imageSize, data);
	}

	public static unsafe void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTextureSubImage2D"))(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	public static unsafe void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void>) Context.GetProcAddress("glCompressedTextureSubImage3D"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	public static unsafe void ConvolutionParameterxOES(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glConvolutionParameterxOES"))(target, pname, param);
	}

	public static unsafe void ConvolutionParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glConvolutionParameterxvOES"))(target, pname, parameters);
	}

	public static unsafe void CopyBufferSubData(uint readTarget, uint writeTarget, int* readOffset, int* writeOffset, nint size) {
		((delegate* unmanaged<uint, uint, int*, int*, nint, void>) Context.GetProcAddress("glCopyBufferSubData"))(readTarget, writeTarget, readOffset, writeOffset, size);
	}

	public static unsafe void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) {
		((delegate* unmanaged<uint, uint, int, int, int, int, uint, uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyImageSubData"))(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
	}

	public static unsafe void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, nint size) {
		((delegate* unmanaged<uint, uint, int*, int*, nint, void>) Context.GetProcAddress("glCopyNamedBufferSubData"))(readBuffer, writeBuffer, readOffset, writeOffset, size);
	}

	public static unsafe void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, void>) Context.GetProcAddress("glCopyTexImage1D"))(target, level, internalformat, x, y, width, border);
	}

	public static unsafe void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) {
		((delegate* unmanaged<uint, int, uint, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexImage2D"))(target, level, internalformat, x, y, width, height, border);
	}

	public static unsafe void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexSubImage1D"))(target, level, xoffset, x, y, width);
	}

	public static unsafe void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexSubImage2D"))(target, level, xoffset, yoffset, x, y, width, height);
	}

	public static unsafe void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTexSubImage3D"))(target, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	public static unsafe void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTextureSubImage1D"))(texture, level, xoffset, x, y, width);
	}

	public static unsafe void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTextureSubImage2D"))(texture, level, xoffset, yoffset, x, y, width, height);
	}

	public static unsafe void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glCopyTextureSubImage3D"))(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	public static unsafe void CreateBuffers(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateBuffers"))(n, buffers);
	}

	public static unsafe void CreateFramebuffers(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateFramebuffers"))(n, framebuffers);
	}

	public static unsafe uint CreateProgram() {
	    return ((delegate* unmanaged<uint>) Context.GetProcAddress("glCreateProgram"))();
	}

	public static unsafe uint CreateProgramObjectARB() {
	    return ((delegate* unmanaged<uint>) Context.GetProcAddress("glCreateProgramObjectARB"))();
	}

	public static unsafe void CreateProgramPipelines(int n, uint* pipelines) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateProgramPipelines"))(n, pipelines);
	}

	public static unsafe void CreateQueries(uint target, int n, uint* ids) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glCreateQueries"))(target, n, ids);
	}

	public static unsafe void CreateRenderbuffers(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateRenderbuffers"))(n, renderbuffers);
	}

	public static unsafe void CreateSamplers(int n, uint* samplers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateSamplers"))(n, samplers);
	}

	public static unsafe uint CreateShader(uint type) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCreateShader"))(type);
	}

	public static unsafe uint CreateShaderObjectARB(uint shaderType) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glCreateShaderObjectARB"))(shaderType);
	}

	public static unsafe uint CreateShaderProgramv(uint type, int count, char** strings) {
		return ((delegate* unmanaged<uint, int, char**, uint>) Context.GetProcAddress("glCreateShaderProgramv"))(type, count, strings);
	}

	public static unsafe void CreateTextures(uint target, int n, uint* textures) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glCreateTextures"))(target, n, textures);
	}

	public static unsafe void CreateTransformFeedbacks(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateTransformFeedbacks"))(n, ids);
	}

	public static unsafe void CreateVertexArrays(int n, uint* arrays) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glCreateVertexArrays"))(n, arrays);
	}

	public static unsafe void CullFace(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glCullFace"))(mode);
	}

	public static unsafe void DebugMessageCallback(delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void> callback, void* userParam) {
		((delegate* unmanaged<delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void>, void*, void>) Context.GetProcAddress("glDebugMessageCallback"))(callback, userParam);
	}

	public static unsafe void DebugMessageCallbackARB(delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void> callback, void* userParam) {
		((delegate* unmanaged<delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void>, void*, void>) Context.GetProcAddress("glDebugMessageCallbackARB"))(callback, userParam);
	}

	public static unsafe void DebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, byte enabled) {
		((delegate* unmanaged<uint, uint, uint, int, uint*, byte, void>) Context.GetProcAddress("glDebugMessageControl"))(source, type, severity, count, ids, enabled);
	}

	public static unsafe void DebugMessageControlARB(uint source, uint type, uint severity, int count, uint* ids, byte enabled) {
		((delegate* unmanaged<uint, uint, uint, int, uint*, byte, void>) Context.GetProcAddress("glDebugMessageControlARB"))(source, type, severity, count, ids, enabled);
	}

	public static unsafe void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char* buf) {
		((delegate* unmanaged<uint, uint, uint, uint, int, char*, void>) Context.GetProcAddress("glDebugMessageInsert"))(source, type, id, severity, length, buf);
	}

	public static unsafe void DebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, char* buf) {
		((delegate* unmanaged<uint, uint, uint, uint, int, char*, void>) Context.GetProcAddress("glDebugMessageInsertARB"))(source, type, id, severity, length, buf);
	}

	public static unsafe void DeleteBuffers(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteBuffers"))(n, buffers);
	}

	public static unsafe void DeleteBuffersARB(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteBuffersARB"))(n, buffers);
	}

	public static unsafe void DeleteFramebuffers(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteFramebuffers"))(n, framebuffers);
	}

	public static unsafe void DeleteFramebuffersEXT(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteFramebuffersEXT"))(n, framebuffers);
	}

	public static unsafe void DeleteNamedStringARB(int namelen, char* name) {
		((delegate* unmanaged<int, char*, void>) Context.GetProcAddress("glDeleteNamedStringARB"))(namelen, name);
	}

	public static unsafe void DeleteObjectARB(uint obj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDeleteObjectARB"))(obj);
	}

	public static unsafe void DeleteProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDeleteProgram"))(program);
	}

	public static unsafe void DeleteProgramPipelines(int n, uint* pipelines) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteProgramPipelines"))(n, pipelines);
	}

	public static unsafe void DeleteProgramsARB(int n, uint* programs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteProgramsARB"))(n, programs);
	}

	public static unsafe void DeleteQueries(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteQueries"))(n, ids);
	}

	public static unsafe void DeleteQueriesARB(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteQueriesARB"))(n, ids);
	}

	public static unsafe void DeleteRenderbuffers(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteRenderbuffers"))(n, renderbuffers);
	}

	public static unsafe void DeleteRenderbuffersEXT(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteRenderbuffersEXT"))(n, renderbuffers);
	}

	public static unsafe void DeleteSamplers(int count, uint* samplers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteSamplers"))(count, samplers);
	}

	public static unsafe void DeleteShader(uint shader) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDeleteShader"))(shader);
	}

	public static unsafe void DeleteSync(GLSync sync) {
		((delegate* unmanaged<GLSync, void>) Context.GetProcAddress("glDeleteSync"))(sync);
	}

	public static unsafe void DeleteTextures(int n, uint* textures) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteTextures"))(n, textures);
	}

	public static unsafe void DeleteTransformFeedbacks(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteTransformFeedbacks"))(n, ids);
	}

	public static unsafe void DeleteVertexArrays(int n, uint* arrays) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDeleteVertexArrays"))(n, arrays);
	}

	public static unsafe void DepthFunc(uint func) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDepthFunc"))(func);
	}

	public static unsafe void DepthMask(byte flag) {
		((delegate* unmanaged<byte, void>) Context.GetProcAddress("glDepthMask"))(flag);
	}

	public static unsafe void DepthRange(double n, double f) {
		((delegate* unmanaged<double, double, void>) Context.GetProcAddress("glDepthRange"))(n, f);
	}

	public static unsafe void DepthRangeArrayv(uint first, int count, double* v) {
		((delegate* unmanaged<uint, int, double*, void>) Context.GetProcAddress("glDepthRangeArrayv"))(first, count, v);
	}

	public static unsafe void DepthRangeIndexed(uint index, double n, double f) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glDepthRangeIndexed"))(index, n, f);
	}

	public static unsafe void DepthRangef(float n, float f) {
		((delegate* unmanaged<float, float, void>) Context.GetProcAddress("glDepthRangef"))(n, f);
	}

	public static unsafe void DepthRangexOES(int n, int f) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glDepthRangexOES"))(n, f);
	}

	public static unsafe void DetachObjectARB(uint containerObj, uint attachedObj) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDetachObjectARB"))(containerObj, attachedObj);
	}

	public static unsafe void DetachShader(uint program, uint shader) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDetachShader"))(program, shader);
	}

	public static unsafe void Disable(uint cap) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDisable"))(cap);
	}

	public static unsafe void DisableVertexArrayAttrib(uint vaobj, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDisableVertexArrayAttrib"))(vaobj, index);
	}

	public static unsafe void DisableVertexAttribArray(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDisableVertexAttribArray"))(index);
	}

	public static unsafe void DisableVertexAttribArrayARB(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDisableVertexAttribArrayARB"))(index);
	}

	public static unsafe void Disablei(uint target, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDisablei"))(target, index);
	}

	public static unsafe void DispatchCompute(uint numgroupsx, uint numgroupsy, uint numgroupsz) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glDispatchCompute"))(numgroupsx, numgroupsy, numgroupsz);
	}

	public static unsafe void DispatchComputeGroupSizeARB(uint numgroupsx, uint numgroupsy, uint numgroupsz, uint groupsizex, uint groupsizey, uint groupsizez) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glDispatchComputeGroupSizeARB"))(numgroupsx, numgroupsy, numgroupsz, groupsizex, groupsizey, groupsizez);
	}

	public static unsafe void DispatchComputeIndirect(int* indirect) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glDispatchComputeIndirect"))(indirect);
	}

	public static unsafe void DrawArrays(uint mode, int first, int count) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glDrawArrays"))(mode, first, count);
	}

	public static unsafe void DrawArraysIndirect(uint mode, void* indirect) {
		((delegate* unmanaged<uint, void*, void>) Context.GetProcAddress("glDrawArraysIndirect"))(mode, indirect);
	}

	public static unsafe void DrawArraysInstanced(uint mode, int first, int count, int instancecount) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glDrawArraysInstanced"))(mode, first, count, instancecount);
	}

	public static unsafe void DrawArraysInstancedARB(uint mode, int first, int count, int primcount) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glDrawArraysInstancedARB"))(mode, first, count, primcount);
	}

	public static unsafe void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance) {
		((delegate* unmanaged<uint, int, int, int, uint, void>) Context.GetProcAddress("glDrawArraysInstancedBaseInstance"))(mode, first, count, instancecount, baseinstance);
	}

	public static unsafe void DrawArraysInstancedEXT(uint mode, int start, int count, int primcount) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glDrawArraysInstancedEXT"))(mode, start, count, primcount);
	}

	public static unsafe void DrawBuffer(uint buf) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glDrawBuffer"))(buf);
	}

	public static unsafe void DrawBuffers(int n, uint* bufs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDrawBuffers"))(n, bufs);
	}

	public static unsafe void DrawBuffersARB(int n, uint* bufs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glDrawBuffersARB"))(n, bufs);
	}

	public static unsafe void DrawElements(uint mode, int count, uint type, void* indices) {
		((delegate* unmanaged<uint, int, uint, void*, void>) Context.GetProcAddress("glDrawElements"))(mode, count, type, indices);
	}

	public static unsafe void DrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsBaseVertex"))(mode, count, type, indices, basevertex);
	}

	public static unsafe void DrawElementsIndirect(uint mode, uint type, void* indirect) {
		((delegate* unmanaged<uint, uint, void*, void>) Context.GetProcAddress("glDrawElementsIndirect"))(mode, type, indirect);
	}

	public static unsafe void DrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsInstanced"))(mode, count, type, indices, instancecount);
	}

	public static unsafe void DrawElementsInstancedARB(uint mode, int count, uint type, void* indices, int primcount) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsInstancedARB"))(mode, count, type, indices, primcount);
	}

	public static unsafe void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance) {
		((delegate* unmanaged<uint, int, uint, void*, int, uint, void>) Context.GetProcAddress("glDrawElementsInstancedBaseInstance"))(mode, count, type, indices, instancecount, baseinstance);
	}

	public static unsafe void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex) {
		((delegate* unmanaged<uint, int, uint, void*, int, int, void>) Context.GetProcAddress("glDrawElementsInstancedBaseVertex"))(mode, count, type, indices, instancecount, basevertex);
	}

	public static unsafe void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance) {
		((delegate* unmanaged<uint, int, uint, void*, int, int, uint, void>) Context.GetProcAddress("glDrawElementsInstancedBaseVertexBaseInstance"))(mode, count, type, indices, instancecount, basevertex, baseinstance);
	}

	public static unsafe void DrawElementsInstancedEXT(uint mode, int count, uint type, void* indices, int primcount) {
		((delegate* unmanaged<uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawElementsInstancedEXT"))(mode, count, type, indices, primcount);
	}

	public static unsafe void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices) {
		((delegate* unmanaged<uint, uint, uint, int, uint, void*, void>) Context.GetProcAddress("glDrawRangeElements"))(mode, start, end, count, type, indices);
	}

	public static unsafe void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex) {
		((delegate* unmanaged<uint, uint, uint, int, uint, void*, int, void>) Context.GetProcAddress("glDrawRangeElementsBaseVertex"))(mode, start, end, count, type, indices, basevertex);
	}

	public static unsafe void DrawTransformFeedback(uint mode, uint id) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glDrawTransformFeedback"))(mode, id);
	}

	public static unsafe void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glDrawTransformFeedbackInstanced"))(mode, id, instancecount);
	}

	public static unsafe void DrawTransformFeedbackStream(uint mode, uint id, uint stream) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glDrawTransformFeedbackStream"))(mode, id, stream);
	}

	public static unsafe void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glDrawTransformFeedbackStreamInstanced"))(mode, id, stream, instancecount);
	}

	public static unsafe void Enable(uint cap) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEnable"))(cap);
	}

	public static unsafe void EnableVertexArrayAttrib(uint vaobj, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glEnableVertexArrayAttrib"))(vaobj, index);
	}

	public static unsafe void EnableVertexAttribArray(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEnableVertexAttribArray"))(index);
	}

	public static unsafe void EnableVertexAttribArrayARB(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEnableVertexAttribArrayARB"))(index);
	}

	public static unsafe void Enablei(uint target, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glEnablei"))(target, index);
	}

	public static unsafe void EndConditionalRender() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glEndConditionalRender"))();
	}

	public static unsafe void EndQuery(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEndQuery"))(target);
	}

	public static unsafe void EndQueryARB(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glEndQueryARB"))(target);
	}

	public static unsafe void EndQueryIndexed(uint target, uint index) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glEndQueryIndexed"))(target, index);
	}

	public static unsafe void EndTransformFeedback() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glEndTransformFeedback"))();
	}

	public static unsafe void EvalCoord1xOES(int u) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glEvalCoord1xOES"))(u);
	}

	public static unsafe void EvalCoord1xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glEvalCoord1xvOES"))(coords);
	}

	public static unsafe void EvalCoord2xOES(int u, int v) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glEvalCoord2xOES"))(u, v);
	}

	public static unsafe void EvalCoord2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glEvalCoord2xvOES"))(coords);
	}

	public static unsafe void EvaluateDepthValuesARB() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glEvaluateDepthValuesARB"))();
	}

	public static unsafe void FeedbackBufferxOES(int n, uint type, int* buffer) {
		((delegate* unmanaged<int, uint, int*, void>) Context.GetProcAddress("glFeedbackBufferxOES"))(n, type, buffer);
	}

	public static unsafe GLSync FenceSync(uint condition, uint flags) {
		return ((delegate* unmanaged<uint, uint, GLSync>) Context.GetProcAddress("glFenceSync"))(condition, flags);
	}

	public static unsafe void Finish() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glFinish"))();
	}

	public static unsafe void Flush() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glFlush"))();
	}

	public static unsafe void FlushMappedBufferRange(uint target, int* offset, nint length) {
		((delegate* unmanaged<uint, int*, nint, void>) Context.GetProcAddress("glFlushMappedBufferRange"))(target, offset, length);
	}

	public static unsafe void FlushMappedNamedBufferRange(uint buffer, int* offset, nint length) {
		((delegate* unmanaged<uint, int*, nint, void>) Context.GetProcAddress("glFlushMappedNamedBufferRange"))(buffer, offset, length);
	}

	public static unsafe void FogCoordPointerEXT(uint type, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, void*, void>) Context.GetProcAddress("glFogCoordPointerEXT"))(type, stride, pointer);
	}

	public static unsafe void FogCoorddEXT(double coord) {
		((delegate* unmanaged<double, void>) Context.GetProcAddress("glFogCoorddEXT"))(coord);
	}

	public static unsafe void FogCoorddvEXT(double* coord) {
		((delegate* unmanaged<double*, void>) Context.GetProcAddress("glFogCoorddvEXT"))(coord);
	}

	public static unsafe void FogCoordfEXT(float coord) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glFogCoordfEXT"))(coord);
	}

	public static unsafe void FogCoordfvEXT(float* coord) {
		((delegate* unmanaged<float*, void>) Context.GetProcAddress("glFogCoordfvEXT"))(coord);
	}

	public static unsafe void FogxOES(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glFogxOES"))(pname, param);
	}

	public static unsafe void FogxvOES(uint pname, int* param) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glFogxvOES"))(pname, param);
	}

	public static unsafe void FramebufferParameteri(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glFramebufferParameteri"))(target, pname, param);
	}

	public static unsafe void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glFramebufferRenderbuffer"))(target, attachment, renderbuffertarget, renderbuffer);
	}

	public static unsafe void FramebufferRenderbufferEXT(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glFramebufferRenderbufferEXT"))(target, attachment, renderbuffertarget, renderbuffer);
	}

	public static unsafe void FramebufferSampleLocationsfvARB(uint target, uint start, int count, float* v) {
		((delegate* unmanaged<uint, uint, int, float*, void>) Context.GetProcAddress("glFramebufferSampleLocationsfvARB"))(target, start, count, v);
	}

	public static unsafe void FramebufferTexture(uint target, uint attachment, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture"))(target, attachment, texture, level);
	}

	public static unsafe void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture1D"))(target, attachment, textarget, texture, level);
	}

	public static unsafe void FramebufferTexture1DEXT(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture1DEXT"))(target, attachment, textarget, texture, level);
	}

	public static unsafe void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture2D"))(target, attachment, textarget, texture, level);
	}

	public static unsafe void FramebufferTexture2DEXT(uint target, uint attachment, uint textarget, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTexture2DEXT"))(target, attachment, textarget, texture, level);
	}

	public static unsafe void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) {
		((delegate* unmanaged<uint, uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTexture3D"))(target, attachment, textarget, texture, level, zoffset);
	}

	public static unsafe void FramebufferTexture3DEXT(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) {
		((delegate* unmanaged<uint, uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTexture3DEXT"))(target, attachment, textarget, texture, level, zoffset);
	}

	public static unsafe void FramebufferTextureARB(uint target, uint attachment, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glFramebufferTextureARB"))(target, attachment, texture, level);
	}

	public static unsafe void FramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face) {
		((delegate* unmanaged<uint, uint, uint, int, uint, void>) Context.GetProcAddress("glFramebufferTextureFaceARB"))(target, attachment, texture, level, face);
	}

	public static unsafe void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) {
		((delegate* unmanaged<uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTextureLayer"))(target, attachment, texture, level, layer);
	}

	public static unsafe void FramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer) {
		((delegate* unmanaged<uint, uint, uint, int, int, void>) Context.GetProcAddress("glFramebufferTextureLayerARB"))(target, attachment, texture, level, layer);
	}

	public static unsafe void FrontFace(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glFrontFace"))(mode);
	}

	public static unsafe void FrustumxOES(int l, int r, int b, int t, int n, int f) {
		((delegate* unmanaged<int, int, int, int, int, int, void>) Context.GetProcAddress("glFrustumxOES"))(l, r, b, t, n, f);
	}

	public static unsafe void GenBuffers(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenBuffers"))(n, buffers);
	}

	public static unsafe void GenBuffersARB(int n, uint* buffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenBuffersARB"))(n, buffers);
	}

	public static unsafe void GenFramebuffers(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenFramebuffers"))(n, framebuffers);
	}

	public static unsafe void GenFramebuffersEXT(int n, uint* framebuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenFramebuffersEXT"))(n, framebuffers);
	}

	public static unsafe void GenProgramPipelines(int n, uint* pipelines) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenProgramPipelines"))(n, pipelines);
	}

	public static unsafe void GenProgramsARB(int n, uint* programs) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenProgramsARB"))(n, programs);
	}

	public static unsafe void GenQueries(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenQueries"))(n, ids);
	}

	public static unsafe void GenQueriesARB(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenQueriesARB"))(n, ids);
	}

	public static unsafe void GenRenderbuffers(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenRenderbuffers"))(n, renderbuffers);
	}

	public static unsafe void GenRenderbuffersEXT(int n, uint* renderbuffers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenRenderbuffersEXT"))(n, renderbuffers);
	}

	public static unsafe void GenSamplers(int count, uint* samplers) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenSamplers"))(count, samplers);
	}

	public static unsafe void GenTextures(int n, uint* textures) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenTextures"))(n, textures);
	}

	public static unsafe void GenTransformFeedbacks(int n, uint* ids) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenTransformFeedbacks"))(n, ids);
	}

	public static unsafe void GenVertexArrays(int n, uint* arrays) {
		((delegate* unmanaged<int, uint*, void>) Context.GetProcAddress("glGenVertexArrays"))(n, arrays);
	}

	public static unsafe void GenerateMipmap(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glGenerateMipmap"))(target);
	}

	public static unsafe void GenerateMipmapEXT(uint target) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glGenerateMipmapEXT"))(target);
	}

	public static unsafe void GenerateTextureMipmap(uint texture) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glGenerateTextureMipmap"))(texture);
	}

	public static unsafe void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetActiveAtomicCounterBufferiv"))(program, bufferIndex, pname, parameters);
	}

	public static unsafe void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveAttrib"))(program, index, bufSize, length, size, type, name);
	}

	public static unsafe void GetActiveAttribARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveAttribARB"))(programObj, index, maxLength, length, size, type, name);
	}

	public static unsafe void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		((delegate* unmanaged<uint, uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveSubroutineName"))(program, shadertype, index, bufSize, length, name);
	}

	public static unsafe void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		((delegate* unmanaged<uint, uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveSubroutineUniformName"))(program, shadertype, index, bufSize, length, name);
	}

	public static unsafe void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values) {
		((delegate* unmanaged<uint, uint, uint, uint, int*, void>) Context.GetProcAddress("glGetActiveSubroutineUniformiv"))(program, shadertype, index, pname, values);
	}

	public static unsafe void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveUniform"))(program, index, bufSize, length, size, type, name);
	}

	public static unsafe void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetActiveUniformARB"))(programObj, index, maxLength, length, size, type, name);
	}

	public static unsafe void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName) {
		((delegate* unmanaged<uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveUniformBlockName"))(program, uniformBlockIndex, bufSize, length, uniformBlockName);
	}

	public static unsafe void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetActiveUniformBlockiv"))(program, uniformBlockIndex, pname, parameters);
	}

	public static unsafe void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName) {
		((delegate* unmanaged<uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetActiveUniformName"))(program, uniformIndex, bufSize, length, uniformName);
	}

	public static unsafe void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint*, uint, int*, void>) Context.GetProcAddress("glGetActiveUniformsiv"))(program, uniformCount, uniformIndices, pname, parameters);
	}

	public static unsafe void GetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj) {
		((delegate* unmanaged<uint, int, int*, uint*, void>) Context.GetProcAddress("glGetAttachedObjectsARB"))(containerObj, maxCount, count, obj);
	}

	public static unsafe void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) {
		((delegate* unmanaged<uint, int, int*, uint*, void>) Context.GetProcAddress("glGetAttachedShaders"))(program, maxCount, count, shaders);
	}

	public static unsafe int GetAttribLocation(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetAttribLocation"))(program, name);
	}

	public static unsafe int GetAttribLocationARB(uint programObj, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetAttribLocationARB"))(programObj, name);
	}

	public static unsafe void GetBooleani_v(uint target, uint index, byte* data) {
		((delegate* unmanaged<uint, uint, byte*, void>) Context.GetProcAddress("glGetBooleani_v"))(target, index, data);
	}

	public static unsafe void GetBooleanv(uint pname, byte* data) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glGetBooleanv"))(pname, data);
	}

	public static unsafe void GetBufferParameteri64v(uint target, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetBufferParameteri64v"))(target, pname, parameters);
	}

	public static unsafe void GetBufferParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetBufferParameteriv"))(target, pname, parameters);
	}

	public static unsafe void GetBufferParameterivARB(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetBufferParameterivARB"))(target, pname, parameters);
	}

	public static unsafe void GetBufferPointerv(uint target, uint pname, void** parameters) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetBufferPointerv"))(target, pname, parameters);
	}

	public static unsafe void GetBufferPointervARB(uint target, uint pname, void** parameters) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetBufferPointervARB"))(target, pname, parameters);
	}

	public static unsafe void GetBufferSubData(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glGetBufferSubData"))(target, offset, size, data);
	}

	public static unsafe void GetBufferSubDataARB(uint target, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glGetBufferSubDataARB"))(target, offset, size, data);
	}

	public static unsafe void GetClipPlanexOES(uint plane, int* equation) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glGetClipPlanexOES"))(plane, equation);
	}

	public static unsafe void GetCompressedTexImage(uint target, int level, void* img) {
		((delegate* unmanaged<uint, int, void*, void>) Context.GetProcAddress("glGetCompressedTexImage"))(target, level, img);
	}

	public static unsafe void GetCompressedTexImageARB(uint target, int level, void* img) {
		((delegate* unmanaged<uint, int, void*, void>) Context.GetProcAddress("glGetCompressedTexImageARB"))(target, level, img);
	}

	public static unsafe void GetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, int, void*, void>) Context.GetProcAddress("glGetCompressedTextureImage"))(texture, level, bufSize, pixels);
	}

	public static unsafe void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void*, void>) Context.GetProcAddress("glGetCompressedTextureSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
	}

	public static unsafe void GetConvolutionParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetConvolutionParameterxvOES"))(target, pname, parameters);
	}

	public static unsafe uint GetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) {
		return ((delegate* unmanaged<uint, int, uint*, uint*, uint*, uint*, int*, char*, uint>) Context.GetProcAddress("glGetDebugMessageLog"))(count, bufSize, sources, types, ids, severities, lengths, messageLog);
	}

	public static unsafe uint GetDebugMessageLogARB(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) {
		return ((delegate* unmanaged<uint, int, uint*, uint*, uint*, uint*, int*, char*, uint>) Context.GetProcAddress("glGetDebugMessageLogARB"))(count, bufSize, sources, types, ids, severities, lengths, messageLog);
	}

	public static unsafe void GetDoublei_v(uint target, uint index, double* data) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetDoublei_v"))(target, index, data);
	}

	public static unsafe void GetDoublev(uint pname, double* data) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glGetDoublev"))(pname, data);
	}

	public static unsafe uint GetError() {
	    return ((delegate* unmanaged<uint>) Context.GetProcAddress("glGetError"))();
	}

	public static unsafe void GetFixedvOES(uint pname, int* parameters) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glGetFixedvOES"))(pname, parameters);
	}

	public static unsafe void GetFloati_v(uint target, uint index, float* data) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetFloati_v"))(target, index, data);
	}

	public static unsafe void GetFloatv(uint pname, float* data) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glGetFloatv"))(pname, data);
	}

	public static unsafe int GetFragDataIndex(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetFragDataIndex"))(program, name);
	}

	public static unsafe int GetFragDataLocation(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetFragDataLocation"))(program, name);
	}

	public static unsafe void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetFramebufferAttachmentParameteriv"))(target, attachment, pname, parameters);
	}

	public static unsafe void GetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetFramebufferAttachmentParameterivEXT"))(target, attachment, pname, parameters);
	}

	public static unsafe void GetFramebufferParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetFramebufferParameteriv"))(target, pname, parameters);
	}

	public static unsafe uint GetHandleARB(uint pname) {
		return ((delegate* unmanaged<uint, uint>) Context.GetProcAddress("glGetHandleARB"))(pname);
	}

	public static unsafe void GetHistogramParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetHistogramParameterxvOES"))(target, pname, parameters);
	}

	public static unsafe void GetInfoLogARB(uint obj, int maxLength, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetInfoLogARB"))(obj, maxLength, length, infoLog);
	}

	public static unsafe void GetInteger64i_v(uint target, uint index, nint* data) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetInteger64i_v"))(target, index, data);
	}

	public static unsafe void GetInteger64v(uint pname, nint* data) {
		((delegate* unmanaged<uint, nint*, void>) Context.GetProcAddress("glGetInteger64v"))(pname, data);
	}

	public static unsafe void GetIntegeri_v(uint target, uint index, int* data) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetIntegeri_v"))(target, index, data);
	}

	public static unsafe void GetIntegerv(uint pname, int* data) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glGetIntegerv"))(pname, data);
	}

	public static unsafe void GetInternalformati64v(uint target, uint internalformat, uint pname, int count, nint* parameters) {
		((delegate* unmanaged<uint, uint, uint, int, nint*, void>) Context.GetProcAddress("glGetInternalformati64v"))(target, internalformat, pname, count, parameters);
	}

	public static unsafe void GetInternalformativ(uint target, uint internalformat, uint pname, int count, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int, int*, void>) Context.GetProcAddress("glGetInternalformativ"))(target, internalformat, pname, count, parameters);
	}

	public static unsafe void GetLightxOES(uint light, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetLightxOES"))(light, pname, parameters);
	}

	public static unsafe void GetMapxvOES(uint target, uint query, int* v) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetMapxvOES"))(target, query, v);
	}

	public static unsafe void GetMaterialxOES(uint face, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glGetMaterialxOES"))(face, pname, param);
	}

	public static unsafe void GetMultisamplefv(uint pname, uint index, float* val) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetMultisamplefv"))(pname, index, val);
	}

	public static unsafe void GetNamedBufferParameteri64v(uint buffer, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetNamedBufferParameteri64v"))(buffer, pname, parameters);
	}

	public static unsafe void GetNamedBufferParameteriv(uint buffer, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetNamedBufferParameteriv"))(buffer, pname, parameters);
	}

	public static unsafe void GetNamedBufferPointerv(uint buffer, uint pname, void** parameters) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetNamedBufferPointerv"))(buffer, pname, parameters);
	}

	public static unsafe void GetNamedBufferSubData(uint buffer, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glGetNamedBufferSubData"))(buffer, offset, size, data);
	}

	public static unsafe void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetNamedFramebufferAttachmentParameteriv"))(framebuffer, attachment, pname, parameters);
	}

	public static unsafe void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetNamedFramebufferParameteriv"))(framebuffer, pname, param);
	}

	public static unsafe void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetNamedRenderbufferParameteriv"))(renderbuffer, pname, parameters);
	}

	public static unsafe void GetNamedStringARB(int namelen, char* name, int bufSize, int* stringlen, char* str) {
		((delegate* unmanaged<int, char*, int, int*, char*, void>) Context.GetProcAddress("glGetNamedStringARB"))(namelen, name, bufSize, stringlen, str);
	}

	public static unsafe void GetNamedStringivARB(int namelen, char* name, uint pname, int* parameters) {
		((delegate* unmanaged<int, char*, uint, int*, void>) Context.GetProcAddress("glGetNamedStringivARB"))(namelen, name, pname, parameters);
	}

	public static unsafe void GetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label) {
		((delegate* unmanaged<uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetObjectLabel"))(identifier, name, bufSize, length, label);
	}

	public static unsafe void GetObjectParameterfvARB(uint obj, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetObjectParameterfvARB"))(obj, pname, parameters);
	}

	public static unsafe void GetObjectParameterivARB(uint obj, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetObjectParameterivARB"))(obj, pname, parameters);
	}

	public static unsafe void GetObjectPtrLabel(void* ptr, int bufSize, int* length, char* label) {
		((delegate* unmanaged<void*, int, int*, char*, void>) Context.GetProcAddress("glGetObjectPtrLabel"))(ptr, bufSize, length, label);
	}

	public static unsafe void GetPixelMapxv(uint map, int size, int* values) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glGetPixelMapxv"))(map, size, values);
	}

	public static unsafe void GetPointerv(uint pname, void** parameters) {
		((delegate* unmanaged<uint, void**, void>) Context.GetProcAddress("glGetPointerv"))(pname, parameters);
	}

	public static unsafe void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) {
		((delegate* unmanaged<uint, int, int*, uint*, void*, void>) Context.GetProcAddress("glGetProgramBinary"))(program, bufSize, length, binaryFormat, binary);
	}

	public static unsafe void GetProgramEnvParameterdvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetProgramEnvParameterdvARB"))(target, index, parameters);
	}

	public static unsafe void GetProgramEnvParameterfvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetProgramEnvParameterfvARB"))(target, index, parameters);
	}

	public static unsafe void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetProgramInfoLog"))(program, bufSize, length, infoLog);
	}

	public static unsafe void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetProgramInterfaceiv"))(program, programInterface, pname, parameters);
	}

	public static unsafe void GetProgramLocalParameterdvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetProgramLocalParameterdvARB"))(target, index, parameters);
	}

	public static unsafe void GetProgramLocalParameterfvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetProgramLocalParameterfvARB"))(target, index, parameters);
	}

	public static unsafe void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetProgramPipelineInfoLog"))(pipeline, bufSize, length, infoLog);
	}

	public static unsafe void GetProgramPipelineiv(uint pipeline, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetProgramPipelineiv"))(pipeline, pname, parameters);
	}

	public static unsafe uint GetProgramResourceIndex(uint program, uint programInterface, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, uint>) Context.GetProcAddress("glGetProgramResourceIndex"))(program, programInterface, name);
	}

	public static unsafe int GetProgramResourceLocation(uint program, uint programInterface, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, int>) Context.GetProcAddress("glGetProgramResourceLocation"))(program, programInterface, name);
	}

	public static unsafe int GetProgramResourceLocationIndex(uint program, uint programInterface, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, int>) Context.GetProcAddress("glGetProgramResourceLocationIndex"))(program, programInterface, name);
	}

	public static unsafe void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name) {
		((delegate* unmanaged<uint, uint, uint, int, int*, char*, void>) Context.GetProcAddress("glGetProgramResourceName"))(program, programInterface, index, bufSize, length, name);
	}

	public static unsafe void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int, uint*, int, int*, int*, void>) Context.GetProcAddress("glGetProgramResourceiv"))(program, programInterface, index, propCount, props, count, length, parameters);
	}

	public static unsafe void GetProgramStageiv(uint program, uint shadertype, uint pname, int* values) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetProgramStageiv"))(program, shadertype, pname, values);
	}

	public static unsafe void GetProgramStringARB(uint target, uint pname, void* str) {
		((delegate* unmanaged<uint, uint, void*, void>) Context.GetProcAddress("glGetProgramStringARB"))(target, pname, str);
	}

	public static unsafe void GetProgramiv(uint program, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetProgramiv"))(program, pname, parameters);
	}

	public static unsafe void GetProgramivARB(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetProgramivARB"))(target, pname, parameters);
	}

	public static unsafe void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjecti64v"))(id, buffer, pname, offset);
	}

	public static unsafe void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjectiv"))(id, buffer, pname, offset);
	}

	public static unsafe void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjectui64v"))(id, buffer, pname, offset);
	}

	public static unsafe void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int* offset) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryBufferObjectuiv"))(id, buffer, pname, offset);
	}

	public static unsafe void GetQueryIndexediv(uint target, uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetQueryIndexediv"))(target, index, pname, parameters);
	}

	public static unsafe void GetQueryObjecti64v(uint id, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetQueryObjecti64v"))(id, pname, parameters);
	}

	public static unsafe void GetQueryObjectiv(uint id, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryObjectiv"))(id, pname, parameters);
	}

	public static unsafe void GetQueryObjectivARB(uint id, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryObjectivARB"))(id, pname, parameters);
	}

	public static unsafe void GetQueryObjectui64v(uint id, uint pname, nint* parameters) {
		((delegate* unmanaged<uint, uint, nint*, void>) Context.GetProcAddress("glGetQueryObjectui64v"))(id, pname, parameters);
	}

	public static unsafe void GetQueryObjectuiv(uint id, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetQueryObjectuiv"))(id, pname, parameters);
	}

	public static unsafe void GetQueryObjectuivARB(uint id, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetQueryObjectuivARB"))(id, pname, parameters);
	}

	public static unsafe void GetQueryiv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryiv"))(target, pname, parameters);
	}

	public static unsafe void GetQueryivARB(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetQueryivARB"))(target, pname, parameters);
	}

	public static unsafe void GetRenderbufferParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetRenderbufferParameteriv"))(target, pname, parameters);
	}

	public static unsafe void GetRenderbufferParameterivEXT(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetRenderbufferParameterivEXT"))(target, pname, parameters);
	}

	public static unsafe void GetSamplerParameterIiv(uint sampler, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetSamplerParameterIiv"))(sampler, pname, parameters);
	}

	public static unsafe void GetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetSamplerParameterIuiv"))(sampler, pname, parameters);
	}

	public static unsafe void GetSamplerParameterfv(uint sampler, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetSamplerParameterfv"))(sampler, pname, parameters);
	}

	public static unsafe void GetSamplerParameteriv(uint sampler, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetSamplerParameteriv"))(sampler, pname, parameters);
	}

	public static unsafe void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetShaderInfoLog"))(shader, bufSize, length, infoLog);
	}

	public static unsafe void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) {
		((delegate* unmanaged<uint, uint, int*, int*, void>) Context.GetProcAddress("glGetShaderPrecisionFormat"))(shadertype, precisiontype, range, precision);
	}

	public static unsafe void GetShaderSource(uint shader, int bufSize, int* length, char* source) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetShaderSource"))(shader, bufSize, length, source);
	}

	public static unsafe void GetShaderSourceARB(uint obj, int maxLength, int* length, char* source) {
		((delegate* unmanaged<uint, int, int*, char*, void>) Context.GetProcAddress("glGetShaderSourceARB"))(obj, maxLength, length, source);
	}

	public static unsafe void GetShaderiv(uint shader, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetShaderiv"))(shader, pname, parameters);
	}

	public static unsafe byte* GetString(uint name) {
		return ((delegate* unmanaged<uint, byte*>) Context.GetProcAddress("glGetString"))(name);
	}

	public static unsafe byte* GetStringi(uint name, uint index) {
		return ((delegate* unmanaged<uint, uint, byte*>) Context.GetProcAddress("glGetStringi"))(name, index);
	}

	public static unsafe uint GetSubroutineIndex(uint program, uint shadertype, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, uint>) Context.GetProcAddress("glGetSubroutineIndex"))(program, shadertype, name);
	}

	public static unsafe int GetSubroutineUniformLocation(uint program, uint shadertype, char* name) {
		return ((delegate* unmanaged<uint, uint, char*, int>) Context.GetProcAddress("glGetSubroutineUniformLocation"))(program, shadertype, name);
	}

	public static unsafe void GetSynciv(GLSync sync, uint pname, int count, int* length, int* values) {
		((delegate* unmanaged<GLSync, uint, int, int*, int*, void>) Context.GetProcAddress("glGetSynciv"))(sync, pname, count, length, values);
	}

	public static unsafe void GetTexEnvxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexEnvxvOES"))(target, pname, parameters);
	}

	public static unsafe void GetTexGenxvOES(uint coord, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexGenxvOES"))(coord, pname, parameters);
	}

	public static unsafe void GetTexImage(uint target, int level, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, uint, uint, void*, void>) Context.GetProcAddress("glGetTexImage"))(target, level, format, type, pixels);
	}

	public static unsafe void GetTexLevelParameterfv(uint target, int level, uint pname, float* parameters) {
		((delegate* unmanaged<uint, int, uint, float*, void>) Context.GetProcAddress("glGetTexLevelParameterfv"))(target, level, pname, parameters);
	}

	public static unsafe void GetTexLevelParameteriv(uint target, int level, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint, int*, void>) Context.GetProcAddress("glGetTexLevelParameteriv"))(target, level, pname, parameters);
	}

	public static unsafe void GetTexLevelParameterxvOES(uint target, int level, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint, int*, void>) Context.GetProcAddress("glGetTexLevelParameterxvOES"))(target, level, pname, parameters);
	}

	public static unsafe void GetTexParameterIiv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexParameterIiv"))(target, pname, parameters);
	}

	public static unsafe void GetTexParameterIuiv(uint target, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetTexParameterIuiv"))(target, pname, parameters);
	}

	public static unsafe void GetTexParameterfv(uint target, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetTexParameterfv"))(target, pname, parameters);
	}

	public static unsafe void GetTexParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexParameteriv"))(target, pname, parameters);
	}

	public static unsafe void GetTexParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTexParameterxvOES"))(target, pname, parameters);
	}

	public static unsafe void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, uint, uint, int, void*, void>) Context.GetProcAddress("glGetTextureImage"))(texture, level, format, type, bufSize, pixels);
	}

	public static unsafe void GetTextureLevelParameterfv(uint texture, int level, uint pname, float* parameters) {
		((delegate* unmanaged<uint, int, uint, float*, void>) Context.GetProcAddress("glGetTextureLevelParameterfv"))(texture, level, pname, parameters);
	}

	public static unsafe void GetTextureLevelParameteriv(uint texture, int level, uint pname, int* parameters) {
		((delegate* unmanaged<uint, int, uint, int*, void>) Context.GetProcAddress("glGetTextureLevelParameteriv"))(texture, level, pname, parameters);
	}

	public static unsafe void GetTextureParameterIiv(uint texture, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTextureParameterIiv"))(texture, pname, parameters);
	}

	public static unsafe void GetTextureParameterIuiv(uint texture, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetTextureParameterIuiv"))(texture, pname, parameters);
	}

	public static unsafe void GetTextureParameterfv(uint texture, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetTextureParameterfv"))(texture, pname, parameters);
	}

	public static unsafe void GetTextureParameteriv(uint texture, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTextureParameteriv"))(texture, pname, parameters);
	}

	public static unsafe void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, int, void*, void>) Context.GetProcAddress("glGetTextureSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
	}

	public static unsafe void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		((delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void>) Context.GetProcAddress("glGetTransformFeedbackVarying"))(program, index, bufSize, length, size, type, name);
	}

	public static unsafe void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, nint* param) {
		((delegate* unmanaged<uint, uint, uint, nint*, void>) Context.GetProcAddress("glGetTransformFeedbacki64_v"))(xfb, pname, index, param);
	}

	public static unsafe void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetTransformFeedbacki_v"))(xfb, pname, index, param);
	}

	public static unsafe void GetTransformFeedbackiv(uint xfb, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetTransformFeedbackiv"))(xfb, pname, param);
	}

	public static unsafe uint GetUniformBlockIndex(uint program, char* uniformBlockName) {
		return ((delegate* unmanaged<uint, char*, uint>) Context.GetProcAddress("glGetUniformBlockIndex"))(program, uniformBlockName);
	}

	public static unsafe void GetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices) {
		((delegate* unmanaged<uint, int, char**, uint*, void>) Context.GetProcAddress("glGetUniformIndices"))(program, uniformCount, uniformNames, uniformIndices);
	}

	public static unsafe int GetUniformLocation(uint program, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetUniformLocation"))(program, name);
	}

	public static unsafe int GetUniformLocationARB(uint programObj, char* name) {
		return ((delegate* unmanaged<uint, char*, int>) Context.GetProcAddress("glGetUniformLocationARB"))(programObj, name);
	}

	public static unsafe void GetUniformSubroutineuiv(uint shadertype, int location, uint* parameters) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glGetUniformSubroutineuiv"))(shadertype, location, parameters);
	}

	public static unsafe void GetUniformdv(uint program, int location, double* parameters) {
		((delegate* unmanaged<uint, int, double*, void>) Context.GetProcAddress("glGetUniformdv"))(program, location, parameters);
	}

	public static unsafe void GetUniformfv(uint program, int location, float* parameters) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glGetUniformfv"))(program, location, parameters);
	}

	public static unsafe void GetUniformfvARB(uint programObj, int location, float* parameters) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glGetUniformfvARB"))(programObj, location, parameters);
	}

	public static unsafe void GetUniformi64vARB(uint program, int location, nint* parameters) {
		((delegate* unmanaged<uint, int, nint*, void>) Context.GetProcAddress("glGetUniformi64vARB"))(program, location, parameters);
	}

	public static unsafe void GetUniformiv(uint program, int location, int* parameters) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glGetUniformiv"))(program, location, parameters);
	}

	public static unsafe void GetUniformivARB(uint programObj, int location, int* parameters) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glGetUniformivARB"))(programObj, location, parameters);
	}

	public static unsafe void GetUniformui64vARB(uint program, int location, nint* parameters) {
		((delegate* unmanaged<uint, int, nint*, void>) Context.GetProcAddress("glGetUniformui64vARB"))(program, location, parameters);
	}

	public static unsafe void GetUniformuiv(uint program, int location, uint* parameters) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glGetUniformuiv"))(program, location, parameters);
	}

	public static unsafe void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, nint* param) {
		((delegate* unmanaged<uint, uint, uint, nint*, void>) Context.GetProcAddress("glGetVertexArrayIndexed64iv"))(vaobj, index, pname, param);
	}

	public static unsafe void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, uint, int*, void>) Context.GetProcAddress("glGetVertexArrayIndexediv"))(vaobj, index, pname, param);
	}

	public static unsafe void GetVertexArrayiv(uint vaobj, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexArrayiv"))(vaobj, pname, param);
	}

	public static unsafe void GetVertexAttribIiv(uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexAttribIiv"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribIuiv(uint index, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glGetVertexAttribIuiv"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribLdv(uint index, uint pname, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetVertexAttribLdv"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribPointerv(uint index, uint pname, void** pointer) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetVertexAttribPointerv"))(index, pname, pointer);
	}

	public static unsafe void GetVertexAttribPointervARB(uint index, uint pname, void** pointer) {
		((delegate* unmanaged<uint, uint, void**, void>) Context.GetProcAddress("glGetVertexAttribPointervARB"))(index, pname, pointer);
	}

	public static unsafe void GetVertexAttribdv(uint index, uint pname, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetVertexAttribdv"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribdvARB(uint index, uint pname, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glGetVertexAttribdvARB"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribfv(uint index, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetVertexAttribfv"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribfvARB(uint index, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glGetVertexAttribfvARB"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribiv(uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexAttribiv"))(index, pname, parameters);
	}

	public static unsafe void GetVertexAttribivARB(uint index, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glGetVertexAttribivARB"))(index, pname, parameters);
	}

	public static unsafe void GetnUniformi64vARB(uint program, int location, int bufSize, nint* parameters) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glGetnUniformi64vARB"))(program, location, bufSize, parameters);
	}

	public static unsafe void GetnUniformui64vARB(uint program, int location, int bufSize, nint* parameters) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glGetnUniformui64vARB"))(program, location, bufSize, parameters);
	}

	public static unsafe void Hint(uint target, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glHint"))(target, mode);
	}

	public static unsafe void IndexxOES(int component) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glIndexxOES"))(component);
	}

	public static unsafe void IndexxvOES(int* component) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glIndexxvOES"))(component);
	}

	public static unsafe void InvalidateBufferData(uint buffer) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glInvalidateBufferData"))(buffer);
	}

	public static unsafe void InvalidateBufferSubData(uint buffer, int* offset, nint length) {
		((delegate* unmanaged<uint, int*, nint, void>) Context.GetProcAddress("glInvalidateBufferSubData"))(buffer, offset, length);
	}

	public static unsafe void InvalidateFramebuffer(uint target, int numAttachments, uint* attachments) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glInvalidateFramebuffer"))(target, numAttachments, attachments);
	}

	public static unsafe void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glInvalidateNamedFramebufferData"))(framebuffer, numAttachments, attachments);
	}

	public static unsafe void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, uint*, int, int, int, int, void>) Context.GetProcAddress("glInvalidateNamedFramebufferSubData"))(framebuffer, numAttachments, attachments, x, y, width, height);
	}

	public static unsafe void InvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height) {
		((delegate* unmanaged<uint, int, uint*, int, int, int, int, void>) Context.GetProcAddress("glInvalidateSubFramebuffer"))(target, numAttachments, attachments, x, y, width, height);
	}

	public static unsafe void InvalidateTexImage(uint texture, int level) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glInvalidateTexImage"))(texture, level);
	}

	public static unsafe void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glInvalidateTexSubImage"))(texture, level, xoffset, yoffset, zoffset, width, height, depth);
	}

	public static unsafe byte IsBuffer(uint buffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsBuffer"))(buffer);
	}

	public static unsafe byte IsBufferARB(uint buffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsBufferARB"))(buffer);
	}

	public static unsafe byte IsEnabled(uint cap) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsEnabled"))(cap);
	}

	public static unsafe byte IsEnabledi(uint target, uint index) {
		return ((delegate* unmanaged<uint, uint, byte>) Context.GetProcAddress("glIsEnabledi"))(target, index);
	}

	public static unsafe byte IsFramebuffer(uint framebuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsFramebuffer"))(framebuffer);
	}

	public static unsafe byte IsFramebufferEXT(uint framebuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsFramebufferEXT"))(framebuffer);
	}

	public static unsafe byte IsNamedStringARB(int namelen, char* name) {
		return ((delegate* unmanaged<int, char*, byte>) Context.GetProcAddress("glIsNamedStringARB"))(namelen, name);
	}

	public static unsafe byte IsProgram(uint program) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsProgram"))(program);
	}

	public static unsafe byte IsProgramARB(uint program) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsProgramARB"))(program);
	}

	public static unsafe byte IsProgramPipeline(uint pipeline) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsProgramPipeline"))(pipeline);
	}

	public static unsafe byte IsQuery(uint id) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsQuery"))(id);
	}

	public static unsafe byte IsQueryARB(uint id) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsQueryARB"))(id);
	}

	public static unsafe byte IsRenderbuffer(uint renderbuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsRenderbuffer"))(renderbuffer);
	}

	public static unsafe byte IsRenderbufferEXT(uint renderbuffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsRenderbufferEXT"))(renderbuffer);
	}

	public static unsafe byte IsSampler(uint sampler) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsSampler"))(sampler);
	}

	public static unsafe byte IsShader(uint shader) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsShader"))(shader);
	}

	public static unsafe byte IsSync(GLSync sync) {
		return ((delegate* unmanaged<GLSync, byte>) Context.GetProcAddress("glIsSync"))(sync);
	}

	public static unsafe byte IsTexture(uint texture) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsTexture"))(texture);
	}

	public static unsafe byte IsTransformFeedback(uint id) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsTransformFeedback"))(id);
	}

	public static unsafe byte IsVertexArray(uint array) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glIsVertexArray"))(array);
	}

	public static unsafe void LightModelxOES(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glLightModelxOES"))(pname, param);
	}

	public static unsafe void LightModelxvOES(uint pname, int* param) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glLightModelxvOES"))(pname, param);
	}

	public static unsafe void LightxOES(uint light, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glLightxOES"))(light, pname, param);
	}

	public static unsafe void LightxvOES(uint light, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glLightxvOES"))(light, pname, parameters);
	}

	public static unsafe void LineWidth(float width) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glLineWidth"))(width);
	}

	public static unsafe void LineWidthxOES(int width) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glLineWidthxOES"))(width);
	}

	public static unsafe void LinkProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glLinkProgram"))(program);
	}

	public static unsafe void LinkProgramARB(uint programObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glLinkProgramARB"))(programObj);
	}

	public static unsafe void LoadMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glLoadMatrixxOES"))(m);
	}

	public static unsafe void LoadTransposeMatrixdARB(double* m) {
		((delegate* unmanaged<double*, void>) Context.GetProcAddress("glLoadTransposeMatrixdARB"))(m);
	}

	public static unsafe void LoadTransposeMatrixfARB(float* m) {
		((delegate* unmanaged<float*, void>) Context.GetProcAddress("glLoadTransposeMatrixfARB"))(m);
	}

	public static unsafe void LoadTransposeMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glLoadTransposeMatrixxOES"))(m);
	}

	public static unsafe void LogicOp(uint opcode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glLogicOp"))(opcode);
	}

	public static unsafe void Map1xOES(uint target, int u1, int u2, int stride, int order, int points) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glMap1xOES"))(target, u1, u2, stride, order, points);
	}

	public static unsafe void Map2xOES(uint target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, int, int, void>) Context.GetProcAddress("glMap2xOES"))(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
	}

	public static unsafe void* MapBuffer(uint target, uint access) {
		return ((delegate* unmanaged<uint, uint, void*>) Context.GetProcAddress("glMapBuffer"))(target, access);
	}

	public static unsafe void* MapBufferARB(uint target, uint access) {
		return ((delegate* unmanaged<uint, uint, void*>) Context.GetProcAddress("glMapBufferARB"))(target, access);
	}

	public static unsafe void* MapBufferRange(uint target, int* offset, nint length, uint access) {
		return ((delegate* unmanaged<uint, int*, nint, uint, void*>) Context.GetProcAddress("glMapBufferRange"))(target, offset, length, access);
	}

	public static unsafe void MapGrid1xOES(int n, int u1, int u2) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glMapGrid1xOES"))(n, u1, u2);
	}

	public static unsafe void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) {
		((delegate* unmanaged<int, int, int, int, int, void>) Context.GetProcAddress("glMapGrid2xOES"))(n, u1, u2, v1, v2);
	}

	public static unsafe void* MapNamedBuffer(uint buffer, uint access) {
		return ((delegate* unmanaged<uint, uint, void*>) Context.GetProcAddress("glMapNamedBuffer"))(buffer, access);
	}

	public static unsafe void* MapNamedBufferRange(uint buffer, int* offset, nint length, uint access) {
		return ((delegate* unmanaged<uint, int*, nint, uint, void*>) Context.GetProcAddress("glMapNamedBufferRange"))(buffer, offset, length, access);
	}

	public static unsafe void MaterialxOES(uint face, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glMaterialxOES"))(face, pname, param);
	}

	public static unsafe void MaterialxvOES(uint face, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glMaterialxvOES"))(face, pname, param);
	}

	public static unsafe void MemoryBarrier(uint barriers) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glMemoryBarrier"))(barriers);
	}

	public static unsafe void MemoryBarrierByRegion(uint barriers) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glMemoryBarrierByRegion"))(barriers);
	}

	public static unsafe void MinSampleShading(float value) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glMinSampleShading"))(value);
	}

	public static unsafe void MinSampleShadingARB(float value) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glMinSampleShadingARB"))(value);
	}

	public static unsafe void MultMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glMultMatrixxOES"))(m);
	}

	public static unsafe void MultTransposeMatrixdARB(double* m) {
		((delegate* unmanaged<double*, void>) Context.GetProcAddress("glMultTransposeMatrixdARB"))(m);
	}

	public static unsafe void MultTransposeMatrixfARB(float* m) {
		((delegate* unmanaged<float*, void>) Context.GetProcAddress("glMultTransposeMatrixfARB"))(m);
	}

	public static unsafe void MultTransposeMatrixxOES(int* m) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glMultTransposeMatrixxOES"))(m);
	}

	public static unsafe void MultiDrawArrays(uint mode, int* first, int* count, int drawcount) {
		((delegate* unmanaged<uint, int*, int*, int, void>) Context.GetProcAddress("glMultiDrawArrays"))(mode, first, count, drawcount);
	}

	public static unsafe void MultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride) {
		((delegate* unmanaged<uint, void*, int, int, void>) Context.GetProcAddress("glMultiDrawArraysIndirect"))(mode, indirect, drawcount, stride);
	}

	public static unsafe void MultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount) {
		((delegate* unmanaged<uint, int*, uint, void**, int, void>) Context.GetProcAddress("glMultiDrawElements"))(mode, count, type, indices, drawcount);
	}

	public static unsafe void MultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex) {
		((delegate* unmanaged<uint, int*, uint, void**, int, int*, void>) Context.GetProcAddress("glMultiDrawElementsBaseVertex"))(mode, count, type, indices, drawcount, basevertex);
	}

	public static unsafe void MultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride) {
		((delegate* unmanaged<uint, uint, void*, int, int, void>) Context.GetProcAddress("glMultiDrawElementsIndirect"))(mode, type, indirect, drawcount, stride);
	}

	public static unsafe void MultiTexCoord1dARB(uint target, double s) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glMultiTexCoord1dARB"))(target, s);
	}

	public static unsafe void MultiTexCoord1dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord1dvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord1fARB(uint target, float s) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glMultiTexCoord1fARB"))(target, s);
	}

	public static unsafe void MultiTexCoord1fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord1fvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord1iARB(uint target, int s) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glMultiTexCoord1iARB"))(target, s);
	}

	public static unsafe void MultiTexCoord1ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord1ivARB"))(target, v);
	}

	public static unsafe void MultiTexCoord1sARB(uint target, short s) {
		((delegate* unmanaged<uint, short, void>) Context.GetProcAddress("glMultiTexCoord1sARB"))(target, s);
	}

	public static unsafe void MultiTexCoord1svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord1svARB"))(target, v);
	}

	public static unsafe void MultiTexCoord1xOES(uint texture, int s) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glMultiTexCoord1xOES"))(texture, s);
	}

	public static unsafe void MultiTexCoord1xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord1xvOES"))(texture, coords);
	}

	public static unsafe void MultiTexCoord2dARB(uint target, double s, double t) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glMultiTexCoord2dARB"))(target, s, t);
	}

	public static unsafe void MultiTexCoord2dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord2dvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord2fARB(uint target, float s, float t) {
		((delegate* unmanaged<uint, float, float, void>) Context.GetProcAddress("glMultiTexCoord2fARB"))(target, s, t);
	}

	public static unsafe void MultiTexCoord2fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord2fvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord2iARB(uint target, int s, int t) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glMultiTexCoord2iARB"))(target, s, t);
	}

	public static unsafe void MultiTexCoord2ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord2ivARB"))(target, v);
	}

	public static unsafe void MultiTexCoord2sARB(uint target, short s, short t) {
		((delegate* unmanaged<uint, short, short, void>) Context.GetProcAddress("glMultiTexCoord2sARB"))(target, s, t);
	}

	public static unsafe void MultiTexCoord2svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord2svARB"))(target, v);
	}

	public static unsafe void MultiTexCoord2xOES(uint texture, int s, int t) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glMultiTexCoord2xOES"))(texture, s, t);
	}

	public static unsafe void MultiTexCoord2xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord2xvOES"))(texture, coords);
	}

	public static unsafe void MultiTexCoord3dARB(uint target, double s, double t, double r) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glMultiTexCoord3dARB"))(target, s, t, r);
	}

	public static unsafe void MultiTexCoord3dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord3dvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord3fARB(uint target, float s, float t, float r) {
		((delegate* unmanaged<uint, float, float, float, void>) Context.GetProcAddress("glMultiTexCoord3fARB"))(target, s, t, r);
	}

	public static unsafe void MultiTexCoord3fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord3fvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord3iARB(uint target, int s, int t, int r) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord3iARB"))(target, s, t, r);
	}

	public static unsafe void MultiTexCoord3ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord3ivARB"))(target, v);
	}

	public static unsafe void MultiTexCoord3sARB(uint target, short s, short t, short r) {
		((delegate* unmanaged<uint, short, short, short, void>) Context.GetProcAddress("glMultiTexCoord3sARB"))(target, s, t, r);
	}

	public static unsafe void MultiTexCoord3svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord3svARB"))(target, v);
	}

	public static unsafe void MultiTexCoord3xOES(uint texture, int s, int t, int r) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord3xOES"))(texture, s, t, r);
	}

	public static unsafe void MultiTexCoord3xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord3xvOES"))(texture, coords);
	}

	public static unsafe void MultiTexCoord4dARB(uint target, double s, double t, double r, double q) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glMultiTexCoord4dARB"))(target, s, t, r, q);
	}

	public static unsafe void MultiTexCoord4dvARB(uint target, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glMultiTexCoord4dvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord4fARB(uint target, float s, float t, float r, float q) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glMultiTexCoord4fARB"))(target, s, t, r, q);
	}

	public static unsafe void MultiTexCoord4fvARB(uint target, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glMultiTexCoord4fvARB"))(target, v);
	}

	public static unsafe void MultiTexCoord4iARB(uint target, int s, int t, int r, int q) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord4iARB"))(target, s, t, r, q);
	}

	public static unsafe void MultiTexCoord4ivARB(uint target, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord4ivARB"))(target, v);
	}

	public static unsafe void MultiTexCoord4sARB(uint target, short s, short t, short r, short q) {
		((delegate* unmanaged<uint, short, short, short, short, void>) Context.GetProcAddress("glMultiTexCoord4sARB"))(target, s, t, r, q);
	}

	public static unsafe void MultiTexCoord4svARB(uint target, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glMultiTexCoord4svARB"))(target, v);
	}

	public static unsafe void MultiTexCoord4xOES(uint texture, int s, int t, int r, int q) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glMultiTexCoord4xOES"))(texture, s, t, r, q);
	}

	public static unsafe void MultiTexCoord4xvOES(uint texture, int* coords) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glMultiTexCoord4xvOES"))(texture, coords);
	}

	public static unsafe void NamedBufferData(uint buffer, nint size, void* data, uint usage) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glNamedBufferData"))(buffer, size, data, usage);
	}

	public static unsafe void NamedBufferStorage(uint buffer, nint size, void* data, uint flags) {
		((delegate* unmanaged<uint, nint, void*, uint, void>) Context.GetProcAddress("glNamedBufferStorage"))(buffer, size, data, flags);
	}

	public static unsafe void NamedBufferSubData(uint buffer, int* offset, nint size, void* data) {
		((delegate* unmanaged<uint, int*, nint, void*, void>) Context.GetProcAddress("glNamedBufferSubData"))(buffer, offset, size, data);
	}

	public static unsafe void NamedFramebufferDrawBuffer(uint framebuffer, uint buf) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glNamedFramebufferDrawBuffer"))(framebuffer, buf);
	}

	public static unsafe void NamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glNamedFramebufferDrawBuffers"))(framebuffer, n, bufs);
	}

	public static unsafe void NamedFramebufferParameteri(uint framebuffer, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glNamedFramebufferParameteri"))(framebuffer, pname, param);
	}

	public static unsafe void NamedFramebufferReadBuffer(uint framebuffer, uint src) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glNamedFramebufferReadBuffer"))(framebuffer, src);
	}

	public static unsafe void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glNamedFramebufferRenderbuffer"))(framebuffer, attachment, renderbuffertarget, renderbuffer);
	}

	public static unsafe void NamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v) {
		((delegate* unmanaged<uint, uint, int, float*, void>) Context.GetProcAddress("glNamedFramebufferSampleLocationsfvARB"))(framebuffer, start, count, v);
	}

	public static unsafe void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level) {
		((delegate* unmanaged<uint, uint, uint, int, void>) Context.GetProcAddress("glNamedFramebufferTexture"))(framebuffer, attachment, texture, level);
	}

	public static unsafe void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer) {
		((delegate* unmanaged<uint, uint, uint, int, int, void>) Context.GetProcAddress("glNamedFramebufferTextureLayer"))(framebuffer, attachment, texture, level, layer);
	}

	public static unsafe void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, uint, int, int, void>) Context.GetProcAddress("glNamedRenderbufferStorage"))(renderbuffer, internalformat, width, height);
	}

	public static unsafe void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glNamedRenderbufferStorageMultisample"))(renderbuffer, samples, internalformat, width, height);
	}

	public static unsafe void NamedStringARB(uint type, int namelen, char* name, int stringlen, char* str) {
		((delegate* unmanaged<uint, int, char*, int, char*, void>) Context.GetProcAddress("glNamedStringARB"))(type, namelen, name, stringlen, str);
	}

	public static unsafe void Normal3xOES(int nx, int ny, int nz) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glNormal3xOES"))(nx, ny, nz);
	}

	public static unsafe void Normal3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glNormal3xvOES"))(coords);
	}

	public static unsafe void ObjectLabel(uint identifier, uint name, int length, char* label) {
		((delegate* unmanaged<uint, uint, int, char*, void>) Context.GetProcAddress("glObjectLabel"))(identifier, name, length, label);
	}

	public static unsafe void ObjectPtrLabel(void* ptr, int length, char* label) {
		((delegate* unmanaged<void*, int, char*, void>) Context.GetProcAddress("glObjectPtrLabel"))(ptr, length, label);
	}

	public static unsafe void OrthoxOES(int l, int r, int b, int t, int n, int f) {
		((delegate* unmanaged<int, int, int, int, int, int, void>) Context.GetProcAddress("glOrthoxOES"))(l, r, b, t, n, f);
	}

	public static unsafe void PassThroughxOES(int token) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glPassThroughxOES"))(token);
	}

	public static unsafe void PatchParameterfv(uint pname, float* values) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glPatchParameterfv"))(pname, values);
	}

	public static unsafe void PatchParameteri(uint pname, int value) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPatchParameteri"))(pname, value);
	}

	public static unsafe void PauseTransformFeedback() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glPauseTransformFeedback"))();
	}

	public static unsafe void PixelMapx(uint map, int size, int* values) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glPixelMapx"))(map, size, values);
	}

	public static unsafe void PixelStoref(uint pname, float param) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glPixelStoref"))(pname, param);
	}

	public static unsafe void PixelStorei(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPixelStorei"))(pname, param);
	}

	public static unsafe void PixelStorex(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPixelStorex"))(pname, param);
	}

	public static unsafe void PixelTransferxOES(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPixelTransferxOES"))(pname, param);
	}

	public static unsafe void PixelZoomxOES(int xfactor, int yfactor) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glPixelZoomxOES"))(xfactor, yfactor);
	}

	public static unsafe void PointParameterf(uint pname, float param) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glPointParameterf"))(pname, param);
	}

	public static unsafe void PointParameterfv(uint pname, float* parameters) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glPointParameterfv"))(pname, parameters);
	}

	public static unsafe void PointParameteri(uint pname, int param) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glPointParameteri"))(pname, param);
	}

	public static unsafe void PointParameteriv(uint pname, int* parameters) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glPointParameteriv"))(pname, parameters);
	}

	public static unsafe void PointParameterxvOES(uint pname, int* parameters) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glPointParameterxvOES"))(pname, parameters);
	}

	public static unsafe void PointSize(float size) {
		((delegate* unmanaged<float, void>) Context.GetProcAddress("glPointSize"))(size);
	}

	public static unsafe void PointSizexOES(int size) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glPointSizexOES"))(size);
	}

	public static unsafe void PolygonMode(uint face, uint mode) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glPolygonMode"))(face, mode);
	}

	public static unsafe void PolygonOffset(float factor, float units) {
		((delegate* unmanaged<float, float, void>) Context.GetProcAddress("glPolygonOffset"))(factor, units);
	}

	public static unsafe void PolygonOffsetxOES(int factor, int units) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glPolygonOffsetxOES"))(factor, units);
	}

	public static unsafe void PopDebugGroup() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glPopDebugGroup"))();
	}

	public static unsafe void PrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) {
		((delegate* unmanaged<float, float, float, float, float, float, float, float, void>) Context.GetProcAddress("glPrimitiveBoundingBoxARB"))(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
	}

	public static unsafe void PrimitiveRestartIndex(uint index) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glPrimitiveRestartIndex"))(index);
	}

	public static unsafe void PrioritizeTexturesxOES(int n, uint* textures, int* priorities) {
		((delegate* unmanaged<int, uint*, int*, void>) Context.GetProcAddress("glPrioritizeTexturesxOES"))(n, textures, priorities);
	}

	public static unsafe void ProgramBinary(uint program, uint binaryFormat, void* binary, int length) {
		((delegate* unmanaged<uint, uint, void*, int, void>) Context.GetProcAddress("glProgramBinary"))(program, binaryFormat, binary, length);
	}

	public static unsafe void ProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, uint, double, double, double, double, void>) Context.GetProcAddress("glProgramEnvParameter4dARB"))(target, index, x, y, z, w);
	}

	public static unsafe void ProgramEnvParameter4dvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glProgramEnvParameter4dvARB"))(target, index, parameters);
	}

	public static unsafe void ProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, uint, float, float, float, float, void>) Context.GetProcAddress("glProgramEnvParameter4fARB"))(target, index, x, y, z, w);
	}

	public static unsafe void ProgramEnvParameter4fvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glProgramEnvParameter4fvARB"))(target, index, parameters);
	}

	public static unsafe void ProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, uint, double, double, double, double, void>) Context.GetProcAddress("glProgramLocalParameter4dARB"))(target, index, x, y, z, w);
	}

	public static unsafe void ProgramLocalParameter4dvARB(uint target, uint index, double* parameters) {
		((delegate* unmanaged<uint, uint, double*, void>) Context.GetProcAddress("glProgramLocalParameter4dvARB"))(target, index, parameters);
	}

	public static unsafe void ProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, uint, float, float, float, float, void>) Context.GetProcAddress("glProgramLocalParameter4fARB"))(target, index, x, y, z, w);
	}

	public static unsafe void ProgramLocalParameter4fvARB(uint target, uint index, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glProgramLocalParameter4fvARB"))(target, index, parameters);
	}

	public static unsafe void ProgramParameteri(uint program, uint pname, int value) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glProgramParameteri"))(program, pname, value);
	}

	public static unsafe void ProgramParameteriARB(uint program, uint pname, int value) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glProgramParameteriARB"))(program, pname, value);
	}

	public static unsafe void ProgramStringARB(uint target, uint format, int len, void* str) {
		((delegate* unmanaged<uint, uint, int, void*, void>) Context.GetProcAddress("glProgramStringARB"))(target, format, len, str);
	}

	public static unsafe void ProgramUniform1d(uint program, int location, double v0) {
		((delegate* unmanaged<uint, int, double, void>) Context.GetProcAddress("glProgramUniform1d"))(program, location, v0);
	}

	public static unsafe void ProgramUniform1dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform1dv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform1f(uint program, int location, float v0) {
		((delegate* unmanaged<uint, int, float, void>) Context.GetProcAddress("glProgramUniform1f"))(program, location, v0);
	}

	public static unsafe void ProgramUniform1fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform1fv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform1i(uint program, int location, int v0) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glProgramUniform1i"))(program, location, v0);
	}

	public static unsafe void ProgramUniform1i64ARB(uint program, int location, nint x) {
		((delegate* unmanaged<uint, int, nint, void>) Context.GetProcAddress("glProgramUniform1i64ARB"))(program, location, x);
	}

	public static unsafe void ProgramUniform1i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform1i64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform1iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform1iv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform1ui(uint program, int location, uint v0) {
		((delegate* unmanaged<uint, int, uint, void>) Context.GetProcAddress("glProgramUniform1ui"))(program, location, v0);
	}

	public static unsafe void ProgramUniform1ui64ARB(uint program, int location, nint x) {
		((delegate* unmanaged<uint, int, nint, void>) Context.GetProcAddress("glProgramUniform1ui64ARB"))(program, location, x);
	}

	public static unsafe void ProgramUniform1ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform1ui64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform1uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform1uiv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform2d(uint program, int location, double v0, double v1) {
		((delegate* unmanaged<uint, int, double, double, void>) Context.GetProcAddress("glProgramUniform2d"))(program, location, v0, v1);
	}

	public static unsafe void ProgramUniform2dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform2dv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform2f(uint program, int location, float v0, float v1) {
		((delegate* unmanaged<uint, int, float, float, void>) Context.GetProcAddress("glProgramUniform2f"))(program, location, v0, v1);
	}

	public static unsafe void ProgramUniform2fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform2fv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform2i(uint program, int location, int v0, int v1) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glProgramUniform2i"))(program, location, v0, v1);
	}

	public static unsafe void ProgramUniform2i64ARB(uint program, int location, nint x, nint y) {
		((delegate* unmanaged<uint, int, nint, nint, void>) Context.GetProcAddress("glProgramUniform2i64ARB"))(program, location, x, y);
	}

	public static unsafe void ProgramUniform2i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform2i64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform2iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform2iv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform2ui(uint program, int location, uint v0, uint v1) {
		((delegate* unmanaged<uint, int, uint, uint, void>) Context.GetProcAddress("glProgramUniform2ui"))(program, location, v0, v1);
	}

	public static unsafe void ProgramUniform2ui64ARB(uint program, int location, nint x, nint y) {
		((delegate* unmanaged<uint, int, nint, nint, void>) Context.GetProcAddress("glProgramUniform2ui64ARB"))(program, location, x, y);
	}

	public static unsafe void ProgramUniform2ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform2ui64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform2uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform2uiv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform3d(uint program, int location, double v0, double v1, double v2) {
		((delegate* unmanaged<uint, int, double, double, double, void>) Context.GetProcAddress("glProgramUniform3d"))(program, location, v0, v1, v2);
	}

	public static unsafe void ProgramUniform3dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform3dv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform3f(uint program, int location, float v0, float v1, float v2) {
		((delegate* unmanaged<uint, int, float, float, float, void>) Context.GetProcAddress("glProgramUniform3f"))(program, location, v0, v1, v2);
	}

	public static unsafe void ProgramUniform3fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform3fv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform3i(uint program, int location, int v0, int v1, int v2) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glProgramUniform3i"))(program, location, v0, v1, v2);
	}

	public static unsafe void ProgramUniform3i64ARB(uint program, int location, nint x, nint y, nint z) {
		((delegate* unmanaged<uint, int, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform3i64ARB"))(program, location, x, y, z);
	}

	public static unsafe void ProgramUniform3i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform3i64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform3iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform3iv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) {
		((delegate* unmanaged<uint, int, uint, uint, uint, void>) Context.GetProcAddress("glProgramUniform3ui"))(program, location, v0, v1, v2);
	}

	public static unsafe void ProgramUniform3ui64ARB(uint program, int location, nint x, nint y, nint z) {
		((delegate* unmanaged<uint, int, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform3ui64ARB"))(program, location, x, y, z);
	}

	public static unsafe void ProgramUniform3ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform3ui64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform3uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform3uiv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) {
		((delegate* unmanaged<uint, int, double, double, double, double, void>) Context.GetProcAddress("glProgramUniform4d"))(program, location, v0, v1, v2, v3);
	}

	public static unsafe void ProgramUniform4dv(uint program, int location, int count, double* value) {
		((delegate* unmanaged<uint, int, int, double*, void>) Context.GetProcAddress("glProgramUniform4dv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) {
		((delegate* unmanaged<uint, int, float, float, float, float, void>) Context.GetProcAddress("glProgramUniform4f"))(program, location, v0, v1, v2, v3);
	}

	public static unsafe void ProgramUniform4fv(uint program, int location, int count, float* value) {
		((delegate* unmanaged<uint, int, int, float*, void>) Context.GetProcAddress("glProgramUniform4fv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) {
		((delegate* unmanaged<uint, int, int, int, int, int, void>) Context.GetProcAddress("glProgramUniform4i"))(program, location, v0, v1, v2, v3);
	}

	public static unsafe void ProgramUniform4i64ARB(uint program, int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<uint, int, nint, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform4i64ARB"))(program, location, x, y, z, w);
	}

	public static unsafe void ProgramUniform4i64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform4i64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform4iv(uint program, int location, int count, int* value) {
		((delegate* unmanaged<uint, int, int, int*, void>) Context.GetProcAddress("glProgramUniform4iv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) {
		((delegate* unmanaged<uint, int, uint, uint, uint, uint, void>) Context.GetProcAddress("glProgramUniform4ui"))(program, location, v0, v1, v2, v3);
	}

	public static unsafe void ProgramUniform4ui64ARB(uint program, int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<uint, int, nint, nint, nint, nint, void>) Context.GetProcAddress("glProgramUniform4ui64ARB"))(program, location, x, y, z, w);
	}

	public static unsafe void ProgramUniform4ui64vARB(uint program, int location, int count, nint* value) {
		((delegate* unmanaged<uint, int, int, nint*, void>) Context.GetProcAddress("glProgramUniform4ui64vARB"))(program, location, count, value);
	}

	public static unsafe void ProgramUniform4uiv(uint program, int location, int count, uint* value) {
		((delegate* unmanaged<uint, int, int, uint*, void>) Context.GetProcAddress("glProgramUniform4uiv"))(program, location, count, value);
	}

	public static unsafe void ProgramUniformMatrix2dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix2dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix2fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix2x3dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix2x3dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix2x3fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix2x4dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix2x4dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix2x4fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix3dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix3dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix3fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix3x2dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix3x2dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix3x2fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix3x4dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix3x4dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix3x4fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix4dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix4dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix4fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix4x2dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix4x2dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix4x2fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix4x3dv(uint program, int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<uint, int, int, byte, double*, void>) Context.GetProcAddress("glProgramUniformMatrix4x3dv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<uint, int, int, byte, float*, void>) Context.GetProcAddress("glProgramUniformMatrix4x3fv"))(program, location, count, transpose, value);
	}

	public static unsafe void ProvokingVertex(uint mode) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glProvokingVertex"))(mode);
	}

	public static unsafe void PushDebugGroup(uint source, uint id, int length, char* message) {
		((delegate* unmanaged<uint, uint, int, char*, void>) Context.GetProcAddress("glPushDebugGroup"))(source, id, length, message);
	}

	public static unsafe void QueryCounter(uint id, uint target) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glQueryCounter"))(id, target);
	}

	public static unsafe void RasterPos2xOES(int x, int y) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glRasterPos2xOES"))(x, y);
	}

	public static unsafe void RasterPos2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glRasterPos2xvOES"))(coords);
	}

	public static unsafe void RasterPos3xOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glRasterPos3xOES"))(x, y, z);
	}

	public static unsafe void RasterPos3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glRasterPos3xvOES"))(coords);
	}

	public static unsafe void RasterPos4xOES(int x, int y, int z, int w) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glRasterPos4xOES"))(x, y, z, w);
	}

	public static unsafe void RasterPos4xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glRasterPos4xvOES"))(coords);
	}

	public static unsafe void ReadBuffer(uint src) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glReadBuffer"))(src);
	}

	public static unsafe void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) {
		((delegate* unmanaged<int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glReadPixels"))(x, y, width, height, format, type, pixels);
	}

	public static unsafe void RectxOES(int x1, int y1, int x2, int y2) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glRectxOES"))(x1, y1, x2, y2);
	}

	public static unsafe void RectxvOES(int* v1, int* v2) {
		((delegate* unmanaged<int*, int*, void>) Context.GetProcAddress("glRectxvOES"))(v1, v2);
	}

	public static unsafe void ReleaseShaderCompiler() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glReleaseShaderCompiler"))();
	}

	public static unsafe void RenderbufferStorage(uint target, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorage"))(target, internalformat, width, height);
	}

	public static unsafe void RenderbufferStorageEXT(uint target, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorageEXT"))(target, internalformat, width, height);
	}

	public static unsafe void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorageMultisample"))(target, samples, internalformat, width, height);
	}

	public static unsafe void RenderbufferStorageMultisampleEXT(uint target, int samples, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glRenderbufferStorageMultisampleEXT"))(target, samples, internalformat, width, height);
	}

	public static unsafe void ResumeTransformFeedback() {
	((delegate* unmanaged<void>) Context.GetProcAddress("glResumeTransformFeedback"))();
	}

	public static unsafe void RotatexOES(int angle, int x, int y, int z) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glRotatexOES"))(angle, x, y, z);
	}

	public static unsafe void SampleCoverage(float value, byte invert) {
		((delegate* unmanaged<float, byte, void>) Context.GetProcAddress("glSampleCoverage"))(value, invert);
	}

	public static unsafe void SampleCoverageARB(float value, byte invert) {
		((delegate* unmanaged<float, byte, void>) Context.GetProcAddress("glSampleCoverageARB"))(value, invert);
	}

	public static unsafe void SampleMaski(uint maskNumber, uint mask) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glSampleMaski"))(maskNumber, mask);
	}

	public static unsafe void SamplerParameterIiv(uint sampler, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glSamplerParameterIiv"))(sampler, pname, param);
	}

	public static unsafe void SamplerParameterIuiv(uint sampler, uint pname, uint* param) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glSamplerParameterIuiv"))(sampler, pname, param);
	}

	public static unsafe void SamplerParameterf(uint sampler, uint pname, float param) {
		((delegate* unmanaged<uint, uint, float, void>) Context.GetProcAddress("glSamplerParameterf"))(sampler, pname, param);
	}

	public static unsafe void SamplerParameterfv(uint sampler, uint pname, float* param) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glSamplerParameterfv"))(sampler, pname, param);
	}

	public static unsafe void SamplerParameteri(uint sampler, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glSamplerParameteri"))(sampler, pname, param);
	}

	public static unsafe void SamplerParameteriv(uint sampler, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glSamplerParameteriv"))(sampler, pname, param);
	}

	public static unsafe void ScalexOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glScalexOES"))(x, y, z);
	}

	public static unsafe void Scissor(int x, int y, int width, int height) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glScissor"))(x, y, width, height);
	}

	public static unsafe void ScissorArrayv(uint first, int count, int* v) {
		((delegate* unmanaged<uint, int, int*, void>) Context.GetProcAddress("glScissorArrayv"))(first, count, v);
	}

	public static unsafe void ScissorIndexed(uint index, int left, int bottom, int width, int height) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glScissorIndexed"))(index, left, bottom, width, height);
	}

	public static unsafe void ScissorIndexedv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glScissorIndexedv"))(index, v);
	}

	public static unsafe void ShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length) {
		((delegate* unmanaged<int, uint*, uint, void*, int, void>) Context.GetProcAddress("glShaderBinary"))(count, shaders, binaryFormat, binary, length);
	}

	public static unsafe void ShaderSource(uint shader, int count, char** str, int* length) {
		((delegate* unmanaged<uint, int, char**, int*, void>) Context.GetProcAddress("glShaderSource"))(shader, count, str, length);
	}

	public static unsafe void ShaderSourceARB(uint shaderObj, int count, char** str, int* length) {
		((delegate* unmanaged<uint, int, char**, int*, void>) Context.GetProcAddress("glShaderSourceARB"))(shaderObj, count, str, length);
	}

	public static unsafe void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glShaderStorageBlockBinding"))(program, storageBlockIndex, storageBlockBinding);
	}

	public static unsafe void SpecializeShaderARB(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) {
		((delegate* unmanaged<uint, char*, uint, uint*, uint*, void>) Context.GetProcAddress("glSpecializeShaderARB"))(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
	}

	public static unsafe void StencilFunc(uint func, int reference, uint mask) {
		((delegate* unmanaged<uint, int, uint, void>) Context.GetProcAddress("glStencilFunc"))(func, reference, mask);
	}

	public static unsafe void StencilFuncSeparate(uint face, uint func, int reference, uint mask) {
		((delegate* unmanaged<uint, uint, int, uint, void>) Context.GetProcAddress("glStencilFuncSeparate"))(face, func, reference, mask);
	}

	public static unsafe void StencilMask(uint mask) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glStencilMask"))(mask);
	}

	public static unsafe void StencilMaskSeparate(uint face, uint mask) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glStencilMaskSeparate"))(face, mask);
	}

	public static unsafe void StencilOp(uint fail, uint zfail, uint zpass) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glStencilOp"))(fail, zfail, zpass);
	}

	public static unsafe void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glStencilOpSeparate"))(face, sfail, dpfail, dppass);
	}

	public static unsafe void TexBuffer(uint target, uint internalformat, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glTexBuffer"))(target, internalformat, buffer);
	}

	public static unsafe void TexBufferRange(uint target, uint internalformat, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glTexBufferRange"))(target, internalformat, buffer, offset, size);
	}

	public static unsafe void TexCoord1xOES(int s) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glTexCoord1xOES"))(s);
	}

	public static unsafe void TexCoord1xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord1xvOES"))(coords);
	}

	public static unsafe void TexCoord2xOES(int s, int t) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glTexCoord2xOES"))(s, t);
	}

	public static unsafe void TexCoord2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord2xvOES"))(coords);
	}

	public static unsafe void TexCoord3xOES(int s, int t, int r) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glTexCoord3xOES"))(s, t, r);
	}

	public static unsafe void TexCoord3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord3xvOES"))(coords);
	}

	public static unsafe void TexCoord4xOES(int s, int t, int r, int q) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glTexCoord4xOES"))(s, t, r, q);
	}

	public static unsafe void TexCoord4xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glTexCoord4xvOES"))(coords);
	}

	public static unsafe void TexEnvxOES(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexEnvxOES"))(target, pname, param);
	}

	public static unsafe void TexEnvxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexEnvxvOES"))(target, pname, parameters);
	}

	public static unsafe void TexGenxOES(uint coord, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexGenxOES"))(coord, pname, param);
	}

	public static unsafe void TexGenxvOES(uint coord, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexGenxvOES"))(coord, pname, parameters);
	}

	public static unsafe void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexImage1D"))(target, level, internalformat, width, border, format, type, pixels);
	}

	public static unsafe void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexImage2D"))(target, level, internalformat, width, height, border, format, type, pixels);
	}

	public static unsafe void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, byte, void>) Context.GetProcAddress("glTexImage2DMultisample"))(target, samples, internalformat, width, height, fixedsamplelocations);
	}

	public static unsafe void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexImage3D"))(target, level, internalformat, width, height, depth, border, format, type, pixels);
	}

	public static unsafe void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, int, byte, void>) Context.GetProcAddress("glTexImage3DMultisample"))(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	public static unsafe void TexParameterIiv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexParameterIiv"))(target, pname, parameters);
	}

	public static unsafe void TexParameterIuiv(uint target, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glTexParameterIuiv"))(target, pname, parameters);
	}

	public static unsafe void TexParameterf(uint target, uint pname, float param) {
		((delegate* unmanaged<uint, uint, float, void>) Context.GetProcAddress("glTexParameterf"))(target, pname, param);
	}

	public static unsafe void TexParameterfv(uint target, uint pname, float* parameters) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glTexParameterfv"))(target, pname, parameters);
	}

	public static unsafe void TexParameteri(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexParameteri"))(target, pname, param);
	}

	public static unsafe void TexParameteriv(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexParameteriv"))(target, pname, parameters);
	}

	public static unsafe void TexParameterxOES(uint target, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTexParameterxOES"))(target, pname, param);
	}

	public static unsafe void TexParameterxvOES(uint target, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTexParameterxvOES"))(target, pname, parameters);
	}

	public static unsafe void TexStorage1D(uint target, int levels, uint internalformat, int width) {
		((delegate* unmanaged<uint, int, uint, int, void>) Context.GetProcAddress("glTexStorage1D"))(target, levels, internalformat, width);
	}

	public static unsafe void TexStorage2D(uint target, int levels, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glTexStorage2D"))(target, levels, internalformat, width, height);
	}

	public static unsafe void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, byte, void>) Context.GetProcAddress("glTexStorage2DMultisample"))(target, samples, internalformat, width, height, fixedsamplelocations);
	}

	public static unsafe void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void>) Context.GetProcAddress("glTexStorage3D"))(target, levels, internalformat, width, height, depth);
	}

	public static unsafe void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, int, byte, void>) Context.GetProcAddress("glTexStorage3DMultisample"))(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	public static unsafe void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexSubImage1D"))(target, level, xoffset, width, format, type, pixels);
	}

	public static unsafe void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexSubImage2D"))(target, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	public static unsafe void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTexSubImage3D"))(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	public static unsafe void TextureBuffer(uint texture, uint internalformat, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glTextureBuffer"))(texture, internalformat, buffer);
	}

	public static unsafe void TextureBufferRange(uint texture, uint internalformat, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glTextureBufferRange"))(texture, internalformat, buffer, offset, size);
	}

	public static unsafe void TextureParameterIiv(uint texture, uint pname, int* parameters) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTextureParameterIiv"))(texture, pname, parameters);
	}

	public static unsafe void TextureParameterIuiv(uint texture, uint pname, uint* parameters) {
		((delegate* unmanaged<uint, uint, uint*, void>) Context.GetProcAddress("glTextureParameterIuiv"))(texture, pname, parameters);
	}

	public static unsafe void TextureParameterf(uint texture, uint pname, float param) {
		((delegate* unmanaged<uint, uint, float, void>) Context.GetProcAddress("glTextureParameterf"))(texture, pname, param);
	}

	public static unsafe void TextureParameterfv(uint texture, uint pname, float* param) {
		((delegate* unmanaged<uint, uint, float*, void>) Context.GetProcAddress("glTextureParameterfv"))(texture, pname, param);
	}

	public static unsafe void TextureParameteri(uint texture, uint pname, int param) {
		((delegate* unmanaged<uint, uint, int, void>) Context.GetProcAddress("glTextureParameteri"))(texture, pname, param);
	}

	public static unsafe void TextureParameteriv(uint texture, uint pname, int* param) {
		((delegate* unmanaged<uint, uint, int*, void>) Context.GetProcAddress("glTextureParameteriv"))(texture, pname, param);
	}

	public static unsafe void TextureStorage1D(uint texture, int levels, uint internalformat, int width) {
		((delegate* unmanaged<uint, int, uint, int, void>) Context.GetProcAddress("glTextureStorage1D"))(texture, levels, internalformat, width);
	}

	public static unsafe void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height) {
		((delegate* unmanaged<uint, int, uint, int, int, void>) Context.GetProcAddress("glTextureStorage2D"))(texture, levels, internalformat, width, height);
	}

	public static unsafe void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, byte, void>) Context.GetProcAddress("glTextureStorage2DMultisample"))(texture, samples, internalformat, width, height, fixedsamplelocations);
	}

	public static unsafe void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth) {
		((delegate* unmanaged<uint, int, uint, int, int, int, void>) Context.GetProcAddress("glTextureStorage3D"))(texture, levels, internalformat, width, height, depth);
	}

	public static unsafe void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		((delegate* unmanaged<uint, int, uint, int, int, int, byte, void>) Context.GetProcAddress("glTextureStorage3DMultisample"))(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	public static unsafe void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTextureSubImage1D"))(texture, level, xoffset, width, format, type, pixels);
	}

	public static unsafe void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTextureSubImage2D"))(texture, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	public static unsafe void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) {
		((delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void>) Context.GetProcAddress("glTextureSubImage3D"))(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	public static unsafe void TextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glTextureView"))(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
	}

	public static unsafe void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glTransformFeedbackBufferBase"))(xfb, index, buffer);
	}

	public static unsafe void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int* offset, nint size) {
		((delegate* unmanaged<uint, uint, uint, int*, nint, void>) Context.GetProcAddress("glTransformFeedbackBufferRange"))(xfb, index, buffer, offset, size);
	}

	public static unsafe void TransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode) {
		((delegate* unmanaged<uint, int, char**, uint, void>) Context.GetProcAddress("glTransformFeedbackVaryings"))(program, count, varyings, bufferMode);
	}

	public static unsafe void TranslatexOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glTranslatexOES"))(x, y, z);
	}

	public static unsafe void Uniform1d(int location, double x) {
		((delegate* unmanaged<int, double, void>) Context.GetProcAddress("glUniform1d"))(location, x);
	}

	public static unsafe void Uniform1dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform1dv"))(location, count, value);
	}

	public static unsafe void Uniform1f(int location, float v0) {
		((delegate* unmanaged<int, float, void>) Context.GetProcAddress("glUniform1f"))(location, v0);
	}

	public static unsafe void Uniform1fARB(int location, float v0) {
		((delegate* unmanaged<int, float, void>) Context.GetProcAddress("glUniform1fARB"))(location, v0);
	}

	public static unsafe void Uniform1fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform1fv"))(location, count, value);
	}

	public static unsafe void Uniform1fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform1fvARB"))(location, count, value);
	}

	public static unsafe void Uniform1i(int location, int v0) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glUniform1i"))(location, v0);
	}

	public static unsafe void Uniform1i64ARB(int location, nint x) {
		((delegate* unmanaged<int, nint, void>) Context.GetProcAddress("glUniform1i64ARB"))(location, x);
	}

	public static unsafe void Uniform1i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform1i64vARB"))(location, count, value);
	}

	public static unsafe void Uniform1iARB(int location, int v0) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glUniform1iARB"))(location, v0);
	}

	public static unsafe void Uniform1iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform1iv"))(location, count, value);
	}

	public static unsafe void Uniform1ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform1ivARB"))(location, count, value);
	}

	public static unsafe void Uniform1ui(int location, uint v0) {
		((delegate* unmanaged<int, uint, void>) Context.GetProcAddress("glUniform1ui"))(location, v0);
	}

	public static unsafe void Uniform1ui64ARB(int location, nint x) {
		((delegate* unmanaged<int, nint, void>) Context.GetProcAddress("glUniform1ui64ARB"))(location, x);
	}

	public static unsafe void Uniform1ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform1ui64vARB"))(location, count, value);
	}

	public static unsafe void Uniform1uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform1uiv"))(location, count, value);
	}

	public static unsafe void Uniform2d(int location, double x, double y) {
		((delegate* unmanaged<int, double, double, void>) Context.GetProcAddress("glUniform2d"))(location, x, y);
	}

	public static unsafe void Uniform2dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform2dv"))(location, count, value);
	}

	public static unsafe void Uniform2f(int location, float v0, float v1) {
		((delegate* unmanaged<int, float, float, void>) Context.GetProcAddress("glUniform2f"))(location, v0, v1);
	}

	public static unsafe void Uniform2fARB(int location, float v0, float v1) {
		((delegate* unmanaged<int, float, float, void>) Context.GetProcAddress("glUniform2fARB"))(location, v0, v1);
	}

	public static unsafe void Uniform2fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform2fv"))(location, count, value);
	}

	public static unsafe void Uniform2fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform2fvARB"))(location, count, value);
	}

	public static unsafe void Uniform2i(int location, int v0, int v1) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glUniform2i"))(location, v0, v1);
	}

	public static unsafe void Uniform2i64ARB(int location, nint x, nint y) {
		((delegate* unmanaged<int, nint, nint, void>) Context.GetProcAddress("glUniform2i64ARB"))(location, x, y);
	}

	public static unsafe void Uniform2i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform2i64vARB"))(location, count, value);
	}

	public static unsafe void Uniform2iARB(int location, int v0, int v1) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glUniform2iARB"))(location, v0, v1);
	}

	public static unsafe void Uniform2iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform2iv"))(location, count, value);
	}

	public static unsafe void Uniform2ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform2ivARB"))(location, count, value);
	}

	public static unsafe void Uniform2ui(int location, uint v0, uint v1) {
		((delegate* unmanaged<int, uint, uint, void>) Context.GetProcAddress("glUniform2ui"))(location, v0, v1);
	}

	public static unsafe void Uniform2ui64ARB(int location, nint x, nint y) {
		((delegate* unmanaged<int, nint, nint, void>) Context.GetProcAddress("glUniform2ui64ARB"))(location, x, y);
	}

	public static unsafe void Uniform2ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform2ui64vARB"))(location, count, value);
	}

	public static unsafe void Uniform2uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform2uiv"))(location, count, value);
	}

	public static unsafe void Uniform3d(int location, double x, double y, double z) {
		((delegate* unmanaged<int, double, double, double, void>) Context.GetProcAddress("glUniform3d"))(location, x, y, z);
	}

	public static unsafe void Uniform3dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform3dv"))(location, count, value);
	}

	public static unsafe void Uniform3f(int location, float v0, float v1, float v2) {
		((delegate* unmanaged<int, float, float, float, void>) Context.GetProcAddress("glUniform3f"))(location, v0, v1, v2);
	}

	public static unsafe void Uniform3fARB(int location, float v0, float v1, float v2) {
		((delegate* unmanaged<int, float, float, float, void>) Context.GetProcAddress("glUniform3fARB"))(location, v0, v1, v2);
	}

	public static unsafe void Uniform3fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform3fv"))(location, count, value);
	}

	public static unsafe void Uniform3fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform3fvARB"))(location, count, value);
	}

	public static unsafe void Uniform3i(int location, int v0, int v1, int v2) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glUniform3i"))(location, v0, v1, v2);
	}

	public static unsafe void Uniform3i64ARB(int location, nint x, nint y, nint z) {
		((delegate* unmanaged<int, nint, nint, nint, void>) Context.GetProcAddress("glUniform3i64ARB"))(location, x, y, z);
	}

	public static unsafe void Uniform3i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform3i64vARB"))(location, count, value);
	}

	public static unsafe void Uniform3iARB(int location, int v0, int v1, int v2) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glUniform3iARB"))(location, v0, v1, v2);
	}

	public static unsafe void Uniform3iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform3iv"))(location, count, value);
	}

	public static unsafe void Uniform3ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform3ivARB"))(location, count, value);
	}

	public static unsafe void Uniform3ui(int location, uint v0, uint v1, uint v2) {
		((delegate* unmanaged<int, uint, uint, uint, void>) Context.GetProcAddress("glUniform3ui"))(location, v0, v1, v2);
	}

	public static unsafe void Uniform3ui64ARB(int location, nint x, nint y, nint z) {
		((delegate* unmanaged<int, nint, nint, nint, void>) Context.GetProcAddress("glUniform3ui64ARB"))(location, x, y, z);
	}

	public static unsafe void Uniform3ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform3ui64vARB"))(location, count, value);
	}

	public static unsafe void Uniform3uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform3uiv"))(location, count, value);
	}

	public static unsafe void Uniform4d(int location, double x, double y, double z, double w) {
		((delegate* unmanaged<int, double, double, double, double, void>) Context.GetProcAddress("glUniform4d"))(location, x, y, z, w);
	}

	public static unsafe void Uniform4dv(int location, int count, double* value) {
		((delegate* unmanaged<int, int, double*, void>) Context.GetProcAddress("glUniform4dv"))(location, count, value);
	}

	public static unsafe void Uniform4f(int location, float v0, float v1, float v2, float v3) {
		((delegate* unmanaged<int, float, float, float, float, void>) Context.GetProcAddress("glUniform4f"))(location, v0, v1, v2, v3);
	}

	public static unsafe void Uniform4fARB(int location, float v0, float v1, float v2, float v3) {
		((delegate* unmanaged<int, float, float, float, float, void>) Context.GetProcAddress("glUniform4fARB"))(location, v0, v1, v2, v3);
	}

	public static unsafe void Uniform4fv(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform4fv"))(location, count, value);
	}

	public static unsafe void Uniform4fvARB(int location, int count, float* value) {
		((delegate* unmanaged<int, int, float*, void>) Context.GetProcAddress("glUniform4fvARB"))(location, count, value);
	}

	public static unsafe void Uniform4i(int location, int v0, int v1, int v2, int v3) {
		((delegate* unmanaged<int, int, int, int, int, void>) Context.GetProcAddress("glUniform4i"))(location, v0, v1, v2, v3);
	}

	public static unsafe void Uniform4i64ARB(int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<int, nint, nint, nint, nint, void>) Context.GetProcAddress("glUniform4i64ARB"))(location, x, y, z, w);
	}

	public static unsafe void Uniform4i64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform4i64vARB"))(location, count, value);
	}

	public static unsafe void Uniform4iARB(int location, int v0, int v1, int v2, int v3) {
		((delegate* unmanaged<int, int, int, int, int, void>) Context.GetProcAddress("glUniform4iARB"))(location, v0, v1, v2, v3);
	}

	public static unsafe void Uniform4iv(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform4iv"))(location, count, value);
	}

	public static unsafe void Uniform4ivARB(int location, int count, int* value) {
		((delegate* unmanaged<int, int, int*, void>) Context.GetProcAddress("glUniform4ivARB"))(location, count, value);
	}

	public static unsafe void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) {
		((delegate* unmanaged<int, uint, uint, uint, uint, void>) Context.GetProcAddress("glUniform4ui"))(location, v0, v1, v2, v3);
	}

	public static unsafe void Uniform4ui64ARB(int location, nint x, nint y, nint z, nint w) {
		((delegate* unmanaged<int, nint, nint, nint, nint, void>) Context.GetProcAddress("glUniform4ui64ARB"))(location, x, y, z, w);
	}

	public static unsafe void Uniform4ui64vARB(int location, int count, nint* value) {
		((delegate* unmanaged<int, int, nint*, void>) Context.GetProcAddress("glUniform4ui64vARB"))(location, count, value);
	}

	public static unsafe void Uniform4uiv(int location, int count, uint* value) {
		((delegate* unmanaged<int, int, uint*, void>) Context.GetProcAddress("glUniform4uiv"))(location, count, value);
	}

	public static unsafe void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glUniformBlockBinding"))(program, uniformBlockIndex, uniformBlockBinding);
	}

	public static unsafe void UniformMatrix2dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix2dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix2fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix2fvARB(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2fvARB"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix2x3dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix2x3dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix2x3fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2x3fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix2x4dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix2x4dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix2x4fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix2x4fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix3dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix3dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix3fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix3fvARB(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3fvARB"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix3x2dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix3x2dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix3x2fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3x2fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix3x4dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix3x4dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix3x4fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix3x4fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix4dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix4dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix4fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix4fvARB(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4fvARB"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix4x2dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix4x2dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix4x2fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4x2fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix4x3dv(int location, int count, byte transpose, double* value) {
		((delegate* unmanaged<int, int, byte, double*, void>) Context.GetProcAddress("glUniformMatrix4x3dv"))(location, count, transpose, value);
	}

	public static unsafe void UniformMatrix4x3fv(int location, int count, byte transpose, float* value) {
		((delegate* unmanaged<int, int, byte, float*, void>) Context.GetProcAddress("glUniformMatrix4x3fv"))(location, count, transpose, value);
	}

	public static unsafe void UniformSubroutinesuiv(uint shadertype, int count, uint* indices) {
		((delegate* unmanaged<uint, int, uint*, void>) Context.GetProcAddress("glUniformSubroutinesuiv"))(shadertype, count, indices);
	}

	public static unsafe byte UnmapBuffer(uint target) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glUnmapBuffer"))(target);
	}

	public static unsafe byte UnmapBufferARB(uint target) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glUnmapBufferARB"))(target);
	}

	public static unsafe byte UnmapNamedBuffer(uint buffer) {
		return ((delegate* unmanaged<uint, byte>) Context.GetProcAddress("glUnmapNamedBuffer"))(buffer);
	}

	public static unsafe void UseProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glUseProgram"))(program);
	}

	public static unsafe void UseProgramObjectARB(uint programObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glUseProgramObjectARB"))(programObj);
	}

	public static unsafe void UseProgramStages(uint pipeline, uint stages, uint program) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glUseProgramStages"))(pipeline, stages, program);
	}

	public static unsafe void ValidateProgram(uint program) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glValidateProgram"))(program);
	}

	public static unsafe void ValidateProgramARB(uint programObj) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glValidateProgramARB"))(programObj);
	}

	public static unsafe void ValidateProgramPipeline(uint pipeline) {
		((delegate* unmanaged<uint, void>) Context.GetProcAddress("glValidateProgramPipeline"))(pipeline);
	}

	public static unsafe void Vertex2xOES(int x) {
		((delegate* unmanaged<int, void>) Context.GetProcAddress("glVertex2xOES"))(x);
	}

	public static unsafe void Vertex2xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glVertex2xvOES"))(coords);
	}

	public static unsafe void Vertex3xOES(int x, int y) {
		((delegate* unmanaged<int, int, void>) Context.GetProcAddress("glVertex3xOES"))(x, y);
	}

	public static unsafe void Vertex3xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glVertex3xvOES"))(coords);
	}

	public static unsafe void Vertex4xOES(int x, int y, int z) {
		((delegate* unmanaged<int, int, int, void>) Context.GetProcAddress("glVertex4xOES"))(x, y, z);
	}

	public static unsafe void Vertex4xvOES(int* coords) {
		((delegate* unmanaged<int*, void>) Context.GetProcAddress("glVertex4xvOES"))(coords);
	}

	public static unsafe void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glVertexArrayAttribBinding"))(vaobj, attribindex, bindingindex);
	}

	public static unsafe void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset) {
		((delegate* unmanaged<uint, uint, int, uint, byte, uint, void>) Context.GetProcAddress("glVertexArrayAttribFormat"))(vaobj, attribindex, size, type, normalized, relativeoffset);
	}

	public static unsafe void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, uint, int, uint, uint, void>) Context.GetProcAddress("glVertexArrayAttribIFormat"))(vaobj, attribindex, size, type, relativeoffset);
	}

	public static unsafe void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, uint, int, uint, uint, void>) Context.GetProcAddress("glVertexArrayAttribLFormat"))(vaobj, attribindex, size, type, relativeoffset);
	}

	public static unsafe void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glVertexArrayBindingDivisor"))(vaobj, bindingindex, divisor);
	}

	public static unsafe void VertexArrayElementBuffer(uint vaobj, uint buffer) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexArrayElementBuffer"))(vaobj, buffer);
	}

	public static unsafe void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int* offset, int stride) {
		((delegate* unmanaged<uint, uint, uint, int*, int, void>) Context.GetProcAddress("glVertexArrayVertexBuffer"))(vaobj, bindingindex, buffer, offset, stride);
	}

	public static unsafe void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, int** offsets, int* strides) {
		((delegate* unmanaged<uint, uint, int, uint*, int**, int*, void>) Context.GetProcAddress("glVertexArrayVertexBuffers"))(vaobj, first, count, buffers, offsets, strides);
	}

	public static unsafe void VertexAttrib1d(uint index, double x) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glVertexAttrib1d"))(index, x);
	}

	public static unsafe void VertexAttrib1dARB(uint index, double x) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glVertexAttrib1dARB"))(index, x);
	}

	public static unsafe void VertexAttrib1dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib1dv"))(index, v);
	}

	public static unsafe void VertexAttrib1dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib1dvARB"))(index, v);
	}

	public static unsafe void VertexAttrib1f(uint index, float x) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glVertexAttrib1f"))(index, x);
	}

	public static unsafe void VertexAttrib1fARB(uint index, float x) {
		((delegate* unmanaged<uint, float, void>) Context.GetProcAddress("glVertexAttrib1fARB"))(index, x);
	}

	public static unsafe void VertexAttrib1fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib1fv"))(index, v);
	}

	public static unsafe void VertexAttrib1fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib1fvARB"))(index, v);
	}

	public static unsafe void VertexAttrib1s(uint index, short x) {
		((delegate* unmanaged<uint, short, void>) Context.GetProcAddress("glVertexAttrib1s"))(index, x);
	}

	public static unsafe void VertexAttrib1sARB(uint index, short x) {
		((delegate* unmanaged<uint, short, void>) Context.GetProcAddress("glVertexAttrib1sARB"))(index, x);
	}

	public static unsafe void VertexAttrib1sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib1sv"))(index, v);
	}

	public static unsafe void VertexAttrib1svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib1svARB"))(index, v);
	}

	public static unsafe void VertexAttrib2d(uint index, double x, double y) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glVertexAttrib2d"))(index, x, y);
	}

	public static unsafe void VertexAttrib2dARB(uint index, double x, double y) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glVertexAttrib2dARB"))(index, x, y);
	}

	public static unsafe void VertexAttrib2dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib2dv"))(index, v);
	}

	public static unsafe void VertexAttrib2dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib2dvARB"))(index, v);
	}

	public static unsafe void VertexAttrib2f(uint index, float x, float y) {
		((delegate* unmanaged<uint, float, float, void>) Context.GetProcAddress("glVertexAttrib2f"))(index, x, y);
	}

	public static unsafe void VertexAttrib2fARB(uint index, float x, float y) {
		((delegate* unmanaged<uint, float, float, void>) Context.GetProcAddress("glVertexAttrib2fARB"))(index, x, y);
	}

	public static unsafe void VertexAttrib2fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib2fv"))(index, v);
	}

	public static unsafe void VertexAttrib2fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib2fvARB"))(index, v);
	}

	public static unsafe void VertexAttrib2s(uint index, short x, short y) {
		((delegate* unmanaged<uint, short, short, void>) Context.GetProcAddress("glVertexAttrib2s"))(index, x, y);
	}

	public static unsafe void VertexAttrib2sARB(uint index, short x, short y) {
		((delegate* unmanaged<uint, short, short, void>) Context.GetProcAddress("glVertexAttrib2sARB"))(index, x, y);
	}

	public static unsafe void VertexAttrib2sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib2sv"))(index, v);
	}

	public static unsafe void VertexAttrib2svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib2svARB"))(index, v);
	}

	public static unsafe void VertexAttrib3d(uint index, double x, double y, double z) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glVertexAttrib3d"))(index, x, y, z);
	}

	public static unsafe void VertexAttrib3dARB(uint index, double x, double y, double z) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glVertexAttrib3dARB"))(index, x, y, z);
	}

	public static unsafe void VertexAttrib3dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib3dv"))(index, v);
	}

	public static unsafe void VertexAttrib3dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib3dvARB"))(index, v);
	}

	public static unsafe void VertexAttrib3f(uint index, float x, float y, float z) {
		((delegate* unmanaged<uint, float, float, float, void>) Context.GetProcAddress("glVertexAttrib3f"))(index, x, y, z);
	}

	public static unsafe void VertexAttrib3fARB(uint index, float x, float y, float z) {
		((delegate* unmanaged<uint, float, float, float, void>) Context.GetProcAddress("glVertexAttrib3fARB"))(index, x, y, z);
	}

	public static unsafe void VertexAttrib3fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib3fv"))(index, v);
	}

	public static unsafe void VertexAttrib3fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib3fvARB"))(index, v);
	}

	public static unsafe void VertexAttrib3s(uint index, short x, short y, short z) {
		((delegate* unmanaged<uint, short, short, short, void>) Context.GetProcAddress("glVertexAttrib3s"))(index, x, y, z);
	}

	public static unsafe void VertexAttrib3sARB(uint index, short x, short y, short z) {
		((delegate* unmanaged<uint, short, short, short, void>) Context.GetProcAddress("glVertexAttrib3sARB"))(index, x, y, z);
	}

	public static unsafe void VertexAttrib3sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib3sv"))(index, v);
	}

	public static unsafe void VertexAttrib3svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib3svARB"))(index, v);
	}

	public static unsafe void VertexAttrib4Nbv(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4Nbv"))(index, v);
	}

	public static unsafe void VertexAttrib4NbvARB(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4NbvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4Niv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4Niv"))(index, v);
	}

	public static unsafe void VertexAttrib4NivARB(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4NivARB"))(index, v);
	}

	public static unsafe void VertexAttrib4Nsv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4Nsv"))(index, v);
	}

	public static unsafe void VertexAttrib4NsvARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4NsvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) {
		((delegate* unmanaged<uint, byte, byte, byte, byte, void>) Context.GetProcAddress("glVertexAttrib4Nub"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) {
		((delegate* unmanaged<uint, byte, byte, byte, byte, void>) Context.GetProcAddress("glVertexAttrib4NubARB"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4Nubv(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4Nubv"))(index, v);
	}

	public static unsafe void VertexAttrib4NubvARB(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4NubvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4Nuiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4Nuiv"))(index, v);
	}

	public static unsafe void VertexAttrib4NuivARB(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4NuivARB"))(index, v);
	}

	public static unsafe void VertexAttrib4Nusv(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4Nusv"))(index, v);
	}

	public static unsafe void VertexAttrib4NusvARB(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4NusvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4bv(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4bv"))(index, v);
	}

	public static unsafe void VertexAttrib4bvARB(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttrib4bvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4d(uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glVertexAttrib4d"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4dARB(uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glVertexAttrib4dARB"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib4dv"))(index, v);
	}

	public static unsafe void VertexAttrib4dvARB(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttrib4dvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4f(uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glVertexAttrib4f"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4fARB(uint index, float x, float y, float z, float w) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glVertexAttrib4fARB"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4fv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib4fv"))(index, v);
	}

	public static unsafe void VertexAttrib4fvARB(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glVertexAttrib4fvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4iv"))(index, v);
	}

	public static unsafe void VertexAttrib4ivARB(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttrib4ivARB"))(index, v);
	}

	public static unsafe void VertexAttrib4s(uint index, short x, short y, short z, short w) {
		((delegate* unmanaged<uint, short, short, short, short, void>) Context.GetProcAddress("glVertexAttrib4s"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4sARB(uint index, short x, short y, short z, short w) {
		((delegate* unmanaged<uint, short, short, short, short, void>) Context.GetProcAddress("glVertexAttrib4sARB"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttrib4sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4sv"))(index, v);
	}

	public static unsafe void VertexAttrib4svARB(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttrib4svARB"))(index, v);
	}

	public static unsafe void VertexAttrib4ubv(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4ubv"))(index, v);
	}

	public static unsafe void VertexAttrib4ubvARB(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttrib4ubvARB"))(index, v);
	}

	public static unsafe void VertexAttrib4uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4uiv"))(index, v);
	}

	public static unsafe void VertexAttrib4uivARB(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttrib4uivARB"))(index, v);
	}

	public static unsafe void VertexAttrib4usv(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4usv"))(index, v);
	}

	public static unsafe void VertexAttrib4usvARB(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttrib4usvARB"))(index, v);
	}

	public static unsafe void VertexAttribBinding(uint attribindex, uint bindingindex) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribBinding"))(attribindex, bindingindex);
	}

	public static unsafe void VertexAttribDivisor(uint index, uint divisor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribDivisor"))(index, divisor);
	}

	public static unsafe void VertexAttribDivisorARB(uint index, uint divisor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribDivisorARB"))(index, divisor);
	}

	public static unsafe void VertexAttribFormat(uint attribindex, int size, uint type, byte normalized, uint relativeoffset) {
		((delegate* unmanaged<uint, int, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribFormat"))(attribindex, size, type, normalized, relativeoffset);
	}

	public static unsafe void VertexAttribI1i(uint index, int x) {
		((delegate* unmanaged<uint, int, void>) Context.GetProcAddress("glVertexAttribI1i"))(index, x);
	}

	public static unsafe void VertexAttribI1iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI1iv"))(index, v);
	}

	public static unsafe void VertexAttribI1ui(uint index, uint x) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexAttribI1ui"))(index, x);
	}

	public static unsafe void VertexAttribI1uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI1uiv"))(index, v);
	}

	public static unsafe void VertexAttribI2i(uint index, int x, int y) {
		((delegate* unmanaged<uint, int, int, void>) Context.GetProcAddress("glVertexAttribI2i"))(index, x, y);
	}

	public static unsafe void VertexAttribI2iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI2iv"))(index, v);
	}

	public static unsafe void VertexAttribI2ui(uint index, uint x, uint y) {
		((delegate* unmanaged<uint, uint, uint, void>) Context.GetProcAddress("glVertexAttribI2ui"))(index, x, y);
	}

	public static unsafe void VertexAttribI2uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI2uiv"))(index, v);
	}

	public static unsafe void VertexAttribI3i(uint index, int x, int y, int z) {
		((delegate* unmanaged<uint, int, int, int, void>) Context.GetProcAddress("glVertexAttribI3i"))(index, x, y, z);
	}

	public static unsafe void VertexAttribI3iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI3iv"))(index, v);
	}

	public static unsafe void VertexAttribI3ui(uint index, uint x, uint y, uint z) {
		((delegate* unmanaged<uint, uint, uint, uint, void>) Context.GetProcAddress("glVertexAttribI3ui"))(index, x, y, z);
	}

	public static unsafe void VertexAttribI3uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI3uiv"))(index, v);
	}

	public static unsafe void VertexAttribI4bv(uint index, sbyte* v) {
		((delegate* unmanaged<uint, sbyte*, void>) Context.GetProcAddress("glVertexAttribI4bv"))(index, v);
	}

	public static unsafe void VertexAttribI4i(uint index, int x, int y, int z, int w) {
		((delegate* unmanaged<uint, int, int, int, int, void>) Context.GetProcAddress("glVertexAttribI4i"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttribI4iv(uint index, int* v) {
		((delegate* unmanaged<uint, int*, void>) Context.GetProcAddress("glVertexAttribI4iv"))(index, v);
	}

	public static unsafe void VertexAttribI4sv(uint index, short* v) {
		((delegate* unmanaged<uint, short*, void>) Context.GetProcAddress("glVertexAttribI4sv"))(index, v);
	}

	public static unsafe void VertexAttribI4ubv(uint index, byte* v) {
		((delegate* unmanaged<uint, byte*, void>) Context.GetProcAddress("glVertexAttribI4ubv"))(index, v);
	}

	public static unsafe void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) {
		((delegate* unmanaged<uint, uint, uint, uint, uint, void>) Context.GetProcAddress("glVertexAttribI4ui"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttribI4uiv(uint index, uint* v) {
		((delegate* unmanaged<uint, uint*, void>) Context.GetProcAddress("glVertexAttribI4uiv"))(index, v);
	}

	public static unsafe void VertexAttribI4usv(uint index, ushort* v) {
		((delegate* unmanaged<uint, ushort*, void>) Context.GetProcAddress("glVertexAttribI4usv"))(index, v);
	}

	public static unsafe void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, int, uint, uint, void>) Context.GetProcAddress("glVertexAttribIFormat"))(attribindex, size, type, relativeoffset);
	}

	public static unsafe void VertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, int, void*, void>) Context.GetProcAddress("glVertexAttribIPointer"))(index, size, type, stride, pointer);
	}

	public static unsafe void VertexAttribL1d(uint index, double x) {
		((delegate* unmanaged<uint, double, void>) Context.GetProcAddress("glVertexAttribL1d"))(index, x);
	}

	public static unsafe void VertexAttribL1dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL1dv"))(index, v);
	}

	public static unsafe void VertexAttribL2d(uint index, double x, double y) {
		((delegate* unmanaged<uint, double, double, void>) Context.GetProcAddress("glVertexAttribL2d"))(index, x, y);
	}

	public static unsafe void VertexAttribL2dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL2dv"))(index, v);
	}

	public static unsafe void VertexAttribL3d(uint index, double x, double y, double z) {
		((delegate* unmanaged<uint, double, double, double, void>) Context.GetProcAddress("glVertexAttribL3d"))(index, x, y, z);
	}

	public static unsafe void VertexAttribL3dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL3dv"))(index, v);
	}

	public static unsafe void VertexAttribL4d(uint index, double x, double y, double z, double w) {
		((delegate* unmanaged<uint, double, double, double, double, void>) Context.GetProcAddress("glVertexAttribL4d"))(index, x, y, z, w);
	}

	public static unsafe void VertexAttribL4dv(uint index, double* v) {
		((delegate* unmanaged<uint, double*, void>) Context.GetProcAddress("glVertexAttribL4dv"))(index, v);
	}

	public static unsafe void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		((delegate* unmanaged<uint, int, uint, uint, void>) Context.GetProcAddress("glVertexAttribLFormat"))(attribindex, size, type, relativeoffset);
	}

	public static unsafe void VertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, int, void*, void>) Context.GetProcAddress("glVertexAttribLPointer"))(index, size, type, stride, pointer);
	}

	public static unsafe void VertexAttribP1ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP1ui"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribP1uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP1uiv"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribP2ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP2ui"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribP2uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP2uiv"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribP3ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP3ui"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribP3uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP3uiv"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribP4ui(uint index, uint type, byte normalized, uint value) {
		((delegate* unmanaged<uint, uint, byte, uint, void>) Context.GetProcAddress("glVertexAttribP4ui"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribP4uiv(uint index, uint type, byte normalized, uint* value) {
		((delegate* unmanaged<uint, uint, byte, uint*, void>) Context.GetProcAddress("glVertexAttribP4uiv"))(index, type, normalized, value);
	}

	public static unsafe void VertexAttribPointer(uint index, int size, uint type, byte normalized, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, byte, int, void*, void>) Context.GetProcAddress("glVertexAttribPointer"))(index, size, type, normalized, stride, pointer);
	}

	public static unsafe void VertexAttribPointerARB(uint index, int size, uint type, byte normalized, int stride, void* pointer) {
		((delegate* unmanaged<uint, int, uint, byte, int, void*, void>) Context.GetProcAddress("glVertexAttribPointerARB"))(index, size, type, normalized, stride, pointer);
	}

	public static unsafe void VertexBindingDivisor(uint bindingindex, uint divisor) {
		((delegate* unmanaged<uint, uint, void>) Context.GetProcAddress("glVertexBindingDivisor"))(bindingindex, divisor);
	}

	public static unsafe void Viewport(int x, int y, int width, int height) {
		((delegate* unmanaged<int, int, int, int, void>) Context.GetProcAddress("glViewport"))(x, y, width, height);
	}

	public static unsafe void ViewportArrayv(uint first, int count, float* v) {
		((delegate* unmanaged<uint, int, float*, void>) Context.GetProcAddress("glViewportArrayv"))(first, count, v);
	}

	public static unsafe void ViewportIndexedf(uint index, float x, float y, float w, float h) {
		((delegate* unmanaged<uint, float, float, float, float, void>) Context.GetProcAddress("glViewportIndexedf"))(index, x, y, w, h);
	}

	public static unsafe void ViewportIndexedfv(uint index, float* v) {
		((delegate* unmanaged<uint, float*, void>) Context.GetProcAddress("glViewportIndexedfv"))(index, v);
	}

	public static unsafe void WaitSync(GLSync sync, uint flags, nint timeout) {
		((delegate* unmanaged<GLSync, uint, nint, void>) Context.GetProcAddress("glWaitSync"))(sync, flags, timeout);
	}

	/// <summary>
	/// Disposes of the OpenGL context, allowing for proper resource cleanup and finalization.
	/// <summary>
	public static void Destroy() {
		Context.Dispose();
	}
}