using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Camera.Cam2D;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Vr;

namespace Raylib_CSharp.Rendering;

public static partial class Graphics {

    /// <summary>
    /// Set background color (framebuffer clear color).
    /// </summary>
    /// <param name="color">The color to clear the background with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearBackground(Color color);

    /// <summary>
    /// Setup canvas (framebuffer) to start drawing.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginDrawing();

    /// <summary>
    /// End canvas drawing and swap buffers (double buffering).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndDrawing();

    /// <summary>
    /// Begin 2D mode with custom camera (2D).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode2D(Camera2D camera);

    /// <summary>
    /// Ends 2D mode with custom camera.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode2D();

    /// <summary>
    /// Begin 3D mode with custom camera (3D).
    /// </summary>
    /// <param name="camera">The custom camera to be used.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode3D(Camera3D camera);

    /// <summary>
    /// Ends 3D mode and returns to default 2D orthographic mode.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode3D();

    /// <summary>
    /// Begin drawing to render texture.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginTextureMode(RenderTexture2D target);

    /// <summary>
    /// Ends drawing to render texture.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndTextureMode();

    /// <summary>
    /// Begin custom shader drawing.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginShaderMode(Shader shader);

    /// <summary>
    /// End custom shader drawing (use default shader).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndShaderMode();

    /// <summary>
    /// Begin blending mode (alpha, additive, multiplied, subtract, custom).
    /// </summary>
    /// <param name="mode">The blend mode to be applied.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginBlendMode(BlendMode mode);

    /// <summary>
    /// End blending mode (reset to default: alpha blending).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndBlendMode();

    /// <summary>
    /// Begin scissor mode (define screen area for following drawing).
    /// </summary>
    /// <param name="x">X-coordinate of the scissor rectangle.</param>
    /// <param name="y">Y-coordinate of the scissor rectangle.</param>
    /// <param name="width">Width of the scissor rectangle.</param>
    /// <param name="height">Height of the scissor rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginScissorMode(int x, int y, int width, int height);

    /// <summary>
    /// End scissor mode.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndScissorMode();

    /// <summary>
    /// Begin stereo rendering (requires VR simulator).
    /// </summary>
    /// <param name="config">The VR stereo configuration.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginVrStereoMode(VrStereoConfig config);

    /// <summary>
    /// End stereo rendering (requires VR simulator).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndVrStereoMode();

    /// <summary>
    /// Swap back buffer with front buffer (screen drawing).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SwapScreenBuffer();

    /* --------------------------------- Text Drawing --------------------------------- */

    /// <summary>
    /// Draw current FPS.
    /// </summary>
    /// <param name="posX">The x-coordinate of the position to draw the FPS counter.</param>
    /// <param name="posY">The y-coordinate of the position to draw the FPS counter.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "DrawFPS")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawFps(int posX, int posY);

    /// <summary>
    /// Draw text (using default font).
    /// </summary>
    /// <param name="text">The text string to be drawn.</param>
    /// <param name="posX">The x-coordinate of the starting position of the text.</param>
    /// <param name="posY">The y-coordinate of the starting position of the text.</param>
    /// <param name="fontSize">The font size of the text.</param>
    /// <param name="color">The color of the text.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawText(string text, int posX, int posY, int fontSize, Color color);

    /// <summary>
    /// Draw text using font and additional parameters.
    /// </summary>
    /// <param name="font">The font to use for drawing the text.</param>
    /// <param name="text">The text to draw.</param>
    /// <param name="position">The position of the text.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <param name="tint">The color tint to apply to the text.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Draw text using Font and pro parameters (rotation).
    /// </summary>
    /// <param name="font">The font to use for drawing the text.</param>
    /// <param name="text">The text to be drawn.</param>
    /// <param name="position">The position where the text will be drawn on the screen.</param>
    /// <param name="origin">The origin of the text. Defaults to (0, 0).</param>
    /// <param name="rotation">The rotation angle of the text. Defaults to 0.</param>
    /// <param name="fontSize">The size of the font. Defaults to 10.</param>
    /// <param name="spacing">The spacing between characters. Defaults to 0.</param>
    /// <param name="tint">The color to tint the text. Defaults to white (RGB: 255, 255, 255).</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Draw one character (codepoint).
    /// </summary>
    /// <param name="font">The font to use for drawing the codepoint.</param>
    /// <param name="codepoint">The Unicode codepoint to draw.</param>
    /// <param name="position">The position at which to draw the codepoint.</param>
    /// <param name="fontSize">The size of the codepoint to be drawn.</param>
    /// <param name="tint">The tint color to apply to the codepoint.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);

    /// <summary>
    /// Draw multiple character (codepoint).
    /// </summary>
    /// <param name="font">The font to use for drawing.</param>
    /// <param name="codepoints">An array of codepoints to draw.</param>
    /// <param name="codepointCount">The number of codepoints in the array.</param>
    /// <param name="position">The position to draw the text.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <param name="tint">The tint color to apply to the text.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTextCodepoints(Font font, int* codepoints, int codepointCount, Vector2 position, float fontSize, float spacing, Color tint);
}