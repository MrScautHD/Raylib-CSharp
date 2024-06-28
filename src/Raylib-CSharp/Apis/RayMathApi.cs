using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.Apis;

internal static partial class RayMathApi {

    /// <summary>
    /// Clamp float value.
    /// </summary>
    /// <param name="value">The value to clamp.</param>
    /// <param name="min">The minimum value allowed.</param>
    /// <param name="max">The maximum value allowed.</param>
    /// <returns>The clamped value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Clamp(float value, float min, float max);

    /// <summary>
    /// Calculate linear interpolation between two floats.
    /// </summary>
    /// <param name="start">The start value.</param>
    /// <param name="end">The end value.</param>
    /// <param name="amount">The interpolation amount, usually between 0 and 1.</param>
    /// <returns>The interpolated value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Lerp(float start, float end, float amount);

    /// <summary>
    /// Normalize input value within input range.
    /// </summary>
    /// <param name="value">The value to normalize.</param>
    /// <param name="start">The minimum value of the range.</param>
    /// <param name="end">The maximum value of the range.</param>
    /// <returns>The normalized value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Normalize(float value, float start, float end);

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
    internal static partial float Remap(float value, float inputStart, float inputEnd, float outputStart, float outputEnd);

    /// <summary>
    /// Wrap input value from min to max.
    /// </summary>
    /// <param name="value">The value to wrap.</param>
    /// <param name="min">The minimum value allowed.</param>
    /// <param name="max">The maximum value allowed.</param>
    /// <returns>The wrapped value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Wrap(float value, float min, float max);

    /// <summary>
    /// Check whether two given floats are almost equal.
    /// </summary>
    /// <param name="x">The first float value to compare.</param>
    /// <param name="y">The second float value to compare.</param>
    /// <returns>True if the two float values are equal, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int FloatEquals(float x, float y);

    /// <summary>
    /// Vector with components value 0.0f.
    /// </summary>
    /// <returns>A Vector2 with both components set to zero.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Zero();

    /// <summary>
    /// Vector with components value 1.0f.
    /// </summary>
    /// <returns>A Vector2 with both components set to 1.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2One();

    /// <summary>
    /// Add two vectors (v1 + v2).
    /// </summary>
    /// <param name="v1">The first Vector2 object to add.</param>
    /// <param name="v2">The second Vector2 object to add.</param>
    /// <returns>The sum of the two Vector2 objects.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Add(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Add vector and float value.
    /// </summary>
    /// <param name="v">The Vector2 to add the value to.</param>
    /// <param name="add">The scalar value to add.</param>
    /// <returns>A new Vector2 with the added value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2AddValue(Vector2 v, float add);

    /// <summary>
    /// Subtract two vectors (v1 - v2).
    /// </summary>
    /// <param name="v1">The first Vector2 object.</param>
    /// <param name="v2">The second Vector2 object.</param>
    /// <returns>The result of subtracting the components of v2 from v1.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Subtract(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Subtract vector by float value.
    /// </summary>
    /// <param name="v">The Vector2 to subtract the value from.</param>
    /// <param name="sub">The float value to subtract.</param>
    /// <returns>The resulting Vector2 after subtracting the value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2SubtractValue(Vector2 v, float sub);

    /// <summary>
    /// Calculate vector length.
    /// </summary>
    /// <param name="v">The 2D vector.</param>
    /// <returns>The length of the vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector2Length(Vector2 v);

    /// <summary>
    /// Calculate vector square length.
    /// </summary>
    /// <param name="v">The Vector2 to calculate the squared length of.</param>
    /// <returns>The squared length of the Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector2LengthSqr(Vector2 v);

    /// <summary>
    /// Calculate two vectors dot product.
    /// </summary>
    /// <param name="v1">The first Vector2.</param>
    /// <param name="v2">The second Vector2.</param>
    /// <returns>The dot product of the two Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector2DotProduct(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Calculate distance between two vectors.
    /// </summary>
    /// <param name="v1">The first Vector2 point.</param>
    /// <param name="v2">The second Vector2 point.</param>
    /// <returns>The distance between the two Vector2 points.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector2Distance(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Calculate square distance between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The squared distance between the two vectors.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector2DistanceSqr(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Calculate angle between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The angle between the two vectors (in radians).</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector2Angle(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Calculate angle defined by a two vectors line.
    /// </summary>
    /// <param name="start">The starting point of the line segment.</param>
    /// <param name="end">The ending point of the line segment.</param>
    /// <returns>The angle between the line segment and the positive x-axis, in radians.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector2LineAngle(Vector2 start, Vector2 end);

    /// <summary>
    /// Scale vector (multiply by value).
    /// </summary>
    /// <param name="v">The Vector2 to scale.</param>
    /// <param name="scale">The amount to scale the Vector2 by.</param>
    /// <returns>The scaled Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Scale(Vector2 v, float scale);

