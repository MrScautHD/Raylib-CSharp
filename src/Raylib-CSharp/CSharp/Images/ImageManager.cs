using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.CSharp.Fonts;
using Raylib_CSharp.CSharp.Marshallers;
using Raylib_CSharp.CSharp.Textures;
using Color = Raylib_CSharp.CSharp.Colors.Color;

namespace Raylib_CSharp.CSharp.Images;

public static partial class ImageManager {

    /// <summary>
    /// Load image from file into CPU memory (RAM).
    /// </summary>
    /// <param name="fileName">The name of the file to load the image from.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImage(string fileName);

    /// <summary>
    /// Load image from RAW file data.
    /// </summary>
    /// <param name="fileName">The name of the file to load the image from.</param>
    /// <param name="width">The width of the image in pixels.</param>
    /// <param name="height">The height of the image in pixels.</param>
    /// <param name="format">The pixel format of the image.</param>
    /// <param name="headerSize">The size of any header data that needs to be skipped.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageRaw(string fileName, int width, int height, PixelFormat format, int headerSize);

    /// <summary>
    /// Load image from SVG file data or string with specified size.
    /// </summary>
    /// <param name="fileNameOrString">The name of the file or the SVG string to load the image from.</param>
    /// <param name="width">The desired width of the image.</param>
    /// <param name="height">The desired height of the image.</param>
    /// <returns>The loaded SVG image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageSvg(string fileNameOrString, int width, int height);

    /// <summary>
    /// Load image sequence from file (frames appended to image.data).
    /// </summary>
    /// <param name="fileNameOrString">The name of the file or string to load the image as animation from.</param>
    /// <param name="frames">Number of frames loaded.</param>
    /// <returns>The loaded image as animation.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageAnim(string fileNameOrString, out int frames);

    /// <summary>
    /// Load image from memory buffer, fileType refers to extension: i.e. '.png'.
    /// </summary>
    /// <param name="fileType">The type of the file to load the image from.</param>
    /// <param name="fileData">The data of the file to load the image from.</param>
    /// <param name="dataSize">The size of the file data.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadImageFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Load image from GPU texture data.
    /// </summary>
    /// <param name="texture">The texture to load the image from.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageFromTexture(Texture2D texture);

    /// <summary>
    /// Load image from screen buffer and (screenshot).
    /// </summary>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageFromScreen();

    /// <summary>
    /// Check if an image is ready.
    /// </summary>
    /// <param name="image">The image to check.</param>
    /// <returns>True if the image is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsImageReady(Image image);

    /// <summary>
    /// Unload image from CPU memory (RAM).
    /// </summary>
    /// <param name="image">The image to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadImage(Image image);

    /// <summary>
    /// Export image data to file, returns true on success.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileName">The name of the file to export the image to.</param>
    /// <returns>Returns true if the image was exported successfully, otherwise false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ExportImage(Image image, string fileName);

    /// <summary>
    /// Export image to memory buffer.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileType">The file format of the exported image.</param>
    /// <param name="fileSize">The size of the exported image file.</param>
    /// <returns>A byte array representing the exported image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string ExportImageToMemory(Image image, string fileType, out int fileSize);

    /// <summary>
    /// Export image as code file defining an array of bytes, returns true on success.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileName">The name of the file to export the image to.</param>
    /// <returns>True if the image is successfully exported as code, otherwise false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ExportImageAsCode(Image image, string fileName);

    /// <summary>
    /// Generate image: plain color.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="color">The color to fill the image with.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageColor(int width, int height, Color color);

    /// <summary>
    /// Generate image: linear gradient, direction in degrees [0..360], 0=Vertical gradient.
    /// </summary>
    /// <param name="width">The width of the gradient image.</param>
    /// <param name="height">The height of the gradient image.</param>
    /// <param name="direction">The direction of the gradient (0 = horizontal, 1 = vertical).</param>
    /// <param name="start">The color at the start of the gradient.</param>
    /// <param name="end">The color at the end of the gradient.</param>
    /// <returns>The generated gradient image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientLinear(int width, int height, int direction, Color start, Color end);

