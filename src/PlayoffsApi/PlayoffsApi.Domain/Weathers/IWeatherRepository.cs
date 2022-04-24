namespace PlayoffsApi.Domain.Weathers;

public interface IWeatherRepository
{
    IEnumerable<Weather> GetWeather();

    IQueryable<Weather> GetAsQueryable();

    IEnumerable<Weather> GetFromRawSql(string sql);
}