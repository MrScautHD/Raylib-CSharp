using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Vr;

[StructLayout(LayoutKind.Sequential)]
public struct VrStereoConfig {

    /// <summary>
    /// VR projection matrices (per eye).
    /// </summary>
    public Matrix4x4 Projection1;

    /// <summary>
    /// VR projection matrices (per eye).
    /// </summary>
    public Matrix4x4 Projection2;

    /// <summary>
    /// VR view offset matrices (per eye).
    /// </summary>
    public Matrix4x4 ViewOffset1;

    /// <summary>
    /// VR view offset matrices (per eye).
    /// </summary>
    public Matrix4x4 ViewOffset2;

    /// <summary>
    /// VR left lens center.
    /// </summary>
    public Vector2 LeftLensCenter;

    /// <summary>
    /// VR right lens center.
    /// </summary>
    public Vector2 RightLensCenter;

    /// <summary>
    /// VR left screen center.
    /// </summary>
    public Vector2 LeftScreenCenter;

    /// <summary>
    /// VR right screen center.
    /// </summary>
    public Vector2 RightScreenCenter;

    /// <summary>
    /// VR distortion scale.
    /// </summary>
    public Vector2 Scale;

    /// <summary>
    /// VR distortion scale in.
    /// </summary>
    public Vector2 ScaleIn;

    /// <inheritdoc cref="RaylibApi.LoadVrStereoConfig" />
    public static VrStereoConfig Load(VrDeviceInfo device) {
        return RaylibApi.LoadVrStereoConfig(device);
    }

    /// <inheritdoc cref="RaylibApi.UnloadVrStereoConfig" />
    public void Unload() {
        RaylibApi.UnloadVrStereoConfig(this);
    }
}