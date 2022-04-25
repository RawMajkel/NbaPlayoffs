namespace PlayoffsApi.Domain.Weathers;

public interface IWeatherRepository
{
    IQueryable<Weather> GetAsQueryable();

    Task AddAsync(Weather weather);

    Task SaveChangesAsync();
}