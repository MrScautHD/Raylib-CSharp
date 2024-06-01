using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Logging;

public static class Logger {

    public delegate bool OnMessage(TraceLogLevel logLevel, string text);
    public static event OnMessage? Message;

    private static StringFormatter? _formatter;

    /// <summary>
    /// Initializes the logger by setting the trace log callback.
    /// </summary>
    public static unsafe void Init() {
        _formatter = new StringFormatter();
        RaylibApi.SetTraceLogCallback(&TraceLogCallback);
    }

    /// <inheritdoc cref="RaylibApi.TraceLog" />
    public static void TraceLog(TraceLogLevel logLevel, string text) {
        RaylibApi.TraceLog(logLevel, text);
    }

    /// <inheritdoc cref="RaylibApi.SetTraceLogLevel" />
    public static void SetTraceLogLevel(TraceLogLevel logLevel) {
        RaylibApi.SetTraceLogLevel(logLevel);
    }

    /// <summary>
    /// Callback method that is called whenever a new log message is generated.
    /// </summary>
    /// <param name="logLevel">The level of the log message.</param>
    /// <param name="text">The log message.</param>
    /// <param name="args">Additional arguments.</param>
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void TraceLogCallback(int logLevel, nint text, nint args) {
        string msg = _formatter!.GetMessage(text, args);

        OnMessage? message = Message;

        if (message != null) {
            if (message.Invoke((TraceLogLevel) logLevel, msg)) {
                return;
            }
        }
    }

    /// <summary>
    /// Destroys the logger (sets the trace log callback to null).
    /// </summary>
    public static unsafe void Destroy() {
        Message = null;
        RaylibApi.SetTraceLogCallback(null);
    }
}