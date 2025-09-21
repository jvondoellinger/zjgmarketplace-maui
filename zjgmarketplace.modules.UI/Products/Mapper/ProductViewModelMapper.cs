using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zjgmarketplace.Modules.UI.Products.ViewModel;
using zjgmarketplace.Products.Core;
using zjgmarketplace.Products.Core.Entity;

namespace zjgmarketplace.Modules.UI.Products.Mapper;

public class ProductViewModelMapper
{
    internal static ProductViewModel Map(PreviewProductViewModel previewProductViewModel)
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
            Title = product.Title,
            Description = product.Description,
            Id = product.Id.ToString()
        };
    }

}
