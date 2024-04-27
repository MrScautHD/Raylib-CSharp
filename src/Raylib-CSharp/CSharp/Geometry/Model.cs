using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Materials;
using Raylib_CSharp.CSharp.Misc;

namespace Raylib_CSharp.CSharp.Geometry;

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
    public unsafe Mesh* Meshes;

    /// <summary>
    /// Materials array.
    /// </summary>
    public unsafe Material* Materials;

    /// <summary>
    /// Mesh material number.
    /// </summary>
    public unsafe int* MeshMaterial;

    /// <summary>
    /// Number of bones.
    /// </summary>
    public int BoneCount;

    /// <summary>
    /// Bones information (skeleton).
    /// </summary>
    public unsafe BoneInfo* Bones;

    /// <summary>
    /// Bones base transformation (pose).
    /// </summary>
    public unsafe Transform* BindPose;
}