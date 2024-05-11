namespace Raylib_CSharp.Unsafe.Spans.Data;

public unsafe class ReadOnlySpanData<T> where T : unmanaged {

    private readonly (nint, int) _data;

    /// <summary>
    /// Initializes a new instance of the SpanData with the specified span.
    /// </summary>
    /// <param name="span">The span to encapsulate.</param>
    public ReadOnlySpanData(ReadOnlySpan<T> span) {
        fixed (T* ptr = span) {
            this._data = ((nint) ptr, span.Length);
        }
    }

    /// <summary>
    /// Initializes a new instance of the SpanData with the specified pointer and length.
    /// </summary>
    /// <param name="pointer">The pointer to the data.</param>
    /// <param name="length">The length of the span.</param>
    public ReadOnlySpanData(T* pointer, int length) {
        this._data = ((nint) pointer, length);
    }

    /// <summary>
    /// Retrieves the span encapsulated within the SpanData instance.
    /// </summary>
    /// <returns>The span encapsulated within the SpanData instance.</returns>
    public ReadOnlySpan<T> GetSpan() {
        return new ReadOnlySpan<T>((T*) this._data.Item1, this._data.Item2);
    }
}