    /// <summary>
    /// Multiply vector by vector.
    /// </summary>
    /// <param name="v1">The first Vector2 value.</param>
    /// <param name="v2">The second Vector2 value.</param>
    /// <returns>A new Vector2 resulting from the component-wise multiplication of v1 and v2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Multiply(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Negate vector.
    /// </summary>
    /// <param name="v">The Vector2 to be negated.</param>
    /// <returns>The negated Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Negate(Vector2 v);

    /// <summary>
    /// Divide vector by vector.
    /// </summary>
    /// <param name="v1">The first Vector2 object to divide.</param>
    /// <param name="v2">The second Vector2 object to divide.</param>
    /// <returns>The resulting Vector2 object when dividing each corresponding element of v1 and v2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Divide(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Normalize provided vector.
    /// </summary>
    /// <param name="v">The Vector2 to normalize.</param>
    /// <returns>The normalized Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Normalize(Vector2 v);

    /// <summary>
    /// Transforms a Vector2 by a given Matrix4x4.
    /// </summary>
    /// <param name="v">The Vector2 to transform.</param>
    /// <param name="mat">The Matrix4x4 transformation matrix.</param>
    /// <returns>The transformed Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Transform(Vector2 v, Matrix4x4 mat);

    /// <summary>
    /// Calculate linear interpolation between two vectors.
    /// </summary>
    /// <param name="v1">The start vector.</param>
    /// <param name="v2">The end vector.</param>
    /// <param name="amount">The amount to interpolate between the two vectors.</param>
    /// <returns>The interpolated vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Lerp(Vector2 v1, Vector2 v2, float amount);

    /// <summary>
    /// Calculate reflected vector to normal.
    /// </summary>
    /// <param name="v">The vector to reflect.</param>
    /// <param name="normal">The normal vector.</param>
    /// <returns>The reflected vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Reflect(Vector2 v, Vector2 normal);

    /// <summary>
    /// Returns the component-wise minimum of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The component-wise minimum of the two vectors.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Min(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Returns the maximum values for each component of two Vector2 objects.
    /// </summary>
    /// <param name="v1">The first Vector2 object.</param>
    /// <param name="v2">The second Vector2 object.</param>
    /// <returns>A new Vector2 object with the maximum values for each component.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Max(Vector2 v1, Vector2 v2);

    /// <summary>
    /// Rotate vector by angle.
    /// </summary>
    /// <param name="v">The 2D vector to rotate.</param>
    /// <param name="angle">The angle (in radians) by which to rotate the vector.</param>
    /// <returns>The rotated 2D vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Rotate(Vector2 v, float angle);

    /// <summary>
    /// Move Vector towards target.
    /// </summary>
    /// <param name="v">The current position.</param>
    /// <param name="target">The target position to move towards.</param>
    /// <param name="maxDistance">The maximum distance the Vector2 can move towards the target.</param>
    /// <returns>The new Vector2 position after moving towards the target within the maximum distance.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2MoveTowards(Vector2 v, Vector2 target, float maxDistance);

    /// <summary>
    /// Invert the given vector.
    /// </summary>
    /// <param name="v">The Vector2 to invert.</param>
    /// <returns>The inverted Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Invert(Vector2 v);

    /// <summary>
    /// Clamp the components of the vector between.
    /// </summary>
    /// <param name="v">The Vector2 value to clamp.</param>
    /// <param name="min">The minimum Vector2 value allowed.</param>
    /// <param name="max">The maximum Vector2 value allowed.</param>
    /// <returns>The clamped Vector2 value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Clamp(Vector2 v, Vector2 min, Vector2 max);

    /// <summary>
    /// Clamp the magnitude of the vector between two min and max values.
    /// </summary>
    /// <param name="v">The Vector2 to clamp.</param>
    /// <param name="min">The minimum value allowed for X and Y.</param>
    /// <param name="max">The maximum value allowed for X and Y.</param>
    /// <returns>The clamped Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2ClampValue(Vector2 v, float min, float max);

    /// <summary>
    /// Check whether two given vectors are almost equal.
    /// </summary>
    /// <param name="p">The first Vector2 object.</param>
    /// <param name="q">The second Vector2 object.</param>
    /// <returns>True if the two Vector2 objects are equal; otherwise, false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int Vector2Equals(Vector2 p, Vector2 q);

    /// <summary>
    /// Compute the direction of a refracted ray.
    /// </summary>
    /// <param name="v">The incident vector.</param>
    /// <param name="n">The normal vector.</param>
    /// <param name="r">The refraction index.</param>
    /// <returns>The refraction vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector2 Vector2Refract(Vector2 v, Vector2 n, float r);

    /// <summary>
    /// Vector with components value 0.0f.
    /// </summary>
    /// <returns>A Vector3 with all components set to zero.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Zero();

    /// <summary>
    /// Vector with components value 1.0f.
    /// </summary>
    /// <returns>A <see cref="Vector3"/> with all components set to 1.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3One();

