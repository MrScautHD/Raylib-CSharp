using System.Runtime.InteropServices;

namespace Raylib_CSharp.Rendering.Gl;

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
    public unsafe VertexBuffer* VertexBufferPtr;

    /// <inheritdoc cref="VertexBufferPtr" />
    public unsafe Span<VertexBuffer> VertexBuffer => new(this.VertexBufferPtr, this.BufferCount);

    /// <summary>
    /// Draw calls array, depends on textureId.
    /// </summary>
    public unsafe DrawCall* DrawsPtr;

    /// <inheritdoc cref="DrawsPtr" />
    public unsafe Span<DrawCall> Draws => new(this.DrawsPtr, this.DrawCounter);

    /// <summary>
    /// Draw calls counter.
    /// </summary>
    public int DrawCounter;

    /// <summary>
    /// Current depth value for next draw.
    /// </summary>
    public float CurrentDepth;
}