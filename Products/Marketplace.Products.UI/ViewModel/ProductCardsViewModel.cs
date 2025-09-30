using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel.Cards;
using Marketplace.Products.UI.ViewModel.Notifiers;
using Marketplace.Products.UI.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace Marketplace.Products.UI.ViewModel;

public class ProductCardsViewModel : PropertyNotifier
{
    private readonly IProductQuery query;
    private readonly IProductState state;
    private readonly IPageResolver resolver;

    public ProductCardsViewModel(IProductQuery query, IProductState state, IPageResolver resolver)
    {
        this.query = query;
        this.state = state;
        this.resolver = resolver;

        AsyncWorker.RunAsync(LoadDataContext);
    }

    // Properties ==================================================================================

    public ObservableCollection<ProductCardViewModel> ProductViewModels { get; private set; }

    public async Task LoadDataContext()
    {
        var data = await query.QueryPagination(0, 10);

        var models = ProductCardViewModelMapper.MapToBuyCard(data);
        
        ProductViewModels = [.. models];
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
            selected = null;
            OnPropertyChanged(nameof(SelectedItem));
        }
    }
}
