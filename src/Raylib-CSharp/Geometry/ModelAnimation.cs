using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Marshallers;
using Raylib_CSharp.Spans;

namespace Raylib_CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public partial struct ModelAnimation {

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

    /// <summary>
    /// Load model animations from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load animations from.</param>
    /// <param name="animCount">The number of animations loaded from the file.</param>
    /// <returns>A Pointer to the loaded model animations.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadModelAnimations", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial ModelAnimation* Load(string fileName, out int animCount);

    /// <summary>
    /// Load model animations from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load animations from.</param>
    /// <returns>A Span to the loaded model animations.</returns>
    public static unsafe ReadOnlySpan<ModelAnimation> Load(string fileName) {
        return new ReadOnlySpan<ModelAnimation>(Load(fileName, out int animCount), animCount);
    }

    /// <summary>
    /// Update model animation pose.
    /// </summary>
    /// <param name="model">The model containing the animation.</param>
    /// <param name="anim">The animation to update.</param>
    /// <param name="frame">The frame to update the animation to.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateModelAnimation")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Update(Model model, ModelAnimation anim, int frame);

    /// <summary>
    /// Unload animation data.
    /// </summary>
    /// <param name="anim">The model animation to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadModelAnimation")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Unload(ModelAnimation anim);

    /// <summary>
    /// Unload animation array data.
    /// </summary>
    /// <param name="animations">The animations to unload.</param>
    /// <param name="animCount">The number of animations to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadModelAnimation")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void Unload(ModelAnimation* animations, int animCount);

    /// <summary>
    /// Unload animation array data.
    /// </summary>
    /// <param name="animations">The animations to unload.</param>
    public static unsafe void Unload(ReadOnlySpan<ModelAnimation> animations) {
        fixed (ModelAnimation* animationPtr = animations) {
            Unload(animationPtr, animations.Length);
        }
    }

    /// <summary>
    /// Check model animation skeleton match.
    /// </summary>
    /// <param name="model">The model to check the animation for.</param>
    /// <param name="anim">The animation to check.</param>
    /// <returns>True if the model animation is valid, otherwise false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsModelAnimationValid")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsValid(Model model, ModelAnimation anim);
}