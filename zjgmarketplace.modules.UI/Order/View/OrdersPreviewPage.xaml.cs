using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.Modules.UI.Order.View;

public partial class OrdersPreviewPage : ContentPage
{
	public OrdersPreviewPage()
	{
		InitializeComponent();
		BindingContext = new OrderPreviewModelView();
    }
}