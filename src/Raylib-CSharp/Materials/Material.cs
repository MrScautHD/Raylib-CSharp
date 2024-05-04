using System.Runtime.InteropServices;
using Raylib_CSharp.Shaders;

namespace Raylib_CSharp.Materials;

[StructLayout(LayoutKind.Sequential)]
public struct Material {

    /// <summary>
    /// Material shader.
    /// </summary>
    public Shader Shader;

    /// <summary>
    /// Material maps array (MAX_MATERIAL_MAPS).
    /// </summary>
    public unsafe Span<MaterialMap> Maps => new(this.MapsPtr, 12);

    public unsafe MaterialMap* MapsPtr;

    /// <summary>
    /// Material generic parameters (if required).
    /// </summary>
    public unsafe Span<float> Param {
        get {
            fixed (float* paramPtr = this.ParamPtr) {
                return new(paramPtr, 4);
            }
        }
    }

    public unsafe fixed float ParamPtr[4];
}