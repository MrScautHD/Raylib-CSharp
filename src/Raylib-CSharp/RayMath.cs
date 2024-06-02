using System.Numerics;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp;

public static class RayMath {

    public const float Deg2Rad = MathF.PI / 180.0f;
    public const float Rad2Deg = 180.0f / MathF.PI;

    /// <inheritdoc cref="RayMathApi.Clamp" />
    public static float Clamp(float value, float min, float max) {
        return RayMathApi.Clamp(value, min, max);
    }

    /// <inheritdoc cref="RayMathApi.Lerp" />
    public static float Lerp(float start, float end, float amount) {
        return RayMathApi.Lerp(start, end, amount);
    }

    /// <inheritdoc cref="RayMathApi.Normalize" />
    public static float Normalize(float value, float start, float end) {
        return RayMathApi.Normalize(value, start, end);
    }

    /// <inheritdoc cref="RayMathApi.Remap" />
    public static float Remap(float value, float inputStart, float inputEnd, float outputStart, float outputEnd) {
        return RayMathApi.Remap(value, inputStart, inputEnd, outputStart, outputEnd);
    }

    /// <inheritdoc cref="RayMathApi.Wrap" />
    public static float Wrap(float value, float min, float max) {
        return RayMathApi.Wrap(value, min, max);
    }

