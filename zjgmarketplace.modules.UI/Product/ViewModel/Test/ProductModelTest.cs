using zjgmarketplace.Modules.UI.Product.ViewModel;

namespace zjgmarketplace.Modules.UI.Product.ViewModel.Test;
public class ProductModelTest
{
    public static List<ProductViewModel> Load()
    {
        var list = new List<ProductViewModel>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(new ProductViewModel()
            {
                ImageURL = "fallback.png",
                Price = decimal.Parse("123.11"),
                Title = "Test"
            });
        }
        return list;
    }
}
