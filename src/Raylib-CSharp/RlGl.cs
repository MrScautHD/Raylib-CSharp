using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.Images;
using Raylib_CSharp.Marshallers;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Rendering.Gl;
using Raylib_CSharp.Rendering.Gl.FrameBuffer;
using Raylib_CSharp.Shaders;

namespace Raylib_CSharp;

public static partial class RlGl {

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

    /// <summary>
    /// Choose the current matrix to be transformed.
    /// </summary>
    /// <param name="mode">The matrix mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlMatrixMode")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void MatrixMode(MatrixMode mode);

    /// <summary>
    /// Push the current matrix to stack.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlPushMatrix")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PushMatrix();

    /// <summary>
    /// Pop latest inserted matrix from stack.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlPopMatrix")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PopMatrix();

    /// <summary>
    /// Reset current matrix to identity matrix.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadIdentity")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void LoadIdentity();

    /// <summary>
    /// Multiply the current matrix by a translation matrix.
    /// </summary>
    /// <param name="x">The amount to translate in the x direction.</param>
    /// <param name="y">The amount to translate in the y direction.</param>
    /// <param name="z">The amount to translate in the z direction.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlTranslatef")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TranslateF(float x, float y, float z);

    /// <summary>
    /// Multiply the current matrix by a rotation matrix.
    /// </summary>
    /// <param name="angle">The angle of rotation in degrees.</param>
    /// <param name="x">The x-component of the axis of rotation.</param>
    /// <param name="y">The y-component of the axis of rotation.</param>
    /// <param name="z">The z-component of the axis of rotation.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlRotatef")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void RotateF(float angle, float x, float y, float z);

    /// <summary>
    /// Multiply the current matrix by a scaling matrix.
    /// </summary>
    /// <param name="x">The scale factor along the x-axis.</param>
    /// <param name="y">The scale factor along the y-axis.</param>
    /// <param name="z">The scale factor along the z-axis.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlScalef")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ScaleF(float x, float y, float z);

    /// <summary>
    /// Multiply the current matrix by another matrix.
    /// </summary>
    /// <param name="matrix">The 4x4 matrix to multiply by.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlMultMatrixf")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void MultMatrixF(Matrix4x4 matrix);

    /// <summary>
    /// Multiply the current matrix by a perspective matrix generated by parameters.
    /// </summary>
    /// <param name="left">Left value of the frustum.</param>
    /// <param name="right">Right value of the frustum.</param>
    /// <param name="bottom">Bottom value of the frustum.</param>
    /// <param name="top">Top value of the frustum.</param>
    /// <param name="zNear">Near value of the frustum.</param>
    /// <param name="zFar">Far value of the frustum.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlFrustum")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);

    /// <summary>
    /// Multiply the current matrix by an orthographic matrix generated by parameters.
    /// </summary>
    /// <param name="left">The coordinate for the left vertical clipping plane</param>
    /// <param name="right">The coordinate for the right vertical clipping plane</param>
    /// <param name="bottom">The coordinate for the bottom horizontal clipping plane</param>
    /// <param name="top">The coordinate for the top horizontal clipping plane</param>
    /// <param name="zNear">The distance to the near clipping plane</param>
    /// <param name="zFar">The distance to the far clipping plane</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlOrtho")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);

    /// <summary>
    /// Set the viewport area.
    /// </summary>
    /// <param name="x">The x-coordinate of the top-left corner of the viewport.</param>
    /// <param name="y">The y-coordinate of the top-left corner of the viewport.</param>
    /// <param name="width">The width of the viewport.</param>
    /// <param name="height">The height of the viewport.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlViewport")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Viewport(int x, int y, int width, int height);

    /// <summary>
    /// Initialize drawing mode (how to organize vertex).
    /// </summary>
    /// <param name="mode">The drawing mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlBegin")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Begin(DrawMode mode);

    /// <summary>
    /// Finish vertex providing.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnd")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void End();

    /// <summary>
    /// Define one vertex (position) - 2 int.
    /// </summary>
    /// <param name="x">The x-coordinate of the vertex position.</param>
    /// <param name="y">The y-coordinate of the vertex position.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlVertex2i")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Vertex2I(int x, int y);

    /// <summary>
    /// Define one vertex (position) - 2 float.
    /// </summary>
    /// <param name="x">The x-coordinate of the vertex.</param>
    /// <param name="y">The y-coordinate of the vertex.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlVertex2f")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Vertex2F(float x, float y);

    /// <summary>
    /// Define one vertex (position) - 3 float.
    /// </summary>
    /// <param name="x">The x-coordinate of the vertex.</param>
    /// <param name="y">The y-coordinate of the vertex.</param>
    /// <param name="z">The z-coordinate of the vertex.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlVertex3f")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Vertex3F(float x, float y, float z);

    /// <summary>
    /// Define one vertex (texture coordinate) - 2 float.
    /// </summary>
    /// <param name="x">The x-coordinate of the texture coordinate.</param>
    /// <param name="y">The y-coordinate of the texture coordinate.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlTexCoord2f")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TexCoord2F(float x, float y);

    /// <summary>
    /// Define one vertex (normal) - 3 float.
    /// </summary>
    /// <param name="x">The x-axis component of the normal vector.</param>
    /// <param name="y">The y-axis component of the normal vector.</param>
    /// <param name="z">The z-axis component of the normal vector.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlNormal3f")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Normal3F(float x, float y, float z);

