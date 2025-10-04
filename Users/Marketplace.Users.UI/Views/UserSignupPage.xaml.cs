using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.ViewModels;
using System.Windows.Input;

namespace Marketplace.Users.UI.Views;

public partial class UserSignupPage : ContentPage
{
    public UserSignupPage(UserSignupViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
    }
}