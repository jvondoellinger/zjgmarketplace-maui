using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.Views;
using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public class TicketsDashboardItem : IDashboardItem
{
    public TicketsDashboardItem(IPageResolver resolver)
    {
        Command = new Command(async () =>
        {
            var page = resolver.Resolve<UserLoginPage>(); //TEste
            await Shell.Current.Navigation.PushAsync(page);
        });
    }
    public string Title { get; } = "Tickets";

    public ICommand Command { get; }
}
