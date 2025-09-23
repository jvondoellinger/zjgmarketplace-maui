using Marketplace.Users.UI.ViewModels.Notifiers;
using System.Diagnostics;
using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels;

public class UserSignupViewModel : PropertyNotifier
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
            if (!value.Equals(_fullname))
            {
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
            if (!value.Equals(_password))
            {
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
            if (!value.Equals(_phone))
            {
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
            if (!value.Equals(_cpf))
            {
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
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }
    }
}
