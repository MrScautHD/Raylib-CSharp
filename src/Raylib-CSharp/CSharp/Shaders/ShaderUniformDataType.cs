namespace Raylib_CSharp.CSharp.Shaders;

public enum ShaderUniformDataType {

    /// <summary>
    /// Shader uniform type: float.
    /// </summary>
    Float = 0,

    /// <summary>
    /// Shader uniform type: vec2 (2 float).
    /// </summary>
    Vec2,

    /// <summary>
    /// Shader uniform type: vec3 (3 float).
    /// </summary>
    Vec3,

    /// <summary>
    /// Shader uniform type: vec4 (4 float).
    /// </summary>
    Vec4,

    /// <summary>
    /// Shader uniform type: int.
    /// </summary>
    Int,

    /// <summary>
    /// Shader uniform type: ivec2 (2 int).
    /// </summary>
    IVec2,

    /// <summary>
    /// Shader uniform type: ivec3 (3 int).
    /// </summary>
    IVec3,

    /// <summary>
    /// Shader uniform type: ivec4 (4 int).
    /// </summary>
    IVec4,

    /// <summary>
    /// Shader uniform type: sampler2d.
    /// </summary>
    Sampler2D
}