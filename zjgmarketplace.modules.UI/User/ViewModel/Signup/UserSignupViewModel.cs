using System.Windows.Input;
using zjgmarketplace.Modules.UI.User.Model.Login;

namespace zjgmarketplace.Modules.UI.User.ViewModel.Signup
{
    class UserSignupViewModel
    {
        public UserSignupModel SignupModel { get; } = new UserSignupModel();

        public ICommand LoginRedirect { get; } = new Command(async () =>
        {
            await Shell.Current.GoToAsync("///LoginPage");
        });
    }
}
