
using Marketplace.Products.UI.Views;

namespace Marketplace.Main.UI.TabMenu;

public class ProductCardsTabLoader : ITabMenuLoader
{
    private readonly ProductCardsPage page;
    public ProductCardsTabLoader(ProductCardsPage page)
    {
        this.page = page;

    }
    public void Load(AppShell shell)
    {
        shell.GetProductTab.Content = page;
    }
}
