using Dapper;
using PlayoffsApi.Application.Configuration.Queries;
using System.Data;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

internal sealed class GetWeatherDetailsDapperQueryHandler : IQueryHandler<GetWeatherDetailsDapperQuery, List<WeatherDetailsDto>>
{
    private readonly IDbConnection _dbConnection;

    public GetWeatherDetailsDapperQueryHandler(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<List<WeatherDetailsDto>> Handle(GetWeatherDetailsDapperQuery request, CancellationToken cancellationToken)
    {
        const string sql = "SELECT " +
                   "\"Id\", " +
                   "\"Date\", " +
                   "\"TemperatureC\", " +
                   "\"TemperatureF\", " +
                   "\"Summary\" " +
                   "FROM public.\"Weather\";";

        var weather = await _dbConnection.QueryAsync<WeatherDetailsDto>(sql);
        return weather.ToList();
    }
}