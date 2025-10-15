using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Core.State;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.ViewModel.Notifiers;
using System.Windows.Input;

namespace Marketplace.Products.UI.ViewModel;

public class ProductViewModel : PropertyNotifier
{
    private readonly IProductState state;
    private readonly IQueryProductRequest request;
    private Product? product;

    public ProductViewModel(IQueryProductRequest request, IProductState state)
    {
        this.request = request;
        this.state = state;

        AsyncWorker.RunAsync(LoadDataContext);
    }

    // Properties ==================================================
    public string Id { get; private set; }
    public List<string> ImagesURL { get; private set; }
    public string Title { get; private set; }
    public decimal Price { get; private set; }
    public string Description { get; private set; }
    public ICommand ButtonCommand { get; private set; }


    // Methods ==================================================
    public async Task LoadDataContext()
    {
        var selected = state.SelectedProductId;
        if (selected == null) 
            return;
        var data = await request.QueryIdAsync(selected) ?? throw new Exception("Product can't be null");
        
        LoadProperties(data);
    }

    private void LoadProperties(Product product)
    {
        if (product == null) 
            return; // Do nothing.
        Id = product.Id;
        Title = product.Title;
        Description = product.Description;
        Price = product.Price;
        ImagesURL = product.ImagesURL.Select(x => x.ToString()).ToList();
        ButtonCommand = new Command(() =>
        {
            var input = new ProductCartInput()
            {
                ProductId = Id,
                Price = Price,
                Title = Title
            };
            ProductCart.Instance.Add(ref input);
        });
    }


}
