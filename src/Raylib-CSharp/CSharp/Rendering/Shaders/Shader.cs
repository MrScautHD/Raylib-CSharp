using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Rendering.Shaders;

[StructLayout(LayoutKind.Sequential)]
public struct Shader {
    
    /// <summary>
    /// Shader program id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Shader locations array (RL_MAX_SHADER_LOCATIONS).
    /// </summary>
    public unsafe int* Locs;
}