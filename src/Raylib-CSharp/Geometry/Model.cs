using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Materials;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public struct Model {

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
    public unsafe Mesh* MeshesPtr;

    /// <inheritdoc cref="MeshesPtr" />
    public unsafe Span<Mesh> Meshes => new(this.MeshesPtr, this.MeshCount);

    /// <summary>
    /// Materials array.
    /// </summary>
    public unsafe Material* MaterialsPtr;

    /// <inheritdoc cref="MaterialsPtr" />
    public unsafe Span<Material> Materials => new(this.MaterialsPtr, this.MaterialCount);

    /// <summary>
    /// Mesh material number.
    /// </summary>
    public unsafe int* MeshMaterialPtr;

    /// <inheritdoc cref="MeshMaterialPtr" />
    public unsafe Span<int> MeshMaterial => new(this.MeshMaterialPtr, this.MeshCount);

    /// <summary>
    /// Number of bones.
    /// </summary>
    public int BoneCount;

    /// <summary>
    /// Bones information (skeleton).
    /// </summary>
    public unsafe BoneInfo* BonesPtr;

    /// <inheritdoc cref="BonesPtr" />
    public unsafe Span<BoneInfo> Bones => new(this.BonesPtr, this.BoneCount);

    /// <summary>
    /// Bones base transformation (pose).
    /// </summary>
    public unsafe Transform* BindPosePtr;

    /// <inheritdoc cref="BindPosePtr" />
    public unsafe Span<Transform> BindPose => new(this.BindPosePtr, this.BoneCount);

    /// <inheritdoc cref="RaylibApi.LoadModel" />
    public static Model Load(string fileName) {
        return RaylibApi.LoadModel(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadModelFromMesh" />
    public static Model LoadFromMesh(Mesh mesh) {
        return RaylibApi.LoadModelFromMesh(mesh);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionSpheres" />
    public static bool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2) {
        return RaylibApi.CheckCollisionSpheres(center1, radius1, center2, radius2);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionSpheres" />
    public static bool CheckCollisionSpheres(BoundingBox box1, BoundingBox box2) {
        return RaylibApi.CheckCollisionBoxes(box1, box2);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionSpheres" />
    public static bool CheckCollisionSpheres(BoundingBox box, Vector3 center, float radius) {
        return RaylibApi.CheckCollisionBoxSphere(box, center, radius);
    }

    /// <inheritdoc cref="RaylibApi.GetRayCollisionSphere" />
    public static RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius) {
        return RaylibApi.GetRayCollisionSphere(ray, center, radius);
    }

    /// <inheritdoc cref="RaylibApi.GetRayCollisionBox" />
    public static RayCollision GetRayCollisionBox(Ray ray, BoundingBox box) {
        return RaylibApi.GetRayCollisionBox(ray, box);
    }

    /// <inheritdoc cref="RaylibApi.GetRayCollisionMesh" />
    public static RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, Matrix4x4 transform) {
        return RaylibApi.GetRayCollisionMesh(ray, mesh, transform);
    }

    /// <inheritdoc cref="RaylibApi.GetRayCollisionTriangle" />
    public static RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3) {
        return RaylibApi.GetRayCollisionTriangle(ray, p1, p2, p3);
    }

    /// <inheritdoc cref="RaylibApi.GetRayCollisionQuad" />
    public static RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4) {
        return RaylibApi.GetRayCollisionQuad(ray, p1, p2, p3, p4);
    }

    /// <inheritdoc cref="RaylibApi.IsModelValid" />
    public bool IsReady() {
        return RaylibApi.IsModelValid(this);
    }

    /// <inheritdoc cref="RaylibApi.UnloadModel" />
    public void Unload() {
        RaylibApi.UnloadModel(this);
    }

    /// <inheritdoc cref="RaylibApi.GetModelBoundingBox" />
    public BoundingBox GetBoundingBox() {
        return RaylibApi.GetModelBoundingBox(this);
    }

    /// <inheritdoc cref="RaylibApi.SetModelMeshMaterial" />
    public void SetMeshMaterial(int meshId, int materialId) {
        RaylibApi.SetModelMeshMaterial(ref this, meshId, materialId);
    }

    /// <summary>
    /// Sets the shader for a specific material in the model.
    /// </summary>
    /// <param name="materialIndex">The index of the material within the model.</param>
    /// <param name="shader">The shader to set for the material.</param>
    public void SetMaterialShader(int materialIndex, Shader shader) {
        this.Materials[materialIndex].Shader = shader;
    }

    /// <summary>
    /// Sets the texture of a material map in a model.
    /// </summary>
    /// <param name="materialIndex">The index of the material.</param>
    /// <param name="mapIndex">The index of the material map.</param>
    /// <param name="texture">The texture to set.</param>
    public void SetMaterialTexture(int materialIndex, MaterialMapIndex mapIndex, Texture2D texture) {
        this.Materials[materialIndex].Maps[(int)mapIndex].Texture = texture;
    }

    /// <summary>
    /// Sets the color of a material map for a specific model.
    /// </summary>
    /// <param name="materialIndex">The index of the material within the model.</param>
    /// <param name="mapIndex">The index of the material map within the material.</param>
    /// <param name="color">The color to set for the material map.</param>
    public void SetMaterialColor(int materialIndex, MaterialMapIndex mapIndex, Color color) {
        this.Materials[materialIndex].Maps[(int)mapIndex].Color = color;
    }

    /// <summary>
    /// Sets the value of a material map in a model.
    /// </summary>
    /// <param name="materialIndex">The index of the material containing the map.</param>
    /// <param name="mapIndex">The index of the material map to modify.</param>
    /// <param name="value">The new value to assign to the material map.</param>
    public void SetMaterialValue(int materialIndex, MaterialMapIndex mapIndex, float value) {
        this.Materials[materialIndex].Maps[(int)mapIndex].Value = value;
    }
}