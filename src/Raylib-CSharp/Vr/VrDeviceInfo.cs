using System.Runtime.InteropServices;

namespace Raylib_CSharp.Vr;

[StructLayout(LayoutKind.Sequential)]
public struct VrDeviceInfo {

    /// <summary>
    /// Horizontal resolution in pixels.
    /// </summary>
    public int HResolution;

    /// <summary>
    /// Vertical resolution in pixels.
    /// </summary>
    public int VResolution;

    /// <summary>
    /// Horizontal size in meters.
    /// </summary>
    public float HScreenSize;

    /// <summary>
    /// Vertical size in meters.
    /// </summary>
    public float VScreenSize;

    /// <summary>
    /// Screen center in meters.
    /// </summary>
    public float VScreenCenter;

    /// <summary>
    /// Distance between eye and display in meters.
    /// </summary>
    public float EyeToScreenDistance;

    /// <summary>
    /// Lens separation distance in meters.
    /// </summary>
    public float LensSeparationDistance;

    /// <summary>
    /// IPD (distance between pupils) in meters.
    /// </summary>
    public float InterpupillaryDistance;

    /// <summary>
    /// Lens distortion constant parameters.
    /// </summary>
    public unsafe Span<float> LensDistortionValues {
        get {
            fixed (float* lensDistortionValues = this.LensDistortionValuesPtr) {
                return new(lensDistortionValues, 4);
            }
        }
    }

    public unsafe fixed float LensDistortionValuesPtr[4];

    /// <summary>
    /// Chromatic aberration correction parameters.
    /// </summary>
    public unsafe Span<float> ChromaAbCorrection {
        get {
            fixed (float* chromaAbCorrection = this.ChromaAbCorrectionPtr) {
                return new(chromaAbCorrection, 4);
            }
        }
    }

    public unsafe fixed float ChromaAbCorrectionPtr[4];
}