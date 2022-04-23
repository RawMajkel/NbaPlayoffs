using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<Weather> Weather { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Weather>()
            .Property(w => w.Id)
            .HasConversion(new ValueConverter<WeatherId, Guid>(w => w.Value, g => new WeatherId(g)));

        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var weatherList = Enumerable.Range(1, 10)
            .Select(index => new Weather
           (
               DateTime.Now.AddDays(index),
               Random.Shared.Next(-20, 55),
               summaries[Random.Shared.Next(summaries.Length)]
           )).ToList();

        modelBuilder.Entity<Weather>().HasData(weatherList);
    }
}