    /// <summary>
    /// Generate image: radial gradient.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="density">The density of the gradient.</param>
    /// <param name="inner">The color of the inner part of the gradient.</param>
    /// <param name="outer">The color of the outer part of the gradient.</param>
    /// <returns>The generated image with the radial gradient.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientRadial(int width, int height, float density, Color inner, Color outer);

    /// <summary>
    /// Generate image: square gradient.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="density">The density of the pixels in the gradient.</param>
    /// <param name="inner">The inner color.</param>
    /// <param name="outer">The outer color.</param>
    /// <returns>The generated square gradient image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientSquare(int width, int height, float density, Color inner, Color outer);

    /// <summary>
    /// Generate image: checked.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="checksX">The number of horizontal checks.</param>
    /// <param name="checksY">The number of vertical checks.</param>
    /// <param name="col1">The color of the first check.</param>
    /// <param name="col2">The color of the second check.</param>
    /// <returns>The generated checked image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageChecked(int width, int height, int checksX, int checksY, Color col1, Color col2);

    /// <summary>
    /// Generate image: white noise.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="factor">The factor to control the intensity of the noise. Value should be between 0 and 1. A lower value generates less intense noise.</param>
    /// <returns>A generated white noise image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageWhiteNoise(int width, int height, float factor);

    /// <summary>
    /// Generate image: perlin noise.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="offsetX">The x-axis offset of the noise pattern.</param>
    /// <param name="offsetY">The y-axis offset of the noise pattern.</param>
    /// <param name="scale">The scale factor of the noise pattern.</param>
    /// <returns>The generated perlin noise image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

    /// <summary>
    /// Generate image: cellular algorithm, bigger tileSize means bigger cells.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="tileSize">The size of each tile in the image.</param>
    /// <returns>A cellular algorithm generated image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageCellular(int width, int height, int tileSize);

    /// <summary>
    /// Generate image: grayscale image from text data.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="text">The text to be converted into an image.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageText(int width, int height, string text);

    /// <summary>
    /// Create an image duplicate (useful for transformations).
    /// </summary>
    /// <param name="image">The Image to be copied.</param>
    /// <returns>A new Image object that is a copy of the input Image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageCopy(Image image);

    /// <summary>
    /// Create an image from another image piece.
    /// </summary>
    /// <param name="image">The source image to copy from.</param>
    /// <param name="rec">The rectangle defining the sub-region to be copied.</param>
    /// <returns>The new image containing the copied sub-rectangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageFromImage(Image image, RectangleF rec);

    /// <summary>
    /// Create an image from text (default font).
    /// </summary>
    /// <param name="text">The text to be rendered on the image.</param>
    /// <param name="fontSize">The font size to be used for the text.</param>
    /// <param name="color">The color of the text.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageText(string text, int fontSize, Color color);

    /// <summary>
    /// Create an image from text (custom sprite font).
    /// </summary>
    /// <param name="font">The font used to render the text.</param>
    /// <param name="text">The text to render.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <param name="tint">The tint color applied to the text.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageTextEx(Font font, string text, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Convert image data to desired format.
    /// </summary>
    /// <param name="image">The image to change the pixel format of.</param>
    /// <param name="newFormat">The new pixel format to apply to the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageFormat(ref Image image, PixelFormat newFormat);

    /// <summary>
    /// Convert image to POT (power-of-two).
    /// </summary>
    /// <param name="image">The image to resize and fill.</param>
    /// <param name="fill">The color to fill the resized image with.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageToPOT")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageToPot(ref Image image, Color fill);

    /// <summary>
    /// Crop an image to a defined rectangle.
    /// </summary>
    /// <param name="image">The image to crop.</param>
    /// <param name="crop">The rectangle defining the portion to crop.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageCrop(ref Image image, RectangleF crop);

