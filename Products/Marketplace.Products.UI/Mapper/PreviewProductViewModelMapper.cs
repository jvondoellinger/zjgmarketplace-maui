using Marketplace.Products.Core.Model;
using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.Mapper;

internal class PreviewProductViewModelMapper
{
    internal static List<PreviewProductViewModel> Map(List<Product> products)
    {
        return [..
        products.Select((product) =>
        {
            return new PreviewProductViewModel()
            {
                ImageURL = product.ImagesURL.FirstOrDefault(),
                Price = product.Price,
                Title = product.Title,
                Id = product.Id.ToString()
            };
        }) ];

    }
}
