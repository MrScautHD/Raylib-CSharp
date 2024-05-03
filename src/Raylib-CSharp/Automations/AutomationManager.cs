using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Automations;

public static partial class AutomationManager {

    /// <summary>
    /// Load automation events list from file, NULL for empty list, capacity = MAX_AUTOMATION_EVENTS.
    /// </summary>
    /// <param name="fileName">The name of the file to load the AutomationEventList from.</param>
    /// <returns>The loaded AutomationEventList.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial AutomationEventList LoadAutomationEventList(string fileName);

    /// <summary>
    /// Unload automation events list from file.
    /// </summary>
    /// <param name="list">The AutomationEventList to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadAutomationEventList(ref AutomationEventList list);

    /// <summary>
    /// Export automation events list as text file.
    /// </summary>
    /// <param name="list">The AutomationEventList to export.</param>
    /// <param name="fileName">The name of the file to export the AutomationEventList to.</param>
    /// <returns>Returns true if the export was successful; otherwise, returns false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ExportAutomationEventList(AutomationEventList list, string fileName);

    /// <summary>
    /// Set automation event list to record to.
    /// </summary>
    /// <param name="list">The AutomationEventList to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAutomationEventList(ref AutomationEventList list);

    /// <summary>
    /// Set automation event internal base frame to start recording.
    /// </summary>
    /// <param name="frame">The base frame to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAutomationEventBaseFrame(int frame);

    /// <summary>
    /// Start recording automation events (AutomationEventList must be set).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StartAutomationEventRecording();

    /// <summary>
    /// Stop recording automation events.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopAutomationEventRecording();

    /// <summary>
    /// Play a recorded automation event.
    /// </summary>
    /// <param name="automationEvent">The automation event to play.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlayAutomationEvent(AutomationEvent automationEvent);
}