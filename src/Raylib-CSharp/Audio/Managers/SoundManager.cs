using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Audio.Managers;

public static partial class SoundManager {

    /// <summary>
    /// Load sound from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load the sound from.</param>
    /// <returns>The loaded sound.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSound(string fileName);

    /// <summary>
    /// Load sound from wave data.
    /// </summary>
    /// <param name="wave">The wave to load the sound from.</param>
    /// <returns>The loaded sound.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSoundFromWave(Wave wave);

    /// <summary>
    /// Create a new sound that shares the same sample data as the source sound, does not own the sound data.
    /// </summary>
    /// <param name="source">The source sound.</param>
    /// <returns>The loaded sound alias.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSoundAlias(Sound source);

    /// <summary>
    /// Checks if a sound is ready.
    /// </summary>
    /// <param name="sound">The sound to check.</param>
    /// <returns>True if the sound is ready to be played, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsSoundReady(Sound sound);

    /// <summary>
    /// Update sound buffer with new data.
    /// </summary>
    /// <param name="sound">The sound to update.</param>
    /// <param name="data">A pointer to the new sample data buffer.</param>
    /// <param name="sampleCount">The number of samples in the buffer.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateSound(Sound sound, void* data, int sampleCount);

    /// <summary>
    /// Unload sound.
    /// </summary>
    /// <param name="sound">The sound to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadSound(Sound sound);

    /// <summary>
    /// Unload a sound alias (does not deallocate sample data).
    /// </summary>
    /// <param name="alias">The sound alias to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadSoundAlias(Sound alias);

    /// <summary>
    /// Play a sound.
    /// </summary>
    /// <param name="sound">The sound to be played.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlaySound(Sound sound);

    /// <summary>
    /// Stop playing a sound.
    /// </summary>
    /// <param name="sound">The sound to stop.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopSound(Sound sound);

    /// <summary>
    /// Pause a sound.
    /// </summary>
    /// <param name="sound">The sound to pause.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PauseSound(Sound sound);

    /// <summary>
    /// Resume a paused sound.
    /// </summary>
    /// <param name="sound">The sound to resume.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ResumeSound(Sound sound);

    /// <summary>
    /// Check if a sound is currently playing.
    /// </summary>
    /// <param name="sound">The sound to check for playing status.</param>
    /// <returns>True if the sound is currently playing, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsSoundPlaying(Sound sound);

    /// <summary>
    /// Set volume for a sound (1.0 is max level).
    /// </summary>
    /// <param name="sound">The sound to set the volume for.</param>
    /// <param name="volume">The volume value. Range is 0.0F to 1.0F.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundVolume(Sound sound, float volume);

    /// <summary>
    /// Set pitch for a sound (1.0 is base level).
    /// </summary>
    /// <param name="sound">The sound to set the pitch for.</param>
    /// <param name="pitch">The pitch value to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundPitch(Sound sound, float pitch);

    /// <summary>
    /// Set pan for a sound (0.5 is center).
    /// </summary>
    /// <param name="sound">The sound to set the pan value for.</param>
    /// <param name="pan">The pan value to set, range -1.0F (left) to 1.0F (right), 0.0F for both center.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundPan(Sound sound, float pan);
}