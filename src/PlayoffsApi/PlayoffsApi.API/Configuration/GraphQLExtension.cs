using PlayoffsApi.Application.Weathers;
using PlayoffsApi.Domain.Weathers;

namespace PlayoffsApi.API.Configuration;

public static class GraphQLExtension
{
    public static void AddGraphQL(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .AddTypeConverter<WeatherId, Guid>(w => w.Value)
            .BindRuntimeType<WeatherId, UuidType>()
            .AddQueryType<WeatherQuery>(wq => wq.Name("WeatherQuery"))
            .AddProjections();
        //.AddFiltering()
        //.AddSorting();
    }
}