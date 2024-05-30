using System.Numerics;
using Raylib_CSharp.Apis;
using Raylib_CSharp.Images;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Rendering.Gl;
using Raylib_CSharp.Rendering.Gl.FrameBuffer;
using Raylib_CSharp.Shaders;

namespace Raylib_CSharp;

public static class RlGl {

    public const int DefaultBatchBufferElements = 8192;
    public const int DefaultBatchBuffers = 1;
    public const int DefaultBatchDrawCalls = 256;
    public const int DefaultBatchMaxTextureUnits  = 4;
    public const int MaxMatrixStackSize = 32;
    public const int MaxShaderLocations = 32;
    public const float CullDistanceNear = 0.01F;
    public const float CullDistanceFar = 1000.0F;

    public const int TextureWrapS = 0x2802;
    public const int TextureWrapT = 0x2803;
    public const int TextureMagFilter = 0x2800;
    public const int TextureMinFilter = 0x2801;

    public const int TextureFilterNearest = 0x2600;
    public const int TextureFilterLinear = 0x2601;
    public const int TextureFilterMipNearest = 0x2700;
    public const int TextureFilterNearestMipLinear = 0x2702;
    public const int TextureFilterLinearMipNearest = 0x2701;
    public const int TextureFilterMipLinear = 0x3000;
    public const int TextureMipmapBiasRatio = 0x4000;

    public const int TextureWrapRepeat = 0x2901;
    public const int TextureWrapClamp = 0x812F;
    public const int TextureWrapMirrorRepeat = 0x8370;
    public const int TextureWrapMirrorClamp = 0x8742;

    public const int ModelView = 0x1700;
    public const int Projection = 0x1701;
    public const int Texture = 0x1702;

    public const int Lines = 0x0001;
    public const int Triangles = 0x0004;
    public const int Quads = 0x0007;

    public const int UnsignedByte = 0x1401;
    public const int Float = 0x1406;

    public const int StreamDraw = 0x88E0;
    public const int StreamRead = 0x88E1;
    public const int StreamCopy = 0x88E2;
    public const int StaticDraw = 0x88E4;
    public const int StaticRead = 0x88E5;
    public const int StaticCopy = 0x88E6;
    public const int DynamicDraw = 0x88E8;
    public const int DynamicRead = 0x88E9;
    public const int DynamicCopy = 0x88EA;

    public const int FragmentShader = 0x8B30;
    public const int VertexShader = 0x8B31;
    public const int ComputeShader = 0x91B9;

    public const int Zero = 0;
    public const int One = 1;
    public const int SrcColor = 0x0300;
    public const int OneMinusSrcColor = 0x0301;
    public const int SrcAlpha = 0x0302;
    public const int OneMinusSrcAlpha = 0x0303;
    public const int DstAlpha = 0x0304;
    public const int OneMinusDstAlpha = 0x0305;
    public const int DstColor = 0x0306;
    public const int OneMinusDstColor = 0x0307;
    public const int SrcAlphaSaturate = 0x0308;
    public const int ConstantColor = 0x8001;
    public const int OneMinusConstantColor = 0x8002;
    public const int ConstantAlpha = 0x8003;
    public const int OneMinusConstantAlpha = 0x8004;

    public const int FuncAdd = 0x8006;
    public const int Min = 0x8007;
    public const int Max = 0x8008;
    public const int FuncSubtract = 0x800A;
    public const int FuncReverseSubtract = 0x800B;
    public const int BlendEquation = 0x8009;
    public const int BlendEquationRgb = 0x8009;
    public const int BlendEquationAlpha = 0x883D;
    public const int BlendDstRgb = 0x80C8;
    public const int BlendSrcRgb = 0x80C9;
    public const int BlendDstAlpha = 0x80CA;
    public const int BlendSrcAlpha = 0x80CB;
    public const int BlendColor = 0x8005;

    /// <inheritdoc cref="Rendering.Gl.MatrixMode" />
    public static void MatrixMode(MatrixMode mode) {
        RlGlApi.MatrixMode(mode);
    }

    /// <inheritdoc cref="RlGlApi.PushMatrix" />
    public static void PushMatrix() {
        RlGlApi.PushMatrix();
    }

    /// <inheritdoc cref="RlGlApi.PopMatrix" />
    public static void PopMatrix() {
        RlGlApi.PopMatrix();
    }

    /// <inheritdoc cref="RlGlApi.LoadIdentity" />
    public static void LoadIdentity() {
        RlGlApi.LoadIdentity();
    }