    /// <summary>
    /// Crop image depending on alpha value.
    /// </summary>
    /// <param name="image">The image to crop.</param>
    /// <param name="threshold">The alpha threshold used for cropping.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageAlphaCrop(ref Image image, float threshold);

    /// <summary>
    /// Clear alpha channel to desired color.
    /// </summary>
    /// <param name="image">The image to clear the alpha channel of.</param>
    /// <param name="color">The color to set the alpha channel to.</param>
    /// <param name="threshold">The threshold value for determining which pixels to clear the alpha channel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageAlphaClear(ref Image image, Color color, float threshold);

    /// <summary>
    /// Apply alpha mask to image.
    /// </summary>
    /// <param name="image">The image to apply the alpha mask to.</param>
    /// <param name="alphaMask">The image to be used as the alpha mask.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageAlphaMask(ref Image image, Image alphaMask);

    /// <summary>
    /// Premultiply alpha channel.
    /// </summary>
    /// <param name="image">The image to modify.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageAlphaPremultiply(ref Image image);

    /// <summary>
    /// Apply Gaussian blur using a box blur approximation.
    /// </summary>
    /// <param name="image">The image to apply the blur effect to.</param>
    /// <param name="blurSize">The size of the blur effect.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageBlurGaussian(ref Image image, int blurSize);

    /// <summary>
    /// Resize image (Bicubic scaling algorithm).
    /// </summary>
    /// <param name="image">The image to resize.</param>
    /// <param name="newWidth">The new width of the image.</param>
    /// <param name="newHeight">The new height of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageResize(ref Image image, int newWidth, int newHeight);

    /// <summary>
    /// Resize image (Nearest-Neighbor scaling algorithm).
    /// </summary>
    /// <param name="image">The image to be resized.</param>
    /// <param name="newWidth">The new width of the image.</param>
    /// <param name="newHeight">The new height of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageResizeNN(ref Image image, int newWidth, int newHeight);

    /// <summary>
    /// Resize canvas and fill with color.
    /// </summary>
    /// <param name="image">The image to resize.</param>
    /// <param name="newWidth">The new width of the canvas.</param>
    /// <param name="newHeight">The new height of the canvas.</param>
    /// <param name="offsetX">The X offset of the image within the new canvas.</param>
    /// <param name="offsetY">The Y offset of the image within the new canvas.</param>
    /// <param name="fill">The color used to fill the empty space in the canvas.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageResizeCanvas(ref Image image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);

    /// <summary>
    /// Compute all mipmap levels for a provided image.
    /// </summary>
    /// <param name="image">The image to generate mipmaps for.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageMipmaps(ref Image image);

    /// <summary>
    /// Dither image data to 16bpp or lower (Floyd-Steinberg dithering).
    /// </summary>
    /// <param name="image">The image to dither.</param>
    /// <param name="rBpp">The color depth for the red channel.</param>
    /// <param name="gBpp">The color depth for the green channel.</param>
    /// <param name="bBpp">The color depth for the blue channel.</param>
    /// <param name="aBpp">The color depth for the alpha channel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDither(ref Image image, int rBpp, int gBpp, int bBpp, int aBpp);

    /// <summary>
    /// Flip image vertically.
    /// </summary>
    /// <param name="image">The image to be flipped.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageFlipVertical(ref Image image);

    /// <summary>
    /// Flip image horizontally.
    /// </summary>
    /// <param name="image">The image to flip.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageFlipHorizontal(ref Image image);

    /// <summary>
    /// Rotate image by input angle in degrees (-359 to 359).
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    /// <param name="degrees">The number of degrees to rotate the image by.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageRotate(ref Image image, int degrees);

    /// <summary>
    /// Rotate image clockwise 90deg.
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageRotateCW(ref Image image);

