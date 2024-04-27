using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Camera.Cam3D;

[StructLayout(LayoutKind.Sequential)]
public struct Camera3D {
    
    /// <summary>
    /// Camera position.
    /// </summary>
    public Vector3 Position;

    /// <summary>
    /// Camera target it looks-at.
    /// </summary>
    public Vector3 Target;

    /// <summary>
    /// Camera up vector (rotation over its axis).
    /// </summary>
    public Vector3 Up;

    /// <summary>
    /// Camera field-of-view aperture in Y (degrees) in perspective, used as near plane width in orthographic.
    /// </summary>
    public float FovY;

    /// <summary>
    /// Camera projection: CAMERA_PERSPECTIVE or CAMERA_ORTHOGRAPHIC.
    /// </summary>
    public CameraProjection Projection;

    /// <summary>
    /// Camera3D, defines position/orientation in 3d space.
    /// </summary>
    public Camera3D(Vector3 position, Vector3 target, Vector3 up, float fovY, CameraProjection projection) {
        this.Position = position;
        this.Target = target;
        this.Up = up;
        this.FovY = fovY;
        this.Projection = projection;
    }
}