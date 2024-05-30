using System.Numerics;
using Raylib_CSharp.Camera.Cam2D;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Materials;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Apis;
using Raylib_CSharp.Vr;
using Color = Raylib_CSharp.Colors.Color;

namespace Raylib_CSharp.Rendering;

public static class Graphics {

    /// <inheritdoc cref="RaylibApi.ClearBackground" />
    public static void ClearBackground(Color color) {
        RaylibApi.ClearBackground(color);
    }

    /// <inheritdoc cref="RaylibApi.BeginDrawing" />
    public static void BeginDrawing() {
        RaylibApi.BeginDrawing();
    }

    /// <inheritdoc cref="RaylibApi.EndDrawing" />
    public static void EndDrawing() {
        RaylibApi.EndDrawing();
    }

    /// <inheritdoc cref="RaylibApi.BeginMode2D" />
    public static void BeginMode2D(Camera2D camera) {
        RaylibApi.BeginMode2D(camera);
    }

    /// <inheritdoc cref="RaylibApi.EndMode2D" />
    public static void EndMode2D() {
        RaylibApi.EndMode2D();
    }

    /// <inheritdoc cref="RaylibApi.BeginMode3D" />
    public static void BeginMode3D(Camera3D camera) {
        RaylibApi.BeginMode3D(camera);
    }

    /// <inheritdoc cref="RaylibApi.EndMode3D" />
    public static void EndMode3D() {
        RaylibApi.EndMode3D();
    }

    /// <inheritdoc cref="RaylibApi.BeginTextureMode" />
    public static void BeginTextureMode(RenderTexture2D target) {
        RaylibApi.BeginTextureMode(target);
    }

    /// <inheritdoc cref="RaylibApi.EndTextureMode" />
    public static void EndTextureMode() {
        RaylibApi.EndTextureMode();
    }

    /// <inheritdoc cref="RaylibApi.BeginShaderMode" />
    public static void BeginShaderMode(Shader shader) {
        RaylibApi.BeginShaderMode(shader);
    }

    /// <inheritdoc cref="RaylibApi.EndShaderMode" />
    public static void EndShaderMode() {
        RaylibApi.EndShaderMode();
    }

    /// <inheritdoc cref="RaylibApi.BeginBlendMode" />
    public static void BeginBlendMode(BlendMode mode) {
        RaylibApi.BeginBlendMode(mode);
    }

    /// <inheritdoc cref="RaylibApi.EndBlendMode" />
    public static void EndBlendMode() {
        RaylibApi.EndBlendMode();
    }

    /// <inheritdoc cref="RaylibApi.BeginScissorMode" />
    public static void BeginScissorMode(int x, int y, int width, int height) {
        RaylibApi.BeginScissorMode(x, y, width, height);
    }

    /// <inheritdoc cref="RaylibApi.EndScissorMode" />
    public static void EndScissorMode() {
        RaylibApi.EndScissorMode();
    }

    /// <inheritdoc cref="RaylibApi.BeginVrStereoMode" />
    public static void BeginVrStereoMode(VrStereoConfig config) {
        RaylibApi.BeginVrStereoMode(config);
    }

    /// <inheritdoc cref="RaylibApi.EndVrStereoMode" />
    public static void EndVrStereoMode() {
        RaylibApi.EndVrStereoMode();
    }

    /// <inheritdoc cref="RaylibApi.SwapScreenBuffer" />
    public static void SwapScreenBuffer() {
        RaylibApi.SwapScreenBuffer();
    }

    /* --------------------------------- Text Drawing --------------------------------- */

    /// <inheritdoc cref="RaylibApi.DrawFPS" />
    public static void DrawFPS(int posX, int posY) {
        RaylibApi.DrawFPS(posX, posY);
    }

