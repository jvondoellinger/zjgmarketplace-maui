using Marketplace.Products.UI.ViewModel;

namespace Marketplace.Products.UI.Views;

public partial class ProductCardsPage : ContentPage
{
    public ProductCardsPage(ProductCardsViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
    }

}