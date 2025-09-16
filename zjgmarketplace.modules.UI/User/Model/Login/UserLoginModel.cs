using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using zjgmarketplace.Modules.UI.Global.BaseModel;

namespace zjgmarketplace.Modules.UI.User.Model.Login
{
    public class UserLoginModel : PropertyNotifier
    {
        public string Email
        { 
            get => _email; 
            set
            {
                if(!value.Equals(_email))
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
                if(!value.Equals(_password))
                {
                    Debug.WriteLine(value);
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private string _email;
        private string _password;
    }
}
