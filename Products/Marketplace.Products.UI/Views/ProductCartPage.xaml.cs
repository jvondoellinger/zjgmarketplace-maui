using Marketplace.Products.Core.Events;
using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel.Cards;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Marketplace.Products.UI.Views;

public partial class ProductCartPage : ContentPage, 
    IDataLoader,
    IAddProductStateEvent,
    IRemoveProductStateEvent
{
    private readonly ProductStateComposite composite = ProductStateComposite.Instance;
    private readonly IProductQuery query;
        
    public ObservableCollection<ProductCardViewModel> ProductCardViewModels { get; private set; }
    public ProductCartPage(IProductQuery query)
	{
		InitializeComponent();

        this.query = query;

        AsyncWorker.RunAsync(LoadDataContext);
        composite.OnA(this);
        composite.OnRemoveStateSubscribe(this);
        // Carregar o ambiente para ajustar os cards (remover o buy e deixar um botão de remover).

        BindingContext = this;
    }

    public async Task LoadDataContext()
    {
        List<Product> products = [];
        foreach (var state in composite.ProductStates)
        {
            if (state == null)
                continue;
            if (string.IsNullOrWhiteSpace(state.SelectedProductId))
                continue;
            var product = await query.Find(state.SelectedProductId);
            if (product == null)
                continue;
            Debug.WriteLine("Item localized!");
            products.Add(product);
        }
        var views = ProductCardViewModelMapper.MapToCartCard(products);
        ProductCardViewModels = [.. views];
    }

    // Event handler to add a product state
    public async Task AddStateAsync(IProductState state)
    {
        if (state == null)
            return;
        if (string.IsNullOrWhiteSpace(state.SelectedProductId))
            return;
        var product = await query.Find(state.SelectedProductId);
        if (product == null)
            return;
        var view = ProductCardViewModelMapper.MapToCartCard(product);
        ProductCardViewModels.Add(view);

    }
    // Event handler to add a product state
    public async Task RemoveStateAsync(IProductState state)
    {
        if (state == null)
            return;
        if (string.IsNullOrWhiteSpace(state.SelectedProductId))
            return;
        var product = await query.Find(state.SelectedProductId);
        if (product == null)
            return;
        var card = ProductCardViewModels
            .FirstOrDefault(x => x.Id.Equals(state.SelectedProductId));
        ProductCardViewModels.Remove(card);
    }

}