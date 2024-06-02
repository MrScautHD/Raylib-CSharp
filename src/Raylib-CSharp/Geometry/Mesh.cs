using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Images;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public struct Mesh {

    /// <summary>
    /// Number of vertices stored in arrays.
    /// </summary>
    public int VertexCount;

    /// <summary>
    /// Number of triangles stored (indexed or not).
    /// </summary>
    public int TriangleCount;

    /// <summary>
    /// Vertex position (XYZ - 3 components per vertex) (shader-location = 0).
    /// </summary>
    public unsafe float* VerticesPtr;

    /// <inheritdoc cref="VerticesPtr" />
    public unsafe Span<Vector3> Vertices => new(this.VerticesPtr, this.VertexCount);

    /// <summary>
    /// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1).
    /// </summary>
    public unsafe float* TexCoordsPtr;

    /// <inheritdoc cref="TexCoordsPtr" />
    public unsafe Span<Vector2> TexCoords => new(this.TexCoordsPtr, this.VertexCount);

    /// <summary>
    /// Vertex texture second coordinates (UV - 2 components per vertex) (shader-location = 5).
    /// </summary>
    public unsafe float* TexCoords2Ptr;

    /// <inheritdoc cref="TexCoords2Ptr" />
    public unsafe Span<Vector2> TexCoords2 => new(this.TexCoords2Ptr, this.VertexCount);

    /// <summary>
    /// Vertex normals (XYZ - 3 components per vertex) (shader-location = 2).
    /// </summary>
    public unsafe float* NormalsPtr;

    /// <inheritdoc cref="NormalsPtr" />
    public unsafe Span<Vector3> Normals => new(this.NormalsPtr, this.VertexCount);

    /// <summary>
    /// Vertex tangents (XYZW - 4 components per vertex) (shader-location = 4).
    /// </summary>
    public unsafe float* TangentsPtr;

    /// <inheritdoc cref="TangentsPtr" />
    public unsafe Span<Vector4> Tangents => new(this.TangentsPtr, this.VertexCount);

    /// <summary>
    /// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3).
    /// </summary>
    public unsafe byte* ColorsPtr;

    /// <inheritdoc cref="ColorsPtr" />
    public unsafe Span<Color> Colors => new(this.ColorsPtr, this.VertexCount);

    /// <summary>
    /// Vertex indices (in case vertex data comes indexed).
    /// </summary>
    public unsafe ushort* IndicesPtr;

    /// <inheritdoc cref="IndicesPtr" />
    public unsafe Span<ushort> Indices => new(this.IndicesPtr, this.TriangleCount * 3);

    /// <summary>
    /// Animated vertex positions (after bones transformations).
    /// </summary>
    public unsafe float* AnimVerticesPtr;

    /// <inheritdoc cref="AnimVertices" />
    public unsafe Span<Vector3> AnimVertices => new(this.AnimVerticesPtr, this.VertexCount);

    /// <summary>
    /// Animated normals (after bones transformations).
    /// </summary>
    public unsafe float* AnimNormalsPtr;

    /// <inheritdoc cref="AnimNormalsPtr" />
    public unsafe Span<Vector3> AnimNormals => new(this.AnimNormalsPtr, this.VertexCount);

    /// <summary>
    /// Vertex bone ids, max 255 bone ids, up to 4 bones influence by vertex (skinning).
    /// </summary>
    public unsafe byte* BoneIdsPtr;

    /// <inheritdoc cref="BoneIdsPtr" />
    public unsafe Span<byte> BoneIds => new(this.BoneIdsPtr, this.VertexCount * 4);

    /// <summary>
    /// Vertex bone weight, up to 4 bones influence by vertex (skinning).
    /// </summary>
    public unsafe float* BoneWeightsPtr;

    /// <inheritdoc cref="BoneWeightsPtr" />
    public unsafe Span<float> BoneWeights => new(this.BoneWeightsPtr, this.VertexCount * 4);

    /// <summary>
    /// OpenGL Vertex Buffer Objects id (default vertex data).
    /// </summary>
    public unsafe uint* VboIdPtr;

    /// <inheritdoc cref="VboIdPtr" />
    public unsafe Span<uint> VboId => new(this.VboIdPtr, this.VertexCount * 7);

    /// <summary>
    /// OpenGL Vertex Array Object id.
    /// </summary>
    public uint VaoId;

    /// <summary>
    /// Mesh, vertex data and vao/vbo.
    /// </summary>
    /// <param name="vertexCount">Number of vertices in the mesh.</param>
    /// <param name="triangleCount">Number of triangles in the mesh.</param>
    public Mesh(int vertexCount, int triangleCount) {
        this.VertexCount = vertexCount;
        this.TriangleCount = triangleCount;
    }

    /// <summary>
    /// Allocates memory for the vertices of the Mesh.
    /// </summary>
    public unsafe void AllocVertices() {
        this.VerticesPtr = Raylib.MemAlloc<float>(this.VertexCount * 3);
    }

    /// <summary>
    /// Allocates memory for the texture coordinates of a mesh.
    /// </summary>
    public unsafe void AllocTexCoords() {
        this.TexCoordsPtr = Raylib.MemAlloc<float>(this.VertexCount * 2);
    }

    /// <summary>
    /// Allocates memory for the second set of texture coordinates of a mesh.
    /// </summary>
    public unsafe void AllocTexCoords2() {
        this.TexCoords2Ptr = Raylib.MemAlloc<float>(this.VertexCount * 2);
    }

    /// <summary>
    /// Allocates memory for the normal vectors of the mesh.
    /// </summary>
    public unsafe void AllocNormals() {
        this.NormalsPtr = Raylib.MemAlloc<float>(this.VertexCount * 3);
    }

    /// <summary>
    /// Allocates memory for tangents in the mesh.
    /// </summary>
    public unsafe void AllocTangents() {
        this.TangentsPtr = Raylib.MemAlloc<float>(this.VertexCount * 4);
    }

    /// <summary>
    /// Allocates memory for the colors of a mesh.
    /// </summary>
    public unsafe void AllocColors() {
        this.ColorsPtr = Raylib.MemAlloc<byte>(this.VertexCount * 4);
    }

    /// <summary>
    /// Allocates memory for the indices array in a mesh.
    /// </summary>
    public unsafe void AllocIndices() {
        this.IndicesPtr = Raylib.MemAlloc<ushort>(this.TriangleCount * 3);
    }

    /// <summary>
    /// Allocates memory for the animation vertices in a mesh.
    /// </summary>
    public unsafe void AllocAnimVertices() {
        this.AnimVerticesPtr = Raylib.MemAlloc<float>(this.VertexCount * 3);
    }

    /// <summary>
    /// Allocates memory for animated normals of a mesh.
    /// </summary>
    public unsafe void AllocAnimNormals() {
        this.AnimNormalsPtr = Raylib.MemAlloc<float>(this.VertexCount * 3);
    }

    /// <summary>
    /// Allocates memory for bone Ids of a mesh.
    /// </summary>
    public unsafe void AllocBoneIds() {
        this.BoneIdsPtr = Raylib.MemAlloc<byte>(this.VertexCount * 4);
    }

    /// <summary>
    /// Allocates memory for bone weights of a mesh.
    /// </summary>
    public unsafe void AllocBoneWeights() {
        this.BoneWeightsPtr = Raylib.MemAlloc<float>(this.VertexCount * 4);
    }

    /// <summary>
    /// Allocates memory for the VBO IDs of a mesh.
    /// </summary>
    public unsafe void AllocVboId() {
        this.VboIdPtr = Raylib.MemAlloc<uint>(this.VertexCount * 7);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshPoly" />
    public static Mesh GenPoly(int sides, float radius) {
        return RaylibApi.GenMeshPoly(sides, radius);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshPlane" />
    public static Mesh GenPlane(float width, float length, int resX, int resZ) {
        return RaylibApi.GenMeshPlane(width, length, resX, resZ);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshCube" />
    public static Mesh GenCube(float width, float height, float length) {
        return RaylibApi.GenMeshCube(width, height, length);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshSphere" />
    public static Mesh GenSphere(float radius, int rings, int slices) {
        return RaylibApi.GenMeshSphere(radius, rings, slices);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshHemiSphere" />
    public static Mesh GenHemiSphere(float radius, int rings, int slices) {
        return RaylibApi.GenMeshHemiSphere(radius, rings, slices);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshCylinder" />
    public static Mesh GenCylinder(float radius, float height, int slices) {
        return RaylibApi.GenMeshCylinder(radius, height, slices);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshCone" />
    public static Mesh GenCone(float radius, float height, int slices) {
        return RaylibApi.GenMeshCone(radius, height, slices);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshTorus" />
    public static Mesh GenTorus(float radius, float size, int radSeg, int sides) {
        return RaylibApi.GenMeshTorus(radius, size, radSeg, sides);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshKnot" />
    public static Mesh GenKnot(float radius, float size, int radSeg, int sides) {
        return RaylibApi.GenMeshKnot(radius, size, radSeg, sides);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshHeightmap" />
    public static Mesh GenHeightmap(Image heightmap, Vector3 size) {
        return RaylibApi.GenMeshHeightmap(heightmap, size);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshCubicmap" />
    public static Mesh GenCubicmap(Image cubicmap, Vector3 cubeSize) {
        return RaylibApi.GenMeshCubicmap(cubicmap, cubeSize);
    }

    /// <inheritdoc cref="RaylibApi.UploadMesh" />
    public void Upload(bool dynamic) {
        RaylibApi.UploadMesh(ref this, dynamic);
    }

    /// <inheritdoc cref="RaylibApi.UpdateMeshBuffer" />
    public void UpdateBuffer(int index, nint data, int dataSize, int offset) {
        RaylibApi.UpdateMeshBuffer(this, index, data, dataSize, offset);
    }

    /// <inheritdoc cref="RaylibApi.UnloadMesh" />
    public void Unload() {
        RaylibApi.UnloadMesh(this);
    }

    /// <inheritdoc cref="RaylibApi.GetMeshBoundingBox" />
    public BoundingBox GetBoundingBox() {
        return RaylibApi.GetMeshBoundingBox(this);
    }

    /// <inheritdoc cref="RaylibApi.GenMeshTangents" />
    public void GenTangents() {
        RaylibApi.GenMeshTangents(ref this);
    }

    /// <inheritdoc cref="RaylibApi.ExportMesh" />
    public bool Export(string fileName) {
        return RaylibApi.ExportMesh(this, fileName);
    }

    /// <inheritdoc cref="RaylibApi.ExportMeshAsCode" />
    public bool ExportAsCode(string fileName) {
        return RaylibApi.ExportMeshAsCode(this, fileName);
    }
}