using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Materials;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Color = Raylib_CSharp.Colors.Color;

namespace Raylib_CSharp.Geometry.Managers;

public static partial class ModelManager {

    /// <summary>
    /// Load model from files (meshes and materials).
    /// </summary>
    /// <param name="fileName">The name of the file containing the model.</param>
    /// <returns>The loaded model.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model LoadModel(string fileName);

    /// <summary>
    /// Load model from generated mesh (default material).
    /// </summary>
    /// <param name="mesh">The mesh object containing the model.</param>
    /// <returns>The loaded model.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model LoadModelFromMesh(Mesh mesh);

    /// <summary>
    /// Check if a model is ready.
    /// </summary>
    /// <param name="model">The model to check.</param>
    /// <returns>True if the model is ready, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsModelReady(Model model);

    /// <summary>
    /// Unload model (including meshes) from memory (RAM and/or VRAM).
    /// </summary>
    /// <param name="model">The model to be unloaded.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadModel(Model model);

    /// <summary>
    /// Compute model bounding box limits (considers all meshes).
    /// </summary>
    /// <param name="model">The model to get the bounding box from.</param>
    /// <returns>The bounding box of the model.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetModelBoundingBox(Model model);

    /// <summary>
    /// Set material for a mesh.
    /// </summary>
    /// <param name="model">The model to set the material for.</param>
    /// <param name="meshId">The ID of the mesh to set the material for.</param>
    /// <param name="materialId">The ID of the material to set for the mesh.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetModelMeshMaterial(ref Model model, int meshId, int materialId);

    /// <summary>
    /// Sets the shader for a specific material in the model.
    /// </summary>
    /// <param name="model">The model whose material needs to be modified.</param>
    /// <param name="materialIndex">The index of the material within the model.</param>
    /// <param name="shader">The shader to set for the material.</param>
    public static unsafe void SetMaterialShader(ref Model model, int materialIndex, Shader shader) {
        model.Materials[materialIndex].Shader = shader;
    }

    /// <summary>
    /// Sets the texture of a material map in a model.
    /// </summary>
    /// <param name="model">The model.</param>
    /// <param name="materialIndex">The index of the material.</param>
    /// <param name="mapIndex">The index of the material map.</param>
    /// <param name="texture">The texture to set.</param>
    public static unsafe void SetMaterialTexture(ref Model model, int materialIndex, MaterialMapIndex mapIndex, Texture2D texture) {
        model.Materials[materialIndex].Maps[(int) mapIndex].Texture = texture;
    }

    /// <summary>
    /// Sets the color of a material map for a specific model.
    /// </summary>
    /// <param name="model">The model to modify.</param>
    /// <param name="materialIndex">The index of the material within the model.</param>
    /// <param name="mapIndex">The index of the material map within the material.</param>
    /// <param name="color">The color to set for the material map.</param>
    public static unsafe void SetMaterialColor(ref Model model, int materialIndex, MaterialMapIndex mapIndex, Color color) {
        model.Materials[materialIndex].Maps[(int) mapIndex].Color = color;
    }

    /// <summary>
    /// Sets the value of a material map in a model.
    /// </summary>
    /// <param name="model">The model whose material map will be modified.</param>
    /// <param name="materialIndex">The index of the material containing the map.</param>
    /// <param name="mapIndex">The index of the material map to modify.</param>
    /// <param name="value">The new value to assign to the material map.</param>
    public static unsafe void SetMaterialValue(ref Model model, int materialIndex, MaterialMapIndex mapIndex, float value) {
        model.Materials[materialIndex].Maps[(int) mapIndex].Value = value;
    }

