using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zjgmarketplace.Modules.UI.Product.ViewModel;

namespace zjgmarketplace.Modules.UI.Product.Mapper;

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
}
