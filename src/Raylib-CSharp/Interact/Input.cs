using System.Numerics;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Interact;

public static class Input {

    /// <inheritdoc cref="RaylibApi.ShowCursor" />
    public static void ShowCursor() {
        RaylibApi.ShowCursor();
    }

    /// <inheritdoc cref="RaylibApi.HideCursor" />
    public static void HideCursor() {
        RaylibApi.HideCursor();
    }

    /// <inheritdoc cref="RaylibApi.IsCursorHidden" />
    public static bool IsCursorHidden() {
        return RaylibApi.IsCursorHidden();
    }

    /// <inheritdoc cref="RaylibApi.EnableCursor" />
    public static void EnableCursor() {
        RaylibApi.EnableCursor();
    }

    /// <inheritdoc cref="RaylibApi.DisableCursor" />
    public static void DisableCursor() {
        RaylibApi.DisableCursor();
    }

    /// <inheritdoc cref="RaylibApi.IsCursorOnScreen" />
    public static bool IsCursorOnScreen() {
        return RaylibApi.IsCursorOnScreen();
    }

    /// <inheritdoc cref="RaylibApi.IsKeyPressed" />
    public static bool IsKeyPressed(KeyboardKey key) {
        return RaylibApi.IsKeyPressed(key);
    }

    /// <inheritdoc cref="RaylibApi.IsKeyPressedRepeat" />
    public static bool IsKeyPressedRepeat(KeyboardKey key) {
        return RaylibApi.IsKeyPressedRepeat(key);
    }

    /// <inheritdoc cref="RaylibApi.IsKeyDown" />
    public static bool IsKeyDown(KeyboardKey key) {
        return RaylibApi.IsKeyDown(key);
    }

    /// <inheritdoc cref="RaylibApi.IsKeyReleased" />
    public static bool IsKeyReleased(KeyboardKey key) {
        return RaylibApi.IsKeyReleased(key);
    }

    /// <inheritdoc cref="RaylibApi.IsKeyUp" />
    public static bool IsKeyUp(KeyboardKey key) {
        return RaylibApi.IsKeyUp(key);
    }

    /// <inheritdoc cref="RaylibApi.GetKeyPressed" />
    public static int GetKeyPressed() {
        return RaylibApi.GetKeyPressed();
    }

    /// <inheritdoc cref="RaylibApi.GetCharPressed" />
    public static int GetCharPressed() {
        return RaylibApi.GetCharPressed();
    }

    /// <inheritdoc cref="RaylibApi.SetExitKey" />
    public static void SetExitKey(KeyboardKey key) {
        RaylibApi.SetExitKey(key);
    }

    /// <inheritdoc cref="RaylibApi.IsGamepadAvailable" />
    public static bool IsGamepadAvailable(int gamepad) {
        return RaylibApi.IsGamepadAvailable(gamepad);
    }

    /// <inheritdoc cref="RaylibApi.GetGamepadName" />
    public static string GetGamepadName(int gamepad) {
        return RaylibApi.GetGamepadName(gamepad);
    }

    /// <inheritdoc cref="RaylibApi.IsGamepadButtonPressed" />
    public static bool IsGamepadButtonPressed(int gamepad, GamepadButton button) {
        return RaylibApi.IsGamepadButtonPressed(gamepad, button);
    }

    /// <inheritdoc cref="RaylibApi.IsGamepadButtonDown" />
    public static bool IsGamepadButtonDown(int gamepad, GamepadButton button) {
        return RaylibApi.IsGamepadButtonDown(gamepad, button);
    }

    /// <inheritdoc cref="RaylibApi.IsGamepadButtonReleased" />
    public static bool IsGamepadButtonReleased(int gamepad, GamepadButton button) {
        return RaylibApi.IsGamepadButtonReleased(gamepad, button);
    }

    /// <inheritdoc cref="RaylibApi.IsGamepadButtonUp" />
    public static bool IsGamepadButtonUp(int gamepad, GamepadButton button) {
        return RaylibApi.IsGamepadButtonUp(gamepad, button);
    }

    /// <inheritdoc cref="RaylibApi.GetGamepadButtonPressed" />
    public static int GetGamepadButtonPressed() {
        return RaylibApi.GetGamepadButtonPressed();
    }

    /// <inheritdoc cref="RaylibApi.GetGamepadAxisCount" />
    public static int GetGamepadAxisCount(int gamepad) {
        return RaylibApi.GetGamepadAxisCount(gamepad);
    }

    /// <inheritdoc cref="RaylibApi.GetGamepadAxisMovement" />
    public static float GetGamepadAxisMovement(int gamepad, GamepadAxis axis) {
        return RaylibApi.GetGamepadAxisMovement(gamepad, axis);
    }

    /// <inheritdoc cref="RaylibApi.SetGamepadMappings" />
    public static int SetGamepadMappings(string mappings) {
        return RaylibApi.SetGamepadMappings(mappings);
    }

    /// <inheritdoc cref="RaylibApi.SetGamepadVibration" />
    public static void SetGamepadVibration(int gamepad, float leftMotor, float rightMotor, float duration) {
        RaylibApi.SetGamepadVibration(gamepad, leftMotor, rightMotor, duration);
    }

