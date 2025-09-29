using Marketplace.Products.UI.ViewModel;

namespace Marketplace.Products.UI.Views;

public partial class ProductPage : ContentPage
{
    public ProductPage(ProductViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
    }
}