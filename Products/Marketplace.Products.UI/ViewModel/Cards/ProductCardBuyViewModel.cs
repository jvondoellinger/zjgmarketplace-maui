using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Core.Workers;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCardBuyViewModel : ProductCardViewModel
{
    public ProductCardBuyViewModel() // Constructor ==========
    {

        InitializeCommands();

    }
    private void InitializeCommands()
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
