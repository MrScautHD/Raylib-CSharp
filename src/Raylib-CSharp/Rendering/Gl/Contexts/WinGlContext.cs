using System.Runtime.InteropServices;

namespace Raylib_CSharp.Rendering.Gl.Contexts;

public partial class WinGlContext : IGlContext {

    private const string OpenGL32 = "opengl32";
    private const string Kernel32 = "kernel32";

    public bool HasDisposed { get; private set; }

    private nint _glHandle;

    /// <summary>
    /// Represents a context for managing WGL bindings.
    /// </summary>
    public WinGlContext() {
        this._glHandle = LoadLibrary(OpenGL32);
    }

    public nint GetProcAddress(string procName) {
        nint wglAddress = GetWGLProcAddress(procName);

        if (wglAddress == nint.Zero) {
            nint procAddress = GetProcAddress(this._glHandle, procName);

            if (procAddress == nint.Zero) {
                throw new Exception("Failed to retrieve the Procedure Address.");
            }

            return procAddress;
        }

        return wglAddress;
    }

    /// <summary>
    /// Retrieves the address of an OpenGL extension function.
    /// </summary>
    /// <param name="procName">The name of the extension function.</param>
    /// <returns> A pointer to the extension function if successful; otherwise, <see cref="nint.Zero"/>.</returns>
    [LibraryImport(OpenGL32, EntryPoint = "wglGetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint GetWGLProcAddress(string procName);

    /// <summary>
    /// Loads the specified dynamic-link library (DLL) into the address space of the calling process.
    /// </summary>
    /// <param name="fileName">The name of the DLL to be loaded.</param>
    /// <returns>
    /// If the function succeeds, the return value is a handle to the loaded module.
    /// If the function fails, the return value is <see cref="nint.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
    /// </returns>
    [LibraryImport(Kernel32, EntryPoint = "LoadLibraryA", SetLastError = true, StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string fileName);

    /// <summary>
    /// Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
    /// </summary>
    /// <param name="module">A handle to the DLL module that contains the function or variable.</param>
    /// <param name="procName">The name of the function or variable.</param>
    /// <returns>
    /// If the function succeeds, the return value is the address of the exported function or variable.
    /// If the function fails, the return value is <see cref="nint.Zero"/>.
    /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
    /// </returns>
    [LibraryImport(Kernel32, EntryPoint = "GetProcAddress", SetLastError = true, StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint GetProcAddress(nint module, string procName);

    /// <summary>
    /// Frees the loaded dynamic-link library (DLL) module.
    /// </summary>
    /// <param name="module">A handle to the loaded DLL module obtained from the LoadLibrary or LoadLibraryEx function.</param>
    /// <returns>
    /// If the function succeeds, the return value is true.
    /// If the function fails, the return value is false.
    /// </returns>
    [LibraryImport(Kernel32, EntryPoint = "FreeLibrary", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool FreeLibrary(nint module);

    /// <summary>
    /// Disposes of the object, allowing for proper resource cleanup and finalization.
    /// </summary>
    public void Dispose() {
        if (this.HasDisposed) return;

        this.Dispose(true);
        GC.SuppressFinalize(this);
        this.HasDisposed = true;
    }

    /// <summary>
    /// Releases the managed resources used by the object (disposing), and optionally releases the unmanaged
    /// resources (not disposing).
    /// </summary>
    /// <param name="disposing">A boolean value indicating whether the method is being called from, dispose method directly (true) or from the finalizer (false).</param>
    protected virtual void Dispose(bool disposing) {
        if (disposing) {
            FreeLibrary(this._glHandle);
        }
    }
}