    /// <summary>
    /// Define one vertex (color) - 4 byte.
    /// </summary>
    /// <param name="r">The red component of the color (0-255).</param>
    /// <param name="g">The green component of the color (0-255).</param>
    /// <param name="b">The blue component of the color (0-255).</param>
    /// <param name="a">The alpha component of the color (0-255).</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlColor4ub")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Color4ub(byte r, byte g, byte b, byte a);

    /// <summary>
    /// Define one vertex (color) - 3 float.
    /// </summary>
    /// <param name="x">The red component of the color.</param>
    /// <param name="y">The green component of the color.</param>
    /// <param name="z">The blue component of the color.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlColor3f")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Color3F(float x, float y, float z);

    /// <summary>
    /// Sets the current color in RGBA format (32-bit).
    /// </summary>
    /// <param name="x">The red component of the color, ranging from 0.0f to 1.0f.</param>
    /// <param name="y">The green component of the color, ranging from 0.0f to 1.0f.</param>
    /// <param name="z">The blue component of the color, ranging from 0.0f to 1.0f.</param>
    /// <param name="w">The alpha component of the color, ranging from 0.0f to 1.0f.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlColor4f")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Color4F(float x, float y, float z, float w);

    /// <summary>
    /// Enable vertex array (VAO, if supported).
    /// </summary>
    /// <param name="vaoId">The ID of the vertex array object to enable.</param>
    /// <returns>Returns true if the vertex array object was enabled successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableVertexArray")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EnableVertexArray(uint vaoId);

    /// <summary>
    /// Disable vertex array (VAO, if supported).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableVertexArray")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexArray();

    /// <summary>
    /// Enable vertex buffer (VBO).
    /// </summary>
    /// <param name="id">The ID of the vertex buffer to enable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableVertexBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableVertexBuffer(uint id);

    /// <summary>
    /// Disable vertex buffer (VBO).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableVertexBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexBuffer();

    /// <summary>
    /// Enable vertex buffer element (VBO element).
    /// </summary>
    /// <param name="id">The ID of the vertex buffer element to enable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableVertexBufferElement")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableVertexBufferElement(uint id);

    /// <summary>
    /// Disable vertex buffer element (VBO element).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableVertexBufferElement")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexBufferElement();

    /// <summary>
    /// Enable vertex attribute index.
    /// </summary>
    /// <param name="index">The index of the vertex attribute to enable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableVertexAttribute")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableVertexAttribute(uint index);

    /// <summary>
    /// Disable vertex attribute index.
    /// </summary>
    /// <param name="index">The index of the vertex attribute to disable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableVertexAttribute")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableVertexAttribute(uint index);

    /// <summary>
    /// Enable attribute state pointer.
    /// </summary>
    /// <param name="vertexAttribType">The vertex attribute type.</param>
    /// <param name="buffer">The buffer to enable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableStatePointer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableStatePointer(int vertexAttribType, nint buffer);

    /// <summary>
    /// Disable attribute state pointer.
    /// </summary>
    /// <param name="vertexAttribType">The type of the vertex attribute.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableStatePointer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableStatePointer(int vertexAttribType);

    /// <summary>
    /// Select and active a texture slot.
    /// </summary>
    /// <param name="slot">The slot to activate.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlActiveTextureSlot")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ActiveTextureSlot(int slot);

    /// <summary>
    /// Enable texture.
    /// </summary>
    /// <param name="id">The ID of the texture to enable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableTexture(uint id);

    /// <summary>
    /// Disable texture.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableTexture();

    /// <summary>
    /// Enable texture cubemap.
    /// </summary>
    /// <param name="id">The ID of the cubemap texture to enable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableTextureCubemap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableTextureCubemap(uint id);

    /// <summary>
    /// Disable texture cubemap.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableTextureCubemap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableTextureCubemap();

    /// <summary>
    /// Set texture parameters (filter, wrap).
    /// </summary>
    /// <param name="id">The ID of the texture.</param>
    /// <param name="param">The parameter to set.</param>
    /// <param name="value">The value to set for the parameter.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlTextureParameters")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TextureParameters(uint id, int param, int value);

    /// <summary>
    /// Set cubemap parameters (filter, wrap).
    /// </summary>
    /// <param name="id">The ID of the cubemap texture.</param>
    /// <param name="param">The parameter to set.</param>
    /// <param name="value">The value of the parameter to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlCubemapParameters")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CubemapParameters(uint id, int param, int value);

    /// <summary>
    /// Enable shader program.
    /// </summary>
    /// <param name="id">The ID of the shader program.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableShader")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableShader(uint id);

    /// <summary>
    /// Disable shader program.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableShader")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableShader();

    /// <summary>
    /// Enable render texture (fbo).
    /// </summary>
    /// <param name="id">The ID of the framebuffer to enable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableFramebuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableFramebuffer(uint id);

    /// <summary>
    /// Disable render texture (fbo), return to default framebuffer.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableFramebuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableFramebuffer();

    /// <summary>
    /// Activate multiple draw color buffers.
    /// </summary>
    /// <param name="count">The number of draw buffers to activate.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlActiveDrawBuffers")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ActiveDrawBuffers(int count);

