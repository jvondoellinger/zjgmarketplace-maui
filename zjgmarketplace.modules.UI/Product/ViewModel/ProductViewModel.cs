using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.Product.Model;

namespace zjgmarketplace.Modules.UI.Product.ViewModel
{
    public class ProductViewModel
    {
        public ObservableCollection<ProductModel> Products { get; }
        public ProductViewModel()
        {
            Products = new ObservableCollection<ProductModel>(ProductModelTest.Load()); // Before remove...
        }
    }
}
