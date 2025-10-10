using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.Infrastructure.Database.Query.Tests;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Products.Infrastructure.DependecyInjection;

public static class ProductInfrastructureInjection
{
    public static IServiceCollection RegisterProductInfrastructureServices(this IServiceCollection services)
    {        
        services.AddSingleton<IProductQuery, StaticQueryDatabaseTest>();
        services.AddSingleton<IProductCategoryQuery, StaticProductCategoryQueryTest>(); 
        services.AddSingleton<IProductState, ProductState>(); 
        return services;
    }
}
