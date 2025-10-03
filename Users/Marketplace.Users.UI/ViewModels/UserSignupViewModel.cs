using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.UI.ViewModels.Notifiers;
using System.Diagnostics;
using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels;

public class UserSignupViewModel : PropertyNotifier
{
    private readonly IUserRegisterRequest request;
    public UserSignupViewModel(IUserRegisterRequest request)
    {
        this.request = request;

        InitializeCommands();
    }

    // Commands ================================================================================
    public ICommand LoginRediredtCommand { get; private set; } = new Command(async () => await Shell.Current.Navigation.PopAsync());
    public ICommand SendRequestCommand { get; private set; }

    // Variables ===============================================================================
    private string _fullname;
    private string _password;
    private string _email;
    private string _countryCode = "+55";
    private string _ddd;
    private string _phone;
    private string _cpf;
    private DateOnly _birthDate;


    // Properties ==============================================================================
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
    public string CountryCode
    {
        get => _countryCode;
        set
        {
            if (!value.Equals(_countryCode))
            {
                _countryCode = value;
                OnPropertyChanged(nameof(CountryCode));
            }
        }
    }
    public string DDD
    {
        get => _ddd;
        set
        {
            if (!value.Equals(_ddd))
            {
                _ddd = value;
                OnPropertyChanged(nameof(DDD));
            }
        }
    }
    public string Number
    {
        get => _phone;
        set
        {
            if (!value.Equals(_phone))
            {
                _phone = value;
                OnPropertyChanged(nameof(Number));
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
    public DateOnly BirthDate
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

    // Initialize methods ===============================================================
    private void InitializeCommands()
    {
        SendRequestCommand = new Command(async () =>
        {
            var model = new UserModel()
            {
                BirthDay = BirthDate,
                Cpf = CPF,
                Email = Email,
                Password = Password,
                Phone = new() { AreaCode = DDD, CountryCode = CountryCode, Number = Number },
                Username = Fullname
            };
            await request.SendAsync(model);
        });
    }
}
