using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Vr;

public static partial class VrManager {

    /// <summary>
    /// Load VR stereo config for VR simulator device parameters.
    /// </summary>
    /// <param name="device">The VR device information.</param>
    /// <returns>The loaded VR stereo configuration.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);

    /// <summary>
    /// Unload VR stereo config.
    /// </summary>
    /// <param name="config">The VR stereo configuration to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadVrStereoConfig(VrStereoConfig config);
}