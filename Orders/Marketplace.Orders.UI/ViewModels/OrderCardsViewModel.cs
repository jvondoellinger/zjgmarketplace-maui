using Marketplace.Orders.Core.Query;
using Marketplace.Orders.Core.Workers;
using Marketplace.Orders.UI.Mapper;
using Marketplace.Orders.UI.ViewModels.Card;
using Marketplace.Orders.UI.ViewModels.Notifiers;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Marketplace.Orders.UI.ViewModels;

public class OrderCardsViewModel : PropertyNotifier
{
    // Services ==========================================
    private readonly IOrderQuery query;


    // Properties ========================================
    public ObservableCollection<OrderCardViewModel> OrderCardViews { get; private set; }

    private OrderCardViewModel selectedItem;
    public OrderCardViewModel SelectedItem
    {
        get => selectedItem;
        set
        {
            OnPropertyChanged(nameof(SelectedItem));
        }
    }


    // Contructor ========================================
    public OrderCardsViewModel(IOrderQuery query)
    {
        this.query = query;

        AsyncWorker.RunAsync(LoadDataContext);
    }

    private async Task LoadDataContext()
    {
        var data = await query.QueryPagination(0, 100);
        var viewModels = OrderCardViewModelMapper.Map(data);
        OrderCardViews = [.. viewModels];
    }
}
