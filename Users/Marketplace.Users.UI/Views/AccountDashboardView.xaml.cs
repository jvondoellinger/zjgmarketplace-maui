using Marketplace.Users.UI.Interfaces;
using Marketplace.Users.UI.ViewModels.Dashboard;
using System.Collections.ObjectModel;

namespace Marketplace.Users.UI.Views;

public partial class AccountDashboardView : ContentPage, IDataLoader
{
    private readonly List<IDashboardItem> items;

    public ObservableCollection<IDashboardItem> Items { get; private set; }
    public AccountDashboardView(IEnumerable<IDashboardItem> items)
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