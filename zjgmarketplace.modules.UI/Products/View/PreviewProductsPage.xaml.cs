using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using zjgmarketplace.modules.UI;
using zjgmarketplace.Modules.UI.Products.Content;
using zjgmarketplace.Modules.UI.Products.Mapper;
using zjgmarketplace.Modules.UI.Products.ViewModel;
using zjgmarketplace.Modules.UI.Products.ViewModel.Test;
using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Modules.UI.Products.View;

public partial class PreviewProductsPage : ContentPage
{
    public static readonly string Route = nameof(PreviewProductsPage);

    private readonly IProductQuery query;
    private readonly IProductState state;

    public ObservableCollection<PreviewProductViewModel> ProductViewModels { get; private set; }

/*    public PreviewProductsPage()
	{
        InitializeComponent();

        // Temporary data loader
        ProductModelTest.Load().ForEach(ProductViewModels.Add);

        BindingContext = this;
    }*/

    public PreviewProductsPage(IProductQuery query, IProductState state)
    {
        this.query = query;
        this.state = state;

        InitializeComponent();

        _ = Task.Run(async () => await DataLoader());

        BindingContext = this;
    }
            
    private async Task DataLoader()
    {
        var list = await query.QueryPagination(0, 30);
        var mapped = PreviewProductViewModelMapper.Map(list);
        ProductViewModels = [ ..mapped];

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine(sender.GetType());
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var ve = (VisualElement) sender;
        var vm = ve.BindingContext as PreviewProductViewModel;

        if (vm != null)
        {
            var page = App.Services.GetRequiredService<ProductPage>();
            state.SelectProduct(vm.Id);
            await Shell.Current.Navigation.PushAsync(page);
        }
    }
}
