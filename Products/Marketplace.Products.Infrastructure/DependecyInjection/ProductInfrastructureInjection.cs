using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Core.State;
using Marketplace.Products.Infrastructure.Database.Query.Tests;
using Marketplace.Products.Infrastructure.Implementations.Requests;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Products.Infrastructure.DependecyInjection;

public static class ProductInfrastructureInjection
{
    public static IServiceCollection RegisterProductInfrastructureServices(this IServiceCollection services)
    {        
        // Tests
        services.AddSingleton<IProductQuery, StaticQueryDatabaseTest>();
        services.AddSingleton<IProductCategoryQuery, StaticProductCategoryQueryTest>(); 
        // -

        services.AddSingleton<IProductState, ProductState>(); 
        services.AddSingleton<IQueryProductRequest, QueryProductRequest>(); 
        services.AddSingleton<IQueryProductImageRequest, QueryProductImageRequest>(); 
        services.AddSingleton<ProductQueryImageProxy>(); 
        services.AddSingleton<ProductRequestMapper>();
        return services;

    }
}
