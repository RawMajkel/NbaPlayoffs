using PlayoffsApi.Application.Weathers.Query;

namespace PlayoffsApi.API.Configuration;

public static class GraphQLExtension
{
    public static void AddGraphQL(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .AddQueryType<WeatherQuery>()
            .AddProjections();
    }
}