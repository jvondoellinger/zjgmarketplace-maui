using System.Diagnostics;
using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.Modules.UI.Order.View;

public partial class OrderPage : ContentPage
{

	public static BindableProperty OrderPageProperty = BindableProperty.Create(
		nameof(OrderModelView),
		typeof(OrderModelView),
		typeof(OrderPage),
		default(OrderModelView),
		propertyChanged: OnOrderModelChanged);

	public static void OnOrderModelChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is OrderPage control)
		{
			control.BindingContext = newValue;
		}
    }

	public OrderModelView OrderModelView
	{
		get => (OrderModelView)GetValue(OrderPageProperty);
		set => SetValue(OrderPageProperty, value);
	}

    public static string Route { get; } = nameof(OrderPage);
	public OrderPage()
	{
		InitializeComponent();
	}
}