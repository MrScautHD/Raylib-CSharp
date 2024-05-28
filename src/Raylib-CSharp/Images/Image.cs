using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Unsafe.Marshallers;
using Color = Raylib_CSharp.Colors.Color;

namespace Raylib_CSharp.Images;

[StructLayout(LayoutKind.Sequential)]
public partial struct Image {

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

    /// <summary>
    /// Load image from file into CPU memory (RAM).
    /// </summary>
    /// <param name="fileName">The name of the file to load the image from.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImage", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image Load(string fileName);

    /// <summary>
    /// Load image from RAW file data.
    /// </summary>
    /// <param name="fileName">The name of the file to load the image from.</param>
    /// <param name="width">The width of the image in pixels.</param>
    /// <param name="height">The height of the image in pixels.</param>
    /// <param name="format">The pixel format of the image.</param>
    /// <param name="headerSize">The size of any header data that needs to be skipped.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImageRaw", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadRaw(string fileName, int width, int height, PixelFormat format, int headerSize);

    /// <summary>
    /// Load image from SVG file data or string with specified size.
    /// </summary>
    /// <param name="fileNameOrString">The name of the file or the SVG string to load the image from.</param>
    /// <param name="width">The desired width of the image.</param>
    /// <param name="height">The desired height of the image.</param>
    /// <returns>The loaded SVG image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImageSvg", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadSvg(string fileNameOrString, int width, int height);

    /// <summary>
    /// Load image sequence from file (frames appended to image.data).
    /// </summary>
    /// <param name="fileNameOrString">The name of the file or string to load the image as animation from.</param>
    /// <param name="frames">Number of frames loaded.</param>
    /// <returns>The loaded image as animation.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImageAnim", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadAnim(string fileNameOrString, out int frames);

    /// <summary>
    /// Load image from memory buffer, fileType refers to extension: i.e. '.png'.
    /// </summary>
    /// <param name="fileType">The type of the file to load the image from.</param>
    /// <param name="fileData">The data of the file to load the image from.</param>
    /// <param name="dataSize">The size of the file data.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImageFromMemory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Load image from memory buffer, fileType refers to extension: i.e. '.png'.
    /// </summary>
    /// <param name="fileType">The type of the file to load the image from.</param>
    /// <param name="fileData">The data of the file to load the image from.</param>
    /// <returns>The loaded image.</returns>
    public static unsafe Image LoadFromMemory(string fileType, ReadOnlySpan<byte> fileData) {
        fixed (byte* fileDataPtr = fileData) {
            return LoadFromMemory(fileType, fileDataPtr, fileData.Length);
        }
    }

    /// <summary>
    /// Load image from GPU texture data.
    /// </summary>
    /// <param name="texture">The texture to load the image from.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImageFromTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadFromTexture(Texture2D texture);

    /// <summary>
    /// Load image from screen buffer and (screenshot).
    /// </summary>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImageFromScreen")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadFromScreen();

    /// <summary>
    /// Generate image: plain color.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="color">The color to fill the image with.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageColor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenColor(int width, int height, Color color);

    /// <summary>
    /// Generate image: linear gradient, direction in degrees [0..360], 0=Vertical gradient.
    /// </summary>
    /// <param name="width">The width of the gradient image.</param>
    /// <param name="height">The height of the gradient image.</param>
    /// <param name="direction">The direction of the gradient (0 = horizontal, 1 = vertical).</param>
    /// <param name="start">The color at the start of the gradient.</param>
    /// <param name="end">The color at the end of the gradient.</param>
    /// <returns>The generated gradient image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageGradientLinear")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenGradientLinear(int width, int height, int direction, Color start, Color end);

    /// <summary>
    /// Generate image: radial gradient.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="density">The density of the gradient.</param>
    /// <param name="inner">The color of the inner part of the gradient.</param>
    /// <param name="outer">The color of the outer part of the gradient.</param>
    /// <returns>The generated image with the radial gradient.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageGradientRadial")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenGradientRadial(int width, int height, float density, Color inner, Color outer);

