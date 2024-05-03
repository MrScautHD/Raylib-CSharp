namespace Raylib_CSharp.Shaders;

public enum ShaderLocationIndex {

    /// <summary>
    /// Shader location: vertex attribute: position
    /// </summary>
    VertexPosition = 0,

    /// <summary>
    /// Shader location: vertex attribute: texcoord01
    /// </summary>
    VertexTexcoord01,

    /// <summary>
    /// Shader location: vertex attribute: texcoord02
    /// </summary>
    VertexTexcoord02,

    /// <summary>
    /// Shader location: vertex attribute: normal
    /// </summary>
    VertexNormal,

    /// <summary>
    /// Shader location: vertex attribute: tangent
    /// </summary>
    VertexTangent,

    /// <summary>
    /// Shader location: vertex attribute: color
    /// </summary>
    VertexColor,

    /// <summary>
    /// Shader location: matrix uniform: model-view-projection
    /// </summary>
    MatrixMvp,

    /// <summary>
    /// Shader location: matrix uniform: view (camera transform)
    /// </summary>
    MatrixView,

    /// <summary>
    /// Shader location: matrix uniform: projection
    /// </summary>
    MatrixProjection,

    /// <summary>
    /// Shader location: matrix uniform: model (transform)
    /// </summary>
    MatrixModel,

    /// <summary>
    /// Shader location: matrix uniform: normal
    /// </summary>
    MatrixNormal,

    /// <summary>
    /// Shader location: vector uniform: view
    /// </summary>
    VectorView,

    /// <summary>
    /// Shader location: vector uniform: diffuse color
    /// </summary>
    ColorDiffuse,

    /// <summary>
    /// Shader location: vector uniform: specular color
    /// </summary>
    ColorSpecular,

    /// <summary>
    /// Shader location: vector uniform: ambient color
    /// </summary>
    ColorAmbient,

    /// <summary>
    /// Shader location: sampler2d texture: albedo (same as: SHADER_LOC_MAP_DIFFUSE)
    /// </summary>
    MapAlbedo,

    /// <summary>
    /// Shader location: sampler2d texture: metalness (same as: SHADER_LOC_MAP_SPECULAR)
    /// </summary>
    MapMetalness,

    /// <summary>
    /// Shader location: sampler2d texture: normal
    /// </summary>
    MapNormal,

    /// <summary>
    /// Shader location: sampler2d texture: roughness
    /// </summary>
    MapRoughness,

    /// <summary>
    /// Shader location: sampler2d texture: occlusion
    /// </summary>
    MapOcclusion,

    /// <summary>
    /// Shader location: sampler2d texture: emission
    /// </summary>
    MapEmission,

    /// <summary>
    /// Shader location: sampler2d texture: height
    /// </summary>
    MapHeight,

    /// <summary>
    /// Shader location: samplerCube texture: cubemap
    /// </summary>
    MapCubemap,

    /// <summary>
    /// Shader location: samplerCube texture: irradiance
    /// </summary>
    MapIrradiance,

    /// <summary>
    /// Shader location: samplerCube texture: prefilter
    /// </summary>
    MapPrefilter,

    /// <summary>
    /// Shader location: sampler2d texture: brdf
    /// </summary>
    MapBrdf,

    /// <summary>
    /// Shader location: sampler2d texture: albedo (same as: SHADER_LOC_MAP_DIFFUSE)
    /// </summary>
    MapDiffuse = MapAlbedo,

    /// <summary>
    /// Shader location: sampler2d texture: metalness (same as: SHADER_LOC_MAP_SPECULAR)
    /// </summary>
    MapSpecular = MapMetalness
}