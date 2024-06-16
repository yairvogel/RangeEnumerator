
using System.Collections;

namespace RangeEnumerator;

public static class RangeExtensions
{
    public static IEnumerator<int> GetEnumerator(this Range range) => new RangeEnumerator(range);
}

class RangeEnumerator(Range range) : IEnumerator<int>
{
    private int buffer = range.Start.Value;

    public int Current { get; private set; }

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        Current = buffer;
        buffer++;
        return Current < range.End.Value;
    }

    public void Reset()
    {
        buffer = range.Start.Value;
    }
}
