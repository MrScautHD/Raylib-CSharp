using System.Numerics;
using Raylib_CSharp.Images;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Windowing;

public static class Window {

    /// <inheritdoc cref="RaylibApi.InitWindow" />
    public static void Init(int width, int height, string title) {
        RaylibApi.InitWindow(width, height, title);
    }

    /// <inheritdoc cref="RaylibApi.CloseWindow" />
    public static void Close() {
        RaylibApi.CloseWindow();
    }

    /// <inheritdoc cref="RaylibApi.WindowShouldClose" />
    public static bool ShouldClose() {
        return RaylibApi.WindowShouldClose();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowReady" />
    public static bool IsReady() {
        return RaylibApi.IsWindowReady();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowFullscreen" />
    public static bool IsFullscreen() {
        return RaylibApi.IsWindowFullscreen();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowHidden" />
    public static bool IsHidden() {
        return RaylibApi.IsWindowHidden();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowMinimized" />
    public static bool IsMinimized() {
        return RaylibApi.IsWindowMinimized();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowMaximized" />
    public static bool IsMaximized() {
        return RaylibApi.IsWindowMaximized();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowFocused" />
    public static bool IsFocused() {
        return RaylibApi.IsWindowFocused();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowResized" />
    public static bool IsResized() {
        return RaylibApi.IsWindowResized();
    }

    /// <inheritdoc cref="RaylibApi.IsWindowState" />
    public static bool IsState(ConfigFlags flag) {
        return RaylibApi.IsWindowState(flag);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowState" />
    public static void SetState(ConfigFlags flag) {
        RaylibApi.SetWindowState(flag);
    }

    /// <inheritdoc cref="RaylibApi.ClearWindowState" />
    public static void ClearState(ConfigFlags flag) {
        RaylibApi.ClearWindowState(flag);
    }

    /// <inheritdoc cref="RaylibApi.ToggleFullscreen" />
    public static void ToggleFullscreen() {
        RaylibApi.ToggleFullscreen();
    }

    /// <inheritdoc cref="RaylibApi.ToggleBorderlessWindowed" />
    public static void ToggleBorderless() {
        RaylibApi.ToggleBorderlessWindowed();
    }

    /// <inheritdoc cref="RaylibApi.MaximizeWindow" />
    public static void Maximize() {
        RaylibApi.MaximizeWindow();
    }

    /// <inheritdoc cref="RaylibApi.MinimizeWindow" />
    public static void Minimize() {
        RaylibApi.MinimizeWindow();
    }

    /// <inheritdoc cref="RaylibApi.RestoreWindow" />
    public static void Restore() {
        RaylibApi.RestoreWindow();
    }

    /// <inheritdoc cref="RaylibApi.SetWindowIcon" />
    public static void SetIcon(Image image) {
        RaylibApi.SetWindowIcon(image);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowIcons" />
    public static unsafe void SetIcons(Span<Image> images) {
        fixed (Image* imagesPtr = images) {
            RaylibApi.SetWindowIcons(imagesPtr, images.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.SetWindowTitle" />
    public static void SetTitle(string title) {
        RaylibApi.SetWindowTitle(title);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowPosition" />
    public static void SetPosition(int x, int y) {
        RaylibApi.SetWindowPosition(x, y);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowMonitor" />
    public static void SetMonitor(int monitor) {
        RaylibApi.SetWindowMonitor(monitor);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowMinSize" />
    public static void SetMinSize(int width, int height) {
        RaylibApi.SetWindowMinSize(width, height);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowMaxSize" />
    public static void SetMaxSize(int width, int height) {
        RaylibApi.SetWindowMaxSize(width, height);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowSize" />
    public static void SetSize(int width, int height) {
        RaylibApi.SetWindowSize(width, height);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowOpacity" />
    public static void SetOpacity(float opacity) {
        RaylibApi.SetWindowOpacity(opacity);
    }

    /// <inheritdoc cref="RaylibApi.SetWindowFocused" />
    public static void SetFocused() {
        RaylibApi.SetWindowFocused();
    }

    /// <inheritdoc cref="RaylibApi.GetWindowHandle" />
    public static nint GetHandle() {
        return RaylibApi.GetWindowHandle();
    }

    /// <inheritdoc cref="RaylibApi.GetScreenWidth" />
    public static int GetScreenWidth() {
        return RaylibApi.GetScreenWidth();
    }

    /// <inheritdoc cref="RaylibApi.GetScreenHeight" />
    public static int GetScreenHeight() {
        return RaylibApi.GetScreenHeight();
    }

    /// <inheritdoc cref="RaylibApi.GetRenderWidth" />
    public static int GetRenderWidth() {
        return RaylibApi.GetRenderWidth();
    }

    /// <inheritdoc cref="RaylibApi.GetRenderHeight" />
    public static int GetRenderHeight() {
        return RaylibApi.GetRenderHeight();
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorCount" />
    public static int GetMonitorCount() {
        return RaylibApi.GetMonitorCount();
    }

    /// <inheritdoc cref="RaylibApi.GetCurrentMonitor" />
    public static int GetCurrentMonitor() {
        return RaylibApi.GetCurrentMonitor();
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorPosition" />
    public static Vector2 GetMonitorPosition(int monitor) {
        return RaylibApi.GetMonitorPosition(monitor);
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorWidth" />
    public static int GetMonitorWidth(int monitor) {
        return RaylibApi.GetMonitorWidth(monitor);
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorHeight" />
    public static int GetMonitorHeight(int monitor) {
        return RaylibApi.GetMonitorHeight(monitor);
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorPhysicalWidth" />
    public static int GetMonitorPhysicalWidth(int monitor) {
        return RaylibApi.GetMonitorPhysicalWidth(monitor);
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorPhysicalHeight" />
    public static int GetMonitorPhysicalHeight(int monitor) {
        return RaylibApi.GetMonitorPhysicalHeight(monitor);
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorRefreshRate" />
    public static int GetMonitorRefreshRate(int monitor) {
        return RaylibApi.GetMonitorRefreshRate(monitor);
    }

    /// <inheritdoc cref="RaylibApi.GetWindowPosition" />
    public static Vector2 GetPosition() {
        return RaylibApi.GetWindowPosition();
    }

    /// <inheritdoc cref="RaylibApi.GetWindowScaleDPI" />
    public static Vector2 GetScaleDPI() {
        return RaylibApi.GetWindowScaleDPI();
    }

    /// <inheritdoc cref="RaylibApi.GetMonitorName" />
    public static string GetMonitorName(int monitor) {
        return RaylibApi.GetMonitorName(monitor);
    }

    /// <inheritdoc cref="RaylibApi.SetClipboardText" />
    public static void SetClipboardText(string text) {
        RaylibApi.SetClipboardText(text);
    }

    /// <inheritdoc cref="RaylibApi.GetClipboardText" />
    public static string GetClipboardText() {
        return RaylibApi.GetClipboardText();
    }

    /// <inheritdoc cref="RaylibApi.GetClipboardImage" />
    public static Image GetClipboardImage() {
        return RaylibApi.GetClipboardImage();
    }

    /// <inheritdoc cref="RaylibApi.EnableEventWaiting" />
    public static void EnableEventWaiting() {
        RaylibApi.EnableEventWaiting();
    }

    /// <inheritdoc cref="RaylibApi.DisableEventWaiting" />
    public static void DisableEventWaiting() {
        RaylibApi.DisableEventWaiting();
    }
}