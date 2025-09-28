using Marketplace.Products.Core.State;
using System.Diagnostics;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCardBuyViewModel : ProductCardViewModel
{
    public ProductCardBuyViewModel()
    {
        Command = new Command(() =>
        {
            var state = new ProductState();
            state.SelectProduct(Id);
            ProductStateComposite.Instance.AddState(state);
            Debug.WriteLine($"Buying product with ID: {Id}");
        });
    }
}