    /// <summary>
    /// Add two vectors.
    /// </summary>
    /// <param name="v1">The first Vector3.</param>
    /// <param name="v2">The second Vector3.</param>
    /// <returns>The sum of the two Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Add(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Add vector and float value.
    /// </summary>
    /// <param name="v">The Vector3 to add the value to.</param>
    /// <param name="add">The value to add.</param>
    /// <returns>The resulting Vector3 after adding the value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3AddValue(Vector3 v, float add);

    /// <summary>
    /// Subtract two vectors.
    /// </summary>
    /// <param name="v1">The first Vector3.</param>
    /// <param name="v2">The second Vector3.</param>
    /// <returns>The difference between the two vectors.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Subtract(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Subtract vector by float value.
    /// </summary>
    /// <param name="v">The Vector3 to subtract the value from.</param>
    /// <param name="sub">The value to subtract.</param>
    /// <returns>The resulting Vector3 after subtraction.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3SubtractValue(Vector3 v, float sub);

    /// <summary>
    /// Multiply vector by scalar.
    /// </summary>
    /// <param name="v">The vector to scale.</param>
    /// <param name="scalar">The scalar value to scale the vector by.</param>
    /// <returns>The scaled vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Scale(Vector3 v, float scalar);

    /// <summary>
    /// Multiply vector by vector.
    /// </summary>
    /// <param name="v1">The first Vector3.</param>
    /// <param name="v2">The second Vector3.</param>
    /// <returns>The result of component-wise multiplication.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Multiply(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Calculate two vectors cross product.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The cross product of <paramref name="v1"/> and <paramref name="v2"/>.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3CrossProduct(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Calculate one vector perpendicular vector.
    /// </summary>
    /// <param name="v">The input Vector3.</param>
    /// <returns>The perpendicular vector of the input Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Perpendicular(Vector3 v);

    /// <summary>
    /// Calculate vector length.
    /// </summary>
    /// <param name="v">The Vector3 to calculate the length of.</param>
    /// <returns>The length of the Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector3Length(Vector3 v);

    /// <summary>
    /// Calculate vector square length.
    /// </summary>
    /// <param name="v">The Vector3 to calculate the squared length of.</param>
    /// <returns>The squared length of the Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector3LengthSqr(Vector3 v);

    /// <summary>
    /// Calculate two vectors dot product.
    /// </summary>
    /// <param name="v1">The first Vector3.</param>
    /// <param name="v2">The second Vector3.</param>
    /// <returns>The dot product of the two Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector3DotProduct(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Calculate distance between two vectors.
    /// </summary>
    /// <param name="v1">The first Vector3 point.</param>
    /// <param name="v2">The second Vector3 point.</param>
    /// <returns>The distance between the two Vector3 points.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector3Distance(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Calculate square distance between two vectors.
    /// </summary>
    /// <param name="v1">The first Vector3.</param>
    /// <param name="v2">The second Vector3.</param>
    /// <returns>The squared distance between v1 and v2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector3DistanceSqr(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Calculate angle between two vectors.
    /// </summary>
    /// <param name="v1">The first Vector3.</param>
    /// <param name="v2">The second Vector3.</param>
    /// <returns>The angle between the two Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector3Angle(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Negate provided vector (invert direction).
    /// </summary>
    /// <param name="v">The vector to negate.</param>
    /// <returns>The negated vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Negate(Vector3 v);

    /// <summary>
    /// Divide vector by vector.
    /// </summary>
    /// <param name="v1">The first Vector3 value.</param>
    /// <param name="v2">The second Vector3 value.</param>
    /// <returns>The component-wise division of v1 and v2 as a new Vector3 value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Divide(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Normalize provided vector.
    /// </summary>
    /// <param name="v">The Vector3 to normalize.</param>
    /// <returns>The normalized Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Normalize(Vector3 v);

    /// <summary>
    /// Calculate the projection of the vector v1 on to v2.
    /// </summary>
    /// <param name="v1">The vector to be projected.</param>
    /// <param name="v2">The vector onto which v1 will be projected.</param>
    /// <returns>The resulting projected vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Project(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Calculate the rejection of the vector v1 on to v2.
    /// </summary>
    /// <param name="v1">The vector to be rejected.</param>
    /// <param name="v2">The vector to reject on.</param>
    /// <returns>The rejection vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Reject(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Orthonormalize provided vectors.
    /// Makes vectors normalized and orthogonal to each other.
    /// Gram-Schmidt function implementation.
    /// </summary>
    /// <param name="v1">The first vector to ortho-normalize.</param>
    /// <param name="v2">The second vector to ortho-normalize.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void Vector3OrthoNormalize(ref Vector3 v1, ref Vector3 v2);

    /// <summary>
    /// Transforms a Vector3 by a given Matrix4x4.
    /// </summary>
    /// <param name="v">The Vector3 to transform.</param>
    /// <param name="mat">The Matrix4x4 to transform the Vector3 by.</param>
    /// <returns>The transformed Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Transform(Vector3 v, Matrix4x4 mat);

