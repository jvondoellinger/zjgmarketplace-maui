using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.Views;

public partial class ProductCardsPage : ContentPage, IDataLoader
{
    private readonly IProductQuery query;
    private readonly IProductState state;
    private readonly IPageResolver pageResolver;

    private ProductCardViewModel selectedProductViewModel;

    public ProductCardViewModel SelectedProductViewModel
    {
        get => selectedProductViewModel;
        set
        {
            Debug.WriteLine(value?.Id);
            _ = RedirectToProductPage(value);
        }
    }

    public ObservableCollection<ProductCardViewModel> ProductViewModels { get; private set; }

    public ProductCardsPage(IProductQuery query, IProductState state, IPageResolver pageResolver)
	{
        InitializeComponent();

        this.query = query;
        this.state = state;
        this.pageResolver = pageResolver;

        _ = LoadDataContext();

        BindingContext = this;
    }

    public async Task LoadDataContext()
    {
        var data = await query.QueryPagination(0, 10);

        var models = ProductCardViewModelMapper.Map(data);

        ProductViewModels = [.. models];
    }

    private async Task RedirectToProductPage(ProductCardViewModel viewModel)
    {
        state.SelectProduct(viewModel.Id); // Select productId in state

        var page = pageResolver.Resolve<ProductPage>(); // Data loader is active in Ctor from the page, when the state in the same insance (singleton). 

        await Shell.Current.Navigation.PushAsync(page); // Navigate to ProductPage

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Debug.WriteLine("Clicked");
        if (sender is VisualElement ve)
        {
            if (ve.BindingContext is ProductCardViewModel vm)
            {
                SelectedProductViewModel = vm;
            }
        }
    }
}