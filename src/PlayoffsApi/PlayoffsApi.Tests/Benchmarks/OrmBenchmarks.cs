using BenchmarkDotNet.Attributes;

namespace PlayoffsApi.Tests.Benchmarks;

[MemoryDiagnoser]
[MinIterationTime(100.0)]
public class OrmBenchmarks
{
    [Benchmark]
    public async Task SelectDapper()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://localhost:7129/weather/dapper");

        //response.EnsureSuccessStatusCode();
    }

    [Benchmark]
    public async Task SelectEf()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://localhost:7129/weather/ef");

        //response.EnsureSuccessStatusCode();
    }

    [Benchmark]
    public async Task SelectEfRaw()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://localhost:7129/weather/efraw");

        //response.EnsureSuccessStatusCode();
    }

    [Benchmark]
    public async Task SelectGraphQL()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://localhost:7129/graphql?query={weather{id,date,temperatureC,temperatureF,summary}}");

        //response.EnsureSuccessStatusCode();
    }
}