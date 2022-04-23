using PlayoffsApi.Domain.SeedWork;

namespace PlayoffsApi.Domain.Weathers;

public class Weather : Entity, IAggregateRoot
{
    public WeatherId Id { get; private set; }

    public DateTime Date { get; init; }
    public int TemperatureC { get; init; }
    public int TemperatureF { get; init; }
    public string? Summary { get; init; }

    public Weather(DateTime date, int temperatureC, string? summary)
    {
        Id = new WeatherId(Guid.NewGuid());
        Date = date;
        TemperatureC = temperatureC;
        TemperatureF = 32 + (int)(TemperatureC / 0.5556);
        Summary = summary;
    }
}