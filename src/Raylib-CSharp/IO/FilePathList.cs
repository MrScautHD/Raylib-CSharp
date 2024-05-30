using System.Runtime.InteropServices;
using Raylib_CSharp.Unsafe.Spans.Custom;

namespace Raylib_CSharp.IO;

[StructLayout(LayoutKind.Sequential)]
public struct FilePathList {

    /// <summary>
    /// FilePaths max entries.
    /// </summary>
    public uint Capacity;

    /// <summary>
    /// FilePaths entries count.
    /// </summary>
    public uint Count;

    /// <summary>
    /// FilePaths entries.
    /// </summary>
    public unsafe sbyte** PathsPtr;

    /// <inheritdoc cref="PathsPtr" />
    public unsafe StringArraySpan Paths => new(this.PathsPtr, (int) this.Count);
}