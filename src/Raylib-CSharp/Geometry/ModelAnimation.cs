using System.Runtime.InteropServices;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Unsafe;
using Raylib_CSharp.Unsafe.Spans.Custom;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Geometry;

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
    public readonly unsafe BoneInfo* BonesPtr;

    /// <inheritdoc cref="BonesPtr" />
    public unsafe ReadOnlySpan<BoneInfo> Bones => new(this.BonesPtr, this.BoneCount);

    /// <summary>
    /// Poses array by frame.
    /// </summary>
    public readonly unsafe Transform** FramePosesPtr;

    /// <inheritdoc cref="FramePosesPtr" />
    public unsafe FixedArraySpan<Transform> FramePosesCollection => new(this.FramePosesPtr, this.FrameCount, this.BoneCount);

    /// <summary>
    /// Animation name.
    /// </summary>
    public unsafe fixed sbyte NamePtr[32];

    /// <inheritdoc cref="NamePtr" />
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

    /// <inheritdoc cref="RaylibApi.LoadModelAnimations" />
    public static unsafe ReadOnlySpan<ModelAnimation> LoadAnimations(string fileName) {
        return new ReadOnlySpan<ModelAnimation>(RaylibApi.LoadModelAnimations(fileName, out int animCount), animCount);
    }

    /// <inheritdoc cref="RaylibApi.UnloadModelAnimation" />
    public static unsafe void UnloadAnimations(ReadOnlySpan<ModelAnimation> animations) {
        fixed (ModelAnimation* animationPtr = animations) {
            RaylibApi.UnloadModelAnimations(animationPtr, animations.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.UpdateModelAnimation" />
    public void Update(Model model, int frame) {
        RaylibApi.UpdateModelAnimation(model, this, frame);
    }

    /// <inheritdoc cref="RaylibApi.IsModelAnimationValid" />
    public bool IsValid(Model model) {
        return RaylibApi.IsModelAnimationValid(model, this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadModelAnimation" />
    public void Unload() {
        RaylibApi.UnloadModelAnimation(this);
    }
}