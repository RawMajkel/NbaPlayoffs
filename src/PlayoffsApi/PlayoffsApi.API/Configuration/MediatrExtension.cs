using MediatR;
using System.Reflection;

namespace PlayoffsApi.API.Configuration;

public static class MediatrExtension
{
    public static void AddMediatR(this IServiceCollection services)
    {
        var appAssembliesList = Assembly.GetEntryAssembly().GetReferencedAssemblies().ToList();
        var res = new List<Assembly>();

        appAssembliesList.ForEach(assembly => res.Add(Assembly.Load(assembly)));

        var requestHandlerTypes = GetTypes(res, typeof(IRequestHandler<,>));

        services.AddScoped<IMediator, Mediator>();
        services.AddScoped<ServiceFactory>(p => p.GetService);

        RegisterGenericTypes(services, typeof(IRequestHandler<,>), requestHandlerTypes);
    }

    private static IEnumerable<TypeInfo> GetTypes(List<Assembly> assemblies, Type genericType)
    {
        return assemblies.SelectMany(a => a.DefinedTypes
            .Where(ti => !ti.IsAbstract && !ti.IsInterface && ti.GetInterfaces()
            .Any(i => i.IsInterface && i.IsGenericType && i.GetGenericTypeDefinition() == genericType)));
    }

    private static void RegisterGenericTypes(IServiceCollection services, Type genericType, IEnumerable<TypeInfo> types, ServiceLifetime lifetime = ServiceLifetime.Transient)
    {
        foreach (var type in types)
        {
            var genType = genericType;
            var genericArguments = genericType.GetGenericArguments();
            if (genericArguments.Any())
            {
                var genericInterfaces = type.GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == genericType);
                if (!genericInterfaces.Any())
                {
                    continue;
                }
                var specifiedArguments = genericInterfaces.First().GetGenericArguments();
                genType = genericType.MakeGenericType(specifiedArguments);
            }
            services.Add(new ServiceDescriptor(genType, type, lifetime));
        }
    }
}