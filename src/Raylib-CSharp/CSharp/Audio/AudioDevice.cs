using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Audio;

public static partial class AudioDevice {

    /// <summary>
    /// Initialize audio device and context.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "InitAudioDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Init();

    /// <summary>
    /// Close the audio device and context.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "CloseAudioDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Close();

    /// <summary>
    /// Check if audio device has been initialized successfully.
    /// </summary>
    /// <returns>Returns true if the audio device is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsAudioDeviceReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsReady();

    /// <summary>
    /// Set master volume (listener).
    /// </summary>
    /// <param name="volume">The volume value.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetMasterVolume")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMasterVolume(float volume);

    /// <summary>
    /// Get master volume (listener).
    /// </summary>
    /// <returns>The master volume of the audio device.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMasterVolume")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMasterVolume();
}