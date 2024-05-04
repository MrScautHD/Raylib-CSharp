using System.Runtime.InteropServices;

namespace Raylib_CSharp.Images;

[StructLayout(LayoutKind.Sequential)]
public struct Image {

    /// <summary>
    /// Image raw data.
    /// </summary>
    public nint DataPtr;

    /// <summary>
    /// Image base width.
    /// </summary>
    public int Width;

    /// <summary>
    /// Image base height.
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