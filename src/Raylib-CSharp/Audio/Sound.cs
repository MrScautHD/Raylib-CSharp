using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public struct Sound {

    /// <summary>
    /// Audio stream.
    /// </summary>
    public AudioStream Stream;

    /// <summary>
    /// Total number of frames (considering channels).
    /// </summary>
    public uint FrameCount;

    /// <inheritdoc cref="RaylibApi.LoadSound" />
    public static Sound Load(string fileName) {
        return RaylibApi.LoadSound(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadSoundFromWave" />
    public static Sound LoadFromWave(Wave wave) {
        return RaylibApi.LoadSoundFromWave(wave);
    }

    /// <inheritdoc cref="RaylibApi.LoadSoundAlias" />
    public static Sound LoadAlias(Sound source) {
        return RaylibApi.LoadSoundAlias(source);
    }

    /// <inheritdoc cref="RaylibApi.IsSoundReady" />
    public bool IsReady() {
        return RaylibApi.IsSoundReady(this);
    }

    /// <inheritdoc cref="RaylibApi.UpdateSound" />
    public void Update(nint data, int sampleCount) {
        RaylibApi.UpdateSound(this, data, sampleCount);
    }

    /// <inheritdoc cref="RaylibApi.UnloadSound" />
    public void Unload() {
        RaylibApi.UnloadSound(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadSoundAlias" />
    public void UnloadAlias() {
        RaylibApi.UnloadSoundAlias(this);
    }

    /// <inheritdoc cref="RaylibApi.PlaySound" />
    public void Play() {
        RaylibApi.PlaySound(this);
    }

    /// <inheritdoc cref="RaylibApi.StopSound" />
    public void Stop() {
        RaylibApi.StopSound(this);
    }

    /// <inheritdoc cref="RaylibApi.PauseSound" />
    public void Pause() {
        RaylibApi.PauseSound(this);
    }

    /// <inheritdoc cref="RaylibApi.ResumeSound" />
    public void Resume() {
        RaylibApi.ResumeSound(this);
    }

    /// <inheritdoc cref="RaylibApi.IsSoundPlaying" />
    public bool IsPlaying() {
        return RaylibApi.IsSoundPlaying(this);
    }

    /// <inheritdoc cref="RaylibApi.SetSoundVolume" />
    public void SetVolume(float volume) {
        RaylibApi.SetSoundVolume(this, volume);
    }

    /// <inheritdoc cref="RaylibApi.SetSoundPitch" />
    public void SetPitch(float pitch) {
        RaylibApi.SetSoundPitch(this, pitch);
    }

    /// <inheritdoc cref="RaylibApi.SetSoundPan" />
    public void SetPan(float pan) {
        RaylibApi.SetSoundPan(this, pan);
    }
}