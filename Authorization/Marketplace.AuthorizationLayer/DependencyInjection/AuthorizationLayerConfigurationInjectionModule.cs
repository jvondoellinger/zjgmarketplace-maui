using Marketplace.AuthorizationLayer.Configs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Marketplace.AuthorizationLayer.DependencyInjection;

public static class AuthorizationLayerConfigurationInjectionModule
{
    public static IServiceCollection ConfigureAuthorizationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        Debug.WriteLine("Configuring authorization layer...");
        var section = configuration.GetRequiredSection("Api:Authorization");
        services.Configure<GuestTokenUriConfig>(section.Bind);
        services.Configure<UserTokenUriConfig>(section.Bind);
        return services;
    }
}
