using System.Diagnostics;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.Global.BaseModel;

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
                    Debug.WriteLine(value);
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
                    Debug.WriteLine(value);
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private string _email;
        private string _password;

        public ICommand SignupRedirect { get; } = new Command(async () =>
        {
            await Shell.Current.GoToAsync("///SignupPage");
        });
    }
}
