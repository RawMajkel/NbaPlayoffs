using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

public class WeatherDetailsDto
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public int TemperatureF { get; set; }
    public string? Summary { get; set; }

    public static WeatherDetailsDto Map(Weather weather)
        => new()
        {
            Id = weather.Id.Value,
            Date = weather.Date,
            TemperatureC = weather.TemperatureC,
            TemperatureF = weather.TemperatureF,
            Summary = weather.Summary
        };
}