    /// <summary>
    /// Blit active framebuffer to main framebuffer.
    /// </summary>
    /// <param name="srcX">Source rectangle x position.</param>
    /// <param name="srcY">Source rectangle y position.</param>
    /// <param name="srcWidth">Source rectangle width.</param>
    /// <param name="srcHeight">Source rectangle height.</param>
    /// <param name="dstX">Destination rectangle x position.</param>
    /// <param name="dstY">Destination rectangle y position.</param>
    /// <param name="dstWidth">Destination rectangle width.</param>
    /// <param name="dstHeight">Destination rectangle height.</param>
    /// <param name="bufferMask">Bitmask to indicate which attachements to Blit (bitmask), it could be one or multiple values (i.e. RL_ATTACHMENT_COLOR_CHANNEL0 | RL_ATTACHMENT_COLOR_CHANNEL1)</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlBlitFramebuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BlitFramebuffer(int srcX, int srcY, int srcWidth, int srcHeight, int dstX, int dstY, int dstWidth, int dstHeight, int bufferMask);

    /// <summary>
    /// Enable color blending.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableColorBlend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableColorBlend();

    /// <summary>
    /// Disable color blending.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableColorBlend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableColorBlend();

    /// <summary>
    /// Enable depth test.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableDepthTest")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableDepthTest();

    /// <summary>
    /// Disable depth test.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableDepthTest")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableDepthTest();

    /// <summary>
    /// Enable depth write.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableDepthMask")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableDepthMask();

    /// <summary>
    /// Disable depth write.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableDepthMask")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableDepthMask();

    /// <summary>
    /// Enable backface culling.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableBackfaceCulling")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableBackfaceCulling();

    /// <summary>
    /// Disable backface culling.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableBackfaceCulling")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableBackfaceCulling();

    /// <summary>
    /// Set face culling mode.
    /// </summary>
    /// <param name="mode">The cull face mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetCullFace")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetCullFace(CullMode mode);

    /// <summary>
    /// Enable scissor test.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableScissorTest")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableScissorTest();

    /// <summary>
    /// Disable scissor test.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableScissorTest")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableScissorTest();

    /// <summary>
    /// Set the scissor area for following drawing instructions.
    /// </summary>
    /// <param name="x">The x-coordinate of the top-left corner of the scissor area.</param>
    /// <param name="y">The y-coordinate of the top-left corner of the scissor area.</param>
    /// <param name="width">The width of the scissor area.</param>
    /// <param name="height">The height of the scissor area.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlScissor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Scissor(int x, int y, int width, int height);

    /// <summary>
    /// Enable wire mode.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableWireMode")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableWireMode();

    /// <summary>
    /// Enable point mode.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnablePointMode")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnablePointMode();

    /// <summary>
    /// Disable wire mode ( and point ) maybe rename.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableWireMode")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableWireMode();

    /// <summary>
    /// Set the line drawing width.
    /// </summary>
    /// <param name="width">The width of the lines to be drawn.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetLineWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetLineWidth(float width);

    /// <summary>
    /// Get the line drawing width.
    /// </summary>
    /// <returns>The current line width.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetLineWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetLineWidth();

    /// <summary>
    /// Enable line aliasing.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableSmoothLines")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableSmoothLines();

    /// <summary>
    /// Disable line aliasing.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableSmoothLines")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableSmoothLines();

    /// <summary>
    /// Enable stereo rendering.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlEnableStereoRender")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableStereoRender();

    /// <summary>
    /// Disable stereo rendering.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDisableStereoRender")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableStereoRender();

    /// <summary>
    /// Check if stereo render is enabled.
    /// </summary>
    /// <returns>Returns true if stereo rendering is enabled, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlIsStereoRenderEnabled")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsStereoRenderEnabled();

    /// <summary>
    /// Clear color buffer with color.
    /// </summary>
    /// <param name="r">The red component of the color.</param>
    /// <param name="g">The green component of the color.</param>
    /// <param name="b">The blue component of the color.</param>
    /// <param name="a">The alpha component of the color.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlClearColor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearColor(byte r, byte g, byte b, byte a);

    /// <summary>
    /// Clear used screen buffers (color and depth).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlClearScreenBuffers")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearScreenBuffers();

    /// <summary>
    /// Check and log OpenGL error codes.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlCheckErrors")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CheckErrors();

    /// <summary>
    /// Set blending mode.
    /// </summary>
    /// <param name="mode">The blend mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetBlendMode")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBlendMode(BlendMode mode);

    /// <summary>
    /// Set blending mode factor and equation (using OpenGL factors).
    /// </summary>
    /// <param name="glSrcFactor">The source blend factor. This determines how the source color components are combined with the destination color components.</param>
    /// <param name="glDstFactor">The destination blend factor. This determines how the destination color components are combined with the source color components.</param>
    /// <param name="glEquation">The blend equation. This determines how the source and destination colors are combined.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetBlendFactors")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBlendFactors(int glSrcFactor, int glDstFactor, int glEquation);

