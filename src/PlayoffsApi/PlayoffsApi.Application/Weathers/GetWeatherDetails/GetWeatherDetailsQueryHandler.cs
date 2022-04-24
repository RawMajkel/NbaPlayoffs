using AutoMapper;
using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Application.Weathers.Query;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

internal sealed class GetWeatherDetailsHandler : IQueryHandler<GetWeatherDetailsQuery, List<WeatherDto>>
{
    private readonly IWeatherRepository _weatherRepository;
    private readonly IMapper _mapper;

    public GetWeatherDetailsHandler(IWeatherRepository weatherRepository, IMapper mapper)
    {
        _weatherRepository = weatherRepository;
        _mapper = mapper;
    }

    public async Task<List<WeatherDto>> Handle(GetWeatherDetailsQuery request, CancellationToken cancellationToken)
    {
        var weather = _weatherRepository.GetWeather();
        var weatherDto = _mapper.Map<List<WeatherDto>>(weather);

        return weatherDto;
    }
}