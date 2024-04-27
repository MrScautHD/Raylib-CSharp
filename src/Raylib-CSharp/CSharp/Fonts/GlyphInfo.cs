using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Images;

namespace Raylib_CSharp.CSharp.Fonts;

[StructLayout(LayoutKind.Sequential)]
public struct GlyphInfo {
    
    /// <summary>
    /// Character value (Unicode).
    /// </summary>
    public int Value;

    /// <summary>
    /// Character offset X when drawing.
    /// </summary>
    public int OffsetX;

    /// <summary>
    /// Character offset Y when drawing.
    /// </summary>
    public int OffsetY;

    /// <summary>
    /// Character advance position X.
    /// </summary>
    public int AdvanceX;

    /// <summary>
    /// Character image data.
    /// </summary>
    public Image Image;
}