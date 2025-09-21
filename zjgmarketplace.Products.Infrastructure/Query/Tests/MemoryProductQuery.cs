using zjgmarketplace.Products.Core.Entity;
using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Products.Infrastructure.Query.Tests;

public class MemoryProductQuery : IProductQuery
{

    public async Task<Product> Find(string id)
    {
        return ProductMemoryRepositoryTest
            .Products
            .Find(p => p.Id.Equals(id));
    }

    public async Task<List<Product>> QueryPagination(int offset, int limit)
    {
        return [.. ProductMemoryRepositoryTest
            .Products
            .Skip(offset)
            .Take(limit)
            ];
    }


}