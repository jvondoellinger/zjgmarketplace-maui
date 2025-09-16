using System.Diagnostics;
using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.Modules.UI.Order.View;

public partial class OrderPage : ContentPage
{
	public static string Route => nameof(OrderPage);
	public OrderPage(OrderModelView view)
	{
		InitializeComponent();
		Debug.WriteLine(view);
		BindingContext = view;
	}
}