using System.Runtime.InteropServices;
using Raylib_CSharp.Marshallers;

namespace Raylib_CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public struct BoneInfo {

    /// <summary>
    /// Bone name.
    /// </summary>
    public unsafe string Name {
        get {
            fixed (sbyte* namePtr = this.NamePtr) {
                return NonFreeUtf8StringMarshaller.ConvertToManaged((nint) namePtr);
            }
        }

        set {
            nint unmanagedValue = NonFreeUtf8StringMarshaller.ConvertToUnmanaged(value);

            fixed (sbyte* namePtr = this.NamePtr) {
                Buffer.MemoryCopy((void*) unmanagedValue, namePtr, 32, Math.Min(32, value.Length));
            }

            Marshal.FreeCoTaskMem(unmanagedValue);
        }
    }

    public unsafe fixed sbyte NamePtr[32];

    /// <summary>
    /// Bone parent.
    /// </summary>
    public int Parent;
}