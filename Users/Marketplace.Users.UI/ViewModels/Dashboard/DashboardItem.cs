using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public abstract class DashboardItem
{
    public string Title { get; protected set; }
    public ICommand Command { get; protected set; }
}
