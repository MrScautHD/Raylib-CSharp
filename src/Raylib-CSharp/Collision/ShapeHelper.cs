using System.Numerics;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Collision;

public static class ShapeHelper {

    /// <inheritdoc cref="RaylibApi.SetShapesTexture" />
    public static void SetShapesTexture(Texture2D texture, Rectangle source) {
        RaylibApi.SetShapesTexture(texture, source);
    }

    /// <inheritdoc cref="RaylibApi.GetSplinePointLinear" />
    public static Vector2 GetSplinePointLinear(Vector2 startPos, Vector2 endPos, float t) {
        return RaylibApi.GetSplinePointLinear(startPos, endPos, t);
    }

    /// <inheritdoc cref="RaylibApi.GetSplinePointBasis" />
    public static Vector2 GetSplinePointBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t) {
        return RaylibApi.GetSplinePointBasis(p1, p2, p3, p4, t);
    }

    /// <inheritdoc cref="RaylibApi.GetSplinePointCatmullRom" />
    public static Vector2 GetSplinePointCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t) {
        return RaylibApi.GetSplinePointCatmullRom(p1, p2, p3, p4, t);
    }

    /// <inheritdoc cref="RaylibApi.GetSplinePointBezierQuad" />
    public static Vector2 GetSplinePointBezierQuad(Vector2 p1, Vector2 c2, Vector2 p3, float t) {
        return RaylibApi.GetSplinePointBezierQuad(p1, c2, p3, t);
    }

    /// <inheritdoc cref="RaylibApi.GetSplinePointBezierCubic" />
    public static Vector2 GetSplinePointBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float t) {
        return RaylibApi.GetSplinePointBezierCubic(p1, c2, c3, p4, t);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionRecs" />
    public static bool CheckCollisionRecs(Rectangle rec1, Rectangle rec2) {
        return RaylibApi.CheckCollisionRecs(rec1, rec2);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionCircles" />
    public static bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2) {
        return RaylibApi.CheckCollisionCircles(center1, radius1, center2, radius2);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionCircleRec" />
    public static bool CheckCollisionCircleRec(Vector2 center, float radius, Rectangle rec) {
        return RaylibApi.CheckCollisionCircleRec(center, radius, rec);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionPointRec" />
    public static bool CheckCollisionPointRec(Vector2 point, Rectangle rec) {
        return RaylibApi.CheckCollisionPointRec(point, rec);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionPointCircle" />
    public static bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius) {
        return RaylibApi.CheckCollisionPointCircle(point, center, radius);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionPointTriangle" />
    public static bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3) {
        return RaylibApi.CheckCollisionPointTriangle(point, p1, p2, p3);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionPointPoly" />
    public static unsafe bool CheckCollisionPointPoly(Vector2 point, Span<Vector2> points) {
        fixed (Vector2* pointsPtr = points) {
            return RaylibApi.CheckCollisionPointPoly(point, pointsPtr, points.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionLines" />
    public static bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2,
        ref Vector2 collisionPoint) {
        return RaylibApi.CheckCollisionLines(startPos1, endPos1, startPos2, endPos2, ref collisionPoint);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionPointLine" />
    public static bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold) {
        return RaylibApi.CheckCollisionPointLine(point, p1, p2, threshold);
    }

    /// <inheritdoc cref="RaylibApi.CheckCollisionCircleLine" />
    public static bool CheckCollisionCircleLine(Vector2 center, float radius, Vector2 p1, Vector2 p2) {
        return RaylibApi.CheckCollisionCircleLine(center, radius, p1, p2);
    }

    /// <inheritdoc cref="RaylibApi.GetCollisionRec" />
    public static Rectangle GetCollisionRec(Rectangle rec1, Rectangle rec2) {
        return RaylibApi.GetCollisionRec(rec1, rec2);
    }
}