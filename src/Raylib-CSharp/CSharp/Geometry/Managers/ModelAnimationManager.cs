using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Geometry.Managers;

public static partial class ModelAnimationManager {

    /// <summary>
    /// Load model animations from file.
    /// </summary>
    /// <param name="fileName">The name of the file to load animations from.</param>
    /// <param name="animCount">The number of animations loaded from the file.</param>
    /// <returns>Pointer to the loaded model animations.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial ModelAnimation* LoadModelAnimations(string fileName, out int animCount);

    /// <summary>
    /// Update model animation pose.
    /// </summary>
    /// <param name="model">The model containing the animation.</param>
    /// <param name="anim">The animation to update.</param>
    /// <param name="frame">The frame to update the animation to.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateModelAnimation(Model model, ModelAnimation anim, int frame);

    /// <summary>
    /// Unload animation data.
    /// </summary>
    /// <param name="anim">The model animation to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadModelAnimation(ModelAnimation anim);

    /// <summary>
    /// Unload animation array data.
    /// </summary>
    /// <param name="animations">The animations to unload.</param>
    /// <param name="animCount">The number of animations to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadModelAnimation(ModelAnimation* animations, int animCount);

    /// <summary>
    /// Check model animation skeleton match.
    /// </summary>
    /// <param name="model">The model to check the animation for.</param>
    /// <param name="anim">The animation to check.</param>
    /// <returns>True if the model animation is valid, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsModelAnimationValid(Model model, ModelAnimation anim);
}