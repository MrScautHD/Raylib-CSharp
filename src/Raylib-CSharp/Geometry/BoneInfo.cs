using System.Runtime.InteropServices;
using Raylib_CSharp.Unsafe;

namespace Raylib_CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public struct BoneInfo {

    /// <summary>
    /// Bone name.
    /// </summary>
    public unsafe string Name {
        get {
            fixed (sbyte* namePtr = this.NamePtr) {
                return FixedString.GetValue(namePtr);
            }
        }

        set {
            fixed (sbyte* namePtr = this.NamePtr) {
                FixedString.SetValue(namePtr, 32, value);
            }
        }
    }

    public unsafe fixed sbyte NamePtr[32];

    /// <summary>
    /// Bone parent.
    /// </summary>
    public int Parent;
}