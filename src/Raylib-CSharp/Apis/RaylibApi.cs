using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.Audio;
using Raylib_CSharp.Automations;
using Raylib_CSharp.Camera.Cam2D;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Images;
using Raylib_CSharp.Interact;
using Raylib_CSharp.IO;
using Raylib_CSharp.Logging;
using Raylib_CSharp.Materials;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Unsafe.Marshallers;
using Raylib_CSharp.Vr;
using Raylib_CSharp.Windowing;

namespace Raylib_CSharp.Apis;

internal static partial class RaylibApi {

    /* --------------------------------- Core --------------------------------- */

    /// <summary>
    /// Takes a screenshot of current screen (saved a .png).
    /// </summary>
    /// <param name="path">The path where the screenshot should be saved.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void TakeScreenshot(string path);

    /// <summary>
    /// Setup init configuration flags (view FLAGS).
    /// </summary>
    /// <param name="flags">The configuration flags to set. Use the bitwise OR operator to combine multiple flags if needed.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetConfigFlags(ConfigFlags flags);

    /// <summary>
    /// Open URL with default system browser (if available).
    /// </summary>
    /// <param name="url">The URL to open.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void OpenURL(string url);

    /// <summary>
    /// Set the seed for the random number generator.
    /// </summary>
    /// <param name="seed">The seed value to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetRandomSeed(uint seed);

    /// <summary>
    /// Get a random value between min and max (both included).
    /// </summary>
    /// <param name="min">The minimum value of the range (inclusive).</param>
    /// <param name="max">The maximum value of the range (inclusive).</param>
    /// <returns>A random integer value between the minimum and maximum values.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetRandomValue(int min, int max);

    /// <summary>
    /// Load random values sequence, no values repeated.
    /// </summary>
    /// <param name="count">The number of random values to generate.</param>
    /// <param name="min">The minimum value in the range (inclusive).</param>
    /// <param name="max">The maximum value in the range (inclusive).</param>
    /// <returns>A pointer to an array of random integers.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial int* LoadRandomSequence(int count, int min, int max);

    /// <summary>
    /// Unload random values sequence.
    /// </summary>
    /// <param name="sequence">Pointer to the array containing the random sequence.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadRandomSequence(int* sequence);

    /// <summary>
    /// Internal memory allocator.
    /// </summary>
    /// <param name="size">The size of the memory block to allocate.</param>
    /// <returns>A pointer to the allocated memory block.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial nint MemAlloc(int size);

    /// <summary>
    /// Internal memory reallocator.
    /// </summary>
    /// <param name="ptr">A pointer to the block of memory to be allocate, in bytes..</param>
    /// <param name="size">The size of the memory block to allocate, in bytes.</param>
    /// <returns>A pointer to the allocated memory block.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial nint MemRealloc(nint ptr, int size);

    /// <summary>
    /// Internal memory free.
    /// </summary>
    /// <param name="ptr">A pointer to the block of memory to be freed.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void MemFree(nint ptr);

    /* --------------------------------- Window --------------------------------- */

    /// <summary>
    /// Initialize window and OpenGL context.
    /// </summary>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    /// <param name="title">The title of the window.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void InitWindow(int width, int height, string title);

    /// <summary>
    /// Close window and unload OpenGL context.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CloseWindow();

    /// <summary>
    /// Check if application should close (KEY_ESCAPE pressed or windows close icon clicked).
    /// </summary>
    /// <returns>true if the window should close, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool WindowShouldClose();

    /// <summary>
    /// Check if window has been initialized successfully.
    /// </summary>
    /// <returns>True if the window and OpenGL context are ready, false otherwise</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowReady();

    /// <summary>
    /// Check if window is currently fullscreen.
    /// </summary>
    /// <returns>True if the window is in fullscreen mode, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowFullscreen();

    /// <summary>
    /// Check if window is currently hidden (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>True if the window is hidden, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowHidden();

    /// <summary>
    /// Check if window is currently minimized (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>
    /// <c>true</c> if the window is minimized; otherwise, <c>false</c>.
    /// </returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowMinimized();

    /// <summary>
    /// Check if window is currently maximized (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>True if the window is maximized, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowMaximized();

    /// <summary>
    /// Check if window is currently focused (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>true if the window has input focus, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowFocused();

    /// <summary>
    /// Check if window has been resized last frame.
    /// </summary>
    /// <returns>true if the window has been resized, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowResized();

    /// <summary>
    /// Check if one specific window flag is enabled.
    /// </summary>
    /// <param name="flag">The window state flag to check.</param>
    /// <returns>true if the window state flag is set, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWindowState(ConfigFlags flag);

    /// <summary>
    /// Set window configuration state using flags (only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="flag">The configuration flag(s) to set for the window.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowState(ConfigFlags flag);

    /// <summary>
    /// Clear window configuration state flags.
    /// </summary>
    /// <param name="flag">The window configuration flag to clear.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ClearWindowState(ConfigFlags flag);

    /// <summary>
    /// Toggle window state: fullscreen/windowed (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ToggleFullscreen();

    /// <summary>
    /// Toggle window state: borderless windowed (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ToggleBorderlessWindowed();

    /// <summary>
    /// Set window state: maximized, if resizable (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void MaximizeWindow();

    /// <summary>
    /// Set window state: minimized, if resizable (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void MinimizeWindow();

    /// <summary>
    /// Set window state: not minimized/maximized (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void RestoreWindow();

    /// <summary>
    /// Set icon for window (single image, RGBA 32bit, only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowIcon(Image image);

    /// <summary>
    /// Set icon for window (multiple images, RGBA 32bit, only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="images">The array of images representing the icons.</param>
    /// <param name="count">The number of icons in the array.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void SetWindowIcons(Image* images, int count);

    /// <summary>
    /// Set title for window (only PLATFORM_DESKTOP and PLATFORM_WEB).
    /// </summary>
    /// <param name="title">The new title for the window.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowTitle(string title);

    /// <summary>
    /// Set window position on screen (only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="x">The x-coordinate of the window position.</param>
    /// <param name="y">The y-coordinate of the window position.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowPosition(int x, int y);

    /// <summary>
    /// Set monitor for the current window.
    /// </summary>
    /// <param name="monitor">The index of the monitor to be used.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowMonitor(int monitor);

    /// <summary>
    /// Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE).
    /// </summary>
    /// <param name="width">The minimum width of the window.</param>
    /// <param name="height">The minimum height of the window.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowMinSize(int width, int height);

    /// <summary>
    /// Set window maximum dimensions (for FLAG_WINDOW_RESIZABLE).
    /// </summary>
    /// <param name="width">The maximum width of the window.</param>
    /// <param name="height">The maximum height of the window.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowMaxSize(int width, int height);

    /// <summary>
    /// Set window dimensions.
    /// </summary>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowSize(int width, int height);

    /// <summary>
    /// Set window opacity [0.0f..1.0f] (only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="opacity">The opacity to set, ranging from 0.0f (transparent) to 1.0f (opaque).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowOpacity(float opacity);

    /// <summary>
    /// Set window focused (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetWindowFocused();

    /// <summary>
    /// Get native window handle.
    /// </summary>
    /// <returns>The handle of the window.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial nint GetWindowHandle();

    /// <summary>
    /// Get current screen width.
    /// </summary>
    /// <returns>The width of the screen in pixels.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetScreenWidth();

    /// <summary>
    /// Get current screen height.
    /// </summary>
    /// <returns>The height of the screen in pixels.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetScreenHeight();

    /// <summary>
    /// Get current render width (it considers HiDPI).
    /// </summary>
    /// <returns>The width of the window's render area.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetRenderWidth();

    /// <summary>
    /// Get current render height (it considers HiDPI).
    /// </summary>
    /// <returns>The height of the rendering context.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetRenderHeight();

    /// <summary>
    /// Get number of connected monitors.
    /// </summary>
    /// <returns>The number of monitors connected to the system.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMonitorCount();

    /// <summary>
    /// Get current connected monitor.
    /// </summary>
    /// <returns>The index of the current monitor.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetCurrentMonitor();

    /// <summary>
    /// Get specified monitor position.
    /// </summary>
    /// <param name="monitor">The index of the monitor.</param>
    /// <returns>The position of the monitor.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetMonitorPosition(int monitor);

    /// <summary>
    /// Get specified monitor width (current video mode used by monitor).
    /// </summary>
    /// <param name="monitor">The monitor index.</param>
    /// <returns>The width of the monitor in pixels.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMonitorWidth(int monitor);

    /// <summary>
    /// Get specified monitor height (current video mode used by monitor).
    /// </summary>
    /// <param name="monitor">The index of the monitor. Default value is 0.</param>
    /// <returns>The height of the specified monitor.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMonitorHeight(int monitor);

    /// <summary>
    /// Get specified monitor physical width in millimetres.
    /// </summary>
    /// <param name="monitor">The index of the monitor to retrieve the width from.</param>
    /// <returns>The physical width of the monitor in pixels.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMonitorPhysicalWidth(int monitor);

    /// <summary>
    /// Get specified monitor physical height in millimetres.
    /// </summary>
    /// <param name="monitor">The index of the monitor.</param>
    /// <returns>The physical height of the monitor.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMonitorPhysicalHeight(int monitor);

    /// <summary>
    /// Get specified monitor refresh rate.
    /// </summary>
    /// <param name="monitor">The index of the monitor to retrieve the refresh rate from.</param>
    /// <returns>The refresh rate of the specified monitor in Hz.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMonitorRefreshRate(int monitor);

    /// <summary>
    /// Get window position XY on monitor.
    /// </summary>
    /// <returns>The position of the window as a <see cref="Vector2"/>.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetWindowPosition();

    /// <summary>
    /// Get window scale DPI factor.
    /// </summary>
    /// <returns>The scale DPI of the window as a <see cref="Vector2"/>.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetWindowScaleDPI();

    /// <summary>
    /// Get the human-readable, UTF-8 encoded name of the specified monitor.
    /// </summary>
    /// <param name="monitor">The index of the monitor.</param>
    /// <returns>The name of the monitor.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetMonitorName(int monitor);

    /// <summary>
    /// Set clipboard text content.
    /// </summary>
    /// <param name="text">The text to set as the clipboard content.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetClipboardText(string text);

    /// <summary>
    /// Get clipboard text content.
    /// </summary>
    /// <returns>The text stored in the clipboard as a Unicode string.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetClipboardText();

    /// <summary>
    /// Enable waiting for events on EndDrawing(), no automatic event polling.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EnableEventWaiting();

    /// <summary>
    /// Disable waiting for events on EndDrawing(), automatic events polling.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DisableEventWaiting();

    /* --------------------------------- Graphics --------------------------------- */

    /// <summary>
    /// Set background color (framebuffer clear color).
    /// </summary>
    /// <param name="color">The color to clear the background with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ClearBackground(Color color);

    /// <summary>
    /// Setup canvas (framebuffer) to start drawing.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginDrawing();

    /// <summary>
    /// End canvas drawing and swap buffers (double buffering).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndDrawing();

    /// <summary>
    /// Begin 2D mode with custom camera (2D).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginMode2D(Camera2D camera);

    /// <summary>
    /// Ends 2D mode with custom camera.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndMode2D();

    /// <summary>
    /// Begin 3D mode with custom camera (3D).
    /// </summary>
    /// <param name="camera">The custom camera to be used.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginMode3D(Camera3D camera);

    /// <summary>
    /// Ends 3D mode and returns to default 2D orthographic mode.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndMode3D();

    /// <summary>
    /// Begin drawing to render texture.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginTextureMode(RenderTexture2D target);

    /// <summary>
    /// Ends drawing to render texture.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndTextureMode();

    /// <summary>
    /// Begin custom shader drawing.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginShaderMode(Shader shader);

    /// <summary>
    /// End custom shader drawing (use default shader).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndShaderMode();

    /// <summary>
    /// Begin blending mode (alpha, additive, multiplied, subtract, custom).
    /// </summary>
    /// <param name="mode">The blend mode to be applied.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginBlendMode(BlendMode mode);

    /// <summary>
    /// End blending mode (reset to default: alpha blending).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndBlendMode();

    /// <summary>
    /// Begin scissor mode (define screen area for following drawing).
    /// </summary>
    /// <param name="x">X-coordinate of the scissor rectangle.</param>
    /// <param name="y">Y-coordinate of the scissor rectangle.</param>
    /// <param name="width">Width of the scissor rectangle.</param>
    /// <param name="height">Height of the scissor rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginScissorMode(int x, int y, int width, int height);

    /// <summary>
    /// End scissor mode.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndScissorMode();

    /// <summary>
    /// Begin stereo rendering (requires VR simulator).
    /// </summary>
    /// <param name="config">The VR stereo configuration.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void BeginVrStereoMode(VrStereoConfig config);

    /// <summary>
    /// End stereo rendering (requires VR simulator).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EndVrStereoMode();

    /// <summary>
    /// Swap back buffer with front buffer (screen drawing).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SwapScreenBuffer();

    /* --------------------------------- Graphics - Text Drawing --------------------------------- */

