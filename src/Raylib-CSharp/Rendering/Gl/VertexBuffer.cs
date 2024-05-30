using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Colors;

namespace Raylib_CSharp.Rendering.Gl;

[StructLayout(LayoutKind.Sequential)]
public struct VertexBuffer {

    /// <summary>
    /// Number of elements in the buffer (QUADS).
    /// </summary>
    public int ElementCount;

    /// <summary>
    /// Vertex position (XYZ - 3 components per vertex) (shader-location = 0).
    /// </summary>
    public unsafe float* VerticesPtr;

    /// <inheritdoc cref="VerticesPtr" />
    public unsafe Span<Vector3> Vertices => new(this.VerticesPtr, this.ElementCount * 4);

    /// <summary>
    /// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1).
    /// </summary>
    public unsafe float* TexCoordsPtr;

    /// <inheritdoc cref="TexCoordsPtr" />
    public unsafe Span<Vector2> TexCoords => new(this.TexCoordsPtr, this.ElementCount * 4);

    /// <summary>
    /// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3).
    /// </summary>
    public unsafe byte* ColorsPtr;

    /// <inheritdoc cref="ColorsPtr" />
    public unsafe Span<Color> Colors => new(this.ColorsPtr, this.ElementCount * 4);

    /// <summary>
    /// Vertex indices (in case vertex data comes indexed) (6 indices per quad).
    /// </summary>
    public unsafe uint* IndicesPtr;

    /// <inheritdoc cref="IndicesPtr" />
    public unsafe Span<uint> Indices => new(this.IndicesPtr, this.ElementCount * 6);

    /// <summary>
    /// OpenGL Vertex Array Object id.
    /// </summary>
    public uint VaoId;

    /// <summary>
    /// OpenGL Vertex Buffer Objects id (5 types of vertex data).
    /// </summary>
    public unsafe fixed uint VboIdPtr[4];

    /// <inheritdoc cref="VboId" />
    public unsafe Span<uint> VboId {
        get {
            fixed (uint* idPtr = this.VboIdPtr) {
                return new(idPtr, 4);
            }
        }
    }
}