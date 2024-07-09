using System.Runtime.CompilerServices;
using Raylib_CSharp.Windowing;
using Raylib_CSharp.Apis;

[assembly: DisableRuntimeMarshalling]

namespace Raylib_CSharp;

public static class Raylib {

    public const string Name = "raylib";

    public static readonly Version Version = new(4, 1, 8);
    public static readonly Version RlVersion = new(5, 5, 0);

    /// <inheritdoc cref="RaylibApi.TakeScreenshot" />
    public static void TakeScreenshot(string path) {
        RaylibApi.TakeScreenshot(path);
    }

    /// <inheritdoc cref="RaylibApi.SetConfigFlags" />
    public static void SetConfigFlags(ConfigFlags flags) {
        RaylibApi.SetConfigFlags(flags);
    }

    /// <inheritdoc cref="RaylibApi.OpenURL" />
    public static void OpenURL(string path) {
        RaylibApi.OpenURL(path);
    }

    /// <inheritdoc cref="RaylibApi.SetRandomSeed" />
    public static void SetRandomSeed(uint seed) {
        RaylibApi.SetRandomSeed(seed);
    }

    /// <inheritdoc cref="RaylibApi.GetRandomValue" />
    public static int GetRandomValue(int min, int max) {
        return RaylibApi.GetRandomValue(min, max);
    }

    /// <inheritdoc cref="RaylibApi.LoadRandomSequence" />
    public static unsafe ReadOnlySpan<int> LoadRandomSequence(int count, int min, int max) {
        return new ReadOnlySpan<int>(RaylibApi.LoadRandomSequence(count, min, max), count);
    }

    /// <inheritdoc cref="RaylibApi.UnloadRandomSequence" />
    public static unsafe void UnloadRandomSequence(ReadOnlySpan<int> sequence) {
        fixed (int* sequencePtr = sequence) {
            RaylibApi.UnloadRandomSequence(sequencePtr);
        }
    }

    /// <inheritdoc cref="RaylibApi.MemAlloc" />
    public static unsafe T* MemAlloc<T>(int size) where T : unmanaged {
        return (T*) RaylibApi.MemAlloc(size * sizeof(T));
    }

    /// <inheritdoc cref="RaylibApi.MemRealloc" />
    public static unsafe T* MemRealloc<T>(T* ptr, int size) where T : unmanaged {
        return (T*) RaylibApi.MemRealloc((nint) ptr, size * sizeof(T));
    }

    /// <inheritdoc cref="RaylibApi.MemFree" />
    public static unsafe void MemFree<T>(T* ptr) where T : unmanaged {
        RaylibApi.MemFree((nint) ptr);
    }
}