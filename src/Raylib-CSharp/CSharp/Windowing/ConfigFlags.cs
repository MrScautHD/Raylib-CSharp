namespace Raylib_CSharp.CSharp.Windowing;

[Flags]
public enum ConfigFlags : uint {

    /// <summary>
    /// Set to try enabling V-Sync on GPU.
    /// </summary>
    VSyncHint = 0x00000040,

    /// <summary>
    /// Set to run program in fullscreen.
    /// </summary>
    FullscreenMode = 0x00000002,

    /// <summary>
    /// Set to allow resizable window.
    /// </summary>
    ResizableWindow = 0x00000004,

    /// <summary>
    /// Set to disable window decoration (frame and buttons).
    /// </summary>
    UndecoratedWindow = 0x00000008,

    /// <summary>
    /// Set to hide window.
    /// </summary>
    HiddenWindow = 0x00000080,

    /// <summary>
    /// Set to minimize window (iconify).
    /// </summary>
    MinimizedWindow = 0x00000200,

    /// <summary>
    /// Set to maximize window (expanded to monitor).
    /// </summary>
    MaximizedWindow = 0x00000400,

    /// <summary>
    /// Set to window non focused.
    /// </summary>
    UnfocusedWindow = 0x00000800,

    /// <summary>
    /// Set to window always on top.
    /// </summary>
    TopmostWindow = 0x00001000,

    /// <summary>
    /// Set to allow windows running while minimized.
    /// </summary>
    AlwaysRunWindow = 0x00000100,

    /// <summary>
    /// Set to allow transparent framebuffer.
    /// </summary>
    TransparentWindow = 0x00000010,

    /// <summary>
    /// Set to support HighDPI.
    /// </summary>
    HighDpiWindow = 0x00002000,

    /// <summary>
    /// Set to support mouse passthrough, only supported when FLAG_WINDOW_UNDECORATED.
    /// </summary>
    MousePassthroughWindow = 0x00004000,

    /// <summary>
    /// Set to run program in borderless windowed mode.
    /// </summary>
    BorderlessWindowMode = 0x00008000,

    /// <summary>
    /// Set to try enabling MSAA 4X.
    /// </summary>
    Msaa4XHint = 0x00000020,

    /// <summary>
    /// Set to try enabling interlaced video format (for V3D).
    /// </summary>
    InterlacedHint = 0x00010000
}