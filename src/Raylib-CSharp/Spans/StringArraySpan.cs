using Raylib_CSharp.Marshallers;

namespace Raylib_CSharp.Spans;

public unsafe struct StringArraySpan {

    private sbyte** _pointer;

    private int _count;

    /// <summary>
    /// Initializes a new instance of the StringArraySpan struct with the specified pointer and count.
    /// </summary>
    /// <param name="pointer">Pointer to the array of strings.</param>
    /// <param name="count">Number of strings in the array.</param>
    public StringArraySpan(sbyte** pointer, int count) {
        this._pointer = pointer;
        this._count = count;
    }

    /// <summary>
    /// Gets the string at the specified index.
    /// </summary>
    /// <param name="index">The index of the string to get.</param>
    /// <returns>The string at the specified index.</returns>
    public readonly string this[int index] {
        get {
            if (index >= this._count) {
                throw new IndexOutOfRangeException();
            }

            return NonFreeUtf8StringMarshaller.ConvertToManaged((nint) this._pointer[index]);
        }
    }
}