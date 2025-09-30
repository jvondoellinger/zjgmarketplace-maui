using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.Interfaces;
using Marketplace.Users.UI.Views;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public class OrdersDashboardItem : DashboardItem
{

    public OrdersDashboardItem(IOrderPageRedirect redirect)
    {
        Title = "Pedidos";
        Command = new Command(async () 
            => await redirect.RedirectAsync());
    }
}
