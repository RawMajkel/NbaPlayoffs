using AutoMapper;
using PlayoffsApi.Application.Weathers.Query;

namespace PlayoffsApi.API.Configuration;

public static class AutoMapperExtension
{
    public static void AddAutoMapper(this IServiceCollection services)
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<WeatherProfile>();
        });

        var mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }
}