using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Core.Workers;

namespace Marketplace.Products.UI.ViewModel.Cards;

public class ProductCardBuyViewModel : ProductCardViewModel
{
    private readonly IQueryProductImageRequest request;

    public ProductCardBuyViewModel(IQueryProductImageRequest request) // Constructor ==========
    {
        this.request = request;

        InitializeCommands();
        LoadImages();
    }

    private void LoadImages()
    {
        if (base.ImagePath == null) return;
        AsyncWorker.RunAsync(async () =>
        {
            await request.QueryImages(base.ImagePath);
        });
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
