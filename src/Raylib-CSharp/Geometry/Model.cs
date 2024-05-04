using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Materials;

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
}