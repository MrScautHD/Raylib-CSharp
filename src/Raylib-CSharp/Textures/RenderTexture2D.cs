using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Textures;

[StructLayout(LayoutKind.Sequential)]
public partial struct RenderTexture2D {

    /// <summary>
    /// OpenGL framebuffer object id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Color buffer attachment texture.
    /// </summary>
    public Texture2D Texture;

    /// <summary>
    /// Depth buffer attachment texture.
    /// </summary>
    public Texture2D Depth;

    /// <summary>
    /// Load texture for rendering (framebuffer).
    /// </summary>
    /// <param name="width">The width of the render texture.</param>
    /// <param name="height">The height of the render texture.</param>
    /// <returns>The loaded render texture.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadRenderTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RenderTexture2D Load(int width, int height);
}

/// <summary>
/// Contains extension methods for the <see cref="RenderTexture2D"/> class.
/// </summary>
public static partial class RenderTexture2DExtensions {

    /// <summary>
    /// Check if a render texture is ready.
    /// </summary>
    /// <param name="target">The render texture to check.</param>
    /// <returns>Returns true if the render texture is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsRenderTextureReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(RenderTexture2D target);
    public static bool IsReady(this RenderTexture2D target) => IsReady_(target);

    /// <summary>
    /// Unload render texture from GPU memory (VRAM).
    /// </summary>
    /// <param name="target">The render texture to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadRenderTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(RenderTexture2D target);
    public static void Unload(this RenderTexture2D target) => Unload_(target);
}