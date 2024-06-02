using Raylib_CSharp.Apis;

namespace Raylib_CSharp.IO;

public static class FileManager {

    /// <inheritdoc cref="RaylibApi.LoadFileData" />
    public static unsafe ReadOnlySpan<byte> LoadFileData(string fileName) {
        return new ReadOnlySpan<byte>(RaylibApi.LoadFileData(fileName, out uint dataSize), (int) dataSize);
    }

    /// <inheritdoc cref="RaylibApi.UnloadFileData" />
    public static unsafe void UnloadFileData(ReadOnlySpan<byte> data) {
        fixed (byte* dataPtr = data) {
            RaylibApi.UnloadFileData(dataPtr);
        }
    }

    /// <inheritdoc cref="RaylibApi.SaveFileData" />
    public static unsafe bool SaveFileData(string fileName, ReadOnlySpan<byte> data) {
        fixed (byte* dataPtr = data) {
            return RaylibApi.SaveFileData(fileName, (nint) dataPtr, (uint) data.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.ExportDataAsCode" />
    public static unsafe bool ExportDataAsCode(ReadOnlySpan<byte> data, string fileName) {
        fixed (byte* dataPtr = data) {
            return RaylibApi.ExportDataAsCode(dataPtr, (uint) data.Length, fileName);
        }
    }

    /// <inheritdoc cref="RaylibApi.LoadFileText" />
    public static string LoadFileText(string fileName) {
        return RaylibApi.LoadFileText(fileName);
    }

    /// <inheritdoc cref="RaylibApi.UnloadFileText" />
    public static void UnloadFileText(string text) {
        RaylibApi.UnloadFileText(text);
    }

    /// <inheritdoc cref="RaylibApi.SaveFileText" />
    public static bool SaveFileText(string fileName, string text) {
        return RaylibApi.SaveFileText(fileName, text);
    }

    /// <inheritdoc cref="RaylibApi.FileExists" />
    public static bool FileExists(string fileName) {
        return RaylibApi.FileExists(fileName);
    }

    /// <inheritdoc cref="RaylibApi.DirectoryExists" />
    public static bool DirectoryExists(string dirPath) {
        return RaylibApi.DirectoryExists(dirPath);
    }

    /// <inheritdoc cref="RaylibApi.IsFileExtension" />
    public static bool IsFileExtension(string fileName, string ext) {
        return RaylibApi.IsFileExtension(fileName, ext);
    }

    /// <inheritdoc cref="RaylibApi.GetFileLength" />
    public static int GetFileLength(string fileName) {
        return RaylibApi.GetFileLength(fileName);
    }

    /// <inheritdoc cref="RaylibApi.GetFileExtension" />
    public static string GetFileExtension(string fileName) {
        return RaylibApi.GetFileExtension(fileName);
    }

    /// <inheritdoc cref="RaylibApi.GetFileName" />
    public static string GetFileName(string filePath) {
        return RaylibApi.GetFileName(filePath);
    }

    /// <inheritdoc cref="RaylibApi.GetFileNameWithoutExt" />
    public static string GetFileNameWithoutExt(string filePath) {
        return RaylibApi.GetFileNameWithoutExt(filePath);
    }

    /// <inheritdoc cref="RaylibApi.GetDirectoryPath" />
    public static string GetDirectoryPath(string filePath) {
        return RaylibApi.GetDirectoryPath(filePath);
    }

    /// <inheritdoc cref="RaylibApi.GetPrevDirectoryPath" />
    public static string GetPrevDirectoryPath(string dirPath) {
        return RaylibApi.GetPrevDirectoryPath(dirPath);
    }

    /// <inheritdoc cref="RaylibApi.GetWorkingDirectory" />
    public static string GetWorkingDirectory() {
        return RaylibApi.GetWorkingDirectory();
    }

    /// <inheritdoc cref="RaylibApi.GetApplicationDirectory" />
    public static string GetApplicationDirectory() {
        return RaylibApi.GetApplicationDirectory();
    }

    /// <inheritdoc cref="RaylibApi.ChangeDirectory" />
    public static bool ChangeDirectory(string dir) {
        return RaylibApi.ChangeDirectory(dir);
    }

    /// <inheritdoc cref="RaylibApi.IsPathFile" />
    public static bool IsPathFile(string path) {
        return RaylibApi.IsPathFile(path);
    }

    /// <inheritdoc cref="RaylibApi.IsFileNameValid" />
    public static bool IsFileNameValid(string fileName) {
        return RaylibApi.IsFileNameValid(fileName);
    }

    /// <inheritdoc cref="RaylibApi.LoadDirectoryFiles" />
    public static FilePathList LoadDirectoryFiles(string dirPath) {
        return RaylibApi.LoadDirectoryFiles(dirPath);
    }

    /// <inheritdoc cref="RaylibApi.LoadDirectoryFilesEx" />
    public static FilePathList LoadDirectoryFilesEx(string basePath, string filter, bool scanSubDirs) {
        return RaylibApi.LoadDirectoryFilesEx(basePath, filter, scanSubDirs);
    }

    /// <inheritdoc cref="RaylibApi.UnloadDirectoryFiles" />
    public static void UnloadDirectoryFiles(FilePathList files) {
        RaylibApi.UnloadDirectoryFiles(files);
    }

    /// <inheritdoc cref="RaylibApi.IsFileDropped" />
    public static bool IsFileDropped() {
        return RaylibApi.IsFileDropped();
    }

    /// <inheritdoc cref="RaylibApi.LoadDroppedFiles" />
    public static FilePathList LoadDroppedFiles() {
        return RaylibApi.LoadDroppedFiles();
    }

    /// <inheritdoc cref="RaylibApi.UnloadDroppedFiles" />
    public static void UnloadDroppedFiles(FilePathList files) {
        RaylibApi.UnloadDroppedFiles(files);
    }

    /// <inheritdoc cref="RaylibApi.GetFileModTime" />
    public static long GetFileModTime(string fileName) {
        return RaylibApi.GetFileModTime(fileName);
    }

    /// <inheritdoc cref="RaylibApi.CompressData" />
    public static unsafe ReadOnlySpan<byte> CompressData(ReadOnlySpan<byte> data) {
        fixed (byte* dataPtr = data) {
            return new ReadOnlySpan<byte>(RaylibApi.CompressData(dataPtr, data.Length, out int compDataSize), compDataSize);
        }
    }

    /// <inheritdoc cref="RaylibApi.DecompressData" />
    public static unsafe ReadOnlySpan<byte> DecompressData(ReadOnlySpan<byte> compData) {
        fixed (byte* compDataPtr = compData) {
            return new ReadOnlySpan<byte>(RaylibApi.DecompressData(compDataPtr, compData.Length, out int dataSize), dataSize);
        }
    }

    /// <inheritdoc cref="RaylibApi.EncodeDataBase64" />
    public static unsafe string EncodeDataBase64(ReadOnlySpan<byte> data, out int outputSize) {
        fixed (byte* dataPtr = data) {
            return RaylibApi.EncodeDataBase64(dataPtr, data.Length, out outputSize);
        }
    }

    /// <inheritdoc cref="RaylibApi.DecodeDataBase64" />
    public static unsafe ReadOnlySpan<byte> DecodeDataBase64(ReadOnlySpan<byte> data) {
        fixed (byte* dataPtr = data) {
            return new ReadOnlySpan<byte>(RaylibApi.DecodeDataBase64(dataPtr, out int outputSize), outputSize);
        }
    }
}