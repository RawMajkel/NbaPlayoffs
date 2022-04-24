using AutoMapper;
using MediatR;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.RegisterWeather;

public class RegisterWeatherCommandHandler : IRequestHandler<RegisterWeatherCommand, WeatherDto>
{
    private readonly IWeatherRepository _weatherRepository;
    private readonly IMapper _mapper;

    public RegisterWeatherCommandHandler(IWeatherRepository weatherRepository, IMapper mapper)
    {
        _weatherRepository = weatherRepository;
        _mapper = mapper;
    }

    public async Task<WeatherDto> Handle(RegisterWeatherCommand request, CancellationToken cancellationToken)
    {
        var nextId = _weatherRepository.FindNextId();
        var weather = Weather.CreateRegistered(nextId, request.Date, request.TemperatureC, request.Summary);

        await _weatherRepository.AddAsync(weather);
        await _weatherRepository.SaveChangesAsync();

        return _mapper.Map<WeatherDto>(weather);
    }
}