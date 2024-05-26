using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Collision;

public static partial class ShapeHelper {

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
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckCollisionRecs(Rectangle rec1, Rectangle rec2);

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
    [return: MarshalAs(UnmanagedType.I1)]
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
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckCollisionCircleRec(Vector2 center, float radius, Rectangle rec);

    /// <summary>
    /// Check if point is inside rectangle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="rec">The rectangle to check against.</param>
    /// <returns>True if the point is inside the rectangle, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckCollisionPointRec(Vector2 point, Rectangle rec);

    /// <summary>
    /// Check if point is inside circle.
    /// </summary>
    /// <param name="point">The point to check.</param>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <returns>True if the point is inside the circle, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
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
    [return: MarshalAs(UnmanagedType.I1)]
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
    [return: MarshalAs(UnmanagedType.I1)]
    public static unsafe partial bool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount);

    /// <summary>
    /// Check if point is within a polygon described by array of vertices.
    /// </summary>
    /// <param name="point">The point to check for collision.</param>
    /// <param name="points">The array of points that define the polygon.</param>
    /// <returns>True if the point collides with the polygon, otherwise false.</returns>
    public static unsafe bool CheckCollisionPointPoly(Vector2 point, Span<Vector2> points) {
        fixed (Vector2* pointsPtr = points) {
            return CheckCollisionPointPoly(point, pointsPtr, points.Length);
        }
    }

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
    [return: MarshalAs(UnmanagedType.I1)]
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
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);

    /// <summary>
    /// Get collision rectangle for two rectangles collision.
    /// </summary>
    /// <param name="rec1">The first rectangle.</param>
    /// <param name="rec2">The second rectangle.</param>
    /// <returns>The collision rectangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Rectangle GetCollisionRec(Rectangle rec1, Rectangle rec2);
}