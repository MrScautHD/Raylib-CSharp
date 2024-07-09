using System.Runtime.InteropServices;

namespace Raylib_CSharp.Rendering.Gl.Contexts;

public class NativeGlContext : IGlContext, IDisposable {

    public bool HasDisposed { get; private set; }

    private IGlContext? _context;

    /// <summary>
    /// Represents a native OpenGL context (Use it for bindings like OpenTK...).
    /// </summary>
    public NativeGlContext() {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            this._context = new WinGlContext();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
            this._context = new LinuxGlContext();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
            this._context = new MacOsGlContext();
        }
        else {
            throw new Exception("Platform is not supported!");
        }
    }

    public nint GetProcAddress(string procName) {
        if (this._context != null) {
            return this._context!.GetProcAddress(procName);
        } else {
            throw new Exception("Platform is not supported!");
        }
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
    protected virtual void Dispose(bool disposing) {
        if (disposing) {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                ((WinGlContext) this._context!)?.Dispose();
            }
        }
    }
}