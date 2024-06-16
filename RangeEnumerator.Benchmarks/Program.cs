
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using RangeEnumerator;

BenchmarkRunner.Run<RangeEnumeratorBenchmark>();


public class RangeEnumeratorBenchmark
{
    private const int N = 10_000;

    private readonly int[] ourBuffer = new int[N];
    private readonly int[] enumerableBuffer = new int[N];
    private readonly int[] classicBuffer = new int[N];
    
    [Benchmark]
    public void RangeEnumerator()
    {
        foreach (int i in 0..N)
        {
            enumerableBuffer[i] = i;
        }
    }

    [Benchmark]
    public void EnumerableRange()
    {
        foreach (int i in Enumerable.Range(0, N))
        {
            enumerableBuffer[i] = i;
        }
    }

    [Benchmark]
    public void ClassicFor()
    {
        for (int i = 0; i < N; i++)
        {
            classicBuffer[i] = i;
        }
    }

}