    /// <summary>
    /// Transform a vector by quaternion rotation.
    /// </summary>
    /// <param name="v">The Vector3 to rotate.</param>
    /// <param name="q">The Quaternion by which to rotate the Vector3.</param>
    /// <returns>The rotated Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3RotateByQuaternion(Vector3 v, Quaternion q);

    /// <summary>
    /// Rotates a vector around an axis.
    /// </summary>
    /// <param name="v">The vector to rotate.</param>
    /// <param name="axis">The axis to rotate around.</param>
    /// <param name="angle">The angle of rotation in radians.</param>
    /// <returns>The rotated vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3RotateByAxisAngle(Vector3 v, Vector3 axis, float angle);

    /// <summary>
    /// Move Vector towards target.
    /// </summary>
    /// <param name="v">The current vector to move.</param>
    /// <param name="target">The target vector to move towards.</param>
    /// <param name="maxDistance">The maximum distance to move towards the target.</param>
    /// <returns>The new vector moved towards the target, limited to the maximum distance.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3MoveTowards(Vector3 v, Vector3 target, float maxDistance);

    /// <summary>
    /// Calculate linear interpolation between two vectors.
    /// </summary>
    /// <param name="v1">The start Vector3 value.</param>
    /// <param name="v2">The end Vector3 value.</param>
    /// <param name="amount">The interpolation amount between the two Vector3 values.</param>
    /// <returns>The interpolated Vector3 value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Lerp(Vector3 v1, Vector3 v2, float amount);

    /// <summary>
    /// Calculate cubic hermite interpolation between two vectors and their tangents.
    /// </summary>
    /// <param name="v1">The first 3D vector.</param>
    /// <param name="tangent1">The first 3D tangent vector.</param>
    /// <param name="v2">The second 3D vector.</param>
    /// <param name="tangent2">The second 3D tangent vector.</param>
    /// <param name="amount">The interpolation amount between the two vectors.</param>
    /// <returns>The interpolated vector. The resulting vector is a point along the Hermite spline.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3CubicHermite(Vector3 v1, Vector3 tangent1, Vector3 v2, Vector3 tangent2, float amount);

    /// <summary>
    /// Calculate reflected vector to normal.
    /// </summary>
    /// <param name="v">The vector to reflect.</param>
    /// <param name="normal">The normalized surface normal.</param>
    /// <returns>The reflected vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Reflect(Vector3 v, Vector3 normal);

    /// <summary>
    /// Get min value for each pair of components.
    /// </summary>
    /// <param name="v1">The first Vector3.</param>
    /// <param name="v2">The second Vector3.</param>
    /// <returns>The Vector3 with the minimum component values.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Min(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Get max value for each pair of components.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The component-wise maximum vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Max(Vector3 v1, Vector3 v2);

    /// <summary>
    /// Compute barycenter coordinates (u, v, w) for point p with respect to triangle (a, b, c).
    /// </summary>
    /// <param name="p">The point inside the triangle.</param>
    /// <param name="a">The first vertex of the triangle.</param>
    /// <param name="b">The second vertex of the triangle.</param>
    /// <param name="c">The third vertex of the triangle.</param>
    /// <returns>The barycenter of the triangle as a Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Barycenter(Vector3 p, Vector3 a, Vector3 b, Vector3 c);

    /// <summary>
    /// Projects a Vector3 from screen space into object space.
    /// </summary>
    /// <param name="source">The vector to unproject.</param>
    /// <param name="projection">The projection matrix.</param>
    /// <param name="view">The view matrix.</param>
    /// <returns>The unprojected vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3UnProject(Vector3 source, Matrix4x4 projection, Matrix4x4 view);

    /// <summary>
    /// Invert the given vector.
    /// </summary>
    /// <param name="v">The Vector3 to invert.</param>
    /// <returns>The inverted Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Invert(Vector3 v);

    /// <summary>
    /// Clamp the components of the vector between.
    /// min and max values specified by the given vectors.
    /// </summary>
    /// <param name="v">The Vector3 value to clamp.</param>
    /// <param name="min">The minimum Vector3 value allowed.</param>
    /// <param name="max">The maximum Vector3 value allowed.</param>
    /// <returns>The clamped Vector3 value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Clamp(Vector3 v, Vector3 min, Vector3 max);

    /// <summary>
    /// Clamp the magnitude of the vector between two values.
    /// </summary>
    /// <param name="v">The Vector3 to clamp.</param>
    /// <param name="min">The minimum value allowed.</param>
    /// <param name="max">The maximum value allowed.</param>
    /// <returns>A new Vector3 clamped to the specified range.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3ClampValue(Vector3 v, float min, float max);

    /// <summary>
    /// Check whether two given vectors are almost equal.
    /// </summary>
    /// <param name="p">The first Vector3 object to compare.</param>
    /// <param name="q">The second Vector3 object to compare.</param>
    /// <returns>Returns true if the two Vector3 objects are equal, otherwise returns false.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int Vector3Equals(Vector3 p, Vector3 q);

