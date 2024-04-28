using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Camera.Cam2D;

[StructLayout(LayoutKind.Sequential)]
public struct Camera2D {

    /// <summary>
    /// Camera2D, defines position/orientation in 2d space.
    /// </summary>
    public Camera2D(Vector2 offset, Vector2 target, float rotation, float zoom) {
        this.Offset = offset;
        this.Target = target;
        this.Rotation = rotation;
        this.Zoom = zoom;
    }

    /// <summary>
    /// Camera offset (displacement from target).
    /// </summary>
    public Vector2 Offset;

    /// <summary>
    /// Camera target (rotation and zoom origin).
    /// </summary>
    public Vector2 Target;

    /// <summary>
    /// Camera rotation in degrees.
    /// </summary>
    public float Rotation;

    /// <summary>
    /// Camera zoom (scaling), should be 1.0f by default.
    /// </summary>
    public float Zoom;
}