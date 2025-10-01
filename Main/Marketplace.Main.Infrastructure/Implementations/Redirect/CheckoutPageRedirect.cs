using Marketplace.Orders.UI.Views;
using Marketplace.Products.UI.Interfaces;

namespace Marketplace.Main.Infrastructure.Implementations.Redirect;

public class CheckoutPageRedirect : ICheckoutPageRedirect
{
    private readonly OrderCardsPage page;

    public CheckoutPageRedirect(OrderCardsPage page)
    {
        this.page = page;
    }


    public async Task RedirectAsync() // Posteriormente, levar a area de checkout (pagamento)
    {
        await Shell.Current.Navigation.PushAsync(page);
    }
}
