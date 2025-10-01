using Marketplace.Users.UI.ViewModels;

namespace Marketplace.Users.UI.Views;

public partial class AccountDashboardPage : ContentPage
{
    public AccountDashboardPage(DashboardViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}