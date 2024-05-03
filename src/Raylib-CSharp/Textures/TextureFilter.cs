namespace Raylib_CSharp.Textures;

public enum TextureFilter {

    /// <summary>
    /// No filter, just pixel approximation.
    /// </summary>
    Point = 0,

    /// <summary>
    /// Linear filtering.
    /// </summary>
    Bilinear,

    /// <summary>
    /// Trilinear filtering (linear with mipmaps).
    /// </summary>
    Trilinear,

    /// <summary>
    /// Anisotropic filtering 4x.
    /// </summary>
    Anisotropic4X,

    /// <summary>
    /// Anisotropic filtering 8x.
    /// </summary>
    Anisotropic8X,

    /// <summary>
    /// Anisotropic filtering 16x.
    /// </summary>
    Anisotropic16X
}