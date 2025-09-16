using zjgmarketplace.Modules.UI.Order.Model.Tests;
using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.Modules.UI.Order.View.Content;

public partial class OrderPreviewContentView : ContentView
{
	public OrderPreviewContentView()
	{
		InitializeComponent();
	}

    private async void RedirectOrderPageButton_Clicked(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new OrderPage(new ()));
		// Atualizando 
    }
}