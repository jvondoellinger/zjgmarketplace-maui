using Marketplace.Main.Infrastructure.Implementations.Redirect.Mappers;
using Marketplace.Orders.Core.Models;
using Marketplace.Orders.Core.Requests;
using Marketplace.Orders.UI.Views;
using Marketplace.Products.Core.Model;
using Marketplace.Products.UI.Interfaces;

namespace Marketplace.Main.Infrastructure.Implementations.Redirect;

public class CheckoutPageAdapterRedirect : ICheckoutPageRedirect
{
    private readonly OrderCardsPage page;
    private readonly ICreateOrderRequest request;
    private readonly ProductCart cart;
    private readonly OrderCheckoutState state;

    public CheckoutPageAdapterRedirect(OrderCardsPage page,
        ICreateOrderRequest request,
        ProductCart cart,
        OrderCheckoutState state)
    {
        this.page = page;
        this.request = request;
        this.cart = cart;
        this.state = state;
    }


    public async Task RedirectAsync() 
    {
        var model = OrderCheckoutModelAdapterMapper.Map(cart); // Get model with cart data

        var order = await request.SendAsync(model); // Send the order to backend and returns the complete model

        state.UpdateState(order); // Update state

        await Shell.Current.Navigation.PushAsync(page); // Finally, redirect...
    }
}
