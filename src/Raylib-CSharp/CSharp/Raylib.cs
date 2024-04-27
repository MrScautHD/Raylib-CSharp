using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: DisableRuntimeMarshalling]

namespace Raylib_CSharp.CSharp;

public static partial class Raylib {

    public const string Name = "raylib";

    public static readonly Version Version = new(1, 0, 0);
    public static readonly Version RlVersion = new(5, 0, 0);

    /// <summary>
    /// Takes a screenshot of current screen (saved a .png).
    /// </summary>
    /// <param name="path">The path where the screenshot should be saved.</param>
    [LibraryImport(Name, EntryPoint = "TakeScreenshot", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TakeScreenshot(string path);

    /// <summary>
    /// Open URL with default system browser (if available).
    /// </summary>
    /// <param name="url">The URL to open.</param>
    [LibraryImport(Name, EntryPoint = "OpenURL", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void OpenUrl(string url);
}