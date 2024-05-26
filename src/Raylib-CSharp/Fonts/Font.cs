using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Images;
using Raylib_CSharp.Textures;
using Color = Raylib_CSharp.Colors.Color;

namespace Raylib_CSharp.Fonts;

[StructLayout(LayoutKind.Sequential)]
public partial struct Font {

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
    public unsafe Span<Rectangle> Recs => new(this.RecsPtr, this.GlyphCount);

    public unsafe Rectangle* RecsPtr;

    /// <summary>
    /// Glyphs info data.
    /// </summary>
    public unsafe Span<GlyphInfo> Glyphs => new(this.GlyphsPtr, this.GlyphCount);

    public unsafe GlyphInfo* GlyphsPtr;

    /// <summary>
    /// Get the default Font.
    /// </summary>
    /// <returns>The default font.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetFontDefault")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font GetDefault();

    /// <summary>
    /// Load font from file into GPU memory (VRAM).
    /// </summary>
    /// <param name="fileName">The path of the font file.</param>
    /// <returns>The loaded font.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadFont", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font Load(string fileName);

    /// <summary>
    /// Load font from file with extended parameters, use NULL for codepoints and 0 for codepointCount to load the default character set.
    /// </summary>
    /// <param name="fileName">The path to the font file.</param>
    /// <param name="fontSize">The font size.</param>
    /// <param name="codepoints">An array of codepoints to load from the font.</param>
    /// <param name="codepointCount">The number of codepoints to load.</param>
    /// <returns>A Font object representing the loaded font.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadFontEx", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Font LoadEx(string fileName, int fontSize, int* codepoints, int codepointCount);

    /// <summary>
    /// Load font from file with extended parameters, use NULL for codepoints and 0 for codepointCount to load the default character set.
    /// </summary>
    /// <param name="fileName">The path to the font file.</param>
    /// <param name="fontSize">The font size.</param>
    /// <param name="codepoints">An array of codepoints to load from the font.</param>
    /// <returns>A Font object representing the loaded font.</returns>
    public static unsafe Font LoadEx(string fileName, int fontSize, ReadOnlySpan<int> codepoints) {
        fixed (int* codepointsPtr = codepoints) {
            return LoadEx(fileName, fontSize, codepointsPtr, codepoints.Length);
        }
    }

    /// <summary>
    /// Load font from Image (XNA style).
    /// </summary>
    /// <param name="image">The image containing the font characters.</param>
    /// <param name="key">The color key used to identify the font characters.</param>
    /// <param name="firstChar">The ASCII value of the first character in the font characters.</param>
    /// <returns>The loaded font.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadFontFromImage")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font LoadFromImage(Image image, Color key, int firstChar);

    /// <summary>
    /// Load font from memory buffer, fileType refers to extension: i.e. '.ttf'.
    /// </summary>
    /// <param name="fileType">The type of the font file.</param>
    /// <param name="fileData">The memory buffer containing the font data.</param>
    /// <param name="dataSize">The size of the font data in bytes.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="codepoints">The codepoints used to generate the font.</param>
    /// <param name="codepointCount">The number of codepoints used.</param>
    /// <returns>True if the font was successfully loaded, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadFontFromMemory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Font LoadFromMemory(string fileType, byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount);

    /// <summary>
    /// Load font from memory buffer, fileType refers to extension: i.e. '.ttf'.
    /// </summary>
    /// <param name="fileType">The type of the font file.</param>
    /// <param name="fileData">The memory buffer containing the font data.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="codepoints">The codepoints used to generate the font.</param>
    /// <returns>True if the font was successfully loaded, false otherwise.</returns>
    public static unsafe Font LoadFromMemory(string fileType, ReadOnlySpan<byte> fileData, int fontSize, ReadOnlySpan<int> codepoints) {
        fixed (byte* fileDataPtr = fileData) {
            fixed (int* codepointsPtr = codepoints) {
                return LoadFromMemory(fileType, fileDataPtr, fileData.Length, fontSize, codepointsPtr, codepoints.Length);
            }
        }
    }

    /// <summary>
    /// Load font data for further use.
    /// </summary>
    /// <param name="fileData">The file data in memory.</param>
    /// <param name="dataSize">The size of the file data.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="codepoints">An array of Unicode code points to load with font data.</param>
    /// <param name="codepointCount">The number of Unicode code points to load.</param>
    /// <param name="type">The type of font data to load.</param>
    /// <returns>A pointer to the loaded font data.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadFontData")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial GlyphInfo* LoadData(byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount, FontType type);

    /// <summary>
    /// Load font data for further use.
    /// </summary>
    /// <param name="fileData">The file data in memory.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="codepoints">An array of Unicode code points to load with font data.</param>
    /// <param name="type">The type of font data to load.</param>
    /// <returns>A Span to the loaded font data.</returns>
    public static unsafe ReadOnlySpan<GlyphInfo> LoadData(ReadOnlySpan<byte> fileData, int fontSize, ReadOnlySpan<int> codepoints, FontType type) {
        fixed (byte* fileDataPtr = fileData) {
            fixed (int* codepointsPtr = codepoints) {
                return new ReadOnlySpan<GlyphInfo>(LoadData(fileDataPtr, fileData.Length, fontSize, codepointsPtr, codepoints.Length, type), codepoints.Length);
            }
        }
    }

