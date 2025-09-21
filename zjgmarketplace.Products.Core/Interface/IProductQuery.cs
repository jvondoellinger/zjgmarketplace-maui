using zjgmarketplace.Products.Core.Entity;

namespace zjgmarketplace.Products.Core.Interface
{
    public interface IProductQuery
    {
        Task<Product> Find(string id);
        Task<List<Product>> QueryPagination(int offset, int limit);
    }
}
