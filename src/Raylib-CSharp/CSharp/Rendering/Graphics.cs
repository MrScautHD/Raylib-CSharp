using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Camera.Cam2D;
using Raylib_CSharp.CSharp.Camera.Cam3D;
using Raylib_CSharp.CSharp.Misc;
using Raylib_CSharp.CSharp.Rendering.Shaders;
using Raylib_CSharp.CSharp.Vr;

namespace Raylib_CSharp.CSharp.Rendering;

public partial class Graphics {

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
    [LibraryImport(Raylib.Name, EntryPoint = "SwapScreenBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SwapScreenBuffer();
}