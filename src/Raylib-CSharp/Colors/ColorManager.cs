using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Images;

namespace Raylib_CSharp.Colors;

public static partial class ColorManager {

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to fade.</param>
    /// <param name="alpha">The new alpha value.</param>
    /// <returns>The faded color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Fade(Color color, float alpha);

    /// <summary>
    /// Get hexadecimal value for a Color.
    /// </summary>
    /// <param name="color">The color to convert.</param>
    /// <returns>The integer representation of the color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int ColorToInt(Color color);

    /// <summary>
    /// Get Color normalized as float [0..1].
    /// </summary>
    /// <param name="color">The color to normalize.</param>
    /// <returns>The normalized color as a Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 ColorNormalize(Color color);

    /// <summary>
    /// Get Color from normalized values [0..1].
    /// </summary>
    /// <param name="normalized">The normalized vector.</param>
    /// <returns>The converted color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorFromNormalized(Vector4 normalized);

    /// <summary>
    /// Get HSV values for a Color, hue [0..360], saturation/value [0..1].
    /// </summary>
    /// <param name="color">The color to convert.</param>
    /// <returns>The HSV representation of the color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ColorToHSV(Color color);

    /// <summary>
    /// Get a Color from HSV values, hue [0..360], saturation/value [0..1].
    /// </summary>
    /// <param name="hue">The hue component of the color. It ranges from 0.0 to 360.0.</param>
    /// <param name="saturation">The saturation component of the color. It ranges from 0.0 to 1.0.</param>
    /// <param name="value">The value component of the color. It ranges from 0.0 to 1.0.</param>
    /// <returns>The color created from the given HSV values.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorFromHSV(float hue, float saturation, float value);

    /// <summary>
    /// Get color multiplied with another color.
    /// </summary>
    /// <param name="color">The color to tint.</param>
    /// <param name="tint">The color to use as a tint.</param>
    /// <returns>The tinted color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorTint(Color color, Color tint);

    /// <summary>
    /// Get color with brightness correction, brightness factor goes from -1.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to adjust brightness on.</param>
    /// <param name="factor">The factor to adjust brightness by. Positive values increase brightness, negative values decrease brightness.</param>
    /// <returns>The color with adjusted brightness.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorBrightness(Color color, float factor);

    /// <summary>
    /// Get color with contrast correction, contrast values between -1.0f and 1.0f.
    /// </summary>
    /// <param name="color">The color to adjust.</param>
    /// <param name="contrast">The contrast value (0.0f to 1.0f).</param>
    /// <returns>The adjusted color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorContrast(Color color, float contrast);

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to modify.</param>
    /// <param name="alpha">The new alpha value.</param>
    /// <returns>The resulting color with the new alpha value applied.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorAlpha(Color color, float alpha);

    /// <summary>
    /// Get src alpha-blended into dst color with tint.
    /// </summary>
    /// <param name="dst">The destination color.</param>
    /// <param name="src">The source color.</param>
    /// <param name="tint">The tint color.</param>
    /// <returns>The blended color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorAlphaBlend(Color dst, Color src, Color tint);

    /// <summary>
    /// Get Color structure from hexadecimal value.
    /// </summary>
    /// <param name="hexValue">The hexadecimal value of the color.</param>
    /// <returns>The color specified by the hexadecimal value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GetColor(uint hexValue);

    /// <summary>
    /// Get Color from a source pixel pointer of certain format.
    /// </summary>
    /// <param name="srcPtr">Pointer to the start of the image buffer.</param>
    /// <param name="format">The pixel format of the image buffer.</param>
    /// <returns>The color of the pixel.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color GetPixelColor(void* srcPtr, PixelFormat format);

    /// <summary>
    /// Set color formatted into destination pixel pointer.
    /// </summary>
    /// <param name="dstPtr">Pointer to the destination image data.</param>
    /// <param name="color">The color to set.</param>
    /// <param name="format">The pixel format of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetPixelColor(void* dstPtr, Color color, PixelFormat format);

    /// <summary>
    /// Get pixel data size in bytes for certain format.
    /// </summary>
    /// <param name="width">The width of the pixel data.</param>
    /// <param name="height">The height of the pixel data.</param>
    /// <param name="format">The pixel format of the pixel data.</param>
    /// <returns>The size of the pixel data in bytes.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetPixelDataSize(int width, int height, PixelFormat format);
}