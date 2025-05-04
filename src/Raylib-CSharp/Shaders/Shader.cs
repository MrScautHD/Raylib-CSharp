using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Shaders;

[StructLayout(LayoutKind.Sequential)]
public struct Shader {

    /// <summary>
    /// Shader program id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Shader locations array (RL_MAX_SHADER_LOCATIONS).
    /// </summary>
    public unsafe int* LocsPtr;

    /// <inheritdoc cref="LocsPtr" />
    public unsafe Span<int> Locs => new(this.LocsPtr, 32);

    /// <inheritdoc cref="RaylibApi.LoadShader" />
    public static Shader Load(string vsFileName, string fsFileName) {
        return RaylibApi.LoadShader(vsFileName, fsFileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadShaderFromMemory" />
    public static Shader LoadFromMemory(string vsCode, string fsCode) {
        return RaylibApi.LoadShaderFromMemory(vsCode, fsCode);
    }

    /// <inheritdoc cref="RaylibApi.IsShaderValid" />
    public bool IsReady() {
        return RaylibApi.IsShaderValid(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadShader" />
    public void Unload() {
        RaylibApi.UnloadShader(this);
    }

    /// <inheritdoc cref="RaylibApi.GetShaderLocation" />
    public int GetLocation(string uniformName) {
        return RaylibApi.GetShaderLocation(this, uniformName);
    }

    /// <inheritdoc cref="RaylibApi.GetShaderLocationAttrib" />
    public int GetLocationAttrib(string attribName) {
        return RaylibApi.GetShaderLocationAttrib(this, attribName);
    }

    /// <inheritdoc cref="RaylibApi.SetShaderValue" />
    public unsafe void SetValue<T>(int locIndex, T value, ShaderUniformDataType uniformType) where T : unmanaged {
        RaylibApi.SetShaderValue(this, locIndex, &value, uniformType);
    }

    /// <inheritdoc cref="RaylibApi.SetShaderValueV" />
    public unsafe void SetValueV<T>(int locIndex, Span<T> values, ShaderUniformDataType uniformType) where T : unmanaged {
        fixed (T* valuesPtr = values) {
            RaylibApi.SetShaderValueV(this, locIndex, valuesPtr, uniformType, values.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.SetShaderValueMatrix" />
    public void SetValueMatrix(int locIndex, Matrix4x4 mat) {
        RaylibApi.SetShaderValueMatrix(this, locIndex, mat);
    }

    /// <inheritdoc cref="RaylibApi.SetShaderValueTexture" />
    public void SetValueTexture(int locIndex, Texture2D texture) {
        RaylibApi.SetShaderValueTexture(this, locIndex, texture);
    }
}