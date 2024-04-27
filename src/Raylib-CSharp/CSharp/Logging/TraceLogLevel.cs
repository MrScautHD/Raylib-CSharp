namespace Raylib_CSharp.CSharp.Logging;

public enum TraceLogLevel {
    
    /// <summary>
    /// Display all logs.
    /// </summary>
    All = 0,

    /// <summary>
    /// Trace logging, intended for internal use only.
    /// </summary>
    Trace,

    /// <summary>
    /// Debug logging, used for internal debugging, it should be disabled on release builds.
    /// </summary>
    Debug,

    /// <summary>
    /// Info logging, used for program execution info.
    /// </summary>
    Info,

    /// <summary>
    /// Warning logging, used on recoverable failures.
    /// </summary>
    Warning,

    /// <summary>
    /// Error logging, used on unrecoverable failures.
    /// </summary>
    Error,

    /// <summary>
    /// Fatal logging, used to abort program: exit(EXIT_FAILURE).
    /// </summary>
    Fatal,

    /// <summary>
    /// Disable logging.
    /// </summary>
    None
}