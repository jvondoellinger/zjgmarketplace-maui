using Marketplace.Products.Core.Model;

namespace Marketplace.Products.Core.Query;

public interface IProductCategoryQuery
{
    Task<IEnumerable<ProductCategory>> QueryAll();
}