    /// <summary>
    /// Generate image: square gradient.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="density">The density of the pixels in the gradient.</param>
    /// <param name="inner">The inner color.</param>
    /// <param name="outer">The outer color.</param>
    /// <returns>The generated square gradient image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageGradientSquare")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenGradientSquare(int width, int height, float density, Color inner, Color outer);

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
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageChecked")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenChecked(int width, int height, int checksX, int checksY, Color col1, Color col2);

    /// <summary>
    /// Generate image: white noise.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="factor">The factor to control the intensity of the noise. Value should be between 0 and 1. A lower value generates less intense noise.</param>
    /// <returns>A generated white noise image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageWhiteNoise")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenWhiteNoise(int width, int height, float factor);

    /// <summary>
    /// Generate image: perlin noise.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="offsetX">The x-axis offset of the noise pattern.</param>
    /// <param name="offsetY">The y-axis offset of the noise pattern.</param>
    /// <param name="scale">The scale factor of the noise pattern.</param>
    /// <returns>The generated perlin noise image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImagePerlinNoise")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenPerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

    /// <summary>
    /// Generate image: cellular algorithm, bigger tileSize means bigger cells.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="tileSize">The size of each tile in the image.</param>
    /// <returns>A cellular algorithm generated image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageCellular")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenCellular(int width, int height, int tileSize);

    /// <summary>
    /// Generate image: grayscale image from text data.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="text">The text to be converted into an image.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenImageText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenText(int width, int height, string text);

    /// <summary>
    /// Create an image from text (default font).
    /// </summary>
    /// <param name="text">The text to be rendered on the image.</param>
    /// <param name="fontSize">The font size to be used for the text.</param>
    /// <param name="color">The color of the text.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image FromText(string text, int fontSize, Color color);

    /// <summary>
    /// Create an image from text (custom sprite font).
    /// </summary>
    /// <param name="font">The font used to render the text.</param>
    /// <param name="text">The text to render.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <param name="tint">The tint color applied to the text.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageTextEx", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image FromTextEx(Font font, string text, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Unload color data loaded with LoadImageColors().
    /// </summary>
    /// <param name="colors">Pointer to the colors of the image.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadImageColors")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadColors(Color* colors);

    /// <summary>
    /// Unload color data loaded with LoadImageColors().
    /// </summary>
    /// <param name="colors">A Span to the colors of the image.</param>
    public static unsafe void UnloadColors(ReadOnlySpan<Color> colors) {
        fixed (Color* colorPtr = colors) {
            UnloadColors(colorPtr);
        }
    }

    /// <summary>
    /// Unload colors palette loaded with LoadImagePalette().
    /// </summary>
    /// <param name="colors">A pointer to the colors representing the palette.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadImagePalette")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadPalette(Color* colors);

    /// <summary>
    /// Unload colors palette loaded with LoadImagePalette().
    /// </summary>
    /// <param name="colors">A Span to the colors representing the palette.</param>
    public static unsafe void UnloadPalette(ReadOnlySpan<Color> colors) {
        fixed (Color* colorPtr = colors) {
            UnloadPalette(colorPtr);
        }
    }
}

/// <summary>
/// Contains extension methods for the <see cref="Image"/> class.
/// </summary>
public static partial class ImageExtensions {

    /// <summary>
    /// Check if an image is ready.
    /// </summary>
    /// <param name="image">The image to check.</param>
    /// <returns>True if the image is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsImageReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(Image image);
    public static bool IsReady(this Image image) => IsReady_(image);

    /// <summary>
    /// Unload image from CPU memory (RAM).
    /// </summary>
    /// <param name="image">The image to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadImage")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(Image image);
    public static void Unload(this Image image) => Unload_(image);

    /// <summary>
    /// Export image data to file, returns true on success.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileName">The name of the file to export the image to.</param>
    /// <returns>Returns true if the image was exported successfully, otherwise false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportImage", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool Export_(Image image, string fileName);
    public static bool Export(this Image image, string fileName) => Export_(image, fileName);

