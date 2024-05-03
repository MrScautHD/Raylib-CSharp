using System.Runtime.InteropServices;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Textures;

namespace Raylib_CSharp.Materials;

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