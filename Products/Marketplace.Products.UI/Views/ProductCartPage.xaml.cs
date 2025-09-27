using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.Views.Content;
using System.Collections.ObjectModel;
using System.Diagnostics;
using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.Views;

public partial class ProductCartPage : ContentPage, IDataLoader
{
    private readonly ProductStateComposite composite = ProductStateComposite.Instance;
    private readonly IProductQuery query;
        
    public ObservableCollection<ProductCardViewModel> ProductCardViewModels { get; private set; }
    public ProductCartPage(IProductQuery query)
	{
		InitializeComponent();

        this.query = query;

        _ = LoadDataContext();

        // Carregar o ambiente para ajustar os cards (remover o buy e deixar um botão de remover).

        BindingContext = this;
    }

	public async Task LoadDataContext()
    {
        Debug.WriteLine("Carregando dados da página...!");

        var states = composite.ProductStates;
        List<Product> products = [];
        foreach (var state in states)
        {
            if (state == null)
                continue;
            if (string.IsNullOrWhiteSpace(state.SelectedProductId))
                continue;
            var product = await query.Find(state.SelectedProductId);
            if (product == null)
                continue;
            Debug.WriteLine("Item localized!");
            products.Add(product);
        }
        var views = ProductCardViewModelMapper.Map(products);
        ProductCardViewModels = [.. views];
    }
}