using System.Numerics;
using Raylib_CSharp.Colors;
using Raylib_CSharp.Interact;
using Raylib_CSharp.Logging;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Transformations;
using Raylib_CSharp.Windowing;

namespace Raylib_CSharp.Samples.Core;

public class Pong : ISample {
    private const int _screenWidth = 1280;
    private const int _screenHeight = 720;

    private const float _ballRadius = 10;
    private const float _ballBaseSpeed = 7.0f;
    private const float _paddleSpeed = 7.0f;

    private readonly Vector2 _center = new(_screenWidth / 2, _screenHeight / 2);

    private readonly Tuple<Vector2, Vector2> _leftSide = new Tuple<Vector2, Vector2>(new Vector2(0, 0), new Vector2(0, _screenHeight));
    private readonly Tuple<Vector2, Vector2> _rightSide = new Tuple<Vector2, Vector2>(new Vector2(_screenWidth, 0), new Vector2(_screenWidth, _screenHeight));

    private Rectangle _leftPaddle = new Rectangle(50, _screenHeight / 2 - 60, 20, 120);
    private Rectangle _rightPaddle = new Rectangle(_screenWidth - 70, _screenHeight / 2 - 60, 20, 120);

    private Vector2 _ballPosition = new Vector2(_screenWidth / 2, _screenHeight / 2);
    private Vector2 _ballSpeed = new Vector2(_ballBaseSpeed, _ballBaseSpeed);

    private int _leftPaddleScore = 0;
    private int _rightPaddleScore = 0;

    public void Run() {
        Window.Init(_screenWidth, _screenHeight, "Pong");

        Logger.SetTraceLogLevel(TraceLogLevel.Warning);
        Time.SetTargetFPS(60);

        while (!Window.ShouldClose()) {
            this.DrawFrame();
        }
    }

    private void DrawFrame() {
        Graphics.BeginDrawing();
        Graphics.ClearBackground(Color.Black);

        // Draw game title and scores
        Graphics.DrawText("Pong!", 10, 10, 20, Color.White);
        Graphics.DrawText(this._leftPaddleScore.ToString(), _screenWidth / 2 - 50, 10, 20, Color.White);
        Graphics.DrawText(this._rightPaddleScore.ToString(), _screenWidth / 2 + 30, 10, 20, Color.White);

        // Handle input for left paddle
        if (Input.IsKeyDown(KeyboardKey.W) && this._leftPaddle.Y > 0) this._leftPaddle.Y -= _paddleSpeed;
        if (Input.IsKeyDown(KeyboardKey.S) && this._leftPaddle.Y < _screenHeight - this._leftPaddle.Height) this._leftPaddle.Y += _paddleSpeed;

        // Handle input for right paddle
        if (Input.IsKeyDown(KeyboardKey.Up) && this._rightPaddle.Y > 0) this._rightPaddle.Y -= _paddleSpeed;
        if (Input.IsKeyDown(KeyboardKey.Down) && this._rightPaddle.Y < _screenHeight - this._rightPaddle.Height) this._rightPaddle.Y += _paddleSpeed;

        // Ball movement
        this._ballPosition += this._ballSpeed;

        // Ball collision with top and bottom
        if (this._ballPosition.Y <= _ballRadius || this._ballPosition.Y >= _screenHeight - _ballRadius) this._ballSpeed.Y *= -1;

        // Ball collision with paddles
        if (Collision.ShapeHelper.CheckCollisionCircleRec(this._ballPosition, _ballRadius, this._leftPaddle) ||
            Collision.ShapeHelper.CheckCollisionCircleRec(this._ballPosition, _ballRadius, this._rightPaddle))
            this._ballSpeed.X *= -1;

        // Ball goes out of bounds, reset position, increase speed, and update score
        if (this._ballPosition.X is < 0 or > _screenWidth) {
            Side winningSide = this._ballPosition.X < 0 ? Side.Left : Side.Right;

            if (winningSide == Side.Left)
                this._rightPaddleScore++;
            else
                this._leftPaddleScore++;

            // Update ball position to center
            this._ballPosition = this._center;

            // Increase ball speed based on scores
            float speedIncreaseFactor = 1 + (this._leftPaddleScore + this._rightPaddleScore) * 0.1f;
            Vector2 target = this.GetRandomTargetForDirection(winningSide);
            Vector2 ballDirection = GetDirectionToTarget(this._center, target);
            this._ballSpeed = new Vector2(ballDirection.X * _ballBaseSpeed * speedIncreaseFactor, ballDirection.Y * _ballBaseSpeed * speedIncreaseFactor);
        }

        // Draw ball
        Graphics.DrawCircleV(this._ballPosition, _ballRadius, Color.White);

        // Draw paddles
        Graphics.DrawRectangleRec(this._leftPaddle, Color.White);
        Graphics.DrawRectangleRec(this._rightPaddle, Color.White);

        Graphics.EndDrawing();
    }

    private static Vector2 GetDirectionToTarget(Vector2 origin, Vector2 target) {
        Vector2 direction = target - origin;
        return Vector2.Normalize(direction);
    }

    private Vector2 GetRandomTargetForDirection(Side winningSide) {
        Tuple<Vector2, Vector2> corners = winningSide switch {
            Side.Left => this._leftSide,
            Side.Right => this._rightSide,
            _ => throw new ArgumentOutOfRangeException(nameof(winningSide), winningSide, null)
        };
        float randomTarget = Random.Shared.Next((int)corners.Item1.Y, (int)corners.Item2.Y);
        return corners.Item1 with { Y = randomTarget };
    }

    private enum Side {
        Left,
        Right
    }

    public void Dispose() {
        Window.Close();
    }
}
