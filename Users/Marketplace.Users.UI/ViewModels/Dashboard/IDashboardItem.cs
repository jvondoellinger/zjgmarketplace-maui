using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public interface IDashboardItem
{
/*    protected DashboardItem(INavigation navigation, ICommand command, string title)
    {
        this.Navigation = navigation;
        this.Command = command;
        this.Title = title;
    }

    protected INavigation Navigation { get; }*/
    public string Title { get; }
    public ICommand Command { get; }
}
