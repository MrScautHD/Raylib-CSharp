using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Automations;

[StructLayout(LayoutKind.Sequential)]
public struct AutomationEventList {

    /// <summary>
    /// Events max entries (MAX_AUTOMATION_EVENTS).
    /// </summary>
    public uint Capacity;

    /// <summary>
    /// Events entries count.
    /// </summary>
    public uint Count;

    /// <summary>
    /// Events entries.
    /// </summary>
    public unsafe AutomationEvent* EventsPtr;

    /// <inheritdoc cref="EventsPtr" />
    public unsafe Span<AutomationEvent> Events => new(this.EventsPtr, (int)this.Capacity);

    /// <inheritdoc cref="RaylibApi.LoadAutomationEventList" />
    public static AutomationEventList Load(string fileName) {
        return RaylibApi.LoadAutomationEventList(fileName);
    }

    /// <inheritdoc cref="RaylibApi.UnloadAutomationEventList" />
    public void Unload() {
        RaylibApi.UnloadAutomationEventList(this);
    }

    /// <inheritdoc cref="RaylibApi.ExportAutomationEventList" />
    public bool Export(string fileName) {
        return RaylibApi.ExportAutomationEventList(this, fileName);
    }

    /// <inheritdoc cref="RaylibApi.SetAutomationEventList" />
    public void Set() {
        RaylibApi.SetAutomationEventList(ref this);
    }
}