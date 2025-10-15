
using Marketplace.Users.UI.Views;

namespace Marketplace.Main.UI.TabMenu;

public class UserLoginPageTabLoader : ITabMenuLoader
{
    private readonly UserLoginPage page;

    public UserLoginPageTabLoader(UserLoginPage page)
    {
        this.page = page;
    }
    public void Load(AppShell shell)
    {
        shell.GetProfileTab.Content = page;
    }
}
