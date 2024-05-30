using System.Runtime.InteropServices;
using Raylib_CSharp.Images;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Textures;

[StructLayout(LayoutKind.Sequential)]
public struct Texture2D {

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

    /// <inheritdoc cref="RaylibApi.LoadTexture" />
    public static Texture2D Load(string fileName) {
        return RaylibApi.LoadTexture(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadTextureFromImage" />
    public static Texture2D LoadFromImage(Image image) {
        return RaylibApi.LoadTextureFromImage(image);
    }

    /// <inheritdoc cref="RaylibApi.LoadTextureCubemap" />
    public static Texture2D LoadCubemap(Image image, CubemapLayout layout) {
        return RaylibApi.LoadTextureCubemap(image, layout);
    }

    /// <inheritdoc cref="RaylibApi.IsTextureReady" />
    public bool IsReady() {
        return RaylibApi.IsTextureReady(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadTexture" />
    public void Unload() {
        RaylibApi.UnloadTexture(this);
    }

    /// <inheritdoc cref="RaylibApi.UpdateTexture" />
    public void Update(nint pixels) {
        RaylibApi.UpdateTexture(this, pixels);
    }

    /// <inheritdoc cref="RaylibApi.UpdateTextureRec" />
    public void UpdateRec(Rectangle rec, nint pixels) {
        RaylibApi.UpdateTextureRec(this, rec, pixels);
    }

    /// <inheritdoc cref="RaylibApi.GenTextureMipmaps" />
    public void GenMipmaps() {
        RaylibApi.GenTextureMipmaps(ref this);
    }

    /// <inheritdoc cref="RaylibApi.SetTextureFilter" />
    public void SetFilter(TextureFilter filter) {
        RaylibApi.SetTextureFilter(this, filter);
    }

    /// <inheritdoc cref="RaylibApi.SetTextureWrap" />
    public void SetWrap(TextureWrap wrap) {
        RaylibApi.SetTextureWrap(this, wrap);
    }
}