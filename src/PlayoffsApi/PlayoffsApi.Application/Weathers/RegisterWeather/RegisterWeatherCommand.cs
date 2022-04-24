using MediatR;

namespace PlayoffsApi.Application.Weathers.RegisterWeather;

public class RegisterWeatherCommand : IRequest<WeatherDto>
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }

    public RegisterWeatherCommand(DateTime date, int temperatureC, string summary)
    {
        Date = date;
        TemperatureC = temperatureC;
        Summary = summary;
    }
}