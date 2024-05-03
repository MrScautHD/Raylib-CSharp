using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public partial struct AudioStream {

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

    /// <summary>
    /// Load audio stream (to stream raw audio pcm data).
    /// </summary>
    /// <param name="sampleRate">The sample rate of the audio stream.</param>
    /// <param name="sampleSize">The sample size of the audio stream.</param>
    /// <param name="channels">The number of channels in the audio stream.</param>
    /// <returns>The loaded audio stream.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadAudioStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial AudioStream Load(uint sampleRate, uint sampleSize, uint channels);

    /// <summary>
    /// Checks if an audio stream is ready.
    /// </summary>
    /// <param name="stream">The audio stream to check.</param>
    /// <returns>True if the audio stream is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsAudioStreamReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsReady(AudioStream stream);

    /// <summary>
    /// Unload audio stream and free memory.
    /// </summary>
    /// <param name="stream">The audio stream to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadAudioStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Unload(AudioStream stream);

    /// <summary>
    /// Update audio stream buffers with data.
    /// </summary>
    /// <param name="stream">The audio stream to update.</param>
    /// <param name="data">Pointer to the new audio data.</param>
    /// <param name="frameCount">The number of frames in the new audio data.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateAudioStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Update(AudioStream stream, nint data, int frameCount);

    /// <summary>
    /// Check if any audio stream buffers requires refill.
    /// </summary>
    /// <param name="stream">The audio stream to check.</param>
    /// <returns>Returns true if the audio stream has been fully processed, otherwise returns false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsAudioStreamProcessed")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsProcessed(AudioStream stream);

    /// <summary>
    /// Play audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to play.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "PlayAudioStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Play(AudioStream stream);

    /// <summary>
    /// Pause audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to pause.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "PauseAudioStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Pause(AudioStream stream);

    /// <summary>
    /// Resume audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to resume.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ResumeAudioStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Resume(AudioStream stream);

    /// <summary>
    /// Check if audio stream is playing.
    /// </summary>
    /// <param name="stream">The audio stream to check.</param>
    /// <returns>True if the audio stream is playing, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsAudioStreamPlaying")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsPlaying(AudioStream stream);

    /// <summary>
    /// Stop audio stream.
    /// </summary>
    /// <param name="stream">The audio stream to stop.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "StopAudioStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Stop(AudioStream stream);

    /// <summary>
    /// Set volume for audio stream (1.0 is max level).
    /// </summary>
    /// <param name="stream">The audio stream to set the volume for.</param>
    /// <param name="volume">The volume value to set (range 0.0f to 1.0f).</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetAudioStreamVolume")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetVolume(AudioStream stream, float volume);

    /// <summary>
    /// Set pitch for audio stream (1.0 is base level).
    /// </summary>
    /// <param name="stream">The audio stream to set the pitch for.</param>
    /// <param name="pitch">The desired pitch value. Range is [-1.0f, 1.0f], with 0.0f being unchanged pitch.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetAudioStreamPitch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetPitch(AudioStream stream, float pitch);

    /// <summary>
    /// Set pan for audio stream (0.5 is centered).
    /// </summary>
    /// <param name="stream">The audio stream.</param>
    /// <param name="pan">The pan value. Pan value should be between -1.0 (fully left) and 1.0 (fully right).</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetAudioStreamPan")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetPan(AudioStream stream, float pan);

    /// <summary>
    /// Default size for new audio streams.
    /// </summary>
    /// <param name="size">The size of the audio stream buffer in bytes.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetAudioStreamBufferSizeDefault")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBufferSizeDefault(int size);

    /// <summary>
    /// Audio thread callback to request new data.
    /// </summary>
    /// <param name="stream">The audio stream to set the callback for.</param>
    /// <param name="callback">The callback function pointer.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetAudioStreamCallback")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetCallback(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> callback);

    /// <summary>
    /// Attach audio stream processor to stream, receives the samples as floats.
    /// </summary>
    /// <param name="stream">The audio stream to attach the processor to.</param>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "AttachAudioStreamProcessor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void AttachProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> processor);

    /// <summary>
    /// Detach audio stream processor from stream.
    /// </summary>
    /// <param name="stream">The audio stream.</param>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "DetachAudioStreamProcessor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DetachProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<nint, uint, void> processor);

    /// <summary>
    /// Attach audio stream processor to the entire audio pipeline, receives the samples as floats.
    /// </summary>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "AttachAudioMixedProcessor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void AttachAudioMixedProcessor(delegate* unmanaged[Cdecl]<nint, uint, void> processor);

    /// <summary>
    /// Detach audio stream processor from the entire audio pipeline.
    /// </summary>
    /// <param name="processor">A pointer to the unmanaged processor function.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "DetachAudioMixedProcessor")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DetachAudioMixedProcessor(delegate* unmanaged[Cdecl]<nint, uint, void> processor);
}