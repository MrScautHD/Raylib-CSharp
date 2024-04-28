using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public struct Mesh {

    /// <summary>
    /// Mesh, vertex data and vao/vbo.
    /// </summary>
    public Mesh(int vertexCount, int triangleCount) {
        this.VertexCount = vertexCount;
        this.TriangleCount = triangleCount;
    }

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
    public unsafe float* Vertices;

    /// <summary>
    /// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1).
    /// </summary>
    public unsafe float* TexCoords;

    /// <summary>
    /// Vertex texture second coordinates (UV - 2 components per vertex) (shader-location = 5).
    /// </summary>
    public unsafe float* TexCoords2;

    /// <summary>
    /// Vertex normals (XYZ - 3 components per vertex) (shader-location = 2).
    /// </summary>
    public unsafe float* Normals;

    /// <summary>
    /// Vertex tangents (XYZW - 4 components per vertex) (shader-location = 4).
    /// </summary>
    public unsafe float* Tangents;

    /// <summary>
    /// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3).
    /// </summary>
    public unsafe byte* Colors;

    /// <summary>
    /// Vertex indices (in case vertex data comes indexed).
    /// </summary>
    public unsafe ushort* Indices;

    /// <summary>
    /// Animated vertex positions (after bones transformations).
    /// </summary>
    public unsafe float* AnimVertices;

    /// <summary>
    /// Animated normals (after bones transformations).
    /// </summary>
    public unsafe float* AnimNormals;

    /// <summary>
    /// Vertex bone ids, max 255 bone ids, up to 4 bones influence by vertex (skinning).
    /// </summary>
    public unsafe byte* BoneIds;

    /// <summary>
    /// Vertex bone weight, up to 4 bones influence by vertex (skinning).
    /// </summary>
    public unsafe float* BoneWeights;

    /// <summary>
    /// OpenGL Vertex Array Object id.
    /// </summary>
    public uint VaoId;

    /// <summary>
    /// OpenGL Vertex Buffer Objects id (default vertex data).
    /// </summary>
    public unsafe uint* VboId;
}