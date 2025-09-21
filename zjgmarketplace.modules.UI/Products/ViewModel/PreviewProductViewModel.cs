using System.Collections.ObjectModel;
using System.Windows.Input;
using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Modules.UI.Products.ViewModel;

public class PreviewProductViewModel : IProductIdentifierGetter
{
    public string Id { get; init; }
    public string ImageURL { get; init; }
    public string Title { get; init; }
    public decimal Price { get; init; }

    public string GetId()
    {
        return Id;
    }
}

