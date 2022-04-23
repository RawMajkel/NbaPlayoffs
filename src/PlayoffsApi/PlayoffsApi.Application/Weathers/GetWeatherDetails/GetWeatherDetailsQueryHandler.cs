using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

internal sealed class GetWeatherDetailsQueryHandler : IQueryHandler<GetWeatherDetailsQuery, List<WeatherDetailsDto>>
{
    private readonly IWeatherRepository _weatherRepository;

    public GetWeatherDetailsQueryHandler(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    public async Task<List<WeatherDetailsDto>> Handle(GetWeatherDetailsQuery request, CancellationToken cancellationToken)
    {
        var weather = _weatherRepository.GetWeather();
        var weatherDto = weather
            .Select(x => WeatherDetailsDto.Map(x))
            .ToList();

        return weatherDto;
    }
}