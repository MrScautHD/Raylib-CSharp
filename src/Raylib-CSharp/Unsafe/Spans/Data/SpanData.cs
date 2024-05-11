namespace Raylib_CSharp.Unsafe.Spans.Data;

public unsafe class SpanData<T> where T : unmanaged {

    private readonly (nint, int) _data;

    /// <summary>
    /// Initializes a new instance of the SpanData with the specified span.
    /// </summary>
    /// <param name="span">The span to encapsulate.</param>
    public SpanData(Span<T> span) {
        fixed (T* ptr = span) {
            this._data = ((nint) ptr, span.Length);
        }
    }

    /// <summary>
    /// Initializes a new instance of the SpanData with the specified pointer and length.
    /// </summary>
    /// <param name="pointer">The pointer to the data.</param>
    /// <param name="length">The length of the span.</param>
    public SpanData(T* pointer, int length) {
        this._data = ((nint) pointer, length);
    }

    /// <summary>
    /// Retrieves the span encapsulated within the SpanData instance.
    /// </summary>
    /// <returns>The span encapsulated within the SpanData instance.</returns>
    public Span<T> GetSpan() {
        return new Span<T>((T*) this._data.Item1, this._data.Item2);
    }
}