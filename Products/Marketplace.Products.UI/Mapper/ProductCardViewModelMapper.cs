using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.State;
using Marketplace.Products.UI.ViewModel.Cards;

namespace Marketplace.Products.UI.Mapper;

internal class ProductCardViewModelMapper
{
    internal static List<ProductCardViewModel> MapToBuyCard(IEnumerable<Product> products)
    {
        return [..
        products.Select((product) =>
        {
            return new ProductCardBuyViewModel()
            {
                ImageURL = product.ImagesURL.FirstOrDefault(),
                Price = product.Price,
                Title = product.Title,
                Id = product.Id
            };
        }) ];

    }

    internal static ProductCardViewModel MapToCartCard(Product product)
    {
        return new ProductCartCardViewModel()
            {
                ImageURL = product.ImagesURL.FirstOrDefault(),
                Price = product.Price,
                Title = product.Title,
                Id = product.Id
            };
    }

    internal static List<ProductCardViewModel> MapToCartCard(IEnumerable<Product> products)
    {
        return [.. products.Select(MapToCartCard) ];

    }
}
