using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public interface IDashboardItem
{
    public string Title { get; }
    public ICommand Command { get; }
}