    /// <inheritdoc cref="RayMathApi.FloatEquals" />
    public static int FloatEquals(float x, float y) {
        return RayMathApi.FloatEquals(x, y);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Zero" />
    public static Vector2 Vector2Zero() {
        return RayMathApi.Vector2Zero();
    }

    /// <inheritdoc cref="RayMathApi.Vector2One" />
    public static Vector2 Vector2One() {
        return RayMathApi.Vector2One();
    }

    /// <inheritdoc cref="RayMathApi.Vector2Add" />
    public static Vector2 Vector2Add(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Add(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2AddValue" />
    public static Vector2 Vector2AddValue(Vector2 v, float add) {
        return RayMathApi.Vector2AddValue(v, add);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Subtract" />
    public static Vector2 Vector2Subtract(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Subtract(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2SubtractValue" />
    public static Vector2 Vector2SubtractValue(Vector2 v, float sub) {
        return RayMathApi.Vector2SubtractValue(v, sub);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Length" />
    public static float Vector2Length(Vector2 v) {
        return RayMathApi.Vector2Length(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector2LengthSqr" />
    public static float Vector2LengthSqr(Vector2 v) {
        return RayMathApi.Vector2LengthSqr(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector2DotProduct" />
    public static float Vector2DotProduct(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2DotProduct(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Distance" />
    public static float Vector2Distance(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Distance(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2DistanceSqr" />
    public static float Vector2DistanceSqr(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2DistanceSqr(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Angle" />
    public static float Vector2Angle(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Angle(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2LineAngle" />
    public static float Vector2LineAngle(Vector2 start, Vector2 end) {
        return RayMathApi.Vector2LineAngle(start, end);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Scale" />
    public static Vector2 Vector2Scale(Vector2 v, float scale) {
        return RayMathApi.Vector2Scale(v, scale);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Multiply" />
    public static Vector2 Vector2Multiply(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Multiply(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Negate" />
    public static Vector2 Vector2Negate(Vector2 v) {
        return RayMathApi.Vector2Negate(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Divide" />
    public static Vector2 Vector2Divide(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Divide(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Normalize" />
    public static Vector2 Vector2Normalize(Vector2 v) {
        return RayMathApi.Vector2Normalize(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Transform" />
    public static Vector2 Vector2Transform(Vector2 v, Matrix4x4 mat) {
        return RayMathApi.Vector2Transform(v, mat);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Lerp" />
    public static Vector2 Vector2Lerp(Vector2 v1, Vector2 v2, float amount) {
        return RayMathApi.Vector2Lerp(v1, v2, amount);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Reflect" />
    public static Vector2 Vector2Reflect(Vector2 v, Vector2 normal) {
        return RayMathApi.Vector2Reflect(v, normal);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Min" />
    public static Vector2 Vector2Min(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Min(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Max" />
    public static Vector2 Vector2Max(Vector2 v1, Vector2 v2) {
        return RayMathApi.Vector2Max(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Rotate" />
    public static Vector2 Vector2Rotate(Vector2 v, float angle) {
        return RayMathApi.Vector2Rotate(v, angle);
    }

    /// <inheritdoc cref="RayMathApi.Vector2MoveTowards" />
    public static Vector2 Vector2MoveTowards(Vector2 v, Vector2 target, float maxDistance) {
        return RayMathApi.Vector2MoveTowards(v, target, maxDistance);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Invert" />
    public static Vector2 Vector2Invert(Vector2 v) {
        return RayMathApi.Vector2Invert(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Clamp" />
    public static Vector2 Vector2Clamp(Vector2 v, Vector2 min, Vector2 max) {
        return RayMathApi.Vector2Clamp(v, min, max);
    }

    /// <inheritdoc cref="RayMathApi.Vector2ClampValue" />
    public static Vector2 Vector2ClampValue(Vector2 v, float min, float max) {
        return RayMathApi.Vector2ClampValue(v, min, max);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Equals" />
    public static int Vector2Equals(Vector2 p, Vector2 q) {
        return RayMathApi.Vector2Equals(p, q);
    }

    /// <inheritdoc cref="RayMathApi.Vector2Refract" />
    public static Vector2 Vector2Refract(Vector2 v, Vector2 n, float r) {
        return RayMathApi.Vector2Refract(v, n, r);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Zero" />
    public static Vector3 Vector3Zero() {
        return RayMathApi.Vector3Zero();
    }

    /// <inheritdoc cref="RayMathApi.Vector3One" />
    public static Vector3 Vector3One() {
        return RayMathApi.Vector3One();
    }

    /// <inheritdoc cref="RayMathApi.Vector3Add" />
    public static Vector3 Vector3Add(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Add(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3AddValue" />
    public static Vector3 Vector3AddValue(Vector3 v, float add) {
        return RayMathApi.Vector3AddValue(v, add);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Subtract" />
    public static Vector3 Vector3Subtract(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Subtract(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3SubtractValue" />
    public static Vector3 Vector3SubtractValue(Vector3 v, float sub) {
        return RayMathApi.Vector3SubtractValue(v, sub);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Scale" />
    public static Vector3 Vector3Scale(Vector3 v, float scalar) {
        return RayMathApi.Vector3Scale(v, scalar);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Multiply" />
    public static Vector3 Vector3Multiply(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Multiply(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3CrossProduct" />
    public static Vector3 Vector3CrossProduct(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3CrossProduct(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Perpendicular" />
    public static Vector3 Vector3Perpendicular(Vector3 v) {
        return RayMathApi.Vector3Perpendicular(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Length" />
    public static float Vector3Length(Vector3 v) {
        return RayMathApi.Vector3Length(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector3LengthSqr" />
    public static float Vector3LengthSqr(Vector3 v) {
        return RayMathApi.Vector3LengthSqr(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector3DotProduct" />
    public static float Vector3DotProduct(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3DotProduct(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Distance" />
    public static float Vector3Distance(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Distance(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3DistanceSqr" />
    public static float Vector3DistanceSqr(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3DistanceSqr(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Angle" />
    public static float Vector3Angle(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Angle(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Negate" />
    public static Vector3 Vector3Negate(Vector3 v) {
        return RayMathApi.Vector3Negate(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Divide" />
    public static Vector3 Vector3Divide(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Divide(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Normalize" />
    public static Vector3 Vector3Normalize(Vector3 v) {
        return RayMathApi.Vector3Normalize(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Project" />
    public static Vector3 Vector3Project(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Project(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Reject" />
    public static Vector3 Vector3Reject(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Reject(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3OrthoNormalize" />
    public static void Vector3OrthoNormalize(ref Vector3 v1, ref Vector3 v2) {
        RayMathApi.Vector3OrthoNormalize(ref v1, ref v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Transform" />
    public static Vector3 Vector3Transform(Vector3 v, Matrix4x4 mat) {
        return RayMathApi.Vector3Transform(v, mat);
    }

    /// <inheritdoc cref="RayMathApi.Vector3RotateByQuaternion" />
    public static Vector3 Vector3RotateByQuaternion(Vector3 v, Quaternion q) {
        return RayMathApi.Vector3RotateByQuaternion(v, q);
    }

    /// <inheritdoc cref="RayMathApi.Vector3RotateByAxisAngle" />
    public static Vector3 Vector3RotateByAxisAngle(Vector3 v, Vector3 axis, float angle) {
        return RayMathApi.Vector3RotateByAxisAngle(v, axis, angle);
    }

    /// <inheritdoc cref="RayMathApi.Vector3MoveTowards" />
    public static Vector3 Vector3MoveTowards(Vector3 v, Vector3 target, float maxDistance) {
        return RayMathApi.Vector3MoveTowards(v, target, maxDistance);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Lerp" />
    public static Vector3 Vector3Lerp(Vector3 v1, Vector3 v2, float amount) {
        return RayMathApi.Vector3Lerp(v1, v2, amount);
    }

    /// <inheritdoc cref="RayMathApi.Vector3CubicHermite" />
    public static Vector3 Vector3CubicHermite(Vector3 v1, Vector3 tangent1, Vector3 v2, Vector3 tangent2, float amount) {
        return RayMathApi.Vector3CubicHermite(v1, tangent1, v2, tangent2, amount);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Reflect" />
    public static Vector3 Vector3Reflect(Vector3 v, Vector3 normal) {
        return RayMathApi.Vector3Reflect(v, normal);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Min" />
    public static Vector3 Vector3Min(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Min(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Max" />
    public static Vector3 Vector3Max(Vector3 v1, Vector3 v2) {
        return RayMathApi.Vector3Max(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Barycenter" />
    public static Vector3 Vector3Barycenter(Vector3 p, Vector3 a, Vector3 b, Vector3 c) {
        return RayMathApi.Vector3Barycenter(p, a, b, c);
    }

    /// <inheritdoc cref="RayMathApi.Vector3UnProject" />
    public static Vector3 Vector3UnProject(Vector3 source, Matrix4x4 projection, Matrix4x4 view) {
        return RayMathApi.Vector3UnProject(source, projection, view);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Invert" />
    public static Vector3 Vector3Invert(Vector3 v) {
        return RayMathApi.Vector3Invert(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Clamp" />
    public static Vector3 Vector3Clamp(Vector3 v, Vector3 min, Vector3 max) {
        return RayMathApi.Vector3Clamp(v, min, max);
    }

    /// <inheritdoc cref="RayMathApi.Vector3ClampValue" />
    public static Vector3 Vector3ClampValue(Vector3 v, float min, float max) {
        return RayMathApi.Vector3ClampValue(v, min, max);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Equals" />
    public static int Vector3Equals(Vector3 p, Vector3 q) {
        return RayMathApi.Vector3Equals(p, q);
    }

    /// <inheritdoc cref="RayMathApi.Vector3Refract" />
    public static Vector3 Vector3Refract(Vector3 v, Vector3 n, float r) {
        return RayMathApi.Vector3Refract(v, n, r);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Zero" />
    public static Vector4 Vector4Zero() {
        return RayMathApi.Vector4Zero();
    }

    /// <inheritdoc cref="RayMathApi.Vector4One" />
    public static Vector4 Vector4One() {
        return RayMathApi.Vector4One();
    }

    /// <inheritdoc cref="RayMathApi.Vector4Add" />
    public static Vector4 Vector4Add(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4Add(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4AddValue" />
    public static Vector4 Vector4AddValue(Vector4 v, float add) {
        return RayMathApi.Vector4AddValue(v, add);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Subtract" />
    public static Vector4 Vector4Subtract(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4Subtract(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4SubtractValue" />
    public static Vector4 Vector4SubtractValue(Vector4 v, float sub) {
        return RayMathApi.Vector4SubtractValue(v, sub);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Length" />
    public static float Vector4Length(Vector4 v) {
        return RayMathApi.Vector4Length(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector4LengthSqr" />
    public static float Vector4LengthSqr(Vector4 v) {
        return RayMathApi.Vector4LengthSqr(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector4DotProduct" />
    public static float Vector4DotProduct(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4DotProduct(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Distance" />
    public static float Vector4Distance(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4Distance(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4DistanceSqr" />
    public static float Vector4DistanceSqr(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4DistanceSqr(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Scale" />
    public static Vector4 Vector4Scale(Vector4 v, float scale) {
        return RayMathApi.Vector4Scale(v, scale);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Multiply" />
    public static Vector4 Vector4Multiply(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4Multiply(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Negate" />
    public static Vector4 Vector4Negate(Vector4 v) {
        return RayMathApi.Vector4Negate(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Divide" />
    public static Vector4 Vector4Divide(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4Divide(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Normalize" />
    public static Vector4 Vector4Normalize(Vector4 v) {
        return RayMathApi.Vector4Normalize(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Min" />
    public static Vector4 Vector4Min(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4Min(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Max" />
    public static Vector4 Vector4Max(Vector4 v1, Vector4 v2) {
        return RayMathApi.Vector4Max(v1, v2);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Lerp" />
    public static Vector4 Vector4Lerp(Vector4 v1, Vector4 v2, float amount) {
        return RayMathApi.Vector4Lerp(v1, v2, amount);
    }

    /// <inheritdoc cref="RayMathApi.Vector4MoveTowards" />
    public static Vector4 Vector4MoveTowards(Vector4 v, Vector4 target, float maxDistance) {
        return RayMathApi.Vector4MoveTowards(v, target, maxDistance);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Invert" />
    public static Vector4 Vector4Invert(Vector4 v) {
        return RayMathApi.Vector4Invert(v);
    }

    /// <inheritdoc cref="RayMathApi.Vector4Equals" />
    public static int Vector4Equals(Vector4 p, Vector4 q) {
        return RayMathApi.Vector4Equals(p, q);
    }

    /// <inheritdoc cref="RayMathApi.MatrixDeterminant" />
    public static float MatrixDeterminant(Matrix4x4 mat) {
        return RayMathApi.MatrixDeterminant(mat);
    }

    /// <inheritdoc cref="RayMathApi.MatrixTrace" />
    public static float MatrixTrace(Matrix4x4 mat) {
        return RayMathApi.MatrixTrace(mat);
    }

    /// <inheritdoc cref="RayMathApi.MatrixTranspose" />
    public static Matrix4x4 MatrixTranspose(Matrix4x4 mat) {
        return RayMathApi.MatrixTranspose(mat);
    }

    /// <inheritdoc cref="RayMathApi.MatrixInvert" />
    public static Matrix4x4 MatrixInvert(Matrix4x4 mat) {
        return RayMathApi.MatrixInvert(mat);
    }

    /// <inheritdoc cref="RayMathApi.MatrixIdentity" />
    public static Matrix4x4 MatrixIdentity() {
        return RayMathApi.MatrixIdentity();
    }

    /// <inheritdoc cref="RayMathApi.MatrixAdd" />
    public static Matrix4x4 MatrixAdd(Matrix4x4 left, Matrix4x4 right) {
        return RayMathApi.MatrixAdd(left, right);
    }

    /// <inheritdoc cref="RayMathApi.MatrixSubtract" />
    public static Matrix4x4 MatrixSubtract(Matrix4x4 left, Matrix4x4 right) {
        return RayMathApi.MatrixSubtract(left, right);
    }

    /// <inheritdoc cref="RayMathApi.MatrixMultiply" />
    public static Matrix4x4 MatrixMultiply(Matrix4x4 left, Matrix4x4 right) {
        return RayMathApi.MatrixMultiply(left, right);
    }

    /// <inheritdoc cref="RayMathApi.MatrixTranslate" />
    public static Matrix4x4 MatrixTranslate(float x, float y, float z) {
        return RayMathApi.MatrixTranslate(x, y, z);
    }

    /// <inheritdoc cref="RayMathApi.MatrixRotate" />
    public static Matrix4x4 MatrixRotate(Vector3 axis, float angle) {
        return RayMathApi.MatrixRotate(axis, angle);
    }

    /// <inheritdoc cref="RayMathApi.MatrixRotateX" />
    public static Matrix4x4 MatrixRotateX(float angle) {
        return RayMathApi.MatrixRotateX(angle);
    }

    /// <inheritdoc cref="RayMathApi.MatrixRotateY" />
    public static Matrix4x4 MatrixRotateY(float angle) {
        return RayMathApi.MatrixRotateY(angle);
    }

    /// <inheritdoc cref="RayMathApi.MatrixRotateZ" />
    public static Matrix4x4 MatrixRotateZ(float angle) {
        return RayMathApi.MatrixRotateZ(angle);
    }

    /// <inheritdoc cref="RayMathApi.MatrixRotateXYZ" />
    public static Matrix4x4 MatrixRotateXYZ(Vector3 angle) {
        return RayMathApi.MatrixRotateXYZ(angle);
    }

    /// <inheritdoc cref="RayMathApi.MatrixRotateZYX" />
    public static Matrix4x4 MatrixRotateZYX(Vector3 angle) {
        return RayMathApi.MatrixRotateZYX(angle);
    }

    /// <inheritdoc cref="RayMathApi.MatrixScale" />
    public static Matrix4x4 MatrixScale(float x, float y, float z) {
        return RayMathApi.MatrixScale(x, y, z);
    }

    /// <inheritdoc cref="RayMathApi.MatrixFrustum" />
    public static Matrix4x4 MatrixFrustum(double left, double right, double bottom, double top, double near, double far) {
        return RayMathApi.MatrixFrustum(left, right, bottom, top, near, far);
    }

    /// <inheritdoc cref="RayMathApi.MatrixPerspective" />
    public static Matrix4x4 MatrixPerspective(double fovY, double aspect, double nearPlane, double farPlane) {
        return RayMathApi.MatrixPerspective(fovY, aspect, nearPlane, farPlane);
    }

    /// <inheritdoc cref="RayMathApi.MatrixOrtho" />
    public static Matrix4x4 MatrixOrtho(double left, double right, double bottom, double top, double nearPlane, double farPlane) {
        return RayMathApi.MatrixOrtho(left, right, bottom, top, nearPlane, farPlane);
    }

    /// <inheritdoc cref="RayMathApi.MatrixLookAt" />
    public static Matrix4x4 MatrixLookAt(Vector3 eye, Vector3 target, Vector3 up) {
        return RayMathApi.MatrixLookAt(eye, target, up);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionAdd" />
    public static Quaternion QuaternionAdd(Quaternion q1, Quaternion q2) {
        return RayMathApi.QuaternionAdd(q1, q2);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionAddValue" />
    public static Quaternion QuaternionAddValue(Quaternion q, float add) {
        return RayMathApi.QuaternionAddValue(q, add);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionSubtract" />
    public static Quaternion QuaternionSubtract(Quaternion q1, Quaternion q2) {
        return RayMathApi.QuaternionSubtract(q1, q2);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionSubtractValue" />
    public static Quaternion QuaternionSubtractValue(Quaternion q, float sub) {
        return RayMathApi.QuaternionSubtractValue(q, sub);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionIdentity" />
    public static Quaternion QuaternionIdentity() {
        return RayMathApi.QuaternionIdentity();
    }

    /// <inheritdoc cref="RayMathApi.QuaternionLength" />
    public static float QuaternionLength(Quaternion q) {
        return RayMathApi.QuaternionLength(q);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionNormalize" />
    public static Quaternion QuaternionNormalize(Quaternion q) {
        return RayMathApi.QuaternionNormalize(q);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionInvert" />
    public static Quaternion QuaternionInvert(Quaternion q) {
        return RayMathApi.QuaternionInvert(q);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionMultiply" />
    public static Quaternion QuaternionMultiply(Quaternion q1, Quaternion q2) {
        return RayMathApi.QuaternionMultiply(q1, q2);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionScale" />
    public static Quaternion QuaternionScale(Quaternion q, float mul) {
        return RayMathApi.QuaternionScale(q, mul);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionDivide" />
    public static Quaternion QuaternionDivide(Quaternion q1, Quaternion q2) {
        return RayMathApi.QuaternionDivide(q1, q2);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionLerp" />
    public static Quaternion QuaternionLerp(Quaternion q1, Quaternion q2, float amount) {
        return RayMathApi.QuaternionLerp(q1, q2, amount);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionNlerp" />
    public static Quaternion QuaternionNlerp(Quaternion q1, Quaternion q2, float amount) {
        return RayMathApi.QuaternionNlerp(q1, q2, amount);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionSlerp" />
    public static Quaternion QuaternionSlerp(Quaternion q1, Quaternion q2, float amount) {
        return RayMathApi.QuaternionSlerp(q1, q2, amount);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionCubicHermiteSpline" />
    public static Quaternion QuaternionCubicHermiteSpline(Quaternion q1, Quaternion outTangent1, Quaternion q2, Quaternion inTangent2, float t) {
        return RayMathApi.QuaternionCubicHermiteSpline(q1, outTangent1, q2, inTangent2, t);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionFromVector3ToVector3" />
    public static Quaternion QuaternionFromVector3ToVector3(Vector3 from, Vector3 to) {
        return RayMathApi.QuaternionFromVector3ToVector3(from, to);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionFromMatrix" />
    public static Quaternion QuaternionFromMatrix(Matrix4x4 mat) {
        return RayMathApi.QuaternionFromMatrix(mat);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionToMatrix" />
    public static Matrix4x4 QuaternionToMatrix(Quaternion q) {
        return RayMathApi.QuaternionToMatrix(q);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionFromAxisAngle" />
    public static Quaternion QuaternionFromAxisAngle(Vector3 axis, float angle) {
        return RayMathApi.QuaternionFromAxisAngle(axis, angle);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionToAxisAngle" />
    public static void QuaternionToAxisAngle(Quaternion q, out Vector3 axis, out float angle) {
        RayMathApi.QuaternionToAxisAngle(q, out axis, out angle);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionFromEuler" />
    public static Quaternion QuaternionFromEuler(float pitch, float yaw, float roll) {
        return RayMathApi.QuaternionFromEuler(pitch, yaw, roll);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionToEuler" />
    public static Vector3 QuaternionToEuler(Quaternion q) {
        return RayMathApi.QuaternionToEuler(q);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionTransform" />
    public static Quaternion QuaternionTransform(Quaternion q, Matrix4x4 mat) {
        return RayMathApi.QuaternionTransform(q, mat);
    }

    /// <inheritdoc cref="RayMathApi.QuaternionEquals" />
    public static int QuaternionEquals(Quaternion p, Quaternion q) {
        return RayMathApi.QuaternionEquals(p, q);
    }
}