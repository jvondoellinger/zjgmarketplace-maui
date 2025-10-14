using Marketplace.Products.Infrastructure.Implementations.Requests.Configs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Products.Infrastructure.DependecyInjection;

public static class ProductInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureProductInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var productSection = configuration.GetRequiredSection("Api:ProductRoutes");
        var imageSection = configuration.GetRequiredSection("Api:ImageRoutes");
        services.Configure<ProductRoutesUriConfig>(productSection.Bind);
        services.Configure<ImageRouteUriConfig>(imageSection.Bind);
        return services;
    }
}
