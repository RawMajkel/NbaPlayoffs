using MediatR;
using PlayoffsApi.API.Configuration.Endpoints;
using PlayoffsApi.Application.Weathers.GetWeatherDetails;
using PlayoffsApi.Domain.Weathers;
using PlayoffsApi.Infrastructure.Domain.Weathers;

namespace PlayoffsApi.API.EndpointDefinitions;

public class WeatherEndpointDefinition : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/weather/dapper", GetWeatherDapper);
        app.MapGet("/weather/ef", GetWeatherEf);
        app.MapGet("/weather/efraw", GetWeatherEfRaw);
    }

    internal async Task<IResult> GetWeatherDapper(IMediator mediator)
    {
        var result = await mediator.Send(new GetWeatherDetailsDapperQuery());

        return Results.Ok(result);
    }

    internal async Task<IResult> GetWeatherEf(IMediator mediator)
    {
        var result = await mediator.Send(new GetWeatherDetailsQuery());

        return Results.Ok(result);
    }

    internal async Task<IResult> GetWeatherEfRaw(IMediator mediator)
    {
        var result = await mediator.Send(new GetWeatherDetailsRawQuery());

        return Results.Ok(result);
    }

    public void DefineServices(IServiceCollection services)
    {
        services.AddScoped<IWeatherRepository, WeatherRepository>();
    }
}