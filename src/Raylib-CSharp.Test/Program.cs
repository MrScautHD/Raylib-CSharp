using System.Numerics;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp;
using Raylib_CSharp.Camera;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Geometry.Managers;
using Raylib_CSharp.Logging;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Windowing;
using Raylib_CSharp.Logging;
using Raylib_CSharp.Shaders;
using CameraManager = Raylib_CSharp.Camera.CameraManager;
using Color = Raylib_CSharp.Colors.Color;
using Graphics = Raylib_CSharp.Rendering.Graphics;
using Logger = Raylib_CSharp.Logging.Logger;
using ModelManager = Raylib_CSharp.Geometry.Managers.ModelManager;
using RayMath = Raylib_CSharp.RayMath;
using ShaderManager = Raylib_CSharp.Shaders.ShaderManager;
using TextManager = Raylib_CSharp.Fonts.TextManager;
using Window = Raylib_CSharp.Windowing.Window;

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

    TextManager.DrawFps(50, 50);
    TextManager.DrawText(TextManager.TextReplace("Raylib-CSharp-1.0.0", "2.0.0", "1.0.0"), 500, 500, 58, Color.Red);

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