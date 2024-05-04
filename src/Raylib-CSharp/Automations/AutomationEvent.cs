using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Automations;

[StructLayout(LayoutKind.Sequential)]
public partial struct AutomationEvent {

    /// <summary>
    /// Event frame.
    /// </summary>
    public uint Frame;

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

    /// <summary>
    /// Set automation event internal base frame to start recording.
    /// </summary>
    /// <param name="frame">The base frame to set.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "SetAutomationEventBaseFrame")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetBaseFrame(int frame);

    /// <summary>
    /// Start recording automation events (AutomationEventList must be set).
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "StartAutomationEventRecording")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StartRecording();

    /// <summary>
    /// Stop recording automation events.
    /// </summary>
    [LibraryImport(Raylib.Name, EntryPoint = "StopAutomationEventRecording")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopRecording();

    /// <summary>
    /// Play a recorded automation event.
    /// </summary>
    /// <param name="automationEvent">The automation event to play.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "PlayAutomationEvent")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Play(AutomationEvent automationEvent);
}