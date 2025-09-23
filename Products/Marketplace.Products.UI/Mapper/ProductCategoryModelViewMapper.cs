using Marketplace.Products.Core.Model;
using Marketplace.Products.UI.ViewModel;

namespace Marketplace.Products.UI.Mapper;

public class ProductCategoryModelViewMapper
{
    public static ProductCategoryViewModel Map(ProductCategory model)
    {
        if (model == null) return null;
        return new ProductCategoryViewModel
        {
            Id = model.Id,
            Title = model.Title
        };
    }

    public static List<ProductCategoryViewModel> Map(IEnumerable<ProductCategory> models)
        => models?.Select(Map).ToList() ?? [];
}
