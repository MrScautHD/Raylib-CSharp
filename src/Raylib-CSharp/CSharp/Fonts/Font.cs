using System.Drawing;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Textures;

namespace Raylib_CSharp.CSharp.Fonts;

[StructLayout(LayoutKind.Sequential)]
public struct Font {

    /// <summary>
    /// Base size (default chars height).
    /// </summary>
    public int BaseSize;

    /// <summary>
    /// Number of glyph characters.
    /// </summary>
    public int GlyphCount;

    /// <summary>
    /// Padding around the glyph characters.
    /// </summary>
    public int GlyphPadding;

    /// <summary>
    /// Texture atlas containing the glyphs.
    /// </summary>
    public Texture2D Texture;

    /// <summary>
    /// Rectangles in texture for the glyphs.
    /// </summary>
    public unsafe Rectangle* Recs;

    /// <summary>
    /// Glyphs info data.
    /// </summary>
    public unsafe GlyphInfo* Glyphs;
}