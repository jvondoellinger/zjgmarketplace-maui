using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.Product.ViewModel;
using zjgmarketplace.Modules.UI.Product.ViewModel.Test;

namespace zjgmarketplace.Modules.UI.Product.View;

public partial class ProductPage : ContentPage
{
	public ProductViewModel ProductViewModel { get; set; }
	public ProductPage()
	{
		InitializeComponent();

        // Temporary data loader 
        ProductViewModel = ProductModelTest.Load2();

        BindingContext = this;
    }

    public ProductPage(ProductViewModel productViewModel)
    {
        InitializeComponent();
        ProductViewModel = productViewModel;
        BindingContext = this;

    }
} 