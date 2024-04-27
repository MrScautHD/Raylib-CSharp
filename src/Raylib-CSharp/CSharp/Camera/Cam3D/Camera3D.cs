using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Camera.Cam3D;

/// <summary>
/// Camera3D, defines position/orientation in 3d space.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct Camera3D(Vector3 position, Vector3 target, Vector3 up, float fovY, CameraProjection projection) {

    /// <summary>
    /// Camera position.
    /// </summary>
    public Vector3 Position = position;

    /// <summary>
    /// Camera target it looks-at.
    /// </summary>
    public Vector3 Target = target;

    /// <summary>
    /// Camera up vector (rotation over its axis).
    /// </summary>
    public Vector3 Up = up;

    /// <summary>
    /// Camera field-of-view aperture in Y (degrees) in perspective, used as near plane width in orthographic.
    /// </summary>
    public float FovY = fovY;

    /// <summary>
    /// Camera projection: CAMERA_PERSPECTIVE or CAMERA_ORTHOGRAPHIC.
    /// </summary>
    public CameraProjection Projection = projection;
}