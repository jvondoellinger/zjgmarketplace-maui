using Marketplace.Orders.UI.ViewModels;

namespace Marketplace.Orders.UI.Views;

public partial class PaymentPage : ContentPage
{
	public PaymentPage(PaymentViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}