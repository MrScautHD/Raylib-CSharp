using Raylib_CSharp.Apis;

namespace Raylib_CSharp;

public static class Time {

    /// <inheritdoc cref="RaylibApi.SetTargetFPS" />
    public static void SetTargetFPS(int fps) {
        RaylibApi.SetTargetFPS(fps);
    }

    /// <inheritdoc cref="RaylibApi.GetFrameTime" />
    public static float GetFrameTime() {
        return RaylibApi.GetFrameTime();
    }

    /// <inheritdoc cref="RaylibApi.GetTime" />
    public static double GetTime() {
        return RaylibApi.GetTime();
    }

    /// <inheritdoc cref="RaylibApi.GetFPS" />
    public static int GetFPS() {
        return RaylibApi.GetFPS();
    }

    /// <inheritdoc cref="RaylibApi.WaitTime" />
    public static void WaitTime(double seconds) {
        RaylibApi.WaitTime(seconds);
    }
}