using zjgmarketplace.Modules.UI.Order.Mapper;
using zjgmarketplace.Modules.UI.Order.ViewModel;
using zjgmarketplace.Modules.UI.Order.ViewModel.Tests;

namespace zjgmarketplace.Modules.UI.Order.View.Content;

public partial class OrderPreviewContentView : ContentView
{
	public static readonly BindableProperty OrderPreviewModelProperty = 
		BindableProperty.Create(
			nameof(OrderPreviewModelView),
			typeof(OrderPreviewModelView),
			typeof(OrderPreviewContentView),
			default(OrderPreviewModelView),
			propertyChanged: OnOrderChanged);

	private static void OnOrderChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is OrderPreviewContentView control)
		{
			control.BindingContext = newValue;
		}
	}

	public OrderPreviewModelView OrderPreviewModel
	{
		get => (OrderPreviewModelView)GetValue(OrderPreviewModelProperty);
		set => SetValue(OrderPreviewModelProperty, value);
	}

    public OrderPreviewContentView()
	{
		InitializeComponent();
	}

    private async void RedirectOrderPageButton_Clicked(object sender, TappedEventArgs e)
    {
		var page = new OrderPage();
		page.BindingContext = OrderModelViewTransformer.Transform(OrderPreviewModel);

        await Navigation.PushAsync(page); 
    }
}