using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Raylib_CSharp.Marshallers;

[CustomMarshaller(typeof(string), MarshalMode.Default, typeof(NonFreeUtf8StringMarshaller))]
public static class NonFreeUtf8StringMarshaller {

    /// <summary>
    /// Converts a null-terminated UTF-8 string from the unmanaged memory to a managed string.
    /// </summary>
    /// <param name="unmanaged">A pointer to the null-terminated UTF-8 string in unmanaged memory.</param>
    /// <returns>The managed string representation of the UTF-8 string.</returns>
    public static string ConvertToManaged(nint unmanaged) {
        return Marshal.PtrToStringUTF8(unmanaged) ?? string.Empty;
    }

    /// <summary>
    /// Converts a managed string to a null-terminated UTF-8 string in unmanaged memory.
    /// </summary>
    /// <param name="managed">The managed string to be converted.</param>
    /// <returns>A pointer to the null-terminated UTF-8 string in unmanaged memory.</returns>
    public static nint ConvertToUnmanaged(string managed) {
        return Marshal.StringToCoTaskMemUTF8(managed);
    }
}