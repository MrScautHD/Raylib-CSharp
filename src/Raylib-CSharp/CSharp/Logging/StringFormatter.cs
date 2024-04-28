using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Logging;

public class StringFormatter {

    private const string Msvcrt = "msvcrt";
    private const string Libc = "libc";
    private const string LibSystem = "libSystem";

    /// <summary>
    /// Formats a message string using the specified format and arguments on Windows platform.
    /// </summary>
    /// <param name="buffer">Pointer to the buffer to write the formatted string.</param>
    /// <param name="format">Pointer to the format string.</param>
    /// <param name="args">Pointer to the arguments.</param>
    /// <returns>The number of characters written to the buffer.</returns>
    [DllImport(Msvcrt, EntryPoint = "vsprintf", CallingConvention = CallingConvention.Cdecl)]
    private static extern int VsPrintFWindows(IntPtr buffer, IntPtr format, IntPtr args);

    /// <summary>
    /// Formats a message string using the specified format and arguments on Windows platform.
    /// </summary>
    /// <param name="buffer">Pointer to the buffer to write the formatted string.</param>
    /// <param name="size">Size of the buffer.</param>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    [DllImport(Msvcrt, EntryPoint = "vsnprintf", CallingConvention = CallingConvention.Cdecl)]
    private static extern int VsnPrintFWindows(IntPtr buffer, UIntPtr size, IntPtr format, IntPtr args);

    /// <summary>
    /// Formats a message string using the specified format and arguments on Linux platform.
    /// </summary>
    /// <param name="buffer">Pointer to the buffer to write the formatted string.</param>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    [DllImport(Libc, EntryPoint = "vsprintf", CallingConvention = CallingConvention.Cdecl)]
    private static extern int VsPrintFLinux(IntPtr buffer, IntPtr format, IntPtr args);

    /// <summary>
    /// Formats a message string using the specified format and arguments on Linux platform.
    /// </summary>
    /// <param name="buffer">A pointer to a buffer to store the formatted message.</param>
    /// <param name="size">The size of the buffer.</param>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The number of characters written to the buffer (excluding the null terminator) if the formatting succeeds;
    /// otherwise, returns a negative value to indicate an error occurred.
    /// </returns>
    [DllImport(Libc, EntryPoint = "vsnprintf", CallingConvention = CallingConvention.Cdecl)]
    private static extern int VsnPrintFLinux(IntPtr buffer, UIntPtr size, IntPtr format, IntPtr args);

    /// <summary>
    /// Formats a message string using the specified format and arguments on macOS platform.
    /// </summary>
    /// <param name="buffer">Pointer to the buffer to write the formatted string.</param>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    [DllImport(LibSystem, EntryPoint = "vasprintf", CallingConvention = CallingConvention.Cdecl)]
    private static extern unsafe int VasPrintFOsx(IntPtr* buffer, IntPtr format, IntPtr args);

    /// <summary>
    /// Retrieves a formatted message string using the specified format and arguments based on the current platform.
    /// </summary>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    public string GetMessage(IntPtr format, IntPtr args) {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            return this.WindowsPrintF(format, args);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
            if (IntPtr.Size == 8) {
                return this.Linux64PrintF(format, args);
            }
            else {
                return this.Linux86PrintF(format, args);
            }
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
            return this.OsxPrintF(format, args);
        }
        else {
            return "This Platform is not supported!";
        }
    }

    /// <summary>
    /// Formats a message string using the specified format and arguments on Windows platform.
    /// </summary>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    private string WindowsPrintF(IntPtr format, IntPtr args) {
        IntPtr utf8Buffer = IntPtr.Zero;

        try {
            int byteSize = VsnPrintFWindows(IntPtr.Zero, UIntPtr.Zero, format, args) + 1;

            if (byteSize <= 1) {
                return string.Empty;
            }

            utf8Buffer = Marshal.AllocHGlobal(byteSize);
            VsPrintFWindows(utf8Buffer, format, args);

            return Marshal.PtrToStringUTF8(utf8Buffer)!;
        }
        finally {
            Marshal.FreeHGlobal(utf8Buffer);
        }
    }

    /// <summary>
    /// Formats a message string using the specified format and arguments on macOS platform.
    /// </summary>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    private unsafe string OsxPrintF(IntPtr format, IntPtr args) {
        IntPtr utf8Buffer = IntPtr.Zero;

        try {
            int count = VasPrintFOsx(&utf8Buffer, format, args);

            if (count == -1) {
                return string.Empty;
            }

            return Marshal.PtrToStringUTF8(utf8Buffer) ?? string.Empty;
        }
        finally {
            Marshal.FreeHGlobal(utf8Buffer);
        }
    }

    /// <summary>
    /// Formats a message string using the specified format and arguments on Linux 64-bit platform.
    /// </summary>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    private string Linux64PrintF(IntPtr format, IntPtr args) {
        IntPtr listPointer = IntPtr.Zero;
        IntPtr utf8Buffer = IntPtr.Zero;

        try {
            VaListLinux64 str = Marshal.PtrToStructure<VaListLinux64>(args);

            // Get size of args.
            listPointer = Marshal.AllocHGlobal(Marshal.SizeOf(str));
            Marshal.StructureToPtr(str, listPointer, false);
            int byteSize = VsnPrintFLinux(IntPtr.Zero, UIntPtr.Zero, format, listPointer) + 1;

            // Allocate buffer.
            Marshal.StructureToPtr(str, listPointer, false);
            utf8Buffer = Marshal.AllocHGlobal(byteSize);

            // Print result into buffer.
            VsPrintFLinux(utf8Buffer, format, listPointer);
            return Marshal.PtrToStringUTF8(utf8Buffer)!;
        }
        finally {
            Marshal.FreeHGlobal(listPointer);
            Marshal.FreeHGlobal(utf8Buffer);
        }
    }

    /// <summary>
    /// Formats a message string using the specified format and arguments on Linux platform.
    /// </summary>
    /// <param name="format">A pointer to a null-terminated string that specifies the format of the output.</param>
    /// <param name="args">A pointer to a list of arguments.</param>
    /// <returns>
    /// The formatted message as a string. If the formatting fails, returns an empty string.
    /// </returns>
    private string Linux86PrintF(IntPtr format, IntPtr args) {
        IntPtr utf8Buffer = IntPtr.Zero;

        try {
            int byteSize = VsnPrintFLinux(IntPtr.Zero, UIntPtr.Zero, format, args) + 1;

            if (byteSize <= 1) {
                return string.Empty;
            }

            utf8Buffer = Marshal.AllocHGlobal(byteSize);
            VsPrintFLinux(utf8Buffer, format, args);

            return Marshal.PtrToStringUTF8(utf8Buffer)!;
        }
        finally {
            Marshal.FreeHGlobal(utf8Buffer);
        }
    }

    /// <summary>
    /// Represents a structure for handling variadic arguments on the Linux 64-bit platform.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    private struct VaListLinux64 {
        private uint _gpOffset;
        private uint _fpOffset;
        private IntPtr _overflowArgsArea;
        private IntPtr _regSaveArea;
    }
}