    /// <inheritdoc cref="RaylibApi.DrawText" />
    public static void DrawText(string text, int posX, int posY, int fontSize, Color color) {
        RaylibApi.DrawText(text, posX, posY, fontSize, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextEx" />
    public static void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint) {
        RaylibApi.DrawTextEx(font, text, position, fontSize, spacing, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextPro" />
    public static void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint) {
        RaylibApi.DrawTextPro(font, text, position, origin, rotation, fontSize, spacing, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextCodepoint" />
    public static void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint) {
        RaylibApi.DrawTextCodepoint(font, codepoint, position, fontSize, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextCodepoints" />
    public static unsafe void DrawTextCodepoints(Font font, ReadOnlySpan<int> codepoints, Vector2 position, float fontSize, float spacing, Color tint) {
        fixed (int* codepointsPtr = codepoints) {
            RaylibApi.DrawTextCodepoints(font, codepointsPtr, codepoints.Length, position, fontSize, spacing, tint);
        }
    }

    /* --------------------------------- Mesh Drawing --------------------------------- */

    /// <inheritdoc cref="RaylibApi.DrawMesh" />
    public static void DrawMesh(Mesh mesh, Material material, Matrix4x4 transform) {
        RaylibApi.DrawMesh(mesh, material, transform);
    }

    /// <inheritdoc cref="RaylibApi.DrawMeshInstanced" />
    public static unsafe void DrawMeshInstanced(Mesh mesh, Material material, Span<Matrix4x4> transforms) {
        fixed (Matrix4x4* transformsPtr = transforms) {
            RaylibApi.DrawMeshInstanced(mesh, material, transformsPtr, transforms.Length);
        }
    }

    /* --------------------------------- Model Drawing --------------------------------- */

    /// <inheritdoc cref="RaylibApi.DrawLine3D" />
    public static void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color) {
        RaylibApi.DrawLine3D(startPos, endPos, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawPoint3D" />
    public static void DrawPoint3D(Vector3 position, Color color) {
        RaylibApi.DrawPoint3D(position, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircle3D" />
    public static void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color) {
        RaylibApi.DrawCircle3D(center, radius, rotationAxis, rotationAngle, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawTriangle3D" />
    public static void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color) {
        RaylibApi.DrawTriangle3D(v1, v2, v3, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawTriangleStrip3D" />
    public static unsafe void DrawTriangleStrip3D(Span<Vector3> points, Color color) {
        fixed (Vector3* pointsPtr = points) {
            RaylibApi.DrawTriangleStrip3D(pointsPtr, points.Length, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawCube" />
    public static void DrawCube(Vector3 position, float width, float height, float length, Color color) {
        RaylibApi.DrawCube(position, width, height, length, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCubeV" />
    public static void DrawCubeV(Vector3 position, Vector3 size, Color color) {
        RaylibApi.DrawCubeV(position, size, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCubeWires" />
    public static void DrawCubeWires(Vector3 position, float width, float height, float length, Color color) {
        RaylibApi.DrawCubeWires(position, width, height, length, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCubeWiresV" />
    public static void DrawCubeWiresV(Vector3 position, Vector3 size, Color color) {
        RaylibApi.DrawCubeWiresV(position, size, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSphere" />
    public static void DrawSphere(Vector3 centerPos, float radius, Color color) {
        RaylibApi.DrawSphere(centerPos, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSphereEx" />
    public static void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color) {
        RaylibApi.DrawSphereEx(centerPos, radius, rings, slices, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSphereWires" />
    public static void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color) {
        RaylibApi.DrawSphereWires(centerPos, radius, rings, slices, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCylinder" />
    public static void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color) {
        RaylibApi.DrawCylinder(position, radiusTop, radiusBottom, height, slices, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCylinderEx" />
    public static void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color) {
        RaylibApi.DrawCylinderEx(startPos, endPos, startRadius, endRadius, sides, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCylinderWires" />
    public static void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color) {
        RaylibApi.DrawCylinderWires(position, radiusTop, radiusBottom, height, slices, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCylinderWiresEx" />
    public static void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color) {
        RaylibApi.DrawCylinderWiresEx(startPos, endPos, startRadius, endRadius, sides, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCapsule" />
    public static void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color) {
        RaylibApi.DrawCapsule(startPos, endPos, radius, slices, rings, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCapsuleWires" />
    public static void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color) {
        RaylibApi.DrawCapsuleWires(startPos, endPos, radius, slices, rings, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawPlane" />
    public static void DrawPlane(Vector3 centerPos, Vector2 size, Color color) {
        RaylibApi.DrawPlane(centerPos, size, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRay" />
    public static void DrawRay(Ray ray, Color color) {
        RaylibApi.DrawRay(ray, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawGrid" />
    public static void DrawGrid(int slices, float spacing) {
        RaylibApi.DrawGrid(slices, spacing);
    }

    /// <inheritdoc cref="RaylibApi.DrawModel" />
    public static void DrawModel(Model model, Vector3 position, float scale, Color tint) {
        RaylibApi.DrawModel(model, position, scale, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawModelEx" />
    public static void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint) {
        RaylibApi.DrawModelEx(model, position, rotationAxis, rotationAngle, scale, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawModelWires" />
    public static void DrawModelWires(Model model, Vector3 position, float scale, Color tint) {
        RaylibApi.DrawModelWires(model, position, scale, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawModelWiresEx" />
    public static void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint) {
        RaylibApi.DrawModelWiresEx(model, position, rotationAxis, rotationAngle, scale, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawBoundingBox" />
    public static void DrawBoundingBox(BoundingBox box, Color color) {
        RaylibApi.DrawBoundingBox(box, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawBillboard" />
    public static void DrawBillboard(Camera3D camera, Texture2D texture, Vector3 position, float size, Color tint) {
        RaylibApi.DrawBillboard(camera, texture, position, size, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawBillboardRec" />
    public static void DrawBillboardRec(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector2 size, Color tint) {
        RaylibApi.DrawBillboardRec(camera, texture, source, position, size, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawBillboardPro" />
    public static void DrawBillboardPro(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint) {
        RaylibApi.DrawBillboardPro(camera, texture, source, position, up, size, origin, rotation, tint);
    }

    /* --------------------------------- Shape Drawing --------------------------------- */

    /// <inheritdoc cref="RaylibApi.DrawPixel" />
    public static void DrawPixel(int posX, int posY, Color color) {
        RaylibApi.DrawPixel(posX, posY, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawPixelV" />
    public static void DrawPixelV(Vector2 position, Color color) {
        RaylibApi.DrawPixelV(position, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawLine" />
    public static void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color) {
        RaylibApi.DrawLine(startPosX, startPosY, endPosX, endPosY, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawLineV" />
    public static void DrawLineV(Vector2 startPos, Vector2 endPos, Color color) {
        RaylibApi.DrawLineV(startPos, endPos, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawLineEx" />
    public static void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color) {
        RaylibApi.DrawLineEx(startPos, endPos, thick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawLineStrip" />
    public static unsafe void DrawLineStrip(Span<Vector2> points, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawLineStrip(pointsPtr, points.Length, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawLineBezier" />
    public static void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color) {
        RaylibApi.DrawLineBezier(startPos, endPos, thick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircle" />
    public static void DrawCircle(int centerX, int centerY, float radius, Color color) {
        RaylibApi.DrawCircle(centerX, centerY, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircleSector" />
    public static void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color) {
        RaylibApi.DrawCircleSector(center, radius, startAngle, endAngle, segments, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircleSectorLines" />
    public static void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color) {
        RaylibApi.DrawCircleSectorLines(center, radius, startAngle, endAngle, segments, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircleGradient" />
    public static void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2) {
        RaylibApi.DrawCircleGradient(centerX, centerY, radius, color1, color2);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircleV" />
    public static void DrawCircleV(Vector2 center, float radius, Color color) {
        RaylibApi.DrawCircleV(center, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircleLines" />
    public static void DrawCircleLines(int centerX, int centerY, float radius, Color color) {
        RaylibApi.DrawCircleLines(centerX, centerY, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawCircleLinesV" />
    public static void DrawCircleLinesV(Vector2 center, float radius, Color color) {
        RaylibApi.DrawCircleLinesV(center, radius, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawEllipse" />
    public static void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color) {
        RaylibApi.DrawEllipse(centerX, centerY, radiusH, radiusV, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawEllipseLines" />
    public static void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color) {
        RaylibApi.DrawEllipseLines(centerX, centerY, radiusH, radiusV, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRing" />
    public static void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color) {
        RaylibApi.DrawRing(center, innerRadius, outerRadius, startAngle, endAngle, segments, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRingLines" />
    public static void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color) {
        RaylibApi.DrawRingLines(center, innerRadius, outerRadius, startAngle, endAngle, segments, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangle" />
    public static void DrawRectangle(int posX, int posY, int width, int height, Color color) {
        RaylibApi.DrawRectangle(posX, posY, width, height, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleV" />
    public static void DrawRectangleV(Vector2 position, Vector2 size, Color color) {
        RaylibApi.DrawRectangleV(position, size, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleRec" />
    public static void DrawRectangleRec(Rectangle rec, Color color) {
        RaylibApi.DrawRectangleRec(rec, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectanglePro" />
    public static void DrawRectanglePro(Rectangle rec, Vector2 origin, float rotation, Color color) {
        RaylibApi.DrawRectanglePro(rec, origin, rotation, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleGradientV" />
    public static void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2) {
        RaylibApi.DrawRectangleGradientV(posX, posY, width, height, color1, color2);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleGradientH" />
    public static void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2) {
        RaylibApi.DrawRectangleGradientH(posX, posY, width, height, color1, color2);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleGradientEx" />
    public static void DrawRectangleGradientEx(Rectangle rec, Color col1, Color col2, Color col3, Color col4) {
        RaylibApi.DrawRectangleGradientEx(rec, col1, col2, col3, col4);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleLines" />
    public static void DrawRectangleLines(int posX, int posY, int width, int height, Color color) {
        RaylibApi.DrawRectangleLines(posX, posY, width, height, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleLinesEx" />
    public static void DrawRectangleLinesEx(Rectangle rec, float lineThick, Color color) {
        RaylibApi.DrawRectangleLinesEx(rec, lineThick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleRounded" />
    public static void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color) {
        RaylibApi.DrawRectangleRounded(rec, roundness, segments, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawRectangleRoundedLines" />
    public static void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color) {
        RaylibApi.DrawRectangleRoundedLines(rec, roundness, segments, lineThick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawTriangle" />
    public static void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color) {
        RaylibApi.DrawTriangle(v1, v2, v3, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawTriangleLines" />
    public static void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color) {
        RaylibApi.DrawTriangleLines(v1, v2, v3, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawTriangleFan" />
    public static unsafe void DrawTriangleFan(Span<Vector2> points, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawTriangleFan(pointsPtr, points.Length, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawTriangleStrip" />
    public static unsafe void DrawTriangleStrip(Span<Vector2> points, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawTriangleStrip(pointsPtr, points.Length, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawPoly" />
    public static void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color) {
        RaylibApi.DrawPoly(center, sides, radius, rotation, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawPolyLines" />
    public static void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color) {
        RaylibApi.DrawPolyLines(center, sides, radius, rotation, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawPolyLinesEx" />
    public static void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color) {
        RaylibApi.DrawPolyLinesEx(center, sides, radius, rotation, lineThick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineLinear" />
    public static unsafe void DrawSplineLinear(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawSplineLinear(pointsPtr, points.Length, thick, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineBasis" />
    public static unsafe void DrawSplineBasis(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawSplineBasis(pointsPtr, points.Length, thick, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineCatmullRom" />
    public static unsafe void DrawSplineCatmullRom(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawSplineCatmullRom(pointsPtr, points.Length, thick, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineBezierQuadratic" />
    public static unsafe void DrawSplineBezierQuadratic(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawSplineBezierQuadratic(pointsPtr, points.Length, thick, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineBezierCubic" />
    public static unsafe void DrawSplineBezierCubic(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            RaylibApi.DrawSplineBezierCubic(pointsPtr, points.Length, thick, color);
        }
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineSegmentLinear" />
    public static void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color) {
        RaylibApi.DrawSplineSegmentLinear(p1, p2, thick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineSegmentBasis" />
    public static void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color) {
        RaylibApi.DrawSplineSegmentBasis(p1, p2, p3, p4, thick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineSegmentCatmullRom" />
    public static void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color) {
        RaylibApi.DrawSplineSegmentCatmullRom(p1, p2, p3, p4, thick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineSegmentBezierQuadratic" />
    public static void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color) {
        RaylibApi.DrawSplineSegmentBezierQuadratic(p1, c2, p3, thick, color);
    }

    /// <inheritdoc cref="RaylibApi.DrawSplineSegmentBezierCubic" />
    public static void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color) {
        RaylibApi.DrawSplineSegmentBezierCubic(p1, c2, c3, p4, thick, color);
    }

    /* --------------------------------- Texture Drawing --------------------------------- */

    /// <inheritdoc cref="RaylibApi.DrawTexture" />
    public static void DrawTexture(Texture2D texture, int posX, int posY, Color tint) {
        RaylibApi.DrawTexture(texture, posX, posY, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextureV" />
    public static void DrawTextureV(Texture2D texture, Vector2 position, Color tint) {
        RaylibApi.DrawTextureV(texture, position, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextureEx" />
    public static void DrawTextureEx(Texture2D texture, Vector2 position, float rotation, float scale, Color tint) {
        RaylibApi.DrawTextureEx(texture, position, rotation, scale, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextureRec" />
    public static void DrawTextureRec(Texture2D texture, Rectangle source, Vector2 position, Color tint) {
        RaylibApi.DrawTextureRec(texture, source, position, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTexturePro" />
    public static void DrawTexturePro(Texture2D texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint) {
        RaylibApi.DrawTexturePro(texture, source, dest, origin, rotation, tint);
    }

    /// <inheritdoc cref="RaylibApi.DrawTextureNPatch" />
    public static void DrawTextureNPatch(Texture2D texture, NPatchInfo nPatchInfo, Rectangle dest, Vector2 origin, float rotation, Color tint) {
        RaylibApi.DrawTextureNPatch(texture, nPatchInfo, dest, origin, rotation, tint);
    }
}