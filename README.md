
# RangeEnumerator
Range should really be an enumerable

## Usage
1. Add The Package
```bash
dotnet add package RangeEnumerator;
```
2. Use it as god intended
```csharp
using RangeEnumerator;

foreach (int i in 1..10)
{
    Console.Write(i); // 123456789
}
```

## Benchmarks
You'll be able to find a benchmark comapring RangeEnumerator with two benchmarks:
1. classic for loop:
```csharp
for (int i = 0; i < 10; i++) {}
```
2. Enumerable.Range
```csharp
foreach (int i in Enumerable.Range(1, 9)) {}
```

### Results


| Method          | Mean      | Error     | StdDev    |                                                                                                                                                     
|---------------- |----------:|----------:|----------:|                                                                                                                                                     
| RangeEnumerator |  8.790 us | 0.0608 us | 0.0569 us |                                                                                                                                                     
| EnumerableRange | 10.240 us | 0.0639 us | 0.0567 us |                                                                                                                                                     
| ClassicFor      |  3.891 us | 0.0135 us | 0.0120 us |

