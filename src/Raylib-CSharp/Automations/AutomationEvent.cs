using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Automations;

[StructLayout(LayoutKind.Sequential)]
public struct AutomationEvent {

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
    public unsafe fixed int ParamsPtr[4];

    /// <inheritdoc cref="ParamsPtr" />
    public unsafe Span<int> Params {
        get {
            fixed (int* paramsPtr = this.ParamsPtr) {
                return new Span<int>(paramsPtr, 4);
            }
        }
    }

    /// <inheritdoc cref="RaylibApi.SetAutomationEventBaseFrame" />
    public static void SetBaseFrame(int frame) {
        RaylibApi.SetAutomationEventBaseFrame(frame);
    }

    /// <inheritdoc cref="RaylibApi.StartAutomationEventRecording" />
    public static void StartRecording() {
        RaylibApi.StartAutomationEventRecording();
    }

    /// <inheritdoc cref="RaylibApi.StopAutomationEventRecording" />
    public static void StopRecording() {
        RaylibApi.StopAutomationEventRecording();
    }

    /// <inheritdoc cref="RaylibApi.PlayAutomationEvent" />
    public void Play() {
        RaylibApi.PlayAutomationEvent(this);
    }
}