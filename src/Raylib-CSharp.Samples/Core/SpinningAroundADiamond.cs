using System.Numerics;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Windowing;

namespace Raylib_CSharp.Samples.Core;

public class SpinningAroundADiamond : ISample {

    /// <inheritdoc />
    public void Run() {
        Window.Init(800, 450, "Spinning a Diamond in 3D Space with a 3D Camera");
        Time.SetTargetFPS(60);

        // Define the camera to look into our 3D world
        Camera3D camera = new Camera3D {
            Position = new Vector3(0, 10, 70),
            Target = new Vector3(0, 0, 0),
            Up = new Vector3(0, 1, 0),
            FovY = 60,
            Projection = CameraProjection.Perspective
        };

        // Define the diamond as a series of triangles with different colors
        Polygon diamond = new(
            new Triangle(new Vector3(-25, 0, 25), new Vector3(25, 0, 25), new Vector3(0, 25, 0), Color.SkyBlue),
            new Triangle(new Vector3(25, 0, 25), new Vector3(25, 0, -25), new Vector3(0, 25, 0), Color.Green),
            new Triangle(new Vector3(25, 0, -25), new Vector3(-25, 0, -25), new Vector3(0, 25, 0), Color.Gold),
            new Triangle(new Vector3(-25, 0, -25), new Vector3(-25, 0, 25), new Vector3(0, 25, 0), Color.Maroon),
            new Triangle(new Vector3(-25, 0, 25), new Vector3(0, -25, 0), new Vector3(25, 0, 25), Color.Gold),
            new Triangle(new Vector3(25, 0, 25), new Vector3(0, -25, 0), new Vector3(25, 0, -25), Color.Maroon),
            new Triangle(new Vector3(25, 0, -25), new Vector3(0, -25, 0), new Vector3(-25, 0, -25), Color.SkyBlue),
            new Triangle(new Vector3(-25, 0, -25), new Vector3(0, -25, 0), new Vector3(-25, 0, 25), Color.Green)
        );

        float rotation = 0.0f;
        float rotationSpeedPerFrame = 0.025f;

        while (!Window.ShouldClose()) {
            Graphics.BeginDrawing();
            Graphics.BeginMode3D(camera);
            Graphics.ClearBackground(Color.LightGray);

            // Rotate the diamond
            float angle = this.CalculateRotation(rotation, rotationSpeedPerFrame);
            diamond.Rotate(Vector3.UnitY, angle);

            // Draw the diamond as a series of triangles with different colors
            foreach (Triangle triangle in diamond.Triangles) {
                triangle.Draw();
            }

            // Draw the grid on the floor to give a sense of orientation
            Graphics.DrawGrid(10, 100);

            Graphics.EndMode3D();
            Graphics.EndDrawing();
        }
    }

    private float CalculateRotation(float rotation, float rotationSpeedPerFrame) {
        float angle = rotation + rotationSpeedPerFrame;
        return angle >= 360.0f ? angle - 360.0f : angle;
    }

    private struct Polygon {
        public readonly Triangle[] Triangles;

        public Polygon(params Triangle[] triangles) {
            this.Triangles = triangles;
        }

        public void Rotate(Vector3 axis, float angle) {
            for (int index = 0; index < this.Triangles.Length; index++) {
                this.Triangles[index].Vertex1 = Vector3.Transform(this.Triangles[index].Vertex1, Matrix4x4.CreateFromAxisAngle(axis, angle));
                this.Triangles[index].Vertex2 = Vector3.Transform(this.Triangles[index].Vertex2, Matrix4x4.CreateFromAxisAngle(axis, angle));
                this.Triangles[index].Vertex3 = Vector3.Transform(this.Triangles[index].Vertex3, Matrix4x4.CreateFromAxisAngle(axis, angle));
            }
        }
    }

    private struct Triangle {
        public Vector3 Vertex1;
        public Vector3 Vertex2;
        public Vector3 Vertex3;
        public Color Color;

        public Triangle(Vector3 v1, Vector3 v2, Vector3 v3, Color color) {
            this.Vertex1 = v1;
            this.Vertex2 = v2;
            this.Vertex3 = v3;
            this.Color = color;
        }

        public void Draw() {
            Graphics.DrawTriangle3D(this.Vertex1, this.Vertex2, this.Vertex3, this.Color);
        }
    }

    /// <inheritdoc />
    public void Dispose() {
        Window.Close();
    }
}