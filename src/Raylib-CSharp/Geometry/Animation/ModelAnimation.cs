using System.Runtime.InteropServices;
using Raylib_CSharp.Marshallers;
using Raylib_CSharp.Spans;

namespace Raylib_CSharp.Geometry.Animation;

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
    public unsafe ReadOnlySpan<BoneInfo> Bones => new(this.BonesPtr, this.BoneCount);

    public readonly unsafe BoneInfo* BonesPtr;

    /// <summary>
    /// Poses array by frame.
    /// </summary>
    public unsafe FixedArraySpan<Transform> FramePosesCollection => new(this.FramePosesPtr, this.FrameCount, this.BoneCount);

    public readonly unsafe Transform** FramePosesPtr;

    /// <summary>
    /// Animation name.
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
}