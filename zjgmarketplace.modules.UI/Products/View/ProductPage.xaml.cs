using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.Products.Mapper;
using zjgmarketplace.Modules.UI.Products.ViewModel;
using zjgmarketplace.Modules.UI.Products.ViewModel.Test;
using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Modules.UI.Products.View;

public partial class ProductPage : ContentPage
{
    public static readonly string Route = nameof(ProductPage);

    private readonly IProductState productState;
    private readonly IProductQuery productQuery;

    public ProductViewModel ProductViewModel { get; set; }
	public ProductPage(IProductState productState, IProductQuery productQuery)
    {
        this.productState = productState;
        this.productQuery = productQuery;

        InitializeComponent();

        // Temporary data loader 
        //ProductViewModel = ProductModelTest.Load2();
        _ = Task.Run(async () => await DataLoader());


        // Verificar posteriormente uma forma async de carregamento de dados na UI

        BindingContext = this;
    }

/*    public ProductPage(ProductViewModel productViewModel)
    {
        InitializeComponent();
        ProductViewModel = productViewModel;
        BindingContext = this;
    }*/

    private async Task DataLoader()
    {
        if (productState.SelectedProductId == null) return;

        var entity = await productQuery.Find(productState.SelectedProductId);

        // Mapping entity to view model ...

        ProductViewModel = ProductViewModelMapper.Map(entity);
    }
} 