using MediatR;
using PlayoffsApi.Application.Configuration.Queries;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

public class GetWeatherDetailsDapperQuery : IQuery<List<WeatherDetailsDto>>
{
    public GetWeatherDetailsDapperQuery()
    {
    }
}