using Marketplace.Users.Core.Interfaces;
using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels.Dashboard;

public class OrdersDashboardItem : IDashboardItem
{
    private readonly IPageResolver resolver;

    public OrdersDashboardItem(IPageResolver resolver)
    {
        this.resolver = resolver;
    }
    public string Title { get; } = "Orders";

    public ICommand Command { get; } = new Command();
}