    /// <inheritdoc cref="RlGlApi.TranslateF" />
    public static void TranslateF(float x, float y, float z) {
        RlGlApi.TranslateF(x, y, z);
    }

    /// <inheritdoc cref="RlGlApi.RotateF" />
    public static void RotateF(float angle, float x, float y, float z) {
        RlGlApi.RotateF(angle, x, y, z);
    }

    /// <inheritdoc cref="RlGlApi.ScaleF" />
    public static void ScaleF(float x, float y, float z) {
        RlGlApi.ScaleF(x, y, z);
    }

    /// <inheritdoc cref="RlGlApi.MultMatrixF" />
    public static void MultMatrixF(Matrix4x4 matrix) {
        RlGlApi.MultMatrixF(matrix);
    }

    /// <inheritdoc cref="RlGlApi.Frustum" />
    public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar) {
        RlGlApi.Frustum(left, right, bottom, top, zNear, zFar);
    }

    /// <inheritdoc cref="RlGlApi.Ortho" />
    public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar) {
        RlGlApi.Ortho(left, right, bottom, top, zNear, zFar);
    }

    /// <inheritdoc cref="RlGlApi.Viewport" />
    public static void Viewport(int x, int y, int width, int height) {
        RlGlApi.Viewport(x, y, width, height);
    }

    /// <inheritdoc cref="RlGlApi.Begin" />
    public static void Begin(DrawMode mode) {
        RlGlApi.Begin(mode);
    }

    /// <inheritdoc cref="RlGlApi.End" />
    public static void End() {
        RlGlApi.End();
    }

    /// <inheritdoc cref="RlGlApi.Vertex2I" />
    public static void Vertex2I(int x, int y) {
        RlGlApi.Vertex2I(x, y);
    }

    /// <inheritdoc cref="RlGlApi.Vertex2F" />
    public static void Vertex2F(float x, float y) {
        RlGlApi.Vertex2F(x, y);
    }

    /// <inheritdoc cref="RlGlApi.Vertex3F" />
    public static void Vertex3F(float x, float y, float z) {
        RlGlApi.Vertex3F(x, y, z);
    }

    /// <inheritdoc cref="RlGlApi.TexCoord2F" />
    public static void TexCoord2F(float x, float y) {
        RlGlApi.TexCoord2F(x, y);
    }

    /// <inheritdoc cref="RlGlApi.Normal3F" />
    public static void Normal3F(float x, float y, float z) {
        RlGlApi.Normal3F(x, y, z);
    }

    /// <inheritdoc cref="RlGlApi.Color4ub" />
    public static void Color4ub(byte r, byte g, byte b, byte a) {
        RlGlApi.Color4ub(r, g, b, a);
    }

    /// <inheritdoc cref="RlGlApi.Color3F" />
    public static void Color3F(float x, float y, float z) {
        RlGlApi.Color3F(x, y, z);
    }

    /// <inheritdoc cref="RlGlApi.Color4F" />
    public static void Color4F(float x, float y, float z, float w) {
        RlGlApi.Color4F(x, y, z, w);
    }

    /// <inheritdoc cref="RlGlApi.EnableVertexArray" />
    public static bool EnableVertexArray(uint vaoId) {
        return RlGlApi.EnableVertexArray(vaoId);
    }

    /// <inheritdoc cref="RlGlApi.DisableVertexArray" />
    public static void DisableVertexArray() {
        RlGlApi.DisableVertexArray();
    }

    /// <inheritdoc cref="RlGlApi.EnableVertexBuffer" />
    public static void EnableVertexBuffer(uint id) {
        RlGlApi.EnableVertexBuffer(id);
    }

    /// <inheritdoc cref="RlGlApi.DisableVertexBuffer" />
    public static void DisableVertexBuffer() {
        RlGlApi.DisableVertexBuffer();
    }

    /// <inheritdoc cref="RlGlApi.EnableVertexBufferElement" />
    public static void EnableVertexBufferElement(uint id) {
        RlGlApi.EnableVertexBufferElement(id);
    }

    /// <inheritdoc cref="RlGlApi.DisableVertexBufferElement" />
    public static void DisableVertexBufferElement() {
        RlGlApi.DisableVertexBufferElement();
    }

    /// <inheritdoc cref="RlGlApi.EnableVertexAttribute" />
    public static void EnableVertexAttribute(uint index) {
        RlGlApi.EnableVertexAttribute(index);
    }

    /// <inheritdoc cref="RlGlApi.DisableVertexAttribute" />
    public static void DisableVertexAttribute(uint index) {
        RlGlApi.DisableVertexAttribute(index);
    }

    /// <inheritdoc cref="RlGlApi.EnableStatePointer" />
    public static void EnableStatePointer(int vertexAttribType, nint buffer) {
        RlGlApi.EnableStatePointer(vertexAttribType, buffer);
    }

    /// <inheritdoc cref="RlGlApi.DisableStatePointer" />
    public static void DisableStatePointer(int vertexAttribType) {
        RlGlApi.DisableStatePointer(vertexAttribType);
    }

    /// <inheritdoc cref="RlGlApi.ActiveTextureSlot" />
    public static void ActiveTextureSlot(int slot) {
        RlGlApi.ActiveTextureSlot(slot);
    }

    /// <inheritdoc cref="RlGlApi.EnableTexture" />
    public static void EnableTexture(uint id) {
        RlGlApi.EnableTexture(id);
    }

    /// <inheritdoc cref="RlGlApi.DisableTexture" />
    public static void DisableTexture() {
        RlGlApi.DisableTexture();
    }

    /// <inheritdoc cref="RlGlApi.EnableTextureCubemap" />
    public static void EnableTextureCubemap(uint id) {
        RlGlApi.EnableTextureCubemap(id);
    }

    /// <inheritdoc cref="RlGlApi.DisableTextureCubemap" />
    public static void DisableTextureCubemap() {
        RlGlApi.DisableTextureCubemap();
    }

    /// <inheritdoc cref="RlGlApi.TextureParameters" />
    public static void TextureParameters(uint id, int param, int value) {
        RlGlApi.TextureParameters(id, param, value);
    }

    /// <inheritdoc cref="RlGlApi.CubemapParameters" />
    public static void CubemapParameters(uint id, int param, int value) {
        RlGlApi.CubemapParameters(id, param, value);
    }

    /// <inheritdoc cref="RlGlApi.EnableShader" />
    public static void EnableShader(uint id) {
        RlGlApi.EnableShader(id);
    }

    /// <inheritdoc cref="RlGlApi.DisableShader" />
    public static void DisableShader() {
        RlGlApi.DisableShader();
    }

    /// <inheritdoc cref="RlGlApi.EnableFramebuffer" />
    public static void EnableFramebuffer(uint id) {
        RlGlApi.EnableFramebuffer(id);
    }

    /// <inheritdoc cref="RlGlApi.DisableFramebuffer" />
    public static void DisableFramebuffer() {
        RlGlApi.DisableFramebuffer();
    }

    /// <inheritdoc cref="RlGlApi.ActiveDrawBuffers" />
    public static void ActiveDrawBuffers(int count) {
        RlGlApi.ActiveDrawBuffers(count);
    }

    /// <inheritdoc cref="RlGlApi.BlitFramebuffer" />
    public static void BlitFramebuffer(int srcX, int srcY, int srcWidth, int srcHeight, int dstX, int dstY, int dstWidth, int dstHeight, int bufferMask) {
        RlGlApi.BlitFramebuffer(srcX, srcY, srcWidth, srcHeight, dstX, dstY, dstWidth, dstHeight, bufferMask);
    }

    /// <inheritdoc cref="RlGlApi.EnableColorBlend" />
    public static void EnableColorBlend() {
        RlGlApi.EnableColorBlend();
    }

    /// <inheritdoc cref="RlGlApi.DisableColorBlend" />
    public static void DisableColorBlend() {
        RlGlApi.DisableColorBlend();
    }

    /// <inheritdoc cref="RlGlApi.EnableDepthTest" />
    public static void EnableDepthTest() {
        RlGlApi.EnableDepthTest();
    }

    /// <inheritdoc cref="RlGlApi.DisableDepthTest" />
    public static void DisableDepthTest() {
        RlGlApi.DisableDepthTest();
    }

    /// <inheritdoc cref="RlGlApi.EnableDepthMask" />
    public static void EnableDepthMask() {
        RlGlApi.EnableDepthMask();
    }

    /// <inheritdoc cref="RlGlApi.DisableDepthMask" />
    public static void DisableDepthMask() {
        RlGlApi.DisableDepthMask();
    }

    /// <inheritdoc cref="RlGlApi.EnableBackfaceCulling" />
    public static void EnableBackfaceCulling() {
        RlGlApi.EnableBackfaceCulling();
    }

    /// <inheritdoc cref="RlGlApi.DisableBackfaceCulling" />
    public static void DisableBackfaceCulling() {
        RlGlApi.DisableBackfaceCulling();
    }

    /// <inheritdoc cref="RlGlApi.SetCullFace" />
    public static void SetCullFace(CullMode mode) {
        RlGlApi.SetCullFace(mode);
    }

    /// <inheritdoc cref="RlGlApi.EnableScissorTest" />
    public static void EnableScissorTest() {
        RlGlApi.EnableScissorTest();
    }

    /// <inheritdoc cref="RlGlApi.DisableScissorTest" />
    public static void DisableScissorTest() {
        RlGlApi.DisableScissorTest();
    }

    /// <inheritdoc cref="RlGlApi.Scissor" />
    public static void Scissor(int x, int y, int width, int height) {
        RlGlApi.Scissor(x, y, width, height);
    }

    /// <inheritdoc cref="RlGlApi.EnableWireMode" />
    public static void EnableWireMode() {
        RlGlApi.EnableWireMode();
    }

    /// <inheritdoc cref="RlGlApi.EnablePointMode" />
    public static void EnablePointMode() {
        RlGlApi.EnablePointMode();
    }

    /// <inheritdoc cref="RlGlApi.DisableWireMode" />
    public static void DisableWireMode() {
        RlGlApi.DisableWireMode();
    }

    /// <inheritdoc cref="RlGlApi.SetLineWidth" />
    public static void SetLineWidth(float width) {
        RlGlApi.SetLineWidth(width);
    }

    /// <inheritdoc cref="RlGlApi.GetLineWidth" />
    public static float GetLineWidth() {
        return RlGlApi.GetLineWidth();
    }

    /// <inheritdoc cref="RlGlApi.EnableSmoothLines" />
    public static void EnableSmoothLines() {
        RlGlApi.EnableSmoothLines();
    }

    /// <inheritdoc cref="RlGlApi.DisableSmoothLines" />
    public static void DisableSmoothLines() {
        RlGlApi.DisableSmoothLines();
    }

    /// <inheritdoc cref="RlGlApi.EnableStereoRender" />
    public static void EnableStereoRender() {
        RlGlApi.EnableStereoRender();
    }

    /// <inheritdoc cref="RlGlApi.DisableStereoRender" />
    public static void DisableStereoRender() {
        RlGlApi.DisableStereoRender();
    }

    /// <inheritdoc cref="RlGlApi.IsStereoRenderEnabled" />
    public static bool IsStereoRenderEnabled() {
        return RlGlApi.IsStereoRenderEnabled();
    }

    /// <inheritdoc cref="RlGlApi.ClearColor" />
    public static void ClearColor(byte r, byte g, byte b, byte a) {
        RlGlApi.ClearColor(r, g, b, a);
    }

    /// <inheritdoc cref="RlGlApi.ClearScreenBuffers" />
    public static void ClearScreenBuffers() {
        RlGlApi.ClearScreenBuffers();
    }

    /// <inheritdoc cref="RlGlApi.CheckErrors" />
    public static void CheckErrors() {
        RlGlApi.CheckErrors();
    }

    /// <inheritdoc cref="RlGlApi.SetBlendMode" />
    public static void SetBlendMode(BlendMode mode) {
        RlGlApi.SetBlendMode(mode);
    }

    /// <inheritdoc cref="RlGlApi.SetBlendFactors" />
    public static void SetBlendFactors(int glSrcFactor, int glDstFactor, int glEquation) {
        RlGlApi.SetBlendFactors(glSrcFactor, glDstFactor, glEquation);
    }

    /// <inheritdoc cref="RlGlApi.SetBlendFactorsSeparate" />
    public static void SetBlendFactorsSeparate(int glSrcRGB, int glDstRGB, int glSrcAlpha, int glDstAlpha, int glEqRGB, int glEqAlpha) {
        RlGlApi.SetBlendFactorsSeparate(glSrcRGB, glDstRGB, glSrcAlpha, glDstAlpha, glEqRGB, glEqAlpha);
    }

    /// <inheritdoc cref="RlGlApi.GlInit" />
    public static void GlInit(int width, int height) {
        RlGlApi.GlInit(width, height);
    }

    /// <inheritdoc cref="RlGlApi.GlClose" />
    public static void GlClose() {
        RlGlApi.GlClose();
    }

    /// <inheritdoc cref="RlGlApi.LoadExtensions" />
    public static void LoadExtensions(nint loader) {
        RlGlApi.LoadExtensions(loader);
    }

    /// <inheritdoc cref="RlGlApi.GetVersion" />
    public static GlVersion GetVersion() {
        return RlGlApi.GetVersion();
    }

    /// <inheritdoc cref="RlGlApi.SetFramebufferWidth" />
    public static void SetFramebufferWidth(int width) {
        RlGlApi.SetFramebufferWidth(width);
    }

    /// <inheritdoc cref="RlGlApi.GetFramebufferWidth" />
    public static int GetFramebufferWidth() {
        return RlGlApi.GetFramebufferWidth();
    }

    /// <inheritdoc cref="RlGlApi.SetFramebufferHeight" />
    public static void SetFramebufferHeight(int height) {
        RlGlApi.SetFramebufferHeight(height);
    }

    /// <inheritdoc cref="RlGlApi.GetFramebufferHeight" />
    public static int GetFramebufferHeight() {
        return RlGlApi.GetFramebufferHeight();
    }

    /// <inheritdoc cref="RlGlApi.GetTextureIdDefault" />
    public static uint GetTextureIdDefault() {
        return RlGlApi.GetTextureIdDefault();
    }

    /// <inheritdoc cref="RlGlApi.GetShaderIdDefault" />
    public static uint GetShaderIdDefault() {
        return RlGlApi.GetShaderIdDefault();
    }

    /// <inheritdoc cref="RlGlApi.GetShaderLocsDefault" />
    public static unsafe ReadOnlySpan<int> GetShaderLocsDefault() {
        return new ReadOnlySpan<int>(RlGlApi.GetShaderLocsDefault(), MaxShaderLocations);
    }

    /// <inheritdoc cref="RlGlApi.LoadRenderBatch" />
    public static RenderBatch LoadRenderBatch(int numBuffers, int bufferElements) {
        return RlGlApi.LoadRenderBatch(numBuffers, bufferElements);
    }

    /// <inheritdoc cref="RlGlApi.UnloadRenderBatch" />
    public static void UnloadRenderBatch(RenderBatch batch) {
        RlGlApi.UnloadRenderBatch(batch);
    }

    /// <inheritdoc cref="RlGlApi.DrawRenderBatch" />
    public static void DrawRenderBatch(ref RenderBatch batch) {
        RlGlApi.DrawRenderBatch(ref batch);
    }

    /// <inheritdoc cref="RlGlApi.SetRenderBatchActive" />
    public static void SetRenderBatchActive(ref RenderBatch batch) {
        RlGlApi.SetRenderBatchActive(ref batch);
    }

    /// <inheritdoc cref="RlGlApi.DrawRenderBatchActive" />
    public static void DrawRenderBatchActive() {
        RlGlApi.DrawRenderBatchActive();
    }

    /// <inheritdoc cref="RlGlApi.CheckRenderBatchLimit" />
    public static bool CheckRenderBatchLimit(int vCount) {
        return RlGlApi.CheckRenderBatchLimit(vCount);
    }

    /// <inheritdoc cref="RlGlApi.SetTexture" />
    public static void SetTexture(uint id) {
        RlGlApi.SetTexture(id);
    }

    /// <inheritdoc cref="RlGlApi.LoadVertexArray" />
    public static uint LoadVertexArray() {
        return RlGlApi.LoadVertexArray();
    }

    /// <inheritdoc cref="RlGlApi.LoadVertexBuffer" />
    public static uint LoadVertexBuffer(nint buffer, int size, bool dynamic) {
        return RlGlApi.LoadVertexBuffer(buffer, size, dynamic);
    }

    /// <inheritdoc cref="RlGlApi.LoadVertexBufferElement" />
    public static uint LoadVertexBufferElement(nint buffer, int size, bool dynamic) {
        return RlGlApi.LoadVertexBufferElement(buffer, size, dynamic);
    }

    /// <inheritdoc cref="RlGlApi.UpdateVertexBuffer" />
    public static void UpdateVertexBuffer(uint bufferId, nint data, int dataSize, int offset) {
        RlGlApi.UpdateVertexBuffer(bufferId, data, dataSize, offset);
    }

    /// <inheritdoc cref="RlGlApi.UpdateVertexBufferElements" />
    public static void UpdateVertexBufferElements(uint id, nint data, int dataSize, int offset) {
        RlGlApi.UpdateVertexBufferElements(id, data, dataSize, offset);
    }

    /// <inheritdoc cref="RlGlApi.UnloadVertexArray" />
    public static void UnloadVertexArray(uint vaoId) {
        RlGlApi.UnloadVertexArray(vaoId);
    }

    /// <inheritdoc cref="RlGlApi.UnloadVertexBuffer" />
    public static void UnloadVertexBuffer(uint vaoId) {
        RlGlApi.UnloadVertexBuffer(vaoId);
    }

    /// <inheritdoc cref="RlGlApi.SetVertexAttribute" />
    public static void SetVertexAttribute(uint index, int compSize, int type, bool normalized, int stride, nint pointer) {
        RlGlApi.SetVertexAttribute(index, compSize, type, normalized, stride, pointer);
    }

    /// <inheritdoc cref="RlGlApi.SetVertexAttributeDivisor" />
    public static void SetVertexAttributeDivisor(uint index, int divisor) {
        RlGlApi.SetVertexAttributeDivisor(index, divisor);
    }

    /// <inheritdoc cref="RlGlApi.SetVertexAttributeDefault" />
    public static void SetVertexAttributeDefault(int locIndex, nint value, ShaderAttributeDataType attribType, int count) {
        RlGlApi.SetVertexAttributeDefault(locIndex, value, attribType, count);
    }

    /// <inheritdoc cref="RlGlApi.DrawVertexArray" />
    public static void DrawVertexArray(int offset, int count) {
        RlGlApi.DrawVertexArray(offset, count);
    }

    /// <inheritdoc cref="RlGlApi.DrawVertexArrayElements" />
    public static void DrawVertexArrayElements(int offset, int count, nint buffer) {
        RlGlApi.DrawVertexArrayElements(offset, count, buffer);
    }

    /// <inheritdoc cref="RlGlApi.DrawVertexArrayInstanced" />
    public static void DrawVertexArrayInstanced(int offset, int count, int instances) {
        RlGlApi.DrawVertexArrayInstanced(offset, count, instances);
    }

    /// <inheritdoc cref="RlGlApi.DrawVertexArrayElementsInstanced" />
    public static void DrawVertexArrayElementsInstanced(int offset, int count, nint buffer, int instances) {
        RlGlApi.DrawVertexArrayElementsInstanced(offset, count, buffer, instances);
    }

    /// <inheritdoc cref="RlGlApi.LoadTexture" />
    public static uint LoadTexture(nint data, int width, int height, PixelFormat format, int mipmapCount) {
        return RlGlApi.LoadTexture(data, width, height, format, mipmapCount);
    }

    /// <inheritdoc cref="RlGlApi.LoadTextureDepth" />
    public static uint LoadTextureDepth(int width, int height, bool useRenderBuffer) {
        return RlGlApi.LoadTextureDepth(width, height, useRenderBuffer);
    }

    /// <inheritdoc cref="RlGlApi.LoadTextureCubemap" />
    public static uint LoadTextureCubemap(nint data, int size, PixelFormat format) {
        return RlGlApi.LoadTextureCubemap(data, size, format);
    }

    /// <inheritdoc cref="RlGlApi.UpdateTexture" />
    public static void UpdateTexture(uint id, int offsetX, int offsetY, int width, int height, PixelFormat format, nint data) {
        RlGlApi.UpdateTexture(id, offsetX, offsetY, width, height, format, data);
    }

    /// <inheritdoc cref="RlGlApi.GetGlTextureFormats" />
    public static void GetGlTextureFormats(PixelFormat format, out uint glInternalFormat, out uint glFormat, out uint glType) {
        RlGlApi.GetGlTextureFormats(format, out glInternalFormat, out glFormat, out glType);
    }

    /// <inheritdoc cref="RlGlApi.GetPixelFormatName" />
    public static string GetPixelFormatName(PixelFormat format) {
        return RlGlApi.GetPixelFormatName(format);
    }

    /// <inheritdoc cref="RlGlApi.UnloadTexture" />
    public static void UnloadTexture(uint id) {
        RlGlApi.UnloadTexture(id);
    }

    /// <inheritdoc cref="RlGlApi.GenTextureMipmaps" />
    public static unsafe void GenTextureMipmaps(uint id, int width, int height, PixelFormat format, out ReadOnlySpan<int> mipmaps) {
        int mipmapsPtr;
        RlGlApi.GenTextureMipmaps(id, width, height, format, &mipmapsPtr);

        mipmaps = new ReadOnlySpan<int>(&mipmapsPtr, 1 + (int) Math.Floor(Math.Log(Math.Max(width, height)) / Math.Log(2)));
    }

    /// <inheritdoc cref="RlGlApi.ReadTexturePixels" />
    public static nint ReadTexturePixels(uint id, int width, int height, PixelFormat format) {
        return RlGlApi.ReadTexturePixels(id, width, height, format);
    }

    /// <inheritdoc cref="RlGlApi.ReadScreenPixels" />
    public static string ReadScreenPixels(int width, int height) {
        return RlGlApi.ReadScreenPixels(width, height);
    }

    /// <inheritdoc cref="RlGlApi.LoadFramebuffer" />
    public static uint LoadFramebuffer(int width, int height) {
        return RlGlApi.LoadFramebuffer(width, height);
    }

    /// <inheritdoc cref="RlGlApi.FramebufferAttach" />
    public static void FramebufferAttach(uint fboId, uint texId, FramebufferAttachType attachType, FramebufferAttachTextureType texType, int mipLevel) {
        RlGlApi.FramebufferAttach(fboId, texId, attachType, texType, mipLevel);
    }

    /// <inheritdoc cref="RlGlApi.FramebufferComplete" />
    public static bool FramebufferComplete(uint id) {
        return RlGlApi.FramebufferComplete(id);
    }

    /// <inheritdoc cref="RlGlApi.UnloadFramebuffer" />
    public static void UnloadFramebuffer(uint id) {
        RlGlApi.UnloadFramebuffer(id);
    }

    /// <inheritdoc cref="RlGlApi.LoadShaderCode" />
    public static uint LoadShaderCode(string vsCode, string fsCode) {
        return RlGlApi.LoadShaderCode(vsCode, fsCode);
    }

    /// <inheritdoc cref="RlGlApi.CompileShader" />
    public static uint CompileShader(string shaderCode, int type) {
        return RlGlApi.CompileShader(shaderCode, type);
    }

    /// <inheritdoc cref="RlGlApi.LoadShaderProgram" />
    public static uint LoadShaderProgram(uint vShaderId, uint fShaderId) {
        return RlGlApi.LoadShaderProgram(vShaderId, fShaderId);
    }

    /// <inheritdoc cref="RlGlApi.UnloadShaderProgram" />
    public static void UnloadShaderProgram(uint id) {
        RlGlApi.UnloadShaderProgram(id);
    }

    /// <inheritdoc cref="RlGlApi.GetLocationUniform" />
    public static int GetLocationUniform(uint shaderId, string uniformName) {
        return RlGlApi.GetLocationUniform(shaderId, uniformName);
    }

    /// <inheritdoc cref="RlGlApi.GetLocationAttrib" />
    public static int GetLocationAttrib(uint shaderId, string attribName) {
        return RlGlApi.GetLocationAttrib(shaderId, attribName);
    }

    /// <inheritdoc cref="RlGlApi.SetUniform" />
    public static void SetUniform(int locIndex, nint value, ShaderUniformDataType uniformType, int count) {
        RlGlApi.SetUniform(locIndex, value, uniformType, count);
    }

    /// <inheritdoc cref="RlGlApi.SetUniformMatrix" />
    public static void SetUniformMatrix(int locIndex, Matrix4x4 mat) {
        RlGlApi.SetUniformMatrix(locIndex, mat);
    }

    /// <inheritdoc cref="RlGlApi.SetUniformSampler" />
    public static void SetUniformSampler(int locIndex, uint textureId) {
        RlGlApi.SetUniformSampler(locIndex, textureId);
    }

    /// <inheritdoc cref="RlGlApi.SetShader" />
    public static unsafe void SetShader(uint id, Span<int> locs) {
        fixed (int* locsPtr = locs) {
            RlGlApi.SetShader(id, locsPtr);
        }
    }

    /// <inheritdoc cref="RlGlApi.LoadComputeShaderProgram" />
    public static uint LoadComputeShaderProgram(uint shaderId) {
        return RlGlApi.LoadComputeShaderProgram(shaderId);
    }

    /// <inheritdoc cref="RlGlApi.ComputeShaderDispatch" />
    public static void ComputeShaderDispatch(uint groupX, uint groupY, uint groupZ) {
        RlGlApi.ComputeShaderDispatch(groupX, groupY, groupZ);
    }

    /// <inheritdoc cref="RlGlApi.LoadShaderBuffer" />
    public static uint LoadShaderBuffer(uint size, nint data, int usageHint) {
        return RlGlApi.LoadShaderBuffer(size, data, usageHint);
    }

    /// <inheritdoc cref="RlGlApi.UnloadShaderBuffer" />
    public static void UnloadShaderBuffer(uint ssboId) {
        RlGlApi.UnloadShaderBuffer(ssboId);
    }

    /// <inheritdoc cref="RlGlApi.UpdateShaderBuffer" />
    public static void UpdateShaderBuffer(uint id, nint data, uint dataSize, uint offset) {
        RlGlApi.UpdateShaderBuffer(id, data, dataSize, offset);
    }

    /// <inheritdoc cref="RlGlApi.BindShaderBuffer" />
    public static void BindShaderBuffer(uint id, uint index) {
        RlGlApi.BindShaderBuffer(id, index);
    }

    /// <inheritdoc cref="RlGlApi.ReadShaderBuffer" />
    public static void ReadShaderBuffer(uint id, nint dest, uint count, uint offset) {
        RlGlApi.ReadShaderBuffer(id, dest, count, offset);
    }

    /// <inheritdoc cref="RlGlApi.CopyShaderBuffer" />
    public static void CopyShaderBuffer(uint destId, uint srcId, uint destOffset, uint srcOffset, uint count) {
        RlGlApi.CopyShaderBuffer(destId, srcId, destOffset, srcOffset, count);
    }

    /// <inheritdoc cref="RlGlApi.GetShaderBufferSize" />
    public static uint GetShaderBufferSize(uint id) {
        return RlGlApi.GetShaderBufferSize(id);
    }

    /// <inheritdoc cref="RlGlApi.BindImageTexture" />
    public static void BindImageTexture(uint id, uint index, PixelFormat format, bool readOnly) {
        RlGlApi.BindImageTexture(id, index, format, readOnly);
    }

    /// <inheritdoc cref="RlGlApi.GetMatrixModelView" />
    public static Matrix4x4 GetMatrixModelView() {
        return RlGlApi.GetMatrixModelView();
    }

    /// <inheritdoc cref="RlGlApi.GetMatrixProjection" />
    public static Matrix4x4 GetMatrixProjection() {
        return RlGlApi.GetMatrixProjection();
    }

    /// <inheritdoc cref="RlGlApi.GetMatrixTransform" />
    public static Matrix4x4 GetMatrixTransform() {
        return RlGlApi.GetMatrixTransform();
    }

    /// <inheritdoc cref="RlGlApi.GetMatrixProjectionStereo" />
    public static Matrix4x4 GetMatrixProjectionStereo(int eye) {
        return RlGlApi.GetMatrixProjectionStereo(eye);
    }

    /// <inheritdoc cref="RlGlApi.GetMatrixViewOffsetStereo" />
    public static Matrix4x4 GetMatrixViewOffsetStereo(int eye) {
        return RlGlApi.GetMatrixViewOffsetStereo(eye);
    }

    /// <inheritdoc cref="RlGlApi.SetMatrixProjection" />
    public static void SetMatrixProjection(Matrix4x4 proj) {
        RlGlApi.SetMatrixProjection(proj);
    }

    /// <inheritdoc cref="RlGlApi.SetMatrixModelView" />
    public static void SetMatrixModelView(Matrix4x4 view) {
        RlGlApi.SetMatrixModelView(view);
    }

    /// <inheritdoc cref="RlGlApi.SetMatrixProjectionStereo" />
    public static void SetMatrixProjectionStereo(Matrix4x4 right, Matrix4x4 left) {
        RlGlApi.SetMatrixProjectionStereo(right, left);
    }

    /// <inheritdoc cref="RlGlApi.SetMatrixViewOffsetStereo" />
    public static void SetMatrixViewOffsetStereo(Matrix4x4 right, Matrix4x4 left) {
        RlGlApi.SetMatrixViewOffsetStereo(right, left);
    }

    /// <inheritdoc cref="RlGlApi.LoadDrawCube" />
    public static void LoadDrawCube() {
        RlGlApi.LoadDrawCube();
    }

    /// <inheritdoc cref="RlGlApi.LoadDrawQuad" />
    public static void LoadDrawQuad() {
        RlGlApi.LoadDrawQuad();
    }
}