using System.Runtime.InteropServices;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Materials;

[StructLayout(LayoutKind.Sequential)]
public struct Material {

    /// <summary>
    /// Material shader.
    /// </summary>
    public Shader Shader;

    /// <summary>
    /// Material maps array (MAX_MATERIAL_MAPS).
    /// </summary>
    public unsafe MaterialMap* MapsPtr;

    /// <inheritdoc cref="MapsPtr" />
    public unsafe Span<MaterialMap> Maps => new(this.MapsPtr, 12);

    /// <summary>
    /// Material generic parameters (if required).
    /// </summary>
    public unsafe fixed float ParamPtr[4];

    /// <inheritdoc cref="ParamPtr" />
    public unsafe Span<float> Param {
        get {
            fixed (float* paramPtr = this.ParamPtr) {
                return new(paramPtr, 4);
            }
        }
    }

    /// <inheritdoc cref="RaylibApi.LoadMaterials" />
    public static unsafe ReadOnlySpan<Material> LoadMaterials(string fileName) {
        return new ReadOnlySpan<Material>(RaylibApi.LoadMaterials(fileName, out int materialCount), materialCount);
    }

    /// <inheritdoc cref="RaylibApi.LoadMaterialDefault" />
    public static Material LoadDefault() {
        return RaylibApi.LoadMaterialDefault();
    }

    /// <inheritdoc cref="RaylibApi.IsMaterialValid" />
    public bool IsReady() {
        return RaylibApi.IsMaterialValid(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadMaterial" />
    public void Unload() {
        RaylibApi.UnloadMaterial(this);
    }

    /// <summary>
    /// Set the shader for a material.
    /// </summary>
    /// <param name="shader">The shader to set.</param>
    public void SetShader(Shader shader) {
        this.Shader = shader;
    }

    /// <summary>
    /// Sets the texture for a specific material map.
    /// </summary>
    /// <param name="mapIndex">The index of the material map to modify.</param>
    /// <param name="texture">The texture to assign to the material map.</param>
    public void SetTexture(MaterialMapIndex mapIndex, Texture2D texture) {
        this.Maps[(int)mapIndex].Texture = texture;
    }

    /// <summary>
    /// Sets the color of a specific material map.
    /// </summary>
    /// <param name="mapIndex">The index of the material map.</param>
    /// <param name="color">The color to set for the material map.</param>
    public void SetColor(MaterialMapIndex mapIndex, Color color) {
        this.Maps[(int)mapIndex].Color = color;
    }

    /// <summary>
    /// Sets the value of a specific map in a material.
    /// </summary>
    /// <param name="mapIndex">The index of the map to modify.</param>
    /// <param name="value">The new value for the map.</param>
    public void SetValue(MaterialMapIndex mapIndex, float value) {
        this.Maps[(int)mapIndex].Value = value;
    }
}