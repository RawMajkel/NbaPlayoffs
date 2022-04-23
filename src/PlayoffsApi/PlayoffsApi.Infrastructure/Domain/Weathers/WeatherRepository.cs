using Microsoft.EntityFrameworkCore;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Infrastructure.Domain.Weathers;

public class WeatherRepository : IWeatherRepository
{
    private readonly ApplicationDbContext _context;

    public WeatherRepository(ApplicationDbContext context)
        => _context = context;

    public async Task<Weather?> GetWeatherById(Guid id)
        => await _context.Weather.FirstOrDefaultAsync(x => x.Id.Value == id);

    public IEnumerable<Weather> GetWeather()
        => _context.Weather.AsEnumerable();
}