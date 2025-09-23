using Marketplace.Users.UI.ViewModels.Notifiers;
using System.Diagnostics;
using System.Windows.Input;

namespace zjgmarketplace.Modules.UI.User.ViewModel.Login
{
    public class UserLoginViewModel : PropertyNotifier
    {
        public string Email
        {
            get => _email;
            set
            {
                if (!value.Equals(_email))
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (!value.Equals(_password))
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private string _email;
        private string _password;
    }
}
