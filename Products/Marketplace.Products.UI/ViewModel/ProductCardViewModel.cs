using Marketplace.Products.Core.State;
using System.Diagnostics;
using System.Windows.Input;

namespace zjgmarketplace.Modules.UI.Products.ViewModel;

public class ProductCardViewModel
{

    public ProductCardViewModel()
    {
        ButtonCommand = new Command(() =>
        {
            Debug.WriteLine("Button clicked!");
            var state = new ProductState();
            state.SelectProduct(Id);
            ProductStateComposite.Instance.AddState(state);
        });
    } 

    public required string Id { get; init; }
    public required string ImageURL { get; init; }
    public required string Title { get; init; }
    public decimal Price { get; init; }
    public ICommand ButtonCommand { get; } 
}