    /// <summary>
    /// Compute the direction of a refracted ray.
    /// </summary>
    /// <param name="v">The vector to be refracted.</param>
    /// <param name="n">The normal vector.</param>
    /// <param name="r">The refraction index.</param>
    /// <returns>The refracted vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 Vector3Refract(Vector3 v, Vector3 n, float r);

    /// <summary>
    /// Returns a Vector4 with all components set to zero.
    /// </summary>
    /// <returns>A Vector4 with all components set to zero.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Zero();

    /// <summary>
    /// Creates a new Vector4 initialized with all components set to 1.
    /// </summary>
    /// <returns>A Vector4 with all components set to 1.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4One();

    /// <summary>
    /// Adds two Vector4 together and returns the result.
    /// </summary>
    /// <param name="v1">The first Vector4.</param>
    /// <param name="v2">The second Vector4.</param>
    /// <returns>The sum of the two Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Add(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Adds a scalar value to all components of a Vector4.
    /// </summary>
    /// <param name="v">The Vector4 to modify.</param>
    /// <param name="add">The value to add to each component.</param>
    /// <returns>The result of adding the scalar value to each component of the Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4AddValue(Vector4 v, float add);

    /// <summary>
    /// Subtract two Vector4s.
    /// </summary>
    /// <param name="v1">The first Vector4.</param>
    /// <param name="v2">The second Vector4.</param>
    /// <returns>The result of subtracting v2 from v1.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Subtract(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Subtract a value from each component of a Vector4.
    /// </summary>
    /// <param name="v">The Vector4 to subtract the value from.</param>
    /// <param name="add">The value to subtract from each component.</param>
    /// <returns>A new Vector4 with the result of subtracting the value from each component of the input Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4SubtractValue(Vector4 v, float add);

    /// <summary>
    /// Calculates the length of a Vector4.
    /// </summary>
    /// <param name="v">The Vector4 to calculate the length of.</param>
    /// <returns>The length of the Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector4Length(Vector4 v);

    /// <summary>
    /// Calculates the squared length of a Vector4.
    /// </summary>
    /// <param name="v">The Vector4 to calculate the squared length of.</param>
    /// <returns>The squared length of the Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector4LengthSqr(Vector4 v);

    /// <summary>
    /// Calculates the dot product of two Vector4.
    /// </summary>
    /// <param name="v1">The first Vector4.</param>
    /// <param name="v2">The second Vector4.</param>
    /// <returns>The dot product of the two Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector4DotProduct(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Calculate distance between two vectors.
    /// </summary>
    /// <param name="v1">The first Vector4.</param>
    /// <param name="v2">The second Vector4.</param>
    /// <returns>The Euclidean distance between v1 and v2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector4Distance(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Calculate square distance between two vectors.
    /// </summary>
    /// <param name="v1">The first Vector4 point.</param>
    /// <param name="v2">The second Vector4 point.</param>
    /// <returns>The square of the distance between the two Vector4 points.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float Vector4DistanceSqr(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Scales a Vector4 by a scalar value.
    /// </summary>
    /// <param name="v">The Vector4 to scale.</param>
    /// <param name="scale">The scaling factor.</param>
    /// <returns>The scaled Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Scale(Vector4 v, float scale);

    /// <summary>
    /// Multiply vector by vector.
    /// </summary>
    /// <param name="v1">The first Vector4 value.</param>
    /// <param name="v2">The second Vector4 value.</param>
    /// <returns>The resulting multiplied Vector4 value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Multiply(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Negate vector.
    /// </summary>
    /// <param name="v">The Vector4 to negate.</param>
    /// <returns>The negated Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Negate(Vector4 v);

    /// <summary>
    /// Divide vector by vector.
    /// </summary>
    /// <param name="v1">The dividend Vector4.</param>
    /// <param name="v2">The divisor Vector4.</param>
    /// <returns>The result of dividing each element of v1 by the corresponding element of v2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Divide(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Normalize provided vector.
    /// </summary>
    /// <param name="v">The Vector4 to normalize.</param>
    /// <returns>The normalized Vector4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Normalize(Vector4 v);

    /// <summary>
    /// Get min value for each pair of components.
    /// </summary>
    /// <param name="v1">The first Vector4 value.</param>
    /// <param name="v2">The second Vector4 value.</param>
    /// <returns>The Vector4 with the minimum values from v1 and v2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Min(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Get max value for each pair of components.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The component-wise maximum vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Max(Vector4 v1, Vector4 v2);

    /// <summary>
    /// Calculate linear interpolation between two vectors.
    /// </summary>
    /// <param name="v1">The start vector.</param>
    /// <param name="v2">The end vector.</param>
    /// <param name="amount">The interpolation amount. Value should be between 0 and 1.</param>
    /// <returns>The interpolated vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Lerp(Vector4 v1, Vector4 v2, float amount);

    /// <summary>
    /// Move Vector towards target.
    /// </summary>
    /// <param name="v">The current vector.</param>
    /// <param name="target">The target vector to move towards.</param>
    /// <param name="maxDistance">The maximum magnitude of the movement.</param>
    /// <returns>The resulting vector after moving towards the target.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4MoveTowards(Vector4 v, Vector4 target, float maxDistance);

