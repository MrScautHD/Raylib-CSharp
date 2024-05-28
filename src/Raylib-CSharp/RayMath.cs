using Raylib_CSharp.Wrappers;
using System.Numerics;

namespace Raylib_CSharp;

public static class RayMath {

    public const float Deg2Rad = MathF.PI / 180.0f;
    public const float Rad2Deg = 180.0f / MathF.PI;

    /// <inheritdoc cref="RlMathWrapper.Clamp"/>
    public static float Clamp(float value, float min, float max) {
        return RlMathWrapper.Clamp(value, min, max);
    }

    /// <inheritdoc cref="RlMathWrapper.Lerp"/>
    public static float Lerp(float start, float end, float amount) {
        return RlMathWrapper.Lerp(start, end, amount);
    }

    /// <inheritdoc cref="RlMathWrapper.Normalize"/>
    public static float Normalize(float value, float start, float end) {
        return RlMathWrapper.Normalize(value, start, end);
    }

    /// <inheritdoc cref="RlMathWrapper.Remap"/>
    public static float Remap(float value, float inputStart, float inputEnd, float outputStart, float outputEnd) {
        return RlMathWrapper.Remap(value, inputStart, inputEnd, outputStart, outputEnd);
    }

    /// <inheritdoc cref="RlMathWrapper.Wrap"/>
    public static float Wrap(float value, float min, float max) {
        return RlMathWrapper.Wrap(value, min, max);
    }


