using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Unsafe;
using Raylib_CSharp.Unsafe.Spans.Custom;

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
}

/// <summary>
/// Contains extension methods for the <see cref="ModelAnimation"/> class.
/// </summary>
public static partial class ModelAnimationExtensions {

    /// <summary>
    /// Unload animation data.
    /// </summary>
    /// <param name="anim">The model animation to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadModelAnimation")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(ModelAnimation anim);
    public static void Unload(this ModelAnimation anim) => Unload_(anim);
}