    /// <summary>
    /// Invert the given vector.
    /// </summary>
    /// <param name="v">The vector to invert.</param>
    /// <returns>The inverted vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector4 Vector4Invert(Vector4 v);

    /// <summary>
    /// Check whether two given vectors are almost equal.
    /// </summary>
    /// <param name="p">The first Vector4 object to compare.</param>
    /// <param name="q">The second Vector4 object to compare.</param>
    /// <returns>True if the two vectors are equal, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int Vector4Equals(Vector4 p, Vector4 q);

    /// <summary>
    /// Compute matrix determinant.
    /// </summary>
    /// <param name="mat">The 4x4 matrix.</param>
    /// <returns>The determinant of the matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float MatrixDeterminant(Matrix4x4 mat);

    /// <summary>
    /// Get the trace of the matrix (sum of the values along the diagonal).
    /// </summary>
    /// <param name="mat">The 4x4 matrix.</param>
    /// <returns>The sum of the elements on the main diagonal of the matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float MatrixTrace(Matrix4x4 mat);

    /// <summary>
    /// Transposes provided matrix.
    /// </summary>
    /// <param name="mat">The matrix to transpose.</param>
    /// <returns>The transposed matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixTranspose(Matrix4x4 mat);

    /// <summary>
    /// Invert provided matrix.
    /// </summary>
    /// <param name="mat">The matrix to invert.</param>
    /// <returns>The inverted matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixInvert(Matrix4x4 mat);

    /// <summary>
    /// Get identity matrix.
    /// </summary>
    /// <returns>The identity matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixIdentity();

    /// <summary>
    /// Add two matrices.
    /// </summary>
    /// <param name="left">The first matrix.</param>
    /// <param name="right">The second matrix.</param>
    /// <returns>The sum of the two matrices.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixAdd(Matrix4x4 left, Matrix4x4 right);

    /// <summary>
    /// Subtract two matrices (left - right).
    /// </summary>
    /// <param name="left">The left matrix.</param>
    /// <param name="right">The right matrix.</param>
    /// <returns>The subtracted matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixSubtract(Matrix4x4 left, Matrix4x4 right);

    /// <summary>
    /// Get two matrix multiplication.
    /// </summary>
    /// <param name="left">The left matrix.</param>
    /// <param name="right">The right matrix.</param>
    /// <returns>The result of the matrix multiplication.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixMultiply(Matrix4x4 left, Matrix4x4 right);

    /// <summary>
    /// Get translation matrix.
    /// </summary>
    /// <param name="x">The translation in the x-axis.</param>
    /// <param name="y">The translation in the y-axis.</param>
    /// <param name="z">The translation in the z-axis.</param>
    /// <returns>The translated matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixTranslate(float x, float y, float z);

    /// <summary>
    /// Create rotation matrix from axis and angle.
    /// </summary>
    /// <param name="axis">The axis of rotation.</param>
    /// <param name="angle">The angle of rotation in degrees.</param>
    /// <returns>The rotated matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixRotate(Vector3 axis, float angle);

    /// <summary>
    /// Get x-rotation matrix.
    /// </summary>
    /// <param name="angle">The angle of rotation in degrees.</param>
    /// <returns>The rotated matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixRotateX(float angle);

    /// <summary>
    /// Get y-rotation matrix.
    /// </summary>
    /// <param name="angle">The angle in radians.</param>
    /// <returns>The rotated Matrix4x4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixRotateY(float angle);

    /// <summary>
    /// Get z-rotation matrix.
    /// </summary>
    /// <param name="angle">The angle of rotation in radians.</param>
    /// <returns>The resulting rotated Matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixRotateZ(float angle);

    /// <summary>
    /// Get xyz-rotation matrix.
    /// </summary>
    /// <param name="angle">The angles to rotate by.</param>
    /// <returns>The rotated vector.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixRotateXYZ(Vector3 angle);

    /// <summary>
    /// Get zyx-rotation matrix.
    /// </summary>
    /// <param name="angle">The angles of rotation around the Z, Y, and X axes.</param>
    /// <returns>A new matrix with the applied rotation.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixRotateZYX(Vector3 angle);

    /// <summary>
    /// Get scaling matrix.
    /// </summary>
    /// <param name="x">The scale factor for the X axis.</param>
    /// <param name="y">The scale factor for the Y axis.</param>
    /// <param name="z">The scale factor for the Z axis.</param>
    /// <returns>The scaled matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixScale(float x, float y, float z);

