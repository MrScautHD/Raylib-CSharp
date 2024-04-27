using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Rendering.Textures;
using Raylib_CSharp.CSharp.Misc;

namespace Raylib_CSharp.CSharp.Materials;

[StructLayout(LayoutKind.Sequential)]
public struct MaterialMap {
    
    /// <summary>
    /// Material map texture.
    /// </summary>
    public Texture2D Texture;

    /// <summary>
    /// Material map color.
    /// </summary>
    public Color Color;

    /// <summary>
    /// Material map value.
    /// </summary>
    public float Value;
}