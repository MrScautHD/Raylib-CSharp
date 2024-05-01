using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.CSharp.Marshallers;

namespace Raylib_CSharp.CSharp.Interact;

public static partial class Input {

    /// <summary>
    /// Shows cursor.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ShowCursor();

    /// <summary>
    /// Hides cursor.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void HideCursor();

    /// <summary>
    /// Check if cursor is not visible.
    /// </summary>
    /// <returns>True if the cursor is hidden, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsCursorHidden();

    /// <summary>
    /// Enables cursor (unlock cursor).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableCursor();

    /// <summary>
    /// Disables cursor (lock cursor).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableCursor();

    /// <summary>
    /// Check if cursor is on the screen.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsCursorOnScreen();

    /// <summary>
    /// Check if a key has been pressed once.
    /// </summary>
    /// <param name="key">The keyboard key to check.</param>
    /// <returns>Returns true if the key is pressed down, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsKeyPressed(KeyboardKey key);

    /// <summary>
    /// Check if a key has been pressed again (Only PLATFORM_DESKTOP).
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>Returns true if the key is being pressed and repeated; otherwise, false</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsKeyPressedRepeat(KeyboardKey key);

    /// <summary>
    /// Check if a key is being pressed.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>True if the key is currently being pressed; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsKeyDown(KeyboardKey key);

    /// <summary>
    /// Check if a key has been released once.
    /// </summary>
    /// <param name="key">The keyboard key to check</param>
    /// <returns>Returns true if the key is released, otherwise false</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsKeyReleased(KeyboardKey key);

    /// <summary>
    /// Check if a key is NOT being pressed.
    /// </summary>
    /// <param name="key">The key to check.</param>
    /// <returns>A boolean value indicating whether the key is up or not.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsKeyUp(KeyboardKey key);

    /// <summary>
    /// Get key pressed (keycode), call it multiple times for keys queued, returns 0 when the queue is empty.
    /// </summary>
    /// <returns>
    /// The keyboard key being pressed.
    /// </returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetKeyPressed();

    /// <summary>
    /// Get char pressed (unicode), call it multiple times for chars queued, returns 0 when the queue is empty.
    /// </summary>
    /// <returns>The ASCII value of the character that was last pressed in the keyboard.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCharPressed();

    /// <summary>
    /// Set a custom key to exit program (default is ESC).
    /// </summary>
    /// <param name="key">The keyboard key used as the exit key.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetExitKey(KeyboardKey key);

    /// <summary>
    /// Check if a gamepad is available.
    /// </summary>
    /// <param name="gamepad">The gamepad number.</param>
    /// <returns>True if the gamepad is available, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsGamepadAvailable(int gamepad);

    /// <summary>
    /// Get gamepad internal name id.
    /// </summary>
    /// <param name="gamepad">The index of the gamepad.</param>
    /// <returns>The name of the gamepad.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetGamepadName(int gamepad);

    /// <summary>
    /// Check if a gamepad button has been pressed once.
    /// </summary>
    /// <param name="gamepad">The index of the gamepad.</param>
    /// <param name="button">The gamepad button to check.</param>
    /// <returns>True if the button is currently pressed; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsGamepadButtonPressed(int gamepad, GamepadButton button);

    /// <summary>
    /// Check if a gamepad button is being pressed.
    /// </summary>
    /// <param name="gamepad">The index of the gamepad.</param>
    /// <param name="button">The button to check.</param>
    /// <returns>True if the button is being pressed down, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsGamepadButtonDown(int gamepad, GamepadButton button);

    /// <summary>
    /// Check if a gamepad button has been released once.
    /// </summary>
    /// <param name="gamepad">Gamepad number</param>
    /// <param name="button">Gamepad button</param>
    /// <returns>True if the gamepad button has been released, false otherwise</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsGamepadButtonReleased(int gamepad, GamepadButton button);

    /// <summary>
    /// Check if a gamepad button is NOT being pressed.
    /// </summary>
    /// <param name="gamepad">The gamepad index.</param>
    /// <param name="button">The gamepad button to check.</param>
    /// <returns>Returns true if the gamepad button is not being held down; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsGamepadButtonUp(int gamepad, GamepadButton button);

    /// <summary>
    /// Get the last gamepad button pressed.
    /// </summary>
    /// <returns>True if the button is pressed, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGamepadButtonPressed();

    /// <summary>
    /// Get gamepad axis count for a gamepad.
    /// </summary>
    /// <param name="gamepad">The gamepad index.</param>
    /// <returns>The number of axis for the specified gamepad.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGamepadAxisCount(int gamepad);

    /// <summary>
    /// Get axis movement value for a gamepad axis.
    /// </summary>
    /// <param name="gamepad">The gamepad index.</param>
    /// <param name="axis">The axis to retrieve the movement from.</param>
    /// <returns>The movement value of the specified axis. This value ranges between -1.0f and 1.0f.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGamepadAxisMovement(int gamepad, GamepadAxis axis);

    /// <summary>
    /// Set internal gamepad mappings (SDL_GameControllerDB).
    /// </summary>
    /// <param name="mappings">The gamepad mappings as a string.</param>
    /// <returns>True if the gamepad mappings were set successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int SetGamepadMappings(string mappings);

