using System.Windows.Input;

namespace Marketplace.Products.UI.ViewModel.Cards;

public abstract class ProductCardViewModel
{
    protected ProductCardViewModel()
    {
        
    }
    public string Id { get; init; }
    public required ImageSource Image { get; init; }
    public string? ImagePath { get; init; }
    public required string Title { get; init; }
    public required decimal Price { get; init; }
    public ICommand Command { get; protected set; }

}
