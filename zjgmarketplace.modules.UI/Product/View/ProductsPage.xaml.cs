using zjgmarketplace.Modules.UI.Product.ViewModel;

namespace zjgmarketplace.Modules.UI.Product.View;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();
		BindingContext = new ProductViewModel();
    }
}