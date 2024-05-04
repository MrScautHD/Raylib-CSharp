namespace Raylib_CSharp.Spans;

public readonly unsafe struct FixedArraySpan<T> where T : unmanaged {

    private readonly T** _pointer;

    private readonly int _length;

    private readonly int _count;

    /// <summary>
    /// Initializes a new instance of the FixedArraySpan class with the specified pointer, length, and count.
    /// </summary>
    /// <param name="pointer">Pointer to the array.</param>
    /// <param name="length">Length of the array.</param>
    /// <param name="count">Number of elements in each sub-array.</param>
    public FixedArraySpan(T** pointer, int length, int count) {
        this._pointer = pointer;
        this._length = length;
        this._count = count;
    }

    /// <summary>
    /// Gets a read-only span representing the sub-array at the specified index.
    /// </summary>
    /// <param name="index">The index of the sub-array.</param>
    /// <returns>A read-only span representing the sub-array.</returns>
    public ReadOnlySpan<T> this[int index] {
        get {
            if (index >= this._length) {
                throw new IndexOutOfRangeException();
            }

            return new(this._pointer[index], this._count);
        }
    }
}