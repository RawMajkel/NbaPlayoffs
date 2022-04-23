using PlayoffsApi.Domain.Weathers;
using PlayoffsApi.Infrastructure.Domain.Weathers;

namespace PlayoffsApi.API.Configuration
{
    public static class RepositoriesExtension
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IWeatherRepository, WeatherRepository>();
        }
    }
}