using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Colors;
using Raylib_CSharp.CSharp.Shaders;
using Raylib_CSharp.CSharp.Textures;

namespace Raylib_CSharp.CSharp.Materials;

public static partial class MaterialManager {

    /// <summary>
    /// Load materials from model file.
    /// </summary>
    /// <param name="fileName">The name of the file to load materials from.</param>
    /// <param name="materialCount">The number of materials loaded.</param>
    /// <returns>A pointer to the loaded materials.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Material* LoadMaterials(string fileName, out int materialCount);

    /// <summary>
    /// Load default material (Supports: DIFFUSE, SPECULAR, NORMAL maps).
    /// </summary>
    /// <returns>A pointer to the loaded material.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Material LoadMaterialDefault();

    /// <summary>
    /// Check if a material is ready.
    /// </summary>
    /// <param name="material">The material to check.</param>
    /// <returns>True if the material is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsMaterialReady(Material material);

    /// <summary>
    /// Unload material from GPU memory (VRAM).
    /// </summary>
    /// <param name="material">The material to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMaterial(Material material);

    /// <summary>
    /// Set the shader for a material.
    /// </summary>
    /// <param name="material">The material to set the shader for.</param>
    /// <param name="shader">The shader to set.</param>
    public static void SetMaterialShader(ref Material material, Shader shader) {
        material.Shader = shader;
    }

    /// <summary>
    /// Sets the texture for a specific material map.
    /// </summary>
    /// <param name="material">The reference to the material to modify.</param>
    /// <param name="mapIndex">The index of the material map to modify.</param>
    /// <param name="texture">The texture to assign to the material map.</param>
    public static unsafe void SetMaterialTexture(ref Material material, MaterialMapIndex mapIndex, Texture2D texture) {
        material.Maps[(int) mapIndex].Texture = texture;
    }

    /// <summary>
    /// Sets the color of a specific material map.
    /// </summary>
    /// <param name="material">The material to modify.</param>
    /// <param name="mapIndex">The index of the material map.</param>
    /// <param name="color">The color to set for the material map.</param>
    public static unsafe void SetMaterialColor(ref Material material, MaterialMapIndex mapIndex, Color color) {
        material.Maps[(int) mapIndex].Color = color;
    }

    /// <summary>
    /// Sets the value of a specific map in a material.
    /// </summary>
    /// <param name="material">The material to modify.</param>
    /// <param name="mapIndex">The index of the map to modify.</param>
    /// <param name="value">The new value for the map.</param>
    public static unsafe void SetMaterialValue(ref Material material, MaterialMapIndex mapIndex, float value) {
        material.Maps[(int) mapIndex].Value = value;
    }
}