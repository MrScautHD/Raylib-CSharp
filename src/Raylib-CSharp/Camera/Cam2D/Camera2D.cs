using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Camera.Cam2D;

[StructLayout(LayoutKind.Sequential)]
public partial struct Camera2D {

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

    /// <summary>
    /// Get the world space position for a 2d camera screen space position.
    /// </summary>
    /// <param name="position">The screen position (2D) to convert.</param>
    /// <param name="camera">The Camera2D used for the conversion.</param>
    /// <returns>The world position (3D) corresponding to the screen position (2D).</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetScreenToWorld2D")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetScreenToWorld(Vector2 position, Camera2D camera);

    /// <summary>
    /// Get the screen space position for a 2d camera world space position.
    /// </summary>
    /// <param name="position">The world position in 2D.</param>
    /// <param name="camera">The 2D camera.</param>
    /// <returns>The screen position in 2D.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetWorldToScreen2D")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen(Vector2 position, Camera2D camera);
}

/// <summary>
/// Contains extension methods for the <see cref="Camera2D"/> class.
/// </summary>
public static partial class Camera2DExtensions {

    /// <summary>
    /// Get camera 2d transform matrix.
    /// </summary>
    /// <param name="camera">The Camera2D to get the transformation matrix for.</param>
    /// <returns>The 2D transformation matrix.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCameraMatrix2D")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Matrix4x4 GetMatrix_(Camera2D camera);
    public static Matrix4x4 GetMatrix(this Camera2D camera) => GetMatrix_(camera);
}