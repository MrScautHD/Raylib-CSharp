using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.CSharp.Images;
using Raylib_CSharp.CSharp.Marshallers;

namespace Raylib_CSharp.CSharp.Windowing;

public static partial class Window {
    
    /// <summary>
    /// Initialize window and OpenGL context.
    /// </summary>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    /// <param name="title">The title of the window.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "InitWindow", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Init(int width, int height, string title);
    
    /// <summary>
    /// Close window and unload OpenGL context.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "CloseWindow")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Close();

    /// <summary>
    /// Check if application should close (KEY_ESCAPE pressed or windows close icon clicked).
    /// </summary>
    /// <returns>true if the window should close, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "WindowShouldClose")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ShouldClose();
    
    /// <summary>
    /// Check if window has been initialized successfully.
    /// </summary>
    /// <returns>True if the window and OpenGL context are ready, false otherwise</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsReady();
    
    /// <summary>
    /// Check if window is currently fullscreen.
    /// </summary>
    /// <returns>True if the window is in fullscreen mode, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowFullscreen")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsFullscreen();
    
    /// <summary>
    /// Check if window is currently hidden (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>True if the window is hidden, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowHidden")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsHidden();
    
    /// <summary>
    /// Check if window is currently minimized (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>
    /// <c>true</c> if the window is minimized; otherwise, <c>false</c>.
    /// </returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowMinimized")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsMinimized();

    /// <summary>
    /// Check if window is currently maximized (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>True if the window is maximized, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowMaximized")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsMaximized();

    /// <summary>
    /// Check if window is currently focused (only PLATFORM_DESKTOP).
    /// </summary>
    /// <returns>true if the window has input focus, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowFocused")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsFocused();

    /// <summary>
    /// Check if window has been resized last frame.
    /// </summary>
    /// <returns>true if the window has been resized, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowResized")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsResized();

    /// <summary>
    /// Check if one specific window flag is enabled.
    /// </summary>
    /// <param name="flag">The window state flag to check.</param>
    /// <returns>true if the window state flag is set, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWindowState")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsState(ConfigFlags flag);

    /// <summary>
    /// Set window configuration state using flags (only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="flag">The configuration flag(s) to set for the window.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowState")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetState(ConfigFlags flag);

    /// <summary>
    /// Clear window configuration state flags.
    /// </summary>
    /// <param name="flag">The window configuration flag to clear.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ClearWindowState")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearState(ConfigFlags flag);
    
    /// <summary>
    /// Toggle window state: fullscreen/windowed (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "ToggleFullscreen")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ToggleFullscreen();

    /// <summary>
    /// Toggle window state: borderless windowed (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "ToggleBorderlessWindowed")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ToggleBorderless();

    /// <summary>
    /// Set window state: maximized, if resizable (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "MaximizeWindow")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Maximize();

    /// <summary>
    /// Set window state: minimized, if resizable (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "MinimizeWindow")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Minimize();

    /// <summary>
    /// Set window state: not minimized/maximized (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "RestoreWindow")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Restore();

    /// <summary>
    /// Set icon for window (single image, RGBA 32bit, only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowIcon")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetIcon(Image image);

    /// <summary>
    /// Set icon for window (multiple images, RGBA 32bit, only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="image">The array of images representing the icons.</param>
    /// <param name="count">The number of icons in the array.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowIcons")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetIcons(Image* image, int count);

    /// <summary>
    /// Set title for window (only PLATFORM_DESKTOP and PLATFORM_WEB).
    /// </summary>
    /// <param name="title">The new title for the window.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowIcon", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTitle(string title);

    /// <summary>
    /// Set window position on screen (only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="x">The x-coordinate of the window position.</param>
    /// <param name="y">The y-coordinate of the window position.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowPosition")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetPosition(int x, int y);

    /// <summary>
    /// Set monitor for the current window.
    /// </summary>
    /// <param name="monitor">The index of the monitor to be used.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowMonitor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMonitor(int monitor);

    /// <summary>
    /// Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE).
    /// </summary>
    /// <param name="width">The minimum width of the window.</param>
    /// <param name="height">The minimum height of the window.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowMinSize")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMinSize(int width, int height);

    /// <summary>
    /// Set window maximum dimensions (for FLAG_WINDOW_RESIZABLE).
    /// </summary>
    /// <param name="width">The maximum width of the window.</param>
    /// <param name="height">The maximum height of the window.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowMaxSize")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMaxSize(int width, int height);