    /// <summary>
    /// Set blending mode factors and equations separately (using OpenGL factors).
    /// </summary>
    /// <param name="glSrcRGB">Source factor for RGB components</param>
    /// <param name="glDstRGB">Destination factor for RGB components</param>
    /// <param name="glSrcAlpha">Source factor for alpha component</param>
    /// <param name="glDstAlpha">Destination factor for alpha component</param>
    /// <param name="glEqRGB">Blending equation for RGB components</param>
    /// <param name="glEqAlpha">Blending equation for alpha component</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetBlendFactorsSeparate")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBlendFactorsSeparate(int glSrcRGB, int glDstRGB, int glSrcAlpha, int glDstAlpha, int glEqRGB, int glEqAlpha);

    /// <summary>
    /// Initialize rlgl (buffers, shaders, textures, states).
    /// </summary>
    /// <param name="width">The width of the rendering area.</param>
    /// <param name="height">The height of the rendering area.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlglInit")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GlInit(int width, int height);

    /// <summary>
    /// De-initialize rlgl (buffers, shaders, textures).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlglClose")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GlClose();

    /// <summary>
    /// Load OpenGL extensions (loader function required).
    /// </summary>
    /// <param name="loader">Pointer to the loader object.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadExtensions")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void LoadExtensions(nint loader);

    /// <summary>
    /// Get current OpenGL version.
    /// </summary>
    /// <returns>The version number of the Raylib library.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetVersion")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial GlVersion GetVersion();

    /// <summary>
    /// Set current framebuffer width.
    /// </summary>
    /// <param name="width">The width of the framebuffer.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetFramebufferWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetFramebufferWidth(int width);

    /// <summary>
    /// Get default framebuffer width.
    /// </summary>
    /// <returns>The width of the current framebuffer.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetFramebufferWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFramebufferWidth();

    /// <summary>
    /// Set current framebuffer height.
    /// </summary>
    /// <param name="height">The height of the framebuffer.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetFramebufferHeight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetFramebufferHeight(int height);

    /// <summary>
    /// Get default framebuffer height.
    /// </summary>
    /// <returns>The height of the framebuffer.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetFramebufferHeight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFramebufferHeight();

    /// <summary>
    /// Get default texture id.
    /// </summary>
    /// <returns>The default texture ID.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetTextureIdDefault")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint GetTextureIdDefault();

    /// <summary>
    /// Get default shader id.
    /// </summary>
    /// <returns>The default shader ID.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetShaderIdDefault")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint GetShaderIdDefault();

    /// <summary>
    /// Get default shader locations.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetShaderLocsDefault")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int* GetShaderLocsDefault();

    /// <summary>
    /// Get default shader locations.
    /// </summary>
    public static unsafe ReadOnlySpan<int> GetShaderLocsDefaultSpan() {
        return new ReadOnlySpan<int>(GetShaderLocsDefault(), MaxShaderLocations);
    }

    /// <summary>
    /// Load a render batch system.
    /// </summary>
    /// <param name="numBuffers">The number of buffers in the render batch.</param>
    /// <param name="bufferElements">The number of elements in each buffer.</param>
    /// <returns>The loaded render batch.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadRenderBatch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RenderBatch LoadRenderBatch(int numBuffers, int bufferElements);

    /// <summary>
    /// Unload render batch system.
    /// </summary>
    /// <param name="batch">The render batch to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUnloadRenderBatch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadRenderBatch(RenderBatch batch);

    /// <summary>
    /// Draw render batch data (Update->Draw->Reset).
    /// </summary>
    /// <param name="batch">The render batch to draw.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDrawRenderBatch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRenderBatch(ref RenderBatch batch);

    /// <summary>
    /// Set the active render batch for rlgl (NULL for default internal).
    /// </summary>
    /// <param name="batch">The render batch to activate.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetRenderBatchActive")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetRenderBatchActive(ref RenderBatch batch);

    /// <summary>
    /// Update and draw internal render batch.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDrawRenderBatchActive")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRenderBatchActive();

    /// <summary>
    /// Check internal buffer overflow for a given number of vertex.
    /// </summary>
    /// <param name="vCount">The number of vertices to check against the render batch limit.</param>
    /// <returns>True if the render batch limit has been reached, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlCheckRenderBatchLimit")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckRenderBatchLimit(int vCount);

    /// <summary>
    /// Set current texture for render batch and check buffers limits.
    /// </summary>
    /// <param name="id">The ID of the texture to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTexture(uint id);

    /// <summary>
    /// Load vertex array (vao) if supported.
    /// </summary>
    /// <returns>The identifier of the loaded vertex array.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadVertexArray")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadVertexArray();

    /// <summary>
    /// Load a vertex buffer attribute.
    /// </summary>
    /// <param name="buffer">The pointer to the vertex buffer data.</param>
    /// <param name="size">The size of the vertex buffer data.</param>
    /// <param name="dynamic">Determines if the vertex buffer can be modified dynamically.</param>
    /// <returns>The ID of the vertex buffer in GPU memory.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadVertexBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadVertexBuffer(nint buffer, int size, [MarshalAs(UnmanagedType.I1)] bool dynamic);

    /// <summary>
    /// Load a new attributes element buffer.
    /// </summary>
    /// <param name="buffer">Pointer to the destination buffer.</param>
    /// <param name="size">Size of the buffer in bytes.</param>
    /// <param name="dynamic">Determines if the buffer is dynamic or not.</param>
    /// <returns>The ID of the loaded vertex buffer element.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadVertexBufferElement")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadVertexBufferElement(nint buffer, int size, [MarshalAs(UnmanagedType.I1)] bool dynamic);

