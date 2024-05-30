using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Textures;

[StructLayout(LayoutKind.Sequential)]
public struct RenderTexture2D {

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

    /// <inheritdoc cref="RaylibApi.LoadRenderTexture" />
    public static RenderTexture2D Load(int width, int height) {
        return RaylibApi.LoadRenderTexture(width, height);
    }

    /// <inheritdoc cref="RaylibApi.IsRenderTextureReady" />
    public bool IsReady() {
        return RaylibApi.IsRenderTextureReady(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadRenderTexture" />
    public void Unload() {
        RaylibApi.UnloadRenderTexture(this);
    }
}