using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Vr;

public static partial class Vr {

    /// <summary>
    /// Load VR stereo config for VR simulator device parameters.
    /// </summary>
    /// <param name="device">The VR device information.</param>
    /// <returns>The loaded VR stereo configuration.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadVrStereoConfig")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial VrStereoConfig LoadStereoConfig(VrDeviceInfo device);

    /// <summary>
    /// Unload VR stereo config.
    /// </summary>
    /// <param name="config">The VR stereo configuration to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadVrStereoConfig")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadStereoConfig(VrStereoConfig config);
}