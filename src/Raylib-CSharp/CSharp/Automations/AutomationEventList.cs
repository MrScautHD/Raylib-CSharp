using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Automations;

[StructLayout(LayoutKind.Sequential)]
public struct AutomationEventList {

    /// <summary>
    /// Events max entries (MAX_AUTOMATION_EVENTS).
    /// </summary>
    public int Capacity;

    /// <summary>
    /// Events entries count.
    /// </summary>
    public int Count;

    /// <summary>
    /// Events entries.
    /// </summary>
    public unsafe AutomationEvent* Events;
}