namespace PlayoffsApi.Application.Weathers.RegisterWeather;

public class RegisterWeatherRequest
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }
}