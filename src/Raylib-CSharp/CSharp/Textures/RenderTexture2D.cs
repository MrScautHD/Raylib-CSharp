using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Textures;

[StructLayout(LayoutKind.Sequential)]
public struct RenderTexture2D {

    /// <summary>
    /// OpenGL framebuffer object id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Color buffer attachment texture.
    /// </summary>
    public Texture2D Texture;

    /// <summary>
    /// Depth buffer attachment texture.
    /// </summary>
    public Texture2D Depth;
}