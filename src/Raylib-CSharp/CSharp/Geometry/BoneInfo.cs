using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public struct BoneInfo {
    
    /// <summary>
    /// Bone name.
    /// </summary>
    public unsafe fixed sbyte Name[32];

    /// <summary>
    /// Bone parent.
    /// </summary>
    public int Parent;
}