namespace Raylib_CSharp.CSharp.Rendering.Gl.FrameBuffer;

public enum FramebufferAttachTextureType {

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +X side
    /// </summary>
    CubeMapPositiveX = 0,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -X side
    /// </summary>
    CubeMapNegativeX,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +Y side
    /// </summary>
    CubeMapPositiveY,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -Y side
    /// </summary>
    CubeMapNegativeY,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +Z side
    /// </summary>
    CubeMapPositiveZ,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -Z side
    /// </summary>
    CubeMapNegativeZ,

    /// <summary>
    /// Framebuffer texture attachment type: texture2d
    /// </summary>
    Texture2D = 100,

    /// <summary>
    /// Framebuffer texture attachment type: renderbuffer
    /// </summary>
    Renderbuffer = 200
}