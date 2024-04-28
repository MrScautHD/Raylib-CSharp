using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Rendering.Shaders;

public static partial class ShaderManager {

    [LibraryImport(Raylib.Name, EntryPoint = "LoadShader", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader Load(string vsFileName, string fsFileName);

    [LibraryImport(Raylib.Name, EntryPoint = "LoadShaderFromMemory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadFromMemory(string vsCode, string fsCode);

    [LibraryImport(Raylib.Name, EntryPoint = "IsShaderReady")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsReady(Shader shader);

    [LibraryImport(Raylib.Name, EntryPoint = "GetShaderLocation", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetLocation(Shader shader, string uniformName);

    [LibraryImport(Raylib.Name, EntryPoint = "GetShaderLocationAttrib", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetLocationAttrib(Shader shader, string attribName);

    [LibraryImport(Raylib.Name, EntryPoint = "SetShaderValue")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetValue(Shader shader, int locIndex, nint value, ShaderUniformDataType uniformType);
}