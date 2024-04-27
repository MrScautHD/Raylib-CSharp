using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Rendering.Gl;

[StructLayout(LayoutKind.Sequential)]
public struct VertexBuffer {
    
    /// <summary>
    /// Number of elements in the buffer (QUADS).
    /// </summary>
    public int ElementCount;

    /// <summary>
    /// Vertex position (XYZ - 3 components per vertex) (shader-location = 0).
    /// </summary>
    public unsafe float* Vertices;

    /// <summary>
    /// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1).
    /// </summary>
    public unsafe float* TexCoords;

    /// <summary>
    /// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3).
    /// </summary>
    public unsafe byte* Colors;

    /// <summary>
    /// Vertex indices (in case vertex data comes indexed) (6 indices per quad).
    /// </summary>
    public unsafe void* Indices;

    /// <summary>
    /// OpenGL Vertex Array Object id.
    /// </summary>
    public uint VaoId;

    /// <summary>
    /// OpenGL Vertex Buffer Objects id (5 types of vertex data).
    /// </summary>
    public unsafe fixed uint VboId[4];
}