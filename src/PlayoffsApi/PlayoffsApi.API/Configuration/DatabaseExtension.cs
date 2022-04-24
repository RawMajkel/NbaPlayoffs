using Microsoft.EntityFrameworkCore;
using Npgsql;
using PlayoffsApi.Infrastructure;
using System.Data;

namespace PlayoffsApi.API.Configuration;

public static class DatabaseExtension
{
    public static void AddPostgreSQL(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        services.AddTransient<IDbConnection>(sp => new NpgsqlConnection(connectionString));
    }
}