    /// <summary>
    /// Get perspective projection matrix.
    /// </summary>
    /// <param name="left">Left boundary of the frustum view volume.</param>
    /// <param name="right">Right boundary of the frustum view volume.</param>
    /// <param name="bottom">Bottom boundary of the frustum view volume.</param>
    /// <param name="top">Top boundary of the frustum view volume.</param>
    /// <param name="nearPlane">Near boundary of the frustum view volume.</param>
    /// <param name="farPlane">Far boundary of the frustum view volume.</param>
    /// <returns>A Matrix4x4 representing the frustum perspective projection matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixFrustum(double left, double right, double bottom, double top, double nearPlane, double farPlane);

    /// <summary>
    /// Get perspective projection matrix.
    /// </summary>
    /// <param name="fovY">The field of view angle in degrees along the y-axis.</param>
    /// <param name="aspect">The aspect ratio of the view, defined as the width divided by the height.</param>
    /// <param name="nearPlane">The distance to the near clipping plane.</param>
    /// <param name="farPlane">The distance to the far clipping plane.</param>
    /// <returns>The perspective projection matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixPerspective(double fovY, double aspect, double nearPlane, double farPlane);

    /// <summary>
    /// Get orthographic projection matrix.
    /// </summary>
    /// <param name="left">The left edge of the view volume.</param>
    /// <param name="right">The right edge of the view volume.</param>
    /// <param name="bottom">The bottom edge of the view volume.</param>
    /// <param name="top">The top edge of the view volume.</param>
    /// <param name="nearPlane">The distance to the near plane.</param>
    /// <param name="farPlane">The distance to the far plane.</param>
    /// <returns>The orthographic transform matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixOrtho(double left, double right, double bottom, double top, double nearPlane, double farPlane);

    /// <summary>
    /// Get camera look-at matrix (view matrix).
    /// </summary>
    /// <param name="eye">The position of the camera.</param>
    /// <param name="target">The target position the camera is looking at.</param>
    /// <param name="up">The up direction vector.</param>
    /// <returns>The resulting view matrix.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 MatrixLookAt(Vector3 eye, Vector3 target, Vector3 up);

    /// <summary>
    /// Add two quaternions.
    /// </summary>
    /// <param name="q1">The first quaternion.</param>
    /// <param name="q2">The second quaternion.</param>
    /// <returns>The sum of the two quaternions.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionAdd(Quaternion q1, Quaternion q2);

    /// <summary>
    /// Add quaternion and float value.
    /// </summary>
    /// <param name="q">The quaternion to modify.</param>
    /// <param name="add">The value to add to each component.</param>
    /// <returns>The modified quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionAddValue(Quaternion q, float add);

    /// <summary>
    /// Subtract two quaternions.
    /// </summary>
    /// <param name="q1">The first quaternion.</param>
    /// <param name="q2">The second quaternion.</param>
    /// <returns>The resulting quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionSubtract(Quaternion q1, Quaternion q2);

    /// <summary>
    /// Subtract quaternion and float value.
    /// </summary>
    /// <param name="q">The Quaternion to subtract the value from.</param>
    /// <param name="sub">The value to subtract from the Quaternion.</param>
    /// <returns>The resulting Quaternion after subtracting the value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionSubtractValue(Quaternion q, float sub);

    /// <summary>
    /// Get identity quaternion.
    /// </summary>
    /// <returns>The identity quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionIdentity();

    /// <summary>
    /// Computes the length of a quaternion.
    /// </summary>
    /// <param name="q">The Quaternion to calculate the length of.</param>
    /// <returns>The length of the Quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial float QuaternionLength(Quaternion q);

    /// <summary>
    /// Normalize provided quaternion.
    /// </summary>
    /// <param name="q">The quaternion to normalize.</param>
    /// <returns>The normalized quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionNormalize(Quaternion q);

    /// <summary>
    /// Invert provided quaternion.
    /// </summary>
    /// <param name="q">The quaternion to invert.</param>
    /// <returns>The inverted quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionInvert(Quaternion q);

    /// <summary>
    /// Calculate two quaternion multiplication.
    /// </summary>
    /// <param name="q1">The first quaternion.</param>
    /// <param name="q2">The second quaternion.</param>
    /// <returns>The result of multiplying the two quaternions.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionMultiply(Quaternion q1, Quaternion q2);

    /// <summary>
    /// Scale quaternion by float value.
    /// </summary>
    /// <param name="q">The quaternion to scale.</param>
    /// <param name="mul">The scalar value to multiply the quaternion by.</param>
    /// <returns>The scaled quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionScale(Quaternion q, float mul);

    /// <summary>
    /// Divide two quaternions.
    /// </summary>
    /// <param name="q1">The dividend quaternion.</param>
    /// <param name="q2">The divisor quaternion.</param>
    /// <returns>The result of dividing q1 by q2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionDivide(Quaternion q1, Quaternion q2);

    /// <summary>
    /// Calculate linear interpolation between two quaternions.
    /// </summary>
    /// <param name="q1">The first quaternion.</param>
    /// <param name="q2">The second quaternion.</param>
    /// <param name="amount">The interpolation amount. Value between 0 and 1.</param>
    /// <returns>The interpolated quaternion</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionLerp(Quaternion q1, Quaternion q2, float amount);

