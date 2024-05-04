using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Materials;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Color = Raylib_CSharp.Colors.Color;

namespace Raylib_CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public partial struct Model {

    /// <summary>
    /// Local transform matrix.
    /// </summary>
    public Matrix4x4 Transform;

    /// <summary>
    /// Number of meshes.
    /// </summary>
    public int MeshCount;

    /// <summary>
    /// Number of materials.
    /// </summary>
    public int MaterialCount;

    /// <summary>
    /// Meshes array.
    /// </summary>
    public unsafe Span<Mesh> Meshes => new(this.MeshesPtr, this.MeshCount);

    public unsafe Mesh* MeshesPtr;

    /// <summary>
    /// Materials array.
    /// </summary>
    public unsafe Span<Material> Materials => new(this.MaterialsPtr, this.MaterialCount);

    public unsafe Material* MaterialsPtr;

    /// <summary>
    /// Mesh material number.
    /// </summary>
    public unsafe Span<int> MeshMaterial => new(this.MeshMaterialPtr, this.MeshCount);

    public unsafe int* MeshMaterialPtr;

    /// <summary>
    /// Number of bones.
    /// </summary>
    public int BoneCount;

    /// <summary>
    /// Bones information (skeleton).
    /// </summary>
    public unsafe Span<BoneInfo> Bones => new(this.BonesPtr, this.BoneCount);

    public unsafe BoneInfo* BonesPtr;

    /// <summary>
    /// Bones base transformation (pose).
    /// </summary>
    public unsafe Span<Transform> BindPose => new(this.BindPosePtr, this.BoneCount);

    public unsafe Transform* BindPosePtr;

    /// <summary>
    /// Load model from files (meshes and materials).
    /// </summary>
    /// <param name="fileName">The name of the file containing the model.</param>
    /// <returns>The loaded model.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadModel", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model Load(string fileName);

    /// <summary>
    /// Load model from generated mesh (default material).
    /// </summary>
    /// <param name="mesh">The mesh object containing the model.</param>
    /// <returns>The loaded model.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadModelFromMesh")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model LoadFromMesh(Mesh mesh);

    /// <summary>
    /// Check if a model is ready.
    /// </summary>
    /// <param name="model">The model to check.</param>
    /// <returns>True if the model is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsModelReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsReady(Model model);

    /// <summary>
    /// Unload model (including meshes) from memory (RAM and/or VRAM).
    /// </summary>
    /// <param name="model">The model to be unloaded.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadModel")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Unload(Model model);

    /// <summary>
    /// Compute model bounding box limits (considers all meshes).
    /// </summary>
    /// <param name="model">The model to get the bounding box from.</param>
    /// <returns>The bounding box of the model.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetModelBoundingBox")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetBoundingBox(Model model);

    /// <summary>
    /// Set material for a mesh.
    /// </summary>
    /// <param name="model">The model to set the material for.</param>
    /// <param name="meshId">The ID of the mesh to set the material for.</param>
    /// <param name="materialId">The ID of the material to set for the mesh.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetModelMeshMaterial")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMeshMaterial(ref Model model, int meshId, int materialId);

    /// <summary>
    /// Sets the shader for a specific material in the model.
    /// </summary>
    /// <param name="model">The model whose material needs to be modified.</param>
    /// <param name="materialIndex">The index of the material within the model.</param>
    /// <param name="shader">The shader to set for the material.</param>
    public static void SetMaterialShader(ref Model model, int materialIndex, Shader shader) {
        model.Materials[materialIndex].Shader = shader;
    }

    /// <summary>
    /// Sets the texture of a material map in a model.
    /// </summary>
    /// <param name="model">The model.</param>
    /// <param name="materialIndex">The index of the material.</param>
    /// <param name="mapIndex">The index of the material map.</param>
    /// <param name="texture">The texture to set.</param>
    public static void SetMaterialTexture(ref Model model, int materialIndex, MaterialMapIndex mapIndex, Texture2D texture) {
        model.Materials[materialIndex].Maps[(int) mapIndex].Texture = texture;
    }

    /// <summary>
    /// Sets the color of a material map for a specific model.
    /// </summary>
    /// <param name="model">The model to modify.</param>
    /// <param name="materialIndex">The index of the material within the model.</param>
    /// <param name="mapIndex">The index of the material map within the material.</param>
    /// <param name="color">The color to set for the material map.</param>
    public static void SetMaterialColor(ref Model model, int materialIndex, MaterialMapIndex mapIndex, Color color) {
        model.Materials[materialIndex].Maps[(int) mapIndex].Color = color;
    }

    /// <summary>
    /// Sets the value of a material map in a model.
    /// </summary>
    /// <param name="model">The model whose material map will be modified.</param>
    /// <param name="materialIndex">The index of the material containing the map.</param>
    /// <param name="mapIndex">The index of the material map to modify.</param>
    /// <param name="value">The new value to assign to the material map.</param>
    public static void SetMaterialValue(ref Model model, int materialIndex, MaterialMapIndex mapIndex, float value) {
        model.Materials[materialIndex].Maps[(int) mapIndex].Value = value;
    }

    /// <summary>
    /// Check collision between two spheres.
    /// </summary>
    /// <param name="center1">The center position of the first sphere.</param>
    /// <param name="radius1">The radius of the first sphere.</param>
    /// <param name="center2">The center position of the second sphere.</param>
    /// <param name="radius2">The radius of the second sphere.</param>
    /// <returns>True if the two spheres collide, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);

    /// <summary>
    /// Check collision between two bounding boxes.
    /// </summary>
    /// <param name="box1">The bounding box of the first sphere.</param>
    /// <param name="box2">The bounding box of the second sphere.</param>
    /// <returns>True if the spheres are colliding, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckCollisionSpheres(BoundingBox box1, BoundingBox box2);

    /// <summary>
    /// Check collision between box and sphere.
    /// </summary>
    /// <param name="box">The bounding box to check against.</param>
    /// <param name="center">The center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>True if the sphere collides with the bounding box, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckCollisionSpheres(BoundingBox box, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and sphere.
    /// </summary>
    /// <param name="ray">The ray used for collision.</param>
    /// <param name="center">The center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>The collision data between the ray and the sphere.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and box.
    /// </summary>
    /// <param name="ray">The ray to check collision with.</param>
    /// <param name="box">The bounding box to check collision with.</param>
    /// <returns>The collision between the ray and the bounding box.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionBox(Ray ray, BoundingBox box);

    /// <summary>
    /// Get collision info between ray and mesh.
    /// </summary>
    /// <param name="ray">The ray to perform the collision check with.</param>
    /// <param name="mesh">The mesh to check collision against.</param>
    /// <param name="transform">The transform to apply to the mesh before collision check.</param>
    /// <returns>The ray collision result.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, Matrix4x4 transform);

    /// <summary>
    /// Get collision info between ray and triangle.
    /// </summary>
    /// <param name="ray">The ray used to calculate collision.</param>
    /// <param name="p1">The first vertex of the triangle.</param>
    /// <param name="p2">The second vertex of the triangle.</param>
    /// <param name="p3">The third vertex of the triangle.</param>
    /// <returns>The collision information between the ray and the triangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3);

    /// <summary>
    /// Get collision info between ray and quad.
    /// </summary>
    /// <param name="ray">The ray to check for collision.</param>
    /// <param name="p1">The first point of the quad.</param>
    /// <param name="p2">The second point of the quad.</param>
    /// <param name="p3">The third point of the quad.</param>
    /// <param name="p4">The fourth point of the quad.</param>
    /// <returns>The collision information between the ray and the quad.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4);
}