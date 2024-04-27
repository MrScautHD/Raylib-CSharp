using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Rendering;

public partial class Graphics {
    
    /// <summary>
    /// Swap back buffer with front buffer (screen drawing).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "SwapScreenBuffer")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SwapScreenBuffer();
    
     //TODO DONE IT
}