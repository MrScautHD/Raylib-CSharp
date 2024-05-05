using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Images;
using Raylib_CSharp.Rendering;
using Color = Raylib_CSharp.Colors.Color;

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

    /// <summary>
    /// Check if a texture is ready.
    /// </summary>
    /// <param name="texture">The texture to check.</param>
    /// <returns>Returns true if the texture is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsTextureReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsReady(Texture2D texture);

    /// <summary>
    /// Unload texture from GPU memory (VRAM).
    /// </summary>
    /// <param name="texture">The texture to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Unload(Texture2D texture);

    /// <summary>
    /// Update GPU texture with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="pixels">The pointer to the new texture data.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void Update(Texture2D texture, nint pixels);

    /// <summary>
    /// Update GPU texture rectangle with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="rec">The rectangle defining the portion of the texture to update.</param>
    /// <param name="pixels">A pointer to the new pixel data.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateTextureRec")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateRec(Texture2D texture, RectangleF rec, nint pixels);

    /// <summary>
    /// Generate GPU mipmaps for a texture.
    /// </summary>
    /// <param name="texture">The texture to generate mipmaps for.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "GenTextureMipmaps")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GenMipmaps(ref Texture2D texture);

    /// <summary>
    /// Set texture scaling filter mode.
    /// </summary>
    /// <param name="texture">The texture to set the filter mode for.</param>
    /// <param name="filter">The texture filter mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetTextureFilter")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetFilter(Texture2D texture, TextureFilter filter);

    /// <summary>
    /// Set texture wrapping mode.
    /// </summary>
    /// <param name="texture">The texture to set the wrapping mode for.</param>
    /// <param name="wrap">The texture wrapping mode to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetTextureWrap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWrap(Texture2D texture, TextureWrap wrap);
}