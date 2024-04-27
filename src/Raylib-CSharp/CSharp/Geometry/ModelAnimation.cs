using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Misc;

namespace Raylib_CSharp.CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public struct ModelAnimation {

    /// <summary>
    /// Number of bones.
    /// </summary>
    public readonly int BoneCount;

    /// <summary>
    /// Number of animation frames.
    /// </summary>
    public readonly int FrameCount;

    /// <summary>
    /// Bones information (skeleton).
    /// </summary>
    public readonly unsafe BoneInfo* Bones;

    /// <summary>
    /// Poses array by frame.
    /// </summary>
    public readonly unsafe Transform** FramePoses;

    /// <summary>
    /// Animation name.
    /// </summary>
    public unsafe fixed sbyte Name[32];
}