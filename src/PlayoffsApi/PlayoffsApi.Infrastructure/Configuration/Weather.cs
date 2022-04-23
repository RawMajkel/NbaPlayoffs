using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Infrastructure.Configuration;

public class WeatherBuilder : IEntityTypeConfiguration<Weather>
{
    public void Configure(EntityTypeBuilder<Weather> builder)
    {
        builder
            .Property(w => w.Id)
            .HasConversion(new ValueConverter<WeatherId, Guid>(w => w.Value, g => new WeatherId(g)));

        builder.HasData(GetBogusWeatherData());
    }

    private static List<Weather> GetBogusWeatherData()
    {
        var summaries = new[]
           {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var weather = Enumerable.Range(1, 10).Select(index => new Weather
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ));

        return weather.ToList();
    }
}