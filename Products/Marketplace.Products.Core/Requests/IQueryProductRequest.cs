using Marketplace.Products.Core.Model;

namespace Marketplace.Products.Core.Requests;

public interface IQueryProductRequest
{
    Task<List<Product>> QueryPaginationAsync(long offset, int limit);
    Task<Product> QueryIdAsync(string id);
}
