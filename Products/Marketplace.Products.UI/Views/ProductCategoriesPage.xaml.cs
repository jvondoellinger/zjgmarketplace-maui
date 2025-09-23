using Marketplace.Products.Core.Query;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel;
using System.Collections.ObjectModel;

namespace Marketplace.Products.UI.Views;

public partial class ProductCategoriesPage : ContentPage, IDataLoader
{
    private readonly IProductCategoryQuery query;

    public ObservableCollection<ProductCategoryViewModel> ProductCategoryModelViews { get; private set; }

    public ProductCategoriesPage(IProductCategoryQuery query)
	{
        this.query = query;

        NavigationPage.SetHasNavigationBar(this, true);


        InitializeComponent();

        _ = LoadDataContext();

        BindingContext = this;
    }


	public async Task LoadDataContext()
    {
        var data = await query.QueryAll();
        var models = ProductCategoryModelViewMapper.Map(data);
        ProductCategoryModelViews = [.. models];
    }
}