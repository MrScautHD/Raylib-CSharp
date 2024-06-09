using Raylib_CSharp.OpenGL.Contexts;
using Raylib_CSharp.Rendering.Gl.Contexts;

namespace Raylib_CSharp.Test;

public class NativeBindingsContext : IDisposable, IBindingsContext {

    private NativeGlContext _context;

    public bool HasDisposed { get; private set; }

    /// <summary>
    /// Represents a context for native bindings in OpenGL.
    /// </summary>
    public NativeBindingsContext() {
        this._context = new NativeGlContext();
    }

    public nint GetProcAddress(string procName) {
        return this._context.GetProcAddress(procName);
    }

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
    /// Releases the managed resources used by the object (disposing), and optionally releases the unmanaged.
    /// resources (not disposing).
    /// </summary>
    /// <param name="disposing">A boolean value indicating whether the method is being called from, dispose method directly (true) or from the finalizer (false).</param>
    protected void Dispose(bool disposing) {
        if (disposing) {
            this._context.Dispose();
        }
    }
}