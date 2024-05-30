using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Images;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Transformations;

namespace Raylib_CSharp.Fonts;

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
    public unsafe Rectangle* RecsPtr;

    /// <inheritdoc cref="RecsPtr" />
    public unsafe Span<Rectangle> Recs => new(this.RecsPtr, this.GlyphCount);

    /// <summary>
    /// Glyphs info data.
    /// </summary>
    public unsafe GlyphInfo* GlyphsPtr;

    /// <inheritdoc cref="GlyphsPtr" />
    public unsafe Span<GlyphInfo> Glyphs => new(this.GlyphsPtr, this.GlyphCount);

    /// <inheritdoc cref="RaylibApi.GetFontDefault" />
    public static Font GetDefault() {
        return RaylibApi.GetFontDefault();
    }

    /// <inheritdoc cref="RaylibApi.LoadFont" />
    public static Font Load(string fileName) {
        return RaylibApi.LoadFont(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadFontEx" />
    public static unsafe Font LoadEx(string fileName, int fontSize, ReadOnlySpan<int> codepoints) {
        fixed (int* codepointsPtr = codepoints) {
            return RaylibApi.LoadFontEx(fileName, fontSize, codepointsPtr, codepoints.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.LoadFontFromImage" />
    public static Font LoadFromImage(Image image, Color key, int firstChar) {
        return RaylibApi.LoadFontFromImage(image, key, firstChar);
    }

    /// <inheritdoc cref="RaylibApi.LoadFontFromMemory" />
    public static unsafe Font LoadFromMemory(string fileType, ReadOnlySpan<byte> fileData, int fontSize, ReadOnlySpan<int> codepoints) {
        fixed (byte* fileDataPtr = fileData) {
            fixed (int* codepointsPtr = codepoints) {
                return RaylibApi.LoadFontFromMemory(fileType, fileDataPtr, fileData.Length, fontSize, codepointsPtr, codepoints.Length);
            }
        }
    }

    /// <inheritdoc cref="RaylibApi.LoadFontData" />
    public static unsafe ReadOnlySpan<GlyphInfo> LoadData(ReadOnlySpan<byte> fileData, int fontSize, ReadOnlySpan<int> codepoints, FontType type) {
        fixed (byte* fileDataPtr = fileData) {
            fixed (int* codepointsPtr = codepoints) {
                return new ReadOnlySpan<GlyphInfo>(RaylibApi.LoadFontData(fileDataPtr, fileData.Length, fontSize, codepointsPtr, codepoints.Length, type), codepoints.Length);
            }
        }
    }

    /// <inheritdoc cref="RaylibApi.LoadFontData" />
    public static unsafe ReadOnlySpan<GlyphInfo> LoadData(ReadOnlySpan<byte> fileData, int fontSize,int codepointCount, FontType type) {
        fixed (byte* fileDataPtr = fileData) {
            return new ReadOnlySpan<GlyphInfo>(RaylibApi.LoadFontData(fileDataPtr, fileData.Length, fontSize, null, codepointCount, type), codepointCount);
        }
    }

    /// <inheritdoc cref="RaylibApi.GenImageFontAtlas" />
    public static unsafe Image GenImageAtlas(ReadOnlySpan<GlyphInfo> glyphs, ReadOnlySpan<Rectangle> glyphRecs, int fontSize, int padding, int packMethod) {
        fixed (GlyphInfo* glyphsPtr = glyphs) {
            fixed (Rectangle* glyphRecsPtr = glyphRecs) {
                return RaylibApi.GenImageFontAtlas(glyphsPtr, &glyphRecsPtr, glyphs.Length, fontSize, padding, packMethod);
            }
        }
    }

    /// <inheritdoc cref="RaylibApi.UnloadFontData" />
    public static unsafe void UnloadData(ReadOnlySpan<GlyphInfo> glyphs) {
        fixed (GlyphInfo* glyphsPtr = glyphs) {
            RaylibApi.UnloadFontData(glyphsPtr, glyphs.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.IsFontReady" />
    public bool IsReady() {
        return RaylibApi.IsFontReady(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadFont" />
    public void Unload() {
        RaylibApi.UnloadFont(this);
    }

    /// <inheritdoc cref="RaylibApi.ExportFontAsCode" />
    public bool ExportAsCode(string fileName) {
        return RaylibApi.ExportFontAsCode(this, fileName);
    }

    /// <inheritdoc cref="RaylibApi.GetGlyphIndex" />
    public int GetGlyphIndex(int codepoint) {
        return RaylibApi.GetGlyphIndex(this, codepoint);
    }

    /// <inheritdoc cref="RaylibApi.GetGlyphInfo" />
    public GlyphInfo GetGlyphInfo(int codepoint) {
        return RaylibApi.GetGlyphInfo(this, codepoint);
    }

    /// <inheritdoc cref="RaylibApi.GetGlyphAtlasRec" />
    public Rectangle GetGlyphAtlasRec(int codepoint) {
        return RaylibApi.GetGlyphAtlasRec(this, codepoint);
    }
}