    /// <summary>
    /// Calculate slerp-optimized interpolation between two quaternions.
    /// </summary>
    /// <param name="q1">The first quaternion.</param>
    /// <param name="q2">The second quaternion.</param>
    /// <param name="amount">The interpolation amount between the two quaternions (in the range [0, 1]).</param>
    /// <returns>The interpolated quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionNlerp(Quaternion q1, Quaternion q2, float amount);

    /// <summary>
    /// Calculates spherical linear interpolation between two quaternions.
    /// </summary>
    /// <param name="q1">The starting quaternion.</param>
    /// <param name="q2">The ending quaternion.</param>
    /// <param name="amount">A value between 0 and 1 indicating the weight of the interpolation.</param>
    /// <returns>The interpolated quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionSlerp(Quaternion q1, Quaternion q2, float amount);

    /// <summary>
    /// Calculate quaternion cubic spline interpolation using Cubic Hermite Spline algorithm.
    /// </summary>
    /// <param name="q1">The starting quaternion.</param>
    /// <param name="outTangent1">The outgoing tangent quaternion of the starting quaternion.</param>
    /// <param name="q2">The ending quaternion.</param>
    /// <param name="inTangent2">The incoming tangent quaternion of the ending quaternion.</param>
    /// <param name="t">The interpolation parameter [0.0f, 1.0f].</param>
    /// <returns>The interpolated quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionCubicHermiteSpline(Quaternion q1, Quaternion outTangent1, Quaternion q2, Quaternion inTangent2, float t);

    /// <summary>
    /// Calculate quaternion based on the rotation from one vector to another.
    /// </summary>
    /// <param name="from">The initial direction.</param>
    /// <param name="to">The target direction.</param>
    /// <returns>The generated quaternion representing the rotation.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionFromVector3ToVector3(Vector3 from, Vector3 to);

    /// <summary>
    /// Get a quaternion for a given rotation matrix.
    /// </summary>
    /// <param name="mat">The Matrix4x4 to create a Quaternion from.</param>
    /// <returns>The Quaternion created from the Matrix4x4.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionFromMatrix(Matrix4x4 mat);

    /// <summary>
    /// Get a matrix for a given quaternion.
    /// </summary>
    /// <param name="q">The quaternion to convert.</param>
    /// <returns>The matrix representation of the quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Matrix4x4 QuaternionToMatrix(Quaternion q);

    /// <summary>
    /// Get rotation quaternion for an angle and axis.
    /// </summary>
    /// <param name="axis">The axis of rotation.</param>
    /// <param name="angle">The angle of rotation in radians.</param>
    /// <returns>The resulting quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionFromAxisAngle(Vector3 axis, float angle);

    /// <summary>
    /// Get the rotation angle and axis for a given quaternion.
    /// </summary>
    /// <param name="q">The quaternion to convert.</param>
    /// <param name="axis">The resulting axis.</param>
    /// <param name="angle">The resulting angle in radians.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void QuaternionToAxisAngle(Quaternion q, out Vector3 axis, out float angle);

    /// <summary>
    /// Get the quaternion equivalent to Euler angles.
    /// </summary>
    /// <param name="pitch">The pitch angle in degrees.</param>
    /// <param name="yaw">The yaw angle in degrees.</param>
    /// <param name="roll">The roll angle in degrees.</param>
    /// <returns>The quaternion representing the euler angles.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionFromEuler(float pitch, float yaw, float roll);

    /// <summary>
    /// Get the Euler angles equivalent to quaternion (roll, pitch, yaw).
    /// </summary>
    /// <param name="q">The Quaternion to convert.</param>
    /// <returns>The Euler angles as a Vector3.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Vector3 QuaternionToEuler(Quaternion q);

    /// <summary>
    /// Transform a quaternion given a transformation matrix.
    /// </summary>
    /// <param name="q">The Quaternion to transform.</param>
    /// <param name="mat">The Matrix4x4 transformation matrix.</param>
    /// <returns>The transformed Quaternion.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial Quaternion QuaternionTransform(Quaternion q, Matrix4x4 mat);

    /// <summary>
    /// Check whether two given quaternions are almost equal.
    /// </summary>
    /// <param name="p">The first quaternion.</param>
    /// <param name="q">The second quaternion.</param>
    /// <returns>True if the quaternions are equal, False otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int QuaternionEquals(Quaternion p, Quaternion q);

    /// <summary>
    /// Decompose a transformation matrix into its rotational, translational and scaling components.
    /// </summary>
    /// <param name="mat">The input matrix to decompose.</param>
    /// <param name="translation">The output translation component of the decomposed matrix.</param>
    /// <param name="rotation">The output rotation component of the decomposed matrix.</param>
    /// <param name="scale">The output scale component of the decomposed matrix.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void MatrixDecompose(Matrix4x4 mat, ref Vector3 translation, ref Quaternion rotation, ref Vector3 scale);
}