namespace Raylib_CSharp.OpenGL.Contexts;

public interface IBindingsContext {

    /// <summary>
    /// Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
    /// </summary>
    /// <param name="procName">The name of the exported function or variable.</param>
    /// <returns>The address of the exported function or variable.</returns>
    nint GetProcAddress(string procName);
}