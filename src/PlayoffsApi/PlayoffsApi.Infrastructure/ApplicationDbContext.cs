using Microsoft.EntityFrameworkCore;
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
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}