    /// <summary>
    /// Update GPU buffer with new data.
    /// </summary>
    /// <param name="bufferId">The ID of the buffer to update.</param>
    /// <param name="data">A pointer to the new data to be copied into the buffer.</param>
    /// <param name="dataSize">The size of the new data, in bytes.</param>
    /// <param name="offset">The offset, in bytes, where the new data should be copied into the buffer.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUpdateVertexBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateVertexBuffer(uint bufferId, nint data, int dataSize, int offset);

    /// <summary>
    /// Updates a portion of the vertex buffer with new data.
    /// </summary>
    /// <param name="id">The ID of the vertex buffer to update.</param>
    /// <param name="data">A pointer to the new vertex data.</param>
    /// <param name="dataSize">The size of the new vertex data in bytes.</param>
    /// <param name="offset">The offset within the vertex buffer to update.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUpdateVertexBufferElements")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateVertexBufferElements(uint id, nint data, int dataSize, int offset);

    /// <summary>
    /// Unload vertex array object (VAO).
    /// </summary>
    /// <param name="vaoId">The ID of the VAO to be unloaded.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUnloadVertexArray")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadVertexArray(uint vaoId);

    /// <summary>
    /// Unload vertex buffer (VBO).
    /// </summary>
    /// <param name="vaoId">The ID of the vertex buffer object to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUnloadVertexBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadVertexBuffer(uint vaoId);

    /// <summary>
    /// Set vertex attribute.
    /// </summary>
    /// <param name="index">The index of the attribute.</param>
    /// <param name="compSize">The number of components per attribute.</param>
    /// <param name="type">The data type of the attribute.</param>
    /// <param name="normalized">Specifies whether the attribute data should be normalized.</param>
    /// <param name="stride">The stride between consecutive attributes.</param>
    /// <param name="pointer">A pointer to the attribute data.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetVertexAttribute")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetVertexAttribute(uint index, int compSize, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, int stride, nint pointer);

    /// <summary>
    /// Set vertex attribute divisor.
    /// </summary>
    /// <param name="index">The index of the vertex attribute.</param>
    /// <param name="divisor">The number of instances that will pass between updates of the vertex attribute.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetVertexAttributeDivisor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetVertexAttributeDivisor(uint index, int divisor);

    /// <summary>
    /// Set vertex attribute default value.
    /// </summary>
    /// <param name="locIndex">The location index of the vertex attribute.</param>
    /// <param name="value">A pointer to the value of the vertex attribute.</param>
    /// <param name="attribType">The type of the vertex attribute.</param>
    /// <param name="count">The number of components in the vertex attribute.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetVertexAttributeDefault")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetVertexAttributeDefault(int locIndex, nint value, ShaderAttributeDataType attribType, int count);

    /// <summary>
    /// Draw vertex array.
    /// </summary>
    /// <param name="offset">The starting index of the vertex array to draw.</param>
    /// <param name="count">The number of vertices to draw.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDrawVertexArray")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawVertexArray(int offset, int count);

    /// <summary>
    /// Draw vertex array elements.
    /// </summary>
    /// <param name="offset">The index within the vertex buffer to start drawing.</param>
    /// <param name="count">The number of elements to draw.</param>
    /// <param name="buffer">A pointer to the vertex buffer containing the elements.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDrawVertexArrayElements")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawVertexArrayElements(int offset, int count, nint buffer);

    /// <summary>
    /// Draw vertex array instanced.
    /// </summary>
    /// <param name="offset">Offset (vertex count offset)</param>
    /// <param name="count">Number of elements in the array</param>
    /// <param name="instances">Number of instances</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDrawVertexArrayInstanced")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawVertexArrayInstanced(int offset, int count, int instances);

    /// <summary>
    /// Draw vertex array elements instanced.
    /// </summary>
    /// <param name="offset">Offset in buffer</param>
    /// <param name="count">Number of elements to draw</param>
    /// <param name="buffer">Pointer to vertex buffer data</param>
    /// <param name="instances">Number of instances to draw</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlDrawVertexArrayElementsInstanced")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawVertexArrayElementsInstanced(int offset, int count, nint buffer, int instances);

    /// <summary>
    /// Load texture in GPU.
    /// </summary>
    /// <param name="data">Pointer to the raw data.</param>
    /// <param name="width">The width of the texture.</param>
    /// <param name="height">The height of the texture.</param>
    /// <param name="format">The format of the texture.</param>
    /// <param name="mipmapCount">The number of mipmaps in the texture.</param>
    /// <returns>The ID of the loaded texture.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadTexture(nint data, int width, int height, PixelFormat format, int mipmapCount);

    /// <summary>
    /// Load depth texture/renderbuffer (to be attached to fbo).
    /// </summary>
    /// <param name="width">The width of the texture/renderbuffer</param>
    /// <param name="height">The height of the texture/renderbuffer</param>
    /// <param name="useRenderBuffer">Whether to use a renderbuffer instead of a texture</param>
    /// <returns>The ID of the loaded depth texture/renderbuffer</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadTextureDepth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadTextureDepth(int width, int height, [MarshalAs(UnmanagedType.I1)] bool useRenderBuffer);

