using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public struct Wave {

    /// <summary>
    /// Total number of frames (considering channels).
    /// </summary>
    public uint FrameCount;

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

    /// <summary>
    /// Buffer data pointer.
    /// </summary>
    public nint Data;

    /// <inheritdoc cref="RaylibApi.LoadWave" />
    public static Wave Load(string fileName) {
        return RaylibApi.LoadWave(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadWaveFromMemory" />
    public static unsafe Wave LoadFromMemory(string fileType, ReadOnlySpan<byte> fileData) {
        fixed (byte* fileDataPtr = fileData) {
            return RaylibApi.LoadWaveFromMemory(fileType, fileDataPtr, fileData.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.UnloadWaveSamples" />
    public static unsafe void UnloadSamples(ReadOnlySpan<float> samples) {
        fixed (float* samplesPtr = samples) {
            RaylibApi.UnloadWaveSamples(samplesPtr);
        }
    }

    /// <inheritdoc cref="RaylibApi.IsWaveReady" />
    public bool IsReady() {
        return RaylibApi.IsWaveReady(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadWave" />
    public void Unload() {
        RaylibApi.UnloadWave(this);
    }

    /// <inheritdoc cref="RaylibApi.ExportWave" />
    public bool Export(string fileName) {
        return RaylibApi.ExportWave(this, fileName);
    }

    /// <inheritdoc cref="RaylibApi.ExportWaveAsCode" />
    public bool ExportAsCode(string fileName) {
        return RaylibApi.ExportWaveAsCode(this, fileName);
    }

    /// <inheritdoc cref="RaylibApi.WaveCopy" />
    public Wave Copy() {
        return RaylibApi.WaveCopy(this);
    }

    /// <inheritdoc cref="RaylibApi.WaveCrop" />
    public void Crop(int initSample, int finalSample) {
        RaylibApi.WaveCrop(ref this, initSample, finalSample);
    }

    /// <inheritdoc cref="RaylibApi.WaveFormat" />
    public void Format(int sampleRate, int sampleSize, int channels) {
        RaylibApi.WaveFormat(ref this, sampleRate, sampleSize, channels);
    }

    /// <inheritdoc cref="RaylibApi.LoadWaveSamples" />
    public unsafe ReadOnlySpan<float> LoadSamples() {
        return new ReadOnlySpan<float>(RaylibApi.LoadWaveSamples(this), (int) (this.FrameCount * this.Channels));
    }
}