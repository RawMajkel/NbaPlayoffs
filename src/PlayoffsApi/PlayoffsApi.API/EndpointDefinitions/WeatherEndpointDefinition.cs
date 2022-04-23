using MediatR;
using PlayoffsApi.API.Configuration.Endpoints;
using PlayoffsApi.Application.Weathers.GetWeatherDetails;

namespace PlayoffsApi.API.EndpointDefinitions;

public class WeatherEndpointDefinition : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/weatherforecast", GetWeather);
    }

    internal async Task<IResult> GetWeather(IMediator mediator)
    {
        var result = await mediator.Send(new GetWeatherDetailsQuery());

        return Results.Ok(result);
    }

    public void DefineServices(IServiceCollection services)
    {
        // Singletons if needed
    }
}