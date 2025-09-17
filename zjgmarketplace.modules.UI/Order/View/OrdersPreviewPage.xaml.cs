using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.Order.ViewModel;
using zjgmarketplace.Modules.UI.Order.ViewModel.Tests;

namespace zjgmarketplace.Modules.UI.Order.View;

public partial class OrdersPreviewPage : ContentPage
{
    public static string Route { get; } = nameof(OrdersPreviewPage);
	public ObservableCollection<OrderPreviewModelView> OrderPreviews { get; } = new ObservableCollection<OrderPreviewModelView>();
    public OrdersPreviewPage() 
	{
		InitializeComponent();

        // Temporary data loader 
        OrderPreviewModelTest.Load()
            .ForEach(OrderPreviews.Add);
        
        BindingContext = this;
    }
}