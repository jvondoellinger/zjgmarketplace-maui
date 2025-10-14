using Marketplace.AuthorizationLayer.Models;
using Marketplace.AuthorizationLayer.Services;
using Marketplace.AuthorizationLayer.Startup;
using Marketplace.AuthorizationLayer.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class AuthorizationLayerDenpendencyInjection
{
    public static IServiceCollection RegisterAuthorizationLayer(this IServiceCollection services)
    {
        services
            .AddAuthorizationClasses()
            .AddHttpClient(); 
        return services;
    }

    private static IServiceCollection AddHttpClient(this IServiceCollection services)
    {
        services.AddSingleton<HttpClient>();
        return services;
    }

    private static IServiceCollection AddAuthorizationClasses(this IServiceCollection services)
    {
        services.AddSingleton<BearerTokenApplier>();
        
        services.AddSingleton<UserApiToken>();
        services.AddSingleton<GuestApiToken>();

        services.AddSingleton<UserApiTokenRequest>();
        services.AddSingleton<GuestApiTokenRequest>();
        
        services.AddHostedService<LoadGuestApiToken>();
        return services;
    }
}
