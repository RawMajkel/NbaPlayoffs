using PlayoffsApi.Domain.SeedWork;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayoffsApi.Domain.Weathers;

public class Weather : Entity, IAggregateRoot
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public WeatherId Id { get; private set; }

    public DateTime Date { get; init; }
    public int TemperatureC { get; init; }
    public int TemperatureF { get; init; }
    public string Summary { get; init; }

    private Weather()
    {
    }

    public Weather(DateTime date, int temperatureC, string summary, int index = 0)
    {
        Id = new WeatherId(index);
        Date = date;
        TemperatureC = temperatureC;
        TemperatureF = 32 + (int)(TemperatureC / 0.5556);
        Summary = summary;
    }

    public static Weather CreateRegistered(
        DateTime date,
        int temperatureC,
        string summary)
    {
        return new Weather(date, temperatureC, summary);
    }
}