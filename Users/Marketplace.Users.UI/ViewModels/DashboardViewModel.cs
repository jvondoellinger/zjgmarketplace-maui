using Marketplace.Users.Core.Worker;
using Marketplace.Users.UI.Interfaces;
using Marketplace.Users.UI.ViewModels.Dashboard;
using Marketplace.Users.UI.ViewModels.Notifiers;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Marketplace.Users.UI.ViewModels;

public class DashboardViewModel : PropertyNotifier
{
    private readonly IEnumerable<DashboardItem> items;
    private readonly IOrderPageRedirect redirect;

    public DashboardViewModel(IEnumerable<DashboardItem> items, IOrderPageRedirect redirect)
    {
        this.items = items;
        this.redirect = redirect;
        InitializeProperties();
    }

    // Methods ========================================================================== 
    private void InitializeProperties()
    {
        DashboardItems = [.. items];
    }


    // Properties =======================================================================
    public ObservableCollection<DashboardItem> DashboardItems { get; private set; }
    private DashboardItem selectedItem;
    public DashboardItem SelectedItem
    {
        get => selectedItem;
        set
        {
            AsyncWorker.RunAsync(redirect.RedirectAsync); // Redireciona de forma async para a página
            OnPropertyChanged(nameof(SelectedItem));
            selectedItem = null;
        }
    }
}
