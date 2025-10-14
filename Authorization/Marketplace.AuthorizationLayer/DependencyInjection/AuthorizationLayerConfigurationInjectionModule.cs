using Marketplace.AuthorizationLayer.Configs;
using Marketplace.AuthorizationLayer.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.AuthorizationLayer.DependencyInjection;

public static class AuthorizationLayerConfigurationInjectionModule
{
    public static IServiceCollection ConfigureAuthorizationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetRequiredSection("Api:Authorization");
        services.Configure<GuestTokenUriConfig>(section.Bind);
        services.Configure<UserTokenUriConfig>(section.Bind);
        return services;
    }
}
