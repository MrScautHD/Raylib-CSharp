using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public partial struct Wave {

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

    /// <summary>
    /// Load wave data from file.
    /// </summary>
    /// <param name="fileName">File name to load wave data from</param>
    /// <returns>Wave structure containing loaded data</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadWave", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Wave Load(string fileName);

    /// <summary>
    /// Load wave from memory buffer, fileType refers to extension: i.e. '.wav'.
    /// </summary>
    /// <param name="fileType">Type of the file containing wave data</param>
    /// <param name="fileData">Pointer to the memory block containing wave data</param>
    /// <param name="dataSize">Size of the memory block in bytes</param>
    /// <returns>Wave structure containing loaded data</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadWaveFromMemory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Wave LoadFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Load wave from memory buffer, fileType refers to extension: i.e. '.wav'.
    /// </summary>
    /// <param name="fileType">Type of the file containing wave data</param>
    /// <param name="fileData">A array to the memory block containing wave data</param>
    /// <returns>Wave structure containing loaded data</returns>
    public static unsafe Wave LoadFromMemory(string fileType, ReadOnlySpan<byte> fileData) {
        fixed (byte* fileDataPtr = fileData) {
            return LoadFromMemory(fileType, fileDataPtr, fileData.Length);
        }
    }

    /// <summary>
    /// Unload samples data loaded with LoadWaveSamples().
    /// </summary>
    /// <param name="samples">Pointer to the samples data</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadWaveSamples")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadSamples(float* samples);

    /// <summary>
    /// Unload samples data loaded with LoadWaveSamples().
    /// </summary>
    /// <param name="samples">A Span to the samples data</param>
    public static unsafe void UnloadSamplesSpan(ReadOnlySpan<float> samples) {
        fixed (float* ptr = samples) {
            UnloadSamples(ptr);
        }
    }
}

/// <summary>
/// Contains extension methods for the <see cref="Wave"/> class.
/// </summary>
public static partial class WaveExtensions {

    /// <summary>
    /// Checks if wave data is ready.
    /// </summary>
    /// <param name="wave">The wave structure to check.</param>
    /// <returns>True if the wave data is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsWaveReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(Wave wave);
    public static bool IsReady(this Wave wave) => IsReady_(wave);

    /// <summary>
    /// Unload wave data.
    /// </summary>
    /// <param name="wave">Wave structure to unload</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadWave")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(Wave wave);
    public static void Unload(this Wave wave) => Unload_(wave);

    /// <summary>
    /// Export wave data to file, returns true on success.
    /// </summary>
    /// <param name="wave">Wave structure containing data to be exported</param>
    /// <param name="fileName">File name to export wave data to</param>
    /// <returns>True if wave data was successfully exported, false otherwise</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportWave", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool Export_(Wave wave, string fileName);
    public static bool Export(this Wave wave, string fileName) => Export_(wave, fileName);

    /// <summary>
    /// Export wave sample data to code (.h), returns true on success.
    /// </summary>
    /// <param name="wave">Wave structure containing the data to be exported as code</param>
    /// <param name="fileName">File name to save the exported code</param>
    /// <returns>True if the wave data was successfully exported as code, false otherwise</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportWaveAsCode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool ExportAsCode_(Wave wave, string fileName);
    public static bool ExportAsCode(this Wave wave, string fileName) => ExportAsCode_(wave, fileName);

    /// <summary>
    /// Copy a wave to a new wave.
    /// </summary>
    /// <param name="wave">The Wave structure to be copied.</param>
    /// <returns>A new Wave structure that is a copy of the original.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "WaveCopy")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Wave Copy_(Wave wave);
    public static Wave Copy(this Wave wave) => Copy_(wave);

    /// <summary>
    /// Crop a wave to defined samples range.
    /// </summary>
    /// <param name="wave">The wave to crop</param>
    /// <param name="initSample">The initial sample to start cropping from</param>
    /// <param name="finalSample">The final sample to end cropping at</param>
    [LibraryImport(Raylib.Name, EntryPoint = "WaveCrop")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Crop_(ref Wave wave, int initSample, int finalSample);
    public static void Crop(this ref Wave wave, int initSample, int finalSample) => Crop_(ref wave, initSample, finalSample);

    /// <summary>
    /// Convert wave data to desired format.
    /// </summary>
    /// <param name="wave">The wave structure to format</param>
    /// <param name="sampleRate">The sample rate of the wave</param>
    /// <param name="sampleSize">The sample size of the wave</param>
    /// <param name="channels">The number of channels of the wave</param>
    [LibraryImport(Raylib.Name, EntryPoint = "WaveFormat")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Format_(ref Wave wave, int sampleRate, int sampleSize, int channels);
    public static void Format(this ref Wave wave, int sampleRate, int sampleSize, int channels) => Format_(ref wave, sampleRate, sampleSize, channels);

    /// <summary>
    /// Load samples data from wave as a 32bit float data array.
    /// </summary>
    /// <param name="wave">The wave data to load the samples from.</param>
    /// <returns>A pointer to the loaded samples.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadWaveSamples")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial float* LoadSamples_(Wave wave);
    public static unsafe float* LoadSamples(this Wave wave) => LoadSamples_(wave);

    /// <summary>
    /// Load samples data from wave as a 32bit float data array.
    /// </summary>
    /// <param name="wave">The wave data to load the samples from.</param>
    /// <returns>A Span to the loaded samples.</returns>
    private static unsafe ReadOnlySpan<float> LoadSamplesSpan_(Wave wave) {
        return new ReadOnlySpan<float>(LoadSamples_(wave), (int) (wave.FrameCount * wave.Channels));
    }
    public static ReadOnlySpan<float> LoadSamplesSpan(this Wave wave) => LoadSamplesSpan_(wave);
}