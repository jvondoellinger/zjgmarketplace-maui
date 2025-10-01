using Marketplace.Orders.Core.Query;
using Marketplace.Orders.Core.Workers;
using Marketplace.Orders.UI.Mapper;
using Marketplace.Orders.UI.ViewModels.Card;
using Marketplace.Orders.UI.ViewModels.Notifiers;
using System.Collections.ObjectModel;
using Marketplace.Orders.Core.Interfaces;
using Marketplace.Orders.UI.Views;
using Marketplace.Orders.Core.State;

namespace Marketplace.Orders.UI.ViewModels;

public class OrderCardsViewModel : PropertyNotifier
{
    // Services ==========================================
    private readonly IOrderQuery query;
    private readonly IOrderState state;
    private readonly IPageResolver resolver;


    // Properties ========================================
    public ObservableCollection<OrderCardViewModel> OrderCardViews { get; private set; }

    private OrderCardViewModel selectedItem;
    public OrderCardViewModel SelectedItem
    {
        get => selectedItem;
        set
        {
            AsyncWorker.RunAsync(Select(value)); // Seleciona o item e ativa o evento para carregar os dados na UI
            AsyncWorker.RunAsync(Redirect); // Redireciona mesmo sem item selecionado
            OnPropertyChanged(nameof(SelectedItem));
        }
    }


    // Contructor ========================================
    public OrderCardsViewModel(IOrderQuery query, IOrderState state, IPageResolver resolver)
    {
        this.query = query;
        this.state = state;
        this.resolver = resolver;
        AsyncWorker.RunAsync(LoadDataContext);
    }

    private async Task LoadDataContext()
    {
        var data = await query.QueryPagination(0, 100);
        var viewModels = OrderCardViewModelMapper.Map(data);
        OrderCardViews = [.. viewModels];
    }

    private async Task Select(OrderCardViewModel model)
    {
        var item = await query.QueryId(model.Id);
        state.Select(item);
    }
    private async Task Redirect()
    {
        var page = resolver.Resolve<CheckoutPage>();
        await Shell.Current.Navigation.PushAsync(page);
    }

}