    /// <summary>
    /// Export image to memory buffer.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileType">The file format of the exported image.</param>
    /// <param name="fileSize">The size of the exported image file.</param>
    /// <returns>A byte array representing the exported image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportImageToMemory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    private static partial string ExportToMemory_(Image image, string fileType, out int fileSize);
    public static string ExportToMemory(this Image image, string fileType, out int fileSize) => ExportToMemory_(image, fileType, out fileSize);

    /// <summary>
    /// Export image as code file defining an array of bytes, returns true on success.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileName">The name of the file to export the image to.</param>
    /// <returns>True if the image is successfully exported as code, otherwise false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportImageAsCode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool ExportAsCode_(Image image, string fileName);
    public static bool ExportAsCode(this Image image, string fileName) => ExportAsCode_(image, fileName);

    /// <summary>
    /// Create an image duplicate (useful for transformations).
    /// </summary>
    /// <param name="image">The Image to be copied.</param>
    /// <returns>A new Image object that is a copy of the input Image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageCopy")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Image Copy_(Image image);
    public static Image Copy(this Image image) => Copy_(image);

    /// <summary>
    /// Create an image from another image piece.
    /// </summary>
    /// <param name="image">The source image to copy from.</param>
    /// <param name="rec">The rectangle defining the sub-region to be copied.</param>
    /// <returns>The new image containing the copied sub-rectangle.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageFromImage")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Image FromImage_(Image image, Rectangle rec);
    public static Image FromImage(this Image image, Rectangle rec) => FromImage_(image, rec);

    /// <summary>
    /// Convert image data to desired format.
    /// </summary>
    /// <param name="image">The image to change the pixel format of.</param>
    /// <param name="newFormat">The new pixel format to apply to the image.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageFormat")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ToFormat_(ref Image image, PixelFormat newFormat);
    public static void ToFormat(this ref Image image, PixelFormat newFormat) => ToFormat_(ref image, newFormat);

    /// <summary>
    /// Convert image to POT (power-of-two).
    /// </summary>
    /// <param name="image">The image to resize and fill.</param>
    /// <param name="fill">The color to fill the resized image with.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageToPOT")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ToPot_(ref Image image, Color fill);
    public static void ToPot(this ref Image image, Color fill) => ToPot_(ref image, fill);

    /// <summary>
    /// Crop an image to a defined rectangle.
    /// </summary>
    /// <param name="image">The image to crop.</param>
    /// <param name="crop">The rectangle defining the portion to crop.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageCrop")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Crop_(ref Image image, Rectangle crop);
    public static void Crop(this ref Image image, Rectangle crop) => Crop_(ref image, crop);

    /// <summary>
    /// Crop image depending on alpha value.
    /// </summary>
    /// <param name="image">The image to crop.</param>
    /// <param name="threshold">The alpha threshold used for cropping.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageAlphaCrop")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void CropAlpha_(ref Image image, float threshold);
    public static void CropAlpha(this ref Image image, float threshold) => CropAlpha_(ref image, threshold);

    /// <summary>
    /// Clear alpha channel to desired color.
    /// </summary>
    /// <param name="image">The image to clear the alpha channel of.</param>
    /// <param name="color">The color to set the alpha channel to.</param>
    /// <param name="threshold">The threshold value for determining which pixels to clear the alpha channel.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageAlphaClear")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ClearAlpha_(ref Image image, Color color, float threshold);
    public static void ClearAlpha(this ref Image image, Color color, float threshold) => ClearAlpha_(ref image, color, threshold);

    /// <summary>
    /// Apply alpha mask to image.
    /// </summary>
    /// <param name="image">The image to apply the alpha mask to.</param>
    /// <param name="alphaMask">The image to be used as the alpha mask.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageAlphaMask")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void AlphaMask_(ref Image image, Image alphaMask);
    public static void AlphaMask(this ref Image image, Image alphaMask) => AlphaMask_(ref image, alphaMask);

    /// <summary>
    /// Premultiply alpha channel.
    /// </summary>
    /// <param name="image">The image to modify.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageAlphaPremultiply")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void AlphaPremultiply_(ref Image image);
    public static void AlphaPremultiply(this ref Image image) => AlphaPremultiply_(ref image);

