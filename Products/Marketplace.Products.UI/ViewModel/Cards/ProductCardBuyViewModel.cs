using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.State;
using Marketplace.Products.UI.Views;
using System.Windows.Input;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCardBuyViewModel : ProductCardViewModel
{
    private readonly IPageResolver resolver;

    public ProductCardBuyViewModel(IPageResolver resolver, IProductState state) // Constructor ==========
    {
        this.resolver = resolver;
        base.Command = new Command(() =>
        {
            var input = new ProductCartInput()
            {
                ProductId = Id,
                Price = Price,
                Title = Title
            };
            ProductCart.Instance.Add(input);
        });
    }
}
