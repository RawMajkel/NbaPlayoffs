using MediatR;
using PlayoffsApi.API.Configuration.Endpoints;
using PlayoffsApi.Application.Weathers.GetWeatherDetails;

namespace PlayoffsApi.API.EndpointDefinitions;

public class WeatherEndpointDefinition : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/weather/dapper", GetWeatherDapper);
        app.MapGet("/weather/ef", GetWeatherEf);
    }

    internal async Task<IResult> GetWeatherEf(IMediator mediator)
    {
        var result = await mediator.Send(new GetWeatherDetailsQuery());

        return Results.Ok(result);
    }

    internal async Task<IResult> GetWeatherDapper(IMediator mediator)
    {
        var result = await mediator.Send(new GetWeatherDetailsDapperQuery());

        return Results.Ok(result);
    }

    public void DefineServices(IServiceCollection services)
    {
        // Singletons if needed
    }
}