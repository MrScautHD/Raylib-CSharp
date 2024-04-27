using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Windowing;

[assembly: DisableRuntimeMarshalling]

namespace Raylib_CSharp.CSharp;

public static partial class Raylib {
    
    public const string Name = "raylib";

    public static readonly Version Version = new Version(1, 0, 0);
    public static readonly Version RlVersion = new Version(5, 0, 0);
    
    /// <summary>
    /// Takes a screenshot of current screen (saved a .png).
    /// </summary>
    /// <param name="path">The path where the screenshot should be saved.</param>
    [LibraryImport(Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TakeScreenshot(string path);
    
    /// <summary>
    /// Setup init configuration flags (view FLAGS).
    /// </summary>
    /// <param name="flags">The configuration flags to set. Use the bitwise OR operator to combine multiple flags if needed.</param>
    [LibraryImport(Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetConfigFlags(ConfigFlags flags);
    
    /// <summary>
    /// Open URL with default system browser (if available).
    /// </summary>
    /// <param name="url">The URL to open.</param>
    [LibraryImport(Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void OpenUrl(string url);
}