namespace PlayoffsApi.Domain.Weathers;

public interface IWeatherRepository
{
    Task<Weather?> GetWeatherById(Guid id);

    IEnumerable<Weather> GetWeather();
}