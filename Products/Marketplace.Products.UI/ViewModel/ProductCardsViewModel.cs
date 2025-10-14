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
    private readonly IQueryProductRequest request;
    private readonly IProductState state;
    private readonly IPageResolver resolver;

    public ProductCardsViewModel(/*IQueryProductRequest request, IProductState state, IPageResolver resolver*/)
    {
/*        this.request = request;
        this.state = state;
        this.resolver = resolver;

        AsyncWorker.RunAsync(LoadDataContext);*/
    }

    // Properties ==================================================================================

    public ObservableCollection<ProductCardViewModel> ProductViewModels { get; private set; }

    public async Task LoadDataContext()
    {
        try
        {
            var data = await request.SendPaginationAsync(0, 10);
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
