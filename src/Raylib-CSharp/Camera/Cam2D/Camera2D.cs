using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Camera.Cam2D;

[StructLayout(LayoutKind.Sequential)]
public struct Camera2D {

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

    /// <summary>
    /// Camera2D, defines position/orientation in 2d space.
    /// </summary>
    /// <param name="offset">Offset position of the camera.</param>
    /// <param name="target">Target point of the camera.</param>
    /// <param name="rotation">Rotation angle of the camera.</param>
    /// <param name="zoom">Zoom level of the camera.</param>
    public Camera2D(Vector2 offset, Vector2 target, float rotation, float zoom) {
        this.Offset = offset;
        this.Target = target;
        this.Rotation = rotation;
        this.Zoom = zoom;
    }

    /// <inheritdoc cref="RaylibApi.GetScreenToWorld2D" />
    public Vector2 GetScreenToWorld(Vector2 position) {
        return RaylibApi.GetScreenToWorld2D(position, this);
    }

    /// <inheritdoc cref="RaylibApi.GetWorldToScreen2D" />
    public Vector2 GetWorldToScreen(Vector2 position) {
        return RaylibApi.GetWorldToScreen2D(position, this);
    }

    /// <inheritdoc cref="RaylibApi.GetCameraMatrix2D" />
    public Matrix4x4 GetCameraMatrix() {
        return RaylibApi.GetCameraMatrix2D(this);
    }
}