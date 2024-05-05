using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Images;

namespace Raylib_CSharp.Geometry;

[StructLayout(LayoutKind.Sequential)]
public partial struct Mesh {

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
    public unsafe Span<Vector3> Vertices => new(this.VerticesPtr, this.VertexCount);

    public unsafe float* VerticesPtr;

    /// <summary>
    /// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1).
    /// </summary>
    public unsafe Span<Vector2> TexCoords => new(this.TexCoordsPtr, this.VertexCount);

    public unsafe float* TexCoordsPtr;

    /// <summary>
    /// Vertex texture second coordinates (UV - 2 components per vertex) (shader-location = 5).
    /// </summary>
    public unsafe Span<Vector2> TexCoords2 => new(this.TexCoords2Ptr, this.VertexCount);

    public unsafe float* TexCoords2Ptr;

    /// <summary>
    /// Vertex normals (XYZ - 3 components per vertex) (shader-location = 2).
    /// </summary>
    public unsafe Span<Vector3> Normals => new(this.NormalsPtr, this.VertexCount);

    public unsafe float* NormalsPtr;

    /// <summary>
    /// Vertex tangents (XYZW - 4 components per vertex) (shader-location = 4).
    /// </summary>
    public unsafe Span<Vector4> Tangents => new(this.TangentsPtr, this.VertexCount);

    public unsafe float* TangentsPtr;

    /// <summary>
    /// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3).
    /// </summary>
    public unsafe Span<Color> Colors => new(this.ColorsPtr, this.VertexCount);

    public unsafe byte* ColorsPtr;

    /// <summary>
    /// Vertex indices (in case vertex data comes indexed).
    /// </summary>
    public unsafe Span<ushort> Indices => new(this.IndicesPtr, this.TriangleCount * 3);

    public unsafe ushort* IndicesPtr;

    /// <summary>
    /// Animated vertex positions (after bones transformations).
    /// </summary>
    public unsafe Span<Vector3> AnimVertices => new(this.AnimVerticesPtr, this.VertexCount);

    public unsafe float* AnimVerticesPtr;

    /// <summary>
    /// Animated normals (after bones transformations).
    /// </summary>
    public unsafe Span<Vector3> AnimNormals => new(this.AnimNormalsPtr, this.VertexCount);

    public unsafe float* AnimNormalsPtr;

    /// <summary>
    /// Vertex bone ids, max 255 bone ids, up to 4 bones influence by vertex (skinning).
    /// </summary>
    public unsafe Span<byte> BoneIds => new(this.BoneIdsPtr, this.VertexCount * 4);

    public unsafe byte* BoneIdsPtr;

    /// <summary>
    /// Vertex bone weight, up to 4 bones influence by vertex (skinning).
    /// </summary>
    public unsafe Span<float> BoneWeights => new(this.BoneWeightsPtr, this.VertexCount * 4);

    public unsafe float* BoneWeightsPtr;

    /// <summary>
    /// OpenGL Vertex Buffer Objects id (default vertex data).
    /// </summary>
    public unsafe Span<uint> VboId => new(this.VboIdPtr, this.VertexCount * 7);

    public unsafe uint* VboIdPtr;

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

    /// <summary>
    /// Upload mesh vertex data in GPU and provide VAO/VBO ids.
    /// </summary>
    /// <param name="mesh">The mesh data to upload</param>
    /// <param name="dynamic">Determines if the mesh data should be uploaded as dynamic or static</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UploadMesh")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Upload(ref Mesh mesh, [MarshalAs(UnmanagedType.I1)] bool dynamic);

    /// <summary>
    /// Update mesh vertex data in GPU for a specific buffer index.
    /// </summary>
    /// <param name="mesh">The mesh to update</param>
    /// <param name="index">The index of the buffer to update</param>
    /// <param name="data">A pointer to the new vertex data</param>
    /// <param name="dataSize">The size of the new data in bytes</param>
    /// <param name="offset">Offset in bytes to offset the mesh data</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateMeshBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateBuffer(Mesh mesh, int index, nint data, int dataSize, int offset);

    /// <summary>
    /// Unload mesh data from CPU and GPU.
    /// </summary>
    /// <param name="mesh">The mesh data to unload</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadMesh")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Unload(Mesh mesh);

