
using Marketplace.Users.UI.Views;

namespace Marketplace.Main.UI.TabMenu;

public class AccountDashboardTabLoader : ITabMenuLoader
{
    private readonly AccountDashboardPage page;

    public AccountDashboardTabLoader(AccountDashboardPage page)
    {
        this.page = page;
    }
    public void Load(AppShell shell)
    {
        shell.GetDashboardTab.Content = page;
    }
}
