using Marketplace.Products.Infrastructure.Implementations.Requests.Configs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Marketplace.Products.Infrastructure.DependecyInjection;

public static class ProductInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureProductInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        Debug.WriteLine("Configuring product layer...");
        var productSection = configuration.GetRequiredSection("Api:ProductRoutes");
        var imageSection = configuration.GetRequiredSection("Api:ImageRoutes");
        services.Configure<ProductRoutesUriConfig>(productSection.Bind);
        services.Configure<ImageRouteUriConfig>(imageSection.Bind);
        return services;
    }
}
