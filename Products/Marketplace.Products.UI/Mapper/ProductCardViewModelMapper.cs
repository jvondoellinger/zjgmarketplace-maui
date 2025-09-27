using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.State;
using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.Mapper;

internal class ProductCardViewModelMapper
{
    internal static List<ProductCardViewModel> Map(IEnumerable<Product> products)
    {
        return [..
        products.Select((product) =>
        {
            return new ProductCardViewModel()
            {
                ImageURL = product.ImagesURL.FirstOrDefault(),
                Price = product.Price,
                Title = product.Title,
                Id = product.Id.ToString()
            };
        }) ];

    }
}
