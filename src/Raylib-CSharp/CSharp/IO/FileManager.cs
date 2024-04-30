using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.CSharp.Marshallers;

namespace Raylib_CSharp.CSharp.IO;

public static partial class FileManager {

    /// <summary>
    /// Load file data as byte array (read).
    /// </summary>
    /// <param name="fileName">The name of the file to load the data from.</param>
    /// <param name="dataSize">A pointer to an integer that will store the size of the loaded data.</param>
    /// <returns>A pointer to the loaded data.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* LoadFileData(string fileName, uint* dataSize);

    /// <summary>
    /// Unload file data allocated by LoadFileData().
    /// </summary>
    /// <param name="data">The pointer to the data to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadFileData(byte* data);

    /// <summary>
    /// Save data to file from byte array (write), returns true on success
    /// </summary>
    /// <param name="fileName">The name of the file to save the data to.</param>
    /// <param name="data">A pointer to the data to be saved.</param>
    /// <param name="dataSize">The size of the data in bytes.</param>
    /// <returns>True if the data was saved successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static unsafe partial bool SaveFileData(string fileName, byte* data, uint dataSize);

    /// <summary>
    /// Export data to code (.h), returns true on success.
    /// </summary>
    /// <param name="data">A pointer to the data to be exported.</param>
    /// <param name="dataSize">The size of the data to be exported.</param>
    /// <param name="fileName">The name of the file to save the exported data to.</param>
    /// <returns>True if the data was successfully exported and saved as code, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static unsafe partial bool ExportDataAsCode(byte* data, uint dataSize, string fileName);

    /// <summary>
    /// Load text data from file (read), returns a '\0' terminated string.
    /// </summary>
    /// <param name="fileName">The name of the file to load the data from.</param>
    /// <returns>The loaded text as a string.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string LoadFileText(string fileName);

    /// <summary>
    /// Unload file text data allocated by LoadFileText().
    /// </summary>
    /// <param name="text">The text to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadFileText", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadFileText(string text);

    /// <summary>
    /// Save text data to file (write), string must be '\0' terminated, returns true on success.
    /// </summary>
    /// <param name="fileName">The name of the file to save the text to.</param>
    /// <param name="text">The text to be saved.</param>
    /// <returns>True if the text was saved successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SaveFileText(string fileName, string text);

    /// <summary>
    /// Check if file exists.
    /// </summary>
    /// <param name="fileName">The name of the file to check.</param>
    /// <returns>Returns true if the file exists; otherwise, false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool FileExists(string fileName);

    /// <summary>
    /// Check if a directory path exists.
    /// </summary>
    /// <param name="dirPath">The path of the directory to check for existence.</param>
    /// <returns>True if the directory exists, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DirectoryExists(string dirPath);

    /// <summary>
    /// Check file extension (including point: .png, .wav).
    /// </summary>
    /// <param name="fileName">The name of the file to check.</param>
    /// <param name="ext">The extension to check against.</param>
    /// <returns>True if the filename has the specified extension, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsFileExtension(string fileName, string ext);

    /// <summary>
    /// Get file length in bytes (NOTE: GetFileSize() conflicts with windows.h).
    /// </summary>
    /// <param name="fileName">The name of the file to get the length of.</param>
    /// <returns>The length of the file in bytes.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFileLength(string fileName);

    /// <summary>
    /// Get pointer to extension for a filename string (includes dot: '.png').
    /// </summary>
    /// <param name="fileName">The file name.</param>
    /// <returns>The extension of the file name.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetFileExtension(string fileName);

    /// <summary>
    /// Get pointer to filename for a path string.
    /// </summary>
    /// <param name="filePath">The path of the file.</param>
    /// <returns>The name of the file.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetFileName(string filePath);

    /// <summary>
    /// Get filename string without extension (uses static string).
    /// </summary>
    /// <param name="filePath">The path of the file.</param>
    /// <returns>The file name without the extension.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetFileNameWithoutExt(string filePath);

    /// <summary>
    /// Get full path for a given fileName with path (uses static string).
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns>The directory path.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetDirectoryPath(string filePath);

