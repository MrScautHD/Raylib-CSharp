using System.Runtime.InteropServices;

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
    public unsafe void* CtxData;
}