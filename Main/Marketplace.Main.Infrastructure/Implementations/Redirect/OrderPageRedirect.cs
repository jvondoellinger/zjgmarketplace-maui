using Marketplace.Orders.UI.Views;
using Marketplace.Users.UI.Interfaces;
using Microsoft.Maui.Controls;

namespace Marketplace.Main.Infrastructure.Implementations.Redirect;

public class OrderPageRedirect : IOrderPageRedirect
{
    private readonly OrderCardsPage page;

    public OrderPageRedirect(OrderCardsPage page)
    {
        this.page = page;
    }
    public async Task RedirectAsync()
    {
        await Shell.Current.CurrentPage.Navigation.PushAsync(page);
    }
}
