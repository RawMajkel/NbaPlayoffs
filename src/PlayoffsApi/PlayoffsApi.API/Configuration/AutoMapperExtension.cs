using AutoMapper;
using HashidsNet;
using PlayoffsApi.Application.Weathers.Query;

namespace PlayoffsApi.API.Configuration;

public static class AutoMapperExtension
{
    public static void AddAutoMapper(this IServiceCollection services)
    {
        services.AddSingleton(provider => new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new WeatherProfile(provider.GetService<IHashids>()));
        })
        .CreateMapper());
    }
}