    /// <summary>
    /// Export mesh data to file, returns true on success.
    /// </summary>
    /// <param name="mesh">The mesh data to export.</param>
    /// <param name="fileName">The name of the file to export the mesh to.</param>
    /// <returns>Returns true if the export was successful, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportMesh", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool Export(Mesh mesh, string fileName);

    /// <summary>
    /// Compute mesh bounding box limits.
    /// </summary>
    /// <param name="mesh">The mesh to get the bounding box from</param>
    /// <returns>The bounding box of the mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetMeshBoundingBox")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetBoundingBox(Mesh mesh);

    /// <summary>
    /// Compute mesh tangents.
    /// </summary>
    /// <param name="mesh">The mesh to generate tangents for</param>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshTangents")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GenTangents(ref Mesh mesh);

    /// <summary>
    /// Generate polygonal mesh.
    /// </summary>
    /// <param name="sides">The number of sides of the polygon</param>
    /// <param name="radius">The radius of the polygon</param>
    /// <returns>The generated Mesh object</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshPoly")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenPoly(int sides, float radius);

    /// <summary>
    /// Generate plane mesh (with subdivisions).
    /// </summary>
    /// <param name="width">The width of the plane</param>
    /// <param name="length">The length of the plane</param>
    /// <param name="resX">The horizontal resolution of the plane</param>
    /// <param name="resZ">The vertical resolution of the plane</param>
    /// <returns>The generated plane mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshPlane")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenPlane(float width, float length, int resX, int resZ);

    /// <summary>
    /// Generate cuboid mesh.
    /// </summary>
    /// <param name="width">The width of the cube</param>
    /// <param name="height">The height of the cube</param>
    /// <param name="length">The length of the cube</param>
    /// <returns>A new Mesh representing the generated cube</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshCube")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenCube(float width, float height, float length);

    /// <summary>
    /// Generate sphere mesh (standard sphere).
    /// </summary>
    /// <param name="radius">The radius of the sphere</param>
    /// <param name="rings">The number of rings that make up the sphere</param>
    /// <param name="slices">The number of slices that make up each ring of the sphere</param>
    /// <returns>The generated sphere mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshSphere")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate half-sphere mesh (no bottom cap).
    /// </summary>
    /// <param name="radius">The radius of the hemisphere</param>
    /// <param name="rings">The number of rings in the hemisphere</param>
    /// <param name="slices">The number of slices in the hemisphere</param>
    /// <returns>A hemisphere Mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshHemiSphere")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenHemiSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate cylinder mesh.
    /// </summary>
    /// <param name="radius">The radius of the cylinder</param>
    /// <param name="height">The height of the cylinder</param>
    /// <param name="slices">The number of slices to create the cylinder</param>
    /// <returns>The generated cylinder mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshCylinder")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenCylinder(float radius, float height, int slices);

    /// <summary>
    /// Generate cone/pyramid mesh.
    /// </summary>
    /// <param name="radius">The radius of the cone base</param>
    /// <param name="height">The height of the cone</param>
    /// <param name="slices">The number of radial slices for the cone</param>
    /// <returns>A Mesh object representing the generated cone</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshCone")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenCone(float radius, float height, int slices);

    /// <summary>
    /// Generate torus mesh.
    /// </summary>
    /// <param name="radius">The radius of the torus</param>
    /// <param name="size">The size of the torus</param>
    /// <param name="radSeg">The number of radial segments</param>
    /// <param name="sides">The number of sides</param>
    /// <returns>The generated torus mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshTorus")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenTorus(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate trefoil knot mesh.
    /// </summary>
    /// <param name="radius">The radius of the knot.</param>
    /// <param name="size">The size of the knot.</param>
    /// <param name="radSeg">The number of segments in the radial direction.</param>
    /// <param name="sides">The number of sides in the knot.</param>
    /// <returns>A mesh representing the generated knot.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshKnot")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenKnot(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate heightMap mesh from image data.
    /// </summary>
    /// <param name="heightmap">The heightMap image used to generate the mesh</param>
    /// <param name="size">The size of the mesh</param>
    /// <returns>The generated mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshHeightmap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenHeightmap(Image heightmap, Vector3 size);

    /// <summary>
    /// Generate cubes-based map mesh from image data.
    /// </summary>
    /// <param name="cubicmap">The image to generate the cubic map from</param>
    /// <param name="cubeSize">The size of each cube in the cubic map</param>
    /// <returns>The generated cubic map mesh</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GenMeshCubicmap")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenCubicmap(Image cubicmap, Vector3 cubeSize);
}