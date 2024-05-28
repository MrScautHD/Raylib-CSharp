using System.Runtime.CompilerServices;
using Raylib_CSharp.Windowing;
using Raylib_CSharp.Wrappers;

[assembly: DisableRuntimeMarshalling]

namespace Raylib_CSharp;

// TODO: Remove temp methods like `Camera3D.Update_(....)` after this issue is fixed: https://github.com/dotnet/runtime/issues/102690

public static class Raylib {

    public const string Name = "raylib";

    public static readonly Version Version = new(3, 0, 6);
    public static readonly Version RlVersion = new(5, 0, 0);

    /// <inheritdoc cref="RlWrapper.TakeScreenshot"/>
    public static void TakeScreenshot(string path) {
        RlWrapper.TakeScreenshot(path);
    }

    /// <inheritdoc cref="RlWrapper.SetConfigFlags"/>
    public static void SetConfigFlags(ConfigFlags flags) {
        RlWrapper.SetConfigFlags(flags);
    }

    /// <inheritdoc cref="RlWrapper.OpenUrl"/>
    public static void OpenUrl(string path) {
        RlWrapper.OpenUrl(path);
    }

    /// <inheritdoc cref="RlWrapper.SetRandomSeed"/>
    public static void SetRandomSeed(uint seed) {
        RlWrapper.SetRandomSeed(seed);
    }

    /// <inheritdoc cref="RlWrapper.GetRandomValue"/>
    public static int GetRandomValue(int min, int max) {
        return RlWrapper.GetRandomValue(min, max);
    }

    /// <inheritdoc cref="RlWrapper.LoadRandomSequence"/>
    public static unsafe ReadOnlySpan<int> LoadRandomSequence(int count, int min, int max) {
        return new ReadOnlySpan<int>(RlWrapper.LoadRandomSequence(count, min, max), count);
    }

    /// <inheritdoc cref="RlWrapper.UnloadRandomSequence"/>
    public static unsafe void UnloadRandomSequence(ReadOnlySpan<int> sequence) {
        fixed (int* sequencePtr = sequence) {
            RlWrapper.UnloadRandomSequence(sequencePtr);
        }
    }

    /// <inheritdoc cref="RlWrapper.MemAlloc"/>
    public static unsafe T* MemAlloc<T>(int size) where T : unmanaged {
        return (T*) RlWrapper.MemAlloc(size * sizeof(T));
    }

    /// <inheritdoc cref="RlWrapper.MemRealloc"/>
    public static unsafe T* MemRealloc<T>(T* ptr, int size) where T : unmanaged {
        return (T*) RlWrapper.MemRealloc((nint) ptr, size * sizeof(T));
    }

    /// <inheritdoc cref="RlWrapper.MemFree"/>
    public static unsafe void MemFree<T>(T* ptr) where T : unmanaged {
        RlWrapper.MemFree((nint) ptr);
    }
}