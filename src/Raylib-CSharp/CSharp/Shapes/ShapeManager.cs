using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Textures;
using Color = Raylib_CSharp.CSharp.Colors.Color;

namespace Raylib_CSharp.CSharp.Shapes;

public static partial class ShapeManager {

    /// <summary>
    /// Set texture and rectangle to be used on shapes drawing.
    /// </summary>
    /// <param name="texture">The texture to set.</param>
    /// <param name="source">The source rectangle of the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShapesTexture(Texture2D texture, RectangleF source);

    /// <summary>
    /// Draw a pixel.
    /// </summary>
    /// <param name="posX">The X coordinate of the pixel position.</param>
    /// <param name="posY">The Y coordinate of the pixel position.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixel(int posX, int posY, Color color);

    /// <summary>
    /// Draw a pixel (Vector version).
    /// </summary>
    /// <param name="position">The position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixelV(Vector2 position, Color color);

    /// <summary>
    /// Draw a line.
    /// </summary>
    /// <param name="startPosX">The x-coordinate of the starting point.</param>
    /// <param name="startPosY">The y-coordinate of the starting point.</param>
    /// <param name="endPosX">The x-coordinate of the ending point.</param>
    /// <param name="endPosY">The y-coordinate of the ending point.</param>
    /// <param name="color">The color to use for drawing the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// Draw a line (using gl lines).
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineV(Vector2 startPos, Vector2 endPos, Color color);

    /// <summary>
    /// Draw a line (using triangles/quads).
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="thick">The thickness of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw lines sequence (using gl lines).
    /// </summary>
    /// <param name="points">The array of points defining the line strip.</param>
    /// <param name="pointCount">The number of points in the line strip array.</param>
    /// <param name="color">The color of the line strip.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawLineStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw line segment cubic-bezier in-out interpolation.
    /// </summary>
    /// <param name="startPos">The starting position of the curve.</param>
    /// <param name="endPos">The ending position of the curve.</param>
    /// <param name="thick">The thickness of the curve.</param>
    /// <param name="color">The color of the curve.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw a color-filled circle.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw a piece of a circle.
    /// </summary>
    /// <param name="center">The center point of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="startAngle">The starting angle of the sector in degrees.</param>
    /// <param name="endAngle">The ending angle of the sector in degrees.</param>
    /// <param name="segments">The number of line segments used to approximate the curve.</param>
    /// <param name="color">The color to fill the sector with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw circle sector outline.
    /// </summary>
    /// <param name="center">The center point of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="startAngle">The start angle in radians.</param>
    /// <param name="endAngle">The end angle in radians.</param>
    /// <param name="segments">The number of line segments to use.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a gradient-filled circle.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the circle's center.</param>
    /// <param name="centerY">The y-coordinate of the circle's center.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color1">The color at the center of the circle.</param>
    /// <param name="color2">The color at the edge of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2);

