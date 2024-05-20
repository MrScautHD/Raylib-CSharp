using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp;

[StructLayout(LayoutKind.Sequential)]
public struct Rectangle {

    /// <summary>
    /// Rectangle top-left corner position x.
    /// </summary>
    public float X;

    /// <summary>
    /// Rectangle top-left corner position y.
    /// </summary>
    public float Y;

    /// <summary>
    /// Rectangle width.
    /// </summary>
    public float Width;

    /// <summary>
    /// Rectangle height.
    /// </summary>
    public float Height;

    /// <summary>
    /// Rectangle, 4 components.
    /// </summary>
    /// <param name="x">The x-coordinate of the rectangle.</param>
    /// <param name="y">The y-coordinate of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public Rectangle(float x, float y, float width, float height) {
        this.X = x;
        this.Y = y;
        this.Width = width;
        this.Height = height;
    }

    /// <summary>
    /// Gets or sets the size of the rectangle.
    /// </summary>
    /// <value>A Vector2 representing the width and height of the rectangle.</value>
    public Vector2 Size {
        get => new Vector2(this.X, this.Y);
        set {
            this.Width = value.X;
            this.Height = value.Y;
        }
    }

    public override string ToString() {
        return $"X:{this.X} Y:{this.Y} Width:{this.Width} Height:{this.Height}";
    }
}