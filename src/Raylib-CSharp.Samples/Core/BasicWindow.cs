using Raylib_CSharp.Colors;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Windowing;

namespace Raylib_CSharp.Samples.Core;

public class BasicWindow : ISample {

    public void Run() {
        Window.Init(1280, 720, "Basic Window");

        while (!Window.ShouldClose()) {
            Graphics.BeginDrawing();
            Graphics.ClearBackground(Color.SkyBlue);

            Graphics.DrawText("Basic Window!", 10, 10, 20, Color.White);

            Graphics.EndDrawing();
        }
    }

    public void Dispose() {
        Window.Close();
    }
}