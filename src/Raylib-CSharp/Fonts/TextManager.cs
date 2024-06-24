using System.Numerics;
using Raylib_CSharp.Apis;

namespace Raylib_CSharp.Fonts;

public static class TextManager {

    /// <inheritdoc cref="RaylibApi.LoadUTF8" />
    public static unsafe string LoadUTF8(ReadOnlySpan<int> codepoints) {
        fixed (int* codepointsPtr = codepoints) {
            return RaylibApi.LoadUTF8(codepointsPtr, codepoints.Length);
        }
    }

    /// <inheritdoc cref="RaylibApi.UnloadUTF8" />
    public static void UnloadUTF8(string text) {
        RaylibApi.UnloadUTF8(text);
    }

    /// <inheritdoc cref="RaylibApi.LoadCodepoints" />
    public static unsafe ReadOnlySpan<int> LoadCodepoints(string text) {
        return new ReadOnlySpan<int>(RaylibApi.LoadCodepoints(text, out int count), count);
    }

    /// <inheritdoc cref="RaylibApi.UnloadCodepoints" />
    public static unsafe void UnloadCodepoints(ReadOnlySpan<int> codepoints) {
        fixed (int* codepointsPtr = codepoints) {
            RaylibApi.UnloadCodepoints(codepointsPtr);
        }
    }

    /// <inheritdoc cref="RaylibApi.GetCodepointCount" />
    public static int GetCodepointCount(string text) {
        return RaylibApi.GetCodepointCount(text);
    }

    /// <inheritdoc cref="RaylibApi.GetCodepoint" />
    public static int GetCodepoint(string text, out int codepointSize) {
        return RaylibApi.GetCodepoint(text, out codepointSize);
    }

    /// <inheritdoc cref="RaylibApi.GetCodepointNext" />
    public static int GetCodepointNext(string text, out int codepointSize) {
        return RaylibApi.GetCodepointNext(text, out codepointSize);
    }

    /// <inheritdoc cref="RaylibApi.GetCodepointPrevious" />
    public static int GetCodepointPrevious(string text, out int codepointSize) {
        return RaylibApi.GetCodepointPrevious(text, out codepointSize);
    }

    /// <inheritdoc cref="RaylibApi.CodepointToUTF8" />
    public static string CodepointToUTF8(int codepoint, out int utf8Size) {
        return RaylibApi.CodepointToUTF8(codepoint, out utf8Size);
    }

    /// <inheritdoc cref="RaylibApi.SetTextLineSpacing" />
    public static void SetTextLineSpacing(int spacing) {
        RaylibApi.SetTextLineSpacing(spacing);
    }

    /// <inheritdoc cref="RaylibApi.MeasureText" />
    public static int MeasureText(string text, int fontSize) {
        return RaylibApi.MeasureText(text, fontSize);
    }

    /// <inheritdoc cref="RaylibApi.MeasureTextEx" />
    public static Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing) {
        return RaylibApi.MeasureTextEx(font, text, fontSize, spacing);
    }

    /// <inheritdoc cref="RaylibApi.TextCopy" />
    public static int TextCopy(string dst, string src) {
        return RaylibApi.TextCopy(dst, src);
    }

    /// <inheritdoc cref="RaylibApi.TextIsEqual" />
    public static bool TextIsEqual(string text1, string text2) {
        return RaylibApi.TextIsEqual(text1, text2);
    }

    /// <inheritdoc cref="RaylibApi.TextLength" />
    public static uint TextLength(string text) {
        return RaylibApi.TextLength(text);
    }

    /// <inheritdoc cref="RaylibApi.TextFormat" />
    public static string TextFormat(string text) {
        return RaylibApi.TextFormat(text);
    }

    /// <inheritdoc cref="RaylibApi.TextSubtext" />
    public static string TextSubtext(string text, int position, int length) {
        return RaylibApi.TextSubtext(text, position, length);
    }

    /// <inheritdoc cref="RaylibApi.TextReplace" />
    public static string TextReplace(string text, string replace, string by) {
        return RaylibApi.TextReplace(text, replace, by);
    }

    /// <inheritdoc cref="RaylibApi.TextInsert" />
    public static string TextInsert(string text, string insert, int position) {
        return RaylibApi.TextInsert(text, insert, position);
    }

    /// <inheritdoc cref="RaylibApi.TextJoin" />
    public static string TextJoin(string[] textList, string delimiter) {
        return string.Join(delimiter, textList);
    }

    /// <inheritdoc cref="RaylibApi.TextSplit" />
    public static string[] TextSplit(string text, string delimiter) {
        return text.Split(delimiter);
    }

    /// <inheritdoc cref="RaylibApi.TextAppend" />
    public static void TextAppend(string text, string append, out int position) {
        RaylibApi.TextAppend(text, append, out position);
    }

    /// <inheritdoc cref="RaylibApi.TextFindIndex" />
    public static int TextFindIndex(string text, string find) {
        return RaylibApi.TextFindIndex(text, find);
    }

    /// <inheritdoc cref="RaylibApi.TextToUpper" />
    public static string TextToUpper(string text) {
        return RaylibApi.TextToUpper(text);
    }

    /// <inheritdoc cref="RaylibApi.TextToLower" />
    public static string TextToLower(string text) {
        return RaylibApi.TextToLower(text);
    }

    /// <inheritdoc cref="RaylibApi.TextToPascal" />
    public static string TextToPascal(string text) {
        return RaylibApi.TextToPascal(text);
    }

    /// <inheritdoc cref="RaylibApi.TextToSnake" />
    public static string TextToSnake(string text) {
        return RaylibApi.TextToSnake(text);
    }

    /// <inheritdoc cref="RaylibApi.TextToCamel" />
    public static string TextToCamel(string text) {
        return RaylibApi.TextToCamel(text);
    }

    /// <inheritdoc cref="RaylibApi.TextToInteger" />
    public static int TextToInteger(string text) {
        return RaylibApi.TextToInteger(text);
    }

    /// <inheritdoc cref="RaylibApi.TextToFloat" />
    public static float TextToFloat(string text) {
        return RaylibApi.TextToFloat(text);
    }
}