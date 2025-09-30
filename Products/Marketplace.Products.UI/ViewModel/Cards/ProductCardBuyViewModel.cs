using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.State;
using Marketplace.Products.UI.Views;
using System.Windows.Input;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCardBuyViewModel : ProductCardViewModel
{

    public ProductCardBuyViewModel() // Constructor ==========
    {
        base.Command = new Command<ProductCardViewModel>((card) =>
        {
            var input = new ProductCartInput()
            {
                ProductId = card.Id,
                Price = card.Price,
                Title = card.Title
            };
            ProductCart.Instance.Add(ref input);
        });
    }
}
