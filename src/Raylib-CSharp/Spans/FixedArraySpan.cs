namespace Raylib_CSharp.Spans;

public readonly unsafe struct FixedArraySpan<T> where T : unmanaged {

    private readonly T** _pointer;

    private readonly int _length;

    private readonly int _count;

    public FixedArraySpan(T** pointer, int length, int count) {
        this._pointer = pointer;
        this._length = length;
        this._count = count;
    }

    public ReadOnlySpan<T> this[int index] {
        get {
            if (index >= this._length) {
                throw new IndexOutOfRangeException();
            }

            return new(this._pointer[index], this._count);
        }
    }
}