using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Audio;

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
    public unsafe void* Data;
}