    /// <summary>
    /// Draw a line in 3D world space.
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color);

    /// <summary>
    /// Draw a point in 3D space, actually a small line.
    /// </summary>
    /// <param name="position">The position of the point in 3D space.</param>
    /// <param name="color">The color of the point.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoint3D(Vector3 position, Color color);

    /// <summary>
    /// Draw a circle in 3D world space.
    /// </summary>
    /// <param name="center">The center position of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="rotationAxis">The axis to rotate the circle around.</param>
    /// <param name="rotationAngle">The angle in degrees to rotate the circle around the rotation axis.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color);

    /// <summary>
    /// Draw a color-filled triangle (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the triangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">The points of the triangle.</param>
    /// <param name="pointCount">The count of the points.</param>
    /// <param name="color">The color to fill the triangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangle3D(Vector3* points, int pointCount, Color color);

    /// <summary>
    /// Draw cube.
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="width">The width of the cube.</param>
    /// <param name="height">The height of the cube.</param>
    /// <param name="length">The length of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCube(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube (Vector version).
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="size">The size of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw cube wires.
    /// </summary>
    /// <param name="position">The position of the cube in 3D space.</param>
    /// <param name="width">The width of the cube.</param>
    /// <param name="height">The height of the cube.</param>
    /// <param name="length">The length of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube wires (Vector version).
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="size">The size of the cube.</param>
    /// <param name="color">The color of the cube wires.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWiresV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw sphere.
    /// </summary>
    /// <param name="centerPos">The center position of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphere(Vector3 centerPos, float radius, Color color);

    /// <summary>
    /// Draw sphere with extended parameters.
    /// </summary>
    /// <param name="centerPos">The center position of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="rings">The number of rings in the sphere. The higher the number, the smoother the surface.</param>
    /// <param name="slices">The number of slices in the sphere. The higher the number, the more detailed the sphere is.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw sphere wires.
    /// </summary>
    /// <param name="centerPos">The position of the center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="rings">The number of horizontal rings that make up the sphere.</param>
    /// <param name="slices">The number of vertical slices that make up the sphere.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw a cylinder/cone.
    /// </summary>
    /// <param name="position">The position of the center of the cylinder.</param>
    /// <param name="radiusTop">The radius of the top surface of the cylinder.</param>
    /// <param name="radiusBottom">The radius of the bottom surface of the cylinder.</param>
    /// <param name="height">The height of the cylinder.</param>
    /// <param name="slices">The number of subdivisions around the circumference of the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder with base at startPos and top at endPos.
    /// </summary>
    /// <param name="startPos">The starting position of the cylinder.</param>
    /// <param name="endPos">The ending position of the cylinder.</param>
    /// <param name="startRadius">The radius of the cylinder at the starting position.</param>
    /// <param name="endRadius">The radius of the cylinder at the ending position.</param>
    /// <param name="sides">The number of sides (segments) that make up the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a cylinder/cone wires.
    /// </summary>
    /// <param name="position">The position of the center of the cylinder.</param>
    /// <param name="radiusTop">The radius of the top circle of the cylinder.</param>
    /// <param name="radiusBottom">The radius of the bottom circle of the cylinder.</param>
    /// <param name="height">The height of the cylinder.</param>
    /// <param name="slices">The number of slices used to create the cylinder.</param>
    /// <param name="color">The color of the wireframe.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder wires with base at startPos and top at endPos.
    /// </summary>
    /// <param name="startPos">The starting position of the cylinder.</param>
    /// <param name="endPos">The ending position of the cylinder.</param>
    /// <param name="startRadius">The radius of the cylinder at the starting position.</param>
    /// <param name="endRadius">The radius of the cylinder at the ending position.</param>
    /// <param name="sides">The number of sides of the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a capsule with the center of its sphere caps at startPos and endPos.
    /// </summary>
    /// <param name="startPos">The start position of the capsule.</param>
    /// <param name="endPos">The end position of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="slices">The number of slices used to form the capsule geometry.</param>
    /// <param name="rings">The number of rings used to form the capsule geometry.</param>
    /// <param name="color">The color of the capsule.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw capsule wireframe with the center of its sphere caps at startPos and endPos.
    /// </summary>
    /// <param name="startPos">The start position of the capsule.</param>
    /// <param name="endPos">The end position of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="slices">The number of slices used to draw the capsule.</param>
    /// <param name="rings">The number of rings used to draw the capsule.</param>
    /// <param name="color">The color of the capsule wires.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw a plane XZ.
    /// </summary>
    /// <param name="centerPos">The center position of the plane.</param>
    /// <param name="size">The size of the plane, specified as a 2D vector.</param>
    /// <param name="color">The color of the plane.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPlane(Vector3 centerPos, Vector2 size, Color color);

    /// <summary>
    /// Draw a ray line.
    /// </summary>
    /// <param name="ray">The ray to draw.</param>
    /// <param name="color">The color of the ray.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRay(Ray ray, Color color);

    /// <summary>
    /// Draw a grid (centered at (0, 0, 0)).
    /// </summary>
    /// <param name="slices">The number of subdivisions per side of the grid.</param>
    /// <param name="spacing">The spacing between grid lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawGrid(int slices, float spacing);

    /// <summary>
    /// Draw a model (with texture if set).
    /// </summary>
    /// <param name="model">The model to be drawn.</param>
    /// <param name="position">The position where the model should be drawn.</param>
    /// <param name="scale">The scaling factor to apply to the model.</param>
    /// <param name="tint">The color tint to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModel(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model with extended parameters.
    /// </summary>
    /// <param name="model">The model to be drawn.</param>
    /// <param name="position">The position of the model.</param>
    /// <param name="rotationAxis">The axis to rotate the model around.</param>
    /// <param name="rotationAngle">The angle of rotation in degrees.</param>
    /// <param name="scale">The scale factor applied to the model.</param>
    /// <param name="tint">The color tint to be applied to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set).
    /// </summary>
    /// <param name="model">The model to draw the wires of.</param>
    /// <param name="position">The position at which to draw the model.</param>
    /// <param name="scale">The scale at which to draw the model.</param>
    /// <param name="tint">The tint color to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWires(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set) with extended parameters.
    /// </summary>
    /// <param name="model">The model to draw.</param>
    /// <param name="position">The position to place the model.</param>
    /// <param name="rotationAxis">The rotation axis to apply to the model.</param>
    /// <param name="rotationAngle">The rotation angle to apply to the model.</param>
    /// <param name="scale">The scale to apply to the model.</param>
    /// <param name="tint">The color tint to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw bounding box (wires).
    /// </summary>
    /// <param name="box">The bounding box to draw.</param>
    /// <param name="color">The color of the bounding box.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBoundingBox(BoundingBox box, Color color);

    /// <summary>
    /// Draw a billboard texture.
    /// </summary>
    /// <param name="camera">The camera used for rendering.</param>
    /// <param name="texture">The texture to be drawn as a billboard.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="tint">The tint color of the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboard(Camera3D camera, Texture2D texture, Vector3 position, float size, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source.
    /// </summary>
    /// <param name="camera">The camera in 3D space.</param>
    /// <param name="texture">The texture of the billboard.</param>
    /// <param name="source">The source rectangle from the texture to be used for the billboard.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="tint">The tint color to be applied to the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardRec(Camera3D camera, Texture2D texture, RectangleF source, Vector3 position, Vector2 size, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source and rotation.
    /// </summary>
    /// <param name="camera">The camera used for drawing.</param>
    /// <param name="texture">The texture used for the billboard.</param>
    /// <param name="source">The source rectangle of the texture.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="up">The up direction of the billboard.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="origin">The origin of the billboard.</param>
    /// <param name="rotation">The rotation of the billboard.</param>
    /// <param name="tint">The color tint of the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardPro(Camera3D camera, Texture2D texture, RectangleF source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Check collision between two spheres.
    /// </summary>
    /// <param name="center1">The center position of the first sphere.</param>
    /// <param name="radius1">The radius of the first sphere.</param>
    /// <param name="center2">The center position of the second sphere.</param>
    /// <param name="radius2">The radius of the second sphere.</param>
    /// <returns>True if the two spheres collide, otherwise false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);

    /// <summary>
    /// Check collision between two bounding boxes.
    /// </summary>
    /// <param name="box1">The bounding box of the first sphere.</param>
    /// <param name="box2">The bounding box of the second sphere.</param>
    /// <returns>True if the spheres are colliding, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionSpheres(BoundingBox box1, BoundingBox box2);

    /// <summary>
    /// Check collision between box and sphere.
    /// </summary>
    /// <param name="box">The bounding box to check against.</param>
    /// <param name="center">The center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>True if the sphere collides with the bounding box, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CheckCollisionSpheres(BoundingBox box, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and sphere.
    /// </summary>
    /// <param name="ray">The ray used for collision.</param>
    /// <param name="center">The center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>The collision data between the ray and the sphere.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and box.
    /// </summary>
    /// <param name="ray">The ray to check collision with.</param>
    /// <param name="box">The bounding box to check collision with.</param>
    /// <returns>The collision between the ray and the bounding box.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionBox(Ray ray, BoundingBox box);

    /// <summary>
    /// Get collision info between ray and mesh.
    /// </summary>
    /// <param name="ray">The ray to perform the collision check with.</param>
    /// <param name="mesh">The mesh to check collision against.</param>
    /// <param name="transform">The transform to apply to the mesh before collision check.</param>
    /// <returns>The ray collision result.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, Matrix4x4 transform);

    /// <summary>
    /// Get collision info between ray and triangle.
    /// </summary>
    /// <param name="ray">The ray used to calculate collision.</param>
    /// <param name="p1">The first vertex of the triangle.</param>
    /// <param name="p2">The second vertex of the triangle.</param>
    /// <param name="p3">The third vertex of the triangle.</param>
    /// <returns>The collision information between the ray and the triangle.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3);

    /// <summary>
    /// Get collision info between ray and quad.
    /// </summary>
    /// <param name="ray">The ray to check for collision.</param>
    /// <param name="p1">The first point of the quad.</param>
    /// <param name="p2">The second point of the quad.</param>
    /// <param name="p3">The third point of the quad.</param>
    /// <param name="p4">The fourth point of the quad.</param>
    /// <returns>The collision information between the ray and the quad.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4);
}