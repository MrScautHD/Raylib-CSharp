namespace Raylib_CSharp.CSharp.Textures;

public enum TextureWrap {

    /// <summary>
    /// Repeats texture in tiled mode.
    /// </summary>
    Repeat = 0,

    /// <summary>
    /// Clamps texture to edge pixel in tiled mode.
    /// </summary>
    Clamp,

    /// <summary>
    /// Mirrors and repeats the texture in tiled mode.
    /// </summary>
    MirrorRepeat,

    /// <summary>
    /// Mirrors and clamps to border the texture in tiled mode.
    /// </summary>
    MirrorClamp
}