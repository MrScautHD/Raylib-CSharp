using System.Numerics;
using Raylib_CSharp;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Images;
using Raylib_CSharp.IO;
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

Model model = Model.Load("content/model.glb");

Camera3D camera3D = new Camera3D() {
    FovY = 70,
    Position = new Vector3(10, 10, 10),
    Target = Vector3.Zero,
    Projection = CameraProjection.Perspective,
    Up = Vector3.UnitY
};

Image testImage = Image.GenColor(100, 100, Color.Green);

while (!Window.ShouldClose()) {
    Camera3D.Update(ref camera3D, CameraMode.Orbital);

    Graphics.BeginDrawing();
    Graphics.ClearBackground(Color.SkyBlue);

    Graphics.BeginMode3D(camera3D);
    Graphics.DrawGrid(100, 1);
    Graphics.DrawModel(model, Vector3.UnitY / 2, 1, Color.Alpha(Color.Green, 0.5F));
    Graphics.EndMode3D();

    Graphics.DrawFps(50, 50);

    Graphics.EndDrawing();
}

unsafe {
    ModelAnimation animation = ModelAnimation.Load("content/model.glb", out int count)[1];

    Transform transform = animation.FramePosesCollection[1][1];
    Logger.TraceLog(TraceLogLevel.Error, "Test : " + transform.Translation);
}

FilePathList test = FileManager.LoadDirectoryFiles("content");
Logger.TraceLog(TraceLogLevel.Error, "Path: " + test.Paths[0]);

MaterialManager.UnloadMaterial(model.Materials[0]);
model.MaterialCount = 0;

Model.Unload(model);

Window.Close();