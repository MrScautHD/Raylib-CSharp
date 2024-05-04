using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Collision;

[StructLayout(LayoutKind.Sequential)]
public struct BoundingBox {

    /// <summary>
    /// Minimum vertex box-corner.
    /// </summary>
    public Vector3 Min;

    /// <summary>
    /// Maximum vertex box-corner.
    /// </summary>
    public Vector3 Max;

    /// <summary>
    /// Bounding box type.
    /// </summary>
    /// <param name="min">Minimum corner of the bounding box.</param>
    /// <param name="max">Maximum corner of the bounding box.</param>
    public BoundingBox(Vector3 min, Vector3 max) {
        this.Min = min;
        this.Max = max;
    }
}