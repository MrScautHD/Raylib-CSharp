using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.CSharp.Marshallers;

namespace Raylib_CSharp.CSharp.IO;

// TODO: Change the Doc on Github!

public static partial class FileManager {

    /// <summary>
    /// Load file data as byte array (read).
    /// </summary>
    /// <param name="fileName">The name of the file to load the data from.</param>
    /// <param name="dataSize">A pointer to an integer that will store the size of the loaded data.</param>
    /// <returns>A pointer to the loaded data.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadFileData", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* LoadData(string fileName, int* dataSize);

    /// <summary>
    /// Unload file data allocated by LoadFileData().
    /// </summary>
    /// <param name="data">The pointer to the data to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadFileData")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadData(byte* data);

    /// <summary>
    /// Save data to file from byte array (write), returns true on success
    /// </summary>
    /// <param name="fileName">The name of the file to save the data to.</param>
    /// <param name="data">A pointer to the data to be saved.</param>
    /// <param name="dataSize">The size of the data in bytes.</param>
    /// <returns>True if the data was saved successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "SaveFileData", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static unsafe partial bool SaveData(string fileName, byte* data, int dataSize);

    /// <summary>
    /// Export data to code (.h), returns true on success.
    /// </summary>
    /// <param name="data">A pointer to the data to be exported.</param>
    /// <param name="dataSize">The size of the data to be exported.</param>
    /// <param name="fileName">The name of the file to save the exported data to.</param>
    /// <returns>True if the data was successfully exported and saved as code, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ExportDataAsCode", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static unsafe partial bool ExportDataAsCode(byte* data, int dataSize, string fileName);

    /// <summary>
    /// Load text data from file (read), returns a '\0' terminated string.
    /// </summary>
    /// <param name="fileName">The name of the file to load the data from.</param>
    /// <returns>The loaded text as a string.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string LoadText(string fileName);

    /// <summary>
    /// Unload file text data allocated by LoadFileText().
    /// </summary>
    /// <param name="text">The text to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadFileText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadText(string text);

    /// <summary>
    /// Save text data to file (write), string must be '\0' terminated, returns true on success.
    /// </summary>
    /// <param name="fileName">The name of the file to save the text to.</param>
    /// <param name="text">The text to be saved.</param>
    /// <returns>True if the text was saved successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "SaveFileText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SaveText(string fileName, string text);

    /// <summary>
    /// Check if file exists.
    /// </summary>
    /// <param name="fileName">The name of the file to check.</param>
    /// <returns>Returns true if the file exists; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "FileExists", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool Exists(string fileName);

    /// <summary>
    /// Check if a directory path exists.
    /// </summary>
    /// <param name="dirPath">The path of the directory to check for existence.</param>
    /// <returns>True if the directory exists, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "DirectoryExists", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DirectoryExists(string dirPath);

    /// <summary>
    /// Check file extension (including point: .png, .wav).
    /// </summary>
    /// <param name="fileName">The name of the file to check.</param>
    /// <param name="ext">The extension to check against.</param>
    /// <returns>True if the filename has the specified extension, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsFileExtension", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsExtension(string fileName, string ext);

    /// <summary>
    /// Get file length in bytes (NOTE: GetFileSize() conflicts with windows.h).
    /// </summary>
    /// <param name="fileName">The name of the file to get the length of.</param>
    /// <returns>The length of the file in bytes.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetFileLength", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetLength(string fileName);

    /// <summary>
    /// Get pointer to extension for a filename string (includes dot: '.png').
    /// </summary>
    /// <param name="fileName">The file name.</param>
    /// <returns>The extension of the file name.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetFileExtension", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetExtension(string fileName);

    /// <summary>
    /// Get pointer to filename for a path string.
    /// </summary>
    /// <param name="filePath">The path of the file.</param>
    /// <returns>The name of the file.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetFileName", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetName(string filePath);

    /// <summary>
    /// Get filename string without extension (uses static string).
    /// </summary>
    /// <param name="filePath">The path of the file.</param>
    /// <returns>The file name without the extension.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetFileNameWithoutExt", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetNameWithoutExt(string filePath);

    /// <summary>
    /// Get full path for a given fileName with path (uses static string).
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns>The directory path.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetDirectoryPath", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetDirectoryPath(string filePath);

    /// <summary>
    /// Get previous directory path for a given path (uses static string).
    /// </summary>
    /// <param name="dirPath">The directory path.</param>
    /// <returns>The previous directory path.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetPrevDirectoryPath", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetPrevDirectoryPath(string dirPath);

    /// <summary>
    /// Get current working directory (uses static string).
    /// </summary>
    /// <returns>The current working directory.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetWorkingDirectory")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetWorkingDirectory();

    /// <summary>
    /// Get the directory of the running application (uses static string).
    /// </summary>
    /// <returns>The application directory.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetApplicationDirectory")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetApplicationDirectory();

    /// <summary>
    /// Change working directory, return true on success.
    /// </summary>
    /// <param name="dir">The path to the new directory.</param>
    /// <returns>True if the directory was changed successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "ChangeDirectory", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ChangeDirectory(string dir);

    /// <summary>
    /// Check if a given path is a file or a directory.
    /// </summary>
    /// <param name="path">The path to check.</param>
    /// <returns>Returns true if the given path is a file, otherwise false.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsPathFile", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsPathFile(string path);

    /// <summary>
    /// Load directory filepaths.
    /// </summary>
    /// <param name="dirPath">The path to the directory to load files from.</param>
    /// <returns>A list of file paths in the directory.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadDirectoryFiles", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFiles(string dirPath);

    /// <summary>
    /// Load directory filepaths with extension filtering and recursive directory scan.
    /// </summary>
    /// <param name="basePath">The base path of the directory to load files from.</param>
    /// <param name="filter">The filter used to match the file names.</param>
    /// <param name="scanSubdirs">Determines whether to scan subdirectories.</param>
    /// <returns>A list of file paths.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadDirectoryFilesEx", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFilesEx(string basePath, string filter, [MarshalAs(UnmanagedType.Bool)] bool scanSubdirs);

    /// <summary>
    /// Unload filepaths.
    /// </summary>
    /// <param name="files">The list of file paths in the directory.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadDirectoryFiles")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDirectoryFiles(FilePathList files);

    /// <summary>
    /// Check if a file has been dropped into window.
    /// </summary>
    /// <returns>True if a file has been dropped, false otherwise.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "IsFileDropped")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsDropped();

    /// <summary>
    /// Load dropped filepaths.
    /// </summary>
    /// <returns>A list of file paths.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadDroppedFiles")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDroppedFiles();

    /// <summary>
    /// Unload dropped filepaths.
    /// </summary>
    /// <param name="files">The list of dropped files to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadDroppedFiles")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDroppedFiles(FilePathList files);

    /// <summary>
    /// Get file modification time (last write time).
    /// </summary>
    /// <param name="fileName">The name of the file to get the modification time from.</param>
    /// <returns>The last modification time of the file as a Unix timestamp.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetFileModTime", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial long GetFileModTime(string fileName);
}