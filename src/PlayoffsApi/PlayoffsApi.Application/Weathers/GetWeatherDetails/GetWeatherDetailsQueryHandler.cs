using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Domain.Weathers;
using System.Data;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

internal sealed class GetWeatherDetailsHandler : IQueryHandler<GetWeatherDetailsQuery, List<WeatherDetailsDto>>
{
    private readonly IWeatherRepository _weatherRepository;

    public GetWeatherDetailsHandler(IWeatherRepository weatherRepository)
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