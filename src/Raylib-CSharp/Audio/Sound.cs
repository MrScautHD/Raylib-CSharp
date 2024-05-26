using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public partial struct Sound {

    /// <summary>
    /// Audio stream.
    /// </summary>
    public AudioStream Stream;

    /// <summary>
    /// Total number of frames (considering channels).
    /// </summary>
    public uint FrameCount;

    /// <summary>
    /// Load sound from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load the sound from.</param>
    /// <returns>The loaded sound.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadSound", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound Load(string fileName);

    /// <summary>
    /// Load sound from wave data.
    /// </summary>
    /// <param name="wave">The wave to load the sound from.</param>
    /// <returns>The loaded sound.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadSoundFromWave")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadFromWave(Wave wave);

    /// <summary>
    /// Create a new sound that shares the same sample data as the source sound, does not own the sound data.
    /// </summary>
    /// <param name="source">The source sound.</param>
    /// <returns>The loaded sound alias.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadSoundAlias")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadAlias(Sound source);
}

/// <summary>
/// Contains extension methods for the <see cref="Sound"/> class.
/// </summary>
public static partial class SoundExtensions {

    /// <summary>
    /// Checks if a sound is ready.
    /// </summary>
    /// <param name="sound">The sound to check.</param>
    /// <returns>True if the sound is ready to be played, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsSoundReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(Sound sound);
    public static bool IsReady(this Sound sound) => IsReady_(sound);

    /// <summary>
    /// Update sound buffer with new data.
    /// </summary>
    /// <param name="sound">The sound to update.</param>
    /// <param name="data">A pointer to the new sample data buffer.</param>
    /// <param name="sampleCount">The number of samples in the buffer.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateSound")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Update_(Sound sound, nint data, int sampleCount);
    public static void Update(this Sound sound, nint data, int sampleCount) => Update_(sound, data, sampleCount);

    /// <summary>
    /// Unload sound.
    /// </summary>
    /// <param name="sound">The sound to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadSound")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(Sound sound);
    public static void Unload(this Sound sound) => Unload_(sound);

    /// <summary>
    /// Unload a sound alias (does not deallocate sample data).
    /// </summary>
    /// <param name="alias">The sound alias to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadSoundAlias")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void UnloadAlias_(Sound alias);
    public static void UnloadAlias(this Sound alias) => UnloadAlias_(alias);

    /// <summary>
    /// Play a sound.
    /// </summary>
    /// <param name="sound">The sound to be played.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "PlaySound")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Play_(Sound sound);
    public static void Play(this Sound sound) => Play_(sound);

    /// <summary>
    /// Stop playing a sound.
    /// </summary>
    /// <param name="sound">The sound to stop.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "StopSound")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Stop_(Sound sound);
    public static void Stop(this Sound sound) => Stop_(sound);

    /// <summary>
    /// Pause a sound.
    /// </summary>
    /// <param name="sound">The sound to pause.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "PauseSound")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Pause_(Sound sound);
    public static void Pause(this Sound sound) => Pause_(sound);

    /// <summary>
    /// Resume a paused sound.
    /// </summary>
    /// <param name="sound">The sound to resume.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ResumeSound")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Resume_(Sound sound);
    public static void Resume(this Sound sound) => Resume_(sound);

    /// <summary>
    /// Check if a sound is currently playing.
    /// </summary>
    /// <param name="sound">The sound to check for playing status.</param>
    /// <returns>True if the sound is currently playing, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsSoundPlaying")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsPlaying_(Sound sound);
    public static bool IsPlaying(this Sound sound) => IsPlaying_(sound);

    /// <summary>
    /// Set volume for a sound (1.0 is max level).
    /// </summary>
    /// <param name="sound">The sound to set the volume for.</param>
    /// <param name="volume">The volume value. Range is 0.0F to 1.0F.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetSoundVolume")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetVolume_(Sound sound, float volume);
    public static void SetVolume(this Sound sound, float volume) => SetVolume_(sound, volume);

    /// <summary>
    /// Set pitch for a sound (1.0 is base level).
    /// </summary>
    /// <param name="sound">The sound to set the pitch for.</param>
    /// <param name="pitch">The pitch value to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetSoundPitch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetPitch_(Sound sound, float pitch);
    public static void SetPitch(this Sound sound, float pitch) => SetPitch_(sound, pitch);

    /// <summary>
    /// Set pan for a sound (0.5 is center).
    /// </summary>
    /// <param name="sound">The sound to set the pan value for.</param>
    /// <param name="pan">The pan value to set, range -1.0F (left) to 1.0F (right), 0.0F for both center.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetSoundPan")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetPan_(Sound sound, float pan);
    public static void SetPan(this Sound sound, float pan) => SetPan_(sound, pan);
}