    /// <summary>
    /// Load font data for further use.
    /// </summary>
    /// <param name="fileData">The byte array containing the font data.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="codepointCount">The number of Unicode code points to load.</param>
    /// <param name="type">The type of font to load.</param>
    /// <returns>A read-only span of glyph information for the loaded codepoints.</returns>
    public static unsafe ReadOnlySpan<GlyphInfo> LoadData(ReadOnlySpan<byte> fileData, int fontSize, int codepointCount, FontType type) {
        fixed (byte* fileDataPtr = fileData) {
            return new ReadOnlySpan<GlyphInfo>(LoadData(fileDataPtr, fileData.Length, fontSize, null, codepointCount, type), codepointCount);
        }
    }

    /// <summary>
    /// Generate image font atlas using chars info.
    /// </summary>
    /// <param name="glyphs">An array of glyph information.</param>
    /// <param name="glyphRecs">A pointer to an array of glyph rectangles.</param>
    /// <param name="glyphCount">The number of glyphs.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="padding">The amount of padding between glyphs.</param>
    /// <param name="packMethod">The method used for packing the glyphs.</param>
    /// <returns>The generated font atlas image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageFontAtlas")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image GenImageAtlas(GlyphInfo* glyphs, Rectangle** glyphRecs, int glyphCount, int fontSize, int padding, int packMethod);

    /// <summary>
    /// Generate image font atlas using chars info.
    /// </summary>
    /// <param name="glyphs">An array of glyph information.</param>
    /// <param name="glyphRecs">A pointer to an array of glyph rectangles.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="padding">The amount of padding between glyphs.</param>
    /// <param name="packMethod">The method used for packing the glyphs.</param>
    /// <returns>The generated font atlas image.</returns>
    public static unsafe Image GenImageAtlas(ReadOnlySpan<GlyphInfo> glyphs, ReadOnlySpan<Rectangle> glyphRecs, int fontSize, int padding, int packMethod) {
        fixed (GlyphInfo* glyphsPtr = glyphs) {
            fixed (Rectangle* glyphRecsPtr = glyphRecs) {
                return GenImageAtlas(glyphsPtr, &glyphRecsPtr, glyphs.Length, fontSize, padding, packMethod);
            }
        }
    }

    /// <summary>
    /// Unload font chars info data (RAM).
    /// </summary>
    /// <param name="glyphs">Pointer to the GlyphInfo structure.</param>
    /// <param name="glyphCount">The number of glyphs.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadFontData")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadData(GlyphInfo* glyphs, int glyphCount);

    /// <summary>
    /// Unload font chars info data (RAM).
    /// </summary>
    /// <param name="glyphs">Pointer to the GlyphInfo structure.</param>
    public static unsafe void UnloadData(ReadOnlySpan<GlyphInfo> glyphs) {
        fixed (GlyphInfo* glyphsPtr = glyphs) {
            UnloadData(glyphsPtr, glyphs.Length);
        }
    }
}

/// <summary>
/// Contains extension methods for the <see cref="Font"/> class.
/// </summary>
public static partial class FontExtensions {

    /// <summary>
    /// Check if a font is ready.
    /// </summary>
    /// <param name="font">The font to check.</param>
    /// <returns>True if the font is ready to be used, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsFontReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(Font font);
    public static bool IsReady(this Font font) => IsReady_(font);

    /// <summary>
    /// Unload font from GPU memory (VRAM).
    /// </summary>
    /// <param name="font">The Font to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadFont")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(Font font);
    public static void Unload(this Font font) => Unload_(font);

    /// <summary>
    /// Export font as code file, returns true on success.
    /// </summary>
    /// <param name="font">The font to export.</param>
    /// <param name="fileName">The name of the file to save the exported code.</param>
    /// <returns>True if the export was successful, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportFontAsCode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool ExportAsCode_(Font font, string fileName);
    public static bool ExportAsCode(this Font font, string fileName) => ExportAsCode_(font, fileName);

    /// <summary>
    /// Get glyph index position in font for a codepoint (unicode character), fallback to '?' if not found.
    /// </summary>
    /// <param name="font">The font.</param>
    /// <param name="codepoint">The codepoint.</param>
    /// <returns>The glyph index.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial int GetGlyphIndex_(Font font, int codepoint);
    public static int GetGlyphIndex(this Font font, int codepoint) => GetGlyphIndex_(font, codepoint);

    /// <summary>
    /// Get glyph font info data for a codepoint (unicode character), fallback to '?' if not found.
    /// </summary>
    /// <param name="font">The font to get glyph information from.</param>
    /// <param name="codepoint">The codepoint of the glyph.</param>
    /// <returns>The glyph information for the specified codepoint.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial GlyphInfo GetGlyphInfo_(Font font, int codepoint);
    public static GlyphInfo GetGlyphInfo(this Font font, int codepoint) => GetGlyphInfo_(font, codepoint);

    /// <summary>
    /// Get glyph rectangle in font atlas for a codepoint (unicode character), fallback to '?' if not found.
    /// </summary>
    /// <param name="font">The font.</param>
    /// <param name="codepoint">The codepoint.</param>
    /// <returns>The glyph atlas rectangle for the specified codepoint.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Rectangle GetGlyphAtlasRec_(Font font, int codepoint);
    public static Rectangle GetGlyphAtlasRec(this Font font, int codepoint) => GetGlyphAtlasRec_(font, codepoint);
}