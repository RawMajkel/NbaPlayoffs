using PlayoffsApi.Application.Configuration.Queries;

namespace PlayoffsApi.Application.Weather.GetWeatherDetails;

internal sealed class GetWeatherDetailsQueryHandler : IQueryHandler<GetWeatherDetailsQuery, List<WeatherDetailsDto>>
{
    public GetWeatherDetailsQueryHandler()
    {
    }

    public async Task<List<WeatherDetailsDto>> Handle(GetWeatherDetailsQuery request, CancellationToken cancellationToken)
    {
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var weatherList = Enumerable.Range(1, 10)
            .Select(index => new Domain.Weather.Weather
           (
               DateTime.Now.AddDays(index),
               Random.Shared.Next(-20, 55),
               summaries[Random.Shared.Next(summaries.Length)]
           )).ToList();

        var weatherDtoList = weatherList
            .Select(x => new WeatherDetailsDto()
            {
                Id = x.Id.Value,
                Date = x.Date,
                TemperatureC = x.TemperatureC,
                TemperatureF = x.TemperatureF,
                Summary = x.Summary
            }).ToList();

        return weatherDtoList;
    }
}