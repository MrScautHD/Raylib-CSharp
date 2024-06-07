namespace Raylib_CSharp.Rendering.Gl.Contexts;

public interface IGlContext {

    /// <summary>
    /// Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
    /// </summary>
    /// <param name="procName">The name of the exported function or variable to retrieve the address of. </param>
    /// <returns> A handle to the exported function or variable if successful; otherwise, <see cref="nint.Zero"/>. </returns>
    nint GetProcAddress(string procName);
}