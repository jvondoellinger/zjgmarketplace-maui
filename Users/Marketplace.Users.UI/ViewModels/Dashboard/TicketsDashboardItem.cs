using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.Views;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public class TicketsDashboardItem : DashboardItem
{
    public TicketsDashboardItem(IPageResolver resolver)
    {
        Title = "Tickets";
        Command = new Command(async () =>
        {
            var page = resolver.Resolve<UserLoginPage>(); //TEste
            await Shell.Current.Navigation.PushAsync(page);
        });
    }
}
