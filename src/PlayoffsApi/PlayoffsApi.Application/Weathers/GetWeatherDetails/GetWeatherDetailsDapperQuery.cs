using MediatR;
using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Application.Weathers.Query;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

public class GetWeatherDetailsDapperQuery : IQuery<List<WeatherDto>>
{
    public GetWeatherDetailsDapperQuery()
    {
    }
}