using System.Windows.Input;

namespace Marketplace.Orders.UI.ViewModels;

public class CheckoutViewModel
{
    public CheckoutViewModel()
    {
        
    }
    public long Id { get; private set; }
    public string ImagePath { get; private set; }
    public string Code { get; private set; }
    public ICommand CopyCodeCommand { get; private set; } //Copiar o código pix do cliente
    public decimal Price { get; private set; } 
    public ICommand ContactUsCommand { get; private set; } // Fale conosco
}
