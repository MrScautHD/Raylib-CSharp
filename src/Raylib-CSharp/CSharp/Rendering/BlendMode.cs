namespace Raylib_CSharp.CSharp.Rendering;

public enum BlendMode {

    /// <summary>
    /// Blend textures considering alpha (default).
    /// </summary>
    Alpha = 0,

    /// <summary>
    /// Blend textures adding colors.
    /// </summary>
    Additive,

    /// <summary>
    /// Blend textures multiplying colors.
    /// </summary>
    Multiplied,

    /// <summary>
    /// Blend textures adding colors (alternative).
    /// </summary>
    AddColors,

    /// <summary>
    /// Blend textures subtracting colors (alternative).
    /// </summary>
    SubtractColors,

    /// <summary>
    /// Blend premultiplied textures considering alpha.
    /// </summary>
    AlphaPremultiply,

    /// <summary>
    /// Blend textures using custom src/dst factors (use rlSetBlendFactors()).
    /// </summary>
    Custom,

    /// <summary>
    /// Blend textures using custom rgb/alpha separate src/dst factors (use rlSetBlendFactorsSeparate()).
    /// </summary>
    CustomSeparate
}