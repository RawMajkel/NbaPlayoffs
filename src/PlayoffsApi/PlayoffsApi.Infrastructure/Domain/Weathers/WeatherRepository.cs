using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Infrastructure.Domain.Weathers;

public class WeatherRepository : IWeatherRepository
{
    private readonly ApplicationDbContext _context;

    public WeatherRepository(ApplicationDbContext context)
        => _context = context ?? throw new ArgumentNullException(nameof(context));

    public IQueryable<Weather> GetAsQueryable()
        => _context.Weather;

    public async Task AddAsync(Weather weather)
        => await _context.Weather.AddAsync(weather);

    public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();
}