    /// <summary>
    /// Rotate image counter-clockwise 90deg.
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageRotateCCW(ref Image image);

    /// <summary>
    /// Modify image color: tint.
    /// </summary>
    /// <param name="image">The image to tint.</param>
    /// <param name="color">The color to tint the image with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageColorTint(ref Image image, Color color);

    /// <summary>
    /// Modify image color: invert.
    /// </summary>
    /// <param name="image">The image to invert the colors of.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageColorInvert(ref Image image);

    /// <summary>
    /// Modify image color: grayscale.
    /// </summary>
    /// <param name="image">The color image to convert.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageColorGrayscale(ref Image image);

    /// <summary>
    /// Modify image color: contrast (-100 to 100).
    /// </summary>
    /// <param name="image">The image to adjust the contrast of.</param>
    /// <param name="contrast">The contrast value. Positive values increase contrast, while negative values decrease contrast.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageColorContrast(ref Image image, float contrast);

    /// <summary>
    /// Modify image color: brightness (-255 to 255).
    /// </summary>
    /// <param name="image">The image to adjust.</param>
    /// <param name="brightness">The brightness value to apply to the image. Positive values increase brightness, negative values decrease brightness.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageColorBrightness(ref Image image, int brightness);

    /// <summary>
    /// Modify image color: replace color.
    /// </summary>
    /// <param name="image">The image to modify.</param>
    /// <param name="color">The color to replace.</param>
    /// <param name="replace">The color to replace with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageColorReplace(ref Image image, Color color, Color replace);

    /// <summary>
    /// Load color data from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color data from.</param>
    /// <returns>The color data of the loaded image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color* LoadImageColors(Image image);

    /// <summary>
    /// Load colors palette from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color palette from.</param>
    /// <param name="maxPaletteSize">The maximum number of colors in the palette.</param>
    /// <param name="colorCount">The actual number of colors in the palette.</param>
    /// <returns>A pointer to the loaded color palette.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color* LoadImagePalette(Image image, int maxPaletteSize, out int colorCount);

    /// <summary>
    /// Unload color data loaded with LoadImageColors().
    /// </summary>
    /// <param name="colors">Pointer to the colors of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadImageColors(Color* colors);

    /// <summary>
    /// Unload colors palette loaded with LoadImagePalette().
    /// </summary>
    /// <param name="colors">A pointer to the array of colors representing the palette.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadImagePalette(Color* colors);

    /// <summary>
    /// Get image alpha border rectangle.
    /// </summary>
    /// <param name="image">The image to process.</param>
    /// <param name="threshold">The threshold value for determining the alpha border.</param>
    /// <returns>The border rectangle with alpha values.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RectangleF GetImageAlphaBorder(Image image, float threshold);

    /// <summary>
    /// Get image pixel color at (x, y) position.
    /// </summary>
    /// <param name="image">The image to get the color from.</param>
    /// <param name="x">The X coordinate of the pixel.</param>
    /// <param name="y">The Y coordinate of the pixel.</param>
    /// <returns>The color of the pixel at the specified coordinates.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GetImageColor(Image image, int x, int y);

    /// <summary>
    /// Clear image background with given color.
    /// </summary>
    /// <param name="dst">The image to clear the background of.</param>
    /// <param name="color">The color to use for clearing the background.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageClearBackground(ref Image dst, Color color);

    /// <summary>
    /// Draw pixel within an image.
    /// </summary>
    /// <param name="dst">The target image.</param>
    /// <param name="posX">The X position of the pixel.</param>
    /// <param name="posY">The Y position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawPixel(ref Image dst, int posX, int posY, Color color);

    /// <summary>
    /// Draw pixel within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on. Modified by reference.</param>
    /// <param name="position">The position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawPixelV(ref Image dst, Vector2 position, Color color);

