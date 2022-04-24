using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Application.Weathers.Query;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

public class GetWeatherDetailsRawQuery : IQuery<List<WeatherDto>>
{
    public GetWeatherDetailsRawQuery()
    {
    }
}