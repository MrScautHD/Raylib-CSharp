using System.Runtime.InteropServices.Marshalling;

namespace Raylib_CSharp.CSharp.Marshallers;

[CustomMarshaller(typeof(string), MarshalMode.Default, typeof(NonFreeUtf8StringMarshaller))]
public static class NonFreeUtf8StringMarshaller {
    
    /// <summary>
    /// Converts a null-terminated UTF-8 string from the unmanaged memory to a managed string.
    /// </summary>
    /// <param name="unmanaged">A pointer to the null-terminated UTF-8 string in unmanaged memory.</param>
    /// <returns>The managed string representation of the UTF-8 string.</returns>
    public static unsafe string? ConvertToManaged(byte* unmanaged) {
        return Utf8StringMarshaller.ConvertToManaged(unmanaged);
    }
}