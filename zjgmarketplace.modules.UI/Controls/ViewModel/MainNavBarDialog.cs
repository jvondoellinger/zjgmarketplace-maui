using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace zjgmarketplace.Modules.UI.Controls.ViewModel;

public class MainNavBarDialog : NavBarDialog
{
    public MainNavBarDialog()
    {
        Title = "Main";
        CommandRedirect = new Command(() => { 
            
        }); // Forneça um delegado vazio para o construtor
    }
}

