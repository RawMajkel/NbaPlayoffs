using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.DomainServices;

public class WeatherIdChecker
{
    private readonly IWeatherRepository _weatherRepository;

    public WeatherIdChecker(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }
}