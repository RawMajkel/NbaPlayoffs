using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers;

public class WeatherQuery
{
    [UseProjection]
    public IQueryable<Weather> GetWeather([Service] IWeatherRepository weatherRepository)
        => weatherRepository.GetAsQueryable();
}