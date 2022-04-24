using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlayoffsApi.API.Configuration.Endpoints;
using PlayoffsApi.Application.Weathers.RegisterWeather;
using PlayoffsApi.Domain.Weathers;
using PlayoffsApi.Infrastructure.Domain.Weathers;

namespace PlayoffsApi.API.EndpointDefinitions;

public class WeatherEndpointDefinition : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapPost("/weather", AddWeather);
    }

    internal async Task<IResult> AddWeather([FromBody] RegisterWeatherRequest request, IMediator mediator)
    {
        var weather = await mediator.Send(new RegisterWeatherCommand(request.Date, request.TemperatureC, request.Summary));

        return Results.Created(string.Empty, weather);
    }

    public void DefineServices(IServiceCollection services)
    {
        services.AddScoped<IWeatherRepository, WeatherRepository>();
    }
}