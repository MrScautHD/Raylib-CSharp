using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Automations;

[StructLayout(LayoutKind.Sequential)]
public struct AutomationEvent {

    /// <summary>
    /// Event frame.
    /// </summary>
    public int Frame;

    /// <summary>
    /// Event type (AutomationEventType).
    /// </summary>
    public AutomationEventType Type;

    /// <summary>
    /// Event parameters (if required).
    /// </summary>
    public unsafe fixed int Params[4];
}