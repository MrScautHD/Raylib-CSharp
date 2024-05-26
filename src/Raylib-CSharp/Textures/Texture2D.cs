using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Images;

namespace Raylib_CSharp.Textures;

[StructLayout(LayoutKind.Sequential)]
public partial struct Texture2D {

    /// <summary>
    /// OpenGL texture id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Texture base width.
    /// </summary>
    public int Width;

    /// <summary>
    /// Texture base height.
    /// </summary>
    public int Height;

    /// <summary>
    /// Mipmap levels, 1 by default.
    /// </summary>
    public int Mipmaps;

    /// <summary>
    /// Data format (PixelFormat type).
    /// </summary>
    public PixelFormat Format;

    /// <summary>
    /// Load texture from file into GPU memory (VRAM).
    /// </summary>
    /// <param name="fileName">The path to the texture file.</param>
    /// <returns>The loaded texture.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadTexture", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture2D Load(string fileName);

    /// <summary>
    /// Load texture from image data.
    /// </summary>
    /// <param name="image">The image to load texture from.</param>
    /// <returns>The loaded texture.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadTextureFromImage")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture2D LoadFromImage(Image image);

    /// <summary>
    /// Load cubemap from image, multiple image cubemap layouts supported.
    /// </summary>
    /// <param name="image">The image data for the cube map.</param>
    /// <param name="layout">The layout of the cube map.</param>
    /// <returns>The loaded cube map texture.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadTextureCubemap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture2D LoadCubemap(Image image, CubemapLayout layout);
}

/// <summary>
/// Contains extension methods for the <see cref="Texture2D"/> class.
/// </summary>
public static partial class Texture2DExtensions {

    /// <summary>
    /// Check if a texture is ready.
    /// </summary>
    /// <param name="texture">The texture to check.</param>
    /// <returns>Returns true if the texture is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsTextureReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(Texture2D texture);
    public static bool IsReady(this Texture2D texture) => IsReady_(texture);

    /// <summary>
    /// Unload texture from GPU memory (VRAM).
    /// </summary>
    /// <param name="texture">The texture to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(Texture2D texture);
    public static void Unload(this Texture2D texture) => Unload_(texture);

    /// <summary>
    /// Update GPU texture with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="pixels">The pointer to the new texture data.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Update_(Texture2D texture, nint pixels);
    public static void Update(this Texture2D texture, nint pixels) => Update_(texture, pixels);

    /// <summary>
    /// Update GPU texture rectangle with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="rec">The rectangle defining the portion of the texture to update.</param>
    /// <param name="pixels">A pointer to the new pixel data.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateTextureRec")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void UpdateRec_(Texture2D texture, Rectangle rec, nint pixels);
    public static void UpdateRec(this Texture2D texture, Rectangle rec, nint pixels) => UpdateRec_(texture, rec, pixels);

    /// <summary>
    /// Generate GPU mipmaps for a texture.
    /// </summary>
    /// <param name="texture">The texture to generate mipmaps for.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "GenTextureMipmaps")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void GenMipmaps_(ref Texture2D texture);
    public static void GenMipmaps(this Texture2D texture) => GenMipmaps_(ref texture);

    /// <summary>
    /// Set texture scaling filter mode.
    /// </summary>
    /// <param name="texture">The texture to set the filter mode for.</param>
    /// <param name="filter">The texture filter mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetTextureFilter")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetFilter_(Texture2D texture, TextureFilter filter);
    public static void SetFilter(this Texture2D texture, TextureFilter filter) => SetFilter_(texture, filter);

    /// <summary>
    /// Set texture wrapping mode.
    /// </summary>
    /// <param name="texture">The texture to set the wrapping mode for.</param>
    /// <param name="wrap">The texture wrapping mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetTextureWrap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetWrap_(Texture2D texture, TextureWrap wrap);
    public static void SetWrap(this Texture2D texture, TextureWrap wrap) => SetWrap_(texture, wrap);
}