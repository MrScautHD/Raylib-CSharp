namespace Raylib_CSharp.CSharp.Rendering.Textures;

public enum CubeMapLayout {

    /// <summary>
    /// Automatically detect layout type.
    /// </summary>
    AutoDetect = 0,

    /// <summary>
    /// Layout is defined by a vertical line with faces.
    /// </summary>
    LineVertical,

    /// <summary>
    /// Layout is defined by a horizontal line with faces.
    /// </summary>
    LineHorizontal,

    /// <summary>
    /// Layout is defined by a 3x4 cross with cubemap faces.
    /// </summary>
    CrossThreeByFour,

    /// <summary>
    /// Layout is defined by a 4x3 cross with cubemap faces.
    /// </summary>
    CrossFourByThree,

    /// <summary>
    /// Layout is defined by a panorama image (equirrectangular map).
    /// </summary>
    Panorama
}