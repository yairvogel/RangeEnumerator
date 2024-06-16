```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.301
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method          | Mean      | Error     | StdDev    |
|---------------- |----------:|----------:|----------:|
| RangeEnumerator |  8.790 μs | 0.0608 μs | 0.0569 μs |
| EnumerableRange | 10.240 μs | 0.0639 μs | 0.0567 μs |
| ClassicFor      |  3.891 μs | 0.0135 μs | 0.0120 μs |
