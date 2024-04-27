using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Collision;

/// <summary>
/// Ray, ray for RayCasting.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct Ray(Vector3 position, Vector3 direction) {

    /// <summary>
    /// Ray position (origin).
    /// </summary>
    public Vector3 Position = position;

    /// <summary>
    /// Ray direction.
    /// </summary>
    public Vector3 Direction = direction;
}