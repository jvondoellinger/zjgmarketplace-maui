using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.UI.ViewModels.Notifiers;
using Marketplace.Users.UI.Views;
using System.Diagnostics;
using System.Windows.Input;

namespace Marketplace.Users.UI.ViewModels;

public class UserLoginViewModel : PropertyNotifier
{
    private readonly IPageResolver pageResolver;
    private readonly IUserLoginRequest request;

    public UserLoginViewModel(IPageResolver pageResolver, IUserLoginRequest request)
    {
        this.pageResolver = pageResolver;
        this.request = request;
        InitializeCommands();
    }



    // Methods ===============================================
    private void InitializeCommands()
    {
        this.SingupRediredtCommand = new Command(async () =>
        {
            
            var page = pageResolver.Resolve<UserSignupPage>();
            await Shell.Current.Navigation.PushAsync(page);
        });
        this.LoginCommand = new Command(async () =>
        {
            Loading = true;
            try
            {
                var model = new UserModel()
                {
                    Email = Email,
                    Password = Password
                };
                await request.SendAsync(model);
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Erro ao logar na conta", ex.Message, "Ok");
            }
            Loading = false;
        });
    }



    // Properties ============================================
    public ICommand SingupRediredtCommand { get; private set; }
    public ICommand LoginCommand { get; private set; }



    // Private variables =====================================
    private string _email;
    private string _password;
    private bool _loading = false;


    //Properties with invoke event ===========================
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
    public bool Loading
    {
        get => _loading;
        set
        {
            if (value != _loading)
            {
                _loading = value;
                OnPropertyChanged(nameof(Loading));
            }
        }
    }

}
