using System.Windows.Input;

namespace Marketplace.Products.UI.ViewModel.Cards;

public abstract class ProductCardViewModel
{
    protected ProductCardViewModel()
    {
        
    }
    public required string Id { get; init; }
    public required string ImageURL { get; init; }
    public required string Title { get; init; }
    public required decimal Price { get; init; }
    public ICommand Command { get; protected init; }

}
