namespace RangeEnumerator.Tests;

public class RangeEnumeratorTests
{
    [Fact]
    public void ShouldBeAbleToCallGetEnumreator()
    {
        Range range = 1..10;
        range.GetEnumerator();
    }

    [Fact]
    public void ShouldProuceCorrectRange()
    {
        List<int> list = new();
        foreach (int i in 1..10)
        {
            list.Add(i);
        }

        Assert.True(list.SequenceEqual(Enumerable.Range(1, 9)), $"got {string.Join(", ", list)}");
    }

    [Fact]
    public void ShouldHandleEmptyRanges()
    {
        Assert.Equal(0, Count((1..1).GetEnumerator()));
    }

    private int Count<T>(IEnumerator<T> enumerator)
    {
        int c = 0;
        while (enumerator.MoveNext()) c++;
        return c;
    }
}
