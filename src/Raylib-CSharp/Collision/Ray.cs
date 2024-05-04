using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Collision;

[StructLayout(LayoutKind.Sequential)]
public struct Ray {

    /// <summary>
    /// Ray position (origin).
    /// </summary>
    public Vector3 Position;

    /// <summary>
    /// Ray direction.
    /// </summary>
    public Vector3 Direction;

    /// <summary>
    /// Ray, ray for RayCasting.
    /// </summary>
    /// <param name="position">Origin position of the ray.</param>
    /// <param name="direction">Direction of the ray.</param>
    public Ray(Vector3 position, Vector3 direction) {
        this.Position = position;
        this.Direction = direction;
    }
}