using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Collision;
using Raylib_CSharp.CSharp.Images;
using Raylib_CSharp.CSharp.Materials;

namespace Raylib_CSharp.CSharp.Geometry.Managers;

public static partial class MeshManager {

    /// <summary>
    /// Upload mesh vertex data in GPU and provide VAO/VBO ids.
    /// </summary>
    /// <param name="mesh">The mesh data to upload</param>
    /// <param name="dynamic">Determines if the mesh data should be uploaded as dynamic or static</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UploadMesh(ref Mesh mesh, [MarshalAs(UnmanagedType.Bool)] bool dynamic);

    /// <summary>
    /// Update mesh vertex data in GPU for a specific buffer index.
    /// </summary>
    /// <param name="mesh">The mesh to update</param>
    /// <param name="index">The index of the buffer to update</param>
    /// <param name="data">A pointer to the new vertex data</param>
    /// <param name="dataSize">The size of the new data in bytes</param>
    /// <param name="offset">Offset in bytes to offset the mesh data</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateMeshBuffer(Mesh mesh, int index, void* data, int dataSize, int offset);

    /// <summary>
    /// Unload mesh data from CPU and GPU.
    /// </summary>
    /// <param name="mesh">The mesh data to unload</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMesh(Mesh mesh);

    /// <summary>
    /// Draw a 3d mesh with material and transform.
    /// </summary>
    /// <param name="mesh">The mesh to draw</param>
    /// <param name="material">The material to use for rendering</param>
    /// <param name="transform">The transformation matrix to apply to the mesh</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawMesh(Mesh mesh, Material material, Matrix4x4 transform);

    /// <summary>
    /// Draw multiple mesh instances with material and different transforms.
    /// </summary>
    /// <param name="mesh">The mesh to be drawn.</param>
    /// <param name="material">The material to be applied to the mesh.</param>
    /// <param name="transforms">An array of transform matrices for each instance.</param>
    /// <param name="instances">The number of instances to be drawn.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawMeshInstanced(Mesh mesh, Material material, Matrix4x4* transforms, int instances);

    /// <summary>
    /// Export mesh data to file, returns true on success.
    /// </summary>
    /// <param name="mesh">The mesh data to export.</param>
    /// <param name="fileName">The name of the file to export the mesh to.</param>
    /// <returns>Returns true if the export was successful, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ExportMesh(Mesh mesh, string fileName);

    /// <summary>
    /// Compute mesh bounding box limits.
    /// </summary>
    /// <param name="mesh">The mesh to get the bounding box from</param>
    /// <returns>The bounding box of the mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetMeshBoundingBox(Mesh mesh);

    /// <summary>
    /// Compute mesh tangents.
    /// </summary>
    /// <param name="mesh">The mesh to generate tangents for</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GenMeshTangents(ref Mesh mesh);

    /// <summary>
    /// Generate polygonal mesh.
    /// </summary>
    /// <param name="sides">The number of sides of the polygon</param>
    /// <param name="radius">The radius of the polygon</param>
    /// <returns>The generated Mesh object</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshPoly(int sides, float radius);

    /// <summary>
    /// Generate plane mesh (with subdivisions).
    /// </summary>
    /// <param name="width">The width of the plane</param>
    /// <param name="length">The length of the plane</param>
    /// <param name="resX">The horizontal resolution of the plane</param>
    /// <param name="resZ">The vertical resolution of the plane</param>
    /// <returns>The generated plane mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshPlane(float width, float length, int resX, int resZ);

    /// <summary>
    /// Generate cuboid mesh.
    /// </summary>
    /// <param name="width">The width of the cube</param>
    /// <param name="height">The height of the cube</param>
    /// <param name="length">The length of the cube</param>
    /// <returns>A new Mesh representing the generated cube</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCube(float width, float height, float length);

    /// <summary>
    /// Generate sphere mesh (standard sphere).
    /// </summary>
    /// <param name="radius">The radius of the sphere</param>
    /// <param name="rings">The number of rings that make up the sphere</param>
    /// <param name="slices">The number of slices that make up each ring of the sphere</param>
    /// <returns>The generated sphere mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate half-sphere mesh (no bottom cap).
    /// </summary>
    /// <param name="radius">The radius of the hemisphere</param>
    /// <param name="rings">The number of rings in the hemisphere</param>
    /// <param name="slices">The number of slices in the hemisphere</param>
    /// <returns>A hemisphere Mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshHemiSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate cylinder mesh.
    /// </summary>
    /// <param name="radius">The radius of the cylinder</param>
    /// <param name="height">The height of the cylinder</param>
    /// <param name="slices">The number of slices to create the cylinder</param>
    /// <returns>The generated cylinder mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCylinder(float radius, float height, int slices);

    /// <summary>
    /// Generate cone/pyramid mesh.
    /// </summary>
    /// <param name="radius">The radius of the cone base</param>
    /// <param name="height">The height of the cone</param>
    /// <param name="slices">The number of radial slices for the cone</param>
    /// <returns>A Mesh object representing the generated cone</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCone(float radius, float height, int slices);

    /// <summary>
    /// Generate torus mesh.
    /// </summary>
    /// <param name="radius">The radius of the torus</param>
    /// <param name="size">The size of the torus</param>
    /// <param name="radSeg">The number of radial segments</param>
    /// <param name="sides">The number of sides</param>
    /// <returns>The generated torus mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshTorus(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate trefoil knot mesh.
    /// </summary>
    /// <param name="radius">The radius of the knot.</param>
    /// <param name="size">The size of the knot.</param>
    /// <param name="radSeg">The number of segments in the radial direction.</param>
    /// <param name="sides">The number of sides in the knot.</param>
    /// <returns>A mesh representing the generated knot.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshKnot(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate heightMap mesh from image data.
    /// </summary>
    /// <param name="heightmap">The heightMap image used to generate the mesh</param>
    /// <param name="size">The size of the mesh</param>
    /// <returns>The generated mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshHeightmap(Image heightmap, Vector3 size);

    /// <summary>
    /// Generate cubes-based map mesh from image data.
    /// </summary>
    /// <param name="cubicmap">The image to generate the cubic map from</param>
    /// <param name="cubeSize">The size of each cube in the cubic map</param>
    /// <returns>The generated cubic map mesh</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCubicmap(Image cubicmap, Vector3 cubeSize);
}