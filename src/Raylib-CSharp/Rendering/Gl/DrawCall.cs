using System.Runtime.InteropServices;

namespace Raylib_CSharp.Rendering.Gl;

[StructLayout(LayoutKind.Sequential)]
public struct DrawCall {

    /// <summary>
    /// Drawing mode: LINES, TRIANGLES, QUADS.
    /// </summary>
    public DrawMode Mode;

    /// <summary>
    /// Number of vertex of the draw.
    /// </summary>
    public int VertexCount;

    /// <summary>
    /// Number of vertex required for index alignment (LINES, TRIANGLES).
    /// </summary>
    public int VertexAlignment;

    /// <summary>
    /// Texture id to be used on the draw -> Use to create new draw call if changes.
    /// </summary>
    public uint TextureId;
}