    /// <inheritdoc cref="RaylibApi.IsMouseButtonPressed" />
    public static bool IsMouseButtonPressed(MouseButton button) {
        return RaylibApi.IsMouseButtonPressed(button);
    }

    /// <inheritdoc cref="RaylibApi.IsMouseButtonDown" />
    public static bool IsMouseButtonDown(MouseButton button) {
        return RaylibApi.IsMouseButtonDown(button);
    }

    /// <inheritdoc cref="RaylibApi.IsMouseButtonReleased" />
    public static bool IsMouseButtonReleased(MouseButton button) {
        return RaylibApi.IsMouseButtonReleased(button);
    }

    /// <inheritdoc cref="RaylibApi.IsMouseButtonUp" />
    public static bool IsMouseButtonUp(MouseButton button) {
        return RaylibApi.IsMouseButtonUp(button);
    }

    /// <inheritdoc cref="RaylibApi.GetMouseX" />
    public static int GetMouseX() {
        return RaylibApi.GetMouseX();
    }

    /// <inheritdoc cref="RaylibApi.GetMouseY" />
    public static int GetMouseY() {
        return RaylibApi.GetMouseY();
    }

    /// <inheritdoc cref="RaylibApi.GetMousePosition" />
    public static Vector2 GetMousePosition() {
        return RaylibApi.GetMousePosition();
    }

    /// <inheritdoc cref="RaylibApi.GetMouseDelta" />
    public static Vector2 GetMouseDelta() {
        return RaylibApi.GetMouseDelta();
    }

    /// <inheritdoc cref="RaylibApi.SetMousePosition" />
    public static void SetMousePosition(int x, int y) {
        RaylibApi.SetMousePosition(x, y);
    }

    /// <inheritdoc cref="RaylibApi.SetMouseOffset" />
    public static void SetMouseOffset(int offsetX, int offsetY) {
        RaylibApi.SetMouseOffset(offsetX, offsetY);
    }

    /// <inheritdoc cref="RaylibApi.SetMouseScale" />
    public static void SetMouseScale(float scaleX, float scaleY) {
        RaylibApi.SetMouseScale(scaleX, scaleY);
    }

    /// <inheritdoc cref="RaylibApi.GetMouseWheelMove" />
    public static float GetMouseWheelMove() {
        return RaylibApi.GetMouseWheelMove();
    }

    /// <inheritdoc cref="RaylibApi.GetMouseWheelMoveV" />
    public static Vector2 GetMouseWheelMoveV() {
        return RaylibApi.GetMouseWheelMoveV();
    }

    /// <inheritdoc cref="RaylibApi.SetMouseCursor" />
    public static void SetMouseCursor(MouseCursor cursor) {
        RaylibApi.SetMouseCursor(cursor);
    }

    /// <inheritdoc cref="RaylibApi.GetTouchX" />
    public static int GetTouchX() {
        return RaylibApi.GetTouchX();
    }

    /// <inheritdoc cref="RaylibApi.GetTouchY" />
    public static int GetTouchY() {
        return RaylibApi.GetTouchY();
    }

    /// <inheritdoc cref="RaylibApi.GetTouchPosition" />
    public static Vector2 GetTouchPosition(int index) {
        return RaylibApi.GetTouchPosition(index);
    }

    /// <inheritdoc cref="RaylibApi.GetTouchPointId" />
    public static int GetTouchPointId(int index) {
        return RaylibApi.GetTouchPointId(index);
    }

    /// <inheritdoc cref="RaylibApi.GetTouchPointCount" />
    public static int GetTouchPointCount() {
        return RaylibApi.GetTouchPointCount();
    }

    /// <inheritdoc cref="RaylibApi.SetGesturesEnabled" />
    public static void SetGesturesEnabled(Gesture flags) {
        RaylibApi.SetGesturesEnabled(flags);
    }

    /// <inheritdoc cref="RaylibApi.IsGestureDetected" />
    public static bool IsGestureDetected(Gesture gesture) {
        return RaylibApi.IsGestureDetected(gesture);
    }

    /// <inheritdoc cref="RaylibApi.GetGestureDetected" />
    public static int GetGestureDetected() {
        return RaylibApi.GetGestureDetected();
    }

    /// <inheritdoc cref="RaylibApi.GetGestureHoldDuration" />
    public static float GetGestureHoldDuration() {
        return RaylibApi.GetGestureHoldDuration();
    }

    /// <inheritdoc cref="RaylibApi.GetGestureDragVector" />
    public static Vector2 GetGestureDragVector() {
        return RaylibApi.GetGestureDragVector();
    }

    /// <inheritdoc cref="RaylibApi.GetGestureDragAngle" />
    public static float GetGestureDragAngle() {
        return RaylibApi.GetGestureDragAngle();
    }

    /// <inheritdoc cref="RaylibApi.GetGesturePinchVector" />
    public static Vector2 GetGesturePinchVector() {
        return RaylibApi.GetGesturePinchVector();
    }

    /// <inheritdoc cref="RaylibApi.GetGesturePinchAngle" />
    public static float GetGesturePinchAngle() {
        return RaylibApi.GetGesturePinchAngle();
    }

    /// <inheritdoc cref="RaylibApi.PollInputEvents" />
    public static void PollInputEvents() {
        RaylibApi.PollInputEvents();
    }
}