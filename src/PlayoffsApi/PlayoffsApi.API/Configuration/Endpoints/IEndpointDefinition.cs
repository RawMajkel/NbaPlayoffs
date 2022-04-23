namespace PlayoffsApi.API.Configuration.Endpoints;

public interface IEndpointDefinition
{
    void DefineEndpoints(WebApplication app);

    void DefineServices(IServiceCollection services);
}