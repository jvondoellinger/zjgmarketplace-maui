using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zjgmarketplace.Modules.UI.Products.ViewModel;
using zjgmarketplace.Products.Core.Entity;

namespace zjgmarketplace.Modules.UI.Products.Mapper;

internal class PreviewProductViewModelMapper
{
    internal static List<PreviewProductViewModel> Map(List<Product> products)
    {
        return [..
        products.Select((product) =>
        {
            return new PreviewProductViewModel()
            {
                ImageURL = product.ImagesURL.FirstOrDefault() ?? "fallback.png",
                Price = product.Price,
                Title = product.Title,
                Id = product.Id.ToString()
            };
        }) ];

    }
}
