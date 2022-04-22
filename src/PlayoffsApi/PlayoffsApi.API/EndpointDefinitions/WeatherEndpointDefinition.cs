using PlayoffsApi.API.Configuration.Endpoints;

namespace PlayoffsApi.API.EndpointDefinitions;

public class WeatherEndpointDefinition : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        app.MapGet("/weatherforecast", () =>
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
               new WeatherForecast
               (
                   DateTime.Now.AddDays(index),
                   Random.Shared.Next(-20, 55),
                   summaries[Random.Shared.Next(summaries.Length)]
               ))
                .ToArray();
            return forecast;
        });
    }

    public void DefineServices(IServiceCollection services)
    {
        // Singletons if needed
    }
}