using Marketplace.SharedLayer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.SharedLayer.DependencyInjection;

public static class SharedLayerDependecyInjection
{
    public static IServiceCollection AddSharedLayerOnDependecyInjection(this IServiceCollection services)
    {
        services.AddSingleton<RequestService>();
        return services;
    }
}
