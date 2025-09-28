using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.State;
using System.Diagnostics;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCartCardViewModel : ProductCardViewModel
{
    public ProductCartCardViewModel()
    {
        Command = new Command(() =>
        {
            Debug.WriteLine($"Deleting card with id: {Id}");
            ProductCart.Instance.Remove(Id);
        });
    }
}
