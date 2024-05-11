namespace Raylib_CSharp.Unsafe;

public class SpanList<T> where T : unmanaged {

    private List<(nint, int)> _pointers;

    /// <summary>
    /// Represents a wrapper around a collection of unmanaged memory spans of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements in the spans.</typeparam>
    public SpanList() {
        this._pointers = new List<(nint, int)>();
    }

    /// <summary>
    /// Adds a new memory span to the UnmanagedSpanList.
    /// </summary>
    /// <param name="span">The memory span to be added.</param>
    public unsafe void Add(Span<T> span) {
        fixed (T* ptr = span) {
            this._pointers.Add(((nint) ptr, span.Length));
        }
    }

    /// <summary>
    /// Adds a read-only span of type T to the UnmanagedSpanList.
    /// </summary>
    /// <param name="span">The read-only span of type T to add.</param>
    public unsafe void Add(ReadOnlySpan<T> span) {
        fixed (T* ptr = span) {
            this._pointers.Add(((nint) ptr, span.Length));
        }
    }

    /// <summary>
    /// Indexer for accessing the elements in the UnmanagedSpanList by index.
    /// </summary>
    /// <param name="index">The index of the element to access.</param>
    /// <returns>The read-only span at the specified index.</returns>
    public unsafe ReadOnlySpan<T> this[int index] {
        get {
            if (index >= this._pointers.Count) {
                throw new IndexOutOfRangeException();
            }

            return new((T*) this._pointers[index].Item1, this._pointers[index].Item2);
        }
    }
}