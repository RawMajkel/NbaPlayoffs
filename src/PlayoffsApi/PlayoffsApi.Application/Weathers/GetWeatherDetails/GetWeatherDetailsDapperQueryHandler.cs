using Dapper;
using PlayoffsApi.Application.Configuration.Queries;
using PlayoffsApi.Application.Weathers.Query;
using System.Data;

namespace PlayoffsApi.Application.Weathers.GetWeatherDetails;

internal sealed class GetWeatherDetailsDapperQueryHandler : IQueryHandler<GetWeatherDetailsDapperQuery, List<WeatherDto>>
{
    private readonly IDbConnection _dbConnection;

    public GetWeatherDetailsDapperQueryHandler(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<List<WeatherDto>> Handle(GetWeatherDetailsDapperQuery request, CancellationToken cancellationToken)
    {
        const string sql = "SELECT " +
                   "\"Id\", " +
                   "\"Date\", " +
                   "\"TemperatureC\", " +
                   "\"TemperatureF\", " +
                   "\"Summary\" " +
                   "FROM public.\"Weather\";";

        var weather = await _dbConnection.QueryAsync<WeatherDto>(sql);
        return weather.ToList();
    }
}