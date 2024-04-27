using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp;

public static partial class RayMath {
    
    public const float Deg2Rad = MathF.PI / 180.0f;
    public const float Rad2Deg = 180.0f / MathF.PI;

    /// <summary>
    /// Clamp float value.
    /// </summary>
    /// <param name="value">The value to clamp.</param>
    /// <param name="min">The minimum value allowed.</param>
    /// <param name="max">The maximum value allowed.</param>
    /// <returns>The clamped value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Clamp(float value, float min, float max);

    /// <summary>
    /// Calculate linear interpolation between two floats.
    /// </summary>
    /// <param name="start">The start value.</param>
    /// <param name="end">The end value.</param>
    /// <param name="amount">The interpolation amount, usually between 0 and 1.</param>
    /// <returns>The interpolated value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Lerp(float start, float end, float amount);

    /// <summary>
    /// Normalize input value within input range.
    /// </summary>
    /// <param name="value">The value to normalize.</param>
    /// <param name="start">The minimum value of the range.</param>
    /// <param name="end">The maximum value of the range.</param>
    /// <returns>The normalized value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Normalize(float value, float start, float end);

    /// <summary>
    /// Remap input value within input range to output range.
    /// </summary>
    /// <param name="value">The value to remap.</param>
    /// <param name="inputStart">The start of the input range.</param>
    /// <param name="inputEnd">The end of the input range.</param>
    /// <param name="outputStart">The start of the output range.</param>
    /// <param name="outputEnd">The end of the output range.</param>
    /// <returns>The remapped value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Remap(float value, float inputStart, float inputEnd, float outputStart, float outputEnd);

    /// <summary>
    /// Wrap input value from min to max.
    /// </summary>
    /// <param name="value">The value to wrap.</param>
    /// <param name="min">The minimum value allowed.</param>
    /// <param name="max">The maximum value allowed.</param>
    /// <returns>The wrapped value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Wrap(float value, float min, float max);

    /// <summary>
    /// Check whether two given floats are almost equal.
    /// </summary>
    /// <param name="x">The first float value to compare.</param>
    /// <param name="y">The second float value to compare.</param>
    /// <returns>True if the two float values are equal, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int FloatEquals(float x, float y);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Zero();
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2One();
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Add(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2AddValue(Vector2 v, float add);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Subtract(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2SubtractValue(Vector2 v, float sub);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector2Length(Vector2 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector2LengthSqr(Vector2 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector2DotProduct(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector2Distance(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector2DistanceSqr(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector2Angle(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector2LineAngle(Vector2 start, Vector2 end);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Scale(Vector2 v, float scale);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Multiply(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Negate(Vector2 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Divide(Vector2 v1, Vector2 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Normalize(Vector2 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Transform(Vector2 v, Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Lerp(Vector2 v1, Vector2 v2, float amount);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Reflect(Vector2 v, Vector2 normal);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Rotate(Vector2 v, float angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2MoveTowards(Vector2 v, Vector2 target, float maxDistance);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Invert(Vector2 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2Clamp(Vector2 v, Vector2 min, Vector2 max);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 Vector2ClampValue(Vector2 v, float min, float max);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int Vector2Equals(Vector2 p, Vector2 q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Zero();
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3One();
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Add(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3AddValue(Vector3 v, float add);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Subtract(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3SubtractValue(Vector3 v, float sub);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Scale(Vector3 v, float scalar);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Multiply(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3CrossProduct(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Perpendicular(Vector3 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector3Length(Vector3 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector3LengthSqr(Vector3 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector3DotProduct(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector3Distance(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector3DistanceSqr(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float Vector3Angle(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Negate(Vector3 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Divide(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Normalize(Vector3 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Project(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Reject(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void Vector3OrthoNormalize(ref Vector3 v1, ref Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Transform(Vector3 v, Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3RotateByQuaternion(Vector3 v, Quaternion q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3RotateByAxisAngle(Vector3 v, Vector3 axis, float angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Lerp(Vector3 v1, Vector3 v2, float amount);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Reflect(Vector3 v, Vector3 normal);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Min(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Max(Vector3 v1, Vector3 v2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Barycenter(Vector3 p, Vector3 a, Vector3 b, Vector3 c);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Unproject(Vector3 source, Matrix4x4 projection, Matrix4x4 view);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Invert(Vector3 v);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Clamp(Vector3 v, Vector3 min, Vector3 max);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3ClampValue(Vector3 v, float min, float max);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int Vector3Equals(Vector3 p, Vector3 q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 Vector3Refract(Vector3 v, Vector3 n, float r);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float MatrixDeterminant(Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float MatrixTrace(Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixTranspose(Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixInvert(Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixIdentity();
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixAdd(Matrix4x4 left, Matrix4x4 right);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixSubtract(Matrix4x4 left, Matrix4x4 right);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixMultiply(Matrix4x4 left, Matrix4x4 right);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixTranslate(float x, float y, float z);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixRotate(Vector3 axis, float angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixRotateX(float angle);

    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixRotateY(float angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixRotateZ(float angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixRotateXYZ(Vector3 angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixRotateZYX(Vector3 angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixScale(float x, float y, float z);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixFrustum(double left, double right, double bottom, double top, double near, double far);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixPerspective(double fovY, double aspect, double nearPlane, double farPlane);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixOrtho(double left, double right, double bottom, double top, double nearPlane, double farPlane);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 MatrixLookAt(Vector3 eye, Vector3 target, Vector3 up);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionAdd(Quaternion q1, Quaternion q2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionAddValue(Quaternion q, float add);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionSubtract(Quaternion q1, Quaternion q2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionSubtractValue(Quaternion q, float sub);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionIdentity();
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float QuaternionLength(Quaternion q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionNormalize(Quaternion q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionInvert(Quaternion q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionMultiply(Quaternion q1, Quaternion q2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionScale(Quaternion q, float mul);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionDivide(Quaternion q1, Quaternion q2);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionLerp(Quaternion q1, Quaternion q2, float amount);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionNlerp(Quaternion q1, Quaternion q2, float amount);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionSlerp(Quaternion q1, Quaternion q2, float amount);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionFromVector3ToVector3(Vector3 from, Vector3 to);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionFromMatrix(Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 QuaternionToMatrix(Quaternion q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionFromAxisAngle(Vector3 axis, float angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void QuaternionToAxisAngle(Quaternion q, out Vector3 axis, out float angle);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionFromEuler(float pitch, float yaw, float roll);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 QuaternionToEuler(Quaternion q);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Quaternion QuaternionTransform(Quaternion q, Matrix4x4 mat);
    
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int QuaternionEquals(Quaternion p, Quaternion q);
}