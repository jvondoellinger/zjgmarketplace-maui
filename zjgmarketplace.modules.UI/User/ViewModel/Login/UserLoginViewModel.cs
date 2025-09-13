using System.Windows.Input;
using zjgmarketplace.Modules.UI.User.Model.Login;

namespace zjgmarketplace.Modules.UI.User.ViewModel.Login
{
    public class UserLoginViewModel
    {
        public UserLoginViewModel() { }

        public UserLoginModel LoginModel { get; } = new UserLoginModel();

        public ICommand SignupRedirect { get; } = new Command(async () =>
        {
            await Shell.Current.GoToAsync("///SignupPage");
        });
    }
}
