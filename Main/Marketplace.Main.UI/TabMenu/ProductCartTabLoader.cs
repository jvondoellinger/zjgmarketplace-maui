using Marketplace.Products.UI.Views;

namespace Marketplace.Main.UI.TabMenu;

public class ProductCartTabLoader : ITabMenuLoader
{
    private readonly ProductCartPage page;

    public ProductCartTabLoader(ProductCartPage page)
    {
        this.page = page;
    }
    public void Load(AppShell shell)
    {
        shell.GetCartTab.Content = page;
    }
}
