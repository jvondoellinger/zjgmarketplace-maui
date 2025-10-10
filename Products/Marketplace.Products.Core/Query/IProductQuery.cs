using Marketplace.Products.Core.Model;

namespace Marketplace.Products.Core.Query;

public interface IProductQuery
{
    Task<Product?> Find(int id);
    Task<List<Product>> QueryPagination(int offset, int limit);
}
