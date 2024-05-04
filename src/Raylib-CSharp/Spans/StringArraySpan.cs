using System.Runtime.InteropServices;
using Raylib_CSharp.Marshallers;

namespace Raylib_CSharp.Spans;

public unsafe struct StringArraySpan {

    private sbyte** _pointer;

    private int _count;

    public StringArraySpan(sbyte** pointer, int count) {
        this._pointer = pointer;
        this._count = count;
    }

    public readonly string this[int index] {
        get {
            if (index >= this._count) {
                throw new IndexOutOfRangeException();
            }

            return NonFreeUtf8StringMarshaller.ConvertToManaged((nint) this._pointer[index]);
        }
    }
}