using Raylib_CSharp.Wrappers;

namespace Raylib_CSharp;

public static class RayMath {

    public const float Deg2Rad = MathF.PI / 180.0f;
    public const float Rad2Deg = 180.0f / MathF.PI;

    /// <inheritdoc cref="RlMathWrapper.Clamp"/>
    public static float Clamp(float value, float min, float max) {
        return RlMathWrapper.Clamp(value, min, max);
    }
}