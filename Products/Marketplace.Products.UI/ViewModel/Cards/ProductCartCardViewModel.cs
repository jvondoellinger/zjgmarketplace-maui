using Marketplace.Products.Core.State;
using System.Diagnostics;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCartCardViewModel : ProductCardViewModel
{
    public ProductCartCardViewModel()
    {
        Command = new Command(() =>
        {
            ProductStateComposite.Instance.RemoveState(Id);
            Debug.WriteLine($"Removing product with ID: {Id} from cart");
        });
    }
}
