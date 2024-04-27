using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Interact;

public static partial class Input {

    /// <summary>
    /// Register all input events.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PollInputEvents();
}