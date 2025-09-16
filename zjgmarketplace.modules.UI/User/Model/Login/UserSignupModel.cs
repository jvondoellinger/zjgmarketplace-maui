using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using zjgmarketplace.Modules.UI.Global.BaseModel;

namespace zjgmarketplace.Modules.UI.User.Model.Login
{
    public class UserSignupModel : PropertyNotifier
    {
        private string _fullname;
        private string _password;
        private string _email;
        private string _phone;
        private string _cpf;
        private DateTime _birthDate;

        public string Fullname
        {
            get => _fullname;
            set
            {
                if(!value.Equals(_fullname))
                {
                    Debug.WriteLine(value);
                    _fullname = value;
                    OnPropertyChanged(nameof(Fullname));
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
        public string Phone
        {
            get => _phone;
            set
            {
                if(!value.Equals(_phone))
                {
                    Debug.WriteLine(value);
                    _phone = value;
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }
        public string CPF
        {
            get => _cpf;
            set
            {
                if(!value.Equals(_cpf))
                {
                    Debug.WriteLine(value);
                    _cpf = value;
                    OnPropertyChanged(nameof(CPF));
                }
            }
        }
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value.Equals(_birthDate))
                {
                    Debug.WriteLine(value);
                    _birthDate = value;
                    OnPropertyChanged(nameof(BirthDate));
                }
            }
        }


    }
}
