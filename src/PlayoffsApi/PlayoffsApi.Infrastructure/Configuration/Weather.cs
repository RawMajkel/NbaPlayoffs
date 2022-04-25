using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
            .HasConversion(new ValueConverter<WeatherId, int>(w => w.Value, g => new WeatherId(g)))
            .ValueGeneratedOnAdd()
            .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

        builder.HasData(GetBogusWeatherData());
    }

    private static List<Weather> GetBogusWeatherData()
    {
        var summaries = new[]
           {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var weather = Enumerable.Range(1, 50).Select(index => new Weather
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)],
            index
        ));

        return weather.ToList();
    }
}