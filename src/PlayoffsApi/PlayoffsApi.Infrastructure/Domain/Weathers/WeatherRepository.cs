using Microsoft.EntityFrameworkCore;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Infrastructure.Domain.Weathers;

public class WeatherRepository : IWeatherRepository
{
    private readonly ApplicationDbContext _context;

    public WeatherRepository(ApplicationDbContext context)
        => _context = context;

    public IEnumerable<Weather> GetWeather()
        => _context.Weather.AsEnumerable();

    public IQueryable<Weather> GetAsQueryable()
        => _context.Weather;
}