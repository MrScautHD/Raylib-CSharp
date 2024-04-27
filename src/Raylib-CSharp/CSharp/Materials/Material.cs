using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Rendering.Shaders;

namespace Raylib_CSharp.CSharp.Materials;

[StructLayout(LayoutKind.Sequential)]
public struct Material {

    /// <summary>
    /// Material shader.
    /// </summary>
    public Shader Shader;

    /// <summary>
    /// Material maps array (MAX_MATERIAL_MAPS).
    /// </summary>
    public unsafe MaterialMap* Maps;

    /// <summary>
    /// Material generic parameters (if required).
    /// </summary>
    public unsafe fixed float Param[4];
}