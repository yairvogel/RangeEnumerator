
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using RangeEnumerator;

BenchmarkRunner.Run<RangeEnumeratorBenchmark>();


public class RangeEnumeratorBenchmark
{
    [Params(1, 100, 10_000)]
    public int N;


    private int[] ourBuffer = [];
    private int[] enumerableBuffer = [];
    private int[] classicBuffer = [];

    [GlobalSetup]
    public void GlobalSetup()
    {
        ourBuffer = new int[N];
        enumerableBuffer = new int[N];
        classicBuffer = new int[N];
    }
    
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
