using System.Runtime.InteropServices;

namespace Raylib_CSharp.Rendering.Gl.Contexts;

public partial class LinuxGlContext : IGlContext {

    private const string libGL = "libGL.so";
    private const string libGL0 = "libGL.so.0";
    private const string libGL1 = "libGL.so.1";

    private delegate nint ProcAddressDelegate(string procName);

    private ProcAddressDelegate[] _procAddresses;

    /// <summary>
    /// Represents a Linux binding context. </summary>
    ///
    public LinuxGlContext() {
        this._procAddresses = new ProcAddressDelegate[3];
        this._procAddresses[0] = GetXProcAddress;
        this._procAddresses[1] = GetXProcAddress0;
        this._procAddresses[2] = GetXProcAddress1;
    }

    public nint GetProcAddress(string procName) {
        nint address = nint.Zero;

        foreach (ProcAddressDelegate procAddressDelegate in this._procAddresses) {
            try {
                address = procAddressDelegate(procName);

                if (address != nint.Zero) {
                    break;
                }
            }
            catch (Exception) {
                // Continue to the next delegate method
            }
        }

        if (address == nint.Zero) {
            throw new Exception("Failed to retrieve the Procedure Address.");
        }

        return address;
    }

    /// <summary>
    /// Retrieves the address of an OpenGL extension function.
    /// </summary>
    /// <param name="procName">The name of the OpenGL extension function to retrieve.</param>
    /// <returns> A pointer to the address of the extension function if successful; otherwise, returns NULL.</returns>
    [LibraryImport(libGL, EntryPoint = "glXGetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint GetXProcAddress(string procName);

    /// <summary>
    /// Retrieves the address of an OpenGL extension function.
    /// </summary>
    /// <param name="procName">The name of the OpenGL extension function to retrieve.</param>
    /// <returns> A pointer to the address of the extension function if successful; otherwise, returns NULL.</returns>
    [LibraryImport(libGL0, EntryPoint = "glXGetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint GetXProcAddress0(string procName);

    /// <summary>
    /// Retrieves the address of an OpenGL extension function.
    /// </summary>
    /// <param name="procName">The name of the OpenGL extension function to retrieve.</param>
    /// <returns> A pointer to the address of the extension function if successful; otherwise, returns NULL.</returns>
    [LibraryImport(libGL1, EntryPoint = "glXGetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint GetXProcAddress1(string procName);
}
