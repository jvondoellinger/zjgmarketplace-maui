using Marketplace.Orders.UI.ViewModels;

namespace Marketplace.Orders.UI.Views;

public partial class OrderCardsPage : ContentPage
{
	public OrderCardsPage(OrderCardsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}