using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public struct Music {

    /// <summary>
    /// Audio stream.
    /// </summary>
    public AudioStream Stream;

    /// <summary>
    /// Total number of frames (considering channels).
    /// </summary>
    public uint FrameCount;

    /// <summary>
    /// Music looping enable.
    /// </summary>
    public bool Looping;

    /// <summary>
    /// Type of music context (audio filetype).
    /// </summary>
    public int CtxType;

    /// <summary>
    /// Audio context data, depends on type.
    /// </summary>
    public nint CtxData;

    /// <inheritdoc cref="RaylibApi.LoadMusicStream" />
    public static Music Load(string fileName) {
        return RaylibApi.LoadMusicStream(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadMusicStreamFromMemory" />
    public static unsafe Music LoadFromMemory(string fileType, ReadOnlySpan<byte> data) {
        fixed (byte* dataPtr = data) {
            return RaylibApi.LoadMusicStreamFromMemory(fileType, dataPtr, data.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.IsMusicReady" />
    public bool IsReady() {
        return RaylibApi.IsMusicReady(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadMusicStream" />
    public void UnloadStream() {
        RaylibApi.UnloadMusicStream(this);
    }

    /// <inheritdoc cref="RaylibApi.PlayMusicStream" />
    public void PlayStream() {
        RaylibApi.PlayMusicStream(this);
    }

    /// <inheritdoc cref="RaylibApi.IsMusicStreamPlaying" />
    public bool IsStreamPlaying() {
        return RaylibApi.IsMusicStreamPlaying(this);
    }

    /// <inheritdoc cref="RaylibApi.UpdateMusicStream" />
    public void UpdateStream() {
        RaylibApi.UpdateMusicStream(this);
    }

    /// <inheritdoc cref="RaylibApi.StopMusicStream" />
    public void StopStream() {
        RaylibApi.StopMusicStream(this);
    }

    /// <inheritdoc cref="RaylibApi.PauseMusicStream" />
    public void PauseStream() {
        RaylibApi.PauseMusicStream(this);
    }

    /// <inheritdoc cref="RaylibApi.ResumeMusicStream" />
    public void ResumeStream() {
        RaylibApi.ResumeMusicStream(this);
    }

    /// <inheritdoc cref="RaylibApi.SeekMusicStream" />
    public void SeekStream(float position) {
        RaylibApi.SeekMusicStream(this, position);
    }

    /// <inheritdoc cref="RaylibApi.SetMusicVolume" />
    public void SetVolume(float volume) {
        RaylibApi.SetMusicVolume(this, volume);
    }

    /// <inheritdoc cref="RaylibApi.SetMusicPitch" />
    public void SetPitch(float pitch) {
        RaylibApi.SetMusicPitch(this, pitch);
    }

    /// <inheritdoc cref="RaylibApi.SetMusicPan" />
    public void SetPan(float pan) {
        RaylibApi.SetMusicPan(this, pan);
    }

    /// <inheritdoc cref="RaylibApi.GetMusicTimeLength" />
    public float GetTimeLength() {
        return RaylibApi.GetMusicTimeLength(this);
    }

    /// <inheritdoc cref="RaylibApi.GetMusicTimePlayed" />
    public float GetTimePlayed() {
        return RaylibApi.GetMusicTimePlayed(this);
    }
}