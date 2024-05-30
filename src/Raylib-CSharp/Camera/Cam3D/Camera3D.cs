using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Camera.Cam3D;

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
    /// Represents a 3D camera.
    /// </summary>
    /// <param name="position">Position of the camera.</param>
    /// <param name="target">Target point of the camera.</param>
    /// <param name="up">Up vector of the camera.</param>
    /// <param name="fovY">Vertical field of view angle.</param>
    /// <param name="projection">Projection type of the camera.</param>
    public Camera3D(Vector3 position, Vector3 target, Vector3 up, float fovY, CameraProjection projection) {
        this.Position = position;
        this.Target = target;
        this.Up = up;
        this.FovY = fovY;
        this.Projection = projection;
    }

    /// <inheritdoc cref="RaylibApi.UpdateCamera" />
    public void Update(CameraMode mode) {
        RaylibApi.UpdateCamera(ref this, mode);
    }

    /// <inheritdoc cref="RaylibApi.UpdateCameraPro" />
    public void UpdatePro(Vector3 movement, Vector3 rotation, float zoom) {
        RaylibApi.UpdateCameraPro(ref this, movement, rotation, zoom);
    }

    /// <inheritdoc cref="RaylibApi.GetCameraForward" />
    public Vector3 GetForward() {
        return RaylibApi.GetCameraForward(ref this);
    }

    /// <inheritdoc cref="RaylibApi.GetCameraUp" />
    public Vector3 GetUp() {
        return RaylibApi.GetCameraUp(ref this);
    }

    /// <inheritdoc cref="RaylibApi.GetCameraRight" />
    public Vector3 GetRight() {
        return RaylibApi.GetCameraRight(ref this);
    }

    /// <inheritdoc cref="RaylibApi.CameraMoveForward" />
    public void MoveForward(float distance, bool moveInWorldPlane) {
        RaylibApi.CameraMoveForward(ref this, distance, moveInWorldPlane);
    }

    /// <inheritdoc cref="RaylibApi.CameraMoveUp" />
    public void MoveUp(float distance) {
        RaylibApi.CameraMoveUp(ref this, distance);
    }

    /// <inheritdoc cref="RaylibApi.CameraMoveRight" />
    public void MoveRight(float distance, bool moveInWorldPlane) {
        RaylibApi.CameraMoveRight(ref this, distance, moveInWorldPlane);
    }

    /// <inheritdoc cref="RaylibApi.CameraMoveToTarget" />
    public void MoveToTarget(float delta) {
        RaylibApi.CameraMoveToTarget(ref this, delta);
    }

    /// <inheritdoc cref="RaylibApi.CameraYaw" />
    public void RotateYaw(float angle, bool rotateAroundTarget) {
        RaylibApi.CameraYaw(ref this, angle, rotateAroundTarget);
    }

    /// <inheritdoc cref="RaylibApi.CameraPitch" />
    public void RotatePitch(float angle, bool lockView, bool rotateAroundTarget, bool rotateUp) {
        RaylibApi.CameraPitch(ref this, angle, lockView, rotateAroundTarget, rotateUp);
    }

    /// <inheritdoc cref="RaylibApi.CameraRoll" />
    public void RotateRoll(float angle) {
        RaylibApi.CameraRoll(ref this, angle);
    }

    /// <inheritdoc cref="RaylibApi.GetCameraViewMatrix" />
    public Matrix4x4 GetViewMatrix() {
        return RaylibApi.GetCameraViewMatrix(ref this);
    }

    /// <inheritdoc cref="RaylibApi.GetCameraProjectionMatrix" />
    public Matrix4x4 GetProjectionMatrix(float aspect) {
        return RaylibApi.GetCameraProjectionMatrix(ref this, aspect);
    }

    /// <inheritdoc cref="RaylibApi.GetCameraMatrix" />
    public Matrix4x4 GetMatrix() {
        return RaylibApi.GetCameraMatrix(this);
    }

    /// <inheritdoc cref="RaylibApi.GetMouseRay" />
    public Ray GetMouseRay(Vector2 mousePosition) {
        return RaylibApi.GetMouseRay(mousePosition, this);
    }

    /// <inheritdoc cref="RaylibApi.GetWorldToScreen" />
    public Vector2 GetWorldToScreen(Vector3 position) {
        return RaylibApi.GetWorldToScreen(position, this);
    }

    /// <inheritdoc cref="RaylibApi.GetWorldToScreenEx" />
    public Vector2 GetWorldToScreenEx(Vector3 position, int width, int height) {
        return RaylibApi.GetWorldToScreenEx(position, this, width, height);
    }
}