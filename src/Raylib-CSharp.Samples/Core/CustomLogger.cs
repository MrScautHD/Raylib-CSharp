using Raylib_CSharp.Colors;
using Raylib_CSharp.Logging;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Windowing;

namespace Raylib_CSharp.Samples.Core;

public class CustomLogger : ISample {

    public void Run() {
        Logger.Init();
        Logger.Message += this.Custom;

        Window.Init(1280, 720, "Custom Logger");

        while (!Window.ShouldClose()) {
            Graphics.BeginDrawing();
            Graphics.ClearBackground(Color.SkyBlue);

            Graphics.DrawText("Custom Logger!", 10, 10, 20, Color.White);

            Graphics.EndDrawing();
        }
    }

    /// <summary>
    /// Writes a custom log message with the specified log level and text.
    /// </summary>
    /// <param name="level">The log level of the message.</param>
    /// <param name="text">The text of the log message.</param>
    /// <returns>True if the log message was written successfully, false otherwise.</returns>
    private bool Custom(TraceLogLevel level, string text) {
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
    }

    public void Dispose() {
        Window.Close();
        Logger.Destroy();
    }
}