    /// <summary>
    /// Set window dimensions.
    /// </summary>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowSize")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSize(int width, int height);

    /// <summary>
    /// Set window opacity [0.0f..1.0f] (only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="opacity">The opacity to set, ranging from 0.0f (transparent) to 1.0f (opaque).</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowOpacity")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetOpacity(float opacity);

    /// <summary>
    /// Set window focused (only PLATFORM_DESKTOP).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "SetWindowFocused")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetFocused();

    /// <summary>
    /// Get native window handle.
    /// </summary>
    /// <returns>The handle of the window.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetWindowHandle")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* GetHandle();

    /// <summary>
    /// Get current screen width.
    /// </summary>
    /// <returns>The width of the screen in pixels.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetScreenWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetScreenWidth();

    /// <summary>
    /// Get current screen height.
    /// </summary>
    /// <returns>The height of the screen in pixels.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetScreenHeight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetScreenHeight();

    /// <summary>
    /// Get current render width (it considers HiDPI).
    /// </summary>
    /// <returns>The width of the window's render area.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetRenderWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRenderWidth();

    /// <summary>
    /// Get current render height (it considers HiDPI).
    /// </summary>
    /// <returns>The height of the rendering context.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetRenderHeight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRenderHeight();

    /// <summary>
    /// Get number of connected monitors.
    /// </summary>
    /// <returns>The number of monitors connected to the system.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMonitorCount")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorCount();

    /// <summary>
    /// Get current connected monitor.
    /// </summary>
    /// <returns>The index of the current monitor.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCurrentMonitor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCurrentMonitor();

    /// <summary>
    /// Get specified monitor position.
    /// </summary>
    /// <param name="monitor">The index of the monitor.</param>
    /// <returns>The position of the monitor.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCurrentMonitor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMonitorPosition(int monitor);

    /// <summary>
    /// Get specified monitor width (current video mode used by monitor).
    /// </summary>
    /// <param name="monitor">The monitor index.</param>
    /// <returns>The width of the monitor in pixels.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMonitorWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorWidth(int monitor);

    /// <summary>
    /// Get specified monitor height (current video mode used by monitor).
    /// </summary>
    /// <param name="monitor">The index of the monitor. Default value is 0.</param>
    /// <returns>The height of the specified monitor.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMonitorHeight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorHeight(int monitor);

    /// <summary>
    /// Get specified monitor physical width in millimetres.
    /// </summary>
    /// <param name="monitor">The index of the monitor to retrieve the width from.</param>
    /// <returns>The physical width of the monitor in pixels.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMonitorPhysicalWidth")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorPhysicalWidth(int monitor);

    /// <summary>
    /// Get specified monitor physical height in millimetres.
    /// </summary>
    /// <param name="monitor">The index of the monitor.</param>
    /// <returns>The physical height of the monitor.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMonitorPhysicalHeight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorPhysicalHeight(int monitor);

    /// <summary>
    /// Get specified monitor refresh rate.
    /// </summary>
    /// <param name="monitor">The index of the monitor to retrieve the refresh rate from.</param>
    /// <returns>The refresh rate of the specified monitor in Hz.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMonitorRefreshRate")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorRefreshRate(int monitor);

    /// <summary>
    /// Get window position XY on monitor.
    /// </summary>
    /// <returns>The position of the window as a <see cref="Vector2"/>.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetWindowPosition")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetPosition();

    /// <summary>
    /// Get window scale DPI factor.
    /// </summary>
    /// <returns>The scale DPI of the window as a <see cref="Vector2"/>.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetWindowScaleDPI")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetScaleDPI();

    /// <summary>
    /// Get the human-readable, UTF-8 encoded name of the specified monitor.
    /// </summary>
    /// <param name="monitor">The index of the monitor.</param>
    /// <returns>The name of the monitor.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMonitorName")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetMonitorName(int monitor);

    /// <summary>
    /// Set clipboard text content.
    /// </summary>
    /// <param name="text">The text to set as the clipboard content.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetClipboardText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetClipboardText(string text);
    
    /// <summary>
    /// Get clipboard text content.
    /// </summary>
    /// <returns>The text stored in the clipboard as a Unicode string.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetClipboardText")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetClipboardText();

    /// <summary>
    /// Enable waiting for events on EndDrawing(), no automatic event polling.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "EnableEventWaiting")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableEventWaiting();

    /// <summary>
    /// Disable waiting for events on EndDrawing(), automatic events polling.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "DisableEventWaiting")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableEventWaiting();
}