using Marketplace.Users.UI.Interfaces;
using Marketplace.Users.UI.ViewModels.Dashboard;
using System.Collections.ObjectModel;

namespace Marketplace.Users.UI.Views;

public partial class AccountDashboardPage : ContentPage, IDataLoader
{
    private readonly List<DashboardItem> items;

    public ObservableCollection<DashboardItem> Items { get; private set; }
    public AccountDashboardPage(IEnumerable<DashboardItem> items)
	{
		InitializeComponent();
        this.items = [..items];

        _ = LoadDataContext();

        BindingContext = this;
    }

    public async Task LoadDataContext()
    {
        Items = [.. items];
    }
}