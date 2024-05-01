namespace Raylib_CSharp.CSharp.Materials;

public enum MaterialMapIndex {

    /// <summary>
    /// Albedo material (same as: MATERIAL_MAP_DIFFUSE).
    /// </summary>
    Albedo = 0,

    /// <summary>
    /// Metalness material (same as: MATERIAL_MAP_SPECULAR).
    /// </summary>
    Metalness,

    /// <summary>
    /// Normal material.
    /// </summary>
    Normal,

    /// <summary>
    /// Roughness material.
    /// </summary>
    Roughness,

    /// <summary>
    /// Ambient occlusion material.
    /// </summary>
    Occlusion,

    /// <summary>
    /// Emission material.
    /// </summary>
    Emission,

    /// <summary>
    /// Heightmap material.
    /// </summary>
    Height,

    /// <summary>
    /// Cubemap material (NOTE: Uses GL_TEXTURE_CUBE_MAP).
    /// </summary>
    Cubemap,

    /// <summary>
    /// Irradiance material (NOTE: Uses GL_TEXTURE_CUBE_MAP).
    /// </summary>
    Irradiance,

    /// <summary>
    /// Prefilter material (NOTE: Uses GL_TEXTURE_CUBE_MAP).
    /// </summary>
    Prefilter,

    /// <summary>
    /// Brdf material.
    /// </summary>
    Brdf,

    /// <summary>
    /// Diffuse material (same as: MATERIAL_MAP_ALBEDO).
    /// </summary>
    Diffuse = Albedo,

    /// <summary>
    /// Specular material (same as: MATERIAL_MAP_METALNESS).
    /// </summary>
    Specular = Metalness
}