    /// <summary>
    /// Apply Gaussian blur using a box blur approximation.
    /// </summary>
    /// <param name="image">The image to apply the blur effect to.</param>
    /// <param name="blurSize">The size of the blur effect.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageBlurGaussian")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void BlurGaussian_(ref Image image, int blurSize);
    public static void BlurGaussian(this ref Image image, int blurSize) => BlurGaussian_(ref image, blurSize);

    /// <summary>
    /// Resize image (Bicubic scaling algorithm).
    /// </summary>
    /// <param name="image">The image to resize.</param>
    /// <param name="newWidth">The new width of the image.</param>
    /// <param name="newHeight">The new height of the image.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageResize")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Resize_(ref Image image, int newWidth, int newHeight);
    public static void Resize(this ref Image image, int newWidth, int newHeight) => Resize_(ref image, newWidth, newHeight);

    /// <summary>
    /// Resize image (Nearest-Neighbor scaling algorithm).
    /// </summary>
    /// <param name="image">The image to be resized.</param>
    /// <param name="newWidth">The new width of the image.</param>
    /// <param name="newHeight">The new height of the image.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageResizeNN")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ResizeNN_(ref Image image, int newWidth, int newHeight);
    public static void ResizeNN(this ref Image image, int newWidth, int newHeight) => ResizeNN_(ref image, newWidth, newHeight);

    /// <summary>
    /// Resize canvas and fill with color.
    /// </summary>
    /// <param name="image">The image to resize.</param>
    /// <param name="newWidth">The new width of the canvas.</param>
    /// <param name="newHeight">The new height of the canvas.</param>
    /// <param name="offsetX">The X offset of the image within the new canvas.</param>
    /// <param name="offsetY">The Y offset of the image within the new canvas.</param>
    /// <param name="fill">The color used to fill the empty space in the canvas.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageResizeCanvas")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ResizeCanvas_(ref Image image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);
    public static void ResizeCanvas(this ref Image image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill) => ResizeCanvas_(ref image, newWidth, newHeight, offsetX, offsetY, fill);

    /// <summary>
    /// Compute all mipmap levels for a provided image.
    /// </summary>
    /// <param name="image">The image to generate mipmaps for.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageMipmaps")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void GenMipmaps_(ref Image image);
    public static void GenMipmaps(this ref Image image) => GenMipmaps_(ref image);

    /// <summary>
    /// Dither image data to 16bpp or lower (Floyd-Steinberg dithering).
    /// </summary>
    /// <param name="image">The image to dither.</param>
    /// <param name="rBpp">The color depth for the red channel.</param>
    /// <param name="gBpp">The color depth for the green channel.</param>
    /// <param name="bBpp">The color depth for the blue channel.</param>
    /// <param name="aBpp">The color depth for the alpha channel.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDither")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Dither_(ref Image image, int rBpp, int gBpp, int bBpp, int aBpp);
    public static void Dither(this ref Image image, int rBpp, int gBpp, int bBpp, int aBpp) => Dither_(ref image, rBpp, gBpp, bBpp, aBpp);

    /// <summary>
    /// Flip image vertically.
    /// </summary>
    /// <param name="image">The image to be flipped.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageFlipVertical")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void FlipVertical_(ref Image image);
    public static void FlipVertical(this ref Image image) => FlipVertical_(ref image);

    /// <summary>
    /// Flip image horizontally.
    /// </summary>
    /// <param name="image">The image to flip.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageFlipHorizontal")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void FlipHorizontal_(ref Image image);
    public static void FlipHorizontal(this ref Image image) => FlipHorizontal_(ref image);

    /// <summary>
    /// Rotate image by input angle in degrees (-359 to 359).
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    /// <param name="degrees">The number of degrees to rotate the image by.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageRotate")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Rotate_(ref Image image, int degrees);
    public static void Rotate(this ref Image image, int degrees) => Rotate_(ref image, degrees);

    /// <summary>
    /// Rotate image clockwise 90deg.
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageRotateCW")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void RotateCW_(ref Image image);
    public static void RotateCW(this ref Image image) => RotateCW_(ref image);

