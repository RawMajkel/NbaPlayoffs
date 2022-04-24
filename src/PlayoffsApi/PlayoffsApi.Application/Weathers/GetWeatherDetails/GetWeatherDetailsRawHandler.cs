using AutoMapper;
using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Application.Weathers.Query;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

internal sealed class GetWeatherDetailsRawHandler : IQueryHandler<GetWeatherDetailsRawQuery, List<WeatherDto>>
{
    private readonly IWeatherRepository _weatherRepository;
    private readonly IMapper _mapper;

    public GetWeatherDetailsRawHandler(IWeatherRepository weatherRepository, IMapper mapper)
    {
        _weatherRepository = weatherRepository;
        _mapper = mapper;
    }

    public async Task<List<WeatherDto>> Handle(GetWeatherDetailsRawQuery request, CancellationToken cancellationToken)
    {
        const string sql = "SELECT " +
           "\"Id\", " +
           "\"Date\", " +
           "\"TemperatureC\", " +
           "\"TemperatureF\", " +
           "\"Summary\" " +
           "FROM public.\"Weather\";";

        var weather = _weatherRepository.GetFromRawSql(sql);
        var weatherDto = _mapper.Map<List<WeatherDto>>(weather);

        return weatherDto;
    }
}