    /// <summary>
    /// Load texture cubemap.
    /// </summary>
    /// <param name="data">Pointer to the raw texture data.</param>
    /// <param name="size">The size of the texture data in bytes.</param>
    /// <param name="format">The format of the texture data.</param>
    /// <returns>The handle of the loaded texture.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadTextureCubemap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadTextureCubemap(nint data, int size, PixelFormat format);

    /// <summary>
    /// Update GPU texture with new data.
    /// </summary>
    /// <param name="id">The ID of the texture to update.</param>
    /// <param name="offsetX">The x-coordinate offset within the texture to update.</param>
    /// <param name="offsetY">The y-coordinate offset within the texture to update.</param>
    /// <param name="width">The width of the texture update area.</param>
    /// <param name="height">The height of the texture update area.</param>
    /// <param name="format">The pixel format of the texture data.</param>
    /// <param name="data">A pointer to the new pixel data to update.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUpdateTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateTexture(uint id, int offsetX, int offsetY, int width, int height, PixelFormat format, nint data);

    /// <summary>
    /// Get OpenGL internal formats.
    /// </summary>
    /// <param name="format">The format to retrieve the OpenGL texture formats for.</param>
    /// <param name="glInternalFormat">A pointer to the variable that will receive the OpenGL internal format.</param>
    /// <param name="glFormat">A pointer to the variable that will receive the OpenGL format.</param>
    /// <param name="glType">A pointer to the variable that will receive the OpenGL type.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetGlTextureFormats")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GetGlTextureFormats(PixelFormat format, out uint glInternalFormat, out uint glFormat, out uint glType);

    /// <summary>
    /// Get name string for pixel format.
    /// </summary>
    /// <param name="format">The format value to retrieve the name for.</param>
    /// <returns>The name of the pixel format, as a UTF-8 encoded string.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetPixelFormatName")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetPixelFormatName(PixelFormat format);

    /// <summary>
    /// Unload texture from GPU memory.
    /// </summary>
    /// <param name="id">The ID of the texture to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUnloadTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadTexture(uint id);

    /// <summary>
    /// Generate mipmap data for selected texture.
    /// </summary>
    /// <param name="id">The ID of the texture to generate mipmaps for</param>
    /// <param name="width">The width of the base level of the texture</param>
    /// <param name="height">The height of the base level of the texture</param>
    /// <param name="format">The format of the texture</param>
    /// <param name="mipmaps">Pointer to an array of integers representing the number of mipmaps for each level</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGenTextureMipmaps")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GenTextureMipmaps(uint id, int width, int height, PixelFormat format, int* mipmaps);

    /// <summary>
    /// Generate mipmap data for selected texture.
    /// </summary>
    /// <param name="id">The ID of the texture.</param>
    /// <param name="width">The width of the texture.</param>
    /// <param name="height">The height of the texture.</param>
    /// <param name="format">The pixel format of the texture.</param>
    /// <param name="mipmaps">The output array of mipmaps.</param>
    public static unsafe void GenTextureMipmaps(uint id, int width, int height, PixelFormat format, out ReadOnlySpan<int> mipmaps) {
        int mipmapsPtr;
        GenTextureMipmaps(id, width, height, format, &mipmapsPtr);

        mipmaps = new ReadOnlySpan<int>(&mipmapsPtr, 1 + (int) Math.Floor(Math.Log(Math.Max(width, height)) / Math.Log(2)));
    }

    /// <summary>
    /// Read texture pixel data.
    /// </summary>
    /// <param name="id">The ID of the texture to read from.</param>
    /// <param name="width">The width of the texture in pixels.</param>
    /// <param name="height">The height of the texture in pixels.</param>
    /// <param name="format">The format of the pixels data.</param>
    /// <returns>A pointer to the pixels data of the texture. The returned pointer must be properly handled in order to avoid memory leaks.
    /// </returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlReadTexturePixels")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint ReadTexturePixels(uint id, int width, int height, PixelFormat format);

    /// <summary>
    /// Read screen pixel data (color buffer).
    /// </summary>
    /// <param name="width">The width of the screen</param>
    /// <param name="height">The height of the screen</param>
    /// <returns>A string containing the pixel data</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlReadScreenPixels")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string ReadScreenPixels(int width, int height);

    /// <summary>
    /// Load an empty framebuffer.
    /// </summary>
    /// <param name="width">The width of the framebuffer</param>
    /// <param name="height">The height of the framebuffer</param>
    /// <returns>The identifier of the loaded framebuffer</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadFramebuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadFramebuffer(int width, int height);

    /// <summary>
    /// Attach texture/renderbuffer to a framebuffer.
    /// </summary>
    /// <param name="fboId">The ID of the framebuffer object to attach the texture to.</param>
    /// <param name="texId">The ID of the texture to attach.</param>
    /// <param name="attachType">The attachment type of the texture.</param>
    /// <param name="texType">The type of the texture.</param>
    /// <param name="mipLevel">The mipmap level of the texture.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlFramebufferAttach")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void FramebufferAttach(uint fboId, uint texId, FramebufferAttachType attachType, FramebufferAttachTextureType texType, int mipLevel);

