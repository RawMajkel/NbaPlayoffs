using BenchmarkDotNet.Attributes;

namespace PlayoffsApi.Tests;

[MemoryDiagnoser]
public class DapperVsEfBenchmark
{
    [Benchmark]
    public async Task SelectDapper()
    {
        var client = new HttpClient();

        try
        {
            var response = await client.GetAsync("https://localhost:7129/weather/dapper");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException e)
        {
            //Console.WriteLine("\nException Caught!");
            //Console.WriteLine("Message :{0} ", e.Message);
        }
    }

    [Benchmark]
    public async Task SelectEf()
    {
        var client = new HttpClient();

        try
        {
            var response = await client.GetAsync("https://localhost:7129/weather/ef");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException e)
        {
            //Console.WriteLine("\nException Caught!");
            //Console.WriteLine("Message :{0} ", e.Message);
        }
    }
}