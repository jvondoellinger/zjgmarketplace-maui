using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.Product.ViewModel;
using zjgmarketplace.Modules.UI.Product.ViewModel.Test;

namespace zjgmarketplace.Modules.UI.Product.View;

public partial class ProductsPage : ContentPage
{
    public ObservableCollection<ProductViewModel> ProductViewModels { get; } = [];

    public ProductsPage()
	{
		InitializeComponent();

        // Temporary data loader
        ProductModelTest.Load().ForEach(ProductViewModels.Add);

        BindingContext = this;
    }
}