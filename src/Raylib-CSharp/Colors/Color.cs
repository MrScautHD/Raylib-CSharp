using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Images;

namespace Raylib_CSharp.Colors;

[StructLayout(LayoutKind.Sequential)]
public partial struct Color {

    /// <summary>
    /// Color red value.
    /// </summary>
    public byte R;

    /// <summary>
    /// Color green value.
    /// </summary>
    public byte G;

    /// <summary>
    /// Color blue value.
    /// </summary>
    public byte B;

    /// <summary>
    /// Color alpha value.
    /// </summary>
    public byte A;

    public static readonly Color LightGray = new(200, 200, 200, 255);
    public static readonly Color Gray = new(130, 130, 130, 255);
    public static readonly Color DarkGray = new(80, 80, 80, 255);
    public static readonly Color Yellow = new(253, 249, 0, 255);
    public static readonly Color Gold = new(255, 203, 0, 255);
    public static readonly Color Orange = new(255, 161, 0, 255);
    public static readonly Color Pink = new(255, 109, 194, 255);
    public static readonly Color Red = new(230, 41, 55, 255);
    public static readonly Color Maroon = new(190, 33, 55, 255);
    public static readonly Color Green = new(0, 228, 48, 255);
    public static readonly Color Lime = new(0, 158, 47, 255);
    public static readonly Color DarkGreen = new(0, 117, 44, 255);
    public static readonly Color SkyBlue = new(102, 191, 255, 255);
    public static readonly Color Blue = new(0, 121, 241, 255);
    public static readonly Color DarkBlue = new(0, 82, 172, 255);
    public static readonly Color Purple = new(200, 122, 255, 255);
    public static readonly Color Violet = new(135, 60, 190, 255);
    public static readonly Color DarkPurple = new(112, 31, 126, 255);
    public static readonly Color Beige = new(211, 176, 131, 255);
    public static readonly Color Brown = new(127, 106, 79, 255);
    public static readonly Color DarkBrown = new(76, 63, 47, 255);
    public static readonly Color White = new(255, 255, 255, 255);
    public static readonly Color Black = new(0, 0, 0, 255);
    public static readonly Color Blank = new(0, 0, 0, 0);
    public static readonly Color Magenta = new(255, 0, 255, 255);
    public static readonly Color RayWhite = new(245, 245, 245, 255);

    /// <summary>
    /// Color, 4 components, R8G8B8A8 (32bit).
    /// </summary>
    public Color(byte r, byte g, byte b, byte a) {
        this.R = r;
        this.G = g;
        this.B = b;
        this.A = a;
    }

    public override string ToString() {
        return $"R:{this.R} G:{this.G} B:{this.B} A:{this.A}";
    }

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to fade.</param>
    /// <param name="alpha">The new alpha value.</param>
    /// <returns>The faded color.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "Fade")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Fade(Color color, float alpha);

    /// <summary>
    /// Get hexadecimal value for a Color.
    /// </summary>
    /// <param name="color">The color to convert.</param>
    /// <returns>The integer representation of the color.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorToInt")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int ToInt(Color color);

    /// <summary>
    /// Get Color normalized as float [0..1].
    /// </summary>
    /// <param name="color">The color to normalize.</param>
    /// <returns>The normalized color as a Vector4.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorNormalize")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 Normalize(Color color);

    /// <summary>
    /// Get Color from normalized values [0..1].
    /// </summary>
    /// <param name="normalized">The normalized vector.</param>
    /// <returns>The converted color.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorFromNormalized")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color FromNormalized(Vector4 normalized);

    /// <summary>
    /// Get HSV values for a Color, hue [0..360], saturation/value [0..1].
    /// </summary>
    /// <param name="color">The color to convert.</param>
    /// <returns>The HSV representation of the color.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorToHSV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ToHSV(Color color);

    /// <summary>
    /// Get a Color from HSV values, hue [0..360], saturation/value [0..1].
    /// </summary>
    /// <param name="hue">The hue component of the color. It ranges from 0.0 to 360.0.</param>
    /// <param name="saturation">The saturation component of the color. It ranges from 0.0 to 1.0.</param>
    /// <param name="value">The value component of the color. It ranges from 0.0 to 1.0.</param>
    /// <returns>The color created from the given HSV values.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorFromHSV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color FromHSV(float hue, float saturation, float value);

    /// <summary>
    /// Get color multiplied with another color.
    /// </summary>
    /// <param name="color">The color to tint.</param>
    /// <param name="tint">The color to use as a tint.</param>
    /// <returns>The tinted color.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorTint")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Tint(Color color, Color tint);

    /// <summary>
    /// Get color with brightness correction, brightness factor goes from -1.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to adjust brightness on.</param>
    /// <param name="factor">The factor to adjust brightness by. Positive values increase brightness, negative values decrease brightness.</param>
    /// <returns>The color with adjusted brightness.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorBrightness")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Brightness(Color color, float factor);

    /// <summary>
    /// Get color with contrast correction, contrast values between -1.0f and 1.0f.
    /// </summary>
    /// <param name="color">The color to adjust.</param>
    /// <param name="contrast">The contrast value (0.0f to 1.0f).</param>
    /// <returns>The adjusted color.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorContrast")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Contrast(Color color, float contrast);

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to modify.</param>
    /// <param name="alpha">The new alpha value.</param>
    /// <returns>The resulting color with the new alpha value applied.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorAlpha")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Alpha(Color color, float alpha);

    /// <summary>
    /// Get src alpha-blended into dst color with tint.
    /// </summary>
    /// <param name="dst">The destination color.</param>
    /// <param name="src">The source color.</param>
    /// <param name="tint">The tint color.</param>
    /// <returns>The blended color.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ColorAlphaBlend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color AlphaBlend(Color dst, Color src, Color tint);

    /// <summary>
    /// Get Color structure from hexadecimal value.
    /// </summary>
    /// <param name="hexValue">The hexadecimal value of the color.</param>
    /// <returns>The color specified by the hexadecimal value.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetColor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color FromHex(uint hexValue);

    /// <summary>
    /// Get Color from a source pixel pointer of certain format.
    /// </summary>
    /// <param name="srcPtr">Pointer to the start of the image buffer.</param>
    /// <param name="format">The pixel format of the image buffer.</param>
    /// <returns>The color of the pixel.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetPixelColor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GetPixelColor(nint srcPtr, PixelFormat format);

    /// <summary>
    /// Set color formatted into destination pixel pointer.
    /// </summary>
    /// <param name="dstPtr">Pointer to the destination image data.</param>
    /// <param name="color">The color to set.</param>
    /// <param name="format">The pixel format of the image.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetPixelColor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetPixelColor(nint dstPtr, Color color, PixelFormat format);

    /// <summary>
    /// Get pixel data size in bytes for certain format.
    /// </summary>
    /// <param name="width">The width of the pixel data.</param>
    /// <param name="height">The height of the pixel data.</param>
    /// <param name="format">The pixel format of the pixel data.</param>
    /// <returns>The size of the pixel data in bytes.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetPixelDataSize")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetPixelDataSize(int width, int height, PixelFormat format);
}