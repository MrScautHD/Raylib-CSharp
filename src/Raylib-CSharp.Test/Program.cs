using System.Numerics;
using Raylib_CSharp.CSharp;
using Raylib_CSharp.CSharp.Camera;
using Raylib_CSharp.CSharp.Camera.Cam3D;
using Raylib_CSharp.CSharp.Geometry.Managers;
using Raylib_CSharp.CSharp.Logging;
using Raylib_CSharp.CSharp.Misc;
using Raylib_CSharp.CSharp.Rendering;
using Raylib_CSharp.CSharp.Rendering.Shaders;
using Raylib_CSharp.CSharp.Windowing;

Console.WriteLine("Hello, World!");

Logger.Init();

Logger.Message += (level, text) => {
    switch (level) {

        case TraceLogLevel.Debug:
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
            Console.ResetColor();
            return true;

        case TraceLogLevel.Info:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
            return true;

        case TraceLogLevel.Warning:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
            return true;

        case TraceLogLevel.Error:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
            return true;

        case TraceLogLevel.Fatal:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
            return true;
    }

    return false;
};

Window.Init(1280, 720, "Raylib-CSharp");

Camera3D camera3D = new Camera3D() {
    FovY = 70,
    Position = new Vector3(10, 10, 10),
    Target = Vector3.Zero,
    Projection = CameraProjection.Perspective,
    Up = Vector3.UnitY
};

while (!Window.ShouldClose()) {
    CameraManager.UpdateCamera(ref camera3D, CameraMode.Orbital);

    Graphics.BeginDrawing();
    Graphics.ClearBackground(Color.SkyBlue);

    Graphics.BeginMode3D(camera3D);
    ModelManager.DrawGrid(100, 1);
    ModelManager.DrawCube(Vector3.UnitY / 2, 1, 1, 1, Color.Green);
    Graphics.EndMode3D();

    Graphics.EndDrawing();

    Quaternion quaternion = Quaternion.CreateFromYawPitchRoll(10, 10, 10);

    RayMath.QuaternionToAxisAngle(quaternion, out Vector3 axis, out float angle);

    Console.WriteLine("Axis: " + axis + "Angle: " + angle * RayMath.Rad2Deg);

    Vector3 vector3 = new(1, 1, 1);
    Vector3 vector32 = new(2, 2, 2);

    RayMath.Vector3OrthoNormalize(ref vector3, ref vector32);

    Console.WriteLine("Vector 1: " + vector3);
    Console.WriteLine("Vector 2: " + vector32);

    ShaderManager.SetShaderValue(new Shader(), 1, true, ShaderUniformDataType.Float);

    float[] texture2Ds = { 1, 2, 3 };
    ShaderManager.SetShaderValueV(new Shader(), 1, texture2Ds, ShaderUniformDataType.Float);
}