using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.UI.ViewModel.Cards;

namespace Marketplace.Products.UI.Mapper;

internal class ProductCardViewModelMapper
{

    public ProductCardViewModelMapper()
    {

    }

    internal static List<ProductCardViewModel> MapToBuyCard(IEnumerable<Product> products)
    {
        List<ProductCardViewModel> models = [];
        foreach(var product in products)
        {   
            var source = ImageSource.FromFile("fallback.png");

            var item = new ProductCardBuyViewModel()
            {
                Image = source,
                Price = product.Price,
                Title = product.Title,
                Id = product.Id
            };
            models.Add(item);
        }
        return models;
    }

    internal static ProductCardViewModel MapToCartCard(Product product)
    {
        var source = ImageSource.FromFile("fallback.png");

        return new ProductCartCardViewModel()
        {
            Image = source,
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
