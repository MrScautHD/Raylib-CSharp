namespace Raylib_CSharp.Interact;

public enum GamepadButton {

    /// <summary>
    /// Unknown button, just for error checking.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Gamepad left DPAD up button.
    /// </summary>
    LeftFaceUp,

    /// <summary>
    /// Gamepad left DPAD right button.
    /// </summary>
    LeftFaceRight,

    /// <summary>
    /// Gamepad left DPAD down button.
    /// </summary>
    LeftFaceDown,

    /// <summary>
    /// Gamepad left DPAD left button.
    /// </summary>
    LeftFaceLeft,

    /// <summary>
    /// Gamepad right button up (i.e. PS3: Triangle, Xbox: Y).
    /// </summary>
    RightFaceUp,

    /// <summary>
    /// Gamepad right button right (i.e. PS3: Circle, Xbox: B).
    /// </summary>
    RightFaceRight,

    /// <summary>
    /// Gamepad right button down (i.e. PS3: Cross, Xbox: A).
    /// </summary>
    RightFaceDown,

    /// <summary>
    /// Gamepad right button left (i.e. PS3: Square, Xbox: X).
    /// </summary>
    RightFaceLeft,

    /// <summary>
    /// Gamepad top/back trigger left (first), it could be a trailing button.
    /// </summary>
    LeftTrigger1,

    /// <summary>
    /// Gamepad top/back trigger left (second), it could be a trailing button.
    /// </summary>
    LeftTrigger2,

    /// <summary>
    /// Gamepad top/back trigger right (one), it could be a trailing button.
    /// </summary>
    RightTrigger1,

    /// <summary>
    /// Gamepad top/back trigger right (second), it could be a trailing button.
    /// </summary>
    RightTrigger2,

    /// <summary>
    /// Gamepad center buttons, left one (i.e. PS3: Select).
    /// </summary>
    MiddleLeft,

    /// <summary>
    /// Gamepad center buttons, middle one (i.e. PS3: PS, Xbox: XBOX).
    /// </summary>
    Middle,

    /// <summary>
    /// Gamepad center buttons, right one (i.e. PS3: Start).
    /// </summary>
    MiddleRight,

    /// <summary>
    /// Gamepad joystick pressed button left.
    /// </summary>
    LeftThumb,

    /// <summary>
    /// Gamepad joystick pressed button right.
    /// </summary>
    RightThumb
}