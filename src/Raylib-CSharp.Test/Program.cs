using System.Numerics;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Geometry.Managers;
using Raylib_CSharp.Logging;
using Raylib_CSharp.Materials;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Windowing;

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

Model model = ModelManager.LoadModel("content/model.glb");

Camera3D camera3D = new Camera3D() {
    FovY = 70,
    Position = new Vector3(10, 10, 10),
    Target = Vector3.Zero,
    Projection = CameraProjection.Perspective,
    Up = Vector3.UnitY
};

while (!Window.ShouldClose()) {
    Camera3D.Update(ref camera3D, CameraMode.Orbital);

    Graphics.BeginDrawing();
    Graphics.ClearBackground(Color.SkyBlue);

    Graphics.BeginMode3D(camera3D);
    ModelManager.DrawGrid(100, 1);
    ModelManager.DrawModel(model, Vector3.UnitY / 2, 1, Color.Alpha(Color.Green, 0.5F));
    Graphics.EndMode3D();

    Graphics.DrawFps(50, 50);

    Graphics.EndDrawing();
}

unsafe {
    MaterialManager.UnloadMaterial(model.Materials[0]);
    model.Materials[0].Maps = null;
}

ModelManager.UnloadModel(model);

Window.Close();