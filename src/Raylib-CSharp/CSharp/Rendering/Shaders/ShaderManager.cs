using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Rendering.Textures;

namespace Raylib_CSharp.CSharp.Rendering.Shaders;

public static partial class ShaderManager {

    /// <summary>
    /// Load shader from files and bind default locations.
    /// </summary>
    /// <param name="vsFileName">The filename of the vertex shader.</param>
    /// <param name="fsFileName">The filename of the fragment shader.</param>
    /// <returns>The loaded shader.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadShader(string vsFileName, string fsFileName);

    /// <summary>
    /// Load shader from code strings and bind default locations.
    /// </summary>
    /// <param name="vsCode">The string containing the vertex shader code.</param>
    /// <param name="fsCode">The string containing the fragment shader code.</param>
    /// <returns>The loaded shader.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadShaderFromMemory(string vsCode, string fsCode);

    /// <summary>
    /// Check if a shader is ready.
    /// </summary>
    /// <param name="shader">The shader to check.</param>
    /// <returns>True if the shader is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsShaderReady(Shader shader);

    /// <summary>
    /// Get shader uniform location.
    /// </summary>
    /// <param name="shader">The shader to query.</param>
    /// <param name="uniformName">The name of the uniform variable.</param>
    /// <returns>The location of the uniform variable. Returns -1 if the uniform does not exist in the shader.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetShaderLocation(Shader shader, string uniformName);

    /// <summary>
    /// Get shader attribute location.
    /// </summary>
    /// <param name="shader">The shader to retrieve the attribute location from.</param>
    /// <param name="attribName">The name of the attribute.</param>
    /// <returns>The location of the attribute.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetShaderLocationAttrib(Shader shader, string attribName);

    /// <summary>
    /// Set shader uniform value.
    /// </summary>
    /// <param name="shader">The shader containing the uniform variable.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial void SetShaderValue(Shader shader, int locIndex, void* value, ShaderUniformDataType uniformType);

    /// <summary>
    /// Set shader uniform value.
    /// </summary>
    /// <param name="shader">The shader containing the uniform variable.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    public static unsafe void SetShaderValue<T>(Shader shader, int locIndex, T value, ShaderUniformDataType uniformType) where T : unmanaged {
        SetShaderValue(shader, locIndex, &value, uniformType);
    }

    /// <summary>
    /// Set shader uniform value vector.
    /// </summary>
    /// <param name="shader">The shader program.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="values">The values to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    /// <param name="count">The number of elements to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial void SetShaderValueV(Shader shader, int locIndex, void* values, ShaderUniformDataType uniformType, int count);

    /// <summary>
    /// Set shader uniform value vector.
    /// </summary>
    /// <param name="shader">The shader program.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="values">The values to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    public static unsafe void SetShaderValueV<T>(Shader shader, int locIndex, T[] values, ShaderUniformDataType uniformType) where T : unmanaged {
        fixed (T* valuePtr = values) {
            SetShaderValueV(shader, locIndex, valuePtr, uniformType, values.Length);
        }
    }

    /// <summary>
    /// Set shader uniform value (matrix 4x4).
    /// </summary>
    /// <param name="shader">The shader to set the value in.</param>
    /// <param name="locIndex">The index of the uniform location.</param>
    /// <param name="mat">The matrix value to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetShaderValueMatrix(Shader shader, int locIndex, Matrix4x4 mat);

    /// <summary>
    /// Set shader uniform value for texture (sampler2d).
    /// </summary>
    /// <param name="shader">The shader to set the value in.</param>
    /// <param name="locIndex">The index of the uniform location.</param>
    /// <param name="texture">The texture to set the value to.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetShaderValueTexture(Shader shader, int locIndex, Texture2D texture);

    /// <summary>
    /// Unload shader from GPU memory (VRAM).
    /// </summary>
    /// <param name="shader">The shader to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void UnloadShader(Shader shader);
}