    /// <summary>
    /// Rotate image counter-clockwise 90deg.
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageRotateCCW")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void RotateCCW_(ref Image image);
    public static void RotateCCW(this ref Image image) => RotateCCW_(ref image);

    /// <summary>
    /// Modify image color: tint.
    /// </summary>
    /// <param name="image">The image to tint.</param>
    /// <param name="color">The color to tint the image with.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageColorTint")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void TintColor_(ref Image image, Color color);
    public static void TintColor(this ref Image image, Color color) => TintColor_(ref image, color);

    /// <summary>
    /// Modify image color: invert.
    /// </summary>
    /// <param name="image">The image to invert the colors of.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageColorInvert")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void InvertColor_(ref Image image);
    public static void InvertColor(this ref Image image) => InvertColor_(ref image);

    /// <summary>
    /// Modify image color: grayscale.
    /// </summary>
    /// <param name="image">The color image to convert.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageColorGrayscale")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void GrayscaleColor_(ref Image image);
    public static void GrayscaleColor(this ref Image image) => GrayscaleColor_(ref image);

    /// <summary>
    /// Modify image color: contrast (-100 to 100).
    /// </summary>
    /// <param name="image">The image to adjust the contrast of.</param>
    /// <param name="contrast">The contrast value. Positive values increase contrast, while negative values decrease contrast.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageColorContrast")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ColorContrast_(ref Image image, float contrast);
    public static void ColorContrast(this ref Image image, float contrast) => ColorContrast_(ref image, contrast);

    /// <summary>
    /// Modify image color: brightness (-255 to 255).
    /// </summary>
    /// <param name="image">The image to adjust.</param>
    /// <param name="brightness">The brightness value to apply to the image. Positive values increase brightness, negative values decrease brightness.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageColorBrightness")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ColorBrightness_(ref Image image, int brightness);
    public static void ColorBrightness(this ref Image image, int brightness) => ColorBrightness_(ref image, brightness);

    /// <summary>
    /// Modify image color: replace color.
    /// </summary>
    /// <param name="image">The image to modify.</param>
    /// <param name="color">The color to replace.</param>
    /// <param name="replace">The color to replace with.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageColorReplace")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ReplaceColor_(ref Image image, Color color, Color replace);
    public static void ReplaceColor(this ref Image image, Color color, Color replace) => ReplaceColor_(ref image, color, replace);

    /// <summary>
    /// Load color data from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color data from.</param>
    /// <returns>The color data of the loaded image.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImageColors")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial Color* LoadColors_(Image image);
    public static unsafe Color* LoadColors(this Image image) => LoadColors_(image);

    /// <summary>
    /// Load color data from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color data from.</param>
    /// <returns>The color data of the loaded image.</returns>
    private static unsafe ReadOnlySpan<Color> LoadColorsSpan_(Image image) {
        return new ReadOnlySpan<Color>(LoadColors(image), image.Width * image.Height);
    }
    public static ReadOnlySpan<Color> LoadColorsSpan(this Image image) => LoadColorsSpan_(image);

    /// <summary>
    /// Load colors palette from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color palette from.</param>
    /// <param name="maxPaletteSize">The maximum number of colors in the palette.</param>
    /// <param name="colorCount">The actual number of colors in the palette.</param>
    /// <returns>A pointer to the loaded color palette.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadImagePalette")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial Color* LoadPalette_(Image image, int maxPaletteSize, out int colorCount);
    public static unsafe Color* LoadPalette(this Image image, int maxPaletteSize, out int colorCount) => LoadPalette_(image, maxPaletteSize, out colorCount);

    /// <summary>
    /// Load colors palette from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color palette from.</param>
    /// <param name="maxPaletteSize">The maximum number of colors in the palette.</param>
    /// <returns>A pointer to the loaded color palette.</returns>
    private static unsafe ReadOnlySpan<Color> LoadPalette_(Image image, int maxPaletteSize) {
        return new ReadOnlySpan<Color>(LoadPalette_(image, maxPaletteSize, out int colorCount), colorCount);
    }
    public static ReadOnlySpan<Color> LoadPalette(this Image image, int maxPaletteSize) => LoadPalette_(image, maxPaletteSize);