    /// <summary>
    /// Draw current FPS.
    /// </summary>
    /// <param name="posX">The x-coordinate of the position to draw the FPS counter.</param>
    /// <param name="posY">The y-coordinate of the position to draw the FPS counter.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawFPS(int posX, int posY);

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
    internal static partial void DrawText(string text, int posX, int posY, int fontSize, Color color);

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
    internal static partial void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

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
    internal static partial void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);

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
    internal static partial void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);

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
    internal static unsafe partial void DrawTextCodepoints(Font font, int* codepoints, int codepointCount, Vector2 position, float fontSize, float spacing, Color tint);

    /* --------------------------------- Graphics - Mesh Drawing --------------------------------- */

    /// <summary>
    /// Draw a 3d mesh with material and transform.
    /// </summary>
    /// <param name="mesh">The mesh to draw</param>
    /// <param name="material">The material to use for rendering</param>
    /// <param name="transform">The transformation matrix to apply to the mesh</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawMesh(Mesh mesh, Material material, Matrix4x4 transform);

    /// <summary>
    /// Draw multiple mesh instances with material and different transforms.
    /// </summary>
    /// <param name="mesh">The mesh to be drawn.</param>
    /// <param name="material">The material to be applied to the mesh.</param>
    /// <param name="transforms">An array of transform matrices for each instance.</param>
    /// <param name="instances">The number of instances to be drawn.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawMeshInstanced(Mesh mesh, Material material, Matrix4x4* transforms, int instances);

    /* --------------------------------- Graphics - Model Drawing --------------------------------- */

    /// <summary>
    /// Draw a line in 3D world space.
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color);

    /// <summary>
    /// Draw a point in 3D space, actually a small line.
    /// </summary>
    /// <param name="position">The position of the point in 3D space.</param>
    /// <param name="color">The color of the point.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawPoint3D(Vector3 position, Color color);

    /// <summary>
    /// Draw a circle in 3D world space.
    /// </summary>
    /// <param name="center">The center position of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="rotationAxis">The axis to rotate the circle around.</param>
    /// <param name="rotationAngle">The angle in degrees to rotate the circle around the rotation axis.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color);

    /// <summary>
    /// Draw a color-filled triangle (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the triangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">The points of the triangle.</param>
    /// <param name="pointCount">The count of the points.</param>
    /// <param name="color">The color to fill the triangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawTriangleStrip3D(Vector3* points, int pointCount, Color color);

    /// <summary>
    /// Draw cube.
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="width">The width of the cube.</param>
    /// <param name="height">The height of the cube.</param>
    /// <param name="length">The length of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCube(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube (Vector version).
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="size">The size of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCubeV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw cube wires.
    /// </summary>
    /// <param name="position">The position of the cube in 3D space.</param>
    /// <param name="width">The width of the cube.</param>
    /// <param name="height">The height of the cube.</param>
    /// <param name="length">The length of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube wires (Vector version).
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="size">The size of the cube.</param>
    /// <param name="color">The color of the cube wires.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCubeWiresV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw sphere.
    /// </summary>
    /// <param name="centerPos">The center position of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSphere(Vector3 centerPos, float radius, Color color);

    /// <summary>
    /// Draw sphere with extended parameters.
    /// </summary>
    /// <param name="centerPos">The center position of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="rings">The number of rings in the sphere. The higher the number, the smoother the surface.</param>
    /// <param name="slices">The number of slices in the sphere. The higher the number, the more detailed the sphere is.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw sphere wires.
    /// </summary>
    /// <param name="centerPos">The position of the center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="rings">The number of horizontal rings that make up the sphere.</param>
    /// <param name="slices">The number of vertical slices that make up the sphere.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw a cylinder/cone.
    /// </summary>
    /// <param name="position">The position of the center of the cylinder.</param>
    /// <param name="radiusTop">The radius of the top surface of the cylinder.</param>
    /// <param name="radiusBottom">The radius of the bottom surface of the cylinder.</param>
    /// <param name="height">The height of the cylinder.</param>
    /// <param name="slices">The number of subdivisions around the circumference of the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder with base at startPos and top at endPos.
    /// </summary>
    /// <param name="startPos">The starting position of the cylinder.</param>
    /// <param name="endPos">The ending position of the cylinder.</param>
    /// <param name="startRadius">The radius of the cylinder at the starting position.</param>
    /// <param name="endRadius">The radius of the cylinder at the ending position.</param>
    /// <param name="sides">The number of sides (segments) that make up the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a cylinder/cone wires.
    /// </summary>
    /// <param name="position">The position of the center of the cylinder.</param>
    /// <param name="radiusTop">The radius of the top circle of the cylinder.</param>
    /// <param name="radiusBottom">The radius of the bottom circle of the cylinder.</param>
    /// <param name="height">The height of the cylinder.</param>
    /// <param name="slices">The number of slices used to create the cylinder.</param>
    /// <param name="color">The color of the wireframe.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder wires with base at startPos and top at endPos.
    /// </summary>
    /// <param name="startPos">The starting position of the cylinder.</param>
    /// <param name="endPos">The ending position of the cylinder.</param>
    /// <param name="startRadius">The radius of the cylinder at the starting position.</param>
    /// <param name="endRadius">The radius of the cylinder at the ending position.</param>
    /// <param name="sides">The number of sides of the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a capsule with the center of its sphere caps at startPos and endPos.
    /// </summary>
    /// <param name="startPos">The start position of the capsule.</param>
    /// <param name="endPos">The end position of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="slices">The number of slices used to form the capsule geometry.</param>
    /// <param name="rings">The number of rings used to form the capsule geometry.</param>
    /// <param name="color">The color of the capsule.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw capsule wireframe with the center of its sphere caps at startPos and endPos.
    /// </summary>
    /// <param name="startPos">The start position of the capsule.</param>
    /// <param name="endPos">The end position of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="slices">The number of slices used to draw the capsule.</param>
    /// <param name="rings">The number of rings used to draw the capsule.</param>
    /// <param name="color">The color of the capsule wires.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw a plane XZ.
    /// </summary>
    /// <param name="centerPos">The center position of the plane.</param>
    /// <param name="size">The size of the plane, specified as a 2D vector.</param>
    /// <param name="color">The color of the plane.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawPlane(Vector3 centerPos, Vector2 size, Color color);

    /// <summary>
    /// Draw a ray line.
    /// </summary>
    /// <param name="ray">The ray to draw.</param>
    /// <param name="color">The color of the ray.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRay(Ray ray, Color color);

    /// <summary>
    /// Draw a grid (centered at (0, 0, 0)).
    /// </summary>
    /// <param name="slices">The number of subdivisions per side of the grid.</param>
    /// <param name="spacing">The spacing between grid lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawGrid(int slices, float spacing);

    /// <summary>
    /// Draw a model (with texture if set).
    /// </summary>
    /// <param name="model">The model to be drawn.</param>
    /// <param name="position">The position where the model should be drawn.</param>
    /// <param name="scale">The scaling factor to apply to the model.</param>
    /// <param name="tint">The color tint to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawModel(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model with extended parameters.
    /// </summary>
    /// <param name="model">The model to be drawn.</param>
    /// <param name="position">The position of the model.</param>
    /// <param name="rotationAxis">The axis to rotate the model around.</param>
    /// <param name="rotationAngle">The angle of rotation in degrees.</param>
    /// <param name="scale">The scale factor applied to the model.</param>
    /// <param name="tint">The color tint to be applied to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set).
    /// </summary>
    /// <param name="model">The model to draw the wires of.</param>
    /// <param name="position">The position at which to draw the model.</param>
    /// <param name="scale">The scale at which to draw the model.</param>
    /// <param name="tint">The tint color to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawModelWires(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set) with extended parameters.
    /// </summary>
    /// <param name="model">The model to draw.</param>
    /// <param name="position">The position to place the model.</param>
    /// <param name="rotationAxis">The rotation axis to apply to the model.</param>
    /// <param name="rotationAngle">The rotation angle to apply to the model.</param>
    /// <param name="scale">The scale to apply to the model.</param>
    /// <param name="tint">The color tint to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw bounding box (wires).
    /// </summary>
    /// <param name="box">The bounding box to draw.</param>
    /// <param name="color">The color of the bounding box.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawBoundingBox(BoundingBox box, Color color);

    /// <summary>
    /// Draw a billboard texture.
    /// </summary>
    /// <param name="camera">The camera used for rendering.</param>
    /// <param name="texture">The texture to be drawn as a billboard.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="tint">The tint color of the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawBillboard(Camera3D camera, Texture2D texture, Vector3 position, float size, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source.
    /// </summary>
    /// <param name="camera">The camera in 3D space.</param>
    /// <param name="texture">The texture of the billboard.</param>
    /// <param name="source">The source rectangle from the texture to be used for the billboard.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="tint">The tint color to be applied to the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawBillboardRec(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector2 size, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source and rotation.
    /// </summary>
    /// <param name="camera">The camera used for drawing.</param>
    /// <param name="texture">The texture used for the billboard.</param>
    /// <param name="source">The source rectangle of the texture.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="up">The up direction of the billboard.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="origin">The origin of the billboard.</param>
    /// <param name="rotation">The rotation of the billboard.</param>
    /// <param name="tint">The color tint of the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawBillboardPro(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint);

    /* --------------------------------- Graphics - Shape Drawing --------------------------------- */

    /// <summary>
    /// Draw a pixel.
    /// </summary>
    /// <param name="posX">The X coordinate of the pixel position.</param>
    /// <param name="posY">The Y coordinate of the pixel position.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawPixel(int posX, int posY, Color color);

    /// <summary>
    /// Draw a pixel (Vector version).
    /// </summary>
    /// <param name="position">The position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawPixelV(Vector2 position, Color color);

    /// <summary>
    /// Draw a line.
    /// </summary>
    /// <param name="startPosX">The x-coordinate of the starting point.</param>
    /// <param name="startPosY">The y-coordinate of the starting point.</param>
    /// <param name="endPosX">The x-coordinate of the ending point.</param>
    /// <param name="endPosY">The y-coordinate of the ending point.</param>
    /// <param name="color">The color to use for drawing the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// Draw a line (using gl lines).
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawLineV(Vector2 startPos, Vector2 endPos, Color color);

    /// <summary>
    /// Draw a line (using triangles/quads).
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="thick">The thickness of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw lines sequence (using gl lines).
    /// </summary>
    /// <param name="points">The array of points defining the line strip.</param>
    /// <param name="pointCount">The number of points in the line strip array.</param>
    /// <param name="color">The color of the line strip.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawLineStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw line segment cubic-bezier in-out interpolation.
    /// </summary>
    /// <param name="startPos">The starting position of the curve.</param>
    /// <param name="endPos">The ending position of the curve.</param>
    /// <param name="thick">The thickness of the curve.</param>
    /// <param name="color">The color of the curve.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw a color-filled circle.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircle(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw a piece of a circle.
    /// </summary>
    /// <param name="center">The center point of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="startAngle">The starting angle of the sector in degrees.</param>
    /// <param name="endAngle">The ending angle of the sector in degrees.</param>
    /// <param name="segments">The number of line segments used to approximate the curve.</param>
    /// <param name="color">The color to fill the sector with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw circle sector outline.
    /// </summary>
    /// <param name="center">The center point of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="startAngle">The start angle in radians.</param>
    /// <param name="endAngle">The end angle in radians.</param>
    /// <param name="segments">The number of line segments to use.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a gradient-filled circle.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the circle's center.</param>
    /// <param name="centerY">The y-coordinate of the circle's center.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color1">The color at the center of the circle.</param>
    /// <param name="color2">The color at the edge of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2);

    /// <summary>
    /// Draw a color-filled circle (Vector version).
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircleV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw circle outline.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircleLines(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw circle outline (Vector version).
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawCircleLinesV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw ellipse.
    /// </summary>
    /// <param name="centerX">The X coordinate of the center of the ellipse.</param>
    /// <param name="centerY">The Y coordinate of the center of the ellipse.</param>
    /// <param name="radiusH">The horizontal radius of the ellipse.</param>
    /// <param name="radiusV">The vertical radius of the ellipse.</param>
    /// <param name="color">The color of the ellipse.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ellipse outline.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the ellipse.</param>
    /// <param name="centerY">The y-coordinate of the center of the ellipse.</param>
    /// <param name="radiusH">The horizontal radius of the ellipse.</param>
    /// <param name="radiusV">The vertical radius of the ellipse.</param>
    /// <param name="color">The color of the ellipse outline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ring.
    /// </summary>
    /// <param name="center">The center of the ring.</param>
    /// <param name="innerRadius">The inner radius of the ring.</param>
    /// <param name="outerRadius">The outer radius of the ring.</param>
    /// <param name="startAngle">The start angle of the ring (in radians).</param>
    /// <param name="endAngle">The end angle of the ring (in radians).</param>
    /// <param name="segments">The number of segments to draw the ring.</param>
    /// <param name="color">The color of the ring.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw ring outline.
    /// </summary>
    /// <param name="center">The center point of the ring.</param>
    /// <param name="innerRadius">The inner radius of the ring.</param>
    /// <param name="outerRadius">The outer radius of the ring.</param>
    /// <param name="startAngle">The start angle of the ring in radians.</param>
    /// <param name="endAngle">The end angle of the ring in radians.</param>
    /// <param name="segments">The number of line segments which form the ring.</param>
    /// <param name="color">The color of the ring.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a color-filled rectangle.
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangle(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw a color-filled rectangle (Vector version).
    /// </summary>
    /// <param name="position">The position of the top-left corner of the rectangle.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleV(Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// Draw a color-filled rectangle.
    /// </summary>
    /// <param name="rec"> The dimensions of the rectangle to draw.</param>
    /// <param name="color"> The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleRec(Rectangle rec, Color color);

    /// <summary>
    /// Draw a color-filled rectangle with pro parameters.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="origin">The origin point of rotation.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="color">The color to fill the rectangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectanglePro(Rectangle rec, Vector2 origin, float rotation, Color color);

    /// <summary>
    /// Draw a vertical-gradient-filled rectangle.
    /// </summary>
    /// <param name="posX">The X coordinate of the rectangle's top-left corner.</param>
    /// <param name="posY">The Y coordinate of the rectangle's top-left corner.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color1">The starting color of the gradient.</param>
    /// <param name="color2">The ending color of the gradient.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2);

    /// <summary>
    /// Draw a horizontal-gradient-filled rectangle.
    /// </summary>
    /// <param name="posX">The starting x-coordinate of the rectangle.</param>
    /// <param name="posY">The starting y-coordinate of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color1">The starting color of the gradient.</param>
    /// <param name="color2">The ending color of the gradient.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2);

    /// <summary>
    /// Draw a gradient-filled rectangle with custom vertex colors.
    /// </summary>
    /// <param name="rec">The position and size of the rectangle.</param>
    /// <param name="col1">The color at the top-left corner of the rectangle.</param>
    /// <param name="col2">The color at the top-right corner of the rectangle.</param>
    /// <param name="col3">The color at the bottom-right corner of the rectangle.</param>
    /// <param name="col4">The color at the bottom-left corner of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleGradientEx(Rectangle rec, Color col1, Color col2, Color col3, Color col4);

    /// <summary>
    /// Draw rectangle outline.
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleLines(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw rectangle outline with extended parameters.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="lineThick">The thickness of the lines in pixels.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleLinesEx(Rectangle rec, float lineThick, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="roundness">The roundness of the rectangle corners.</param>
    /// <param name="segments">The number of segments used to draw the rounded corners.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color);

    /// <summary>
    /// Draw rectangle lines with rounded edges.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="roundness">The roundness of the corners. The value 0 is a sharp corner, while larger values make the corners more rounded.</param>
    /// <param name="segments">The number of segments used to approximate each corner.</param>
    /// <param name="color">The color of the rectangle and its corners.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges outline.
    /// </summary>
    /// <param name="rec">The rectangle to be drawn.</param>
    /// <param name="roundness">The roundness of the rectangle's corners.</param>
    /// <param name="segments">The number of line segments used to create the rounded corners.</param>
    /// <param name="lineThick">The thickness of the lines.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawRectangleRoundedLinesEx(Rectangle rec, float roundness, int segments, float lineThick, Color color);

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color to fill the triangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw a triangle fan defined by points (first vertex is the center).
    /// </summary>
    /// <param name="points">An array of points representing the vertices of the triangles.</param>
    /// <param name="pointCount">The number of vertices in the array.</param>
    /// <param name="color">The color of the triangles.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawTriangleFan(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">The array of vertices defining the triangle strip.</param>
    /// <param name="pointCount">The number of vertices in the array.</param>
    /// <param name="color">The color to fill the triangle strip with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawTriangleStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a regular polygon (Vector version).
    /// </summary>
    /// <param name="center">The center position of the polygon.</param>
    /// <param name="sides">The number of sides of the polygon.</param>
    /// <param name="radius">The radius of the polygon.</param>
    /// <param name="rotation">The rotation angle of the polygon in degrees.</param>
    /// <param name="color">The color of the polygon.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides.
    /// </summary>
    /// <param name="center">The center position of the polygon.</param>
    /// <param name="sides">The number of sides of the polygon.</param>
    /// <param name="radius">The radius of the polygon.</param>
    /// <param name="rotation">The rotation angle of the polygon in radians.</param>
    /// <param name="color">The color of the polygon.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides with extended parameters.
    /// </summary>
    /// <param name="center">The center position of the shape.</param>
    /// <param name="sides">The number of sides of the shape.</param>
    /// <param name="radius">The radius of the shape.</param>
    /// <param name="rotation">The rotation angle of the shape.</param>
    /// <param name="lineThick">The thickness of the lines.</param>
    /// <param name="color">The color of the shape.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color);

    /// <summary>
    /// Draw spline: Linear, minimum 2 points.
    /// </summary>
    /// <param name="points">The array of points that define the spline.</param>
    /// <param name="pointCount">The number of points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawSplineLinear(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: B-Spline, minimum 4 points.
    /// </summary>
    /// <param name="points">Pointer to the array of control points.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the curve.</param>
    /// <param name="color">The color of the curve.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawSplineBasis(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Catmull-Rom, minimum 4 points.
    /// </summary>
    /// <param name="points">The array of control points defining the spline.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawSplineCatmullRom(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Quadratic Bezier, minimum 3 points (1 control point): [p1, c2, p3, c4...].
    /// </summary>
    /// <param name="points">The array of control points defining the spline.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawSplineBezierQuadratic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Cubic Bezier, minimum 4 points (2 control points): [p1, c2, c3, p4, c5, c6...].
    /// </summary>
    /// <param name="points">Pointer to an array of Vector2 control points</param>
    /// <param name="pointCount">Number of control points in the array</param>
    /// <param name="thick">Thickness of the curve</param>
    /// <param name="color">Color of the curve</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DrawSplineBezierCubic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Linear, 2 points.
    /// </summary>
    /// <param name="p1">The starting point of the spline segment.</param>
    /// <param name="p2">The ending point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color);

    /// <summary>
    /// Draw spline segment: B-Spline, 4 points.
    /// </summary>
    /// <param name="p1">The first control point.</param>
    /// <param name="p2">The second control point.</param>
    /// <param name="p3">The third control point.</param>
    /// <param name="p4">The fourth control point.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment </param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Catmull-Rom, 4 points.
    /// </summary>
    /// <param name="p1">The first point of the spline segment.</param>
    /// <param name="p2">The second point of the spline segment.</param>
    /// <param name="p3">The third point of the spline segment.</param>
    /// <param name="p4">The fourth point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Quadratic Bezier, 2 points, 1 control point.
    /// </summary>
    /// <param name="p1">The starting point of the segment.</param>
    /// <param name="c2">The control point of the segment.</param>
    /// <param name="p3">The ending point of the segment.</param>
    /// <param name="thick">The thickness of the curve segment.</param>
    /// <param name="color">The color of the curve segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Cubic Bezier, 2 points, 2 control points.
    /// </summary>
    /// <param name="p1">The starting point of the spline segment.</param>
    /// <param name="c2">The second control point of the spline segment.</param>
    /// <param name="c3">The third control point of the spline segment.</param>
    /// <param name="p4">The ending point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment to draw.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color);

    /* --------------------------------- Graphics - Texture Drawing --------------------------------- */

    /// <summary>
    /// Draw a Texture2D.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="posX">The X coordinate of the position to draw the texture at.</param>
    /// <param name="posY">The Y coordinate of the position to draw the texture at.</param>
    /// <param name="tint">The tint color to apply to the texture (optional).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTexture(Texture2D texture, int posX, int posY, Color tint);

    /// <summary>
    /// Draw a Texture2D with position defined as Vector2.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="position">The position where the texture will be drawn.</param>
    /// <param name="tint">The color tint to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTextureV(Texture2D texture, Vector2 position, Color tint);

    /// <summary>
    /// Draw a Texture2D with extended parameters.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="position">The position where the texture will be drawn.</param>
    /// <param name="rotation">The rotation angle of the texture, in degrees.</param>
    /// <param name="scale">The scale factor to apply to the texture.</param>
    /// <param name="tint">The tint color to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTextureEx(Texture2D texture, Vector2 position, float rotation, float scale, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="source">The source rectangle to draw on the texture.</param>
    /// <param name="position">The position where the texture will be drawn on the screen.</param>
    /// <param name="tint">The color tint to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTextureRec(Texture2D texture, Rectangle source, Vector2 position, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle with 'pro' parameters.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="source">The source rectangle inside the texture.</param>
    /// <param name="dest">The destination rectangle on the screen.</param>
    /// <param name="origin">The origin point for rotation and scaling.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="tint">The color tint of the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTexturePro(Texture2D texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Draws a texture (or part of it) that stretches or shrinks nicely.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="nPatchInfo">The nine-patch information.</param>
    /// <param name="dest">The destination rectangle where the texture will be drawn.</param>
    /// <param name="origin">The origin of the rotation.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="tint">The color tint.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DrawTextureNPatch(Texture2D texture, NPatchInfo nPatchInfo, Rectangle dest, Vector2 origin, float rotation, Color tint);

    /* --------------------------------- Vr --------------------------------- */

    /// <summary>
    /// Load VR stereo config for VR simulator device parameters.
    /// </summary>
    /// <param name="device">The VR device information.</param>
    /// <returns>The loaded VR stereo configuration.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);

    /// <summary>
    /// Unload VR stereo config.
    /// </summary>
    /// <param name="config">The VR stereo configuration to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadVrStereoConfig(VrStereoConfig config);

    /* --------------------------------- Shader --------------------------------- */

    /// <summary>
    /// Load shader from files and bind default locations.
    /// </summary>
    /// <param name="vsFileName">The filename of the vertex shader.</param>
    /// <param name="fsFileName">The filename of the fragment shader.</param>
    /// <returns>The loaded shader.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Shader LoadShader(string vsFileName, string fsFileName);

    /// <summary>
    /// Load shader from code strings and bind default locations.
    /// </summary>
    /// <param name="vsCode">The string containing the vertex shader code.</param>
    /// <param name="fsCode">The string containing the fragment shader code.</param>
    /// <returns>The loaded shader.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Shader LoadShaderFromMemory(string vsCode, string fsCode);

    /// <summary>
    /// Check if a shader is ready.
    /// </summary>
    /// <param name="shader">The shader to check.</param>
    /// <returns>True if the shader is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsShaderReady(Shader shader);

    /// <summary>
    /// Unload shader from GPU memory (VRAM).
    /// </summary>
    /// <param name="shader">The shader to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadShader(Shader shader);

    /// <summary>
    /// Get shader uniform location.
    /// </summary>
    /// <param name="shader">The shader to query.</param>
    /// <param name="uniformName">The name of the uniform variable.</param>
    /// <returns>The location of the uniform variable. Returns -1 if the uniform does not exist in the shader.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetShaderLocation(Shader shader, string uniformName);

    /// <summary>
    /// Get shader attribute location.
    /// </summary>
    /// <param name="shader">The shader to retrieve the attribute location from.</param>
    /// <param name="attribName">The name of the attribute.</param>
    /// <returns>The location of the attribute.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetShaderLocationAttrib(Shader shader, string attribName);

    /// <summary>
    /// Set shader uniform value.
    /// </summary>
    /// <param name="shader">The shader containing the uniform variable.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void SetShaderValue(Shader shader, int locIndex, void* value, ShaderUniformDataType uniformType);

    /// <summary>
    /// Set shader uniform value vector.
    /// </summary>
    /// <param name="shader">The shader program.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="values">The values to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    /// <param name="count">The number of elements to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void SetShaderValueV(Shader shader, int locIndex, void* values, ShaderUniformDataType uniformType, int count);

    /// <summary>
    /// Set shader uniform value (matrix 4x4).
    /// </summary>
    /// <param name="shader">The shader to set the value in.</param>
    /// <param name="locIndex">The index of the uniform location.</param>
    /// <param name="mat">The matrix value to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetShaderValueMatrix(Shader shader, int locIndex, Matrix4x4 mat);

    /// <summary>
    /// Set shader uniform value for texture (sampler2d).
    /// </summary>
    /// <param name="shader">The shader to set the value in.</param>
    /// <param name="locIndex">The index of the uniform location.</param>
    /// <param name="texture">The texture to set the value to.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetShaderValueTexture(Shader shader, int locIndex, Texture2D texture);

    /* --------------------------------- Camera 2D --------------------------------- */

    /// <summary>
    /// Get the world space position for a 2d camera screen space position.
    /// </summary>
    /// <param name="position">The screen position (2D) to convert.</param>
    /// <param name="camera">The Camera2D used for the conversion.</param>
    /// <returns>The world position (2D) corresponding to the screen position (2D).</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera);

    /// <summary>
    /// Get the screen space position for a 2d camera world space position.
    /// </summary>
    /// <param name="position">The world position in 2D.</param>
    /// <param name="camera">The 2D camera.</param>
    /// <returns>The screen position in 2D.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera);

    /// <summary>
    /// Get camera 2d transform matrix.
    /// </summary>
    /// <param name="camera">The Camera2D to get the transformation matrix for.</param>
    /// <returns>The 2D transformation matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 GetCameraMatrix2D(Camera2D camera);

    /* --------------------------------- Camera 3D --------------------------------- */

    /// <summary>
    /// Update camera position for selected mode.
    /// </summary>
    /// <param name="camera">The camera to update.</param>
    /// <param name="mode">The camera mode.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateCamera(ref Camera3D camera, CameraMode mode);

    /// <summary>
    /// Update camera movement/rotation.
    /// </summary>
    /// <param name="camera">The camera to update.</param>
    /// <param name="movement">The movement vector.</param>
    /// <param name="rotation">The rotation vector.</param>
    /// <param name="zoom">The zoom value.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateCameraPro(ref Camera3D camera, Vector3 movement, Vector3 rotation, float zoom);

    /// <summary>
    /// Returns the cameras forward vector (normalized).
    /// </summary>
    /// <param name="camera">The camera to get the forward vector from.</param>
    /// <returns>The forward vector of the camera.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 GetCameraForward(ref Camera3D camera);

    /// <summary>
    /// Returns the cameras up vector (normalized).
    /// </summary>
    /// <param name="camera">The camera.</param>
    /// <returns>The "up" vector of the camera.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 GetCameraUp(ref Camera3D camera);

    /// <summary>
    /// Returns the cameras right vector (normalized).
    /// </summary>
    /// <param name="camera">The camera to get the right vector from.</param>
    /// <returns>The right vector of the camera.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 GetCameraRight(ref Camera3D camera);

    /// <summary>
    /// Moves the camera in its forward direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera forward.</param>
    /// <param name="moveInWorldPlane">Specifies whether to move the camera in the world plane or camera plane.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CameraMoveForward(ref Camera3D camera, float distance, [MarshalAs(UnmanagedType.I1)] bool moveInWorldPlane);

    /// <summary>
    /// Moves the camera in its up direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera up.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CameraMoveUp(ref Camera3D camera, float distance);

    /// <summary>
    /// Moves the camera target in its current right direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera to the right.</param>
    /// <param name="moveInWorldPlane">Move the camera in world plane coordinates (relative to pivot).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CameraMoveRight(ref Camera3D camera, float distance, [MarshalAs(UnmanagedType.I1)] bool moveInWorldPlane);

    /// <summary>
    /// Moves the camera position closer/farther to/from the camera target.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="delta">The time interval.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CameraMoveToTarget(ref Camera3D camera, float delta);

    /// <summary>
    /// Rotates the camera around its up vector.
    /// </summary>
    /// <param name="camera">The camera to yaw.</param>
    /// <param name="angle">The yaw angle in degrees.</param>
    /// <param name="rotateAroundTarget">If true, the camera will rotate around its target.
    /// If false, it will rotate around its position.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CameraYaw(ref Camera3D camera, float angle, [MarshalAs(UnmanagedType.I1)] bool rotateAroundTarget);

    /// <summary>
    /// Rotates the camera around its right vector, pitch is "looking up and down".
    /// </summary>
    /// <param name="camera">The camera to rotate.</param>
    /// <param name="angle">The angle to rotate. Positive values rotate counterclockwise, negative values rotate clockwise.</param>
    /// <param name="lockView">If set to true, the camera view will remain locked (parallel to the ground) during rotation.</param>
    /// <param name="rotateAroundTarget">If set to true, the camera will rotate around the target according to its position and orientation.</param>
    /// <param name="rotateUp">If set to true, the camera will rotate around the World's up vector instead of its local up vector.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CameraPitch(ref Camera3D camera, float angle, [MarshalAs(UnmanagedType.I1)] bool lockView, [MarshalAs(UnmanagedType.I1)] bool rotateAroundTarget, [MarshalAs(UnmanagedType.I1)] bool rotateUp);

    /// <summary>
    /// Rotates the camera around its forward vector.
    /// </summary>
    /// <param name="camera">The camera to roll.</param>
    /// <param name="angle">The angle in degrees to roll the camera.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CameraRoll(ref Camera3D camera, float angle);

    /// <summary>
    /// Returns the camera view matrix.
    /// </summary>
    /// <param name="camera">The camera to get the view matrix from.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 GetCameraViewMatrix(ref Camera3D camera);

    /// <summary>
    /// Returns the camera projection matrix.
    /// </summary>
    /// <param name="camera">The camera to retrieve the projection matrix from.</param>
    /// <param name="aspect">The aspect ratio of the camera.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 GetCameraProjectionMatrix(ref Camera3D camera, float aspect);

    /// <summary>
    /// Get a ray trace from screen position (i.e mouse).
    /// </summary>
    /// <param name="position">The position in screen space.</param>
    /// <param name="camera">The Camera3D object used for the transformation.</param>
    /// <returns>A Ray object representing the ray from screen space to world space.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Ray GetScreenToWorldRay(Vector2 position, Camera3D camera);

    /// <summary>
    /// Get a ray trace from screen position (i.e mouse) in a viewport.
    /// </summary>
    /// <param name="position">The position in screen space coordinates.</param>
    /// <param name="camera">The camera used to convert the ray from screen space to world space.</param>
    /// <param name="width">The width of the screen.</param>
    /// <param name="height">The height of the screen.</param>
    /// <returns>Returns a <see cref="Ray"/> representing the ray in world space.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Ray GetScreenToWorldRayEx(Vector2 position, Camera3D camera, int width, int height);

    /// <summary>
    /// Get the screen space position for a 3d world space position.
    /// </summary>
    /// <param name="position">The world position to convert.</param>
    /// <param name="camera">The camera to use for the conversion.</param>
    /// <returns>The screen coordinates of the world position.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);

    /// <summary>
    /// Get size position for a 3d world space position.
    /// </summary>
    /// <param name="position">The world-space position.</param>
    /// <param name="camera">The camera3D to use for the conversion.</param>
    /// <param name="width">The width of the screen.</param>
    /// <param name="height">The height of the screen.</param>
    /// <returns>The screen-space coordinates as a Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height);

    /// <summary>
    /// Get camera transform matrix (view matrix).
    /// </summary>
    /// <param name="camera">The camera for which to retrieve the matrix.</param>
    /// <returns>The 4x4 matrix representing the camera's view.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 GetCameraMatrix(Camera3D camera);

    /* --------------------------------- Input --------------------------------- */

    /// <summary>
    /// Shows cursor.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ShowCursor();

    /// <summary>
    /// Hides cursor.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void HideCursor();

    /// <summary>
    /// Check if cursor is not visible.
    /// </summary>
    /// <returns>True if the cursor is hidden, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsCursorHidden();

    /// <summary>
    /// Enables cursor (unlock cursor).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void EnableCursor();

    /// <summary>
    /// Disables cursor (lock cursor).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void DisableCursor();

    /// <summary>
    /// Check if cursor is on the screen.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsCursorOnScreen();

    /// <summary>
    /// Check if a key has been pressed once.
    /// </summary>
    /// <param name="key">The keyboard key to check.</param>
    /// <returns>Returns true if the key is pressed down, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsKeyPressed(KeyboardKey key);

    /// <summary>
    /// Check if a key has been pressed again (Only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>Returns true if the key is being pressed and repeated; otherwise, false</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsKeyPressedRepeat(KeyboardKey key);

    /// <summary>
    /// Check if a key is being pressed.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>True if the key is currently being pressed; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsKeyDown(KeyboardKey key);

    /// <summary>
    /// Check if a key has been released once.
    /// </summary>
    /// <param name="key">The keyboard key to check</param>
    /// <returns>Returns true if the key is released, otherwise false</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsKeyReleased(KeyboardKey key);

    /// <summary>
    /// Check if a key is NOT being pressed.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>A boolean value indicating whether the key is up or not.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsKeyUp(KeyboardKey key);

    /// <summary>
    /// Get key pressed (keycode), call it multiple times for keys queued, returns 0 when the queue is empty.
    /// </summary>
    /// <returns>
    /// The keyboard key being pressed.
    /// </returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetKeyPressed();

    /// <summary>
    /// Get char pressed (unicode), call it multiple times for chars queued, returns 0 when the queue is empty.
    /// </summary>
    /// <returns>The ASCII value of the character that was last pressed in the keyboard.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetCharPressed();

    /// <summary>
    /// Set a custom key to exit program (default is ESC).
    /// </summary>
    /// <param name="key">The keyboard key used as the exit key.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetExitKey(KeyboardKey key);

    /// <summary>
    /// Check if a gamepad is available.
    /// </summary>
    /// <param name="gamepad">The gamepad number.</param>
    /// <returns>True if the gamepad is available, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsGamepadAvailable(int gamepad);

    /// <summary>
    /// Get gamepad internal name id.
    /// </summary>
    /// <param name="gamepad">The index of the gamepad.</param>
    /// <returns>The name of the gamepad.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetGamepadName(int gamepad);

    /// <summary>
    /// Check if a gamepad button has been pressed once.
    /// </summary>
    /// <param name="gamepad">The index of the gamepad.</param>
    /// <param name="button">The gamepad button to check.</param>
    /// <returns>True if the button is currently pressed; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsGamepadButtonPressed(int gamepad, GamepadButton button);

    /// <summary>
    /// Check if a gamepad button is being pressed.
    /// </summary>
    /// <param name="gamepad">The index of the gamepad.</param>
    /// <param name="button">The button to check.</param>
    /// <returns>True if the button is being pressed down, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsGamepadButtonDown(int gamepad, GamepadButton button);

    /// <summary>
    /// Check if a gamepad button has been released once.
    /// </summary>
    /// <param name="gamepad">Gamepad number</param>
    /// <param name="button">Gamepad button</param>
    /// <returns>True if the gamepad button has been released, false otherwise</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsGamepadButtonReleased(int gamepad, GamepadButton button);

    /// <summary>
    /// Check if a gamepad button is NOT being pressed.
    /// </summary>
    /// <param name="gamepad">The gamepad index.</param>
    /// <param name="button">The gamepad button to check.</param>
    /// <returns>Returns true if the gamepad button is not being held down; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsGamepadButtonUp(int gamepad, GamepadButton button);

    /// <summary>
    /// Get the last gamepad button pressed.
    /// </summary>
    /// <returns>True if the button is pressed, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetGamepadButtonPressed();

    /// <summary>
    /// Get gamepad axis count for a gamepad.
    /// </summary>
    /// <param name="gamepad">The gamepad index.</param>
    /// <returns>The number of axis for the specified gamepad.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetGamepadAxisCount(int gamepad);

    /// <summary>
    /// Get axis movement value for a gamepad axis.
    /// </summary>
    /// <param name="gamepad">The gamepad index.</param>
    /// <param name="axis">The axis to retrieve the movement from.</param>
    /// <returns>The movement value of the specified axis. This value ranges between -1.0f and 1.0f.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetGamepadAxisMovement(int gamepad, GamepadAxis axis);

    /// <summary>
    /// Set internal gamepad mappings (SDL_GameControllerDB).
    /// </summary>
    /// <param name="mappings">The gamepad mappings as a string.</param>
    /// <returns>True if the gamepad mappings were set successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int SetGamepadMappings(string mappings);

    /// <summary>
    /// Set gamepad vibration for both motors.
    /// </summary>
    /// <param name="gamepad">The index of the gamepad.</param>
    /// <param name="leftMotor">The intensity of the left motor vibration (0.0f to 1.0f).</param>
    /// <param name="rightMotor">The intensity of the right motor vibration (0.0f to 1.0f).</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetGamepadVibration(int gamepad, float leftMotor, float rightMotor);

    /// <summary>
    /// Check if a mouse button has been pressed once.
    /// </summary>
    /// <param name="button">The button to check for.</param>
    /// <returns>Returns true if the specified mouse button is currently pressed; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsMouseButtonPressed(MouseButton button);

    /// <summary>
    /// Check if a mouse button is being pressed.
    /// </summary>
    /// <param name="button">The mouse button to check.</param>
    /// <returns>True if the mouse button is currently being pressed down; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsMouseButtonDown(MouseButton button);

    /// <summary>
    /// Check if a mouse button has been released once.
    /// </summary>
    /// <param name="button">The mouse button to check</param>
    /// <returns>True if the mouse button was released, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsMouseButtonReleased(MouseButton button);

    /// <summary>
    /// Check if a mouse button is NOT being pressed.
    /// </summary>
    /// <param name="button">The mouse button to check.</param>
    /// <returns>true if the mouse button is up; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsMouseButtonUp(MouseButton button);

    /// <summary>
    /// Get mouse position X.
    /// </summary>
    /// <returns>The x-coordinate of the mouse cursor position.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMouseX();

    /// <summary>
    /// Get mouse position Y.
    /// </summary>
    /// <returns>The Y position of the mouse cursor.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetMouseY();

    /// <summary>
    /// Get mouse position XY.
    /// </summary>
    /// <returns>The current position of the mouse as a <see cref="Vector2"/>.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetMousePosition();

    /// <summary>
    /// Get mouse delta between frames.
    /// </summary>
    /// <returns>The delta of the mouse movement.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetMouseDelta();

    /// <summary>
    /// Set mouse position XY.
    /// </summary>
    /// <param name="x">The x-coordinate of the new mouse position.</param>
    /// <param name="y">The y-coordinate of the new mouse position.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMousePosition(int x, int y);

    /// <summary>
    /// Set mouse offset.
    /// </summary>
    /// <param name="offsetX">The offset on the X-axis.</param>
    /// <param name="offsetY">The offset on the Y-axis.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMouseOffset(int offsetX, int offsetY);

    /// <summary>
    /// Set mouse scaling.
    /// </summary>
    /// <param name="scaleX">The X-axis scale value.</param>
    /// <param name="scaleY">The Y-axis scale value.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMouseScale(float scaleX, float scaleY);

    /// <summary>
    /// Get mouse wheel movement for X or Y, whichever is larger.
    /// </summary>
    /// <returns>The movement of the mouse wheel as a float value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetMouseWheelMove();

    /// <summary>
    /// Get mouse wheel movement for both X and Y.
    /// </summary>
    /// <returns>The vertical movement of the mouse wheel.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetMouseWheelMoveV();

    /// <summary>
    /// Set mouse cursor.
    /// </summary>
    /// <param name="cursor">The cursor type to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMouseCursor(MouseCursor cursor);

    /// <summary>
    /// Get touch position X for touch point 0 (relative to screen size).
    /// </summary>
    /// <returns>The horizontal position of the touch input.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetTouchX();

    /// <summary>
    /// Get touch position Y for touch point 0 (relative to screen size).
    /// </summary>
    /// <returns>The Y position of the touch point.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetTouchY();

    /// <summary>
    /// Get touch position XY for a touch point index (relative to screen size).
    /// </summary>
    /// <param name="index">The index of the touch point.</param>
    /// <returns>The position of the touch point as a Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetTouchPosition(int index);

    /// <summary>
    /// Get touch point identifier for given index.
    /// </summary>
    /// <param name="index">The index of the touch point.</param>
    /// <returns>The touch point ID.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetTouchPointId(int index);

    /// <summary>
    /// Get number of touch points.
    /// </summary>
    /// <returns>The number of touch points currently active on the screen.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetTouchPointCount();

    /// <summary>
    /// Enable a set of gestures using flags.
    /// </summary>
    /// <param name="flags">The bitwise OR of the gestures to enable.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetGesturesEnabled(Gesture flags);

    /// <summary>
    /// Check if a gesture have been detected.
    /// </summary>
    /// <param name="gesture">The gesture to check for detection.</param>
    /// <returns>True if the specified gesture is detected, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsGestureDetected(Gesture gesture);

    /// <summary>
    /// Get latest detected gesture.
    /// </summary>
    /// <returns>The type of gesture detected.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetGestureDetected();

    /// <summary>
    /// Get gesture hold time in milliseconds.
    /// </summary>
    /// <returns>The hold duration of the gesture in seconds.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetGestureHoldDuration();

    /// <summary>
    /// Get gesture drag vector.
    /// </summary>
    /// <returns>The direction vector of the drag gesture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetGestureDragVector();

    /// <summary>
    /// Get gesture drag angle.
    /// </summary>
    /// <returns>The drag angle of the gesture in degrees.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetGestureDragAngle();

    /// <summary>
    /// Get gesture pinch delta.
    /// </summary>
    /// <returns>The pinch gesture vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetGesturePinchVector();

    /// <summary>
    /// Get gesture pinch angle.
    /// </summary>
    /// <returns>The angle of the pinch gesture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetGesturePinchAngle();

    /// <summary>
    /// Register all input events.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PollInputEvents();

    /* --------------------------------- Time --------------------------------- */

    /// <summary>
    /// Set target FPS (maximum).
    /// </summary>
    /// <param name="fps">The desired frames-per-second.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetTargetFPS(int fps);

    /// <summary>
    /// Get time in seconds for last frame drawn (delta time).
    /// </summary>
    /// <returns>The frame time in seconds.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetFrameTime();

    /// <summary>
    /// Get elapsed time in seconds since InitWindow().
    /// </summary>
    /// <returns>The current time in seconds.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial double GetTime();

    /// <summary>
    /// Get current FPS.
    /// </summary>
    /// <returns>The frames-per-second value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetFPS();

    /// <summary>
    /// Wait for some time (halt program execution).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void WaitTime(double seconds);

    /* --------------------------------- Logger --------------------------------- */

    /// <summary>
    /// Sends a log message to the logger with the specified log level and text.
    /// </summary>
    /// <param name="logLevel">The level of the log message.</param>
    /// <param name="text">The text of the log message.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void TraceLog(TraceLogLevel logLevel, string text);

    /// <summary>
    /// Sets the trace log level.
    /// </summary>
    /// <param name="logLevel">The log level to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetTraceLogLevel(TraceLogLevel logLevel);

    /// <summary>
    /// Sets the trace log callback function.
    /// </summary>
    /// <param name="callback">A pointer to an unmanaged function that matches the signature of the callback function.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void SetTraceLogCallback(delegate* unmanaged[Cdecl]<int, nint, nint, void> callback);

    /* --------------------------------- File Manager --------------------------------- */

    /// <summary>
    /// Load file data as byte array (read).
    /// </summary>
    /// <param name="fileName">The name of the file to load the data from.</param>
    /// <param name="dataSize">A pointer to an integer that will store the size of the loaded data.</param>
    /// <returns>A pointer to the loaded data.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial byte* LoadFileData(string fileName, out uint dataSize);

    /// <summary>
    /// Unload file data allocated by LoadFileData().
    /// </summary>
    /// <param name="data">The pointer to the data to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadFileData(byte* data);

    /// <summary>
    /// Save data to file from byte array (write), returns true on success
    /// </summary>
    /// <param name="fileName">The name of the file to save the data to.</param>
    /// <param name="data">A pointer to the data to be saved.</param>
    /// <param name="dataSize">The size of the data in bytes.</param>
    /// <returns>True if the data was saved successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool SaveFileData(string fileName, nint data, uint dataSize);

    /// <summary>
    /// Export data to code (.h), returns true on success.
    /// </summary>
    /// <param name="data">A pointer to the data to be exported.</param>
    /// <param name="dataSize">The size of the data to be exported.</param>
    /// <param name="fileName">The name of the file to save the exported data to.</param>
    /// <returns>True if the data was successfully exported and saved as code, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static unsafe partial bool ExportDataAsCode(byte* data, uint dataSize, string fileName);

    /// <summary>
    /// Load text data from file (read), returns a '\0' terminated string.
    /// </summary>
    /// <param name="fileName">The name of the file to load the data from.</param>
    /// <returns>The loaded text as a string.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string LoadFileText(string fileName);

    /// <summary>
    /// Unload file text data allocated by LoadFileText().
    /// </summary>
    /// <param name="text">The text to unload.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadFileText(string text);

    /// <summary>
    /// Save text data to file (write), string must be '\0' terminated, returns true on success.
    /// </summary>
    /// <param name="fileName">The name of the file to save the text to.</param>
    /// <param name="text">The text to be saved.</param>
    /// <returns>True if the text was saved successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool SaveFileText(string fileName, string text);

    /// <summary>
    /// Check if file exists.
    /// </summary>
    /// <param name="fileName">The name of the file to check.</param>
    /// <returns>Returns true if the file exists; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool FileExists(string fileName);

    /// <summary>
    /// Check if a directory path exists.
    /// </summary>
    /// <param name="dirPath">The path of the directory to check for existence.</param>
    /// <returns>True if the directory exists, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool DirectoryExists(string dirPath);

    /// <summary>
    /// Check file extension (including point: .png, .wav).
    /// </summary>
    /// <param name="fileName">The name of the file to check.</param>
    /// <param name="ext">The extension to check against.</param>
    /// <returns>True if the filename has the specified extension, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsFileExtension(string fileName, string ext);

    /// <summary>
    /// Get file length in bytes (NOTE: GetFileSize() conflicts with windows.h).
    /// </summary>
    /// <param name="fileName">The name of the file to get the length of.</param>
    /// <returns>The length of the file in bytes.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetFileLength(string fileName);

    /// <summary>
    /// Get pointer to extension for a filename string (includes dot: '.png').
    /// </summary>
    /// <param name="fileName">The file name.</param>
    /// <returns>The extension of the file name.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetFileExtension(string fileName);

    /// <summary>
    /// Get pointer to filename for a path string.
    /// </summary>
    /// <param name="filePath">The path of the file.</param>
    /// <returns>The name of the file.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetFileName(string filePath);

    /// <summary>
    /// Get filename string without extension (uses static string).
    /// </summary>
    /// <param name="filePath">The path of the file.</param>
    /// <returns>The file name without the extension.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetFileNameWithoutExt(string filePath);

    /// <summary>
    /// Get full path for a given fileName with path (uses static string).
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns>The directory path.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetDirectoryPath(string filePath);

    /// <summary>
    /// Get previous directory path for a given path (uses static string).
    /// </summary>
    /// <param name="dirPath">The directory path.</param>
    /// <returns>The previous directory path.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetPrevDirectoryPath(string dirPath);

    /// <summary>
    /// Get current working directory (uses static string).
    /// </summary>
    /// <returns>The current working directory.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetWorkingDirectory();

    /// <summary>
    /// Get the directory of the running application (uses static string).
    /// </summary>
    /// <returns>The application directory.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string GetApplicationDirectory();

    /// <summary>
    /// Change working directory, return true on success.
    /// </summary>
    /// <param name="dir">The path to the new directory.</param>
    /// <returns>True if the directory was changed successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ChangeDirectory(string dir);

    /// <summary>
    /// Check if a given path is a file or a directory.
    /// </summary>
    /// <param name="path">The path to check.</param>
    /// <returns>Returns true if the given path is a file, otherwise false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsPathFile(string path);

    /// <summary>
    /// Checks if the given file name is valid.
    /// </summary>
    /// <param name="fileName">The file name to be checked.</param>
    /// <returns>Returns true if the file name is valid; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsFileNameValid(string fileName);

    /// <summary>
    /// Load directory filepaths.
    /// </summary>
    /// <param name="dirPath">The path to the directory to load files from.</param>
    /// <returns>A list of file paths in the directory.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial FilePathList LoadDirectoryFiles(string dirPath);

    /// <summary>
    /// Load directory filepaths with extension filtering and recursive directory scan.
    /// </summary>
    /// <param name="basePath">The base path of the directory to load files from.</param>
    /// <param name="filter">The filter used to match the file names.</param>
    /// <param name="scanSubDirs">Determines whether to scan subdirectories.</param>
    /// <returns>A list of file paths.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial FilePathList LoadDirectoryFilesEx(string basePath, string filter, [MarshalAs(UnmanagedType.I1)] bool scanSubDirs);

    /// <summary>
    /// Unload filepaths.
    /// </summary>
    /// <param name="files">The list of file paths in the directory.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadDirectoryFiles(FilePathList files);

    /// <summary>
    /// Check if a file has been dropped into window.
    /// </summary>
    /// <returns>True if a file has been dropped, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsFileDropped();

    /// <summary>
    /// Load dropped filepaths.
    /// </summary>
    /// <returns>A list of file paths.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial FilePathList LoadDroppedFiles();

    /// <summary>
    /// Unload dropped filepaths.
    /// </summary>
    /// <param name="files">The list of dropped files to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadDroppedFiles(FilePathList files);

    /// <summary>
    /// Get file modification time (last write time).
    /// </summary>
    /// <param name="fileName">The name of the file to get the modification time from.</param>
    /// <returns>The last modification time of the file as a Unix timestamp.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial long GetFileModTime(string fileName);

    /// <summary>
    /// Compress data (DEFLATE algorithm), memory must be MemFree().
    /// </summary>
    /// <param name="data">A pointer to the data to compress.</param>
    /// <param name="dataSize">The size of the data to compress.</param>
    /// <param name="compDataSize">A pointer to an integer that will store the size of the compressed data.</param>
    /// <returns>A pointer to the compressed data.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial byte* CompressData(byte* data, int dataSize, out int compDataSize);

    /// <summary>
    /// Decompress data (DEFLATE algorithm), memory must be MemFree().
    /// </summary>
    /// <param name="compData">The pointer to the compressed data.</param>
    /// <param name="compDataSize">The size of the compressed data.</param>
    /// <param name="dataSize">A pointer to an integer that will store the size of the decompressed data.</param>
    /// <returns>A pointer to the decompressed data.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial byte* DecompressData(byte* compData, int compDataSize, out int dataSize);

    /// <summary>
    /// Encode data to Base64 string, memory must be MemFree().
    /// </summary>
    /// <param name="data">A pointer to the data to encode.</param>
    /// <param name="dataSize">The size of the data to encode.</param>
    /// <param name="outputSize">A pointer to an integer that will store the size of the encoded data.</param>
    /// <returns>A base64 encoded string.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static unsafe partial string EncodeDataBase64(byte* data, int dataSize, out int outputSize);

    /// <summary>
    /// Decode Base64 string data, memory must be MemFree().
    /// </summary>
    /// <param name="data">A pointer to the base64 encoded byte array.</param>
    /// <param name="outputSize">A pointer to an integer that will store the size of the decoded byte array.</param>
    /// <returns>A pointer to the decoded byte array.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial byte* DecodeDataBase64(byte* data, out int outputSize);

    /* --------------------------------- Automation Event --------------------------------- */

    /// <summary>
    /// Set automation event internal base frame to start recording.
    /// </summary>
    /// <param name="frame">The base frame to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetAutomationEventBaseFrame(int frame);

    /// <summary>
    /// Start recording automation events (AutomationEventList must be set).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void StartAutomationEventRecording();

    /// <summary>
    /// Stop recording automation events.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void StopAutomationEventRecording();

    /// <summary>
    /// Play a recorded automation event.
    /// </summary>
    /// <param name="automationEvent">The automation event to play.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PlayAutomationEvent(AutomationEvent automationEvent);

    /* --------------------------------- Automation Event List --------------------------------- */

    /// <summary>
    /// Load automation events list from file, NULL for empty list, capacity = MAX_AUTOMATION_EVENTS.
    /// </summary>
    /// <param name="fileName">The name of the file to load the AutomationEventList from.</param>
    /// <returns>The loaded AutomationEventList.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial AutomationEventList LoadAutomationEventList(string fileName);

    /// <summary>
    /// Unload automation events list from file.
    /// </summary>
    /// <param name="list">The AutomationEventList to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadAutomationEventList(AutomationEventList list);

    /// <summary>
    /// Export automation events list as text file.
    /// </summary>
    /// <param name="list">The AutomationEventList to export.</param>
    /// <param name="fileName">The name of the file to export the AutomationEventList to.</param>
    /// <returns>Returns true if the export was successful; otherwise, returns false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportAutomationEventList(AutomationEventList list, string fileName);

    /// <summary>
    /// Set automation event list to record to.
    /// </summary>
    /// <param name="list">The AutomationEventList to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetAutomationEventList(ref AutomationEventList list);

    /* --------------------------------- Audio Device --------------------------------- */

    /// <summary>
    /// Initialize audio device and context.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void InitAudioDevice();

    /// <summary>
    /// Close the audio device and context.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void CloseAudioDevice();

    /// <summary>
    /// Check if audio device has been initialized successfully.
    /// </summary>
    /// <returns>Returns true if the audio device is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsAudioDeviceReady();

    /// <summary>
    /// Set master volume (listener).
    /// </summary>
    /// <param name="volume">The volume value.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMasterVolume(float volume);

    /// <summary>
    /// Get master volume (listener).
    /// </summary>
    /// <returns>The master volume of the audio device.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetMasterVolume();

    /* --------------------------------- Wave --------------------------------- */

    /// <summary>
    /// Load wave data from file.
    /// </summary>
    /// <param name="fileName">File name to load wave data from</param>
    /// <returns>Wave structure containing loaded data</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Wave LoadWave(string fileName);

    /// <summary>
    /// Load wave from memory buffer, fileType refers to extension: i.e. '.wav'.
    /// </summary>
    /// <param name="fileType">Type of the file containing wave data</param>
    /// <param name="fileData">Pointer to the memory block containing wave data</param>
    /// <param name="dataSize">Size of the memory block in bytes</param>
    /// <returns>Wave structure containing loaded data</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Wave LoadWaveFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Unload samples data loaded with LoadWaveSamples().
    /// </summary>
    /// <param name="samples">Pointer to the samples data</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadWaveSamples(float* samples);

    /// <summary>
    /// Checks if wave data is ready.
    /// </summary>
    /// <param name="wave">The wave structure to check.</param>
    /// <returns>True if the wave data is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsWaveReady(Wave wave);

    /// <summary>
    /// Unload wave data.
    /// </summary>
    /// <param name="wave">Wave structure to unload</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadWave(Wave wave);

    /// <summary>
    /// Export wave data to file, returns true on success.
    /// </summary>
    /// <param name="wave">Wave structure containing data to be exported</param>
    /// <param name="fileName">File name to export wave data to</param>
    /// <returns>True if wave data was successfully exported, false otherwise</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportWave(Wave wave, string fileName);

    /// <summary>
    /// Export wave sample data to code (.h), returns true on success.
    /// </summary>
    /// <param name="wave">Wave structure containing the data to be exported as code</param>
    /// <param name="fileName">File name to save the exported code</param>
    /// <returns>True if the wave data was successfully exported as code, false otherwise</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportWaveAsCode(Wave wave, string fileName);

    /// <summary>
    /// Copy a wave to a new wave.
    /// </summary>
    /// <param name="wave">The Wave structure to be copied.</param>
    /// <returns>A new Wave structure that is a copy of the original.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Wave WaveCopy(Wave wave);

    /// <summary>
    /// Crop a wave to defined frames range.
    /// </summary>
    /// <param name="wave">The wave to crop</param>
    /// <param name="initFrame">The initial sample to start cropping from</param>
    /// <param name="finalFrame">The final sample to end cropping at</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void WaveCrop(ref Wave wave, int initFrame, int finalFrame);

    /// <summary>
    /// Convert wave data to desired format.
    /// </summary>
    /// <param name="wave">The wave structure to format</param>
    /// <param name="sampleRate">The sample rate of the wave</param>
    /// <param name="sampleSize">The sample size of the wave</param>
    /// <param name="channels">The number of channels of the wave</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void WaveFormat(ref Wave wave, int sampleRate, int sampleSize, int channels);

    /// <summary>
    /// Load samples data from wave as a 32bit float data array.
    /// </summary>
    /// <param name="wave">The wave data to load the samples from.</param>
    /// <returns>A pointer to the loaded samples.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial float* LoadWaveSamples(Wave wave);

    /* --------------------------------- Sound --------------------------------- */

    /// <summary>
    /// Load sound from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load the sound from.</param>
    /// <returns>The loaded sound.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Sound LoadSound(string fileName);

    /// <summary>
    /// Load sound from wave data.
    /// </summary>
    /// <param name="wave">The wave to load the sound from.</param>
    /// <returns>The loaded sound.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Sound LoadSoundFromWave(Wave wave);

    /// <summary>
    /// Create a new sound that shares the same sample data as the source sound, does not own the sound data.
    /// </summary>
    /// <param name="source">The source sound.</param>
    /// <returns>The loaded sound alias.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Sound LoadSoundAlias(Sound source);

    /// <summary>
    /// Checks if a sound is ready.
    /// </summary>
    /// <param name="sound">The sound to check.</param>
    /// <returns>True if the sound is ready to be played, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsSoundReady(Sound sound);

    /// <summary>
    /// Update sound buffer with new data.
    /// </summary>
    /// <param name="sound">The sound to update.</param>
    /// <param name="data">A pointer to the new sample data buffer.</param>
    /// <param name="sampleCount">The number of samples in the buffer.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateSound(Sound sound, nint data, int sampleCount);

    /// <summary>
    /// Unload sound.
    /// </summary>
    /// <param name="sound">The sound to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadSound(Sound sound);

    /// <summary>
    /// Unload a sound alias (does not deallocate sample data).
    /// </summary>
    /// <param name="alias">The sound alias to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadSoundAlias(Sound alias);

    /// <summary>
    /// Play a sound.
    /// </summary>
    /// <param name="sound">The sound to be played.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PlaySound(Sound sound);

    /// <summary>
    /// Stop playing a sound.
    /// </summary>
    /// <param name="sound">The sound to stop.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void StopSound(Sound sound);

    /// <summary>
    /// Pause a sound.
    /// </summary>
    /// <param name="sound">The sound to pause.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PauseSound(Sound sound);

    /// <summary>
    /// Resume a paused sound.
    /// </summary>
    /// <param name="sound">The sound to resume.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ResumeSound(Sound sound);

    /// <summary>
    /// Check if a sound is currently playing.
    /// </summary>
    /// <param name="sound">The sound to check for playing status.</param>
    /// <returns>True if the sound is currently playing, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsSoundPlaying(Sound sound);

    /// <summary>
    /// Set volume for a sound (1.0 is max level).
    /// </summary>
    /// <param name="sound">The sound to set the volume for.</param>
    /// <param name="volume">The volume value. Range is 0.0F to 1.0F.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetSoundVolume(Sound sound, float volume);

    /// <summary>
    /// Set pitch for a sound (1.0 is base level).
    /// </summary>
    /// <param name="sound">The sound to set the pitch for.</param>
    /// <param name="pitch">The pitch value to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetSoundPitch(Sound sound, float pitch);

    /// <summary>
    /// Set pan for a sound (0.5 is center).
    /// </summary>
    /// <param name="sound">The sound to set the pan value for.</param>
    /// <param name="pan">The pan value to set, range -1.0F (left) to 1.0F (right), 0.0F for both center.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetSoundPan(Sound sound, float pan);

    /* --------------------------------- Music --------------------------------- */

    /// <summary>
    /// Load music stream from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load the music from.</param>
    /// <returns>The loaded music stream.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Music LoadMusicStream(string fileName);

    /// <summary>
    /// Load music stream from data.
    /// </summary>
    /// <param name="fileType">The file type of the music.</param>
    /// <param name="data">A pointer to the memory containing the music data.</param>
    /// <param name="dataSize">The size of the music data in bytes.</param>
    /// <returns>The loaded music stream.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Music LoadMusicStreamFromMemory(string fileType, byte* data, int dataSize);

    /// <summary>
    /// Checks if a music stream is ready.
    /// </summary>
    /// <param name="music">The music stream to check.</param>
    /// <returns>True if the music stream is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsMusicReady(Music music);

    /// <summary>
    /// Unload music stream.
    /// </summary>
    /// <param name="music">The music stream to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadMusicStream(Music music);

    /// <summary>
    /// Start music playing.
    /// </summary>
    /// <param name="music">The music stream to play.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PlayMusicStream(Music music);

    /// <summary>
    /// Check if music is playing.
    /// </summary>
    /// <param name="music">The music stream to check.</param>
    /// <returns>Returns true if the music stream is currently playing; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsMusicStreamPlaying(Music music);

    /// <summary>
    /// Updates buffers for music streaming.
    /// </summary>
    /// <param name="music">The music stream to update.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateMusicStream(Music music);

    /// <summary>
    /// Stop music playing.
    /// </summary>
    /// <param name="music">The music stream to stop.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void StopMusicStream(Music music);

    /// <summary>
    /// Pause music playing.
    /// </summary>
    /// <param name="music">The music stream to pause.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PauseMusicStream(Music music);

    /// <summary>
    /// Resume playing paused music.
    /// </summary>
    /// <param name="music">The music stream to resume.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ResumeMusicStream(Music music);

    /// <summary>
    /// Seek music to a position (in seconds).
    /// </summary>
    /// <param name="music">The music stream to seek.</param>
    /// <param name="position">The new position of the music stream.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SeekMusicStream(Music music, float position);

    /// <summary>
    /// Set volume for music (1.0 is max level).
    /// </summary>
    /// <param name="music">The music stream to set the volume for.</param>
    /// <param name="volume">The desired volume, ranging from 0.0f (silence) to 1.0f (full volume).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMusicVolume(Music music, float volume);

    /// <summary>
    /// Set pitch for a music (1.0 is base level).
    /// </summary>
    /// <param name="music">The music stream to set the pitch for.</param>
    /// <param name="pitch">The new pitch value to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMusicPitch(Music music, float pitch);

    /// <summary>
    /// Set pan for a music (0.5 is center).
    /// </summary>
    /// <param name="music">The music stream.</param>
    /// <param name="pan">The panning effect value (-1.0f to 1.0f).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetMusicPan(Music music, float pan);

    /// <summary>
    /// Get music time length (in seconds).
    /// </summary>
    /// <param name="music">The music stream to get the length of.</param>
    /// <returns>The length of the music stream in seconds.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetMusicTimeLength(Music music);

    /// <summary>
    /// Get current music time played (in seconds).
    /// </summary>
    /// <param name="music">The music stream to get the time played from.</param>
    /// <returns>The time played of the music stream.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float GetMusicTimePlayed(Music music);

    /* --------------------------------- Audio Stream --------------------------------- */

    /// <summary>
    /// Load audio stream (to stream raw audio pcm data).
    /// </summary>
    /// <param name="sampleRate">The sample rate of the audio stream.</param>
    /// <param name="sampleSize">The sample size of the audio stream.</param>
    /// <param name="channels">The number of channels in the audio stream.</param>
    /// <returns>The loaded audio stream.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial AudioStream LoadAudioStream(uint sampleRate, uint sampleSize, uint channels);

    /// <summary>
    /// Default size for new audio streams.
    /// </summary>
    /// <param name="size">The size of the audio stream buffer in bytes.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetAudioStreamBufferSizeDefault(int size);

    /// <summary>
    /// Audio thread callback to request new data.
    /// </summary>
    /// <param name="stream">The audio stream to set the callback for.</param>
    /// <param name="callback">The callback function pointer.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void SetAudioStreamCallback(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> callback);

    /// <summary>
    /// Attach audio stream processor to stream, receives the samples as 'float'.
    /// </summary>
    /// <param name="stream">The audio stream to attach the processor to.</param>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void AttachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> processor);

    /// <summary>
    /// Detach audio stream processor from stream.
    /// </summary>
    /// <param name="stream">The audio stream.</param>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DetachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> processor);

    /// <summary>
    /// Attach audio stream processor to the entire audio pipeline, receives the samples as 'float'.
    /// </summary>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void AttachAudioMixedProcessor(delegate* unmanaged[Cdecl]<nint, uint, void> processor);

    /// <summary>
    /// Detach audio stream processor from the entire audio pipeline.
    /// </summary>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void DetachAudioMixedProcessor(delegate* unmanaged[Cdecl]<nint, uint, void> processor);

    /// <summary>
    /// Checks if an audio stream is ready.
    /// </summary>
    /// <param name="stream">The audio stream to check.</param>
    /// <returns>True if the audio stream is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsAudioStreamReady(AudioStream stream);

    /// <summary>
    /// Unload audio stream and free memory.
    /// </summary>
    /// <param name="stream">The audio stream to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadAudioStream(AudioStream stream);

    /// <summary>
    /// Update audio stream buffers with data.
    /// </summary>
    /// <param name="stream">The audio stream to update.</param>
    /// <param name="data">Pointer to the new audio data.</param>
    /// <param name="frameCount">The number of frames in the new audio data.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateAudioStream(AudioStream stream, nint data, int frameCount);

    /// <summary>
    /// Check if any audio stream buffers requires refill.
    /// </summary>
    /// <param name="stream">The audio stream to check.</param>
    /// <returns>Returns true if the audio stream has been fully processed, otherwise returns false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsAudioStreamProcessed(AudioStream stream);

    /// <summary>
    /// Play audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to play.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PlayAudioStream(AudioStream stream);

    /// <summary>
    /// Pause audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to pause.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void PauseAudioStream(AudioStream stream);

    /// <summary>
    /// Resume audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to resume.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ResumeAudioStream(AudioStream stream);

    /// <summary>
    /// Check if audio stream is playing.
    /// </summary>
    /// <param name="stream">The audio stream to check.</param>
    /// <returns>True if the audio stream is playing, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsAudioStreamPlaying(AudioStream stream);

    /// <summary>
    /// Stop audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to stop.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void StopAudioStream(AudioStream stream);

    /// <summary>
    /// Set volume for audio stream (1.0 is max level).
    /// </summary>
    /// <param name="stream">The audio stream to set the volume for.</param>
    /// <param name="volume">The volume value to set (range 0.0f to 1.0f).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetAudioStreamVolume(AudioStream stream, float volume);

    /// <summary>
    /// Set pitch for audio stream (1.0 is base level).
    /// </summary>
    /// <param name="stream">The audio stream to set the pitch for.</param>
    /// <param name="pitch">The desired pitch value. Range is [-1.0f, 1.0f], with 0.0f being unchanged pitch.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetAudioStreamPitch(AudioStream stream, float pitch);

    /// <summary>
    /// Set pan for audio stream (0.5 is centered).
    /// </summary>
    /// <param name="stream">The audio stream.</param>
    /// <param name="pan">The pan value. Pan value should be between -1.0 (fully left) and 1.0 (fully right).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetAudioStreamPan(AudioStream stream, float pan);

    /* --------------------------------- Shape Helper --------------------------------- */

    /// <summary>
    /// Set texture and rectangle to be used on shapes drawing.
    /// </summary>
    /// <param name="texture">The texture to set.</param>
    /// <param name="source">The source rectangle of the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetShapesTexture(Texture2D texture, Rectangle source);

    /// <summary>
    /// Get texture that is used for shapes drawing.
    /// </summary>
    /// <returns>The Texture2D object representing the texture for shapes.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Texture2D GetShapesTexture();

    /// <summary>
    /// Get texture source rectangle that is used for shapes drawing.
    /// </summary>
    /// <returns>A Rectangle structure representing the rectangle of the current texture used for shapes rendering.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Rectangle GetShapesTextureRectangle();

    /// <summary>
    /// Get (evaluate) spline point: Linear.
    /// </summary>
    /// <param name="startPos">The start position of the spline.</param>
    /// <param name="endPos">The end position of the spline.</param>
    /// <param name="t">The time value between 0 and 1.</param>
    /// <returns>The point on the linear spline.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetSplinePointLinear(Vector2 startPos, Vector2 endPos, float t);

    /// <summary>
    /// Get (evaluate) spline point: B-Spline.
    /// </summary>
    /// <param name="p1">The first control point of the spline curve.</param>
    /// <param name="p2">The second control point of the spline curve.</param>
    /// <param name="p3">The third control point of the spline curve.</param>
    /// <param name="p4">The fourth control point of the spline curve.</param>
    /// <param name="t">The parameter value for the point on the spline curve (range from 0 to 1).</param>
    /// <returns>The basis function value for the point on the spline curve.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetSplinePointBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// Get (evaluate) spline point: Catmull-Rom.
    /// </summary>
    /// <param name="p1">The first control point.</param>
    /// <param name="p2">The second control point.</param>
    /// <param name="p3">The third control point.</param>
    /// <param name="p4">The fourth control point.</param>
    /// <param name="t">The t-value between 0 and 1.</param>
    /// <returns>The calculated point on the Catmull-Rom spline.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetSplinePointCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// Get (evaluate) spline point: Quadratic Bezier.
    /// </summary>
    /// <param name="p1">The start point of the curve.</param>
    /// <param name="c2">The control point of the curve.</param>
    /// <param name="p3">The end point of the curve.</param>
    /// <param name="t">The t value represents position on the curve. It should be between 0 and 1.</param>
    /// <returns>The calculated point on the curve.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetSplinePointBezierQuad(Vector2 p1, Vector2 c2, Vector2 p3, float t);

    /// <summary>
    /// Get (evaluate) spline point: Cubic Bezier.
    /// </summary>
    /// <param name="p1">The starting point of the spline.</param>
    /// <param name="c2">The second control point of the spline.</param>
    /// <param name="c3">The third control point of the spline.</param>
    /// <param name="p4">The ending point of the spline.</param>
    /// <param name="t">The time parameter for interpolation, between 0 and 1.</param>
    /// <returns>The calculated point on the spline.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 GetSplinePointBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float t);

    /// <summary>
    /// Check collision between two rectangles.
    /// </summary>
    /// <param name="rec1">The first rectangle.</param>
    /// <param name="rec2">The second rectangle.</param>
    /// <returns>True if the rectangles are colliding, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionRecs(Rectangle rec1, Rectangle rec2);

    /// <summary>
    /// Check collision between two circles.
    /// </summary>
    /// <param name="center1">The center of the first circle.</param>
    /// <param name="radius1">The radius of the first circle.</param>
    /// <param name="center2">The center of the second circle.</param>
    /// <param name="radius2">The radius of the second circle.</param>
    /// <returns>True if the circles collide, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);

    /// <summary>
    /// Check collision between circle and rectangle.
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="rec">The rectangle to check collision with.</param>
    /// <returns>True if there is a collision, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionCircleRec(Vector2 center, float radius, Rectangle rec);

    /// <summary>
    /// Check if point is inside rectangle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="rec">The rectangle to check against.</param>
    /// <returns>True if the point is inside the rectangle, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionPointRec(Vector2 point, Rectangle rec);

    /// <summary>
    /// Check if point is inside circle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <returns>True if the point is inside the circle, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);

    /// <summary>
    /// Check if point is inside a triangle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="p1">The first vertex of the triangle.</param>
    /// <param name="p2">The second vertex of the triangle.</param>
    /// <param name="p3">The third vertex of the triangle.</param>
    /// <returns>True if the point is inside the triangle; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);

    /// <summary>
    /// Check if point is within a polygon described by array of vertices.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="points">An array of points that define the vertices of the polygon.</param>
    /// <param name="pointCount">The number of points in the array.</param>
    /// <returns>True if the point is inside the polygon, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static unsafe partial bool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount);

    /// <summary>
    /// Check the collision between two lines defined by two points each, returns collision point by reference.
    /// </summary>
    /// <param name="startPos1">The start position of the first line.</param>
    /// <param name="endPos1">The end position of the first line.</param>
    /// <param name="startPos2">The start position of the second line.</param>
    /// <param name="endPos2">The end position of the second line.</param>
    /// <param name="collisionPoint">Return the intersection point if lines intersect, otherwise returns null.</param>
    /// <returns>Returns true if the lines intersect, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, ref Vector2 collisionPoint);

    /// <summary>
    /// Check if point belongs to line created between two points [p1] and [p2] with defined margin in pixels [threshold].
    /// </summary>
    /// <param name="point">The point to check for collision.</param>
    /// <param name="p1">The starting point of the line segment.</param>
    /// <param name="p2">The ending point of the line segment.</param>
    /// <param name="threshold">The threshold value for collision.</param>
    /// <returns>Returns true if the point collides with the line segment within the threshold, otherwise returns false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);

    /// <summary>
    /// Check if circle collides with a line created betweeen two points [p1] and [p2].
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="p1">The starting point of the line segment.</param>
    /// <param name="p2">The ending point of the line segment.</param>
    /// <returns>True if the circle and line segment intersect, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionCircleLine(Vector2 center, float radius, Vector2 p1, Vector2 p2);

    /// <summary>
    /// Get collision rectangle for two rectangles collision.
    /// </summary>
    /// <param name="rec1">The first rectangle.</param>
    /// <param name="rec2">The second rectangle.</param>
    /// <returns>The collision rectangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Rectangle GetCollisionRec(Rectangle rec1, Rectangle rec2);

    /* --------------------------------- Image --------------------------------- */

    /// <summary>
    /// Load image from file into CPU memory (RAM).
    /// </summary>
    /// <param name="fileName">The name of the file to load the image from.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image LoadImage(string fileName);

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
    internal static partial Image LoadImageRaw(string fileName, int width, int height, PixelFormat format, int headerSize);

    /// <summary>
    /// Load image from SVG file data or string with specified size.
    /// </summary>
    /// <param name="fileNameOrString">The name of the file or the SVG string to load the image from.</param>
    /// <param name="width">The desired width of the image.</param>
    /// <param name="height">The desired height of the image.</param>
    /// <returns>The loaded SVG image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image LoadImageSvg(string fileNameOrString, int width, int height);

    /// <summary>
    /// Load image sequence from file (frames appended to image.data).
    /// </summary>
    /// <param name="fileNameOrString">The name of the file or string to load the image as animation from.</param>
    /// <param name="frames">Number of frames loaded.</param>
    /// <returns>The loaded image as animation.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image LoadImageAnim(string fileNameOrString, out int frames);

    /// <summary>
    /// Load animated image data.
    /// </summary>
    /// <param name="fileType">The type of the image file (e.g., "png", "jpg", "gif").</param>
    /// <param name="fileData">A pointer to the image file data in memory.</param>
    /// <param name="dataSize">The size of the image file data in bytes.</param>
    /// <param name="frames">The number of frames in the loaded animated image.</param>
    /// <returns>An Image struct representing the loaded animated image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Image LoadImageAnimFromMemory(string fileType, byte* fileData, int dataSize, out int frames);

    /// <summary>
    /// Load image from memory buffer, fileType refers to extension: i.e. '.png'.
    /// </summary>
    /// <param name="fileType">The type of the file to load the image from.</param>
    /// <param name="fileData">The data of the file to load the image from.</param>
    /// <param name="dataSize">The size of the file data.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Image LoadImageFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Load image from GPU texture data.
    /// </summary>
    /// <param name="texture">The texture to load the image from.</param>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image LoadImageFromTexture(Texture2D texture);

    /// <summary>
    /// Load image from screen buffer and (screenshot).
    /// </summary>
    /// <returns>The loaded image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image LoadImageFromScreen();

    /// <summary>
    /// Generate image: plain color.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="color">The color to fill the image with.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image GenImageColor(int width, int height, Color color);

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
    internal static partial Image GenImageGradientLinear(int width, int height, int direction, Color start, Color end);

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
    internal static partial Image GenImageGradientRadial(int width, int height, float density, Color inner, Color outer);

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
    internal static partial Image GenImageGradientSquare(int width, int height, float density, Color inner, Color outer);

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
    internal static partial Image GenImageChecked(int width, int height, int checksX, int checksY, Color col1, Color col2);

    /// <summary>
    /// Generate image: white noise.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="factor">The factor to control the intensity of the noise. Value should be between 0 and 1. A lower value generates less intense noise.</param>
    /// <returns>A generated white noise image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image GenImageWhiteNoise(int width, int height, float factor);

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
    internal static partial Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

    /// <summary>
    /// Generate image: cellular algorithm, bigger tileSize means bigger cells.
    /// </summary>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    /// <param name="tileSize">The size of each tile in the image.</param>
    /// <returns>A cellular algorithm generated image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image GenImageCellular(int width, int height, int tileSize);

    /// <summary>
    /// Generate image: grayscale image from text data.
    /// </summary>
    /// <param name="width">The width of the generated image.</param>
    /// <param name="height">The height of the generated image.</param>
    /// <param name="text">The text to be converted into an image.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image GenImageText(int width, int height, string text);

    /// <summary>
    /// Create an image from text (default font).
    /// </summary>
    /// <param name="text">The text to be rendered on the image.</param>
    /// <param name="fontSize">The font size to be used for the text.</param>
    /// <param name="color">The color of the text.</param>
    /// <returns>The generated image.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image ImageText(string text, int fontSize, Color color);

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
    internal static partial Image ImageTextEx(Font font, string text, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Create an image from a selected channel of another image (GRAYSCALE).
    /// </summary>
    /// <param name="image">The input Image.</param>
    /// <param name="selectedChannel">The index of the channel to extract (0 for red, 1 for green, 2 for blue, 3 for alpha).</param>
    /// <returns>The Image containing only the selected channel.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image ImageFromChannel(Image image, int selectedChannel);

    /// <summary>
    /// Unload color data loaded with LoadImageColors().
    /// </summary>
    /// <param name="colors">Pointer to the colors of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadImageColors(Color* colors);

    /// <summary>
    /// Unload colors palette loaded with LoadImagePalette().
    /// </summary>
    /// <param name="colors">A pointer to the colors representing the palette.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadImagePalette(Color* colors);

    /// <summary>
    /// Check if an image is ready.
    /// </summary>
    /// <param name="image">The image to check.</param>
    /// <returns>True if the image is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsImageReady(Image image);

    /// <summary>
    /// Unload image from CPU memory (RAM).
    /// </summary>
    /// <param name="image">The image to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadImage(Image image);

    /// <summary>
    /// Export image data to file, returns true on success.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileName">The name of the file to export the image to.</param>
    /// <returns>Returns true if the image was exported successfully, otherwise false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportImage(Image image, string fileName);

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
    internal static partial string ExportImageToMemory(Image image, string fileType, out int fileSize);

    /// <summary>
    /// Export image as code file defining an array of bytes, returns true on success.
    /// </summary>
    /// <param name="image">The image to export.</param>
    /// <param name="fileName">The name of the file to export the image to.</param>
    /// <returns>True if the image is successfully exported as code, otherwise false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportImageAsCode(Image image, string fileName);

    /// <summary>
    /// Create an image duplicate (useful for transformations).
    /// </summary>
    /// <param name="image">The Image to be copied.</param>
    /// <returns>A new Image object that is a copy of the input Image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image ImageCopy(Image image);

    /// <summary>
    /// Create an image from another image piece.
    /// </summary>
    /// <param name="image">The source image to copy from.</param>
    /// <param name="rec">The rectangle defining the sub-region to be copied.</param>
    /// <returns>The new image containing the copied sub-rectangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Image ImageFromImage(Image image, Rectangle rec);

    /// <summary>
    /// Convert image data to desired format.
    /// </summary>
    /// <param name="image">The image to change the pixel format of.</param>
    /// <param name="newFormat">The new pixel format to apply to the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageFormat(ref Image image, PixelFormat newFormat);

    /// <summary>
    /// Convert image to POT (power-of-two).
    /// </summary>
    /// <param name="image">The image to resize and fill.</param>
    /// <param name="fill">The color to fill the resized image with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageToPOT(ref Image image, Color fill);

    /// <summary>
    /// Crop an image to a defined rectangle.
    /// </summary>
    /// <param name="image">The image to crop.</param>
    /// <param name="crop">The rectangle defining the portion to crop.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageCrop(ref Image image, Rectangle crop);

    /// <summary>
    /// Crop image depending on alpha value.
    /// </summary>
    /// <param name="image">The image to crop.</param>
    /// <param name="threshold">The alpha threshold used for cropping.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageAlphaCrop(ref Image image, float threshold);

    /// <summary>
    /// Clear alpha channel to desired color.
    /// </summary>
    /// <param name="image">The image to clear the alpha channel of.</param>
    /// <param name="color">The color to set the alpha channel to.</param>
    /// <param name="threshold">The threshold value for determining which pixels to clear the alpha channel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageAlphaClear(ref Image image, Color color, float threshold);

    /// <summary>
    /// Apply alpha mask to image.
    /// </summary>
    /// <param name="image">The image to apply the alpha mask to.</param>
    /// <param name="alphaMask">The image to be used as the alpha mask.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageAlphaMask(ref Image image, Image alphaMask);

    /// <summary>
    /// Premultiply alpha channel.
    /// </summary>
    /// <param name="image">The image to modify.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageAlphaPremultiply(ref Image image);

    /// <summary>
    /// Apply Gaussian blur using a box blur approximation.
    /// </summary>
    /// <param name="image">The image to apply the blur effect to.</param>
    /// <param name="blurSize">The size of the blur effect.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageBlurGaussian(ref Image image, int blurSize);

    /// <summary>
    /// Apply custom square convolution kernel to image.
    /// </summary>
    /// <param name="image">The Image to be convoluted.</param>
    /// <param name="kernel">The kernel to be used in the convolution.</param>
    /// <param name="kernelSize">The size of the kernel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void ImageKernelConvolution(ref Image image, float* kernel, int kernelSize);

    /// <summary>
    /// Resize image (Bicubic scaling algorithm).
    /// </summary>
    /// <param name="image">The image to resize.</param>
    /// <param name="newWidth">The new width of the image.</param>
    /// <param name="newHeight">The new height of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageResize(ref Image image, int newWidth, int newHeight);

    /// <summary>
    /// Resize image (Nearest-Neighbor scaling algorithm).
    /// </summary>
    /// <param name="image">The image to be resized.</param>
    /// <param name="newWidth">The new width of the image.</param>
    /// <param name="newHeight">The new height of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageResizeNN(ref Image image, int newWidth, int newHeight);

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
    internal static partial void ImageResizeCanvas(ref Image image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);

    /// <summary>
    /// Compute all mipmap levels for a provided image.
    /// </summary>
    /// <param name="image">The image to generate mipmaps for.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageMipmaps(ref Image image);

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
    internal static partial void ImageDither(ref Image image, int rBpp, int gBpp, int bBpp, int aBpp);

    /// <summary>
    /// Flip image vertically.
    /// </summary>
    /// <param name="image">The image to be flipped.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageFlipVertical(ref Image image);

    /// <summary>
    /// Flip image horizontally.
    /// </summary>
    /// <param name="image">The image to flip.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageFlipHorizontal(ref Image image);

    /// <summary>
    /// Rotate image by input angle in degrees (-359 to 359).
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    /// <param name="degrees">The number of degrees to rotate the image by.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageRotate(ref Image image, int degrees);

    /// <summary>
    /// Rotate image clockwise 90deg.
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageRotateCW(ref Image image);

    /// <summary>
    /// Rotate image counter-clockwise 90deg.
    /// </summary>
    /// <param name="image">The image to rotate.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageRotateCCW(ref Image image);

    /// <summary>
    /// Modify image color: tint.
    /// </summary>
    /// <param name="image">The image to tint.</param>
    /// <param name="color">The color to tint the image with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageColorTint(ref Image image, Color color);

    /// <summary>
    /// Modify image color: invert.
    /// </summary>
    /// <param name="image">The image to invert the colors of.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageColorInvert(ref Image image);

    /// <summary>
    /// Modify image color: grayscale.
    /// </summary>
    /// <param name="image">The color image to convert.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageColorGrayscale(ref Image image);

    /// <summary>
    /// Modify image color: contrast (-100 to 100).
    /// </summary>
    /// <param name="image">The image to adjust the contrast of.</param>
    /// <param name="contrast">The contrast value. Positive values increase contrast, while negative values decrease contrast.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageColorContrast(ref Image image, float contrast);

    /// <summary>
    /// Modify image color: brightness (-255 to 255).
    /// </summary>
    /// <param name="image">The image to adjust.</param>
    /// <param name="brightness">The brightness value to apply to the image. Positive values increase brightness, negative values decrease brightness.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageColorBrightness(ref Image image, int brightness);

    /// <summary>
    /// Modify image color: replace color.
    /// </summary>
    /// <param name="image">The image to modify.</param>
    /// <param name="color">The color to replace.</param>
    /// <param name="replace">The color to replace with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageColorReplace(ref Image image, Color color, Color replace);

    /// <summary>
    /// Load color data from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color data from.</param>
    /// <returns>The color data of the loaded image.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Color* LoadImageColors(Image image);

    /// <summary>
    /// Load colors palette from image as a Color array (RGBA - 32bit).
    /// </summary>
    /// <param name="image">The image to load the color palette from.</param>
    /// <param name="maxPaletteSize">The maximum number of colors in the palette.</param>
    /// <param name="colorCount">The actual number of colors in the palette.</param>
    /// <returns>A pointer to the loaded color palette.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Color* LoadImagePalette(Image image, int maxPaletteSize, out int colorCount);

    /// <summary>
    /// Get image alpha border rectangle.
    /// </summary>
    /// <param name="image">The image to process.</param>
    /// <param name="threshold">The threshold value for determining the alpha border.</param>
    /// <returns>The border rectangle with alpha values.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Rectangle GetImageAlphaBorder(Image image, float threshold);

    /// <summary>
    /// Get image pixel color at (x, y) position.
    /// </summary>
    /// <param name="image">The image to get the color from.</param>
    /// <param name="x">The X coordinate of the pixel.</param>
    /// <param name="y">The Y coordinate of the pixel.</param>
    /// <returns>The color of the pixel at the specified coordinates.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color GetImageColor(Image image, int x, int y);

    /// <summary>
    /// Clear image background with given color.
    /// </summary>
    /// <param name="dst">The image to clear the background of.</param>
    /// <param name="color">The color to use for clearing the background.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageClearBackground(ref Image dst, Color color);

    /// <summary>
    /// Draw pixel within an image.
    /// </summary>
    /// <param name="dst">The target image.</param>
    /// <param name="posX">The X position of the pixel.</param>
    /// <param name="posY">The Y position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawPixel(ref Image dst, int posX, int posY, Color color);

    /// <summary>
    /// Draw pixel within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on. Modified by reference.</param>
    /// <param name="position">The position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawPixelV(ref Image dst, Vector2 position, Color color);

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
    internal static partial void ImageDrawLine(ref Image dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// Draw line within an image (Vector version).
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="start">The starting point of the line.</param>
    /// <param name="end">The ending point of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawLineV(ref Image dst, Vector2 start, Vector2 end, Color color);

    /// <summary>
    /// Draw a line defining thickness within an image.
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="start">The starting position of the line.</param>
    /// <param name="end">The ending position of the line.</param>
    /// <param name="thick">The thickness of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawLineEx(ref Image dst, Vector2 start, Vector2 end, int thick, Color color);

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
    internal static partial void ImageDrawCircle(ref Image dst, int centerX, int centerY, int radius, Color color);

    /// <summary>
    ///Draw a filled circle within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on.</param>
    /// <param name="center">The center coordinates of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle outline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawCircleV(ref Image dst, Vector2 center, int radius, Color color);

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
    internal static partial void ImageDrawCircleLines(ref Image dst, int centerX, int centerY, int radius, Color color);

    /// <summary>
    /// Draw circle outline within an image (Vector version).
    /// </summary>
    /// <param name="dst">Reference to the target image.</param>
    /// <param name="center">Center of the circle.</param>
    /// <param name="radius">Radius of the circle.</param>
    /// <param name="color">Color of the circle outline lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawCircleLinesV(ref Image dst, Vector2 center, int radius, Color color);

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
    internal static partial void ImageDrawRectangle(ref Image dst, int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw rectangle within an image (Vector version).
    /// </summary>
    /// <param name="dst">The image to draw on.</param>
    /// <param name="position">The position of the top-left corner of the rectangle.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawRectangleV(ref Image dst, Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// Draw rectangle within an image.
    /// </summary>
    /// <param name="dst">The destination image to draw on.</param>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="color">The color to fill the rectangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawRectangleRec(ref Image dst, Rectangle rec, Color color);

    /// <summary>
    /// Draw rectangle lines within an image.
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="thick">The thickness of the lines.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawRectangleLines(ref Image dst, Rectangle rec, int thick, Color color);

    /// <summary>
    /// Draw triangle within an image.
    /// </summary>
    /// <param name="dst">The destination image on which to draw the triangle.</param>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the filled triangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawTriangle(ref Image dst, Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw triangle with interpolated colors within an image.
    /// </summary>
    /// <param name="dst">The image on which to draw the triangle.</param>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="c1">The color of the first vertex.</param>
    /// <param name="c2">The color of the second vertex.</param>
    /// <param name="c3">The color of the third vertex.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawTriangleEx(ref Image dst, Vector2 v1, Vector2 v2, Vector2 v3, Color c1, Color c2, Color c3);

    /// <summary>
    /// Draw triangle outline within an image.
    /// </summary>
    /// <param name="dst">The image on which to draw the triangle.</param>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the triangle outline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void ImageDrawTriangleLines(ref Image dst, Vector2 v1, Vector2 v2, Vector2 v3, Color color);


    /// <summary>
    /// Draw a triangle fan defined by points within an image (first vertex is the center).
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="points">A pointer to an array of Vector2 points defining the vertices of the triangle fan.</param>
    /// <param name="pointCount">The number of points in the array.</param>
    /// <param name="color">The color of the filled triangle fan.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void ImageDrawTriangleFan(ref Image dst, Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points within an image.
    /// </summary>
    /// <param name="dst">The destination image.</param>
    /// <param name="points">A pointer to an array of Vector2 points.</param>
    /// <param name="pointCount">The number of points in the array.</param>
    /// <param name="color">The color of the triangle strip.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void ImageDrawTriangleStrip(ref Image dst, Vector2* points, int pointCount, Color color);

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
    internal static partial void ImageDraw(ref Image dst, Image src, Rectangle srcRec, Rectangle dstRec, Color tint);

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
    internal static partial void ImageDrawText(ref Image dst, string text, int posX, int posY, int fontSize, Color color);

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
    internal static partial void ImageDrawTextEx(ref Image dst, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

    /* --------------------------------- Texture --------------------------------- */

    /// <summary>
    /// Load texture from file into GPU memory (VRAM).
    /// </summary>
    /// <param name="fileName">The path to the texture file.</param>
    /// <returns>The loaded texture.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Texture2D LoadTexture(string fileName);

    /// <summary>
    /// Load texture from image data.
    /// </summary>
    /// <param name="image">The image to load texture from.</param>
    /// <returns>The loaded texture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Texture2D LoadTextureFromImage(Image image);

    /// <summary>
    /// Load cubemap from image, multiple image cubemap layouts supported.
    /// </summary>
    /// <param name="image">The image data for the cube map.</param>
    /// <param name="layout">The layout of the cube map.</param>
    /// <returns>The loaded cube map texture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Texture2D LoadTextureCubemap(Image image, CubemapLayout layout);

    /// <summary>
    /// Check if a texture is ready.
    /// </summary>
    /// <param name="texture">The texture to check.</param>
    /// <returns>Returns true if the texture is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsTextureReady(Texture2D texture);

    /// <summary>
    /// Unload texture from GPU memory (VRAM).
    /// </summary>
    /// <param name="texture">The texture to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadTexture(Texture2D texture);

    /// <summary>
    /// Update GPU texture with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="pixels">The pointer to the new texture data.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateTexture(Texture2D texture, nint pixels);

    /// <summary>
    /// Update GPU texture rectangle with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="rec">The rectangle defining the portion of the texture to update.</param>
    /// <param name="pixels">A pointer to the new pixel data.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateTextureRec(Texture2D texture, Rectangle rec, nint pixels);

    /// <summary>
    /// Generate GPU mipmaps for a texture.
    /// </summary>
    /// <param name="texture">The texture to generate mipmaps for.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void GenTextureMipmaps(ref Texture2D texture);

    /// <summary>
    /// Set texture scaling filter mode.
    /// </summary>
    /// <param name="texture">The texture to set the filter mode for.</param>
    /// <param name="filter">The texture filter mode to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetTextureFilter(Texture2D texture, TextureFilter filter);

    /// <summary>
    /// Set texture wrapping mode.
    /// </summary>
    /// <param name="texture">The texture to set the wrapping mode for.</param>
    /// <param name="wrap">The texture wrapping mode to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetTextureWrap(Texture2D texture, TextureWrap wrap);

    /* --------------------------------- Render Texture --------------------------------- */

    /// <summary>
    /// Load texture for rendering (framebuffer).
    /// </summary>
    /// <param name="width">The width of the render texture.</param>
    /// <param name="height">The height of the render texture.</param>
    /// <returns>The loaded render texture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial RenderTexture2D LoadRenderTexture(int width, int height);

    /// <summary>
    /// Check if a render texture is ready.
    /// </summary>
    /// <param name="target">The render texture to check.</param>
    /// <returns>Returns true if the render texture is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsRenderTextureReady(RenderTexture2D target);

    /// <summary>
    /// Unload render texture from GPU memory (VRAM).
    /// </summary>
    /// <param name="target">The render texture to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadRenderTexture(RenderTexture2D target);

    /* --------------------------------- Color --------------------------------- */

    /// <summary>
    /// Check if two colors are equal.
    /// </summary>
    /// <param name="col1">The first color to compare.</param>
    /// <param name="col2">The second color to compare.</param>
    /// <returns>True if the colors are equal; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ColorIsEqual(Color col1, Color col2);

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to fade.</param>
    /// <param name="alpha">The new alpha value.</param>
    /// <returns>The faded color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color Fade(Color color, float alpha);

    /// <summary>
    /// Get hexadecimal value for a Color (0xRRGGBBAA).
    /// </summary>
    /// <param name="color">The color to convert.</param>
    /// <returns>The integer representation of the color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int ColorToInt(Color color);

    /// <summary>
    /// Get Color normalized as float [0..1].
    /// </summary>
    /// <param name="color">The color to normalize.</param>
    /// <returns>The normalized color as a Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 ColorNormalize(Color color);

    /// <summary>
    /// Get Color from normalized values [0..1].
    /// </summary>
    /// <param name="normalized">The normalized vector.</param>
    /// <returns>The converted color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color ColorFromNormalized(Vector4 normalized);

    /// <summary>
    /// Get HSV values for a Color, hue [0..360], saturation/value [0..1].
    /// </summary>
    /// <param name="color">The color to convert.</param>
    /// <returns>The HSV representation of the color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 ColorToHSV(Color color);

    /// <summary>
    /// Get a Color from HSV values, hue [0..360], saturation/value [0..1].
    /// </summary>
    /// <param name="hue">The hue component of the color. It ranges from 0.0 to 360.0.</param>
    /// <param name="saturation">The saturation component of the color. It ranges from 0.0 to 1.0.</param>
    /// <param name="value">The value component of the color. It ranges from 0.0 to 1.0.</param>
    /// <returns>The color created from the given HSV values.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color ColorFromHSV(float hue, float saturation, float value);

    /// <summary>
    /// Get color multiplied with another color.
    /// </summary>
    /// <param name="color">The color to tint.</param>
    /// <param name="tint">The color to use as a tint.</param>
    /// <returns>The tinted color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color ColorTint(Color color, Color tint);

    /// <summary>
    /// Get color with brightness correction, brightness factor goes from -1.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to adjust brightness on.</param>
    /// <param name="factor">The factor to adjust brightness by. Positive values increase brightness, negative values decrease brightness.</param>
    /// <returns>The color with adjusted brightness.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color ColorBrightness(Color color, float factor);

    /// <summary>
    /// Get color with contrast correction, contrast values between -1.0f and 1.0f.
    /// </summary>
    /// <param name="color">The color to adjust.</param>
    /// <param name="contrast">The contrast value (0.0f to 1.0f).</param>
    /// <returns>The adjusted color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color ColorContrast(Color color, float contrast);

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f.
    /// </summary>
    /// <param name="color">The color to modify.</param>
    /// <param name="alpha">The new alpha value.</param>
    /// <returns>The resulting color with the new alpha value applied.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color ColorAlpha(Color color, float alpha);

    /// <summary>
    /// Get src alpha-blended into dst color with tint.
    /// </summary>
    /// <param name="dst">The destination color.</param>
    /// <param name="src">The source color.</param>
    /// <param name="tint">The tint color.</param>
    /// <returns>The blended color.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color ColorAlphaBlend(Color dst, Color src, Color tint);

    /// <summary>
    /// Get Color structure from hexadecimal value.
    /// </summary>
    /// <param name="hexValue">The hexadecimal value of the color.</param>
    /// <returns>The color specified by the hexadecimal value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color GetColor(uint hexValue);

    /// <summary>
    /// Get Color from a source pixel pointer of certain format.
    /// </summary>
    /// <param name="srcPtr">Pointer to the start of the image buffer.</param>
    /// <param name="format">The pixel format of the image buffer.</param>
    /// <returns>The color of the pixel.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Color GetPixelColor(nint srcPtr, PixelFormat format);

    /// <summary>
    /// Set color formatted into destination pixel pointer.
    /// </summary>
    /// <param name="dstPtr">Pointer to the destination image data.</param>
    /// <param name="color">The color to set.</param>
    /// <param name="format">The pixel format of the image.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetPixelColor(nint dstPtr, Color color, PixelFormat format);

    /// <summary>
    /// Get pixel data size in bytes for certain format.
    /// </summary>
    /// <param name="width">The width of the pixel data.</param>
    /// <param name="height">The height of the pixel data.</param>
    /// <param name="format">The pixel format of the pixel data.</param>
    /// <returns>The size of the pixel data in bytes.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetPixelDataSize(int width, int height, PixelFormat format);

    /* --------------------------------- Font --------------------------------- */

    /// <summary>
    /// Get the default Font.
    /// </summary>
    /// <returns>The default font.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Font GetFontDefault();

    /// <summary>
    /// Load font from file into GPU memory (VRAM).
    /// </summary>
    /// <param name="fileName">The path of the font file.</param>
    /// <returns>The loaded font.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Font LoadFont(string fileName);

    /// <summary>
    /// Load font from file with extended parameters, use NULL for codepoints and 0 for codepointCount to load the default character set.
    /// </summary>
    /// <param name="fileName">The path to the font file.</param>
    /// <param name="fontSize">The font size.</param>
    /// <param name="codepoints">An array of codepoints to load from the font.</param>
    /// <param name="codepointCount">The number of codepoints to load.</param>
    /// <returns>A Font object representing the loaded font.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Font LoadFontEx(string fileName, int fontSize, int* codepoints, int codepointCount);

    /// <summary>
    /// Load font from Image (XNA style).
    /// </summary>
    /// <param name="image">The image containing the font characters.</param>
    /// <param name="key">The color key used to identify the font characters.</param>
    /// <param name="firstChar">The ASCII value of the first character in the font characters.</param>
    /// <returns>The loaded font.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Font LoadFontFromImage(Image image, Color key, int firstChar);

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
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Font LoadFontFromMemory(string fileType, byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount);

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
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial GlyphInfo* LoadFontData(byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount, FontType type);

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
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Image GenImageFontAtlas(GlyphInfo* glyphs, Rectangle** glyphRecs, int glyphCount, int fontSize, int padding, int packMethod);

    /// <summary>
    /// Unload font chars info data (RAM).
    /// </summary>
    /// <param name="glyphs">Pointer to the GlyphInfo structure.</param>
    /// <param name="glyphCount">The number of glyphs.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadFontData(GlyphInfo* glyphs, int glyphCount);

    /// <summary>
    /// Check if a font is ready.
    /// </summary>
    /// <param name="font">The font to check.</param>
    /// <returns>True if the font is ready to be used, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsFontReady(Font font);

    /// <summary>
    /// Unload font from GPU memory (VRAM).
    /// </summary>
    /// <param name="font">The Font to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadFont(Font font);

    /// <summary>
    /// Export font as code file, returns true on success.
    /// </summary>
    /// <param name="font">The font to export.</param>
    /// <param name="fileName">The name of the file to save the exported code.</param>
    /// <returns>True if the export was successful, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportFontAsCode(Font font, string fileName);

    /// <summary>
    /// Get glyph index position in font for a codepoint (unicode character), fallback to '?' if not found.
    /// </summary>
    /// <param name="font">The font.</param>
    /// <param name="codepoint">The codepoint.</param>
    /// <returns>The glyph index.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetGlyphIndex(Font font, int codepoint);

    /// <summary>
    /// Get glyph font info data for a codepoint (unicode character), fallback to '?' if not found.
    /// </summary>
    /// <param name="font">The font to get glyph information from.</param>
    /// <param name="codepoint">The codepoint of the glyph.</param>
    /// <returns>The glyph information for the specified codepoint.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial GlyphInfo GetGlyphInfo(Font font, int codepoint);

    /// <summary>
    /// Get glyph rectangle in font atlas for a codepoint (unicode character), fallback to '?' if not found.
    /// </summary>
    /// <param name="font">The font.</param>
    /// <param name="codepoint">The codepoint.</param>
    /// <returns>The glyph atlas rectangle for the specified codepoint.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Rectangle GetGlyphAtlasRec(Font font, int codepoint);

    /* --------------------------------- Text Manager --------------------------------- */

    /// <summary>
    /// Load UTF-8 text encoded from codepoints array.
    /// </summary>
    /// <param name="codepoints">An array of codepoints.</param>
    /// <param name="length">The length of the codepoints array.</param>
    /// <returns>The loaded UTF-8 string.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static unsafe partial string LoadUTF8(int* codepoints, int length);

    /// <summary>
    /// Unload UTF-8 text encoded from codepoints array.
    /// </summary>
    /// <param name="text">The UTF-8 encoded string to unload.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadUTF8(string text);

    /// <summary>
    /// Load all codepoints from a UTF-8 text string, codepoints count returned by parameter.
    /// </summary>
    /// <param name="text">The text from which to load the codepoints.</param>
    /// <param name="count">The number of codepoints loaded.</param>
    /// <returns>A Pointer of integers representing the codepoints.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial int* LoadCodepoints(string text, out int count);

    /// <summary>
    /// Unload codepoints data from memory.
    /// </summary>
    /// <param name="codepoints">The Pointer of codepoints to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadCodepoints(int* codepoints);

    /// <summary>
    /// Get total number of codepoints in a UTF-8 encoded string.
    /// </summary>
    /// <param name="text">The text to count the codepoints in.</param>
    /// <returns>The number of codepoints in the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetCodepointCount(string text);

    /// <summary>
    /// Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure.
    /// </summary>
    /// <param name="text">The UTF-8 encoded string.</param>
    /// <param name="codepointSize">The size of the next Unicode code point in bytes.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetCodepoint(string text, out int codepointSize);

    /// <summary>
    /// Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure.
    /// </summary>
    /// <param name="text">The text to analyze.</param>
    /// <param name="codepointSize">The size of the next codepoint in bytes.</param>
    /// <returns>The next codepoint in the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetCodepointNext(string text, out int codepointSize);

    /// <summary>
    /// Get previous codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure.
    /// </summary>
    /// <param name="text">The text from which to find the previous codepoint.</param>
    /// <param name="codepointSize">The size in bytes of the previous codepoint.</param>
    /// <returns>The codepoint of the previous character in the text, and its size in bytes.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetCodepointPrevious(string text, out int codepointSize);

    /// <summary>
    /// Encode one codepoint into UTF-8 byte array (array length returned as parameter).
    /// </summary>
    /// <param name="codepoint">The Unicode code point to convert.</param>
    /// <param name="utf8Size">The size of the resulting UTF-8 string, in bytes.</param>
    /// <returns>The UTF-8 string representation of the given code point.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string CodepointToUTF8(int codepoint, out int utf8Size);

    /// <summary>
    /// Set vertical line spacing when drawing with line-breaks.
    /// </summary>
    /// <param name="spacing">The amount of spacing between lines. Positive values increase the spacing, negative values decrease the spacing.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetTextLineSpacing(int spacing);

    /// <summary>
    /// Measure string width for default font.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="fontSize">The font size to use for rendering the text.</param>
    /// <returns>The width in pixels of the rendered text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int MeasureText(string text, int fontSize);

    /// <summary>
    /// Measure string size for Font.
    /// </summary>
    /// <param name="font">The font used to measure the text.</param>
    /// <param name="text">The text to measure.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <returns>The size of the measured text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);

    /// <summary>
    /// Copy one string to another, returns bytes copied.
    /// </summary>
    /// <param name="dst">The destination string.</param>
    /// <param name="src">The source string.</param>
    /// <returns>The number of characters copied.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int TextCopy(string dst, string src);

    /// <summary>
    /// Check if two text string are equal.
    /// </summary>
    /// <param name="text1">The first string to compare.</param>
    /// <param name="text2">The second string to compare.</param>
    /// <returns>True if the two strings are equal, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool TextIsEqual(string text1, string text2);

    /// <summary>
    /// Get text length, checks for '\0' ending.
    /// </summary>
    /// <param name="text">The text to be measured.</param>
    /// <returns>The length of the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial uint TextLength(string text);

    /// <summary>
    /// Text formatting with variables (sprintf() style).
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextFormat(string text);

    /// <summary>
    /// Get a piece of a text string.
    /// </summary>
    /// <param name="text">The original text.</param>
    /// <param name="position">The starting position of the subtext.</param>
    /// <param name="length">The length of the subtext.</param>
    /// <returns>The subtext from the given text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextSubtext(string text, int position, int length);

    /// <summary>
    /// Replace text string (WARNING: memory must be freed!).
    /// </summary>
    /// <param name="text">The input text.</param>
    /// <param name="replace">The string to be replaced.</param>
    /// <param name="by">The replacement string.</param>
    /// <returns>The modified text with all occurrences of the specified string replaced.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextReplace(string text, string replace, string by);

    /// <summary>
    /// Insert text in a position (WARNING: memory must be freed!).
    /// </summary>
    /// <param name="text">The original string.</param>
    /// <param name="insert">The string to be inserted.</param>
    /// <param name="position">The position at which the string should be inserted.</param>
    /// <returns>The resulting string after the insertion.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextInsert(string text, string insert, int position);

    /// <summary>
    /// Join text strings with delimiter.
    /// </summary>
    /// <param name="textList">An array of strings.</param>
    /// <param name="count">The number of strings in the array.</param>
    /// <param name="delimiter">The delimiter used to join the strings.</param>
    /// <returns>The joined string.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static unsafe partial string TextJoin(sbyte** textList, int count, string delimiter);

    /// <summary>
    /// Split text into multiple strings.
    /// </summary>
    /// <param name="text">The string to split.</param>
    /// <param name="delimiter">The delimiter used to split the string.</param>
    /// <param name="count">The number of resulting substrings.</param>
    /// <returns>An array of substrings.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial sbyte** TextSplit(string text, string delimiter, out int count);

    /// <summary>
    /// Append text at specific position and move cursor!.
    /// </summary>
    /// <param name="text">The initial text.</param>
    /// <param name="append">The string to append.</param>
    /// <param name="position">The position at which to append the string. This will be updated with the new position after the append operation.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void TextAppend(string text, string append, out int position);

    /// <summary>
    /// Find first text occurrence within a string.
    /// </summary>
    /// <param name="text">The text to search within.</param>
    /// <param name="find">The string to search for.</param>
    /// <returns>The index of the first occurrence of the specified string within the given text; -1 if the string is not found.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int TextFindIndex(string text, string find);

    /// <summary>
    /// Get upper case version of provided string.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The uppercase version of the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextToUpper(string text);

    /// <summary>
    /// Get lower case version of provided string.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The converted text in lowercase.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextToLower(string text);

    /// <summary>
    /// Get Pascal case notation version of provided string.
    /// </summary>
    /// <param name="text">The string to be converted.</param>
    /// <returns>The string in Pascal case.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextToPascal(string text);

    /// <summary>
    /// Get Snake case notation version of provided string.
    /// </summary>
    /// <param name="text">The text to be converted.</param>
    /// <returns>The converted text in snake case.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextToSnake(string text);

    /// <summary>
    /// Get Camel case notation version of provided string.
    /// </summary>
    /// <param name="text">The text string to convert.</param>
    /// <returns>The text string converted to camel case.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    internal static partial string TextToCamel(string text);

    /// <summary>
    /// Get integer value from text (negative values not supported).
    /// </summary>
    /// <param name="text">The text string to convert.</param>
    /// <returns>The converted integer value.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int TextToInteger(string text);

    /// <summary>
    /// Get float value from text (negative values not supported).
    /// </summary>
    /// <param name="text">A string containing a number to convert.</param>
    /// <returns>The single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="text"/>.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float TextToFloat(string text);

    /* --------------------------------- Mesh --------------------------------- */

    /// <summary>
    /// Generate polygonal mesh.
    /// </summary>
    /// <param name="sides">The number of sides of the polygon</param>
    /// <param name="radius">The radius of the polygon</param>
    /// <returns>The generated Mesh object</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshPoly(int sides, float radius);

    /// <summary>
    /// Generate plane mesh (with subdivisions).
    /// </summary>
    /// <param name="width">The width of the plane</param>
    /// <param name="length">The length of the plane</param>
    /// <param name="resX">The horizontal resolution of the plane</param>
    /// <param name="resZ">The vertical resolution of the plane</param>
    /// <returns>The generated plane mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshPlane(float width, float length, int resX, int resZ);

    /// <summary>
    /// Generate cuboid mesh.
    /// </summary>
    /// <param name="width">The width of the cube</param>
    /// <param name="height">The height of the cube</param>
    /// <param name="length">The length of the cube</param>
    /// <returns>A new Mesh representing the generated cube</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshCube(float width, float height, float length);

    /// <summary>
    /// Generate sphere mesh (standard sphere).
    /// </summary>
    /// <param name="radius">The radius of the sphere</param>
    /// <param name="rings">The number of rings that make up the sphere</param>
    /// <param name="slices">The number of slices that make up each ring of the sphere</param>
    /// <returns>The generated sphere mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate half-sphere mesh (no bottom cap).
    /// </summary>
    /// <param name="radius">The radius of the hemisphere</param>
    /// <param name="rings">The number of rings in the hemisphere</param>
    /// <param name="slices">The number of slices in the hemisphere</param>
    /// <returns>A hemisphere Mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshHemiSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate cylinder mesh.
    /// </summary>
    /// <param name="radius">The radius of the cylinder</param>
    /// <param name="height">The height of the cylinder</param>
    /// <param name="slices">The number of slices to create the cylinder</param>
    /// <returns>The generated cylinder mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshCylinder(float radius, float height, int slices);

    /// <summary>
    /// Generate cone/pyramid mesh.
    /// </summary>
    /// <param name="radius">The radius of the cone base</param>
    /// <param name="height">The height of the cone</param>
    /// <param name="slices">The number of radial slices for the cone</param>
    /// <returns>A Mesh object representing the generated cone</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshCone(float radius, float height, int slices);

    /// <summary>
    /// Generate torus mesh.
    /// </summary>
    /// <param name="radius">The radius of the torus</param>
    /// <param name="size">The size of the torus</param>
    /// <param name="radSeg">The number of radial segments</param>
    /// <param name="sides">The number of sides</param>
    /// <returns>The generated torus mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshTorus(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate trefoil knot mesh.
    /// </summary>
    /// <param name="radius">The radius of the knot.</param>
    /// <param name="size">The size of the knot.</param>
    /// <param name="radSeg">The number of segments in the radial direction.</param>
    /// <param name="sides">The number of sides in the knot.</param>
    /// <returns>A mesh representing the generated knot.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshKnot(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate heightMap mesh from image data.
    /// </summary>
    /// <param name="heightmap">The heightMap image used to generate the mesh</param>
    /// <param name="size">The size of the mesh</param>
    /// <returns>The generated mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshHeightmap(Image heightmap, Vector3 size);

    /// <summary>
    /// Generate cubes-based map mesh from image data.
    /// </summary>
    /// <param name="cubicmap">The image to generate the cubic map from</param>
    /// <param name="cubeSize">The size of each cube in the cubic map</param>
    /// <returns>The generated cubic map mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Mesh GenMeshCubicmap(Image cubicmap, Vector3 cubeSize);

    /// <summary>
    /// Upload mesh vertex data in GPU and provide VAO/VBO ids.
    /// </summary>
    /// <param name="mesh">The mesh data to upload</param>
    /// <param name="dynamic">Determines if the mesh data should be uploaded as dynamic or static</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UploadMesh(ref Mesh mesh, [MarshalAs(UnmanagedType.I1)] bool dynamic);

    /// <summary>
    /// Update mesh vertex data in GPU for a specific buffer index.
    /// </summary>
    /// <param name="mesh">The mesh to update</param>
    /// <param name="index">The index of the buffer to update</param>
    /// <param name="data">A pointer to the new vertex data</param>
    /// <param name="dataSize">The size of the new data in bytes</param>
    /// <param name="offset">Offset in bytes to offset the mesh data</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateMeshBuffer(Mesh mesh, int index, nint data, int dataSize, int offset);

    /// <summary>
    /// Unload mesh data from CPU and GPU.
    /// </summary>
    /// <param name="mesh">The mesh data to unload</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadMesh(Mesh mesh);

    /// <summary>
    /// Compute mesh bounding box limits.
    /// </summary>
    /// <param name="mesh">The mesh to get the bounding box from</param>
    /// <returns>The bounding box of the mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial BoundingBox GetMeshBoundingBox(Mesh mesh);

    /// <summary>
    /// Compute mesh tangents.
    /// </summary>
    /// <param name="mesh">The mesh to generate tangents for</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void GenMeshTangents(ref Mesh mesh);

    /// <summary>
    /// Export mesh data to file, returns true on success.
    /// </summary>
    /// <param name="mesh">The mesh data to export.</param>
    /// <param name="fileName">The name of the file to export the mesh to.</param>
    /// <returns>Returns true if the export was successful, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportMesh(Mesh mesh, string fileName);

    /// <summary>
    /// Export mesh as code file (.h) defining multiple arrays of vertex attributes.
    /// </summary>
    /// <param name="mesh">The mesh to export.</param>
    /// <param name="fileName">The name of the file to save the exported code to.</param>
    /// <returns>True if the export was successful; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool ExportMeshAsCode(Mesh mesh, string fileName);

    /* --------------------------------- Model --------------------------------- */

    /// <summary>
    /// Load model from files (meshes and materials).
    /// </summary>
    /// <param name="fileName">The name of the file containing the model.</param>
    /// <returns>The loaded model.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Model LoadModel(string fileName);

    /// <summary>
    /// Load model from generated mesh (default material).
    /// </summary>
    /// <param name="mesh">The mesh object containing the model.</param>
    /// <returns>The loaded model.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Model LoadModelFromMesh(Mesh mesh);

    /// <summary>
    /// Check collision between two spheres.
    /// </summary>
    /// <param name="center1">The center position of the first sphere.</param>
    /// <param name="radius1">The radius of the first sphere.</param>
    /// <param name="center2">The center position of the second sphere.</param>
    /// <param name="radius2">The radius of the second sphere.</param>
    /// <returns>True if the two spheres collide, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);

    /// <summary>
    /// Check collision between two bounding boxes.
    /// </summary>
    /// <param name="box1">The bounding box of the first sphere.</param>
    /// <param name="box2">The bounding box of the second sphere.</param>
    /// <returns>True if the spheres are colliding, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionBoxes(BoundingBox box1, BoundingBox box2);

    /// <summary>
    /// Check collision between box and sphere.
    /// </summary>
    /// <param name="box">The bounding box to check against.</param>
    /// <param name="center">The center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>True if the sphere collides with the bounding box, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool CheckCollisionBoxSphere(BoundingBox box, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and sphere.
    /// </summary>
    /// <param name="ray">The ray used for collision.</param>
    /// <param name="center">The center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>The collision data between the ray and the sphere.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and box.
    /// </summary>
    /// <param name="ray">The ray to check collision with.</param>
    /// <param name="box">The bounding box to check collision with.</param>
    /// <returns>The collision between the ray and the bounding box.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial RayCollision GetRayCollisionBox(Ray ray, BoundingBox box);

    /// <summary>
    /// Get collision info between ray and mesh.
    /// </summary>
    /// <param name="ray">The ray to perform the collision check with.</param>
    /// <param name="mesh">The mesh to check collision against.</param>
    /// <param name="transform">The transform to apply to the mesh before collision check.</param>
    /// <returns>The ray collision result.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, Matrix4x4 transform);

    /// <summary>
    /// Get collision info between ray and triangle.
    /// </summary>
    /// <param name="ray">The ray used to calculate collision.</param>
    /// <param name="p1">The first vertex of the triangle.</param>
    /// <param name="p2">The second vertex of the triangle.</param>
    /// <param name="p3">The third vertex of the triangle.</param>
    /// <returns>The collision information between the ray and the triangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3);

    /// <summary>
    /// Get collision info between ray and quad.
    /// </summary>
    /// <param name="ray">The ray to check for collision.</param>
    /// <param name="p1">The first point of the quad.</param>
    /// <param name="p2">The second point of the quad.</param>
    /// <param name="p3">The third point of the quad.</param>
    /// <param name="p4">The fourth point of the quad.</param>
    /// <returns>The collision information between the ray and the quad.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4);

    /// <summary>
    /// Check if a model is ready.
    /// </summary>
    /// <param name="model">The model to check.</param>
    /// <returns>True if the model is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsModelReady(Model model);

    /// <summary>
    /// Unload model (including meshes) from memory (RAM and/or VRAM).
    /// </summary>
    /// <param name="model">The model to be unloaded.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadModel(Model model);

    /// <summary>
    /// Compute model bounding box limits (considers all meshes).
    /// </summary>
    /// <param name="model">The model to get the bounding box from.</param>
    /// <returns>The bounding box of the model.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial BoundingBox GetModelBoundingBox(Model model);

    /// <summary>
    /// Set material for a mesh.
    /// </summary>
    /// <param name="model">The model to set the material for.</param>
    /// <param name="meshId">The ID of the mesh to set the material for.</param>
    /// <param name="materialId">The ID of the material to set for the mesh.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetModelMeshMaterial(ref Model model, int meshId, int materialId);

    /* --------------------------------- Model Animation --------------------------------- */

    /// <summary>
    /// Load model animations from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load animations from.</param>
    /// <param name="animCount">The number of animations loaded from the file.</param>
    /// <returns>A Pointer to the loaded model animations.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial ModelAnimation* LoadModelAnimations(string fileName, out int animCount);

    /// <summary>
    /// Unload animation array data.
    /// </summary>
    /// <param name="animations">The animations to unload.</param>
    /// <param name="animCount">The number of animations to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadModelAnimations(ModelAnimation* animations, int animCount);

    /// <summary>
    /// Update model animation pose.
    /// </summary>
    /// <param name="model">The model containing the animation.</param>
    /// <param name="anim">The animation to update.</param>
    /// <param name="frame">The frame to update the animation to.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UpdateModelAnimation(Model model, ModelAnimation anim, int frame);

    /// <summary>
    /// Check model animation skeleton match.
    /// </summary>
    /// <param name="model">The model to check the animation for.</param>
    /// <param name="anim">The animation to check.</param>
    /// <returns>True if the model animation is valid, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsModelAnimationValid(Model model, ModelAnimation anim);

    /// <summary>
    /// Unload animation data.
    /// </summary>
    /// <param name="anim">The model animation to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadModelAnimation(ModelAnimation anim);

    /* --------------------------------- Material --------------------------------- */

    /// <summary>
    /// Load materials from model file.
    /// </summary>
    /// <param name="fileName">The name of the file to load materials from.</param>
    /// <param name="materialCount">The number of materials loaded.</param>
    /// <returns>A pointer to the loaded materials.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial Material* LoadMaterials(string fileName, out int materialCount);

    /// <summary>
    /// Load default material (Supports: DIFFUSE, SPECULAR, NORMAL maps).
    /// </summary>
    /// <returns>A pointer to the loaded material.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Material LoadMaterialDefault();

    /// <summary>
    /// Check if a material is ready.
    /// </summary>
    /// <param name="material">The material to check.</param>
    /// <returns>True if the material is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    internal static partial bool IsMaterialReady(Material material);

    /// <summary>
    /// Unload material from GPU memory (VRAM).
    /// </summary>
    /// <param name="material">The material to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void UnloadMaterial(Material material);
}