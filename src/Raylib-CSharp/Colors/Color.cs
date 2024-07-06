using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Images;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Colors;

[StructLayout(LayoutKind.Sequential)]
public struct Color {

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

    /// <summary>
    /// Color, 4 components, R8G8B8A8 (32bit).
    /// </summary>
    /// <param name="r">Red component value.</param>
    /// <param name="g">Green component value.</param>
    /// <param name="b">Blue component value.</param>
    /// <param name="a">Alpha component value.</param>
    public Color(byte r, byte g, byte b, byte a) {
        this.R = r;
        this.G = g;
        this.B = b;
        this.A = a;
    }

    public override string ToString() {
        return $"R:{this.R} G:{this.G} B:{this.B} A:{this.A}";
    }

    /// <inheritdoc cref="RaylibApi.ColorIsEqual" />
    public static bool IsEqual(Color col1, Color col2) {
        return RaylibApi.ColorIsEqual(col1, col2);
    }

    /// <inheritdoc cref="RaylibApi.Fade" />
    public static Color Fade(Color color, float alpha) {
        return RaylibApi.Fade(color, alpha);
    }

    /// <inheritdoc cref="RaylibApi.ColorToInt" />
    public static int ToInt(Color color) {
        return RaylibApi.ColorToInt(color);
    }

    /// <inheritdoc cref="RaylibApi.ColorNormalize" />
    public static Vector4 Normalize(Color color) {
        return RaylibApi.ColorNormalize(color);
    }

    /// <inheritdoc cref="RaylibApi.ColorFromNormalized" />
    public static Color FromNormalized(Vector4 normalized) {
        return RaylibApi.ColorFromNormalized(normalized);
    }

    /// <inheritdoc cref="RaylibApi.ColorToHSV" />
    public static Vector3 ToHSV(Color color) {
        return RaylibApi.ColorToHSV(color);
    }

    /// <inheritdoc cref="RaylibApi.ColorFromHSV" />
    public static Color FromHSV(float hue, float saturation, float value) {
        return RaylibApi.ColorFromHSV(hue, saturation, value);
    }

    /// <inheritdoc cref="RaylibApi.ColorTint" />
    public static Color Tint(Color color, Color tint) {
        return RaylibApi.ColorTint(color, tint);
    }

    /// <inheritdoc cref="RaylibApi.ColorBrightness" />
    public static Color Brightness(Color color, float factor) {
        return RaylibApi.ColorBrightness(color, factor);
    }

    /// <inheritdoc cref="RaylibApi.ColorContrast" />
    public static Color Contrast(Color color, float contrast) {
        return RaylibApi.ColorContrast(color, contrast);
    }

    /// <inheritdoc cref="RaylibApi.ColorAlpha" />
    public static Color Alpha(Color color, float alpha) {
        return RaylibApi.ColorAlpha(color, alpha);
    }

    /// <inheritdoc cref="RaylibApi.ColorAlphaBlend" />
    public static Color AlphaBlend(Color dst, Color src, Color tint) {
        return RaylibApi.ColorAlphaBlend(dst, src, tint);
    }

    /// <inheritdoc cref="RaylibApi.GetColor" />
    public static Color FromHex(uint hexValue) {
        return RaylibApi.GetColor(hexValue);
    }

    /// <inheritdoc cref="RaylibApi.GetPixelColor" />
    public static Color GetPixelColor(nint srcPtr, PixelFormat format) {
        return RaylibApi.GetPixelColor(srcPtr, format);
    }

    /// <inheritdoc cref="RaylibApi.SetPixelColor" />
    public static void SetPixelColor(nint dstPtr, Color color, PixelFormat format) {
        RaylibApi.SetPixelColor(dstPtr, color, format);
    }

    /// <inheritdoc cref="RaylibApi.GetPixelDataSize" />
    public static int GetPixelDataSize(int width, int height, PixelFormat format) {
        return RaylibApi.GetPixelDataSize(width, height, format);
    }
}