using Marketplace.Products.Core.Events;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel.Cards;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Marketplace.Products.UI.ViewModel;

public class ProductCartViewModel : IAddProductOnCartEvent, IRemoveProductOnCartEvent
{
    private readonly IProductQuery query;
    private readonly ProductCart cart = ProductCart.Instance;

    public ProductCartViewModel(IProductQuery query)
    {
        this.query = query;

        AsyncWorker.RunAsync(LoadDataContext);

        cart.AddedItem += async (input) => await AddItemAsync(input); // After, use interface event/handler
        cart.RemovedItem += async (input) => await RemoveItemAsync(input); // After, use interface event/handler - Subscribe(this);
    }

    public ObservableCollection<ProductCardViewModel> ProductCardViewModels { get; private set; }

    public async Task LoadDataContext()
    {
        List<ProductCardViewModel> views = [];

        foreach (var input in cart.Products)
        {
            if (input == null)
                continue;
            if (string.IsNullOrWhiteSpace(input.ProductId))
                continue;
            var product = await query.Find(input.ProductId) 
                ?? throw new Exception("This identifier isn't found in this query.");
            
            var view = ProductCardViewModelMapper.MapToCartCard(product);
            views.Add(view);
        }
        ProductCardViewModels = [.. views];
    }

    // Events ===========================================================
    public async Task AddItemAsync(ProductCartInput input)
    {
        Debug.WriteLine("Inserted ITEMMMM");

        ArgumentNullException.ThrowIfNull(input); // Validate input

        if (string.IsNullOrWhiteSpace(input.ProductId))
            return; // Invalid input     
        var product = await query.Find(input.ProductId)
            ?? throw new Exception("Current product added is not found."); // Get product details

        var view = ProductCardViewModelMapper.MapToCartCard(product); // Map to view model
        ProductCardViewModels.Add(view);
    }
    public async Task RemoveItemAsync(ProductCartInput input)
    {
        if (input == null)
            return; // Invalid input
        var card = ProductCardViewModels.FirstOrDefault(x => x.Id.Equals(input.ProductId)); // Get same instance
        ProductCardViewModels.Remove(card);
    }

}
