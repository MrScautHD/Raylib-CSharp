using System.Numerics;
using Raylib_CSharp;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Images;
using Raylib_CSharp.IO;
using Raylib_CSharp.Logging;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Rendering.Gl.Contexts;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Unsafe.Spans.Data;
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

ReadOnlySpan<ModelAnimation> animation = ModelAnimation.LoadAnimations("content/model.glb");

ReadOnlySpanData<ModelAnimation> data = new(animation);
List<ReadOnlySpanData<ModelAnimation>> list = new();
list.Add(data);

//ModelAnimation.Unload(animation[0]);

unsafe {
    Console.WriteLine(list[0].GetSpan()[0].BonesPtr[1].Name + "");
}

// LOAD DATA
Font font = Font.Load("content/fontoe.ttf");
ReadOnlySpan<byte> fileData = FileManager.LoadFileData("content/fontoe.ttf");
ReadOnlySpan<int> codepoints = TextManager.LoadCodepoints("HELLOO i like you :)");
ReadOnlySpan<GlyphInfo> info = Font.LoadData(fileData, 18, 95, FontType.Default);

Console.WriteLine(info.Length + "");

Image image = Font.GenImageAtlas(info, font.Recs, 18, 4, 0);
Texture2D texture = Texture2D.LoadFromImage(image);
image.Unload();

FileManager.UnloadFileData(fileData);
TextManager.UnloadCodepoints(codepoints);
Font.UnloadData(info);

string[] testArray = new string[3];
testArray[1] = "HELLOOOO";
testArray[2] = "HEYYYYY";

TextManager.TextJoin(testArray, "hello");

Camera3D camera3D = new Camera3D() {
    FovY = 70,
    Position = new Vector3(10, 10, 10),
    Target = Vector3.Zero,
    Projection = CameraProjection.Perspective,
    Up = Vector3.UnitY
};

Color color = Color.Black;
Color color1 = Color.Fade(color, 1);


Font font2 = Font.GetDefault();

//if (font2.IsReady()) {
//
//}

Image testImage = Image.GenColor(100, 100, Color.Green);

NativeGlContext Context = new NativeGlContext();

Gl.Init();

//Span<Matrix4x4> matrix = new(new Matrix4x4[1]);
//matrix[1] = new Matrix4x4();

while (!Window.ShouldClose()) {
    camera3D.Update(CameraMode.Orbital);

    Graphics.BeginDrawing();
    Graphics.ClearBackground(Color.SkyBlue);

    Gl.UseProgram(RlGl.GetShaderIdDefault());

    //Console.WriteLine(GladApi.GetString(0x1F02) + "");

    Graphics.BeginMode3D(camera3D);
    Graphics.DrawGrid(100, 1);
    Graphics.DrawModel(model, Vector3.UnitY / 2, 1, Color.Alpha(Color.Green, 0.5F));
    Graphics.EndMode3D();

    Graphics.DrawFPS(50, 50);
    Graphics.DrawTexture(texture, 10, 10, Color.White);

    Graphics.EndDrawing();
}

FilePathList test = FileManager.LoadDirectoryFiles("content");
Logger.TraceLog(TraceLogLevel.Error, "Path: " + test.Paths[0]);

model.Materials[0].Unload();
model.MaterialCount = 0;

model.Unload();

Window.Close();
Gl.Destroy();