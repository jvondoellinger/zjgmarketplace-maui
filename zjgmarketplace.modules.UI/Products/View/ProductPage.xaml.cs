using System.Collections.ObjectModel;
using System.Diagnostics;
using zjgmarketplace.Modules.UI.Products.Mapper;
using zjgmarketplace.Modules.UI.Products.ViewModel;
using zjgmarketplace.Modules.UI.Products.ViewModel.Test;
using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Modules.UI.Products.View;

public partial class ProductPage : ContentPage
{
    public static readonly string Route = nameof(ProductPage);

    private readonly IProductState state;
    private readonly IProductQuery query;

    public ProductViewModel ProductViewModel { get; set; }
	public ProductPage(IProductState state, IProductQuery query)
    {
        this.state = state;
        this.query = query;

        InitializeComponent();

        //_ = Task.Run(async () => await DataLoader());
        _ = DataLoader();

        BindingContext = this;
    }

    private async Task DataLoader()
    {
        Debug.WriteLine("STARTING DATA LOADER: ");

        if (state.SelectedProductId == null)
        {
            Debug.WriteLine("Current object: " + state.GetHashCode());
            Debug.WriteLine("STARTING DATA LOADER: 2");
        }
        else
        {
            Debug.WriteLine("STARTING DATA LOADER: 3");
        }

        var entity = await query.Find(state.SelectedProductId);
        Debug.WriteLine("DEscription: "+entity.Description);
        ProductViewModel = ProductViewModelMapper.Map(entity);
    }
} 