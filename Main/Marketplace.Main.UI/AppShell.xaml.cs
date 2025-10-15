using Marketplace.Main.UI.TabMenu;
using Marketplace.Products.UI.Views;
using System.Security.Cryptography.X509Certificates;

namespace Marketplace.Main.UI;

public partial class AppShell : Shell
{
    private readonly IServiceProvider provider;

    public AppShell(IServiceProvider provider)
    {
        InitializeComponent();
        this.provider = provider;

        LoadTabs();
    }

    public ShellContent GetProductTab => ProductTab;
    public ShellContent GetCategoryTab => CategoryTab;
    public ShellContent GetProfileTab => ProfileTab;
    public ShellContent GetCartTab => CartTab;
    public ShellContent GetDashboardTab => DashboardTab;
    private void LoadTabs()
    {
        var loaders = provider.GetServices<ITabMenuLoader>();
        foreach (var item in loaders)
        {
            item.Load(this);
        }
    }
}
