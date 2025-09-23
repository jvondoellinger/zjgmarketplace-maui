using Marketplace.Products.Core.Model;

namespace Marketplace.Products.Core.Query;

public interface IProductQuery
{
    Task<Product?> Find(string id);
    Task<List<Product>> QueryPagination(int offset, int limit);
}