    /// <summary>
    /// Get image alpha border rectangle.
    /// </summary>
    /// <param name="image">The image to process.</param>
    /// <param name="threshold">The threshold value for determining the alpha border.</param>
    /// <returns>The border rectangle with alpha values.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetImageAlphaBorder")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Rectangle GetAlphaBorder_(Image image, float threshold);
    public static Rectangle GetAlphaBorder(this Image image, float threshold) => GetAlphaBorder_(image, threshold);

    /// <summary>
    /// Get image pixel color at (x, y) position.
    /// </summary>
    /// <param name="image">The image to get the color from.</param>
    /// <param name="x">The X coordinate of the pixel.</param>
    /// <param name="y">The Y coordinate of the pixel.</param>
    /// <returns>The color of the pixel at the specified coordinates.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetImageColor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Color GetColor_(Image image, int x, int y);
    public static Color GetColor(this Image image, int x, int y) => GetColor_(image, x, y);

    /// <summary>
    /// Clear image background with given color.
    /// </summary>
    /// <param name="dst">The image to clear the background of.</param>
    /// <param name="color">The color to use for clearing the background.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageClearBackground")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void ClearBackground_(ref Image dst, Color color);
    public static void ClearBackground(this ref Image image, Color color) => ClearBackground_(ref image, color);

    /// <summary>
    /// Draw pixel within an image.
    /// </summary>
    /// <param name="dst">The target image.</param>
    /// <param name="posX">The X position of the pixel.</param>
    /// <param name="posY">The Y position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawPixel")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawPixel_(ref Image dst, int posX, int posY, Color color);
    public static void DrawPixel(this ref Image image, int posX, int posY, Color color) => DrawPixel_(ref image, posX, posY, color);

    /// <summary>
    /// Draw pixel within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on. Modified by reference.</param>
    /// <param name="position">The position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawPixelV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawPixelV_(ref Image dst, Vector2 position, Color color);
    public static void DrawPixelV(this ref Image image, Vector2 position, Color color) => DrawPixelV_(ref image, position, color);

    /// <summary>
    /// Draw line within an image.
    /// </summary>
    /// <param name="dst">The image to draw the line on.</param>
    /// <param name="startPosX">The starting x-coordinate of the line's position.</param>
    /// <param name="startPosY">The starting y-coordinate of the line's position.</param>
    /// <param name="endPosX">The ending x-coordinate of the line's position.</param>
    /// <param name="endPosY">The ending y-coordinate of the line's position.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawLine")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawLine_(ref Image dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);
    public static void DrawLine(this ref Image image, int startPosX, int startPosY, int endPosX, int endPosY, Color color) => DrawLine_(ref image, startPosX, startPosY, endPosX, endPosY, color);

    /// <summary>
    /// Draw line within an image (Vector version).
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="start">The starting point of the line.</param>
    /// <param name="end">The ending point of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawLineV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawLineV_(ref Image dst, Vector2 start, Vector2 end, Color color);
    public static void DrawLineV(this ref Image image, Vector2 start, Vector2 end, Color color) => DrawLineV_(ref image, start, end, color);

    /// <summary>
    /// Draw a filled circle within an image.
    /// </summary>
    /// <param name="dst">The image in which to draw the circle.</param>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawCircle")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawCircle_(ref Image dst, int centerX, int centerY, int radius, Color color);
    public static void DrawCircle(this ref Image image, int centerX, int centerY, int radius, Color color) => DrawCircle_(ref image, centerX, centerY, radius, color);

    /// <summary>
    ///Draw a filled circle within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on.</param>
    /// <param name="center">The center coordinates of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle outline.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawCircleV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawCircleV_(ref Image dst, Vector2 center, int radius, Color color);
    public static void DrawCircleV(this ref Image image, Vector2 center, int radius, Color color) => DrawCircleV_(ref image, center, radius, color);

