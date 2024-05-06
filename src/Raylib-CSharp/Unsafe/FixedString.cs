using System.Runtime.InteropServices;
using Raylib_CSharp.Unsafe.Marshallers;

namespace Raylib_CSharp.Unsafe;

public static class FixedString {

    /// <summary>
    /// Returns the value of a fixed-length string stored in unmanaged memory.
    /// </summary>
    /// <param name="src">A pointer to the fixed-length string in unmanaged memory.</param>
    /// <returns>The value of the fixed-length string.</returns>
    public static unsafe string GetValue(sbyte* src) {
        return NonFreeUtf8StringMarshaller.ConvertToManaged((IntPtr) src);
    }

    /// <summary>
    /// Sets the value of a fixed-length string stored in unmanaged memory.
    /// </summary>
    /// <param name="dst">A pointer to the fixed-length string in unmanaged memory where the value will be set.</param>
    /// <param name="dstLength">The maximum length of the fixed-length string.</param>
    /// <param name="src">The string value to be set in the fixed-length string.</param>
    public static unsafe void SetValue(sbyte* dst, int dstLength, string? src) {
        sbyte* unmanagedValue = (sbyte*) NonFreeUtf8StringMarshaller.ConvertToUnmanaged(src!);

        Buffer.MemoryCopy(unmanagedValue, dst, dstLength, Math.Min(dstLength + 1, src?.Length ?? 0));

        if (src == null) {
            dst[0] = 0;
        }

        Marshal.FreeCoTaskMem((nint) unmanagedValue);
    }
}