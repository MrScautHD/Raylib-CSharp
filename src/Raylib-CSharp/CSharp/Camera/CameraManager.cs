using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Camera.Cam2D;
using Raylib_CSharp.CSharp.Camera.Cam3D;
using Raylib_CSharp.CSharp.Collision;

namespace Raylib_CSharp.CSharp.Camera;

public static partial class CameraManager {

    /// <summary>
    /// Update camera position for selected mode.
    /// </summary>
    /// <param name="camera">The camera to update.</param>
    /// <param name="mode">The camera mode.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateCamera(ref Camera3D camera, CameraMode mode);

    /// <summary>
    /// Update camera movement/rotation.
    /// </summary>
    /// <param name="camera">The camera to update.</param>
    /// <param name="movement">The movement vector.</param>
    /// <param name="rotation">The rotation vector.</param>
    /// <param name="zoom">The zoom value.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateCameraPro(ref Camera3D camera, Vector3 movement, Vector3 rotation, float zoom);

    /// <summary>
    /// Returns the cameras forward vector (normalized).
    /// </summary>
    /// <param name="camera">The camera to get the forward vector from.</param>
    /// <returns>The forward vector of the camera.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 GetCameraForward(ref Camera3D camera);

    /// <summary>
    /// Returns the cameras up vector (normalized).
    /// </summary>
    /// <param name="camera">The camera.</param>
    /// <returns>The "up" vector of the camera.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 GetCameraUp(ref Camera3D camera);

    /// <summary>
    /// Returns the cameras right vector (normalized).
    /// </summary>
    /// <param name="camera">The camera to get the right vector from.</param>
    /// <returns>The right vector of the camera.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 GetCameraRight(ref Camera3D camera);

    /// <summary>
    /// Moves the camera in its forward direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera forward.</param>
    /// <param name="moveInWorldPlane">Specifies whether to move the camera in the world plane or camera plane.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CameraMoveForward(ref Camera3D camera, float distance, [MarshalAs(UnmanagedType.Bool)] bool moveInWorldPlane);

    /// <summary>
    /// Moves the camera in its up direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera up.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CameraMoveUp(ref Camera3D camera, float distance);

    /// <summary>
    /// Moves the camera target in its current right direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera to the right.</param>
    /// <param name="moveInWorldPlane">Move the camera in world plane coordinates (relative to pivot).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CameraMoveRight(ref Camera3D camera, float distance, [MarshalAs(UnmanagedType.Bool)] bool moveInWorldPlane);

    /// <summary>
    /// Moves the camera position closer/farther to/from the camera target.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="delta">The time interval.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CameraMoveToTarget(ref Camera3D camera, float delta);

    /// <summary>
    /// Rotates the camera around its up vector.
    /// </summary>
    /// <param name="camera">The camera to yaw.</param>
    /// <param name="angle">The yaw angle in degrees.</param>
    /// <param name="rotateAroundTarget">If true, the camera will rotate around its target.
    /// If false, it will rotate around its position.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CameraYaw(ref Camera3D camera, float angle, [MarshalAs(UnmanagedType.Bool)] bool rotateAroundTarget);

    /// <summary>
    /// Rotates the camera around its right vector, pitch is "looking up and down".
    /// </summary>
    /// <param name="camera">The camera to rotate.</param>
    /// <param name="angle">The angle to rotate. Positive values rotate counterclockwise, negative values rotate clockwise.</param>
    /// <param name="lockView">If set to true, the camera view will remain locked (parallel to the ground) during rotation.</param>
    /// <param name="rotateAroundTarget">If set to true, the camera will rotate around the target according to its position and orientation.</param>
    /// <param name="rotateUp">If set to true, the camera will rotate around the World's up vector instead of its local up vector.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CameraPitch(ref Camera3D camera, float angle, [MarshalAs(UnmanagedType.Bool)] bool lockView, [MarshalAs(UnmanagedType.Bool)] bool rotateAroundTarget, [MarshalAs(UnmanagedType.Bool)] bool rotateUp);

    /// <summary>
    /// Rotates the camera around its forward vector.
    /// </summary>
    /// <param name="camera">The camera to roll.</param>
    /// <param name="angle">The angle in degrees to roll the camera.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CameraRoll(ref Camera3D camera, float angle);

    /// <summary>
    /// Returns the camera view matrix.
    /// </summary>
    /// <param name="camera">The camera to get the view matrix from.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraViewMatrix(ref Camera3D camera);

    /// <summary>
    /// Returns the camera projection matrix.
    /// </summary>
    /// <param name="camera">The camera to retrieve the projection matrix from.</param>
    /// <param name="aspect">The aspect ratio of the camera.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraProjectionMatrix(ref Camera3D camera, float aspect);

    /// <summary>
    /// Get a ray trace from mouse position.
    /// </summary>
    /// <param name="mousePosition">The position of the mouse in screen coordinates.</param>
    /// <param name="camera">The camera to use for the ray calculation.</param>
    /// <returns>The ray from the mouse position in world space coordinates.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Ray GetMouseRay(Vector2 mousePosition, Camera3D camera);

    /// <summary>
    /// Get camera transform matrix (view matrix).
    /// </summary>
    /// <param name="camera">The camera for which to retrieve the matrix.</param>
    /// <returns>The 4x4 matrix representing the camera's view.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraMatrix(Camera3D camera);

    /// <summary>
    /// Get camera 2d transform matrix.
    /// </summary>
    /// <param name="camera">The Camera2D to get the transformation matrix for.</param>
    /// <returns>The 2D transformation matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraMatrix2D(Camera2D camera);

    /// <summary>
    /// Get the screen space position for a 3d world space position.
    /// </summary>
    /// <param name="position">The world position to convert.</param>
    /// <param name="camera">The camera to use for the conversion.</param>
    /// <returns>The screen coordinates of the world position.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);

    /// <summary>
    /// Get the world space position for a 2d camera screen space position.
    /// </summary>
    /// <param name="position">The screen position (2D) to convert.</param>
    /// <param name="camera">The Camera2D used for the conversion.</param>
    /// <returns>The world position (3D) corresponding to the screen position (2D).</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera);

    /// <summary>
    /// Get size position for a 3d world space position.
    /// </summary>
    /// <param name="position">The world-space position.</param>
    /// <param name="camera">The camera3D to use for the conversion.</param>
    /// <param name="width">The width of the screen.</param>
    /// <param name="height">The height of the screen.</param>
    /// <returns>The screen-space coordinates as a Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height);

    /// <summary>
    /// Get the screen space position for a 2d camera world space position.
    /// </summary>
    /// <param name="position">The world position in 2D.</param>
    /// <param name="camera">The 2D camera.</param>
    /// <returns>The screen position in 2D.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera);
}