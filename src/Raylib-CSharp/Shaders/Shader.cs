using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Textures;

namespace Raylib_CSharp.Shaders;

[StructLayout(LayoutKind.Sequential)]
public partial struct Shader {

    /// <summary>
    /// Shader program id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Shader locations array (RL_MAX_SHADER_LOCATIONS).
    /// </summary>
    public unsafe Span<int> Locs => new(this.LocsPtr, 32);

    public unsafe int* LocsPtr;

    /// <summary>
    /// Load shader from files and bind default locations.
    /// </summary>
    /// <param name="vsFileName">The filename of the vertex shader.</param>
    /// <param name="fsFileName">The filename of the fragment shader.</param>
    /// <returns>The loaded shader.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadShader", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader Load(string vsFileName, string fsFileName);

    /// <summary>
    /// Load shader from code strings and bind default locations.
    /// </summary>
    /// <param name="vsCode">The string containing the vertex shader code.</param>
    /// <param name="fsCode">The string containing the fragment shader code.</param>
    /// <returns>The loaded shader.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadShaderFromMemory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadFromMemory(string vsCode, string fsCode);
}

/// <summary>
/// Contains extension methods for the <see cref="Shader"/> class.
/// </summary>
public static partial class ShaderExtensions {

    /// <summary>
    /// Check if a shader is ready.
    /// </summary>
    /// <param name="shader">The shader to check.</param>
    /// <returns>True if the shader is ready; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsShaderReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(Shader shader);
    public static bool IsReady(this Shader shader) => IsReady_(shader);

    /// <summary>
    /// Unload shader from GPU memory (VRAM).
    /// </summary>
    /// <param name="shader">The shader to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadShader")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(Shader shader);
    public static void Unload(this Shader shader) => Unload_(shader);

    /// <summary>
    /// Get shader uniform location.
    /// </summary>
    /// <param name="shader">The shader to query.</param>
    /// <param name="uniformName">The name of the uniform variable.</param>
    /// <returns>The location of the uniform variable. Returns -1 if the uniform does not exist in the shader.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetShaderLocation", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial int GetLocation_(Shader shader, string uniformName);
    public static int GetLocation(this Shader shader, string uniformName) => GetLocation_(shader, uniformName);

    /// <summary>
    /// Get shader attribute location.
    /// </summary>
    /// <param name="shader">The shader to retrieve the attribute location from.</param>
    /// <param name="attribName">The name of the attribute.</param>
    /// <returns>The location of the attribute.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetShaderLocationAttrib", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial int GetLocationAttrib_(Shader shader, string attribName);
    public static int GetLocationAttrib(this Shader shader, string attribName) => GetLocationAttrib_(shader, attribName);

    /// <summary>
    /// Set shader uniform value.
    /// </summary>
    /// <param name="shader">The shader containing the uniform variable.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetShaderValue")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial void SetValue_(Shader shader, int locIndex, void* value, ShaderUniformDataType uniformType);
    public static unsafe void SetValue(this Shader shader, int locIndex, void* value, ShaderUniformDataType uniformType) => SetValue_(shader, locIndex, value, uniformType);

    /// <summary>
    /// Set shader uniform value.
    /// </summary>
    /// <param name="shader">The shader containing the uniform variable.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    private static unsafe void SetValue_<T>(Shader shader, int locIndex, T value, ShaderUniformDataType uniformType) where T : unmanaged {
        SetValue(shader, locIndex, &value, uniformType);
    }
    public static void SetValue<T>(this Shader shader, int locIndex, T value, ShaderUniformDataType uniformType) where T : unmanaged => SetValue_(shader, locIndex, value, uniformType);

    /// <summary>
    /// Set shader uniform value vector.
    /// </summary>
    /// <param name="shader">The shader program.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="values">The values to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    /// <param name="count">The number of elements to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetShaderValueV")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial void SetValueV_(Shader shader, int locIndex, void* values, ShaderUniformDataType uniformType, int count);
    public static unsafe void SetValueV(this Shader shader, int locIndex, void* values, ShaderUniformDataType uniformType, int count) => SetValueV_(shader, locIndex, values, uniformType, count);

    /// <summary>
    /// Set shader uniform value vector.
    /// </summary>
    /// <param name="shader">The shader program.</param>
    /// <param name="locIndex">The location index of the uniform variable.</param>
    /// <param name="values">The values to set.</param>
    /// <param name="uniformType">The data type of the uniform variable.</param>
    private static unsafe void SetValueV_<T>(Shader shader, int locIndex, Span<T> values, ShaderUniformDataType uniformType) where T : unmanaged {
        fixed (T* valuesPtr = values) {
            SetValueV(shader, locIndex, valuesPtr, uniformType, values.Length);
        }
    }
    public static void SetValueV<T>(this Shader shader, int locIndex, Span<T> values, ShaderUniformDataType uniformType) where T : unmanaged => SetValueV_(shader, locIndex, values, uniformType);

    /// <summary>
    /// Set shader uniform value (matrix 4x4).
    /// </summary>
    /// <param name="shader">The shader to set the value in.</param>
    /// <param name="locIndex">The index of the uniform location.</param>
    /// <param name="mat">The matrix value to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetShaderValueMatrix")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetValueMatrix_(Shader shader, int locIndex, Matrix4x4 mat);
    public static void SetValueMatrix(this Shader shader, int locIndex, Matrix4x4 mat) => SetValueMatrix_(shader, locIndex, mat);

    /// <summary>
    /// Set shader uniform value for texture (sampler2d).
    /// </summary>
    /// <param name="shader">The shader to set the value in.</param>
    /// <param name="locIndex">The index of the uniform location.</param>
    /// <param name="texture">The texture to set the value to.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetShaderValueTexture")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void SetValueTexture_(Shader shader, int locIndex, Texture2D texture);
    public static void SetValueTexture(this Shader shader, int locIndex, Texture2D texture) => SetValueTexture_(shader, locIndex, texture);
}