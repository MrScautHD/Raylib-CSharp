using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Rendering.Gl;

[StructLayout(LayoutKind.Sequential)]
public struct RenderBatch {

    /// <summary>
    /// Number of vertex buffers (multi-buffering support).
    /// </summary>
    public int BufferCount;

    /// <summary>
    /// Current buffer tracking in case of multi-buffering.
    /// </summary>
    public int CurrentBuffer;

    /// <summary>
    /// Dynamic buffer(s) for vertex data.
    /// </summary>
    public unsafe VertexBuffer* VertexBuffer;

    /// <summary>
    /// Draw calls array, depends on textureId.
    /// </summary>
    public unsafe DrawCall* Draws;

    /// <summary>
    /// Draw calls counter.
    /// </summary>
    public int DrawCounter;

    /// <summary>
    /// Current depth value for next draw.
    /// </summary>
    public float CurrentDepth;
}