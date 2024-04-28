using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Logging;

public static partial class Logger {

    public delegate bool OnMessage(TraceLogLevel logLevel, string text);
    public static event OnMessage? Message;

    private static StringFormatter? _formatter;

    /// <summary>
    /// Initializes the logger by setting the trace log callback.
    /// </summary>
    public static unsafe void Init() {
        _formatter = new StringFormatter();
        SetTraceLogCallback(&TraceLogCallback);
    }

    /// <summary>
    /// Sends a log message to the logger with the specified log level and text.
    /// </summary>
    /// <param name="logLevel">The level of the log message.</param>
    /// <param name="text">The text of the log message.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TraceLog(TraceLogLevel logLevel, string text);

    /// <summary>
    /// Sets the trace log level.
    /// </summary>
    /// <param name="logLevel">The log level to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTraceLogLevel(TraceLogLevel logLevel);

    /// <summary>
    /// Sets the trace log callback function.
    /// </summary>
    /// <param name="callback">A pointer to an unmanaged function that matches the signature of the callback function.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial void SetTraceLogCallback(delegate* unmanaged[Cdecl]<int, sbyte*, sbyte*, void> callback);

    /// <summary>
    /// Callback method that is called whenever a new log message is generated.
    /// </summary>
    /// <param name="logLevel">The level of the log message.</param>
    /// <param name="text">The log message.</param>
    /// <param name="args">Additional arguments.</param>
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static unsafe void TraceLogCallback(int logLevel, sbyte* text, sbyte* args) {
        string msg = _formatter!.GetMessage((IntPtr) text, (IntPtr) args);

        OnMessage? message = Message;

        if (message != null) {
            if (message.Invoke((TraceLogLevel) logLevel, msg)) {
                return;
            }
        }
    }
}