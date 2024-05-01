using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Images;
using Raylib_CSharp.CSharp.Rendering;
using Color = Raylib_CSharp.CSharp.Colors.Color;

namespace Raylib_CSharp.CSharp.Textures;

public static partial class TextureManager {

    /// <summary>
    /// Load texture from file into GPU memory (VRAM).
    /// </summary>
    /// <param name="fileName">The path to the texture file.</param>
    /// <returns>The loaded texture.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture2D LoadTexture(string fileName);

    /// <summary>
    /// Load texture from image data.
    /// </summary>
    /// <param name="image">The image to load texture from.</param>
    /// <returns>The loaded texture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture2D LoadTextureFromImage(Image image);

    /// <summary>
    /// Load cubemap from image, multiple image cubemap layouts supported.
    /// </summary>
    /// <param name="image">The image data for the cube map.</param>
    /// <param name="layout">The layout of the cube map.</param>
    /// <returns>The loaded cube map texture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture2D LoadTextureCubemap(Image image, CubemapLayout layout);

    /// <summary>
    /// Load texture for rendering (framebuffer).
    /// </summary>
    /// <param name="width">The width of the render texture.</param>
    /// <param name="height">The height of the render texture.</param>
    /// <returns>The loaded render texture.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RenderTexture2D LoadRenderTexture(int width, int height);

    /// <summary>
    /// Check if a texture is ready.
    /// </summary>
    /// <param name="texture">The texture to check.</param>
    /// <returns>Returns true if the texture is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsTextureReady(Texture2D texture);

    /// <summary>
    /// Unload texture from GPU memory (VRAM).
    /// </summary>
    /// <param name="texture">The texture to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadTexture(Texture2D texture);

    /// <summary>
    /// Check if a render texture is ready.
    /// </summary>
    /// <param name="target">The render texture to check.</param>
    /// <returns>Returns true if the render texture is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsRenderTextureReady(RenderTexture2D target);

    /// <summary>
    /// Unload render texture from GPU memory (VRAM).
    /// </summary>
    /// <param name="target">The render texture to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadRenderTexture(RenderTexture2D target);

    /// <summary>
    /// Update GPU texture with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="pixels">The pointer to the new texture data.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateTexture(Texture2D texture, void* pixels);

    /// <summary>
    /// Update GPU texture rectangle with new data.
    /// </summary>
    /// <param name="texture">The texture to update.</param>
    /// <param name="rec">The rectangle defining the portion of the texture to update.</param>
    /// <param name="pixels">A pointer to the new pixel data.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateTextureRec(Texture2D texture, RectangleF rec, void* pixels);

    /// <summary>
    /// Generate GPU mipmaps for a texture.
    /// </summary>
    /// <param name="texture">The texture to generate mipmaps for.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GenTextureMipmaps(ref Texture2D texture);

    /// <summary>
    /// Set texture scaling filter mode.
    /// </summary>
    /// <param name="texture">The texture to set the filter mode for.</param>
    /// <param name="filter">The texture filter mode to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextureFilter(Texture2D texture, TextureFilter filter);

    /// <summary>
    /// Set texture wrapping mode.
    /// </summary>
    /// <param name="texture">The texture to set the wrapping mode for.</param>
    /// <param name="wrap">The texture wrapping mode to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextureWrap(Texture2D texture, TextureWrap wrap);

    /// <summary>
    /// Draw a Texture2D.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="posX">The X coordinate of the position to draw the texture at.</param>
    /// <param name="posY">The Y coordinate of the position to draw the texture at.</param>
    /// <param name="tint">The tint color to apply to the texture (optional).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexture(Texture2D texture, int posX, int posY, Color tint);

    /// <summary>
    /// Draw a Texture2D with position defined as Vector2.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="position">The position where the texture will be drawn.</param>
    /// <param name="tint">The color tint to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureV(Texture2D texture, Vector2 position, Color tint);

    /// <summary>
    /// Draw a Texture2D with extended parameters.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="position">The position where the texture will be drawn.</param>
    /// <param name="rotation">The rotation angle of the texture, in degrees.</param>
    /// <param name="scale">The scale factor to apply to the texture.</param>
    /// <param name="tint">The tint color to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureEx(Texture2D texture, Vector2 position, float rotation, float scale, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="source">The source rectangle to draw on the texture.</param>
    /// <param name="position">The position where the texture will be drawn on the screen.</param>
    /// <param name="tint">The color tint to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureRec(Texture2D texture, RectangleF source, Vector2 position, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle with 'pro' parameters.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="source">The source rectangle inside the texture.</param>
    /// <param name="dest">The destination rectangle on the screen.</param>
    /// <param name="origin">The origin point for rotation and scaling.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="tint">The color tint of the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexturePro(Texture2D texture, RectangleF source, RectangleF dest, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Draws a texture (or part of it) that stretches or shrinks nicely.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="nPatchInfo">The nine-patch information.</param>
    /// <param name="dest">The destination rectangle where the texture will be drawn.</param>
    /// <param name="origin">The origin of the rotation.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="tint">The color tint.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureNPatch(Texture2D texture, NPatchInfo nPatchInfo, RectangleF dest, Vector2 origin, float rotation, Color tint);
}