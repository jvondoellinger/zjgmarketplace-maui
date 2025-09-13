using zjgmarketplace.Modules.UI.ViewModels;

namespace zjgmarketplace.Modules.UI.View;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();
		BindingContext = new ProductViewModel();
    }
}