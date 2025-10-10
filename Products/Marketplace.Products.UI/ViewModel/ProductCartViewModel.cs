using Marketplace.Products.Core.Events;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel.Cards;
using Marketplace.Products.UI.ViewModel.Notifiers;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Marketplace.Products.UI.ViewModel;

public class ProductCartViewModel : PropertyNotifier, IAddProductOnCartEvent, IRemoveProductOnCartEvent 
{
    private readonly IProductQuery query;
    private readonly ICheckoutPageRedirect redirect;
    private readonly ProductCart cart = ProductCart.Instance;


    public ProductCartViewModel(IProductQuery query, 
        ICheckoutPageRedirect redirect)
    {
        this.query = query;
        this.redirect = redirect;
        AsyncWorker.RunAsync(this.InitializeDataContent);

        this.InitializeCommands();
        this.SubscribeOnEvents();
    }


    // Properties =======================================================

    public ObservableCollection<ProductCardViewModel> ProductCardViewModels { get; private set; }

    public decimal TotalPrice
    {
        get => cart.TotalPrice;
        set
        {
            OnPropertyChanged(nameof(TotalPrice));
        }
    }

    public ICommand SendOrderCommand { get; private set; }


    // Initializes ==========================================================
    private async Task InitializeDataContent()
    {
        List<ProductCardViewModel> views = [];

        foreach (var input in cart.Products)
        {
            if (input == null)
                continue;
            var product = await query.Find(input.ProductId) 
                ?? throw new Exception("This identifier isn't found in this query.");
            
            var view = ProductCardViewModelMapper.MapToCartCard(product);
            views.Add(view);
        }
        ProductCardViewModels = [.. views];
    }
    private void SubscribeOnEvents()
    {
        cart.AddedItem += async (input) => await AddItemAsync(input); // After, use interface event/handler
        cart.RemovedItem += async (input) => await RemoveItemAsync(input); // After, use interface event/handler - Subscribe(this);

    }
    private void InitializeCommands()
    {
        SendOrderCommand = new Command(async () =>
        {
            try
            {
                await redirect.RedirectAsync();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Erro ao finalizar pedido.", ex.Message, "Ok");
            }
        });
    }


    // Events ===========================================================
    public async Task AddItemAsync(ProductCartInput input)
    {
        ArgumentNullException.ThrowIfNull(input); // Validate input
        var product = await query.Find(input.ProductId)
            ?? throw new Exception("Current product added is not found."); // Get product details

        var view = ProductCardViewModelMapper.MapToCartCard(product); // Map to view model
        ProductCardViewModels.Add(view);
        TotalPrice++;
    }

    public async Task RemoveItemAsync(ProductCartInput input)
    {
        if (input == null)
            return; // Invalid input
        var card = ProductCardViewModels.FirstOrDefault(x => x.Id.Equals(input.ProductId)); // Get same instance
        
        ProductCardViewModels.Remove(card);
        TotalPrice--;
    }

}
