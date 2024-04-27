using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Camera.Cam2D;

/// <summary>
/// Camera2D, defines position/orientation in 2d space.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct Camera2D(Vector2 offset, Vector2 target, float rotation, float zoom) {

    /// <summary>
    /// Camera offset (displacement from target).
    /// </summary>
    public Vector2 Offset = offset;

    /// <summary>
    /// Camera target (rotation and zoom origin).
    /// </summary>
    public Vector2 Target = target;

    /// <summary>
    /// Camera rotation in degrees.
    /// </summary>
    public float Rotation = rotation;

    /// <summary>
    /// Camera zoom (scaling), should be 1.0f by default.
    /// </summary>
    public float Zoom = zoom;
}