    /// <summary>
    /// Draw line within an image.
    /// </summary>
    /// <param name="dst">The image to draw the line on.</param>
    /// <param name="startPosX">The starting x-coordinate of the line's position.</param>
    /// <param name="startPosY">The starting y-coordinate of the line's position.</param>
    /// <param name="endPosX">The ending x-coordinate of the line's position.</param>
    /// <param name="endPosY">The ending y-coordinate of the line's position.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawLine(ref Image dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// Draw line within an image (Vector version).
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="start">The starting point of the line.</param>
    /// <param name="end">The ending point of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawLineV(ref Image dst, Vector2 start, Vector2 end, Color color);

    /// <summary>
    /// Draw a filled circle within an image.
    /// </summary>
    /// <param name="dst">The image in which to draw the circle.</param>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawCircle(ref Image dst, int centerX, int centerY, int radius, Color color);

    /// <summary>
    ///Draw a filled circle within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on.</param>
    /// <param name="center">The center coordinates of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle outline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawCircleV(ref Image dst, Vector2 center, int radius, Color color);

    /// <summary>
    /// Draw circle outline within an image.
    /// </summary>
    /// <param name="dst">The target image.</param>
    /// <param name="centerX">The X coordinate of the center of the circle.</param>
    /// <param name="centerY">The Y coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawCircleLines(ref Image dst, int centerX, int centerY, int radius, Color color);

    /// <summary>
    /// Draw circle outline within an image (Vector version).
    /// </summary>
    /// <param name="dst">Reference to the target image.</param>
    /// <param name="center">Center of the circle.</param>
    /// <param name="radius">Radius of the circle.</param>
    /// <param name="color">Color of the circle outline lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawCircleLinesV(ref Image dst, Vector2 center, int radius, Color color);

    /// <summary>
    /// Draw rectangle within an image.
    /// </summary>
    /// <param name="dst">The destination image to draw on.</param>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawRectangle(ref Image dst, int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw rectangle within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on.</param>
    /// <param name="position">The position of the top-left corner of the rectangle.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawRectangleV(ref Image dst, Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// Draw rectangle within an image.
    /// </summary>
    /// <param name="dst">The destination image to draw on.</param>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="color">The color to fill the rectangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawRectangleRec(ref Image dst, RectangleF rec, Color color);

    /// <summary>
    /// Draw rectangle lines within an image.
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="thick">The thickness of the lines.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawRectangleLines(ref Image dst, RectangleF rec, int thick, Color color);

    /// <summary>
    /// Draw a source image within a destination image (tint applied to source).
    /// </summary>
    /// <param name="dst">A reference to the destination image.</param>
    /// <param name="src">The source image to draw.</param>
    /// <param name="srcRec">The source rectangle defining the portion of the source image to draw.</param>
    /// <param name="dstRec">The destination rectangle defining the portion of the destination image where the source image will be drawn.</param>
    /// <param name="tint">The color tint to apply to the source image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDraw(ref Image dst, Image src, RectangleF srcRec, RectangleF dstRec, Color tint);

    /// <summary>
    /// Draw text (using default font) within an image (destination).
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="text">The text to draw.</param>
    /// <param name="posX">The X position of the text.</param>
    /// <param name="posY">The Y position of the text.</param>
    /// <param name="fontSize">The font size to use for the text.</param>
    /// <param name="color">The color of the text.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawText(ref Image dst, string text, int posX, int posY, int fontSize, Color color);

    /// <summary>
    /// Draw text (custom sprite font) within an image (destination).
    /// </summary>
    /// <param name="dst">The target image to draw the text on.</param>
    /// <param name="font">The font to use for rendering the text.</param>
    /// <param name="text">The text to draw on the image.</param>
    /// <param name="position">The position where the text should be drawn on the image.</param>
    /// <param name="fontSize">The size of the font to use for rendering the text.</param>
    /// <param name="spacing">The spacing between characters in the text.</param>
    /// <param name="tint">The tint color to apply to the text.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ImageDrawText(ref Image dst, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);
}