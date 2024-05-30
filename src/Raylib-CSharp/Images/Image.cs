using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Images;

[StructLayout(LayoutKind.Sequential)]
public struct Image {

    /// <summary>
    /// Image raw data.
    /// </summary>
    public nint Data;

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

    /// <inheritdoc cref="RaylibApi.LoadImage" />
    public static Image Load(string fileName) {
        return RaylibApi.LoadImage(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadImageRaw" />
    public static Image LoadRaw(string fileName, int width, int height, PixelFormat format, int headerSize) {
        return RaylibApi.LoadImageRaw(fileName, width, height, format, headerSize);
    }

    /// <inheritdoc cref="RaylibApi.LoadImageSvg" />
    public static Image LoadSvg(string fileNameOrString, int width, int height) {
        return RaylibApi.LoadImageSvg(fileNameOrString, width, height);
    }

    /// <inheritdoc cref="RaylibApi.LoadImageAnim" />
    public static Image LoadAnim(string fileNameOrString, out int frames) {
        return RaylibApi.LoadImageAnim(fileNameOrString, out frames);
    }

    /// <inheritdoc cref="RaylibApi.LoadImageFromMemory" />
    public static unsafe Image LoadFromMemory(string fileType, ReadOnlySpan<byte> fileData) {
        fixed (byte* fileDataPtr = fileData) {
            return RaylibApi.LoadImageFromMemory(fileType, fileDataPtr, fileData.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.LoadImageFromTexture" />
    public static Image LoadFromTexture(Texture2D texture) {
        return RaylibApi.LoadImageFromTexture(texture);
    }

    /// <inheritdoc cref="RaylibApi.LoadImageFromScreen" />
    public static Image LoadFromScreen() {
        return RaylibApi.LoadImageFromScreen();
    }

    /// <inheritdoc cref="RaylibApi.GenImageColor" />
    public static Image GenColor(int width, int height, Color color) {
        return RaylibApi.GenImageColor(width, height, color);
    }

    /// <inheritdoc cref="RaylibApi.GenImageGradientLinear" />
    public static Image GenGradientLinear(int width, int height, int direction, Color start, Color end) {
        return RaylibApi.GenImageGradientLinear(width, height, direction, start, end);
    }

    /// <inheritdoc cref="RaylibApi.GenImageGradientRadial" />
    public static Image GenGradientRadial(int width, int height, float density, Color inner, Color outer) {
        return RaylibApi.GenImageGradientRadial(width, height, density, inner, outer);
    }

    /// <inheritdoc cref="RaylibApi.GenImageGradientSquare" />
    public static Image GenGradientSquare(int width, int height, float density, Color inner, Color outer) {
        return RaylibApi.GenImageGradientSquare(width, height, density, inner, outer);
    }

    /// <inheritdoc cref="RaylibApi.GenImageChecked" />
    public static Image GenChecked(int width, int height, int checksX, int checksY, Color col1, Color col2) {
        return RaylibApi.GenImageChecked(width, height, checksX, checksY, col1, col2);
    }

    /// <inheritdoc cref="RaylibApi.GenImageWhiteNoise" />
    public static Image GenWhiteNoise(int width, int height, float factor) {
        return RaylibApi.GenImageWhiteNoise(width, height, factor);
    }

    /// <inheritdoc cref="RaylibApi.GenImagePerlinNoise" />
    public static Image GenPerlinNoise(int width, int height, int offsetX, int offsetY, float scale) {
        return RaylibApi.GenImagePerlinNoise(width, height, offsetX, offsetY, scale);
    }

    /// <inheritdoc cref="RaylibApi.GenImageCellular" />
    public static Image GenCellular(int width, int height, int tileSize) {
        return RaylibApi.GenImageCellular(width, height, tileSize);
    }

    /// <inheritdoc cref="RaylibApi.GenImageText" />
    public static Image GenText(int width, int height, string text) {
        return RaylibApi.GenImageText(width, height, text);
    }

    /// <inheritdoc cref="RaylibApi.ImageText" />
    public static Image FromText(string text, int fontSize, Color color) {
        return RaylibApi.ImageText(text, fontSize, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageTextEx" />
    public static Image FromTextEx(Font font, string text, float fontSize, float spacing, Color tint) {
        return RaylibApi.ImageTextEx(font, text, fontSize, spacing, tint);
    }

    /// <inheritdoc cref="RaylibApi.UnloadImageColors" />
    public static unsafe void UnloadColors(ReadOnlySpan<Color> colors) {
        fixed (Color* colorPtr = colors) {
            RaylibApi.UnloadImageColors(colorPtr);
        }
    }

    /// <inheritdoc cref="RaylibApi.UnloadImagePalette" />
    public static unsafe void UnloadPalette(ReadOnlySpan<Color> colors) {
        fixed (Color* colorPtr = colors) {
            RaylibApi.UnloadImagePalette(colorPtr);
        }
    }

    /// <inheritdoc cref="RaylibApi.IsImageReady" />
    public bool IsReady() {
        return RaylibApi.IsImageReady(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadImage" />
    public void Unload() {
        RaylibApi.UnloadImage(this);
    }

    /// <inheritdoc cref="RaylibApi.ExportImage" />
    public bool Export(string fileName) {
        return RaylibApi.ExportImage(this, fileName);
    }

    /// <inheritdoc cref="RaylibApi.ExportImageToMemory" />
    public string ExportToMemory(string fileType, out int fileSize) {
        return RaylibApi.ExportImageToMemory(this, fileType, out fileSize);
    }

    /// <inheritdoc cref="RaylibApi.ExportImageAsCode" />
    public bool ExportAsCode(string fileName) {
        return RaylibApi.ExportImageAsCode(this, fileName);
    }

    /// <inheritdoc cref="RaylibApi.ImageCopy" />
    public Image Copy() {
        return RaylibApi.ImageCopy(this);
    }

    /// <inheritdoc cref="RaylibApi.ImageFromImage" />
    public Image FromImage(Rectangle rec) {
        return RaylibApi.ImageFromImage(this, rec);
    }

    /// <inheritdoc cref="RaylibApi.ImageFormat" />
    public void FromFormat(PixelFormat newFormat) {
        RaylibApi.ImageFormat(ref this, newFormat);
    }

    /// <inheritdoc cref="RaylibApi.ImageToPOT" />
    public void ToPOT(Color fill) {
        RaylibApi.ImageToPOT(ref this, fill);
    }

    /// <inheritdoc cref="RaylibApi.ImageCrop" />
    public void Crop(Rectangle crop) {
        RaylibApi.ImageCrop(ref this, crop);
    }

    /// <inheritdoc cref="RaylibApi.ImageAlphaCrop" />
    public void CropAlpha(float threshold) {
        RaylibApi.ImageAlphaCrop(ref this, threshold);
    }

    /// <inheritdoc cref="RaylibApi.ImageAlphaClear" />
    public void ClearAlpha(Color color, float threshold) {
        RaylibApi.ImageAlphaClear(ref this, color, threshold);
    }

    /// <inheritdoc cref="RaylibApi.ImageAlphaMask" />
    public void AlphaMask(Image alphaMask) {
        RaylibApi.ImageAlphaMask(ref this, alphaMask);
    }

    /// <inheritdoc cref="RaylibApi.ImageAlphaPremultiply" />
    public void AlphaPremultiply() {
        RaylibApi.ImageAlphaPremultiply(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageBlurGaussian" />
    public void BlurGaussian(int blurSize) {
        RaylibApi.ImageBlurGaussian(ref this, blurSize);
    }

    /// <inheritdoc cref="RaylibApi.ImageResize" />
    public void Resize(int newWidth, int newHeight) {
        RaylibApi.ImageResize(ref this, newWidth, newHeight);
    }

    /// <inheritdoc cref="RaylibApi.ImageResizeNN" />
    public void ImageResizeNN(int newWidth, int newHeight) {
        RaylibApi.ImageResizeNN(ref this, newWidth, newHeight);
    }

    /// <inheritdoc cref="RaylibApi.ImageResizeCanvas" />
    public void ResizeCanvas(int newWidth, int newHeight, int offsetX, int offsetY, Color fill) {
        RaylibApi.ImageResizeCanvas(ref this, newWidth, newHeight, offsetX, offsetY, fill);
    }

    /// <inheritdoc cref="RaylibApi.ImageMipmaps" />
    public void GenMipmaps() {
        RaylibApi.ImageMipmaps(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageDither" />
    public void Dither(int rBpp, int gBpp, int bBpp, int aBpp) {
        RaylibApi.ImageDither(ref this, rBpp, gBpp, bBpp, aBpp);
    }

    /// <inheritdoc cref="RaylibApi.ImageFlipVertical" />
    public void FlipVertical() {
        RaylibApi.ImageFlipVertical(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageFlipHorizontal" />
    public void FlipHorizontal() {
        RaylibApi.ImageFlipHorizontal(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageRotate" />
    public void Rotate(int degrees) {
        RaylibApi.ImageRotate(ref this, degrees);
    }

    /// <inheritdoc cref="RaylibApi.ImageRotateCW" />
    public void RotateCW() {
        RaylibApi.ImageRotateCW(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageRotateCCW" />
    public void RotateCCW() {
        RaylibApi.ImageRotateCCW(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageColorTint" />
    public void TintColor(Color color) {
        RaylibApi.ImageColorTint(ref this, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageColorInvert" />
    public void InvertColor() {
        RaylibApi.ImageColorInvert(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageColorGrayscale" />
    public void GrayscaleColor() {
        RaylibApi.ImageColorGrayscale(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ImageColorContrast" />
    public void ColorContrast(float contrast) {
        RaylibApi.ImageColorContrast(ref this, contrast);
    }

    /// <inheritdoc cref="RaylibApi.ImageColorBrightness" />
    public void ColorBrightness(int brightness) {
        RaylibApi.ImageColorBrightness(ref this, brightness);
    }

    /// <inheritdoc cref="RaylibApi.ImageColorReplace" />
    public void ReplaceColor(Color color, Color replace) {
        RaylibApi.ImageColorReplace(ref this, color, replace);
    }

    /// <inheritdoc cref="RaylibApi.LoadImageColors" />
    public unsafe ReadOnlySpan<Color> LoadColors() {
        return new ReadOnlySpan<Color>(RaylibApi.LoadImageColors(this), this.Width * this.Height);
    }

    /// <inheritdoc cref="RaylibApi.LoadImagePalette" />
    public unsafe ReadOnlySpan<Color> LoadPalette(int maxPaletteSize) {
        return new ReadOnlySpan<Color>(RaylibApi.LoadImagePalette(this, maxPaletteSize, out int colorCount), colorCount);
    }

    /// <inheritdoc cref="RaylibApi.GetImageAlphaBorder" />
    public Rectangle GetAlphaBorder(float threshold) {
        return RaylibApi.GetImageAlphaBorder(this, threshold);
    }

    /// <inheritdoc cref="RaylibApi.GetImageColor" />
    public Color GetColor(int x, int y) {
        return RaylibApi.GetImageColor(this, x, y);
    }

    /// <inheritdoc cref="RaylibApi.ImageClearBackground" />
    public void ClearBackground(Color color) {
        RaylibApi.ImageClearBackground(ref this, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawPixel" />
    public void DrawPixel(int posX, int posY, Color color) {
        RaylibApi.ImageDrawPixel(ref this, posX, posY, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawPixelV" />
    public void DrawPixelV(Vector2 position, Color color) {
        RaylibApi.ImageDrawPixelV(ref this, position, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawLine" />
    public void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color) {
        RaylibApi.ImageDrawLine(ref this, startPosX, startPosY, endPosX, endPosY, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawLineV" />
    public void DrawLineV(Vector2 start, Vector2 end, Color color) {
        RaylibApi.ImageDrawLineV(ref this, start, end, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawCircle" />
    public void DrawCircle(int centerX, int centerY, int radius, Color color) {
        RaylibApi.ImageDrawCircle(ref this, centerX, centerY, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawCircleV" />
    public void DrawCircleV(Vector2 center, int radius, Color color) {
        RaylibApi.ImageDrawCircleV(ref this, center, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawCircleLines" />
    public void DrawCircleLines(int centerX, int centerY, int radius, Color color) {
        RaylibApi.ImageDrawCircleLines(ref this, centerX, centerY, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawCircleLinesV" />
    public void DrawCircleLinesV(Vector2 center, int radius, Color color) {
        RaylibApi.ImageDrawCircleLinesV(ref this, center, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawRectangle" />
    public void DrawRectangle(int posX, int posY, int width, int height, Color color) {
        RaylibApi.ImageDrawRectangle(ref this, posX, posY, width, height, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawRectangleV" />
    public void DrawRectangleV(Vector2 position, Vector2 size, Color color) {
        RaylibApi.ImageDrawRectangleV(ref this, position, size, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawRectangleRec" />
    public  void DrawRectangleRec(Rectangle rec, Color color) {
        RaylibApi.ImageDrawRectangleRec(ref this, rec, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawRectangleLines" />
    public void DrawRectangleLines(Rectangle rec, int thick, Color color) {
        RaylibApi.ImageDrawRectangleLines(ref this, rec, thick, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDraw" />
    public void Draw(Image src, Rectangle srcRec, Rectangle dstRec, Color tint) {
        RaylibApi.ImageDraw(ref this, src, srcRec, dstRec, tint);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawText" />
    public void DrawText(string text, int posX, int posY, int fontSize, Color color) {
        RaylibApi.ImageDrawText(ref this, text, posX, posY, fontSize, color);
    }

    /// <inheritdoc cref="RaylibApi.ImageDrawTextEx" />
    public void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint) {
        RaylibApi.ImageDrawTextEx(ref this, font, text, position, fontSize, spacing, tint);
    }
}