namespace PlayoffsApi.Domain.Weathers;

public interface IWeatherRepository
{
    IQueryable<Weather> GetAsQueryable();

    int FindNextId();

    Task AddAsync(Weather weather);

    Task SaveChangesAsync();
}