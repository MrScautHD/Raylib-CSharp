using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Collision;

[StructLayout(LayoutKind.Sequential)]
public struct BoundingBox {

    /// <summary>
    /// Bounding box type.
    /// </summary>
    public BoundingBox(Vector3 min, Vector3 max) {
        this.Min = min;
        this.Max = max;
    }

    /// <summary>
    /// Minimum vertex box-corner.
    /// </summary>
    public Vector3 Min;

    /// <summary>
    /// Maximum vertex box-corner.
    /// </summary>
    public Vector3 Max;
}