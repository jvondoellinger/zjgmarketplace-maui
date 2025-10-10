using Marketplace.Products.Core.Model;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCardBuyViewModel : ProductCardViewModel
{

    public ProductCardBuyViewModel() // Constructor ==========
    {
        base.Command = new Command<ProductCardViewModel>((ProductCardViewModel card) =>
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
