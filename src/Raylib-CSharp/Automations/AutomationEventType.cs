namespace Raylib_CSharp.Automations;

public enum AutomationEventType {

    /// <summary>
    /// None type.
    /// </summary>
    None = 0,

    /// <summary>
    /// param[0]: key.
    /// </summary>
    KeyUp,

    /// <summary>
    /// param[0]: key.
    /// </summary>
    KeyDown,

    /// <summary>
    /// param[0]: key.
    /// </summary>
    KeyPressed,

    /// <summary>
    /// param[0]: key.
    /// </summary>
    KeyReleased,

    /// <summary>
    /// param[0]: button.
    /// </summary>
    MouseButtonUp,

    /// <summary>
    /// param[0]: button.
    /// </summary>
    MouseButtonDown,

    /// <summary>
    /// param[0]: x, param[1]: y.
    /// </summary>
    MousePosition,

    /// <summary>
    /// param[0]: x delta, param[1]: y delta.
    /// </summary>
    MouseWheelMotion,

    /// <summary>
    /// param[0]: gamepad.
    /// </summary>
    GamePadConnect,

    /// <summary>
    /// param[0]: gamepad.
    /// </summary>
    GamepadDisconnect,

    /// <summary>
    /// param[0]: button.
    /// </summary>
    GamepadButtonUp,

    /// <summary>
    /// param[0]: button.
    /// </summary>
    GamepadButtonDown,

    /// <summary>
    /// param[0]: axis, param[1]: delta.
    /// </summary>
    GamepadAxisMotion,

    /// <summary>
    /// param[0]: id.
    /// </summary>
    TouchUp,

    /// <summary>
    /// param[0]: id.
    /// </summary>
    TouchDown,

    /// <summary>
    /// param[0]: x, param[1]: y.
    /// </summary>
    TouchPosition,

    /// <summary>
    /// param[0]: gesture.
    /// </summary>
    Gesture,

    /// <summary>
    /// no params.
    /// </summary>
    WindowClose,

    /// <summary>
    /// no params.
    /// </summary>
    WindowMaximize,

    /// <summary>
    /// no params.
    /// </summary>
    WindowMinimize,

    /// <summary>
    /// param[0]: width, param[1]: height.
    /// </summary>
    WindowResize,

    /// <summary>
    /// no params.
    /// </summary>
    TakeScreenshot,

    /// <summary>
    /// param[0]: fps.
    /// </summary>
    SetTargetFps
}