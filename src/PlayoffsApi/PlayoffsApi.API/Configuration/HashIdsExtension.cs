using HashidsNet;

namespace PlayoffsApi.API.Configuration;

public static class HashIdsExtension
{
    public static void AddHashIds(this IServiceCollection services, string hash)
    {
        services.AddSingleton<IHashids>(new Hashids(hash, 12));
    }
}