    /// <summary>
    /// Draw a color-filled circle (Vector version).
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw circle outline.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLines(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw circle outline (Vector version).
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLinesV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw ellipse.
    /// </summary>
    /// <param name="centerX">The X coordinate of the center of the ellipse.</param>
    /// <param name="centerY">The Y coordinate of the center of the ellipse.</param>
    /// <param name="radiusH">The horizontal radius of the ellipse.</param>
    /// <param name="radiusV">The vertical radius of the ellipse.</param>
    /// <param name="color">The color of the ellipse.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ellipse outline.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the ellipse.</param>
    /// <param name="centerY">The y-coordinate of the center of the ellipse.</param>
    /// <param name="radiusH">The horizontal radius of the ellipse.</param>
    /// <param name="radiusV">The vertical radius of the ellipse.</param>
    /// <param name="color">The color of the ellipse outline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ring.
    /// </summary>
    /// <param name="center">The center of the ring.</param>
    /// <param name="innerRadius">The inner radius of the ring.</param>
    /// <param name="outerRadius">The outer radius of the ring.</param>
    /// <param name="startAngle">The start angle of the ring (in radians).</param>
    /// <param name="endAngle">The end angle of the ring (in radians).</param>
    /// <param name="segments">The number of segments to draw the ring.</param>
    /// <param name="color">The color of the ring.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw ring outline.
    /// </summary>
    /// <param name="center">The center point of the ring.</param>
    /// <param name="innerRadius">The inner radius of the ring.</param>
    /// <param name="outerRadius">The outer radius of the ring.</param>
    /// <param name="startAngle">The start angle of the ring in radians.</param>
    /// <param name="endAngle">The end angle of the ring in radians.</param>
    /// <param name="segments">The number of line segments which form the ring.</param>
    /// <param name="color">The color of the ring.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a color-filled rectangle.
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangle(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw a color-filled rectangle (Vector version).
    /// </summary>
    /// <param name="position">The position of the top-left corner of the rectangle.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleV(Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// Draw a color-filled rectangle.
    /// </summary>
    /// <param name="rec"> The dimensions of the rectangle to draw.</param>
    /// <param name="color"> The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRec(RectangleF rec, Color color);

    /// <summary>
    /// Draw a color-filled rectangle with pro parameters.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="origin">The origin point of rotation.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="color">The color to fill the rectangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectanglePro(RectangleF rec, Vector2 origin, float rotation, Color color);

    /// <summary>
    /// Draw a vertical-gradient-filled rectangle.
    /// </summary>
    /// <param name="posX">The X coordinate of the rectangle's top-left corner.</param>
    /// <param name="posY">The Y coordinate of the rectangle's top-left corner.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color1">The starting color of the gradient.</param>
    /// <param name="color2">The ending color of the gradient.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2);

    /// <summary>
    /// Draw a horizontal-gradient-filled rectangle.
    /// </summary>
    /// <param name="posX">The starting x-coordinate of the rectangle.</param>
    /// <param name="posY">The starting y-coordinate of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color1">The starting color of the gradient.</param>
    /// <param name="color2">The ending color of the gradient.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2);

    /// <summary>
    /// Draw a gradient-filled rectangle with custom vertex colors.
    /// </summary>
    /// <param name="rec">The position and size of the rectangle.</param>
    /// <param name="col1">The color at the top-left corner of the rectangle.</param>
    /// <param name="col2">The color at the top-right corner of the rectangle.</param>
    /// <param name="col3">The color at the bottom-right corner of the rectangle.</param>
    /// <param name="col4">The color at the bottom-left corner of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientEx(RectangleF rec, Color col1, Color col2, Color col3, Color col4);

    /// <summary>
    /// Draw rectangle outline.
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLines(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw rectangle outline with extended parameters.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="lineThick">The thickness of the lines in pixels.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLinesEx(RectangleF rec, float lineThick, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="roundness">The roundness of the rectangle corners.</param>
    /// <param name="segments">The number of segments used to draw the rounded corners.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRounded(RectangleF rec, float roundness, int segments, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges outline.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="roundness">The roundness of the corners. The value 0 is a sharp corner, while larger values make the corners more rounded.</param>
    /// <param name="segments">The number of segments used to approximate each corner.</param>
    /// <param name="lineThick">The thickness of the lines used to draw the rectangle and its corners.</param>
    /// <param name="color">The color of the rectangle and its corners.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRoundedLines(RectangleF rec, float roundness, int segments, float lineThick, Color color);

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color to fill the triangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw a triangle fan defined by points (first vertex is the center).
    /// </summary>
    /// <param name="points">An array of points representing the vertices of the triangles.</param>
    /// <param name="pointCount">The number of vertices in the array.</param>
    /// <param name="color">The color of the triangles.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleFan(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">The array of vertices defining the triangle strip.</param>
    /// <param name="pointCount">The number of vertices in the array.</param>
    /// <param name="color">The color to fill the triangle strip with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a regular polygon (Vector version).
    /// </summary>
    /// <param name="center">The center position of the polygon.</param>
    /// <param name="sides">The number of sides of the polygon.</param>
    /// <param name="radius">The radius of the polygon.</param>
    /// <param name="rotation">The rotation angle of the polygon in degrees.</param>
    /// <param name="color">The color of the polygon.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides.
    /// </summary>
    /// <param name="center">The center position of the polygon.</param>
    /// <param name="sides">The number of sides of the polygon.</param>
    /// <param name="radius">The radius of the polygon.</param>
    /// <param name="rotation">The rotation angle of the polygon in radians.</param>
    /// <param name="color">The color of the polygon.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides with extended parameters.
    /// </summary>
    /// <param name="center">The center position of the shape.</param>
    /// <param name="sides">The number of sides of the shape.</param>
    /// <param name="radius">The radius of the shape.</param>
    /// <param name="rotation">The rotation angle of the shape.</param>
    /// <param name="lineThick">The thickness of the lines.</param>
    /// <param name="color">The color of the shape.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color);

    /// <summary>
    /// Draw spline: Linear, minimum 2 points.
    /// </summary>
    /// <param name="points">The array of points that define the spline.</param>
    /// <param name="pointCount">The number of points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineLinear(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: B-Spline, minimum 4 points.
    /// </summary>
    /// <param name="points">Pointer to the array of control points.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the curve.</param>
    /// <param name="color">The color of the curve.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBasis(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Catmull-Rom, minimum 4 points.
    /// </summary>
    /// <param name="points">The array of control points defining the spline.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineCatmullRom(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Quadratic Bezier, minimum 3 points (1 control point): [p1, c2, p3, c4...].
    /// </summary>
    /// <param name="points">The array of control points defining the spline.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierQuadratic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Cubic Bezier, minimum 4 points (2 control points): [p1, c2, c3, p4, c5, c6...].
    /// </summary>
    /// <param name="points">Pointer to an array of Vector2 control points</param>
    /// <param name="pointCount">Number of control points in the array</param>
    /// <param name="thick">Thickness of the curve</param>
    /// <param name="color">Color of the curve</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierCubic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Linear, 2 points.
    /// </summary>
    /// <param name="p1">The starting point of the spline segment.</param>
    /// <param name="p2">The ending point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color);

    /// <summary>
    /// Draw spline segment: B-Spline, 4 points.
    /// </summary>
    /// <param name="p1">The first control point.</param>
    /// <param name="p2">The second control point.</param>
    /// <param name="p3">The third control point.</param>
    /// <param name="p4">The fourth control point.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment </param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Catmull-Rom, 4 points.
    /// </summary>
    /// <param name="p1">The first point of the spline segment.</param>
    /// <param name="p2">The second point of the spline segment.</param>
    /// <param name="p3">The third point of the spline segment.</param>
    /// <param name="p4">The fourth point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Quadratic Bezier, 2 points, 1 control point.
    /// </summary>
    /// <param name="p1">The starting point of the segment.</param>
    /// <param name="c2">The control point of the segment.</param>
    /// <param name="p3">The ending point of the segment.</param>
    /// <param name="thick">The thickness of the curve segment.</param>
    /// <param name="color">The color of the curve segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Cubic Bezier, 2 points, 2 control points.
    /// </summary>
    /// <param name="p1">The starting point of the spline segment.</param>
    /// <param name="c2">The second control point of the spline segment.</param>
    /// <param name="c3">The third control point of the spline segment.</param>
    /// <param name="p4">The ending point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment to draw.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Get (evaluate) spline point: Linear.
    /// </summary>
    /// <param name="startPos">The start position of the spline.</param>
    /// <param name="endPos">The end position of the spline.</param>
    /// <param name="t">The time value between 0 and 1.</param>
    /// <returns>The point on the linear spline.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointLinear(Vector2 startPos, Vector2 endPos, float t);

    /// <summary>
    /// Get (evaluate) spline point: B-Spline.
    /// </summary>
    /// <param name="p1">The first control point of the spline curve.</param>
    /// <param name="p2">The second control point of the spline curve.</param>
    /// <param name="p3">The third control point of the spline curve.</param>
    /// <param name="p4">The fourth control point of the spline curve.</param>
    /// <param name="t">The parameter value for the point on the spline curve (range from 0 to 1).</param>
    /// <returns>The basis function value for the point on the spline curve.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// Get (evaluate) spline point: Catmull-Rom.
    /// </summary>
    /// <param name="p1">The first control point.</param>
    /// <param name="p2">The second control point.</param>
    /// <param name="p3">The third control point.</param>
    /// <param name="p4">The fourth control point.</param>
    /// <param name="t">The t-value between 0 and 1.</param>
    /// <returns>The calculated point on the Catmull-Rom spline.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// Get (evaluate) spline point: Quadratic Bezier.
    /// </summary>
    /// <param name="p1">The start point of the curve.</param>
    /// <param name="c2">The control point of the curve.</param>
    /// <param name="p3">The end point of the curve.</param>
    /// <param name="t">The t value represents position on the curve. It should be between 0 and 1.</param>
    /// <returns>The calculated point on the curve.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBezierQuad(Vector2 p1, Vector2 c2, Vector2 p3, float t);

    /// <summary>
    /// Get (evaluate) spline point: Cubic Bezier.
    /// </summary>
    /// <param name="p1">The starting point of the spline.</param>
    /// <param name="c2">The second control point of the spline.</param>
    /// <param name="c3">The third control point of the spline.</param>
    /// <param name="p4">The ending point of the spline.</param>
    /// <param name="t">The time parameter for interpolation, between 0 and 1.</param>
    /// <returns>The calculated point on the spline.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float t);

    /// <summary>
    /// Check collision between two rectangles.
    /// </summary>
    /// <param name="rec1">The first rectangle.</param>
    /// <param name="rec2">The second rectangle.</param>
    /// <returns>True if the rectangles are colliding, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionRecs(RectangleF rec1, RectangleF rec2);

    /// <summary>
    /// Check collision between two circles.
    /// </summary>
    /// <param name="center1">The center of the first circle.</param>
    /// <param name="radius1">The radius of the first circle.</param>
    /// <param name="center2">The center of the second circle.</param>
    /// <param name="radius2">The radius of the second circle.</param>
    /// <returns>True if the circles collide, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);

    /// <summary>
    /// Check collision between circle and rectangle.
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="rec">The rectangle to check collision with.</param>
    /// <returns>True if there is a collision, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionCircleRec(Vector2 center, float radius, RectangleF rec);

    /// <summary>
    /// Check if point is inside rectangle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="rec">The rectangle to check against.</param>
    /// <returns>True if the point is inside the rectangle, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionPointRec(Vector2 point, RectangleF rec);

    /// <summary>
    /// Check if point is inside circle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <returns>True if the point is inside the circle, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);

    /// <summary>
    /// Check if point is inside a triangle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="p1">The first vertex of the triangle.</param>
    /// <param name="p2">The second vertex of the triangle.</param>
    /// <param name="p3">The third vertex of the triangle.</param>
    /// <returns>True if the point is inside the triangle; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);

    /// <summary>
    /// Check if point is within a polygon described by array of vertices.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="points">An array of points that define the vertices of the polygon.</param>
    /// <param name="pointCount">The number of points in the array.</param>
    /// <returns>True if the point is inside the polygon, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static unsafe partial bool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount);

    /// <summary>
    /// Check the collision between two lines defined by two points each, returns collision point by reference.
    /// </summary>
    /// <param name="startPos1">The start position of the first line.</param>
    /// <param name="endPos1">The end position of the first line.</param>
    /// <param name="startPos2">The start position of the second line.</param>
    /// <param name="endPos2">The end position of the second line.</param>
    /// <param name="collisionPoint">Return the intersection point if lines intersect, otherwise returns null.</param>
    /// <returns>Returns true if the lines intersect, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, ref Vector2 collisionPoint);

    /// <summary>
    /// Check if point belongs to line created between two points [p1] and [p2] with defined margin in pixels [threshold].
    /// </summary>
    /// <param name="point">The point to check for collision.</param>
    /// <param name="p1">The starting point of the line segment.</param>
    /// <param name="p2">The ending point of the line segment.</param>
    /// <param name="threshold">The threshold value for collision.</param>
    /// <returns>Returns true if the point collides with the line segment within the threshold, otherwise returns false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);

    /// <summary>
    /// Get collision rectangle for two rectangles collision.
    /// </summary>
    /// <param name="rec1">The first rectangle.</param>
    /// <param name="rec2">The second rectangle.</param>
    /// <returns>The collision rectangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RectangleF GetCollisionRec(RectangleF rec1, RectangleF rec2);
}