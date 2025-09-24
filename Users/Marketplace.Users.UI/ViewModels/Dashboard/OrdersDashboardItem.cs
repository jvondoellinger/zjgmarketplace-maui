using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.Views;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public class OrdersDashboardItem : DashboardItem
{

    public OrdersDashboardItem(IPageResolver resolver)
    {
        Title = "Pedidos";
        Command = new Command(async () =>
        {
            var page = resolver.Resolve<UserLoginPage>();
            await Shell.Current.Navigation.PushAsync(page);
        });
    }
}
