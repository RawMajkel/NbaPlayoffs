using HotChocolate.Resolvers;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.Query;

public class WeatherQuery
{
    [UseProjection]
    public IQueryable<WeatherDto> GetWeather([Service] IWeatherRepository weatherRepository, IResolverContext context)
        => weatherRepository
            .GetAsQueryable()
            .ProjectTo<Weather, WeatherDto>(context);
}