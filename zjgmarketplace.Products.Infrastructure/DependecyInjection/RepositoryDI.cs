using Microsoft.Extensions.DependencyInjection;
using zjgmarketplace.Products.Core.Entity;
using zjgmarketplace.Products.Core.Interface;
using zjgmarketplace.Products.Infrastructure.Query.Tests;

namespace zjgmarketplace.Products.Infrastructure.DependecyInjection;

public static class RepositoryDI
{
    public static IServiceCollection AddProductLayerInfrastructure(this IServiceCollection services)
    {
        services.AddRepositoryDI();
        return services;
    }
    internal static IServiceCollection AddRepositoryDI(this IServiceCollection services)
    {
        services.AddSingleton<IProductState, ProductState>();
        // services.AddScoped<IProductCommand, MemoryProductCommand>();
        services.AddScoped<IProductQuery, MemoryProductQuery>();
        return services;
    }
}
