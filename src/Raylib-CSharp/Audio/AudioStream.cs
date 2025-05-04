using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public struct AudioStream {

    /// <summary>
    /// Pointer to internal data used by the audio system.
    /// </summary>
    public nint Buffer;

    /// <summary>
    /// Pointer to internal data processor, useful for audio effects.
    /// </summary>
    public nint Processor;

    /// <summary>
    /// Frequency (samples per second).
    /// </summary>
    public uint SampleRate;

    /// <summary>
    /// Bit depth (bits per sample): 8, 16, 32 (24 not supported).
    /// </summary>
    public uint SampleSize;

    /// <summary>
    /// Number of channels (1-mono, 2-stereo, ...).
    /// </summary>
    public uint Channels;

    /// <inheritdoc cref="RaylibApi.LoadAudioStream" />
    public static AudioStream Load(uint sampleRate, uint sampleSize, uint channels) {
        return RaylibApi.LoadAudioStream(sampleRate, sampleSize, channels);
    }

    /// <inheritdoc cref="RaylibApi.SetAudioStreamBufferSizeDefault" />
    public static void SetBufferSizeDefault(int size) {
        RaylibApi.SetAudioStreamBufferSizeDefault(size);
    }

    /// <inheritdoc cref="RaylibApi.SetAudioStreamCallback" />
    public static unsafe void SetCallback(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> callback) {
        RaylibApi.SetAudioStreamCallback(stream, callback);
    }

    /// <inheritdoc cref="RaylibApi.AttachAudioStreamProcessor" />
    public static unsafe void AttachProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> processor) {
        RaylibApi.AttachAudioStreamProcessor(stream, processor);
    }

    /// <inheritdoc cref="RaylibApi.DetachAudioStreamProcessor" />
    public static unsafe void DetachProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> processor) {
        RaylibApi.DetachAudioStreamProcessor(stream, processor);
    }

    /// <inheritdoc cref="RaylibApi.AttachAudioMixedProcessor" />
    public static unsafe void AttachMixedProcessor(delegate* unmanaged[Cdecl]<nint, uint, void> processor) {
        RaylibApi.AttachAudioMixedProcessor(processor);
    }

    /// <inheritdoc cref="RaylibApi.DetachAudioMixedProcessor" />
    public static unsafe void DetachMixedProcessor(delegate* unmanaged[Cdecl]<nint, uint, void> processor) {
        RaylibApi.DetachAudioMixedProcessor(processor);
    }

    /// <inheritdoc cref="RaylibApi.IsAudioStreamValid" />
    public bool IsValid() {
        return RaylibApi.IsAudioStreamValid(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadAudioStream" />
    public void Unload() {
        RaylibApi.UnloadAudioStream(this);
    }

    /// <inheritdoc cref="RaylibApi.UpdateAudioStream" />
    public void Update(nint data, int frameCount) {
        RaylibApi.UpdateAudioStream(this, data, frameCount);
    }

    /// <inheritdoc cref="RaylibApi.IsAudioStreamProcessed" />
    public bool IsProcessed() {
        return RaylibApi.IsAudioStreamProcessed(this);
    }

    /// <inheritdoc cref="RaylibApi.PlayAudioStream" />
    public void Play() {
        RaylibApi.PlayAudioStream(this);
    }

    /// <inheritdoc cref="RaylibApi.PauseAudioStream" />
    public void Pause() {
        RaylibApi.PauseAudioStream(this);
    }

    /// <inheritdoc cref="RaylibApi.ResumeAudioStream" />
    public void Resume() {
        RaylibApi.ResumeAudioStream(this);
    }

    /// <inheritdoc cref="RaylibApi.IsAudioStreamPlaying" />
    public bool IsPlaying() {
        return RaylibApi.IsAudioStreamPlaying(this);
    }

    /// <inheritdoc cref="RaylibApi.StopAudioStream" />
    public void Stop() {
        RaylibApi.StopAudioStream(this);
    }

    /// <inheritdoc cref="RaylibApi.SetAudioStreamVolume" />
    public void SetVolume(float volume) {
        RaylibApi.SetAudioStreamVolume(this, volume);
    }

    /// <inheritdoc cref="RaylibApi.SetAudioStreamPitch" />
    public void SetPitch(float pitch) {
        RaylibApi.SetAudioStreamPitch(this, pitch);
    }

    /// <inheritdoc cref="RaylibApi.SetAudioStreamPan" />
    public void SetPan(float pan) {
        RaylibApi.SetAudioStreamPan(this, pan);
    }
}