using Marketplace.Orders.Core.Models;
using Marketplace.Orders.Core.Requests;
using Marketplace.Orders.UI.ViewModels.Card;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Marketplace.Orders.UI.ViewModels;

public class CheckoutViewModel
{
    private readonly ICreateOrderRequest request;
    private readonly OrderCheckoutState state;

    public ObservableCollection<ItemOnOrderViewModel> ItemsOnOrder { get; private set; }
    public CheckoutViewModel(ICreateOrderRequest request, OrderCheckoutState state)
    {
        this.request = request;
        this.state = state;

        InitializeCommands();
    }

    public int OrderId { get; private set; }
    public decimal Total { get; init; }
    public ICommand RedirectToPaymentCommand { get; private set; } 

    private void InitializeCommands()
    {
        RedirectToPaymentCommand = new Command(() =>
        {
            request.SendAsync(state.Current);
        });
    }
}
