using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Audio;

public static class AudioDevice {

    /// <inheritdoc cref="RaylibApi.InitAudioDevice" />
    public static void Init() {
        RaylibApi.InitAudioDevice();
    }

    /// <inheritdoc cref="RaylibApi.CloseAudioDevice" />
    public static void Close() {
        RaylibApi.CloseAudioDevice();
    }

    /// <inheritdoc cref="RaylibApi.IsAudioDeviceReady" />
    public static bool IsReady() {
        return RaylibApi.IsAudioDeviceReady();
    }

    /// <inheritdoc cref="RaylibApi.SetMasterVolume" />
    public static void SetMasterVolume(float volume) {
        RaylibApi.SetMasterVolume(volume);
    }

    /// <inheritdoc cref="RaylibApi.GetMasterVolume" />
    public static float GetMasterVolume() {
        return RaylibApi.GetMasterVolume();
    }
}