    /// <summary>
    /// Draw circle outline within an image.
    /// </summary>
    /// <param name="dst">The target image.</param>
    /// <param name="centerX">The X coordinate of the center of the circle.</param>
    /// <param name="centerY">The Y coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawCircleLines")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawCircleLines_(ref Image dst, int centerX, int centerY, int radius, Color color);
    public static void DrawCircleLines(this ref Image image, int centerX, int centerY, int radius, Color color) => DrawCircleLines_(ref image, centerX, centerY, radius, color);

    /// <summary>
    /// Draw circle outline within an image (Vector version).
    /// </summary>
    /// <param name="dst">Reference to the target image.</param>
    /// <param name="center">Center of the circle.</param>
    /// <param name="radius">Radius of the circle.</param>
    /// <param name="color">Color of the circle outline lines.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawCircleLinesV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawCircleLinesV_(ref Image dst, Vector2 center, int radius, Color color);
    public static void DrawCircleLinesV(this ref Image image, Vector2 center, int radius, Color color) => DrawCircleLinesV_(ref image, center, radius, color);

    /// <summary>
    /// Draw rectangle within an image.
    /// </summary>
    /// <param name="dst">The destination image to draw on.</param>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawRectangle")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawRectangle_(ref Image dst, int posX, int posY, int width, int height, Color color);
    public static void DrawRectangle(this ref Image image, int posX, int posY, int width, int height, Color color) => DrawRectangle_(ref image, posX, posY, width, height, color);

    /// <summary>
    /// Draw rectangle within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on.</param>
    /// <param name="position">The position of the top-left corner of the rectangle.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawRectangleV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawRectangleV_(ref Image dst, Vector2 position, Vector2 size, Color color);
    public static void DrawRectangleV(this ref Image image, Vector2 position, Vector2 size, Color color) => DrawRectangleV_(ref image, position, size, color);

    /// <summary>
    /// Draw rectangle within an image.
    /// </summary>
    /// <param name="dst">The destination image to draw on.</param>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="color">The color to fill the rectangle with.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawRectangleRec")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawRectangleRec_(ref Image dst, Rectangle rec, Color color);
    public static void DrawRectangleRec(this ref Image image, Rectangle rec, Color color) => DrawRectangleRec_(ref image, rec, color);

    /// <summary>
    /// Draw rectangle lines within an image.
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="thick">The thickness of the lines.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawRectangleLines")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawRectangleLines_(ref Image dst, Rectangle rec, int thick, Color color);
    public static void DrawRectangleLines(this ref Image image, Rectangle rec, int thick, Color color) => DrawRectangleLines_(ref image, rec, thick, color);

    /// <summary>
    /// Draw a source image within a destination image (tint applied to source).
    /// </summary>
    /// <param name="dst">A reference to the destination image.</param>
    /// <param name="src">The source image to draw.</param>
    /// <param name="srcRec">The source rectangle defining the portion of the source image to draw.</param>
    /// <param name="dstRec">The destination rectangle defining the portion of the destination image where the source image will be drawn.</param>
    /// <param name="tint">The color tint to apply to the source image.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDraw")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Draw_(ref Image dst, Image src, Rectangle srcRec, Rectangle dstRec, Color tint);
    public static void Draw(this ref Image image, Image src, Rectangle srcRec, Rectangle dstRec, Color tint) => Draw_(ref image, src, srcRec, dstRec, tint);

    /// <summary>
    /// Draw text (using default font) within an image (destination).
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="text">The text to draw.</param>
    /// <param name="posX">The X position of the text.</param>
    /// <param name="posY">The Y position of the text.</param>
    /// <param name="fontSize">The font size to use for the text.</param>
    /// <param name="color">The color of the text.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawText_(ref Image dst, string text, int posX, int posY, int fontSize, Color color);
    public static void DrawText(this ref Image image, string text, int posX, int posY, int fontSize, Color color) => DrawText_(ref image, text, posX, posY, fontSize, color);

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
    [LibraryImport(Raylib.Name, EntryPoint = "ImageDrawTextEx", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void DrawTextEx_(ref Image dst, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);
    public static void DrawTextEx(this ref Image image, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint) => DrawTextEx_(ref image, font, text, position, fontSize, spacing, tint);
}