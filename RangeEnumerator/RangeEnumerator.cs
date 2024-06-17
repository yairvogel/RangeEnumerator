
using System.Collections;
using System.Diagnostics;

namespace RangeEnumerator;

public static class RangeExtensions
{
    public static IEnumerator<int> GetEnumerator(this Range range) => new RangeEnumerator(range);
}

[DebuggerDisplay("Count = { range.End.Value - buffer }")]
struct RangeEnumerator(Range range) : IEnumerator<int>
{
    private int state = 1;

    public int Current { get; private set; }

    readonly object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        switch (state)
        {
            case 1:
                Current = range.Start.Value;
                state = 2;
                return Current < range.End.Value;
            case 2:
                if (++Current == range.End.Value)
                {
                    break;
                }

                return true;
        }

        state = -1;
        return false;
    }

    public void Reset()
    {
        state = -1;
    }
} 