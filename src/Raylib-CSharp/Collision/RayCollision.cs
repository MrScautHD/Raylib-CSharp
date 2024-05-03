using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Collision;

[StructLayout(LayoutKind.Sequential)]
public struct RayCollision {

    /// <summary>
    /// Did the ray hit something?
    /// </summary>
    public bool Hit;

    /// <summary>
    /// Distance to the nearest hit.
    /// </summary>
    public float Distance;

    /// <summary>
    /// Point of the nearest hit.
    /// </summary>
    public Vector3 Point;

    /// <summary>
    /// Surface normal of hit.
    /// </summary>
    public Vector3 Normal;
}