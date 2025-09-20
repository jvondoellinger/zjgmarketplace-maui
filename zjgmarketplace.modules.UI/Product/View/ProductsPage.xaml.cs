using System.Collections.ObjectModel;
using System.Diagnostics;
using zjgmarketplace.Modules.UI.Product.ViewModel;
using zjgmarketplace.Modules.UI.Product.ViewModel.Test;

namespace zjgmarketplace.Modules.UI.Product.View;

public partial class ProductsPage : ContentPage
{
    public ObservableCollection<PreviewProductViewModel> ProductViewModels { get; } = [];

    public ProductsPage()
	{
		InitializeComponent();

        // Temporary data loader
        ProductModelTest.Load().ForEach(ProductViewModels.Add);

        BindingContext = this;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine(sender.GetType());
    }
}