    /// <summary>
    /// Check if a mouse button has been pressed once.
    /// </summary>
    /// <param name="button">The button to check for.</param>
    /// <returns>Returns true if the specified mouse button is currently pressed; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsMouseButtonPressed(MouseButton button);

    /// <summary>
    /// Check if a mouse button is being pressed.
    /// </summary>
    /// <param name="button">The mouse button to check.</param>
    /// <returns>True if the mouse button is currently being pressed down; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsMouseButtonDown(MouseButton button);

    /// <summary>
    /// Check if a mouse button has been released once.
    /// </summary>
    /// <param name="button">The mouse button to check</param>
    /// <returns>True if the mouse button was released, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsMouseButtonReleased(MouseButton button);

    /// <summary>
    /// Check if a mouse button is NOT being pressed.
    /// </summary>
    /// <param name="button">The mouse button to check.</param>
    /// <returns>true if the mouse button is up; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsMouseButtonUp(MouseButton button);

    /// <summary>
    /// Get mouse position X.
    /// </summary>
    /// <returns>The x-coordinate of the mouse cursor position.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMouseX();

    /// <summary>
    /// Get mouse position Y.
    /// </summary>
    /// <returns>The Y position of the mouse cursor.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMouseY();

    /// <summary>
    /// Get mouse position XY.
    /// </summary>
    /// <returns>The current position of the mouse as a <see cref="Vector2"/>.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMousePosition();

    /// <summary>
    /// Get mouse delta between frames.
    /// </summary>
    /// <returns>The delta of the mouse movement.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMouseDelta();

    /// <summary>
    /// Set mouse position XY.
    /// </summary>
    /// <param name="x">The x-coordinate of the new mouse position.</param>
    /// <param name="y">The y-coordinate of the new mouse position.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMousePosition(int x, int y);

    /// <summary>
    /// Set mouse offset.
    /// </summary>
    /// <param name="offsetX">The offset on the X-axis.</param>
    /// <param name="offsetY">The offset on the Y-axis.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseOffset(int offsetX, int offsetY);

    /// <summary>
    /// Set mouse scaling.
    /// </summary>
    /// <param name="scaleX">The X-axis scale value.</param>
    /// <param name="scaleY">The Y-axis scale value.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseScale(float scaleX, float scaleY);

    /// <summary>
    /// Get mouse wheel movement for X or Y, whichever is larger.
    /// </summary>
    /// <returns>The movement of the mouse wheel as a float value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMouseWheelMove();

    /// <summary>
    /// Get mouse wheel movement for both X and Y.
    /// </summary>
    /// <returns>The vertical movement of the mouse wheel.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMouseWheelMoveV();

    /// <summary>
    /// Set mouse cursor.
    /// </summary>
    /// <param name="cursor">The cursor type to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseCursor(MouseCursor cursor);

    /// <summary>
    /// Get touch position X for touch point 0 (relative to screen size).
    /// </summary>
    /// <returns>The horizontal position of the touch input.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchX();

    /// <summary>
    /// Get touch position Y for touch point 0 (relative to screen size).
    /// </summary>
    /// <returns>The Y position of the touch point.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchY();

    /// <summary>
    /// Get touch position XY for a touch point index (relative to screen size).
    /// </summary>
    /// <param name="index">The index of the touch point.</param>
    /// <returns>The position of the touch point as a Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetTouchPosition(int index);

    /// <summary>
    /// Get touch point identifier for given index.
    /// </summary>
    /// <param name="index">The index of the touch point.</param>
    /// <returns>The touch point ID.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchPointId(int index);

    /// <summary>
    /// Get number of touch points.
    /// </summary>
    /// <returns>The number of touch points currently active on the screen.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchPointCount();

    /// <summary>
    /// Enable a set of gestures using flags.
    /// </summary>
    /// <param name="flags">The bitwise OR of the gestures to enable.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetGesturesEnabled(Gesture flags);

    /// <summary>
    /// Check if a gesture have been detected.
    /// </summary>
    /// <param name="gesture">The gesture to check for detection.</param>
    /// <returns>True if the specified gesture is detected, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsGestureDetected(Gesture gesture);

    /// <summary>
    /// Get latest detected gesture.
    /// </summary>
    /// <returns>The type of gesture detected.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGestureDetected();

    /// <summary>
    /// Get gesture hold time in milliseconds.
    /// </summary>
    /// <returns>The hold duration of the gesture in seconds.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGestureHoldDuration();

    /// <summary>
    /// Get gesture drag vector.
    /// </summary>
    /// <returns>The direction vector of the drag gesture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetGestureDragVector();

    /// <summary>
    /// Get gesture drag angle.
    /// </summary>
    /// <returns>The drag angle of the gesture in degrees.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGestureDragAngle();

    /// <summary>
    /// Get gesture pinch delta.
    /// </summary>
    /// <returns>The pinch gesture vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetGesturePinchVector();

    /// <summary>
    /// Get gesture pinch angle.
    /// </summary>
    /// <returns>The angle of the pinch gesture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGesturePinchAngle();

    /// <summary>
    /// Register all input events.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PollInputEvents();
}