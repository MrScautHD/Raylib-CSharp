using Raylib_CSharp.OpenGL.Apis;
using Raylib_CSharp.OpenGL.Contexts;

namespace Raylib_CSharp.OpenGL;

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

    public static IBindingsContext Context { get; private set; }

    /// <summary>
    /// The Gl class provides bindings for OpenGL functions.
    /// </summary>
    public static void Init(IBindingsContext context) {
        Context = context;
    }

    public static void AccumxOES(uint op, int value) {
		GlApi.AccumxOES(op, value);
	}

    public static void ActiveShaderProgram(uint pipeline, uint program) {
		GlApi.ActiveShaderProgram(pipeline, program);
	}

	public static void ActiveTexture(uint texture) {
		GlApi.ActiveTexture(texture);
	}

	public static void ActiveTextureARB(uint texture) {
		GlApi.ActiveTextureARB(texture);
	}

	public static void AlphaFuncxOES(uint func, int reference) {
		GlApi.AlphaFuncxOES(func, reference);
	}

	public static void AttachObjectARB(uint containerObj, uint obj) {
		GlApi.AttachObjectARB(containerObj, obj);
	}

	public static void AttachShader(uint program, uint shader) {
		GlApi.AttachShader(program, shader);
	}

	public static void BeginConditionalRender(uint id, uint mode) {
		GlApi.BeginConditionalRender(id, mode);
	}

	public static void BeginQuery(uint target, uint id) {
		GlApi.BeginQuery(target, id);
	}

	public static void BeginQueryARB(uint target, uint id) {
		GlApi.BeginQueryARB(target, id);
	}

	public static void BeginQueryIndexed(uint target, uint index, uint id) {
		GlApi.BeginQueryIndexed(target, index, id);
	}

	public static void BeginTransformFeedback(uint primitiveMode) {
		GlApi.BeginTransformFeedback(primitiveMode);
	}

	public static unsafe void BindAttribLocation(uint program, uint index, char* name) {
		GlApi.BindAttribLocation(program, index, name);
	}

	public static unsafe void BindAttribLocationARB(uint programObj, uint index, char* name) {
		GlApi.BindAttribLocationARB(programObj, index, name);
	}

	public static void BindBuffer(uint target, uint buffer) {
		GlApi.BindBuffer(target, buffer);
	}

	public static void BindBufferARB(uint target, uint buffer) {
		GlApi.BindBufferARB(target, buffer);
	}

	public static void BindBufferBase(uint target, uint index, uint buffer) {
		GlApi.BindBufferBase(target, index, buffer);
	}

	public static unsafe void BindBufferRange(uint target, uint index, uint buffer, int* offset, nint size) {
		GlApi.BindBufferRange(target, index, buffer, offset, size);
	}

	public static unsafe void BindBuffersBase(uint target, uint first, int count, uint* buffers) {
		GlApi.BindBuffersBase(target, first, count, buffers);
	}

	public static unsafe void BindBuffersRange(uint target, uint first, int count, uint* buffers, int** offsets, nint* sizes) {
		GlApi.BindBuffersRange(target, first, count, buffers, offsets, sizes);
	}

	public static unsafe void BindFragDataLocation(uint program, uint color, char* name) {
		GlApi.BindFragDataLocation(program, color, name);
	}

	public static unsafe void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name) {
		GlApi.BindFragDataLocationIndexed(program, colorNumber, index, name);
	}

	public static void BindFramebuffer(uint target, uint framebuffer) {
		GlApi.BindFramebuffer(target, framebuffer);
	}

	public static void BindFramebufferEXT(uint target, uint framebuffer) {
		GlApi.BindFramebufferEXT(target, framebuffer);
	}

	public static void BindImageTexture(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format) {
		GlApi.BindImageTexture(unit, texture, level, layered, layer, access, format);
	}

	public static unsafe void BindImageTextures(uint first, int count, uint* textures) {
		GlApi.BindImageTextures(first, count, textures);
	}

	public static void BindProgramARB(uint target, uint program) {
		GlApi.BindProgramARB(target, program);
	}

	public static void BindProgramPipeline(uint pipeline) {
		GlApi.BindProgramPipeline(pipeline);
	}

	public static void BindRenderbuffer(uint target, uint renderbuffer) {
		GlApi.BindRenderbuffer(target, renderbuffer);
	}

	public static void BindRenderbufferEXT(uint target, uint renderbuffer) {
		GlApi.BindRenderbufferEXT(target, renderbuffer);
	}

	public static void BindSampler(uint unit, uint sampler) {
		GlApi.BindSampler(unit, sampler);
	}

	public static unsafe void BindSamplers(uint first, int count, uint* samplers) {
		GlApi.BindSamplers(first, count, samplers);
	}

	public static void BindTexture(uint target, uint texture) {
		GlApi.BindTexture(target, texture);
	}

	public static void BindTextureUnit(uint unit, uint texture) {
		GlApi.BindTextureUnit(unit, texture);
	}

	public static unsafe void BindTextures(uint first, int count, uint* textures) {
		GlApi.BindTextures(first, count, textures);
	}

	public static void BindTransformFeedback(uint target, uint id) {
		GlApi.BindTransformFeedback(target, id);
	}

	public static void BindVertexArray(uint array) {
		GlApi.BindVertexArray(array);
	}

	public static unsafe void BindVertexBuffer(uint bindingindex, uint buffer, int* offset, int stride) {
		GlApi.BindVertexBuffer(bindingindex, buffer, offset, stride);
	}

	public static unsafe void BindVertexBuffers(uint first, int count, uint* buffers, int** offsets, int* strides) {
		GlApi.BindVertexBuffers(first, count, buffers, offsets, strides);
	}

	public static unsafe void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) {
		GlApi.BitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap);
	}

	public static void BlendColor(float red, float green, float blue, float alpha) {
		GlApi.BlendColor(red, green, blue, alpha);
	}

	public static void BlendColorxOES(int red, int green, int blue, int alpha) {
		GlApi.BlendColorxOES(red, green, blue, alpha);
	}

	public static void BlendEquation(uint mode) {
		GlApi.BlendEquation(mode);
	}

	public static void BlendEquationSeparate(uint modeRGB, uint modeAlpha) {
		GlApi.BlendEquationSeparate(modeRGB, modeAlpha);
	}

	public static void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha) {
		GlApi.BlendEquationSeparatei(buf, modeRGB, modeAlpha);
	}

	public static void BlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha) {
		GlApi.BlendEquationSeparateiARB(buf, modeRGB, modeAlpha);
	}

	public static void BlendEquationi(uint buf, uint mode) {
		GlApi.BlendEquationi(buf, mode);
	}

	public static void BlendEquationiARB(uint buf, uint mode) {
		GlApi.BlendEquationiARB(buf, mode);
	}

	public static void BlendFunc(uint sfactor, uint dfactor) {
		GlApi.BlendFunc(sfactor, dfactor);
	}

	public static void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) {
		GlApi.BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
	}

	public static void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		GlApi.BlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
	}

	public static void BlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		GlApi.BlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
	}

	public static void BlendFunci(uint buf, uint src, uint dst) {
		GlApi.BlendFunci(buf, src, dst);
	}

	public static void BlendFunciARB(uint buf, uint src, uint dst) {
		GlApi.BlendFunciARB(buf, src, dst);
	}

	public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		GlApi.BlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	public static void BlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		GlApi.BlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	public static void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		GlApi.BlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	public static unsafe void BufferData(uint target, nint size, void* data, uint usage) {
		GlApi.BufferData(target, size, data, usage);
	}

	public static unsafe void BufferDataARB(uint target, nint size, void* data, uint usage) {
		GlApi.BufferDataARB(target, size, data, usage);
	}

	public static unsafe void BufferStorage(uint target, nint size, void* data, uint flags) {
		GlApi.BufferStorage(target, size, data, flags);
	}

	public static unsafe void BufferSubData(uint target, int* offset, nint size, void* data) {
		GlApi.BufferSubData(target, offset, size, data);
	}

	public static unsafe void BufferSubDataARB(uint target, int* offset, nint size, void* data) {
		GlApi.BufferSubDataARB(target, offset, size, data);
	}

	public static uint CheckFramebufferStatus(uint target) {
		return GlApi.CheckFramebufferStatus(target);
	}

	public static uint CheckFramebufferStatusEXT(uint target) {
		return GlApi.CheckFramebufferStatusEXT(target);
	}

	public static uint CheckNamedFramebufferStatus(uint framebuffer, uint target) {
		return GlApi.CheckNamedFramebufferStatus(framebuffer, target);
	}

	public static void ClampColor(uint target, uint clamp) {
		GlApi.ClampColor(target, clamp);
	}

	public static void ClampColorARB(uint target, uint clamp) {
		GlApi.ClampColorARB(target, clamp);
	}

	public static void Clear(uint mask) {
		GlApi.Clear(mask);
	}

	public static void ClearAccumxOES(int red, int green, int blue, int alpha) {
		GlApi.ClearAccumxOES(red, green, blue, alpha);
	}

	public static unsafe void ClearBufferData(uint target, uint internalformat, uint format, uint type, void* data) {
		GlApi.ClearBufferData(target, internalformat, format, type, data);
	}

	public static unsafe void ClearBufferSubData(uint target, uint internalformat, int* offset, nint size, uint format, uint type, void* data) {
		GlApi.ClearBufferSubData(target, internalformat, offset, size, format, type, data);
	}

	public static void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) {
		GlApi.ClearBufferfi(buffer, drawbuffer, depth, stencil);
	}

	public static unsafe void ClearBufferfv(uint buffer, int drawbuffer, float* value) {
		GlApi.ClearBufferfv(buffer, drawbuffer, value);
	}

	public static unsafe void ClearBufferiv(uint buffer, int drawbuffer, int* value) {
		GlApi.ClearBufferiv(buffer, drawbuffer, value);
	}

	public static unsafe void ClearBufferuiv(uint buffer, int drawbuffer, uint* value) {
		GlApi.ClearBufferuiv(buffer, drawbuffer, value);
	}

	public static void ClearColor(float red, float green, float blue, float alpha) {
		GlApi.ClearColor(red, green, blue, alpha);
	}

	public static void ClearColorxOES(int red, int green, int blue, int alpha) {
		GlApi.ClearColorxOES(red, green, blue, alpha);
	}

	public static void ClearDepth(double depth) {
		GlApi.ClearDepth(depth);
	}

	public static void ClearDepthf(float d) {
		GlApi.ClearDepthf(d);
	}

	public static void ClearDepthxOES(int depth) {
		GlApi.ClearDepthxOES(depth);
	}

	public static unsafe void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data) {
		GlApi.ClearNamedBufferData(buffer, internalformat, format, type, data);
	}

	public static unsafe void ClearNamedBufferSubData(uint buffer, uint internalformat, int* offset, nint size, uint format, uint type, void* data) {
		GlApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
	}

	public static void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil) {
		GlApi.ClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
	}

	public static unsafe void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value) {
		GlApi.ClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
	}

	public static unsafe void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value) {
		GlApi.ClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
	}

	public static unsafe void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value) {
		GlApi.ClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
	}

	public static unsafe void ClearStencil(int s) {
		GlApi.ClearStencil(s);
	}

	public static unsafe void ClearTexImage(uint texture, int level, uint format, uint type, void* data) {
		GlApi.ClearTexImage(texture, level, format, type, data);
	}

	public static unsafe void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data) {
		GlApi.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
	}

	public static void ClientActiveTextureARB(uint texture) {
		GlApi.ClientActiveTextureARB(texture);
	}

	public static uint ClientWaitSync(GLSync sync, uint flags, nint timeout) {
		return GlApi.ClientWaitSync(sync, flags, timeout);
	}

	public static unsafe void ClipPlanexOES(uint plane, int* equation) {
		GlApi.ClipPlanexOES(plane, equation);
	}

	public static void Color3xOES(int red, int green, int blue) {
		GlApi.Color3xOES(red, green, blue);
	}

	public static unsafe void Color3xvOES(int* components) {
		GlApi.Color3xvOES(components);
	}

	public static void Color4xOES(int red, int green, int blue, int alpha) {
		GlApi.Color4xOES(red, green, blue, alpha);
	}

	public static unsafe void Color4xvOES(int* components) {
		GlApi.Color4xvOES(components);
	}

	public static void ColorMask(byte red, byte green, byte blue, byte alpha) {
		GlApi.ColorMask(red, green, blue, alpha);
	}

	public static void ColorMaski(uint index, byte r, byte g, byte b, byte a) {
		GlApi.ColorMaski(index, r, g, b, a);
	}

	public static void CompileShader(uint shader) {
		GlApi.CompileShader(shader);
	}

	public static void CompileShaderARB(uint shaderObj) {
		GlApi.CompileShaderARB(shaderObj);
	}

	public static unsafe void CompileShaderIncludeARB(uint shader, int count, char** path, int* length) {
		GlApi.CompileShaderIncludeARB(shader, count, path, length);
	}

	public static unsafe void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) {
		GlApi.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) {
		GlApi.CompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) {
		GlApi.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) {
		GlApi.CompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) {
		GlApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
	}

	public static unsafe void CompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) {
		GlApi.CompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		GlApi.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		GlApi.CompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		GlApi.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		GlApi.CompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		GlApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	public static unsafe void CompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		GlApi.CompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	public static unsafe void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data) {
		GlApi.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
	}

	public static unsafe void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) {
		GlApi.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
	}

	public static unsafe void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) {
		GlApi.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}

	public static void ConvolutionParameterxOES(uint target, uint pname, int param) {
		GlApi.ConvolutionParameterxOES(target, pname, param);
	}

	public static unsafe void ConvolutionParameterxvOES(uint target, uint pname, int* parameters) {
		GlApi.ConvolutionParameterxvOES(target, pname, parameters);
	}

	public static unsafe void CopyBufferSubData(uint readTarget, uint writeTarget, int* readOffset, int* writeOffset, nint size) {
		GlApi.CopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
	}

	public static void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) {
		GlApi.CopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
	}

	public static unsafe void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, nint size) {
		GlApi.CopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
	}

	public static void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border) {
		GlApi.CopyTexImage1D(target, level, internalformat, x, y, width, border);
	}

	public static void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) {
		GlApi.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
	}

	public static void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) {
		GlApi.CopyTexSubImage1D(target, level, xoffset, x, y, width);
	}

	public static void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		GlApi.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
	}

	public static void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		GlApi.CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	public static void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width) {
		GlApi.CopyTextureSubImage1D(texture, level, xoffset, x, y, width);
	}

	public static void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		GlApi.CopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
	}

	public static void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		GlApi.CopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	public static unsafe void CreateBuffers(int n, uint* buffers) {
		GlApi.CreateBuffers(n, buffers);
	}

	public static unsafe void CreateFramebuffers(int n, uint* framebuffers) {
		GlApi.CreateFramebuffers(n, framebuffers);
	}

	public static uint CreateProgram() {
		return GlApi.CreateProgram();
	}

	public static uint CreateProgramObjectARB() {
		return GlApi.CreateProgramObjectARB();
	}

	public static unsafe void CreateProgramPipelines(int n, uint* pipelines) {
		GlApi.CreateProgramPipelines(n, pipelines);
	}

	public static unsafe void CreateQueries(uint target, int n, uint* ids) {
		GlApi.CreateQueries(target, n, ids);
	}

	public static unsafe void CreateRenderbuffers(int n, uint* renderbuffers) {
		GlApi.CreateRenderbuffers(n, renderbuffers);
	}

	public static unsafe void CreateSamplers(int n, uint* samplers) {
		GlApi.CreateSamplers(n, samplers);
	}

	public static uint CreateShader(uint type) {
		return GlApi.CreateShader(type);
	}

	public static uint CreateShaderObjectARB(uint shaderType) {
		return GlApi.CreateShaderObjectARB(shaderType);
	}

	public static unsafe uint CreateShaderProgramv(uint type, int count, char** strings) {
		return GlApi.CreateShaderProgramv(type, count, strings);
	}

	public static unsafe void CreateTextures(uint target, int n, uint* textures) {
		GlApi.CreateTextures(target, n, textures);
	}

	public static unsafe void CreateTransformFeedbacks(int n, uint* ids) {
		GlApi.CreateTransformFeedbacks(n, ids);
	}

	public static unsafe void CreateVertexArrays(int n, uint* arrays) {
		GlApi.CreateVertexArrays(n, arrays);
	}

	public static void CullFace(uint mode) {
		GlApi.CullFace(mode);
	}

	public static unsafe void DebugMessageCallback(delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void> callback, void* userParam) {
		GlApi.DebugMessageCallback(callback, userParam);
	}

	public static unsafe void DebugMessageCallbackARB(delegate* unmanaged[Cdecl]<uint, uint, uint, uint, int, char*, void*, void> callback, void* userParam) {
		GlApi.DebugMessageCallbackARB(callback, userParam);
	}

	public static unsafe void DebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, byte enabled) {
		GlApi.DebugMessageControl(source, type, severity, count, ids, enabled);
	}

	public static unsafe void DebugMessageControlARB(uint source, uint type, uint severity, int count, uint* ids, byte enabled) {
		GlApi.DebugMessageControlARB(source, type, severity, count, ids, enabled);
	}

	public static unsafe void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char* buf) {
		GlApi.DebugMessageInsert(source, type, id, severity, length, buf);
	}

	public static unsafe void DebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, char* buf) {
		GlApi.DebugMessageInsertARB(source, type, id, severity, length, buf);
	}

	public static unsafe void DeleteBuffers(int n, uint* buffers) {
		GlApi.DeleteBuffers(n, buffers);
	}

	public static unsafe void DeleteBuffersARB(int n, uint* buffers) {
		GlApi.DeleteBuffersARB(n, buffers);
	}

	public static unsafe void DeleteFramebuffers(int n, uint* framebuffers) {
		GlApi.DeleteFramebuffers(n, framebuffers);
	}

	public static unsafe void DeleteFramebuffersEXT(int n, uint* framebuffers) {
		GlApi.DeleteFramebuffersEXT(n, framebuffers);
	}

	public static unsafe void DeleteNamedStringARB(int namelen, char* name) {
		GlApi.DeleteNamedStringARB(namelen, name);
	}

	public static void DeleteObjectARB(uint obj) {
		GlApi.DeleteObjectARB(obj);
	}

	public static void DeleteProgram(uint program) {
		GlApi.DeleteProgram(program);
	}

	public static unsafe void DeleteProgramPipelines(int n, uint* pipelines) {
		GlApi.DeleteProgramPipelines(n, pipelines);
	}

	public static unsafe void DeleteProgramsARB(int n, uint* programs) {
		GlApi.DeleteProgramsARB(n, programs);
	}

	public static unsafe void DeleteQueries(int n, uint* ids) {
		GlApi.DeleteQueries(n, ids);
	}

	public static unsafe void DeleteQueriesARB(int n, uint* ids) {
		GlApi.DeleteQueriesARB(n, ids);
	}

	public static unsafe void DeleteRenderbuffers(int n, uint* renderbuffers) {
		GlApi.DeleteRenderbuffers(n, renderbuffers);
	}

	public static unsafe void DeleteRenderbuffersEXT(int n, uint* renderbuffers) {
		GlApi.DeleteRenderbuffersEXT(n, renderbuffers);
	}

	public static unsafe void DeleteSamplers(int count, uint* samplers) {
		GlApi.DeleteSamplers(count, samplers);
	}

	public static void DeleteShader(uint shader) {
		GlApi.DeleteShader(shader);
	}

	public static void DeleteSync(GLSync sync) {
		GlApi.DeleteSync(sync);
	}

	public static void DeleteTextures(int n, uint* textures) {
		GlApi.DeleteTextures(n, textures);
	}

	public static void DeleteTransformFeedbacks(int n, uint* ids) {
		GlApi.DeleteTransformFeedbacks(n, ids);
	}

	public static void DeleteVertexArrays(int n, uint* arrays) {
		GlApi.DeleteVertexArrays(n, arrays);
	}

	public static void DepthFunc(uint func) {
		GlApi.DepthFunc(func);
	}

	public static void DepthMask(byte flag) {
		GlApi.DepthMask(flag);
	}

	public static void DepthRange(double n, double f) {
		GlApi.DepthRange(n, f);
	}

	public static void DepthRangeArrayv(uint first, int count, double* v) {
		GlApi.DepthRangeArrayv(first, count, v);
	}

	public static void DepthRangeIndexed(uint index, double n, double f) {
		GlApi.DepthRangeIndexed(index, n, f);
	}

	public static void DepthRangef(float n, float f) {
		GlApi.DepthRangef(n, f);
	}

	public static void DepthRangexOES(int n, int f) {
		GlApi.DepthRangexOES(n, f);
	}

	public static void DetachObjectARB(uint containerObj, uint attachedObj) {
		GlApi.DetachObjectARB(containerObj, attachedObj);
	}

	public static void DetachShader(uint program, uint shader) {
		GlApi.DetachShader(program, shader);
	}

	public static void Disable(uint cap) {
		GlApi.Disable(cap);
	}

	public static void DisableVertexArrayAttrib(uint vaobj, uint index) {
		GlApi.DisableVertexArrayAttrib(vaobj, index);
	}

	public static void DisableVertexAttribArray(uint index) {
		GlApi.DisableVertexAttribArray(index);
	}

	public static void DisableVertexAttribArrayARB(uint index) {
		GlApi.DisableVertexAttribArrayARB(index);
	}

	public static void Disablei(uint target, uint index) {
		GlApi.Disablei(target, index);
	}

	public static void DispatchCompute(uint numgroupsx, uint numgroupsy, uint numgroupsz) {
		GlApi.DispatchCompute(numgroupsx, numgroupsy, numgroupsz);
	}

	public static void DispatchComputeGroupSizeARB(uint numgroupsx, uint numgroupsy, uint numgroupsz, uint groupsizex, uint groupsizey, uint groupsizez) {
		GlApi.DispatchComputeGroupSizeARB(numgroupsx, numgroupsy, numgroupsz, groupsizex, groupsizey, groupsizez);
	}

	public static void DispatchComputeIndirect(int* indirect) {
		GlApi.DispatchComputeIndirect(indirect);
	}

	public static void DrawArrays(uint mode, int first, int count) {
		GlApi.DrawArrays(mode, first, count);
	}

	public static void DrawArraysIndirect(uint mode, void* indirect) {
		GlApi.DrawArraysIndirect(mode, indirect);
	}

	public static void DrawArraysInstanced(uint mode, int first, int count, int instancecount) {
		GlApi.DrawArraysInstanced(mode, first, count, instancecount);
	}

	public static void DrawArraysInstancedARB(uint mode, int first, int count, int primcount) {
		GlApi.DrawArraysInstancedARB(mode, first, count, primcount);
	}

	public static void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance) {
		GlApi.DrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
	}

	public static void DrawArraysInstancedEXT(uint mode, int start, int count, int primcount) {
		GlApi.DrawArraysInstancedEXT(mode, start, count, primcount);
	}

	public static void DrawBuffer(uint buf) {
		GlApi.DrawBuffer(buf);
	}

	public static void DrawBuffers(int n, uint* bufs) {
		GlApi.DrawBuffers(n, bufs);
	}

	public static void DrawBuffersARB(int n, uint* bufs) {
		GlApi.DrawBuffersARB(n, bufs);
	}

	public static void DrawElements(uint mode, int count, uint type, void* indices) {
		GlApi.DrawElements(mode, count, type, indices);
	}

	public static void DrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex) {
		GlApi.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
	}

	public static void DrawElementsIndirect(uint mode, uint type, void* indirect) {
		GlApi.DrawElementsIndirect(mode, type, indirect);
	}

	public static void DrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount) {
		GlApi.DrawElementsInstanced(mode, count, type, indices, instancecount);
	}

	public static void DrawElementsInstancedARB(uint mode, int count, uint type, void* indices, int primcount) {
		GlApi.DrawElementsInstancedARB(mode, count, type, indices, primcount);
	}

	public static void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance) {
		GlApi.DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
	}

	public static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex) {
		GlApi.DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
	}

	public static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance) {
		GlApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
	}

	public static void DrawElementsInstancedEXT(uint mode, int count, uint type, void* indices, int primcount) {
		GlApi.DrawElementsInstancedEXT(mode, count, type, indices, primcount);
	}

	public static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices) {
		GlApi.DrawRangeElements(mode, start, end, count, type, indices);
	}

	public static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex) {
		GlApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
	}

	public static void DrawTransformFeedback(uint mode, uint id) {
		GlApi.DrawTransformFeedback(mode, id);
	}

	public static void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount) {
		GlApi.DrawTransformFeedbackInstanced(mode, id, instancecount);
	}

	public static void DrawTransformFeedbackStream(uint mode, uint id, uint stream) {
		GlApi.DrawTransformFeedbackStream(mode, id, stream);
	}

	public static void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount) {
		GlApi.DrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
	}

	public static void Enable(uint cap) {
		GlApi.Enable(cap);
	}

	public static void EnableVertexArrayAttrib(uint vaobj, uint index) {
		GlApi.EnableVertexArrayAttrib(vaobj, index);
	}

	public static void EnableVertexAttribArray(uint index) {
		GlApi.EnableVertexAttribArray(index);
	}

	public static void EnableVertexAttribArrayARB(uint index) {
		GlApi.EnableVertexAttribArrayARB(index);
	}

	public static void Enablei(uint target, uint index) {
		GlApi.Enablei(target, index);
	}

	public static void EndConditionalRender() {
		GlApi.EndConditionalRender();
	}

	public static void EndQuery(uint target) {
		GlApi.EndQuery(target);
	}

	public static void EndQueryARB(uint target) {
		GlApi.EndQueryARB(target);
	}

	public static void EndQueryIndexed(uint target, uint index) {
		GlApi.EndQueryIndexed(target, index);
	}

	public static void EndTransformFeedback() {
		GlApi.EndTransformFeedback();
	}

	public static void EvalCoord1xOES(int u) {
		GlApi.EvalCoord1xOES(u);
	}

	public static void EvalCoord1xvOES(int* coords) {
		GlApi.EvalCoord1xvOES(coords);
	}

	public static void EvalCoord2xOES(int u, int v) {
		GlApi.EvalCoord2xOES(u, v);
	}

	public static void EvalCoord2xvOES(int* coords) {
		GlApi.EvalCoord2xvOES(coords);
	}

	public static void EvaluateDepthValuesARB() {
		GlApi.EvaluateDepthValuesARB();
	}

	public static void FeedbackBufferxOES(int n, uint type, int* buffer) {
		GlApi.FeedbackBufferxOES(n, type, buffer);
	}

	public static GLSync FenceSync(uint condition, uint flags) {
		return GlApi.FenceSync(condition, flags);
	}

	public static void Finish() {
		GlApi.Finish();
	}

	public static void Flush() {
		GlApi.Flush();
	}

	public static void FlushMappedBufferRange(uint target, int* offset, nint length) {
		GlApi.FlushMappedBufferRange(target, offset, length);
	}

	public static void FlushMappedNamedBufferRange(uint buffer, int* offset, nint length) {
		GlApi.FlushMappedNamedBufferRange(buffer, offset, length);
	}

	public static void FogCoordPointerEXT(uint type, int stride, void* pointer) {
		GlApi.FogCoordPointerEXT(type, stride, pointer);
	}

	public static void FogCoorddEXT(double coord) {
		GlApi.FogCoorddEXT(coord);
	}

	public static void FogCoorddvEXT(double* coord) {
		GlApi.FogCoorddvEXT(coord);
	}

	public static void FogCoordfEXT(float coord) {
		GlApi.FogCoordfEXT(coord);
	}

	public static void FogCoordfvEXT(float* coord) {
		GlApi.FogCoordfvEXT(coord);
	}

	public static void FogxOES(uint pname, int param) {
		GlApi.FogxOES(pname, param);
	}

	public static void FogxvOES(uint pname, int* param) {
		GlApi.FogxvOES(pname, param);
	}

	public static void FramebufferParameteri(uint target, uint pname, int param) {
		GlApi.FramebufferParameteri(target, pname, param);
	}

	public static void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		GlApi.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
	}

	public static void FramebufferRenderbufferEXT(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		GlApi.FramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
	}

	public static void FramebufferSampleLocationsfvARB(uint target, uint start, int count, float* v) {
		GlApi.FramebufferSampleLocationsfvARB(target, start, count, v);
	}

	public static void FramebufferTexture(uint target, uint attachment, uint texture, int level) {
		GlApi.FramebufferTexture(target, attachment, texture, level);
	}

	public static void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) {
		GlApi.FramebufferTexture1D(target, attachment, textarget, texture, level);
	}

	public static void FramebufferTexture1DEXT(uint target, uint attachment, uint textarget, uint texture, int level) {
		GlApi.FramebufferTexture1DEXT(target, attachment, textarget, texture, level);
	}

	public static void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) {
		GlApi.FramebufferTexture2D(target, attachment, textarget, texture, level);
	}

	public static void FramebufferTexture2DEXT(uint target, uint attachment, uint textarget, uint texture, int level) {
		GlApi.FramebufferTexture2DEXT(target, attachment, textarget, texture, level);
	}

	public static void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) {
		GlApi.FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
	}

	public static void FramebufferTexture3DEXT(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) {
		GlApi.FramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
	}

	public static void FramebufferTextureARB(uint target, uint attachment, uint texture, int level) {
		GlApi.FramebufferTextureARB(target, attachment, texture, level);
	}

	public static void FramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face) {
		GlApi.FramebufferTextureFaceARB(target, attachment, texture, level, face);
	}

	public static void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) {
		GlApi.FramebufferTextureLayer(target, attachment, texture, level, layer);
	}

	public static void FramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer) {
		GlApi.FramebufferTextureLayerARB(target, attachment, texture, level, layer);
	}

	public static void FrontFace(uint mode) {
		GlApi.FrontFace(mode);
	}

	public static void FrustumxOES(int l, int r, int b, int t, int n, int f) {
		GlApi.FrustumxOES(l, r, b, t, n, f);
	}

	public static void GenBuffers(int n, uint* buffers) {
		GlApi.GenBuffers(n, buffers);
	}

	public static void GenBuffersARB(int n, uint* buffers) {
		GlApi.GenBuffersARB(n, buffers);
	}

	public static void GenFramebuffers(int n, uint* framebuffers) {
		GlApi.GenFramebuffers(n, framebuffers);
	}

	public static void GenFramebuffersEXT(int n, uint* framebuffers) {
		GlApi.GenFramebuffersEXT(n, framebuffers);
	}

	public static void GenProgramPipelines(int n, uint* pipelines) {
		GlApi.GenProgramPipelines(n, pipelines);
	}

	public static void GenProgramsARB(int n, uint* programs) {
		GlApi.GenProgramsARB(n, programs);
	}

	public static void GenQueries(int n, uint* ids) {
		GlApi.GenQueries(n, ids);
	}

	public static void GenQueriesARB(int n, uint* ids) {
		GlApi.GenQueriesARB(n, ids);
	}

	public static void GenRenderbuffers(int n, uint* renderbuffers) {
		GlApi.GenRenderbuffers(n, renderbuffers);
	}

	public static void GenRenderbuffersEXT(int n, uint* renderbuffers) {
		GlApi.GenRenderbuffersEXT(n, renderbuffers);
	}

	public static void GenSamplers(int count, uint* samplers) {
		GlApi.GenSamplers(count, samplers);
	}

	public static void GenTextures(int n, uint* textures) {
		GlApi.GenTextures(n, textures);
	}

	public static void GenTransformFeedbacks(int n, uint* ids) {
		GlApi.GenTransformFeedbacks(n, ids);
	}

	public static void GenVertexArrays(int n, uint* arrays) {
		GlApi.GenVertexArrays(n, arrays);
	}

	public static void GenerateMipmap(uint target) {
		GlApi.GenerateMipmap(target);
	}

	public static void GenerateMipmapEXT(uint target) {
		GlApi.GenerateMipmapEXT(target);
	}

	public static void GenerateTextureMipmap(uint texture) {
		GlApi.GenerateTextureMipmap(texture);
	}

	public static void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* parameters) {
		GlApi.GetActiveAtomicCounterBufferiv(program, bufferIndex, pname, parameters);
	}

	public static void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		GlApi.GetActiveAttrib(program, index, bufSize, length, size, type, name);
	}

	public static void GetActiveAttribARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) {
		GlApi.GetActiveAttribARB(programObj, index, maxLength, length, size, type, name);
	}

	public static void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		GlApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, name);
	}

	public static void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		GlApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);
	}

	public static void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values) {
		GlApi.GetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
	}

	public static void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		GlApi.GetActiveUniform(program, index, bufSize, length, size, type, name);
	}

	public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) {
		GlApi.GetActiveUniformARB(programObj, index, maxLength, length, size, type, name);
	}

	public static void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName) {
		GlApi.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
	}

	public static void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters) {
		GlApi.GetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters);
	}

	public static void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName) {
		GlApi.GetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
	}

	public static void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters) {
		GlApi.GetActiveUniformsiv(program, uniformCount, uniformIndices, pname, parameters);
	}

	public static void GetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj) {
		GlApi.GetAttachedObjectsARB(containerObj, maxCount, count, obj);
	}

	public static void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) {
		GlApi.GetAttachedShaders(program, maxCount, count, shaders);
	}

	public static int GetAttribLocation(uint program, char* name) {
		return GlApi.GetAttribLocation(program, name);
	}

	public static int GetAttribLocationARB(uint programObj, char* name) {
		return GlApi.GetAttribLocationARB(programObj, name);
	}

	public static void GetBooleani_v(uint target, uint index, byte* data) {
		GlApi.GetBooleani_v(target, index, data);
	}

	public static void GetBooleanv(uint pname, byte* data) {
		GlApi.GetBooleanv(pname, data);
	}

	public static void GetBufferParameteri64v(uint target, uint pname, nint* parameters) {
		GlApi.GetBufferParameteri64v(target, pname, parameters);
	}

	public static void GetBufferParameteriv(uint target, uint pname, int* parameters) {
		GlApi.GetBufferParameteriv(target, pname, parameters);
	}

	public static void GetBufferParameterivARB(uint target, uint pname, int* parameters) {
		GlApi.GetBufferParameterivARB(target, pname, parameters);
	}

	public static void GetBufferPointerv(uint target, uint pname, void** parameters) {
		GlApi.GetBufferPointerv(target, pname, parameters);
	}

	public static void GetBufferPointervARB(uint target, uint pname, void** parameters) {
		GlApi.GetBufferPointervARB(target, pname, parameters);
	}

	public static void GetBufferSubData(uint target, int* offset, nint size, void* data) {
		GlApi.GetBufferSubData(target, offset, size, data);
	}

	public static void GetBufferSubDataARB(uint target, int* offset, nint size, void* data) {
		GlApi.GetBufferSubDataARB(target, offset, size, data);
	}

	public static void GetClipPlanexOES(uint plane, int* equation) {
		GlApi.GetClipPlanexOES(plane, equation);
	}

	public static void GetCompressedTexImage(uint target, int level, void* img) {
		GlApi.GetCompressedTexImage(target, level, img);
	}

	public static void GetCompressedTexImageARB(uint target, int level, void* img) {
		GlApi.GetCompressedTexImageARB(target, level, img);
	}

	public static void GetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels) {
		GlApi.GetCompressedTextureImage(texture, level, bufSize, pixels);
	}

	public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels) {
		GlApi.GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
	}

	public static void GetConvolutionParameterxvOES(uint target, uint pname, int* parameters) {
		GlApi.GetConvolutionParameterxvOES(target, pname, parameters);
	}

	public static uint GetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) {
		return GlApi.GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
	}

	public static uint GetDebugMessageLogARB(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) {
		return GlApi.GetDebugMessageLogARB(count, bufSize, sources, types, ids, severities, lengths, messageLog);
	}

	public static void GetDoublei_v(uint target, uint index, double* data) {
		GlApi.GetDoublei_v(target, index, data);
	}

	public static void GetDoublev(uint pname, double* data) {
		GlApi.GetDoublev(pname, data);
	}

	public static uint GetError() {
		return GlApi.GetError();
	}

	public static void GetFixedvOES(uint pname, int* parameters) {
		GlApi.GetFixedvOES(pname, parameters);
	}

	public static void GetFloati_v(uint target, uint index, float* data) {
		GlApi.GetFloati_v(target, index, data);
	}

	public static void GetFloatv(uint pname, float* data) {
		GlApi.GetFloatv(pname, data);
	}

	public static int GetFragDataIndex(uint program, char* name) {
		return GlApi.GetFragDataIndex(program, name);
	}

	public static int GetFragDataLocation(uint program, char* name) {
		return GlApi.GetFragDataLocation(program, name);
	}

	public static void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters) {
		GlApi.GetFramebufferAttachmentParameteriv(target, attachment, pname, parameters);
	}

	public static void GetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname, int* parameters) {
		GlApi.GetFramebufferAttachmentParameterivEXT(target, attachment, pname, parameters);
	}

	public static void GetFramebufferParameteriv(uint target, uint pname, int* parameters) {
		GlApi.GetFramebufferParameteriv(target, pname, parameters);
	}

	public static uint GetHandleARB(uint pname) {
		return GlApi.GetHandleARB(pname);
	}

	public static void GetHistogramParameterxvOES(uint target, uint pname, int* parameters) {
		GlApi.GetHistogramParameterxvOES(target, pname, parameters);
	}

	public static void GetInfoLogARB(uint obj, int maxLength, int* length, char* infoLog) {
		GlApi.GetInfoLogARB(obj, maxLength, length, infoLog);
	}

	public static void GetInteger64i_v(uint target, uint index, nint* data) {
		GlApi.GetInteger64i_v(target, index, data);
	}

	public static void GetInteger64v(uint pname, nint* data) {
		GlApi.GetInteger64v(pname, data);
	}

	public static void GetIntegeri_v(uint target, uint index, int* data) {
		GlApi.GetIntegeri_v(target, index, data);
	}

	public static void GetIntegerv(uint pname, int* data) {
		GlApi.GetIntegerv(pname, data);
	}

	public static void GetInternalformati64v(uint target, uint internalformat, uint pname, int count, nint* parameters) {
		GlApi.GetInternalformati64v(target, internalformat, pname, count, parameters);
	}

	public static void GetInternalformativ(uint target, uint internalformat, uint pname, int count, int* parameters) {
		GlApi.GetInternalformativ(target, internalformat, pname, count, parameters);
	}

	public static void GetLightxOES(uint light, uint pname, int* parameters) {
		GlApi.GetLightxOES(light, pname, parameters);
	}

	public static void GetMapxvOES(uint target, uint query, int* v) {
		GlApi.GetMapxvOES(target, query, v);
	}

	public static void GetMaterialxOES(uint face, uint pname, int param) {
		GlApi.GetMaterialxOES(face, pname, param);
	}

	public static void GetMultisamplefv(uint pname, uint index, float* val) {
		GlApi.GetMultisamplefv(pname, index, val);
	}

	public static void GetNamedBufferParameteri64v(uint buffer, uint pname, nint* parameters) {
		GlApi.GetNamedBufferParameteri64v(buffer, pname, parameters);
	}

	public static void GetNamedBufferParameteriv(uint buffer, uint pname, int* parameters) {
		GlApi.GetNamedBufferParameteriv(buffer, pname, parameters);
	}

	public static void GetNamedBufferPointerv(uint buffer, uint pname, void** parameters) {
		GlApi.GetNamedBufferPointerv(buffer, pname, parameters);
	}

	public static void GetNamedBufferSubData(uint buffer, int* offset, nint size, void* data) {
		GlApi.GetNamedBufferSubData(buffer, offset, size, data);
	}

	public static void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* parameters) {
		GlApi.GetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, parameters);
	}

	public static void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param) {
		GlApi.GetNamedFramebufferParameteriv(framebuffer, pname, param);
	}

	public static void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* parameters) {
		GlApi.GetNamedRenderbufferParameteriv(renderbuffer, pname, parameters);
	}

	public static void GetNamedStringARB(int namelen, char* name, int bufSize, int* stringlen, char* str) {
		GlApi.GetNamedStringARB(namelen, name, bufSize, stringlen, str);
	}

	public static void GetNamedStringivARB(int namelen, char* name, uint pname, int* parameters) {
		GlApi.GetNamedStringivARB(namelen, name, pname, parameters);
	}

	public static void GetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label) {
		GlApi.GetObjectLabel(identifier, name, bufSize, length, label);
	}

	public static void GetObjectParameterfvARB(uint obj, uint pname, float* parameters) {
		GlApi.GetObjectParameterfvARB(obj, pname, parameters);
	}

	public static void GetObjectParameterivARB(uint obj, uint pname, int* parameters) {
		GlApi.GetObjectParameterivARB(obj, pname, parameters);
	}

	public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, char* label) {
		GlApi.GetObjectPtrLabel(ptr, bufSize, length, label);
	}

	public static void GetPixelMapxv(uint map, int size, int* values) {
		GlApi.GetPixelMapxv(map, size, values);
	}

	public static void GetPointerv(uint pname, void** parameters) {
		GlApi.GetPointerv(pname, parameters);
	}

	public static void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) {
		GlApi.GetProgramBinary(program, bufSize, length, binaryFormat, binary);
	}

	public static void GetProgramEnvParameterdvARB(uint target, uint index, double* parameters) {
		GlApi.GetProgramEnvParameterdvARB(target, index, parameters);
	}

	public static void GetProgramEnvParameterfvARB(uint target, uint index, float* parameters) {
		GlApi.GetProgramEnvParameterfvARB(target, index, parameters);
	}

	public static void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog) {
		GlApi.GetProgramInfoLog(program, bufSize, length, infoLog);
	}

	public static void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* parameters) {
		GlApi.GetProgramInterfaceiv(program, programInterface, pname, parameters);
	}

	public static void GetProgramLocalParameterdvARB(uint target, uint index, double* parameters) {
		GlApi.GetProgramLocalParameterdvARB(target, index, parameters);
	}

	public static void GetProgramLocalParameterfvARB(uint target, uint index, float* parameters) {
		GlApi.GetProgramLocalParameterfvARB(target, index, parameters);
	}

	public static void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog) {
		GlApi.GetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
	}

	public static void GetProgramPipelineiv(uint pipeline, uint pname, int* parameters) {
		GlApi.GetProgramPipelineiv(pipeline, pname, parameters);
	}

	public static uint GetProgramResourceIndex(uint program, uint programInterface, char* name) {
		return GlApi.GetProgramResourceIndex(program, programInterface, name);
	}

	public static int GetProgramResourceLocation(uint program, uint programInterface, char* name) {
		return GlApi.GetProgramResourceLocation(program, programInterface, name);
	}

	public static int GetProgramResourceLocationIndex(uint program, uint programInterface, char* name) {
		return GlApi.GetProgramResourceLocationIndex(program, programInterface, name);
	}

	public static void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name) {
		GlApi.GetProgramResourceName(program, programInterface, index, bufSize, length, name);
	}

	public static void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* parameters) {
		GlApi.GetProgramResourceiv(program, programInterface, index, propCount, props, count, length, parameters);
	}

	public static void GetProgramStageiv(uint program, uint shadertype, uint pname, int* values) {
		GlApi.GetProgramStageiv(program, shadertype, pname, values);
	}

	public static void GetProgramStringARB(uint target, uint pname, void* str) {
		GlApi.GetProgramStringARB(target, pname, str);
	}

	public static void GetProgramiv(uint program, uint pname, int* parameters) {
		GlApi.GetProgramiv(program, pname, parameters);
	}

	public static void GetProgramivARB(uint target, uint pname, int* parameters) {
		GlApi.GetProgramivARB(target, pname, parameters);
	}

	public static void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int* offset) {
		GlApi.GetQueryBufferObjecti64v(id, buffer, pname, offset);
	}

	public static void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, int* offset) {
		GlApi.GetQueryBufferObjectiv(id, buffer, pname, offset);
	}

	public static void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int* offset) {
		GlApi.GetQueryBufferObjectui64v(id, buffer, pname, offset);
	}

	public static void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int* offset) {
		GlApi.GetQueryBufferObjectuiv(id, buffer, pname, offset);
	}

	public static void GetQueryIndexediv(uint target, uint index, uint pname, int* parameters) {
		GlApi.GetQueryIndexediv(target, index, pname, parameters);
	}

	public static void GetQueryObjecti64v(uint id, uint pname, nint* parameters) {
		GlApi.GetQueryObjecti64v(id, pname, parameters);
	}

	public static void GetQueryObjectiv(uint id, uint pname, int* parameters) {
		GlApi.GetQueryObjectiv(id, pname, parameters);
	}

	public static void GetQueryObjectivARB(uint id, uint pname, int* parameters) {
		GlApi.GetQueryObjectivARB(id, pname, parameters);
	}

	public static void GetQueryObjectui64v(uint id, uint pname, nint* parameters) {
		GlApi.GetQueryObjectui64v(id, pname, parameters);
	}

	public static void GetQueryObjectuiv(uint id, uint pname, uint* parameters) {
		GlApi.GetQueryObjectuiv(id, pname, parameters);
	}

	public static void GetQueryObjectuivARB(uint id, uint pname, uint* parameters) {
		GlApi.GetQueryObjectuivARB(id, pname, parameters);
	}

	public static void GetQueryiv(uint target, uint pname, int* parameters) {
		GlApi.GetQueryiv(target, pname, parameters);
	}

	public static void GetQueryivARB(uint target, uint pname, int* parameters) {
		GlApi.GetQueryivARB(target, pname, parameters);
	}

	public static void GetRenderbufferParameteriv(uint target, uint pname, int* parameters) {
		GlApi.GetRenderbufferParameteriv(target, pname, parameters);
	}

	public static void GetRenderbufferParameterivEXT(uint target, uint pname, int* parameters) {
		GlApi.GetRenderbufferParameterivEXT(target, pname, parameters);
	}

	public static void GetSamplerParameterIiv(uint sampler, uint pname, int* parameters) {
		GlApi.GetSamplerParameterIiv(sampler, pname, parameters);
	}

	public static void GetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters) {
		GlApi.GetSamplerParameterIuiv(sampler, pname, parameters);
	}

	public static void GetSamplerParameterfv(uint sampler, uint pname, float* parameters) {
		GlApi.GetSamplerParameterfv(sampler, pname, parameters);
	}

	public static void GetSamplerParameteriv(uint sampler, uint pname, int* parameters) {
		GlApi.GetSamplerParameteriv(sampler, pname, parameters);
	}

	public static void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog) {
		GlApi.GetShaderInfoLog(shader, bufSize, length, infoLog);
	}

	public static void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) {
		GlApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
	}

	public static void GetShaderSource(uint shader, int bufSize, int* length, char* source) {
		GlApi.GetShaderSource(shader, bufSize, length, source);
	}

	public static void GetShaderSourceARB(uint obj, int maxLength, int* length, char* source) {
		GlApi.GetShaderSourceARB(obj, maxLength, length, source);
	}

	public static void GetShaderiv(uint shader, uint pname, int* parameters) {
		GlApi.GetShaderiv(shader, pname, parameters);
	}

	public static byte* GetString(uint name) {
		return GlApi.GetString(name);
	}

	public static byte* GetStringi(uint name, uint index) {
		return GlApi.GetStringi(name, index);
	}

	public static uint GetSubroutineIndex(uint program, uint shadertype, char* name) {
		return GlApi.GetSubroutineIndex(program, shadertype, name);
	}

	public static int GetSubroutineUniformLocation(uint program, uint shadertype, char* name) {
		return GlApi.GetSubroutineUniformLocation(program, shadertype, name);
	}

	public static void GetSynciv(GLSync sync, uint pname, int count, int* length, int* values) {
		GlApi.GetSynciv(sync, pname, count, length, values);
	}

	public static void GetTexEnvxvOES(uint target, uint pname, int* parameters) {
		GlApi.GetTexEnvxvOES(target, pname, parameters);
	}

	public static void GetTexGenxvOES(uint coord, uint pname, int* parameters) {
		GlApi.GetTexGenxvOES(coord, pname, parameters);
	}

	public static void GetTexImage(uint target, int level, uint format, uint type, void* pixels) {
		GlApi.GetTexImage(target, level, format, type, pixels);
	}

	public static void GetTexLevelParameterfv(uint target, int level, uint pname, float* parameters) {
		GlApi.GetTexLevelParameterfv(target, level, pname, parameters);
	}

	public static void GetTexLevelParameteriv(uint target, int level, uint pname, int* parameters) {
		GlApi.GetTexLevelParameteriv(target, level, pname, parameters);
	}

	public static void GetTexLevelParameterxvOES(uint target, int level, uint pname, int* parameters) {
		GlApi.GetTexLevelParameterxvOES(target, level, pname, parameters);
	}

	public static void GetTexParameterIiv(uint target, uint pname, int* parameters) {
		GlApi.GetTexParameterIiv(target, pname, parameters);
	}

	public static void GetTexParameterIuiv(uint target, uint pname, uint* parameters) {
		GlApi.GetTexParameterIuiv(target, pname, parameters);
	}

	public static void GetTexParameterfv(uint target, uint pname, float* parameters) {
		GlApi.GetTexParameterfv(target, pname, parameters);
	}

	public static void GetTexParameteriv(uint target, uint pname, int* parameters) {
		GlApi.GetTexParameteriv(target, pname, parameters);
	}

	public static void GetTexParameterxvOES(uint target, uint pname, int* parameters) {
		GlApi.GetTexParameterxvOES(target, pname, parameters);
	}

	public static void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels) {
		GlApi.GetTextureImage(texture, level, format, type, bufSize, pixels);
	}

	public static void GetTextureLevelParameterfv(uint texture, int level, uint pname, float* parameters) {
		GlApi.GetTextureLevelParameterfv(texture, level, pname, parameters);
	}

	public static void GetTextureLevelParameteriv(uint texture, int level, uint pname, int* parameters) {
		GlApi.GetTextureLevelParameteriv(texture, level, pname, parameters);
	}

	public static void GetTextureParameterIiv(uint texture, uint pname, int* parameters) {
		GlApi.GetTextureParameterIiv(texture, pname, parameters);
	}

	public static void GetTextureParameterIuiv(uint texture, uint pname, uint* parameters) {
		GlApi.GetTextureParameterIuiv(texture, pname, parameters);
	}

	public static void GetTextureParameterfv(uint texture, uint pname, float* parameters) {
		GlApi.GetTextureParameterfv(texture, pname, parameters);
	}

	public static void GetTextureParameteriv(uint texture, uint pname, int* parameters) {
		GlApi.GetTextureParameteriv(texture, pname, parameters);
	}

	public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels) {
		GlApi.GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
	}

	public static void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		GlApi.GetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
	}

	public static void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, nint* param) {
		GlApi.GetTransformFeedbacki64_v(xfb, pname, index, param);
	}

	public static void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param) {
		GlApi.GetTransformFeedbacki_v(xfb, pname, index, param);
	}

	public static void GetTransformFeedbackiv(uint xfb, uint pname, int* param) {
		GlApi.GetTransformFeedbackiv(xfb, pname, param);
	}

	public static uint GetUniformBlockIndex(uint program, char* uniformBlockName) {
		return GlApi.GetUniformBlockIndex(program, uniformBlockName);
	}

	public static void GetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices) {
		GlApi.GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
	}

	public static int GetUniformLocation(uint program, char* name) {
		return GlApi.GetUniformLocation(program, name);
	}

	public static int GetUniformLocationARB(uint programObj, char* name) {
		return GlApi.GetUniformLocationARB(programObj, name);
	}

	public static void GetUniformSubroutineuiv(uint shadertype, int location, uint* parameters) {
		GlApi.GetUniformSubroutineuiv(shadertype, location, parameters);
	}

	public static void GetUniformdv(uint program, int location, double* parameters) {
		GlApi.GetUniformdv(program, location, parameters);
	}

	public static void GetUniformfv(uint program, int location, float* parameters) {
		GlApi.GetUniformfv(program, location, parameters);
	}

	public static void GetUniformfvARB(uint programObj, int location, float* parameters) {
		GlApi.GetUniformfvARB(programObj, location, parameters);
	}

	public static void GetUniformi64vARB(uint program, int location, nint* parameters) {
		GlApi.GetUniformi64vARB(program, location, parameters);
	}

	public static void GetUniformiv(uint program, int location, int* parameters) {
		GlApi.GetUniformiv(program, location, parameters);
	}

	public static void GetUniformivARB(uint programObj, int location, int* parameters) {
		GlApi.GetUniformivARB(programObj, location, parameters);
	}

	public static void GetUniformui64vARB(uint program, int location, nint* parameters) {
		GlApi.GetUniformui64vARB(program, location, parameters);
	}

	public static void GetUniformuiv(uint program, int location, uint* parameters) {
		GlApi.GetUniformuiv(program, location, parameters);
	}

	public static void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, nint* param) {
		GlApi.GetVertexArrayIndexed64iv(vaobj, index, pname, param);
	}

	public static void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param) {
		GlApi.GetVertexArrayIndexediv(vaobj, index, pname, param);
	}

	public static void GetVertexArrayiv(uint vaobj, uint pname, int* param) {
		GlApi.GetVertexArrayiv(vaobj, pname, param);
	}

	public static void GetVertexAttribIiv(uint index, uint pname, int* parameters) {
		GlApi.GetVertexAttribIiv(index, pname, parameters);
	}

	public static void GetVertexAttribIuiv(uint index, uint pname, uint* parameters) {
		GlApi.GetVertexAttribIuiv(index, pname, parameters);
	}

	public static void GetVertexAttribLdv(uint index, uint pname, double* parameters) {
		GlApi.GetVertexAttribLdv(index, pname, parameters);
	}

	public static void GetVertexAttribPointerv(uint index, uint pname, void** pointer) {
		GlApi.GetVertexAttribPointerv(index, pname, pointer);
	}

	public static void GetVertexAttribPointervARB(uint index, uint pname, void** pointer) {
		GlApi.GetVertexAttribPointervARB(index, pname, pointer);
	}

	public static void GetVertexAttribdv(uint index, uint pname, double* parameters) {
		GlApi.GetVertexAttribdv(index, pname, parameters);
	}

	public static void GetVertexAttribdvARB(uint index, uint pname, double* parameters) {
		GlApi.GetVertexAttribdvARB(index, pname, parameters);
	}

	public static void GetVertexAttribfv(uint index, uint pname, float* parameters) {
		GlApi.GetVertexAttribfv(index, pname, parameters);
	}

	public static void GetVertexAttribfvARB(uint index, uint pname, float* parameters) {
		GlApi.GetVertexAttribfvARB(index, pname, parameters);
	}

	public static void GetVertexAttribiv(uint index, uint pname, int* parameters) {
		GlApi.GetVertexAttribiv(index, pname, parameters);
	}

	public static void GetVertexAttribivARB(uint index, uint pname, int* parameters) {
		GlApi.GetVertexAttribivARB(index, pname, parameters);
	}

	public static void GetnUniformi64vARB(uint program, int location, int bufSize, nint* parameters) {
		GlApi.GetnUniformi64vARB(program, location, bufSize, parameters);
	}

	public static void GetnUniformui64vARB(uint program, int location, int bufSize, nint* parameters) {
		GlApi.GetnUniformui64vARB(program, location, bufSize, parameters);
	}

	public static void Hint(uint target, uint mode) {
		GlApi.Hint(target, mode);
	}

	public static void IndexxOES(int component) {
		GlApi.IndexxOES(component);
	}

	public static void IndexxvOES(int* component) {
		GlApi.IndexxvOES(component);
	}

	public static void InvalidateBufferData(uint buffer) {
		GlApi.InvalidateBufferData(buffer);
	}

	public static void InvalidateBufferSubData(uint buffer, int* offset, nint length) {
		GlApi.InvalidateBufferSubData(buffer, offset, length);
	}

	public static void InvalidateFramebuffer(uint target, int numAttachments, uint* attachments) {
		GlApi.InvalidateFramebuffer(target, numAttachments, attachments);
	}

	public static void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments) {
		GlApi.InvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
	}

	public static void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height) {
		GlApi.InvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
	}

	public static void InvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height) {
		GlApi.InvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
	}

	public static void InvalidateTexImage(uint texture, int level) {
		GlApi.InvalidateTexImage(texture, level);
	}

	public static void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) {
		GlApi.InvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
	}

	public static byte IsBuffer(uint buffer) {
		return GlApi.IsBuffer(buffer);
	}

	public static byte IsBufferARB(uint buffer) {
		return GlApi.IsBufferARB(buffer);
	}

	public static byte IsEnabled(uint cap) {
		return GlApi.IsEnabled(cap);
	}

	public static byte IsEnabledi(uint target, uint index) {
		return GlApi.IsEnabledi(target, index);
	}

	public static byte IsFramebuffer(uint framebuffer) {
		return GlApi.IsFramebuffer(framebuffer);
	}

	public static byte IsFramebufferEXT(uint framebuffer) {
		return GlApi.IsFramebufferEXT(framebuffer);
	}

	public static byte IsNamedStringARB(int namelen, char* name) {
		return GlApi.IsNamedStringARB(namelen, name);
	}

	public static byte IsProgram(uint program) {
		return GlApi.IsProgram(program);
	}

	public static byte IsProgramARB(uint program) {
		return GlApi.IsProgramARB(program);
	}

	public static byte IsProgramPipeline(uint pipeline) {
		return GlApi.IsProgramPipeline(pipeline);
	}

	public static byte IsQuery(uint id) {
		return GlApi.IsQuery(id);
	}

	public static byte IsQueryARB(uint id) {
		return GlApi.IsQueryARB(id);
	}

	public static byte IsRenderbuffer(uint renderbuffer) {
		return GlApi.IsRenderbuffer(renderbuffer);
	}

	public static byte IsRenderbufferEXT(uint renderbuffer) {
		return GlApi.IsRenderbufferEXT(renderbuffer);
	}

	public static byte IsSampler(uint sampler) {
		return GlApi.IsSampler(sampler);
	}

	public static byte IsShader(uint shader) {
		return GlApi.IsShader(shader);
	}

	public static byte IsSync(GLSync sync) {
		return GlApi.IsSync(sync);
	}

	public static byte IsTexture(uint texture) {
		return GlApi.IsTexture(texture);
	}

	public static byte IsTransformFeedback(uint id) {
		return GlApi.IsTransformFeedback(id);
	}

	public static byte IsVertexArray(uint array) {
		return GlApi.IsVertexArray(array);
	}

	public static void LightModelxOES(uint pname, int param) {
		GlApi.LightModelxOES(pname, param);
	}

	public static void LightModelxvOES(uint pname, int* param) {
		GlApi.LightModelxvOES(pname, param);
	}

	public static void LightxOES(uint light, uint pname, int param) {
		GlApi.LightxOES(light, pname, param);
	}

	public static void LightxvOES(uint light, uint pname, int* parameters) {
		GlApi.LightxvOES(light, pname, parameters);
	}

	public static void LineWidth(float width) {
		GlApi.LineWidth(width);
	}

	public static void LineWidthxOES(int width) {
		GlApi.LineWidthxOES(width);
	}

	public static void LinkProgram(uint program) {
		GlApi.LinkProgram(program);
	}

	public static void LinkProgramARB(uint programObj) {
		GlApi.LinkProgramARB(programObj);
	}

	public static void LoadMatrixxOES(int* m) {
		GlApi.LoadMatrixxOES(m);
	}

	public static void LoadTransposeMatrixdARB(double* m) {
		GlApi.LoadTransposeMatrixdARB(m);
	}

	public static void LoadTransposeMatrixfARB(float* m) {
		GlApi.LoadTransposeMatrixfARB(m);
	}

	public static void LoadTransposeMatrixxOES(int* m) {
		GlApi.LoadTransposeMatrixxOES(m);
	}

	public static void LogicOp(uint opcode) {
		GlApi.LogicOp(opcode);
	}

	public static void Map1xOES(uint target, int u1, int u2, int stride, int order, int points) {
		GlApi.Map1xOES(target, u1, u2, stride, order, points);
	}

	public static void Map2xOES(uint target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) {
		GlApi.Map2xOES(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
	}

	public static void* MapBuffer(uint target, uint access) {
		return GlApi.MapBuffer(target, access);
	}

	public static void* MapBufferARB(uint target, uint access) {
		return GlApi.MapBufferARB(target, access);
	}

	public static void* MapBufferRange(uint target, int* offset, nint length, uint access) {
		return GlApi.MapBufferRange(target, offset, length, access);
	}

	public static void MapGrid1xOES(int n, int u1, int u2) {
		GlApi.MapGrid1xOES(n, u1, u2);
	}

	public static void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) {
		GlApi.MapGrid2xOES(n, u1, u2, v1, v2);
	}

	public static void* MapNamedBuffer(uint buffer, uint access) {
		return GlApi.MapNamedBuffer(buffer, access);
	}

	public static void* MapNamedBufferRange(uint buffer, int* offset, nint length, uint access) {
		return GlApi.MapNamedBufferRange(buffer, offset, length, access);
	}

	public static void MaterialxOES(uint face, uint pname, int param) {
		GlApi.MaterialxOES(face, pname, param);
	}

	public static void MaterialxvOES(uint face, uint pname, int* param) {
		GlApi.MaterialxvOES(face, pname, param);
	}

	public static void MemoryBarrier(uint barriers) {
		GlApi.MemoryBarrier(barriers);
	}

	public static void MemoryBarrierByRegion(uint barriers) {
		GlApi.MemoryBarrierByRegion(barriers);
	}

	public static void MinSampleShading(float value) {
		GlApi.MinSampleShading(value);
	}

	public static void MinSampleShadingARB(float value) {
		GlApi.MinSampleShadingARB(value);
	}

	public static void MultMatrixxOES(int* m) {
		GlApi.MultMatrixxOES(m);
	}

	public static void MultTransposeMatrixdARB(double* m) {
		GlApi.MultTransposeMatrixdARB(m);
	}

	public static void MultTransposeMatrixfARB(float* m) {
		GlApi.MultTransposeMatrixfARB(m);
	}

	public static void MultTransposeMatrixxOES(int* m) {
		GlApi.MultTransposeMatrixxOES(m);
	}

	public static void MultiDrawArrays(uint mode, int* first, int* count, int drawcount) {
		GlApi.MultiDrawArrays(mode, first, count, drawcount);
	}

	public static void MultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride) {
		GlApi.MultiDrawArraysIndirect(mode, indirect, drawcount, stride);
	}

	public static void MultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount) {
		GlApi.MultiDrawElements(mode, count, type, indices, drawcount);
	}

	public static void MultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex) {
		GlApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
	}

	public static void MultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride) {
		GlApi.MultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
	}

	public static void MultiTexCoord1dARB(uint target, double s) {
		GlApi.MultiTexCoord1dARB(target, s);
	}

	public static void MultiTexCoord1dvARB(uint target, double* v) {
		GlApi.MultiTexCoord1dvARB(target, v);
	}

	public static void MultiTexCoord1fARB(uint target, float s) {
		GlApi.MultiTexCoord1fARB(target, s);
	}

	public static void MultiTexCoord1fvARB(uint target, float* v) {
		GlApi.MultiTexCoord1fvARB(target, v);
	}

	public static void MultiTexCoord1iARB(uint target, int s) {
		GlApi.MultiTexCoord1iARB(target, s);
	}

	public static void MultiTexCoord1ivARB(uint target, int* v) {
		GlApi.MultiTexCoord1ivARB(target, v);
	}

	public static void MultiTexCoord1sARB(uint target, short s) {
		GlApi.MultiTexCoord1sARB(target, s);
	}

	public static void MultiTexCoord1svARB(uint target, short* v) {
		GlApi.MultiTexCoord1svARB(target, v);
	}

	public static void MultiTexCoord1xOES(uint texture, int s) {
		GlApi.MultiTexCoord1xOES(texture, s);
	}

	public static void MultiTexCoord1xvOES(uint texture, int* coords) {
		GlApi.MultiTexCoord1xvOES(texture, coords);
	}

	public static void MultiTexCoord2dARB(uint target, double s, double t) {
		GlApi.MultiTexCoord2dARB(target, s, t);
	}

	public static void MultiTexCoord2dvARB(uint target, double* v) {
		GlApi.MultiTexCoord2dvARB(target, v);
	}

	public static void MultiTexCoord2fARB(uint target, float s, float t) {
		GlApi.MultiTexCoord2fARB(target, s, t);
	}

	public static void MultiTexCoord2fvARB(uint target, float* v) {
		GlApi.MultiTexCoord2fvARB(target, v);
	}

	public static void MultiTexCoord2iARB(uint target, int s, int t) {
		GlApi.MultiTexCoord2iARB(target, s, t);
	}

	public static void MultiTexCoord2ivARB(uint target, int* v) {
		GlApi.MultiTexCoord2ivARB(target, v);
	}

	public static void MultiTexCoord2sARB(uint target, short s, short t) {
		GlApi.MultiTexCoord2sARB(target, s, t);
	}

	public static void MultiTexCoord2svARB(uint target, short* v) {
		GlApi.MultiTexCoord2svARB(target, v);
	}

	public static void MultiTexCoord2xOES(uint texture, int s, int t) {
		GlApi.MultiTexCoord2xOES(texture, s, t);
	}

	public static void MultiTexCoord2xvOES(uint texture, int* coords) {
		GlApi.MultiTexCoord2xvOES(texture, coords);
	}

	public static void MultiTexCoord3dARB(uint target, double s, double t, double r) {
		GlApi.MultiTexCoord3dARB(target, s, t, r);
	}

	public static void MultiTexCoord3dvARB(uint target, double* v) {
		GlApi.MultiTexCoord3dvARB(target, v);
	}

	public static void MultiTexCoord3fARB(uint target, float s, float t, float r) {
		GlApi.MultiTexCoord3fARB(target, s, t, r);
	}

	public static void MultiTexCoord3fvARB(uint target, float* v) {
		GlApi.MultiTexCoord3fvARB(target, v);
	}

	public static void MultiTexCoord3iARB(uint target, int s, int t, int r) {
		GlApi.MultiTexCoord3iARB(target, s, t, r);
	}

	public static void MultiTexCoord3ivARB(uint target, int* v) {
		GlApi.MultiTexCoord3ivARB(target, v);
	}

	public static void MultiTexCoord3sARB(uint target, short s, short t, short r) {
		GlApi.MultiTexCoord3sARB(target, s, t, r);
	}

	public static void MultiTexCoord3svARB(uint target, short* v) {
		GlApi.MultiTexCoord3svARB(target, v);
	}

	public static void MultiTexCoord3xOES(uint texture, int s, int t, int r) {
		GlApi.MultiTexCoord3xOES(texture, s, t, r);
	}

	public static void MultiTexCoord3xvOES(uint texture, int* coords) {
		GlApi.MultiTexCoord3xvOES(texture, coords);
	}

	public static void MultiTexCoord4dARB(uint target, double s, double t, double r, double q) {
		GlApi.MultiTexCoord4dARB(target, s, t, r, q);
	}

	public static void MultiTexCoord4dvARB(uint target, double* v) {
		GlApi.MultiTexCoord4dvARB(target, v);
	}

	public static void MultiTexCoord4fARB(uint target, float s, float t, float r, float q) {
		GlApi.MultiTexCoord4fARB(target, s, t, r, q);
	}

	public static void MultiTexCoord4fvARB(uint target, float* v) {
		GlApi.MultiTexCoord4fvARB(target, v);
	}

	public static void MultiTexCoord4iARB(uint target, int s, int t, int r, int q) {
		GlApi.MultiTexCoord4iARB(target, s, t, r, q);
	}

	public static void MultiTexCoord4ivARB(uint target, int* v) {
		GlApi.MultiTexCoord4ivARB(target, v);
	}

	public static void MultiTexCoord4sARB(uint target, short s, short t, short r, short q) {
		GlApi.MultiTexCoord4sARB(target, s, t, r, q);
	}

	public static void MultiTexCoord4svARB(uint target, short* v) {
		GlApi.MultiTexCoord4svARB(target, v);
	}

	public static void MultiTexCoord4xOES(uint texture, int s, int t, int r, int q) {
		GlApi.MultiTexCoord4xOES(texture, s, t, r, q);
	}

	public static void MultiTexCoord4xvOES(uint texture, int* coords) {
		GlApi.MultiTexCoord4xvOES(texture, coords);
	}

	public static void NamedBufferData(uint buffer, nint size, void* data, uint usage) {
		GlApi.NamedBufferData(buffer, size, data, usage);
	}

	public static void NamedBufferStorage(uint buffer, nint size, void* data, uint flags) {
		GlApi.NamedBufferStorage(buffer, size, data, flags);
	}

	public static void NamedBufferSubData(uint buffer, int* offset, nint size, void* data) {
		GlApi.NamedBufferSubData(buffer, offset, size, data);
	}

	public static void NamedFramebufferDrawBuffer(uint framebuffer, uint buf) {
		GlApi.NamedFramebufferDrawBuffer(framebuffer, buf);
	}

	public static void NamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs) {
		GlApi.NamedFramebufferDrawBuffers(framebuffer, n, bufs);
	}

	public static void NamedFramebufferParameteri(uint framebuffer, uint pname, int param) {
		GlApi.NamedFramebufferParameteri(framebuffer, pname, param);
	}

	public static void NamedFramebufferReadBuffer(uint framebuffer, uint src) {
		GlApi.NamedFramebufferReadBuffer(framebuffer, src);
	}

	public static void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		GlApi.NamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
	}

	public static void NamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v) {
		GlApi.NamedFramebufferSampleLocationsfvARB(framebuffer, start, count, v);
	}

	public static void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level) {
		GlApi.NamedFramebufferTexture(framebuffer, attachment, texture, level);
	}

	public static void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer) {
		GlApi.NamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
	}

	public static void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height) {
		GlApi.NamedRenderbufferStorage(renderbuffer, internalformat, width, height);
	}

	public static void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height) {
		GlApi.NamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
	}

	public static void NamedStringARB(uint type, int namelen, char* name, int stringlen, char* str) {
		GlApi.NamedStringARB(type, namelen, name, stringlen, str);
	}

	public static void Normal3xOES(int nx, int ny, int nz) {
		GlApi.Normal3xOES(nx, ny, nz);
	}

	public static void Normal3xvOES(int* coords) {
		GlApi.Normal3xvOES(coords);
	}

	public static void ObjectLabel(uint identifier, uint name, int length, char* label) {
		GlApi.ObjectLabel(identifier, name, length, label);
	}

	public static void ObjectPtrLabel(void* ptr, int length, char* label) {
		GlApi.ObjectPtrLabel(ptr, length, label);
	}

	public static void OrthoxOES(int l, int r, int b, int t, int n, int f) {
		GlApi.OrthoxOES(l, r, b, t, n, f);
	}

	public static void PassThroughxOES(int token) {
		GlApi.PassThroughxOES(token);
	}

	public static void PatchParameterfv(uint pname, float* values) {
		GlApi.PatchParameterfv(pname, values);
	}

	public static void PatchParameteri(uint pname, int value) {
		GlApi.PatchParameteri(pname, value);
	}

	public static void PauseTransformFeedback() {
		GlApi.PauseTransformFeedback();
	}

	public static void PixelMapx(uint map, int size, int* values) {
		GlApi.PixelMapx(map, size, values);
	}

	public static void PixelStoref(uint pname, float param) {
		GlApi.PixelStoref(pname, param);
	}

	public static void PixelStorei(uint pname, int param) {
		GlApi.PixelStorei(pname, param);
	}

	public static void PixelStorex(uint pname, int param) {
		GlApi.PixelStorex(pname, param);
	}

	public static void PixelTransferxOES(uint pname, int param) {
		GlApi.PixelTransferxOES(pname, param);
	}

	public static void PixelZoomxOES(int xfactor, int yfactor) {
		GlApi.PixelZoomxOES(xfactor, yfactor);
	}

	public static void PointParameterf(uint pname, float param) {
		GlApi.PointParameterf(pname, param);
	}

	public static void PointParameterfv(uint pname, float* parameters) {
		GlApi.PointParameterfv(pname, parameters);
	}

	public static void PointParameteri(uint pname, int param) {
		GlApi.PointParameteri(pname, param);
	}

	public static void PointParameteriv(uint pname, int* parameters) {
		GlApi.PointParameteriv(pname, parameters);
	}

	public static void PointParameterxvOES(uint pname, int* parameters) {
		GlApi.PointParameterxvOES(pname, parameters);
	}

	public static void PointSize(float size) {
		GlApi.PointSize(size);
	}

	public static void PointSizexOES(int size) {
		GlApi.PointSizexOES(size);
	}

	public static void PolygonMode(uint face, uint mode) {
		GlApi.PolygonMode(face, mode);
	}

	public static void PolygonOffset(float factor, float units) {
		GlApi.PolygonOffset(factor, units);
	}

	public static void PolygonOffsetxOES(int factor, int units) {
		GlApi.PolygonOffsetxOES(factor, units);
	}

	public static void PopDebugGroup() {
		GlApi.PopDebugGroup();
	}

	public static void PrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) {
		GlApi.PrimitiveBoundingBoxARB(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
	}

	public static void PrimitiveRestartIndex(uint index) {
		GlApi.PrimitiveRestartIndex(index);
	}

	public static void PrioritizeTexturesxOES(int n, uint* textures, int* priorities) {
		GlApi.PrioritizeTexturesxOES(n, textures, priorities);
	}

	public static void ProgramBinary(uint program, uint binaryFormat, void* binary, int length) {
		GlApi.ProgramBinary(program, binaryFormat, binary, length);
	}

	public static void ProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w) {
		GlApi.ProgramEnvParameter4dARB(target, index, x, y, z, w);
	}

	public static void ProgramEnvParameter4dvARB(uint target, uint index, double* parameters) {
		GlApi.ProgramEnvParameter4dvARB(target, index, parameters);
	}

	public static void ProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w) {
		GlApi.ProgramEnvParameter4fARB(target, index, x, y, z, w);
	}

	public static void ProgramEnvParameter4fvARB(uint target, uint index, float* parameters) {
		GlApi.ProgramEnvParameter4fvARB(target, index, parameters);
	}

	public static void ProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w) {
		GlApi.ProgramLocalParameter4dARB(target, index, x, y, z, w);
	}

	public static void ProgramLocalParameter4dvARB(uint target, uint index, double* parameters) {
		GlApi.ProgramLocalParameter4dvARB(target, index, parameters);
	}

	public static void ProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w) {
		GlApi.ProgramLocalParameter4fARB(target, index, x, y, z, w);
	}

	public static void ProgramLocalParameter4fvARB(uint target, uint index, float* parameters) {
		GlApi.ProgramLocalParameter4fvARB(target, index, parameters);
	}

	public static void ProgramParameteri(uint program, uint pname, int value) {
		GlApi.ProgramParameteri(program, pname, value);
	}

	public static void ProgramParameteriARB(uint program, uint pname, int value) {
		GlApi.ProgramParameteriARB(program, pname, value);
	}

	public static void ProgramStringARB(uint target, uint format, int len, void* str) {
		GlApi.ProgramStringARB(target, format, len, str);
	}

	public static void ProgramUniform1d(uint program, int location, double v0) {
		GlApi.ProgramUniform1d(program, location, v0);
	}

	public static void ProgramUniform1dv(uint program, int location, int count, double* value) {
		GlApi.ProgramUniform1dv(program, location, count, value);
	}

	public static void ProgramUniform1f(uint program, int location, float v0) {
		GlApi.ProgramUniform1f(program, location, v0);
	}

	public static void ProgramUniform1fv(uint program, int location, int count, float* value) {
		GlApi.ProgramUniform1fv(program, location, count, value);
	}

	public static void ProgramUniform1i(uint program, int location, int v0) {
		GlApi.ProgramUniform1i(program, location, v0);
	}

	public static void ProgramUniform1i64ARB(uint program, int location, nint x) {
		GlApi.ProgramUniform1i64ARB(program, location, x);
	}

	public static void ProgramUniform1i64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform1i64vARB(program, location, count, value);
	}

	public static void ProgramUniform1iv(uint program, int location, int count, int* value) {
		GlApi.ProgramUniform1iv(program, location, count, value);
	}

	public static void ProgramUniform1ui(uint program, int location, uint v0) {
		GlApi.ProgramUniform1ui(program, location, v0);
	}

	public static void ProgramUniform1ui64ARB(uint program, int location, nint x) {
		GlApi.ProgramUniform1ui64ARB(program, location, x);
	}

	public static void ProgramUniform1ui64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform1ui64vARB(program, location, count, value);
	}

	public static void ProgramUniform1uiv(uint program, int location, int count, uint* value) {
		GlApi.ProgramUniform1uiv(program, location, count, value);
	}

	public static void ProgramUniform2d(uint program, int location, double v0, double v1) {
		GlApi.ProgramUniform2d(program, location, v0, v1);
	}

	public static void ProgramUniform2dv(uint program, int location, int count, double* value) {
		GlApi.ProgramUniform2dv(program, location, count, value);
	}

	public static void ProgramUniform2f(uint program, int location, float v0, float v1) {
		GlApi.ProgramUniform2f(program, location, v0, v1);
	}

	public static void ProgramUniform2fv(uint program, int location, int count, float* value) {
		GlApi.ProgramUniform2fv(program, location, count, value);
	}

	public static void ProgramUniform2i(uint program, int location, int v0, int v1) {
		GlApi.ProgramUniform2i(program, location, v0, v1);
	}

	public static void ProgramUniform2i64ARB(uint program, int location, nint x, nint y) {
		GlApi.ProgramUniform2i64ARB(program, location, x, y);
	}

	public static void ProgramUniform2i64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform2i64vARB(program, location, count, value);
	}

	public static void ProgramUniform2iv(uint program, int location, int count, int* value) {
		GlApi.ProgramUniform2iv(program, location, count, value);
	}

	public static void ProgramUniform2ui(uint program, int location, uint v0, uint v1) {
		GlApi.ProgramUniform2ui(program, location, v0, v1);
	}

	public static void ProgramUniform2ui64ARB(uint program, int location, nint x, nint y) {
		GlApi.ProgramUniform2ui64ARB(program, location, x, y);
	}

	public static void ProgramUniform2ui64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform2ui64vARB(program, location, count, value);
	}

	public static void ProgramUniform2uiv(uint program, int location, int count, uint* value) {
		GlApi.ProgramUniform2uiv(program, location, count, value);
	}

	public static void ProgramUniform3d(uint program, int location, double v0, double v1, double v2) {
		GlApi.ProgramUniform3d(program, location, v0, v1, v2);
	}

	public static void ProgramUniform3dv(uint program, int location, int count, double* value) {
		GlApi.ProgramUniform3dv(program, location, count, value);
	}

	public static void ProgramUniform3f(uint program, int location, float v0, float v1, float v2) {
		GlApi.ProgramUniform3f(program, location, v0, v1, v2);
	}

	public static void ProgramUniform3fv(uint program, int location, int count, float* value) {
		GlApi.ProgramUniform3fv(program, location, count, value);
	}

	public static void ProgramUniform3i(uint program, int location, int v0, int v1, int v2) {
		GlApi.ProgramUniform3i(program, location, v0, v1, v2);
	}

	public static void ProgramUniform3i64ARB(uint program, int location, nint x, nint y, nint z) {
		GlApi.ProgramUniform3i64ARB(program, location, x, y, z);
	}

	public static void ProgramUniform3i64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform3i64vARB(program, location, count, value);
	}

	public static void ProgramUniform3iv(uint program, int location, int count, int* value) {
		GlApi.ProgramUniform3iv(program, location, count, value);
	}

	public static void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) {
		GlApi.ProgramUniform3ui(program, location, v0, v1, v2);
	}

	public static void ProgramUniform3ui64ARB(uint program, int location, nint x, nint y, nint z) {
		GlApi.ProgramUniform3ui64ARB(program, location, x, y, z);
	}

	public static void ProgramUniform3ui64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform3ui64vARB(program, location, count, value);
	}

	public static void ProgramUniform3uiv(uint program, int location, int count, uint* value) {
		GlApi.ProgramUniform3uiv(program, location, count, value);
	}

	public static void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) {
		GlApi.ProgramUniform4d(program, location, v0, v1, v2, v3);
	}

	public static void ProgramUniform4dv(uint program, int location, int count, double* value) {
		GlApi.ProgramUniform4dv(program, location, count, value);
	}

	public static void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) {
		GlApi.ProgramUniform4f(program, location, v0, v1, v2, v3);
	}

	public static void ProgramUniform4fv(uint program, int location, int count, float* value) {
		GlApi.ProgramUniform4fv(program, location, count, value);
	}

	public static void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) {
		GlApi.ProgramUniform4i(program, location, v0, v1, v2, v3);
	}

	public static void ProgramUniform4i64ARB(uint program, int location, nint x, nint y, nint z, nint w) {
		GlApi.ProgramUniform4i64ARB(program, location, x, y, z, w);
	}

	public static void ProgramUniform4i64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform4i64vARB(program, location, count, value);
	}

	public static void ProgramUniform4iv(uint program, int location, int count, int* value) {
		GlApi.ProgramUniform4iv(program, location, count, value);
	}

	public static void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) {
		GlApi.ProgramUniform4ui(program, location, v0, v1, v2, v3);
	}

	public static void ProgramUniform4ui64ARB(uint program, int location, nint x, nint y, nint z, nint w) {
		GlApi.ProgramUniform4ui64ARB(program, location, x, y, z, w);
	}

	public static void ProgramUniform4ui64vARB(uint program, int location, int count, nint* value) {
		GlApi.ProgramUniform4ui64vARB(program, location, count, value);
	}

	public static void ProgramUniform4uiv(uint program, int location, int count, uint* value) {
		GlApi.ProgramUniform4uiv(program, location, count, value);
	}

	public static void ProgramUniformMatrix2dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix2dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix2fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix2x3dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix2x3dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix2x3fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix2x4dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix2x4dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix2x4fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix3dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix3dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix3fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix3x2dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix3x2dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix3x2fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix3x4dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix3x4dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix3x4fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix4dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix4dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix4fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix4x2dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix4x2dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix4x2fv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix4x3dv(uint program, int location, int count, byte transpose, double* value) {
		GlApi.ProgramUniformMatrix4x3dv(program, location, count, transpose, value);
	}

	public static void ProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value) {
		GlApi.ProgramUniformMatrix4x3fv(program, location, count, transpose, value);
	}

	public static void ProvokingVertex(uint mode) {
		GlApi.ProvokingVertex(mode);
	}

	public static void PushDebugGroup(uint source, uint id, int length, char* message) {
		GlApi.PushDebugGroup(source, id, length, message);
	}

	public static void QueryCounter(uint id, uint target) {
		GlApi.QueryCounter(id, target);
	}

	public static void RasterPos2xOES(int x, int y) {
		GlApi.RasterPos2xOES(x, y);
	}

	public static void RasterPos2xvOES(int* coords) {
		GlApi.RasterPos2xvOES(coords);
	}

	public static void RasterPos3xOES(int x, int y, int z) {
		GlApi.RasterPos3xOES(x, y, z);
	}

	public static void RasterPos3xvOES(int* coords) {
		GlApi.RasterPos3xvOES(coords);
	}

	public static void RasterPos4xOES(int x, int y, int z, int w) {
		GlApi.RasterPos4xOES(x, y, z, w);
	}

	public static void RasterPos4xvOES(int* coords) {
		GlApi.RasterPos4xvOES(coords);
	}

	public static void ReadBuffer(uint src) {
		GlApi.ReadBuffer(src);
	}

	public static void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) {
		GlApi.ReadPixels(x, y, width, height, format, type, pixels);
	}

	public static void RectxOES(int x1, int y1, int x2, int y2) {
		GlApi.RectxOES(x1, y1, x2, y2);
	}

	public static void RectxvOES(int* v1, int* v2) {
		GlApi.RectxvOES(v1, v2);
	}

	public static void ReleaseShaderCompiler() {
		GlApi.ReleaseShaderCompiler();
	}

	public static void RenderbufferStorage(uint target, uint internalformat, int width, int height) {
		GlApi.RenderbufferStorage(target, internalformat, width, height);
	}

	public static void RenderbufferStorageEXT(uint target, uint internalformat, int width, int height) {
		GlApi.RenderbufferStorageEXT(target, internalformat, width, height);
	}

	public static void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) {
		GlApi.RenderbufferStorageMultisample(target, samples, internalformat, width, height);
	}

	public static void RenderbufferStorageMultisampleEXT(uint target, int samples, uint internalformat, int width, int height) {
		GlApi.RenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
	}

	public static void ResumeTransformFeedback() {
		GlApi.ResumeTransformFeedback();
	}

	public static void RotatexOES(int angle, int x, int y, int z) {
		GlApi.RotatexOES(angle, x, y, z);
	}

	public static void SampleCoverage(float value, byte invert) {
		GlApi.SampleCoverage(value, invert);
	}

	public static void SampleCoverageARB(float value, byte invert) {
		GlApi.SampleCoverageARB(value, invert);
	}

	public static void SampleMaski(uint maskNumber, uint mask) {
		GlApi.SampleMaski(maskNumber, mask);
	}

	public static void SamplerParameterIiv(uint sampler, uint pname, int* param) {
		GlApi.SamplerParameterIiv(sampler, pname, param);
	}

	public static void SamplerParameterIuiv(uint sampler, uint pname, uint* param) {
		GlApi.SamplerParameterIuiv(sampler, pname, param);
	}

	public static void SamplerParameterf(uint sampler, uint pname, float param) {
		GlApi.SamplerParameterf(sampler, pname, param);
	}

	public static void SamplerParameterfv(uint sampler, uint pname, float* param) {
		GlApi.SamplerParameterfv(sampler, pname, param);
	}

	public static void SamplerParameteri(uint sampler, uint pname, int param) {
		GlApi.SamplerParameteri(sampler, pname, param);
	}

	public static void SamplerParameteriv(uint sampler, uint pname, int* param) {
		GlApi.SamplerParameteriv(sampler, pname, param);
	}

	public static void ScalexOES(int x, int y, int z) {
		GlApi.ScalexOES(x, y, z);
	}

	public static void Scissor(int x, int y, int width, int height) {
		GlApi.Scissor(x, y, width, height);
	}

	public static void ScissorArrayv(uint first, int count, int* v) {
		GlApi.ScissorArrayv(first, count, v);
	}

	public static void ScissorIndexed(uint index, int left, int bottom, int width, int height) {
		GlApi.ScissorIndexed(index, left, bottom, width, height);
	}

	public static void ScissorIndexedv(uint index, int* v) {
		GlApi.ScissorIndexedv(index, v);
	}

	public static void ShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length) {
		GlApi.ShaderBinary(count, shaders, binaryFormat, binary, length);
	}

	public static void ShaderSource(uint shader, int count, char** str, int* length) {
		GlApi.ShaderSource(shader, count, str, length);
	}

	public static void ShaderSourceARB(uint shaderObj, int count, char** str, int* length) {
		GlApi.ShaderSourceARB(shaderObj, count, str, length);
	}

	public static void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) {
		GlApi.ShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
	}

	public static void SpecializeShaderARB(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) {
		GlApi.SpecializeShaderARB(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
	}

	public static void StencilFunc(uint func, int reference, uint mask) {
		GlApi.StencilFunc(func, reference, mask);
	}

	public static void StencilFuncSeparate(uint face, uint func, int reference, uint mask) {
		GlApi.StencilFuncSeparate(face, func, reference, mask);
	}

	public static void StencilMask(uint mask) {
		GlApi.StencilMask(mask);
	}

	public static void StencilMaskSeparate(uint face, uint mask) {
		GlApi.StencilMaskSeparate(face, mask);
	}

	public static void StencilOp(uint fail, uint zfail, uint zpass) {
		GlApi.StencilOp(fail, zfail, zpass);
	}

	public static void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) {
		GlApi.StencilOpSeparate(face, sfail, dpfail, dppass);
	}

	public static void TexBuffer(uint target, uint internalformat, uint buffer) {
		GlApi.TexBuffer(target, internalformat, buffer);
	}

	public static void TexBufferRange(uint target, uint internalformat, uint buffer, int* offset, nint size) {
		GlApi.TexBufferRange(target, internalformat, buffer, offset, size);
	}

	public static void TexCoord1xOES(int s) {
		GlApi.TexCoord1xOES(s);
	}

	public static void TexCoord1xvOES(int* coords) {
		GlApi.TexCoord1xvOES(coords);
	}

	public static void TexCoord2xOES(int s, int t) {
		GlApi.TexCoord2xOES(s, t);
	}

	public static void TexCoord2xvOES(int* coords) {
		GlApi.TexCoord2xvOES(coords);
	}

	public static void TexCoord3xOES(int s, int t, int r) {
		GlApi.TexCoord3xOES(s, t, r);
	}

	public static void TexCoord3xvOES(int* coords) {
		GlApi.TexCoord3xvOES(coords);
	}

	public static void TexCoord4xOES(int s, int t, int r, int q) {
		GlApi.TexCoord4xOES(s, t, r, q);
	}

	public static void TexCoord4xvOES(int* coords) {
		GlApi.TexCoord4xvOES(coords);
	}

	public static void TexEnvxOES(uint target, uint pname, int param) {
		GlApi.TexEnvxOES(target, pname, param);
	}

	public static void TexEnvxvOES(uint target, uint pname, int* parameters) {
		GlApi.TexEnvxvOES(target, pname, parameters);
	}

	public static void TexGenxOES(uint coord, uint pname, int param) {
		GlApi.TexGenxOES(coord, pname, param);
	}

	public static void TexGenxvOES(uint coord, uint pname, int* parameters) {
		GlApi.TexGenxvOES(coord, pname, parameters);
	}

	public static void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels) {
		GlApi.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
	}

	public static void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) {
		GlApi.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
	}

	public static void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		GlApi.TexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
	}

	public static void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels) {
		GlApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
	}

	public static void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		GlApi.TexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	public static void TexParameterIiv(uint target, uint pname, int* parameters) {
		GlApi.TexParameterIiv(target, pname, parameters);
	}

	public static void TexParameterIuiv(uint target, uint pname, uint* parameters) {
		GlApi.TexParameterIuiv(target, pname, parameters);
	}

	public static void TexParameterf(uint target, uint pname, float param) {
		GlApi.TexParameterf(target, pname, param);
	}

	public static void TexParameterfv(uint target, uint pname, float* parameters) {
		GlApi.TexParameterfv(target, pname, parameters);
	}

	public static void TexParameteri(uint target, uint pname, int param) {
		GlApi.TexParameteri(target, pname, param);
	}

	public static void TexParameteriv(uint target, uint pname, int* parameters) {
		GlApi.TexParameteriv(target, pname, parameters);
	}

	public static void TexParameterxOES(uint target, uint pname, int param) {
		GlApi.TexParameterxOES(target, pname, param);
	}

	public static void TexParameterxvOES(uint target, uint pname, int* parameters) {
		GlApi.TexParameterxvOES(target, pname, parameters);
	}

	public static void TexStorage1D(uint target, int levels, uint internalformat, int width) {
		GlApi.TexStorage1D(target, levels, internalformat, width);
	}

	public static void TexStorage2D(uint target, int levels, uint internalformat, int width, int height) {
		GlApi.TexStorage2D(target, levels, internalformat, width, height);
	}

	public static void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		GlApi.TexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
	}

	public static void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) {
		GlApi.TexStorage3D(target, levels, internalformat, width, height, depth);
	}

	public static void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		GlApi.TexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	public static void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels) {
		GlApi.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
	}

	public static void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) {
		GlApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	public static void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) {
		GlApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	public static void TextureBuffer(uint texture, uint internalformat, uint buffer) {
		GlApi.TextureBuffer(texture, internalformat, buffer);
	}

	public static void TextureBufferRange(uint texture, uint internalformat, uint buffer, int* offset, nint size) {
		GlApi.TextureBufferRange(texture, internalformat, buffer, offset, size);
	}

	public static void TextureParameterIiv(uint texture, uint pname, int* parameters) {
		GlApi.TextureParameterIiv(texture, pname, parameters);
	}

	public static void TextureParameterIuiv(uint texture, uint pname, uint* parameters) {
		GlApi.TextureParameterIuiv(texture, pname, parameters);
	}

	public static void TextureParameterf(uint texture, uint pname, float param) {
		GlApi.TextureParameterf(texture, pname, param);
	}

	public static void TextureParameterfv(uint texture, uint pname, float* param) {
		GlApi.TextureParameterfv(texture, pname, param);
	}

	public static void TextureParameteri(uint texture, uint pname, int param) {
		GlApi.TextureParameteri(texture, pname, param);
	}

	public static void TextureParameteriv(uint texture, uint pname, int* param) {
		GlApi.TextureParameteriv(texture, pname, param);
	}

	public static void TextureStorage1D(uint texture, int levels, uint internalformat, int width) {
		GlApi.TextureStorage1D(texture, levels, internalformat, width);
	}

	public static void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height) {
		GlApi.TextureStorage2D(texture, levels, internalformat, width, height);
	}

	public static void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, byte fixedsamplelocations) {
		GlApi.TextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
	}

	public static void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth) {
		GlApi.TextureStorage3D(texture, levels, internalformat, width, height, depth);
	}

	public static void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations) {
		GlApi.TextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
	}

	public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels) {
		GlApi.TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
	}

	public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) {
		GlApi.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) {
		GlApi.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	public static void TextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) {
		GlApi.TextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
	}

	public static void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer) {
		GlApi.TransformFeedbackBufferBase(xfb, index, buffer);
	}

	public static void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int* offset, nint size) {
		GlApi.TransformFeedbackBufferRange(xfb, index, buffer, offset, size);
	}

	public static void TransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode) {
		GlApi.TransformFeedbackVaryings(program, count, varyings, bufferMode);
	}

	public static void TranslatexOES(int x, int y, int z) {
		GlApi.TranslatexOES(x, y, z);
	}

	public static void Uniform1d(int location, double x) {
		GlApi.Uniform1d(location, x);
	}

	public static void Uniform1dv(int location, int count, double* value) {
		GlApi.Uniform1dv(location, count, value);
	}

	public static void Uniform1f(int location, float v0) {
		GlApi.Uniform1f(location, v0);
	}

	public static void Uniform1fARB(int location, float v0) {
		GlApi.Uniform1fARB(location, v0);
	}

	public static void Uniform1fv(int location, int count, float* value) {
		GlApi.Uniform1fv(location, count, value);
	}

	public static void Uniform1fvARB(int location, int count, float* value) {
		GlApi.Uniform1fvARB(location, count, value);
	}

	public static void Uniform1i(int location, int v0) {
		GlApi.Uniform1i(location, v0);
	}

	public static void Uniform1i64ARB(int location, nint x) {
		GlApi.Uniform1i64ARB(location, x);
	}

	public static void Uniform1i64vARB(int location, int count, nint* value) {
		GlApi.Uniform1i64vARB(location, count, value);
	}

	public static void Uniform1iARB(int location, int v0) {
		GlApi.Uniform1iARB(location, v0);
	}

	public static void Uniform1iv(int location, int count, int* value) {
		GlApi.Uniform1iv(location, count, value);
	}

	public static void Uniform1ivARB(int location, int count, int* value) {
		GlApi.Uniform1ivARB(location, count, value);
	}

	public static void Uniform1ui(int location, uint v0) {
		GlApi.Uniform1ui(location, v0);
	}

	public static void Uniform1ui64ARB(int location, nint x) {
		GlApi.Uniform1ui64ARB(location, x);
	}

	public static void Uniform1ui64vARB(int location, int count, nint* value) {
		GlApi.Uniform1ui64vARB(location, count, value);
	}

	public static void Uniform1uiv(int location, int count, uint* value) {
		GlApi.Uniform1uiv(location, count, value);
	}

	public static void Uniform2d(int location, double x, double y) {
		GlApi.Uniform2d(location, x, y);
	}

	public static void Uniform2dv(int location, int count, double* value) {
		GlApi.Uniform2dv(location, count, value);
	}

	public static void Uniform2f(int location, float v0, float v1) {
		GlApi.Uniform2f(location, v0, v1);
	}

	public static void Uniform2fARB(int location, float v0, float v1) {
		GlApi.Uniform2fARB(location, v0, v1);
	}

	public static void Uniform2fv(int location, int count, float* value) {
		GlApi.Uniform2fv(location, count, value);
	}

	public static void Uniform2fvARB(int location, int count, float* value) {
		GlApi.Uniform2fvARB(location, count, value);
	}

	public static void Uniform2i(int location, int v0, int v1) {
		GlApi.Uniform2i(location, v0, v1);
	}

	public static void Uniform2i64ARB(int location, nint x, nint y) {
		GlApi.Uniform2i64ARB(location, x, y);
	}

	public static void Uniform2i64vARB(int location, int count, nint* value) {
		GlApi.Uniform2i64vARB(location, count, value);
	}

	public static void Uniform2iARB(int location, int v0, int v1) {
		GlApi.Uniform2iARB(location, v0, v1);
	}

	public static void Uniform2iv(int location, int count, int* value) {
		GlApi.Uniform2iv(location, count, value);
	}

	public static void Uniform2ivARB(int location, int count, int* value) {
		GlApi.Uniform2ivARB(location, count, value);
	}

	public static void Uniform2ui(int location, uint v0, uint v1) {
		GlApi.Uniform2ui(location, v0, v1);
	}

	public static void Uniform2ui64ARB(int location, nint x, nint y) {
		GlApi.Uniform2ui64ARB(location, x, y);
	}

	public static void Uniform2ui64vARB(int location, int count, nint* value) {
		GlApi.Uniform2ui64vARB(location, count, value);
	}

	public static void Uniform2uiv(int location, int count, uint* value) {
		GlApi.Uniform2uiv(location, count, value);
	}

	public static void Uniform3d(int location, double x, double y, double z) {
		GlApi.Uniform3d(location, x, y, z);
	}

	public static void Uniform3dv(int location, int count, double* value) {
		GlApi.Uniform3dv(location, count, value);
	}

	public static void Uniform3f(int location, float v0, float v1, float v2) {
		GlApi.Uniform3f(location, v0, v1, v2);
	}

	public static void Uniform3fARB(int location, float v0, float v1, float v2) {
		GlApi.Uniform3fARB(location, v0, v1, v2);
	}

	public static void Uniform3fv(int location, int count, float* value) {
		GlApi.Uniform3fv(location, count, value);
	}

	public static void Uniform3fvARB(int location, int count, float* value) {
		GlApi.Uniform3fvARB(location, count, value);
	}

	public static void Uniform3i(int location, int v0, int v1, int v2) {
		GlApi.Uniform3i(location, v0, v1, v2);
	}

	public static void Uniform3i64ARB(int location, nint x, nint y, nint z) {
		GlApi.Uniform3i64ARB(location, x, y, z);
	}

	public static void Uniform3i64vARB(int location, int count, nint* value) {
		GlApi.Uniform3i64vARB(location, count, value);
	}

	public static void Uniform3iARB(int location, int v0, int v1, int v2) {
		GlApi.Uniform3iARB(location, v0, v1, v2);
	}

	public static void Uniform3iv(int location, int count, int* value) {
		GlApi.Uniform3iv(location, count, value);
	}

	public static void Uniform3ivARB(int location, int count, int* value) {
		GlApi.Uniform3ivARB(location, count, value);
	}

	public static void Uniform3ui(int location, uint v0, uint v1, uint v2) {
		GlApi.Uniform3ui(location, v0, v1, v2);
	}

	public static void Uniform3ui64ARB(int location, nint x, nint y, nint z) {
		GlApi.Uniform3ui64ARB(location, x, y, z);
	}

	public static void Uniform3ui64vARB(int location, int count, nint* value) {
		GlApi.Uniform3ui64vARB(location, count, value);
	}

	public static void Uniform3uiv(int location, int count, uint* value) {
		GlApi.Uniform3uiv(location, count, value);
	}

	public static void Uniform4d(int location, double x, double y, double z, double w) {
		GlApi.Uniform4d(location, x, y, z, w);
	}

	public static void Uniform4dv(int location, int count, double* value) {
		GlApi.Uniform4dv(location, count, value);
	}

	public static void Uniform4f(int location, float v0, float v1, float v2, float v3) {
		GlApi.Uniform4f(location, v0, v1, v2, v3);
	}

	public static void Uniform4fARB(int location, float v0, float v1, float v2, float v3) {
		GlApi.Uniform4fARB(location, v0, v1, v2, v3);
	}

	public static void Uniform4fv(int location, int count, float* value) {
		GlApi.Uniform4fv(location, count, value);
	}

	public static void Uniform4fvARB(int location, int count, float* value) {
		GlApi.Uniform4fvARB(location, count, value);
	}

	public static void Uniform4i(int location, int v0, int v1, int v2, int v3) {
		GlApi.Uniform4i(location, v0, v1, v2, v3);
	}

	public static void Uniform4i64ARB(int location, nint x, nint y, nint z, nint w) {
		GlApi.Uniform4i64ARB(location, x, y, z, w);
	}

	public static void Uniform4i64vARB(int location, int count, nint* value) {
		GlApi.Uniform4i64vARB(location, count, value);
	}

	public static void Uniform4iARB(int location, int v0, int v1, int v2, int v3) {
		GlApi.Uniform4iARB(location, v0, v1, v2, v3);
	}

	public static void Uniform4iv(int location, int count, int* value) {
		GlApi.Uniform4iv(location, count, value);
	}

	public static void Uniform4ivARB(int location, int count, int* value) {
		GlApi.Uniform4ivARB(location, count, value);
	}

	public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) {
		GlApi.Uniform4ui(location, v0, v1, v2, v3);
	}

	public static void Uniform4ui64ARB(int location, nint x, nint y, nint z, nint w) {
		GlApi.Uniform4ui64ARB(location, x, y, z, w);
	}

	public static void Uniform4ui64vARB(int location, int count, nint* value) {
		GlApi.Uniform4ui64vARB(location, count, value);
	}

	public static void Uniform4uiv(int location, int count, uint* value) {
		GlApi.Uniform4uiv(location, count, value);
	}

	public static void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) {
		GlApi.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
	}

	public static void UniformMatrix2dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix2dv(location, count, transpose, value);
	}

	public static void UniformMatrix2fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix2fv(location, count, transpose, value);
	}

	public static void UniformMatrix2fvARB(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix2fvARB(location, count, transpose, value);
	}

	public static void UniformMatrix2x3dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix2x3dv(location, count, transpose, value);
	}

	public static void UniformMatrix2x3fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix2x3fv(location, count, transpose, value);
	}

	public static void UniformMatrix2x4dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix2x4dv(location, count, transpose, value);
	}

	public static void UniformMatrix2x4fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix2x4fv(location, count, transpose, value);
	}

	public static void UniformMatrix3dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix3dv(location, count, transpose, value);
	}

	public static void UniformMatrix3fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix3fv(location, count, transpose, value);
	}

	public static void UniformMatrix3fvARB(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix3fvARB(location, count, transpose, value);
	}

	public static void UniformMatrix3x2dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix3x2dv(location, count, transpose, value);
	}

	public static void UniformMatrix3x2fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix3x2fv(location, count, transpose, value);
	}

	public static void UniformMatrix3x4dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix3x4dv(location, count, transpose, value);
	}

	public static void UniformMatrix3x4fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix3x4fv(location, count, transpose, value);
	}

	public static void UniformMatrix4dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix4dv(location, count, transpose, value);
	}

	public static void UniformMatrix4fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix4fv(location, count, transpose, value);
	}

	public static void UniformMatrix4fvARB(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix4fvARB(location, count, transpose, value);
	}

	public static void UniformMatrix4x2dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix4x2dv(location, count, transpose, value);
	}

	public static void UniformMatrix4x2fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix4x2fv(location, count, transpose, value);
	}

	public static void UniformMatrix4x3dv(int location, int count, byte transpose, double* value) {
		GlApi.UniformMatrix4x3dv(location, count, transpose, value);
	}

	public static void UniformMatrix4x3fv(int location, int count, byte transpose, float* value) {
		GlApi.UniformMatrix4x3fv(location, count, transpose, value);
	}

	public static void UniformSubroutinesuiv(uint shadertype, int count, uint* indices) {
		GlApi.UniformSubroutinesuiv(shadertype, count, indices);
	}

	public static byte UnmapBuffer(uint target) {
		return GlApi.UnmapBuffer(target);
	}

	public static byte UnmapBufferARB(uint target) {
		return GlApi.UnmapBufferARB(target);
	}

	public static byte UnmapNamedBuffer(uint buffer) {
		return GlApi.UnmapNamedBuffer(buffer);
	}

	public static void UseProgram(uint program) {
		GlApi.UseProgram(program);
	}

	public static void UseProgramObjectARB(uint programObj) {
		GlApi.UseProgramObjectARB(programObj);
	}

	public static void UseProgramStages(uint pipeline, uint stages, uint program) {
		GlApi.UseProgramStages(pipeline, stages, program);
	}

	public static void ValidateProgram(uint program) {
		GlApi.ValidateProgram(program);
	}

	public static void ValidateProgramARB(uint programObj) {
		GlApi.ValidateProgramARB(programObj);
	}

	public static void ValidateProgramPipeline(uint pipeline) {
		GlApi.ValidateProgramPipeline(pipeline);
	}

	public static void Vertex2xOES(int x) {
		GlApi.Vertex2xOES(x);
	}

	public static void Vertex2xvOES(int* coords) {
		GlApi.Vertex2xvOES(coords);
	}

	public static void Vertex3xOES(int x, int y) {
		GlApi.Vertex3xOES(x, y);
	}

	public static void Vertex3xvOES(int* coords) {
		GlApi.Vertex3xvOES(coords);
	}

	public static void Vertex4xOES(int x, int y, int z) {
		GlApi.Vertex4xOES(x, y, z);
	}

	public static void Vertex4xvOES(int* coords) {
		GlApi.Vertex4xvOES(coords);
	}

	public static void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) {
		GlApi.VertexArrayAttribBinding(vaobj, attribindex, bindingindex);
	}

	public static void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset) {
		GlApi.VertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
	}

	public static void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		GlApi.VertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
	}

	public static void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		GlApi.VertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
	}

	public static void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) {
		GlApi.VertexArrayBindingDivisor(vaobj, bindingindex, divisor);
	}

	public static void VertexArrayElementBuffer(uint vaobj, uint buffer) {
		GlApi.VertexArrayElementBuffer(vaobj, buffer);
	}

	public static void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int* offset, int stride) {
		GlApi.VertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
	}

	public static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, int** offsets, int* strides) {
		GlApi.VertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
	}

	public static void VertexAttrib1d(uint index, double x) {
		GlApi.VertexAttrib1d(index, x);
	}

	public static void VertexAttrib1dARB(uint index, double x) {
		GlApi.VertexAttrib1dARB(index, x);
	}

	public static void VertexAttrib1dv(uint index, double* v) {
		GlApi.VertexAttrib1dv(index, v);
	}

	public static void VertexAttrib1dvARB(uint index, double* v) {
		GlApi.VertexAttrib1dvARB(index, v);
	}

	public static void VertexAttrib1f(uint index, float x) {
		GlApi.VertexAttrib1f(index, x);
	}

	public static void VertexAttrib1fARB(uint index, float x) {
		GlApi.VertexAttrib1fARB(index, x);
	}

	public static void VertexAttrib1fv(uint index, float* v) {
		GlApi.VertexAttrib1fv(index, v);
	}

	public static void VertexAttrib1fvARB(uint index, float* v) {
		GlApi.VertexAttrib1fvARB(index, v);
	}

	public static void VertexAttrib1s(uint index, short x) {
		GlApi.VertexAttrib1s(index, x);
	}

	public static void VertexAttrib1sARB(uint index, short x) {
		GlApi.VertexAttrib1sARB(index, x);
	}

	public static void VertexAttrib1sv(uint index, short* v) {
		GlApi.VertexAttrib1sv(index, v);
	}

	public static void VertexAttrib1svARB(uint index, short* v) {
		GlApi.VertexAttrib1svARB(index, v);
	}

	public static void VertexAttrib2d(uint index, double x, double y) {
		GlApi.VertexAttrib2d(index, x, y);
	}

	public static void VertexAttrib2dARB(uint index, double x, double y) {
		GlApi.VertexAttrib2dARB(index, x, y);
	}

	public static void VertexAttrib2dv(uint index, double* v) {
		GlApi.VertexAttrib2dv(index, v);
	}

	public static void VertexAttrib2dvARB(uint index, double* v) {
		GlApi.VertexAttrib2dvARB(index, v);
	}

	public static void VertexAttrib2f(uint index, float x, float y) {
		GlApi.VertexAttrib2f(index, x, y);
	}

	public static void VertexAttrib2fARB(uint index, float x, float y) {
		GlApi.VertexAttrib2fARB(index, x, y);
	}

	public static void VertexAttrib2fv(uint index, float* v) {
		GlApi.VertexAttrib2fv(index, v);
	}

	public static void VertexAttrib2fvARB(uint index, float* v) {
		GlApi.VertexAttrib2fvARB(index, v);
	}

	public static void VertexAttrib2s(uint index, short x, short y) {
		GlApi.VertexAttrib2s(index, x, y);
	}

	public static void VertexAttrib2sARB(uint index, short x, short y) {
		GlApi.VertexAttrib2sARB(index, x, y);
	}

	public static void VertexAttrib2sv(uint index, short* v) {
		GlApi.VertexAttrib2sv(index, v);
	}

	public static void VertexAttrib2svARB(uint index, short* v) {
		GlApi.VertexAttrib2svARB(index, v);
	}

	public static void VertexAttrib3d(uint index, double x, double y, double z) {
		GlApi.VertexAttrib3d(index, x, y, z);
	}

	public static void VertexAttrib3dARB(uint index, double x, double y, double z) {
		GlApi.VertexAttrib3dARB(index, x, y, z);
	}

	public static void VertexAttrib3dv(uint index, double* v) {
		GlApi.VertexAttrib3dv(index, v);
	}

	public static void VertexAttrib3dvARB(uint index, double* v) {
		GlApi.VertexAttrib3dvARB(index, v);
	}

	public static void VertexAttrib3f(uint index, float x, float y, float z) {
		GlApi.VertexAttrib3f(index, x, y, z);
	}

	public static void VertexAttrib3fARB(uint index, float x, float y, float z) {
		GlApi.VertexAttrib3fARB(index, x, y, z);
	}

	public static void VertexAttrib3fv(uint index, float* v) {
		GlApi.VertexAttrib3fv(index, v);
	}

	public static void VertexAttrib3fvARB(uint index, float* v) {
		GlApi.VertexAttrib3fvARB(index, v);
	}

	public static void VertexAttrib3s(uint index, short x, short y, short z) {
		GlApi.VertexAttrib3s(index, x, y, z);
	}

	public static void VertexAttrib3sARB(uint index, short x, short y, short z) {
		GlApi.VertexAttrib3sARB(index, x, y, z);
	}

	public static void VertexAttrib3sv(uint index, short* v) {
		GlApi.VertexAttrib3sv(index, v);
	}

	public static void VertexAttrib3svARB(uint index, short* v) {
		GlApi.VertexAttrib3svARB(index, v);
	}

	public static void VertexAttrib4Nbv(uint index, sbyte* v) {
		GlApi.VertexAttrib4Nbv(index, v);
	}

	public static void VertexAttrib4NbvARB(uint index, sbyte* v) {
		GlApi.VertexAttrib4NbvARB(index, v);
	}

	public static void VertexAttrib4Niv(uint index, int* v) {
		GlApi.VertexAttrib4Niv(index, v);
	}

	public static void VertexAttrib4NivARB(uint index, int* v) {
		GlApi.VertexAttrib4NivARB(index, v);
	}

	public static void VertexAttrib4Nsv(uint index, short* v) {
		GlApi.VertexAttrib4Nsv(index, v);
	}

	public static void VertexAttrib4NsvARB(uint index, short* v) {
		GlApi.VertexAttrib4NsvARB(index, v);
	}

	public static void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) {
		GlApi.VertexAttrib4Nub(index, x, y, z, w);
	}

	public static void VertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) {
		GlApi.VertexAttrib4NubARB(index, x, y, z, w);
	}

	public static void VertexAttrib4Nubv(uint index, byte* v) {
		GlApi.VertexAttrib4Nubv(index, v);
	}

	public static void VertexAttrib4NubvARB(uint index, byte* v) {
		GlApi.VertexAttrib4NubvARB(index, v);
	}

	public static void VertexAttrib4Nuiv(uint index, uint* v) {
		GlApi.VertexAttrib4Nuiv(index, v);
	}

	public static void VertexAttrib4NuivARB(uint index, uint* v) {
		GlApi.VertexAttrib4NuivARB(index, v);
	}

	public static void VertexAttrib4Nusv(uint index, ushort* v) {
		GlApi.VertexAttrib4Nusv(index, v);
	}

	public static void VertexAttrib4NusvARB(uint index, ushort* v) {
		GlApi.VertexAttrib4NusvARB(index, v);
	}

	public static void VertexAttrib4bv(uint index, sbyte* v) {
		GlApi.VertexAttrib4bv(index, v);
	}

	public static void VertexAttrib4bvARB(uint index, sbyte* v) {
		GlApi.VertexAttrib4bvARB(index, v);
	}

	public static void VertexAttrib4d(uint index, double x, double y, double z, double w) {
		GlApi.VertexAttrib4d(index, x, y, z, w);
	}

	public static void VertexAttrib4dARB(uint index, double x, double y, double z, double w) {
		GlApi.VertexAttrib4dARB(index, x, y, z, w);
	}

	public static void VertexAttrib4dv(uint index, double* v) {
		GlApi.VertexAttrib4dv(index, v);
	}

	public static void VertexAttrib4dvARB(uint index, double* v) {
		GlApi.VertexAttrib4dvARB(index, v);
	}

	public static void VertexAttrib4f(uint index, float x, float y, float z, float w) {
		GlApi.VertexAttrib4f(index, x, y, z, w);
	}

	public static void VertexAttrib4fARB(uint index, float x, float y, float z, float w) {
		GlApi.VertexAttrib4fARB(index, x, y, z, w);
	}

	public static void VertexAttrib4fv(uint index, float* v) {
		GlApi.VertexAttrib4fv(index, v);
	}

	public static void VertexAttrib4fvARB(uint index, float* v) {
		GlApi.VertexAttrib4fvARB(index, v);
	}

	public static void VertexAttrib4iv(uint index, int* v) {
		GlApi.VertexAttrib4iv(index, v);
	}

	public static void VertexAttrib4ivARB(uint index, int* v) {
		GlApi.VertexAttrib4ivARB(index, v);
	}

	public static void VertexAttrib4s(uint index, short x, short y, short z, short w) {
		GlApi.VertexAttrib4s(index, x, y, z, w);
	}

	public static void VertexAttrib4sARB(uint index, short x, short y, short z, short w) {
		GlApi.VertexAttrib4sARB(index, x, y, z, w);
	}

	public static void VertexAttrib4sv(uint index, short* v) {
		GlApi.VertexAttrib4sv(index, v);
	}

	public static void VertexAttrib4svARB(uint index, short* v) {
		GlApi.VertexAttrib4svARB(index, v);
	}

	public static void VertexAttrib4ubv(uint index, byte* v) {
		GlApi.VertexAttrib4ubv(index, v);
	}

	public static void VertexAttrib4ubvARB(uint index, byte* v) {
		GlApi.VertexAttrib4ubvARB(index, v);
	}

	public static void VertexAttrib4uiv(uint index, uint* v) {
		GlApi.VertexAttrib4uiv(index, v);
	}

	public static void VertexAttrib4uivARB(uint index, uint* v) {
		GlApi.VertexAttrib4uivARB(index, v);
	}

	public static void VertexAttrib4usv(uint index, ushort* v) {
		GlApi.VertexAttrib4usv(index, v);
	}

	public static void VertexAttrib4usvARB(uint index, ushort* v) {
		GlApi.VertexAttrib4usvARB(index, v);
	}

	public static void VertexAttribBinding(uint attribindex, uint bindingindex) {
		GlApi.VertexAttribBinding(attribindex, bindingindex);
	}

	public static void VertexAttribDivisor(uint index, uint divisor) {
		GlApi.VertexAttribDivisor(index, divisor);
	}

	public static void VertexAttribDivisorARB(uint index, uint divisor) {
		GlApi.VertexAttribDivisorARB(index, divisor);
	}

	public static void VertexAttribFormat(uint attribindex, int size, uint type, byte normalized, uint relativeoffset) {
		GlApi.VertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
	}

	public static void VertexAttribI1i(uint index, int x) {
		GlApi.VertexAttribI1i(index, x);
	}

	public static void VertexAttribI1iv(uint index, int* v) {
		GlApi.VertexAttribI1iv(index, v);
	}

	public static void VertexAttribI1ui(uint index, uint x) {
		GlApi.VertexAttribI1ui(index, x);
	}

	public static void VertexAttribI1uiv(uint index, uint* v) {
		GlApi.VertexAttribI1uiv(index, v);
	}

	public static void VertexAttribI2i(uint index, int x, int y) {
		GlApi.VertexAttribI2i(index, x, y);
	}

	public static void VertexAttribI2iv(uint index, int* v) {
		GlApi.VertexAttribI2iv(index, v);
	}

	public static void VertexAttribI2ui(uint index, uint x, uint y) {
		GlApi.VertexAttribI2ui(index, x, y);
	}

	public static void VertexAttribI2uiv(uint index, uint* v) {
		GlApi.VertexAttribI2uiv(index, v);
	}

	public static void VertexAttribI3i(uint index, int x, int y, int z) {
		GlApi.VertexAttribI3i(index, x, y, z);
	}

	public static void VertexAttribI3iv(uint index, int* v) {
		GlApi.VertexAttribI3iv(index, v);
	}

	public static void VertexAttribI3ui(uint index, uint x, uint y, uint z) {
		GlApi.VertexAttribI3ui(index, x, y, z);
	}

	public static void VertexAttribI3uiv(uint index, uint* v) {
		GlApi.VertexAttribI3uiv(index, v);
	}

	public static void VertexAttribI4bv(uint index, sbyte* v) {
		GlApi.VertexAttribI4bv(index, v);
	}

	public static void VertexAttribI4i(uint index, int x, int y, int z, int w) {
		GlApi.VertexAttribI4i(index, x, y, z, w);
	}

	public static void VertexAttribI4iv(uint index, int* v) {
		GlApi.VertexAttribI4iv(index, v);
	}

	public static void VertexAttribI4sv(uint index, short* v) {
		GlApi.VertexAttribI4sv(index, v);
	}

	public static void VertexAttribI4ubv(uint index, byte* v) {
		GlApi.VertexAttribI4ubv(index, v);
	}

	public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) {
		GlApi.VertexAttribI4ui(index, x, y, z, w);
	}

	public static void VertexAttribI4uiv(uint index, uint* v) {
		GlApi.VertexAttribI4uiv(index, v);
	}

	public static void VertexAttribI4usv(uint index, ushort* v) {
		GlApi.VertexAttribI4usv(index, v);
	}

	public static void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		GlApi.VertexAttribIFormat(attribindex, size, type, relativeoffset);
	}

	public static void VertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer) {
		GlApi.VertexAttribIPointer(index, size, type, stride, pointer);
	}

	public static void VertexAttribL1d(uint index, double x) {
		GlApi.VertexAttribL1d(index, x);
	}

	public static void VertexAttribL1dv(uint index, double* v) {
		GlApi.VertexAttribL1dv(index, v);
	}

	public static void VertexAttribL2d(uint index, double x, double y) {
		GlApi.VertexAttribL2d(index, x, y);
	}

	public static void VertexAttribL2dv(uint index, double* v) {
		GlApi.VertexAttribL2dv(index, v);
	}

	public static void VertexAttribL3d(uint index, double x, double y, double z) {
		GlApi.VertexAttribL3d(index, x, y, z);
	}

	public static void VertexAttribL3dv(uint index, double* v) {
		GlApi.VertexAttribL3dv(index, v);
	}

	public static void VertexAttribL4d(uint index, double x, double y, double z, double w) {
		GlApi.VertexAttribL4d(index, x, y, z, w);
	}

	public static void VertexAttribL4dv(uint index, double* v) {
		GlApi.VertexAttribL4dv(index, v);
	}

	public static void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		GlApi.VertexAttribLFormat(attribindex, size, type, relativeoffset);
	}

	public static void VertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer) {
		GlApi.VertexAttribLPointer(index, size, type, stride, pointer);
	}

	public static void VertexAttribP1ui(uint index, uint type, byte normalized, uint value) {
		GlApi.VertexAttribP1ui(index, type, normalized, value);
	}

	public static void VertexAttribP1uiv(uint index, uint type, byte normalized, uint* value) {
		GlApi.VertexAttribP1uiv(index, type, normalized, value);
	}

	public static void VertexAttribP2ui(uint index, uint type, byte normalized, uint value) {
		GlApi.VertexAttribP2ui(index, type, normalized, value);
	}

	public static void VertexAttribP2uiv(uint index, uint type, byte normalized, uint* value) {
		GlApi.VertexAttribP2uiv(index, type, normalized, value);
	}

	public static void VertexAttribP3ui(uint index, uint type, byte normalized, uint value) {
		GlApi.VertexAttribP3ui(index, type, normalized, value);
	}

	public static void VertexAttribP3uiv(uint index, uint type, byte normalized, uint* value) {
		GlApi.VertexAttribP3uiv(index, type, normalized, value);
	}

	public static void VertexAttribP4ui(uint index, uint type, byte normalized, uint value) {
		GlApi.VertexAttribP4ui(index, type, normalized, value);
	}

	public static void VertexAttribP4uiv(uint index, uint type, byte normalized, uint* value) {
		GlApi.VertexAttribP4uiv(index, type, normalized, value);
	}

	public static void VertexAttribPointer(uint index, int size, uint type, byte normalized, int stride, void* pointer) {
		GlApi.VertexAttribPointer(index, size, type, normalized, stride, pointer);
	}

	public static void VertexAttribPointerARB(uint index, int size, uint type, byte normalized, int stride, void* pointer) {
		GlApi.VertexAttribPointerARB(index, size, type, normalized, stride, pointer);
	}

	public static void VertexBindingDivisor(uint bindingindex, uint divisor) {
		GlApi.VertexBindingDivisor(bindingindex, divisor);
	}

	public static void Viewport(int x, int y, int width, int height) {
		GlApi.Viewport(x, y, width, height);
	}

	public static void ViewportArrayv(uint first, int count, float* v) {
		GlApi.ViewportArrayv(first, count, v);
	}

	public static void ViewportIndexedf(uint index, float x, float y, float w, float h) {
		GlApi.ViewportIndexedf(index, x, y, w, h);
	}

	public static void ViewportIndexedfv(uint index, float* v) {
		GlApi.ViewportIndexedfv(index, v);
	}

	public static void WaitSync(GLSync sync, uint flags, nint timeout) {
		GlApi.WaitSync(sync, flags, timeout);
	}
}