using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;

namespace Raylib_CSharp.Materials;

[StructLayout(LayoutKind.Sequential)]
public partial struct Material {

    /// <summary>
    /// Material shader.
    /// </summary>
    public Shader Shader;

    /// <summary>
    /// Material maps array (MAX_MATERIAL_MAPS).
    /// </summary>
    public unsafe Span<MaterialMap> Maps => new(this.MapsPtr, 12);

    public unsafe MaterialMap* MapsPtr;

    /// <summary>
    /// Material generic parameters (if required).
    /// </summary>
    public unsafe Span<float> Param {
        get {
            fixed (float* paramPtr = this.ParamPtr) {
                return new(paramPtr, 4);
            }
        }
    }

    public unsafe fixed float ParamPtr[4];

    /// <summary>
    /// Load materials from model file.
    /// </summary>
    /// <param name="fileName">The name of the file to load materials from.</param>
    /// <param name="materialCount">The number of materials loaded.</param>
    /// <returns>A pointer to the loaded materials.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadMaterials", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Material* Load(string fileName, out int materialCount);

    /// <summary>
    /// Load materials from model file.
    /// </summary>
    /// <param name="fileName">The name of the file to load materials from.</param>
    /// <returns>A Span to the loaded materials.</returns>
    public static unsafe ReadOnlySpan<Material> Load(string fileName) {
        return new ReadOnlySpan<Material>(Load(fileName, out int materialCount), materialCount);
    }

    /// <summary>
    /// Load default material (Supports: DIFFUSE, SPECULAR, NORMAL maps).
    /// </summary>
    /// <returns>A pointer to the loaded material.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadMaterialDefault")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Material LoadDefault();
}

/// <summary>
/// Contains extension methods for the <see cref="Material"/> class.
/// </summary>
public static partial class MaterialExtensions {

    /// <summary>
    /// Check if a material is ready.
    /// </summary>
    /// <param name="material">The material to check.</param>
    /// <returns>True if the material is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsMaterialReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool IsReady_(Material material);
    public static bool IsReady(this Material material) => IsReady_(material);

    /// <summary>
    /// Unload material from GPU memory (VRAM).
    /// </summary>
    /// <param name="material">The material to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadMaterial")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Unload_(Material material);
    public static void Unload(this Material material) => Unload_(material);

    /// <summary>
    /// Set the shader for a material.
    /// </summary>
    /// <param name="material">The material to set the shader for.</param>
    /// <param name="shader">The shader to set.</param>
    private static void SetShader_(ref Material material, Shader shader) {
        material.Shader = shader;
    }
    public static void SetShader(this ref Material material, Shader shader) => SetShader_(ref material, shader);

    /// <summary>
    /// Sets the texture for a specific material map.
    /// </summary>
    /// <param name="material">The reference to the material to modify.</param>
    /// <param name="mapIndex">The index of the material map to modify.</param>
    /// <param name="texture">The texture to assign to the material map.</param>
    private static void SetTexture_(ref Material material, MaterialMapIndex mapIndex, Texture2D texture) {
        material.Maps[(int) mapIndex].Texture = texture;
    }
    public static void SetTexture(this ref Material material, MaterialMapIndex mapIndex, Texture2D texture) => SetTexture_(ref material, mapIndex, texture);

    /// <summary>
    /// Sets the color of a specific material map.
    /// </summary>
    /// <param name="material">The material to modify.</param>
    /// <param name="mapIndex">The index of the material map.</param>
    /// <param name="color">The color to set for the material map.</param>
    private static void SetColor_(ref Material material, MaterialMapIndex mapIndex, Color color) {
        material.Maps[(int) mapIndex].Color = color;
    }
    public static void SetColor(this ref Material material, MaterialMapIndex mapIndex, Color color) => SetColor_(ref material, mapIndex, color);

    /// <summary>
    /// Sets the value of a specific map in a material.
    /// </summary>
    /// <param name="material">The material to modify.</param>
    /// <param name="mapIndex">The index of the map to modify.</param>
    /// <param name="value">The new value for the map.</param>
    private static void SetValue_(ref Material material, MaterialMapIndex mapIndex, float value) {
        material.Maps[(int) mapIndex].Value = value;
    }
    public static void SetValue(this ref Material material, MaterialMapIndex mapIndex, float value) => SetValue_(ref material, mapIndex, value);
}