    /// <summary>
    /// Get previous directory path for a given path (uses static string).
    /// </summary>
    /// <param name="dirPath">The directory path.</param>
    /// <returns>The previous directory path.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetPrevDirectoryPath(string dirPath);

    /// <summary>
    /// Get current working directory (uses static string).
    /// </summary>
    /// <returns>The current working directory.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetWorkingDirectory();

    /// <summary>
    /// Get the directory of the running application (uses static string).
    /// </summary>
    /// <returns>The application directory.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string GetApplicationDirectory();

    /// <summary>
    /// Change working directory, return true on success.
    /// </summary>
    /// <param name="dir">The path to the new directory.</param>
    /// <returns>True if the directory was changed successfully, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ChangeDirectory(string dir);

    /// <summary>
    /// Check if a given path is a file or a directory.
    /// </summary>
    /// <param name="path">The path to check.</param>
    /// <returns>Returns true if the given path is a file, otherwise false.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsPathFile(string path);

    /// <summary>
    /// Load directory filepaths.
    /// </summary>
    /// <param name="dirPath">The path to the directory to load files from.</param>
    /// <returns>A list of file paths in the directory.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFiles(string dirPath);

    /// <summary>
    /// Load directory filepaths with extension filtering and recursive directory scan.
    /// </summary>
    /// <param name="basePath">The base path of the directory to load files from.</param>
    /// <param name="filter">The filter used to match the file names.</param>
    /// <param name="scanSubdirs">Determines whether to scan subdirectories.</param>
    /// <returns>A list of file paths.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFilesEx(string basePath, string filter, [MarshalAs(UnmanagedType.Bool)] bool scanSubdirs);

    /// <summary>
    /// Unload filepaths.
    /// </summary>
    /// <param name="files">The list of file paths in the directory.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDirectoryFiles(FilePathList files);

    /// <summary>
    /// Check if a file has been dropped into window.
    /// </summary>
    /// <returns>True if a file has been dropped, false otherwise.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsFileDropped();

    /// <summary>
    /// Load dropped filepaths.
    /// </summary>
    /// <returns>A list of file paths.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDroppedFiles();

    /// <summary>
    /// Unload dropped filepaths.
    /// </summary>
    /// <param name="files">The list of dropped files to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDroppedFiles(FilePathList files);

    /// <summary>
    /// Get file modification time (last write time).
    /// </summary>
    /// <param name="fileName">The name of the file to get the modification time from.</param>
    /// <returns>The last modification time of the file as a Unix timestamp.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial long GetFileModTime(string fileName);

    /// <summary>
    /// Compress data (DEFLATE algorithm), memory must be MemFree().
    /// </summary>
    /// <param name="data">A pointer to the data to compress.</param>
    /// <param name="dataSize">The size of the data to compress.</param>
    /// <param name="compDataSize">A pointer to an integer that will store the size of the compressed data.</param>
    /// <returns>A pointer to the compressed data.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* CompressData(byte* data, int dataSize, int* compDataSize);

    /// <summary>
    /// Decompress data (DEFLATE algorithm), memory must be MemFree().
    /// </summary>
    /// <param name="compData">The pointer to the compressed data.</param>
    /// <param name="compDataSize">The size of the compressed data.</param>
    /// <param name="dataSize">A pointer to an integer that will store the size of the decompressed data.</param>
    /// <returns>A pointer to the decompressed data.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* DecompressData(byte* compData, int compDataSize, int* dataSize);

    /// <summary>
    /// Encode data to Base64 string, memory must be MemFree().
    /// </summary>
    /// <param name="data">A pointer to the data to encode.</param>
    /// <param name="dataSize">The size of the data to encode.</param>
    /// <param name="outputSize">A pointer to an integer that will store the size of the encoded data.</param>
    /// <returns>A base64 encoded string.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static unsafe partial string EncodeDataBase64(byte* data, int dataSize, int* outputSize);

    /// <summary>
    /// Decode Base64 string data, memory must be MemFree().
    /// </summary>
    /// <param name="data">A pointer to the base64 encoded byte array.</param>
    /// <param name="outputSize">A pointer to an integer that will store the size of the decoded byte array.</param>
    /// <returns>A pointer to the decoded byte array.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* DecodeDataBase64(byte* data, int* outputSize);
}