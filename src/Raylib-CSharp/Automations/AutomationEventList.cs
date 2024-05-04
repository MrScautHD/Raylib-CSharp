using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Automations;

[StructLayout(LayoutKind.Sequential)]
public partial struct AutomationEventList {

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
    public unsafe Span<AutomationEvent> Events => new(this.EventsPtr, (int) this.Capacity);

    public unsafe AutomationEvent* EventsPtr;

    /// <summary>
    /// Load automation events list from file, NULL for empty list, capacity = MAX_AUTOMATION_EVENTS.
    /// </summary>
    /// <param name="fileName">The name of the file to load the AutomationEventList from.</param>
    /// <returns>The loaded AutomationEventList.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadAutomationEventList", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial AutomationEventList Load(string fileName);

    /// <summary>
    /// Unload automation events list from file.
    /// </summary>
    /// <param name="list">The AutomationEventList to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadAutomationEventList")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Unload(ref AutomationEventList list);

    /// <summary>
    /// Export automation events list as text file.
    /// </summary>
    /// <param name="list">The AutomationEventList to export.</param>
    /// <param name="fileName">The name of the file to export the AutomationEventList to.</param>
    /// <returns>Returns true if the export was successful; otherwise, returns false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportAutomationEventList", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool Export(AutomationEventList list, string fileName);

    /// <summary>
    /// Set automation event list to record to.
    /// </summary>
    /// <param name="list">The AutomationEventList to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetAutomationEventList")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Set(ref AutomationEventList list);
}