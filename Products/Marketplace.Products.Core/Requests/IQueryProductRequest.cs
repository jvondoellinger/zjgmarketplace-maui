using Marketplace.Products.Core.Model;

namespace Marketplace.Products.Core.Requests;

public interface IQueryProductRequest
{
    Task<List<Product>> SendPaginationAsync(long offset, int limit);
}