    /// <summary>
    /// Verify framebuffer is complete.
    /// </summary>
    /// <param name="id">The ID of the framebuffer to check.</param>
    /// <returns>true if the framebuffer is complete, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlFramebufferComplete")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FramebufferComplete(uint id);

    /// <summary>
    /// Delete framebuffer from GPU.
    /// </summary>
    /// <param name="id">The ID of the framebuffer object to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUnloadFramebuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadFramebuffer(uint id);

    /// <summary>
    /// Load shader from code strings.
    /// </summary>
    /// <param name="vsCode">The code of the vertex shader.</param>
    /// <param name="fsCode">The code of the fragment shader.</param>
    /// <returns>The ID of the compiled shader program.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadShaderCode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadShaderCode(string vsCode, string fsCode);

    /// <summary>
    /// Compile custom shader and return shader id (type: RL_VERTEX_SHADER, RL_FRAGMENT_SHADER, RL_COMPUTE_SHADER).
    /// </summary>
    /// <param name="shaderCode">The code of the shader to compile.</param>
    /// <param name="type">The type of the shader to compile (e.g. VertexShader, FragmentShader, etc).</param>
    /// <returns>The compiled shader as an unsigned integer.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlCompileShader", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint CompileShader(string shaderCode, int type);

    /// <summary>
    /// Load custom shader program.
    /// </summary>
    /// <param name="vShaderId">The vertex shader ID.</param>
    /// <param name="fShaderId">The fragment shader ID.</param>
    /// <returns>The program ID of the loaded shader program.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadShaderProgram")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadShaderProgram(uint vShaderId, uint fShaderId);

    /// <summary>
    /// Unload shader program.
    /// </summary>
    /// <param name="id">The ID of the shader program to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUnloadShaderProgram")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadShaderProgram(uint id);

    /// <summary>
    /// Get shader location uniform.
    /// </summary>
    /// <param name="shaderId">The ID of the shader program.</param>
    /// <param name="uniformName">The name of the uniform variable.</param>
    /// <returns>The location of the uniform variable within the shader program.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetLocationUniform", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetLocationUniform(uint shaderId, string uniformName);

    /// <summary>
    /// Retrieves the attribute location for a specific shader program.
    /// </summary>
    /// <param name="shaderId">The ID of the shader program.</param>
    /// <param name="attribName">The name of the attribute to retrieve the location for.</param>
    /// <returns>
    /// The attribute location for the specified shader program and attribute name.
    /// Returns -1 if the attribute location is not found.
    /// </returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetLocationAttrib", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetLocationAttrib(uint shaderId, string attribName);

    /// <summary>
    /// Set shader value uniform.
    /// </summary>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="value">A pointer to the value of the uniform variable.</param>
    /// <param name="uniformType">The type of the uniform variable.</param>
    /// <param name="count">The number of elements in the uniform variable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetUniform")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetUniform(int locIndex, nint value, ShaderUniformDataType uniformType, int count);

    /// <summary>
    /// Set shader value matrix.
    /// </summary>
    /// <param name="locIndex">The location index of the uniform matrix.</param>
    /// <param name="mat">The matrix value to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetUniformMatrix")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetUniformMatrix(int locIndex, Matrix4x4 mat);

    /// <summary>
    /// Set shader value sampler.
    /// </summary>
    /// <param name="locIndex">The location index of the uniform.</param>
    /// <param name="textureId">The ID of the texture.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetUniformSampler")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetUniformSampler(int locIndex, uint textureId);

    /// <summary>
    /// Set shader currently active (id and locations).
    /// </summary>
    /// <param name="id">The ID of the shader program to set.</param>
    /// <param name="locs">A pointer to an array of integers representing the location of each shader uniform.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetShader")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetShader(uint id, int* locs);

    /// <summary>
    /// Set shader currently active (id and locations).
    /// </summary>
    /// <param name="id">The ID of the shader program to set.</param>
    /// <param name="locs">The locations of the shader program's uniforms.</param>
    public static unsafe void SetShader(uint id, Span<int> locs) {
        fixed (int* locsPtr = locs) {
            SetShader(id, locsPtr);
        }
    }

    /// <summary>
    /// Load compute shader program.
    /// </summary>
    /// <param name="shaderId">The ID of the shader program to load.</param>
    /// <returns>The ID of the loaded compute shader program.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadComputeShaderProgram")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadComputeShaderProgram(uint shaderId);

    /// <summary>
    /// Dispatch compute shader (equivalent to *draw* for graphics pipeline).
    /// </summary>
    /// <param name="groupX">The number of groups in the X dimension.</param>
    /// <param name="groupY">The number of groups in the Y dimension.</param>
    /// <param name="groupZ">The number of groups in the Z dimension.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlComputeShaderDispatch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ComputeShaderDispatch(uint groupX, uint groupY, uint groupZ);

    /// <summary>
    /// Load shader storage buffer object (SSBO).
    /// </summary>
    /// <param name="size">The size of the data buffer.</param>
    /// <param name="data">A pointer to the data buffer.</param>
    /// <param name="usageHint">The usage hint for the data buffer.</param>
    /// <returns>The ID of the loaded shader buffer.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadShaderBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint LoadShaderBuffer(uint size, nint data, int usageHint);

