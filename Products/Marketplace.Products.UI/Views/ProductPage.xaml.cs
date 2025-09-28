using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel;
using System.Diagnostics;

namespace Marketplace.Products.UI.Views;

public partial class ProductPage : ContentPage, IDataLoader
{
    private readonly IProductState state;
    private readonly IProductQuery query;

    public ProductViewModel ProductViewModel { get; private set; }
    public ProductPage(IProductState state, IProductQuery query)
	{
        this.state = state;
        this.query = query;

        InitializeComponent();

        AsyncWorker.RunAsync(LoadDataContext);

        BindingContext = ProductViewModel;

    }

    public async Task LoadDataContext()
    {
        var selected = state.SelectedProductId;

        var data = await query.Find(selected);

        var mapped = ProductViewModelMapper.Map(data);
        ProductViewModel = mapped;
    }
}