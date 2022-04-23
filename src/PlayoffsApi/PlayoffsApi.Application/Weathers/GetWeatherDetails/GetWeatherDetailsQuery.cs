using MediatR;
using PlayoffsApi.Application.Configuration.Queries;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

public class GetWeatherDetailsQuery : IQuery<List<WeatherDetailsDto>>
{
    public GetWeatherDetailsQuery()
    {
    }
}