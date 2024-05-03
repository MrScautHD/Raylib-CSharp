using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Audio.Managers;

public static partial class WaveManager {

    /// <summary>
    /// Load wave data from file.
    /// </summary>
    /// <param name="fileName">File name to load wave data from</param>
    /// <returns>Wave structure containing loaded data</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Wave LoadWave(string fileName);

    /// <summary>
    /// Load wave from memory buffer, fileType refers to extension: i.e. '.wav'.
    /// </summary>
    /// <param name="fileType">Type of the file containing wave data</param>
    /// <param name="fileData">Pointer to the memory block containing wave data</param>
    /// <param name="dataSize">Size of the memory block in bytes</param>
    /// <returns>Wave structure containing loaded data</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Wave LoadWaveFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Checks if wave data is ready.
    /// </summary>
    /// <param name="wave">The wave structure to check.</param>
    /// <returns>True if the wave data is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsWaveReady(Wave wave);

    /// <summary>
    /// Unload wave data.
    /// </summary>
    /// <param name="wave">Wave structure to unload</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadWave(Wave wave);

    /// <summary>
    /// Export wave data to file, returns true on success.
    /// </summary>
    /// <param name="wave">Wave structure containing data to be exported</param>
    /// <param name="fileName">File name to export wave data to</param>
    /// <returns>True if wave data was successfully exported, false otherwise</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ExportWave(Wave wave, string fileName);

    /// <summary>
    /// Export wave sample data to code (.h), returns true on success.
    /// </summary>
    /// <param name="wave">Wave structure containing the data to be exported as code</param>
    /// <param name="fileName">File name to save the exported code</param>
    /// <returns>True if the wave data was successfully exported as code, false otherwise</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ExportWaveAsCode(Wave wave, string fileName);

    /// <summary>
    /// Copy a wave to a new wave.
    /// </summary>
    /// <param name="wave">The Wave structure to be copied.</param>
    /// <returns>A new Wave structure that is a copy of the original.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Wave WaveCopy(Wave wave);

    /// <summary>
    /// Crop a wave to defined samples range.
    /// </summary>
    /// <param name="wave">The wave to crop</param>
    /// <param name="initSample">The initial sample to start cropping from</param>
    /// <param name="finalSample">The final sample to end cropping at</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void WaveCrop(ref Wave wave, int initSample, int finalSample);

    /// <summary>
    /// Convert wave data to desired format.
    /// </summary>
    /// <param name="wave">The wave structure to format</param>
    /// <param name="sampleRate">The sample rate of the wave</param>
    /// <param name="sampleSize">The sample size of the wave</param>
    /// <param name="channels">The number of channels of the wave</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void WaveFormat(ref Wave wave, int sampleRate, int sampleSize, int channels);

    /// <summary>
    /// Load samples data from wave as a 32bit float data array.
    /// </summary>
    /// <param name="wave">The wave data to load the samples from.</param>
    /// <returns>A pointer to the loaded samples.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial float* LoadWaveSamples(Wave wave);

    /// <summary>
    /// Unload samples data loaded with LoadWaveSamples().
    /// </summary>
    /// <param name="samples">Pointer to the samples data</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadWaveSamples(float* samples);
}