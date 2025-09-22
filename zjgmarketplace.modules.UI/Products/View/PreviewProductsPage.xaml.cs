using System.Collections.ObjectModel;
using zjgmarketplace.modules.UI;
using zjgmarketplace.Modules.UI.Products.Mapper;
using zjgmarketplace.Modules.UI.Products.ViewModel;
using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Modules.UI.Products.View;

public partial class PreviewProductsPage : ContentPage
{
    public static readonly string Route = nameof(PreviewProductsPage);

    private readonly IProductQuery query;
    private readonly IProductState state;

    public ObservableCollection<PreviewProductViewModel> ProductViewModels { get; private set; }

    public PreviewProductsPage(IProductQuery query, IProductState state)
    {
        this.query = query;
        this.state = state;

        InitializeComponent();

        // _ = Task.Run(async () => await DataLoader());
        _ = DataLoader();
        BindingContext = this;
    }
            
    private async Task DataLoader()
    {
        var list = await query.QueryPagination(0, 30);
        var mapped = PreviewProductViewModelMapper.Map(list);
        ProductViewModels = [ ..mapped];

    }

    private async void OnCardClicked_Tapped(object sender, TappedEventArgs e)
    {
        var ve = (ContentView) sender; // (ContentView) or (VisualElement) to cast sender

        if (ve.BindingContext is not PreviewProductViewModel vm) return;

        state.SelectProduct(vm.Id); // Select productId in state

        var page = App.Services.GetRequiredService<ProductPage>(); // Data loader is active in Ctor from the page, when the state in the same insance (singleton). 

        await Shell.Current.Navigation.PushAsync(page); // Navigate to ProductPage

    }
}
