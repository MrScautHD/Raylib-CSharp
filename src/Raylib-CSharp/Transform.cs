using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp;

[StructLayout(LayoutKind.Sequential)]
public struct Transform {

    /// <summary>
    /// Translation.
    /// </summary>
    public Vector3 Translation;

    /// <summary>
    /// Rotation.
    /// </summary>
    public Quaternion Rotation;

    /// <summary>
    /// Scale.
    /// </summary>
    public Vector3 Scale;
}