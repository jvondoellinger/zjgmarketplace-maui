using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;

namespace Marketplace.Products.Infrastructure.Database.Query.Tests;

public class StaticProductCategoryQueryTest : IProductCategoryQuery
{
    private static readonly List<ProductCategory> _categories = StaticLoad();

    private static List<ProductCategory> StaticLoad()
    {
        var lis = new List<ProductCategory>();
        for (int i = 0; i < 20; i++)
        {
            var item = new ProductCategory()
            {
                Id = Guid.NewGuid().ToString(),
                Title = $"Category {i}",
            };
            lis.Add(item);
        }
        return lis;
    }

    public async Task<IEnumerable<ProductCategory>> QueryAll()
    {
        return _categories;
    }
}
