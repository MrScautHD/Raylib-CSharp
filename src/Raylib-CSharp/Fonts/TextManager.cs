using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Raylib_CSharp.Marshallers;

namespace Raylib_CSharp.Fonts;

public static partial class TextManager {

    /// <summary>
    /// Load UTF-8 text encoded from codepoints array.
    /// </summary>
    /// <param name="codepoints">An array of codepoints.</param>
    /// <param name="length">The length of the codepoints array.</param>
    /// <returns>The loaded UTF-8 string.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "LoadUTF8")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static unsafe partial string LoadUtf8(int* codepoints, int length);

    /// <summary>
    /// Unload UTF-8 text encoded from codepoints array.
    /// </summary>
    /// <param name="text">The UTF-8 encoded string to unload.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UnloadUTF8", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadUtf8(string text);

    /// <summary>
    /// Load all codepoints from a UTF-8 text string, codepoints count returned by parameter.
    /// </summary>
    /// <param name="text">The text from which to load the codepoints.</param>
    /// <param name="count">The number of codepoints loaded.</param>
    /// <returns>An array of integers representing the codepoints.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int* LoadCodepoints(string text, out int count);

    /// <summary>
    /// Unload codepoints data from memory.
    /// </summary>
    /// <param name="codepoints">The array of codepoints to unload.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadCodepoints(int* codepoints);

    /// <summary>
    /// Get total number of codepoints in a UTF-8 encoded string.
    /// </summary>
    /// <param name="text">The text to count the codepoints in.</param>
    /// <returns>The number of codepoints in the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCodepointCount(string text);

    /// <summary>
    /// Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure.
    /// </summary>
    /// <param name="text">The UTF-8 encoded string.</param>
    /// <param name="codepointSize">The size of the next Unicode code point in bytes.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCodepoint(string text, out int codepointSize);

    /// <summary>
    /// Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure.
    /// </summary>
    /// <param name="text">The text to analyze.</param>
    /// <param name="codepointSize">The size of the next codepoint in bytes.</param>
    /// <returns>The next codepoint in the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCodepointNext(string text, out int codepointSize);

    /// <summary>
    /// Get previous codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure.
    /// </summary>
    /// <param name="text">The text from which to find the previous codepoint.</param>
    /// <param name="codepointSize">The size in bytes of the previous codepoint.</param>
    /// <returns>The codepoint of the previous character in the text, and its size in bytes.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCodepointPrevious(string text, out int codepointSize);

    /// <summary>
    /// Encode one codepoint into UTF-8 byte array (array length returned as parameter).
    /// </summary>
    /// <param name="codepoint">The Unicode code point to convert.</param>
    /// <param name="utf8Size">The size of the resulting UTF-8 string, in bytes.</param>
    /// <returns>The UTF-8 string representation of the given code point.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "CodepointToUTF8")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string CodepointToUtf8(int codepoint, out int utf8Size);

    /// <summary>
    /// Set vertical line spacing when drawing with line-breaks.
    /// </summary>
    /// <param name="spacing">The amount of spacing between lines. Positive values increase the spacing, negative values decrease the spacing.</param
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextLineSpacing(int spacing);

    /// <summary>
    /// Measure string width for default font.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="fontSize">The font size to use for rendering the text.</param>
    /// <returns>The width in pixels of the rendered text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int MeasureText(string text, int fontSize);

    /// <summary>
    /// Measure string size for Font.
    /// </summary>
    /// <param name="font">The font used to measure the text.</param>
    /// <param name="text">The text to measure.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <returns>The size of the measured text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);

    /// <summary>
    /// Copy one string to another, returns bytes copied.
    /// </summary>
    /// <param name="dst">The destination string.</param>
    /// <param name="src">The source string.</param>
    /// <returns>The number of characters copied.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextCopy(string dst, string src);

    /// <summary>
    /// Check if two text string are equal.
    /// </summary>
    /// <param name="text1">The first string to compare.</param>
    /// <param name="text2">The second string to compare.</param>
    /// <returns>True if the two strings are equal, false otherwise.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TextIsEqual(string text1, string text2);

    /// <summary>
    /// Get text length, checks for '\0' ending.
    /// </summary>
    /// <param name="text">The text to be measured.</param>
    /// <returns>The length of the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint TextLength(string text);

    /// <summary>
    /// Text formatting with variables (sprintf() style).
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string TextFormat(string text);

    /// <summary>
    /// Get a piece of a text string.
    /// </summary>
    /// <param name="text">The original text.</param>
    /// <param name="position">The starting position of the subtext.</param>
    /// <param name="length">The length of the subtext.</param>
    /// <returns>The subtext from the given text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string TextSubtext(string text, int position, int length);

    /// <summary>
    /// Replace text string (WARNING: memory must be freed!).
    /// </summary>
    /// <param name="text">The input text.</param>
    /// <param name="replace">The string to be replaced.</param>
    /// <param name="by">The replacement string.</param>
    /// <returns>The modified text with all occurrences of the specified string replaced.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string TextReplace(string text, string replace, string by);

    /// <summary>
    /// Insert text in a position (WARNING: memory must be freed!).
    /// </summary>
    /// <param name="text">The original string.</param>
    /// <param name="insert">The string to be inserted.</param>
    /// <param name="position">The position at which the string should be inserted.</param>
    /// <returns>The resulting string after the insertion.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string TextInsert(string text, string insert, int position);

    /// <summary>
    /// Join text strings with delimiter.
    /// </summary>
    /// <param name="textList">An array of strings.</param>
    /// <param name="count">The number of strings in the array.</param>
    /// <param name="delimiter">The delimiter used to join the strings.</param>
    /// <returns>The joined string.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static unsafe partial string TextJoin(sbyte** textList, int count, string delimiter);

    /// <summary>
    /// Split text into multiple strings.
    /// </summary>
    /// <param name="text">The string to split.</param>
    /// <param name="delimiter">The delimiter used to split the string.</param>
    /// <param name="count">The number of resulting substrings.</param>
    /// <returns>An array of substrings.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** TextSplit(string text, string delimiter, out int count);

    /// <summary>
    /// Append text at specific position and move cursor!.
    /// </summary>
    /// <param name="text">The initial text.</param>
    /// <param name="append">The string to append.</param>
    /// <param name="position">The position at which to append the string. This will be updated with the new position after the append operation.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TextAppend(string text, string append, out int position);

    /// <summary>
    /// Find first text occurrence within a string.
    /// </summary>
    /// <param name="text">The text to search within.</param>
    /// <param name="find">The string to search for.</param>
    /// <returns>The index of the first occurrence of the specified string within the given text; -1 if the string is not found.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextFindIndex(string text, string find);

    /// <summary>
    /// Get upper case version of provided string.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The uppercase version of the text.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string TextToUpper(string text);

    /// <summary>
    /// Get lower case version of provided string.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The converted text in lowercase.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string TextToLower(string text);

    /// <summary>
    /// Get Pascal case notation version of provided string.
    /// </summary>
    /// <param name="text">The string to be converted.</param>
    /// <returns>The string in Pascal case.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalUsing(typeof(NonFreeUtf8StringMarshaller))]
    public static partial string TextToPascal(string text);

    /// <summary>
    /// Get integer value from text (negative values not supported).
    /// </summary>
    /// <param name="text">The text string to convert.</param>
    /// <returns>The converted integer value.</returns>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextToInteger(string text);
}