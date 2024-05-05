using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Audio;

[StructLayout(LayoutKind.Sequential)]
public partial struct Music {

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

    /// <summary>
    /// Load music stream from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load the music from.</param>
    /// <returns>The loaded music stream.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadMusicStream", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Music Load(string fileName);

    /// <summary>
    /// Load music stream from data.
    /// </summary>
    /// <param name="fileType">The file type of the music.</param>
    /// <param name="data">A pointer to the memory containing the music data.</param>
    /// <param name="dataSize">The size of the music data in bytes.</param>
    /// <returns>The loaded music stream.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadMusicStreamFromMemory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Music LoadFromMemory(string fileType, byte* data, int dataSize);

    /// <summary>
    /// Load music stream from data.
    /// </summary>
    /// <param name="fileType">The file type of the music.</param>
    /// <param name="data">A Span to the memory containing the music data.</param>
    /// <returns>The loaded music stream.</returns>
    public static unsafe Music LoadFromMemory(string fileType, ReadOnlySpan<byte> data) {
        fixed (byte* dataPtr = data) {
            return LoadFromMemory(fileType, dataPtr, data.Length);
        }
    }

    /// <summary>
    /// Checks if a music stream is ready.
    /// </summary>
    /// <param name="music">The music stream to check.</param>
    /// <returns>True if the music stream is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsMusicReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsReady(Music music);

    /// <summary>
    /// Unload music stream.
    /// </summary>
    /// <param name="music">The music stream to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadMusicStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Unload(Music music);

    /// <summary>
    /// Start music playing.
    /// </summary>
    /// <param name="music">The music stream to play.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "PlayMusicStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Play(Music music);

    /// <summary>
    /// Check if music is playing.
    /// </summary>
    /// <param name="music">The music stream to check.</param>
    /// <returns>Returns true if the music stream is currently playing; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsMusicStreamPlaying")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsPlaying(Music music);

    /// <summary>
    /// Updates buffers for music streaming.
    /// </summary>
    /// <param name="music">The music stream to update.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateMusicStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Update(Music music);

    /// <summary>
    /// Stop music playing.
    /// </summary>
    /// <param name="music">The music stream to stop.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "StopMusicStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Stop(Music music);

    /// <summary>
    /// Pause music playing.
    /// </summary>
    /// <param name="music">The music stream to pause.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "PauseMusicStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Pause(Music music);

    /// <summary>
    /// Resume playing paused music.
    /// </summary>
    /// <param name="music">The music stream to resume.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "ResumeMusicStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Resume(Music music);

    /// <summary>
    /// Seek music to a position (in seconds).
    /// </summary>
    /// <param name="music">The music stream to seek.</param>
    /// <param name="position">The new position of the music stream.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SeekMusicStream")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Seek(Music music, float position);

    /// <summary>
    /// Set volume for music (1.0 is max level).
    /// </summary>
    /// <param name="music">The music stream to set the volume for.</param>
    /// <param name="volume">The desired volume, ranging from 0.0f (silence) to 1.0f (full volume).</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetMusicVolume")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetVolume(Music music, float volume);

    /// <summary>
    /// Set pitch for a music (1.0 is base level).
    /// </summary>
    /// <param name="music">The music stream to set the pitch for.</param>
    /// <param name="pitch">The new pitch value to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetMusicPitch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetPitch(Music music, float pitch);

    /// <summary>
    /// Set pan for a music (0.5 is center).
    /// </summary>
    /// <param name="music">The music stream.</param>
    /// <param name="pan">The panning effect value (-1.0f to 1.0f).</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetMusicPan")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetPan(Music music, float pan);

    /// <summary>
    /// Get music time length (in seconds).
    /// </summary>
    /// <param name="music">The music stream to get the length of.</param>
    /// <returns>The length of the music stream in seconds.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMusicTimeLength")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetTimeLength(Music music);

    /// <summary>
    /// Get current music time played (in seconds).
    /// </summary>
    /// <param name="music">The music stream to get the time played from.</param>
    /// <returns>The time played of the music stream.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMusicTimePlayed")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetTimePlayed(Music music);
}