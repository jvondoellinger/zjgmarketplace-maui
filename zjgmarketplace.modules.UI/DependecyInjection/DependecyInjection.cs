using zjgmarketplace.Modules.UI.Products.View;
using zjgmarketplace.Products.Infrastructure.DependecyInjection;

namespace zjgmarketplace.Modules.UI.DependecyInjection;

internal static class DependecyInjection
{
    internal static IServiceCollection AddAllDependencies(this IServiceCollection services)
    {
        services
            .AddPages()
            .AddProductLayerInfrastructure();
        return services;
    }

    private static IServiceCollection AddPages(this IServiceCollection services)
    {
        services
            .AddScoped<PreviewProductsPage>()
            .AddScoped<ProductPage>();
        return services;
    }
}
