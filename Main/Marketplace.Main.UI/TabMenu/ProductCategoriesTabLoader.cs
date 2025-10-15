
using Marketplace.Products.UI.Views;

namespace Marketplace.Main.UI.TabMenu;

public class ProductCategoriesTabLoader : ITabMenuLoader
{
    private readonly ProductCategoriesPage page;

    public ProductCategoriesTabLoader(ProductCategoriesPage page)
    {
        this.page = page;
    }
    public void Load(AppShell shell)
    {
        shell.GetCategoryTab.Content = page;
    }
}
