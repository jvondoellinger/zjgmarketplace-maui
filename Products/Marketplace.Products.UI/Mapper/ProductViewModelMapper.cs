using Marketplace.Products.Core.Model;
using Marketplace.Products.UI.ViewModel;
using Marketplace.Products.UI.ViewModel.Cards;
using System.Diagnostics;

namespace Marketplace.Products.UI.Mapper;

public class ProductViewModelMapper
{
    internal static ProductViewModel Map(ProductCardViewModel previewProductViewModel)
    {
        return new ProductViewModel()
        {
            ImagesURL = new List<string>() { previewProductViewModel.ImageURL },
            Price = previewProductViewModel.Price,
            Title = previewProductViewModel.Title,
            Description = "Descrição não disponível"
        };
    }
    internal static ProductViewModel Map(Product product)
    {
        return new ProductViewModel()
        {
            ImagesURL = product.ImagesURL,
            Price = product.Price, 
            Title = product.Title?? "Batta",
            Description = product.Description,
            Id = product.Id.ToString()
        };
    }
    internal static List<ProductViewModel> Map(List<Product> previewProductViewModels) => previewProductViewModels.ConvertAll(Map);
}
