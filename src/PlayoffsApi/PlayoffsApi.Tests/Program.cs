using BenchmarkDotNet.Running;

namespace PlayoffsApi.Tests;

public class Program
{
    private static async Task Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<DapperVsEfVsGqlBenchmark>();
        Console.ReadLine();
    }
}