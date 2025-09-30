using Marketplace.Orders.UI.ViewModels.Card;

namespace Marketplace.Orders.UI.Views.Content;

public partial class OrderCardView : ContentView
{
	public static readonly BindableProperty OrderCardViewModelProperty = BindableProperty.Create(
		nameof(OrderCardViewModel),
		typeof(OrderCardViewModel),
		typeof(OrderCardView),
		default(OrderCardViewModel),
		propertyChanged: OnOrderCardViewModelChanged);
	
	public OrderCardViewModel OrderCardViewModel
	{
		get => (OrderCardViewModel) GetValue(OrderCardViewModelProperty);
		set => SetValue(OrderCardViewModelProperty, value);
	}

	private static void OnOrderCardViewModelChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is OrderCardView view) 
		{
			view.BindingContext = newValue;
		}
	}

	public OrderCardView()
	{
		InitializeComponent();
	}
}