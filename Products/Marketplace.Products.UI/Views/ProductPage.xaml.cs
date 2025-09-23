using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel;

namespace Marketplace.Products.UI.Views;

public partial class ProductPage : ContentPage, IDataLoader
{
    private bool isRunning = false;
    private readonly IProductState state;
    private readonly IProductQuery query;

    public ProductViewModel ProductViewModel { get; private set; }
    public ProductPage(IProductState state, IProductQuery query)
	{
        this.state = state;
        this.query = query;

        InitializeComponent();

        _ = LoadDataContext();

        BindingContext = this;

    }

    public async Task LoadDataContext()
    {
        var selected = state.SelectedProductId;

        if (selected == null) return;

        var data = await query.Find(selected);
        var mapped = ProductViewModelMapper.Map(data);
        ProductViewModel = mapped;
    }
}