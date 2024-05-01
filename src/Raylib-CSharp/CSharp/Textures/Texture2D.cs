using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Images;

namespace Raylib_CSharp.CSharp.Textures;

[StructLayout(LayoutKind.Sequential)]
public struct Texture2D {

    /// <summary>
    /// OpenGL texture id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Texture base width.
    /// </summary>
    public int Width;

    /// <summary>
    /// Texture base height.
    /// </summary>
    public int Height;

    /// <summary>
    /// Mipmap levels, 1 by default.
    /// </summary>
    public int Mipmaps;

    /// <summary>
    /// Data format (PixelFormat type).
    /// </summary>
    public PixelFormat Format;
}