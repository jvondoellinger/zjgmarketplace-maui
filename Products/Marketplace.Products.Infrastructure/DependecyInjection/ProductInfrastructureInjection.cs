using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.Infrastructure.Database.Query.Tests;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
