using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace zjgmarketplace.Modules.UI.User.Model.Login
{
    public class UserLoginModel : INotifyPropertyChanged
    {
        public string Email
        { 
            get => _email; 
            set
            {
                if(!value.Equals(_email))
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
                if(!value.Equals(_password))
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private string _email;
        private string _password;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
