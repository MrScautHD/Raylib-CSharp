using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.IO;

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
    public unsafe byte** Paths;
}