using System.Runtime.InteropServices;

namespace Raylib_CSharp.Automations;

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
    public unsafe Span<int> Params {
        get {
            fixed (int* paramsPtr = this.ParamsPtr) {
                return new(paramsPtr, 4);
            }
        }
    }

    public unsafe fixed int ParamsPtr[4];
}