    /// <summary>
    /// Unload shader storage buffer object (SSBO).
    /// </summary>
    /// <param name="ssboId">The ID of the shader buffer object to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUnloadShaderBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadShaderBuffer(uint ssboId);

    /// <summary>
    /// Update SSBO buffer data.
    /// </summary>
    /// <param name="id">The ID of the shader buffer object.</param>
    /// <param name="data">A pointer to the data to be updated.</param>
    /// <param name="dataSize">The size of the data in bytes.</param>
    /// <param name="offset">The offset in bytes from the beginning of the shader buffer object where the data will be updated.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlUpdateShaderBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateShaderBuffer(uint id, nint data, uint dataSize, uint offset);

    /// <summary>
    /// Bind SSBO buffer.
    /// </summary>
    /// <param name="id">The ID of the shader buffer.</param>
    /// <param name="index">The index to bind the shader buffer to.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlBindShaderBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BindShaderBuffer(uint id, uint index);

    /// <summary>
    /// Reads data from a shader buffer object.
    /// </summary>
    /// <param name="id">The identifier of the shader buffer object.</param>
    /// <param name="dest">The destination buffer to copy the data into.</param>
    /// <param name="count">The number of elements to read from the buffer.</param>
    /// <param name="offset">The offset at which to start reading from the buffer.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlReadShaderBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ReadShaderBuffer(uint id, nint dest, uint count, uint offset);

    /// <summary>
    /// Copy SSBO data between buffers.
    /// </summary>
    /// <param name="destId">The identifier of the destination shader buffer.</param>
    /// <param name="srcId">The identifier of the source shader buffer.</param>
    /// <param name="destOffset">The offset in bytes in the destination shader buffer where the data will be copied.</param>
    /// <param name="srcOffset">The offset in bytes in the source shader buffer where the data will start.</param>
    /// <param name="count">The number of bytes to copy from the source shader buffer to the destination shader buffer.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlCopyShaderBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void CopyShaderBuffer(uint destId, uint srcId, uint destOffset, uint srcOffset, uint count);

    /// <summary>
    /// Get SSBO buffer size.
    /// </summary>
    /// <param name="id">The ID of the shader program object.</param>
    /// <returns>The size of the storage for the shader program object.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetShaderBufferSize")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint GetShaderBufferSize(uint id);

    /// <summary>
    /// Bind image texture.
    /// </summary>
    /// <param name="id">The ID of the image texture to bind.</param>
    /// <param name="index">The index of the texture unit to bind the texture to.</param>
    /// <param name="format">The format of the image texture.</param>
    /// <param name="readOnly">A flag indicating if the texture should be read-only.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlBindImageTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BindImageTexture(uint id, uint index, PixelFormat format, [MarshalAs(UnmanagedType.I1)] bool readOnly);

    /// <summary>
    /// Get internal modelView matrix.
    /// </summary>
    /// <returns>The current modelView matrix as a Matrix4x4.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetMatrixModelview")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixModelView();

    /// <summary>
    /// Get internal projection matrix.
    /// </summary>
    /// <returns>The current projection matrix.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetMatrixProjection")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixProjection();

    /// <summary>
    /// Get internal accumulated transform matrix.
    /// </summary>
    /// <returns>The current matrix transformation as a Matrix4x4.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetMatrixTransform")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixTransform();

    /// <summary>
    /// Get internal projection matrix for stereo render (selected eye).
    /// </summary>
    /// <param name="eye">The eye to generate the projection matrix for.</param>
    /// <returns>The stereo projection matrix for the specified eye.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetMatrixProjectionStereo")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixProjectionStereo(int eye);

    /// <summary>
    /// Get internal view offset matrix for stereo render (selected eye).
    /// </summary>
    /// <param name="eye">The eye to get the view offset for. Use 0 for left eye, 1 for right eye.</param>
    /// <returns>The view offset matrix for stereo rendering.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "rlGetMatrixViewOffsetStereo")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetMatrixViewOffsetStereo(int eye);

    /// <summary>
    /// Set a custom projection matrix (replaces internal projection matrix).
    /// </summary>
    /// <param name="proj">The projection matrix to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetMatrixProjection")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixProjection(Matrix4x4 proj);

    /// <summary>
    /// Set a custom modelView matrix (replaces internal modelView matrix).
    /// </summary>
    /// <param name="view">The matrix used for model-view transformation.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetMatrixModelview")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixModelView(Matrix4x4 view);

    /// <summary>
    /// Set eyes projection matrices for stereo rendering.
    /// </summary>
    /// <param name="right">The matrix representing the projection for the right eye.</param>
    /// <param name="left">The matrix representing the projection for the left eye.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetMatrixProjectionStereo")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixProjectionStereo(Matrix4x4 right, Matrix4x4 left);

    /// <summary>
    /// Set eyes view offsets matrices for stereo rendering.
    /// </summary>
    /// <param name="right">The transformation matrix for the right eye.</param>
    /// <param name="left">The transformation matrix for the left eye.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "rlSetMatrixViewOffsetStereo")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMatrixViewOffsetStereo(Matrix4x4 right, Matrix4x4 left);

    /// <summary>
    /// Load and draw a cube.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadDrawCube")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void LoadDrawCube();

    /// <summary>
    /// Load and draw a quad.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "rlLoadDrawQuad")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void LoadDrawQuad();
}