namespace Raylib_CSharp.Unsafe.Lists;

public class SpanList<T> where T : unmanaged {

    private List<(nint, int)> _pointers;
    public int Count => this._pointers.Count;

    /// <summary>
    /// Represents a wrapper around a collection of unmanaged memory spans of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements in the spans.</typeparam>
    public SpanList() {
        this._pointers = new List<(nint, int)>();
    }

    /// <summary>
    /// Adds a new memory span to the SpanList.
    /// </summary>
    /// <param name="span">The memory span to be added.</param>
    public unsafe void Add(Span<T> span) {
        fixed (T* ptr = span) {
            this._pointers.Add(((nint) ptr, span.Length));
        }
    }

    /// <summary>
    /// Removes a span of type T from the SpanList.
    /// </summary>
    /// <param name="span">The read-only span of type T to remove.</param>
    public unsafe void Remove(Span<T> span) {
        fixed (T* ptr = span) {
            this._pointers.Remove(((nint) ptr, span.Length));
        }
    }

    /// <summary>
    /// Removes the memory span at the specified index from the SpanList.
    /// </summary>
    /// <param name="index">The index of the memory span to remove.</param>
    public void RemoveAt(int index) {
        this._pointers.RemoveAt(index);
    }

    /// <summary>
    /// Removes all the elements from the SpanList.
    /// </summary>
    public void Clear() {
        this._pointers.Clear();
    }

    /// <summary>
    /// Determines whether the SpanList contains the specified span of type T.
    /// </summary>
    /// <param name="span">The span of type T to locate in the SpanList.</param>
    /// <returns>
    /// true if the SpanList contains the specified span; otherwise, false.
    /// </returns>
    public unsafe bool Contains(Span<T> span) {
        fixed (T* ptr = span) {
            return this._pointers.Contains(((nint) ptr, span.Length));
        }
    }

    /// <summary>
    /// Searches for the specified span within the SpanList and returns the zero-based index of the first occurrence.
    /// </summary>
    /// <param name="span">The span to locate in the SpanList.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of the specified span within the SpanList, or -1 if the span is not found.
    /// </returns>
    public unsafe int IndexOf(Span<T> span) {
        fixed (T* ptr = span) {
            return this._pointers.IndexOf(((nint) ptr, span.Length));
        }
    }

    /// <summary>
    /// Inserts a span of type T at the specified index in the SpanList.
    /// </summary>
    /// <param name="index">The zero-based index at which the span should be inserted.</param>
    /// <param name="span">The span of type T to insert.</param>
    public unsafe void Insert(int index, Span<T> span) {
        fixed (T* ptr = span) {
            this._pointers.Insert(index, ((nint) ptr, span.Length));
        }
    }

    /// <summary>
    /// Indexer for accessing the elements in the SpanList by index.
    /// </summary>
    /// <param name="index">The index of the element to access.</param>
    /// <returns>The read-only span at the specified index.</returns>
    public unsafe Span<T> this[int index] {
        get {
            if (index >= this._pointers.Count) {
                throw new IndexOutOfRangeException();
            }

            return new((T*) this._pointers[index].Item1, this._pointers[index].Item2);
        }
    }
}