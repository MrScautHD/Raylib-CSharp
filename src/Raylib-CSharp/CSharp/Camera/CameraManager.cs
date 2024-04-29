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
    public static partial Vector2 GetScreenToWorld2D(Vector3 position, Camera2D camera);

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