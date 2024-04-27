using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp;

public static partial class Time {
    
    /// <summary>
    /// Set target FPS (maximum).
    /// </summary>
    /// <param name="fps">The desired frames-per-second.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTargetFPS(int fps);
    
    /// <summary>
    /// Get time in seconds for last frame drawn (delta time).
    /// </summary>
    /// <returns>The frame time in seconds.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetFrameTime();
    
    /// <summary>
    /// Get elapsed time in seconds since InitWindow().
    /// </summary>
    /// <returns>The current time in seconds.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial double GetTime();

    /// <summary>
    /// Get current FPS.
    /// </summary>
    /// <returns>The frames-per-second value.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFPS();
    
    /// <summary>
    /// Wait for some time (halt program execution).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void WaitTime(double seconds);

    /// <summary>
    /// Register all input events.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PollInputEvents();
}