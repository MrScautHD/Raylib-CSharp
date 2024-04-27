namespace Raylib_CSharp.CSharp.Rendering.Gl.FrameBuffer;

public enum FramebufferAttachTextureType {
    
    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +X side
    /// </summary>
    CubemapPositiveX = 0,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -X side
    /// </summary>
    CubemapNegativeX,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +Y side
    /// </summary>
    CubemapPositiveY,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -Y side
    /// </summary>
    CubemapNegativeY,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, +Z side
    /// </summary>
    CubemapPositiveZ,

    /// <summary>
    /// Framebuffer texture attachment type: cubemap, -Z side
    /// </summary>
    CubemapNegativeZ,

    /// <summary>
    /// Framebuffer texture attachment type: texture2d
    /// </summary>
    Texture2D = 100,

    /// <summary>
    /// Framebuffer texture attachment type: renderbuffer
    /// </summary>
    Renderbuffer = 200
}