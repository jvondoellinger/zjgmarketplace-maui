using Marketplace.Products.Core.Interfaces;using Marketplace.Products.Core.Requests;
using Marketplace.Products.Core.State;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel.Cards;
using Marketplace.Products.UI.ViewModel.Notifiers;
using Marketplace.Products.UI.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Marketplace.Products.UI.ViewModel;

public class ProductCardsViewModel : PropertyNotifier
{
    private readonly ProductQueryImageProxy proxy;
    private readonly IProductState state;
    private readonly IPageResolver resolver;

    public ProductCardsViewModel(ProductQueryImageProxy proxy, IProductState state, IPageResolver resolver)
    {
        this.proxy = proxy;
        this.state = state;
        this.resolver = resolver;

        AsyncWorker.RunAsync(LoadDataContext);
    }

    // Properties ==================================================================================

    public ObservableCollection<ProductCardViewModel> ProductViewModels { get; private set; }

    public async Task LoadDataContext()
    {
        try
        {
            var data = await proxy.QueryPaginationAsync(0, 10);

            var models = ProductCardViewModelMapper.MapToBuyCard(data);

            ProductViewModels = [ ..models];

            OnPropertyChanged(nameof(ProductViewModels));
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            throw ex;
        }


    }

    private ProductCardViewModel selected;

    public ProductCardViewModel SelectedItem
    {
        get => selected;
        set
        {
            selected = value;
            state.SelectProduct(value.Id);
            AsyncWorker.RunAsync(async () =>
            {
                var page = resolver.Resolve<ProductPage>();
                await Shell.Current.Navigation.PushAsync(page);
            });
            OnPropertyChanged(nameof(SelectedItem));
        }
    }
}
