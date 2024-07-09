using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Rendering.Gl.Contexts;

public partial class MacOsGlContext : IGlContext {

    private const string OpenGL = "/System/Library/Frameworks/OpenGL.framework/OpenGL";

    /// <summary>
    /// Retrieves the address of an OpenGL extension function.
    /// </summary>
    /// <param name="procName">The name of the extension function.</param>
    /// <returns> A pointer to the extension function if found; otherwise, <see cref="nint.Zero"/>.</returns>
    [LibraryImport(OpenGL, EntryPoint = "NSLookupAndBindSymbol", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial nint NSLookupAndBindSymbol(string procName);

    public nint GetProcAddress(string procName) {
        nint address = NSLookupAndBindSymbol($"_{procName}");

        if (address == nint.Zero) {
            throw new Exception("Failed to retrieve the Procedure Address.");
        }

        return address;
    }
}