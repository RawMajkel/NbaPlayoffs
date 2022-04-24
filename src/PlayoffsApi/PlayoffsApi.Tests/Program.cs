using BenchmarkDotNet.Running;
using PlayoffsApi.Tests.Benchmarks;

namespace PlayoffsApi.Tests;

public class Program
{
    private static async Task Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<OrmBenchmarks>();
        Console.ReadLine();
    }
}

//Default -> The minimum observed iteration time is 3.8522 ms which is very small