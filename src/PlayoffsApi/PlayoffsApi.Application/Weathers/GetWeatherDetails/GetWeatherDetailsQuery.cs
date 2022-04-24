using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Application.Weathers.Query;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

public class GetWeatherDetailsQuery : IQuery<List<WeatherDto>>
{
    public GetWeatherDetailsQuery()
    {
    }
}