    /// <inheritdoc cref="RlMathWrapper.Vector2Zero"/>
    public static Vector2 Vector2Zero() {
        return RlMathWrapper.Vector2Zero();
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2One"/>
    public static Vector2 Vector2One() {
        return RlMathWrapper.Vector2One();
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Add"/>
    public static Vector2 Vector2Add(Vector2 v1, Vector2 v2) {
        return RlMathWrapper.Vector2Add(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2AddValue"/>
    public static Vector2 Vector2AddValue(Vector2 v, float add) {
        return RlMathWrapper.Vector2AddValue(v, add);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Subtract"/>
    public static Vector2 Vector2Subtract(Vector2 v1, Vector2 v2) {
        return RlMathWrapper.Vector2Subtract(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2SubtractValue"/>
    public static Vector2 Vector2SubtractValue(Vector2 v, float sub) {
        return RlMathWrapper.Vector2SubtractValue(v, sub);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Length"/>
    public static float Vector2Length(Vector2 v) {
        return RlMathWrapper.Vector2Length(v);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2LengthSqr"/>
    public static float Vector2LengthSqr(Vector2 v) {
        return RlMathWrapper.Vector2LengthSqr(v);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2DotProduct"/>
    public static float Vector2DotProduct(Vector2 v1, Vector2 v2) {
        return RlMathWrapper.Vector2DotProduct(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Angle"/>
    public static float Vector2Angle(Vector2 v1, Vector2 v2) {
        return RlMathWrapper.Vector2Angle(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2LineAngle"/>
    public static float Vector2LineAngle(Vector2 start, Vector2 end) {
        return RlMathWrapper.Vector2LineAngle(start, end);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Scale"/>
    public static Vector2 Vector2Scale(Vector2 v, float scale) {
        return RlMathWrapper.Vector2Scale(v, scale);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Multiply"/>
    public static Vector2 Vector2Multiply(Vector2 v1, Vector2 v2) {
        return RlMathWrapper.Vector2Multiply(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Negate"/>
    public static Vector2 Vector2Negate(Vector2 v) {
        return RlMathWrapper.Vector2Negate(v);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Divide"/>
    public static Vector2 Vector2Divide(Vector2 v1, Vector2 v2) {
        return RlMathWrapper.Vector2Divide(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Normalize"/>
    public static Vector2 Vector2Normalize(Vector2 v) {
        return RlMathWrapper.Vector2Normalize(v);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Transform"/>
    public static Vector2 Vector2Transform(Vector2 v, Matrix4x4 mat) {
        return RlMathWrapper.Vector2Transform(v, mat);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Lerp"/>
    public static Vector2 Vector2Lerp(Vector2 v1, Vector2 v2, float amount) {
        return RlMathWrapper.Vector2Lerp(v1, v2, amount);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Reflect"/>
    public static Vector2 Vector2Reflect(Vector2 v, Vector2 normal) {
        return RlMathWrapper.Vector2Reflect(v, normal);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Rotate"/>
    public static Vector2 Vector2Rotate(Vector2 v, float angle) {
        return RlMathWrapper.Vector2Rotate(v, angle);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2MoveTowards"/>
    public static Vector2 Vector2MoveTowards(Vector2 v, Vector2 target, float maxDistance) {
        return RlMathWrapper.Vector2MoveTowards(v, target, maxDistance);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Invert"/>
    public static Vector2 Vector2Invert(Vector2 v) {
        return RlMathWrapper.Vector2Invert(v);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Clamp"/>
    public static Vector2 Vector2Clamp(Vector2 v, Vector2 min, Vector2 max) {
        return RlMathWrapper.Vector2Clamp(v, min, max);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2ClampValue"/>
    public static Vector2 Vector2ClampValue(Vector2 v, float min, float max) {
        return RlMathWrapper.Vector2ClampValue(v, min, max);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector2Equals"/>
    public static int Vector2Equals(Vector2 p, Vector2 q) {
        return RlMathWrapper.Vector2Equals(p, q);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Zero"/>
    public static Vector3 Vector3Zero() {
        return RlMathWrapper.Vector3Zero();
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3One"/>
    public static Vector3 Vector3One() {
        return RlMathWrapper.Vector3One();
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Add"/>
    public static Vector3 Vector3Add(Vector3 v1, Vector3 v2) {
        return RlMathWrapper.Vector3Add(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3AddValue"/>
    public static Vector3 Vector3AddValue(Vector3 v, float add) {
        return RlMathWrapper.Vector3AddValue(v, add);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Subtract"/>
    public static Vector3 Vector3Subtract(Vector3 v1, Vector3 v2) {
        return RlMathWrapper.Vector3Subtract(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3SubtractValue"/>
    public static Vector3 Vector3SubtractValue(Vector3 v, float sub) {
        return RlMathWrapper.Vector3SubtractValue(v, sub);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Scale"/>
    public static Vector3 Vector3Scale(Vector3 v, float scalar) {
        return RlMathWrapper.Vector3Scale(v, scalar);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Multiply"/>
    public static Vector3 Vector3Multiply(Vector3 v1, Vector3 v2) {
        return RlMathWrapper.Vector3Multiply(v1, v2);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3UnProject"/>
    public static Vector3 Vector3UnProject(Vector3 source, Matrix4x4 projection, Matrix4x4 view) {
        return RlMathWrapper.Vector3UnProject(source, projection, view);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Invert"/>
    public static Vector3 Vector3Invert(Vector3 v) {
        return RlMathWrapper.Vector3Invert(v);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Clamp"/>
    public static Vector3 Vector3Clamp(Vector3 v, Vector3 min, Vector3 max) {
        return RlMathWrapper.Vector3Clamp(v, min, max);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3ClampValue"/>
    public static Vector3 Vector3ClampValue(Vector3 v, float min, float max) {
        return RlMathWrapper.Vector3ClampValue(v, min, max);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Equals"/>
    public static int Vector3Equals(Vector3 p, Vector3 q) {
        return RlMathWrapper.Vector3Equals(p, q);
    }

    /// <inheritdoc cref="RlMathWrapper.Vector3Refract"/>
    public static Vector3 Vector3Refract(Vector3 v, Vector3 n, float r) {
        return RlMathWrapper.Vector3Refract(v, n, r);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixDeterminant"/>
    public static float MatrixDeterminant(Matrix4x4 mat) {
        return RlMathWrapper.MatrixDeterminant(mat);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixTrace"/>
    public static float MatrixTrace(Matrix4x4 mat) {
        return RlMathWrapper.MatrixTrace(mat);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixTranspose"/>
    public static Matrix4x4 MatrixTranspose(Matrix4x4 mat) {
        return RlMathWrapper.MatrixTranspose(mat);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixInvert"/>
    public static Matrix4x4 MatrixInvert(Matrix4x4 mat) {
        return RlMathWrapper.MatrixInvert(mat);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixIdentity"/>
    public static Matrix4x4 MatrixIdentity() {
        return RlMathWrapper.MatrixIdentity();
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixAdd"/>
    public static Matrix4x4 MatrixAdd(Matrix4x4 left, Matrix4x4 right) {
        return RlMathWrapper.MatrixAdd(left, right);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixSubtract"/>
    public static Matrix4x4 MatrixSubtract(Matrix4x4 left, Matrix4x4 right) {
        return RlMathWrapper.MatrixSubtract(left, right);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixMultiply"/>
    public static Matrix4x4 MatrixMultiply(Matrix4x4 left, Matrix4x4 right) {
        return RlMathWrapper.MatrixMultiply(left, right);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixTranslate"/>
    public static Matrix4x4 MatrixTranslate(float x, float y, float z) {
        return RlMathWrapper.MatrixTranslate(x, y, z);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixRotate"/>
    public static Matrix4x4 MatrixRotate(Vector3 axis, float angle) {
        return RlMathWrapper.MatrixRotate(axis, angle);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixRotateX"/>
    public static Matrix4x4 MatrixRotateX(float angle) {
        return RlMathWrapper.MatrixRotateX(angle);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixRotateY"/>
    public static Matrix4x4 MatrixRotateY(float angle) {
        return RlMathWrapper.MatrixRotateY(angle);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixRotateZ"/>
    public static Matrix4x4 MatrixRotateZ(float angle) {
        return RlMathWrapper.MatrixRotateZ(angle);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixRotateXYZ"/>
    public static Matrix4x4 MatrixRotateXYZ(Vector3 angle) {
        return RlMathWrapper.MatrixRotateXYZ(angle);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixRotateZYX"/>
    public static Matrix4x4 MatrixRotateZYX(Vector3 angle) {
        return RlMathWrapper.MatrixRotateZYX(angle);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixScale"/>
    public static Matrix4x4 MatrixScale(float x, float y, float z) {
        return RlMathWrapper.MatrixScale(x, y, z);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixFrustum"/>
    public static Matrix4x4 MatrixFrustum(double left, double right, double bottom, double top, double near, double far) {
        return RlMathWrapper.MatrixFrustum(left, right, bottom, top, near, far);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixPerspective"/>
    public static Matrix4x4 MatrixPerspective(double fovY, double aspect, double nearPlane, double farPlane) {
        return RlMathWrapper.MatrixPerspective(fovY, aspect, nearPlane, farPlane);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixOrtho"/>
    public static Matrix4x4 MatrixOrtho(double left, double right, double bottom, double top, double nearPlane, double farPlane) {
        return RlMathWrapper.MatrixOrtho(left, right, bottom, top, nearPlane, farPlane);
    }

    /// <inheritdoc cref="RlMathWrapper.MatrixLookAt"/>
    public static Matrix4x4 MatrixLookAt(Vector3 eye, Vector3 target, Vector3 up) {
        return RlMathWrapper.MatrixLookAt(eye, target, up);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionAdd"/>
    public static Quaternion QuaternionAdd(Quaternion q1, Quaternion q2) {
        return RlMathWrapper.QuaternionAdd(q1, q2);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionAddValue"/>
    public static Quaternion QuaternionAddValue(Quaternion q, float add) {
        return RlMathWrapper.QuaternionAddValue(q, add);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionSubtract"/>
    public static Quaternion QuaternionSubtract(Quaternion q1, Quaternion q2) {
        return RlMathWrapper.QuaternionSubtract(q1, q2);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionSubtractValue"/>
    public static Quaternion QuaternionSubtractValue(Quaternion q, float sub) {
        return RlMathWrapper.QuaternionSubtractValue(q, sub);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionIdentity"/>
    public static Quaternion QuaternionIdentity() {
        return RlMathWrapper.QuaternionIdentity();
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionLength"/>
    public static float QuaternionLength(Quaternion q) {
        return RlMathWrapper.QuaternionLength(q);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionNormalize"/>
    public static Quaternion QuaternionNormalize(Quaternion q) {
        return RlMathWrapper.QuaternionNormalize(q);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionInvert"/>
    public static Quaternion QuaternionInvert(Quaternion q) {
        return RlMathWrapper.QuaternionInvert(q);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionMultiply"/>
    public static Quaternion QuaternionMultiply(Quaternion q1, Quaternion q2) {
        return RlMathWrapper.QuaternionMultiply(q1, q2);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionScale"/>
    public static Quaternion QuaternionScale(Quaternion q, float mul) {
        return RlMathWrapper.QuaternionScale(q, mul);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionDivide"/>
    public static Quaternion QuaternionDivide(Quaternion q1, Quaternion q2) {
        return RlMathWrapper.QuaternionDivide(q1, q2);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionLerp"/>
    public static Quaternion QuaternionLerp(Quaternion q1, Quaternion q2, float amount) {
        return RlMathWrapper.QuaternionLerp(q1, q2, amount);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionNlerp"/>
    public static Quaternion QuaternionNlerp(Quaternion q1, Quaternion q2, float amount) {
        return RlMathWrapper.QuaternionNlerp(q1, q2, amount);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionSlerp"/>
    public static Quaternion QuaternionSlerp(Quaternion q1, Quaternion q2, float amount) {
        return RlMathWrapper.QuaternionSlerp(q1, q2, amount);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionFromVector3ToVector3"/>
    public static Quaternion QuaternionFromVector3ToVector3(Vector3 from, Vector3 to) {
        return RlMathWrapper.QuaternionFromVector3ToVector3(from, to);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionFromMatrix"/>
    public static Quaternion QuaternionFromMatrix(Matrix4x4 mat) {
        return RlMathWrapper.QuaternionFromMatrix(mat);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionToMatrix"/>
    public static Matrix4x4 QuaternionToMatrix(Quaternion q) {
        return RlMathWrapper.QuaternionToMatrix(q);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionFromAxisAngle"/>
    public static Quaternion QuaternionFromAxisAngle(Vector3 axis, float angle) {
        return RlMathWrapper.QuaternionFromAxisAngle(axis, angle);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionToAxisAngle"/>
    public static void QuaternionToAxisAngle(Quaternion q, out Vector3 axis, out float angle) {
        RlMathWrapper.QuaternionToAxisAngle(q, out axis, out angle);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionFromEuler"/>
    public static Quaternion QuaternionFromEuler(float roll, float pitch, float yaw) {
        return RlMathWrapper.QuaternionFromEuler(roll, pitch, yaw);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionToEuler"/>
    public static Vector3 QuaternionToEuler(Quaternion q) {
        return RlMathWrapper.QuaternionToEuler(q);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionTransform"/>
    public static Quaternion QuaternionTransform(Quaternion q, Matrix4x4 mat) {
        return RlMathWrapper.QuaternionTransform(q, mat);
    }

    /// <inheritdoc cref="RlMathWrapper.QuaternionEquals"/>
    public static int QuaternionEquals(Quaternion p, Quaternion q) {
        return RlMathWrapper.QuaternionEquals(p, q);
    }
}