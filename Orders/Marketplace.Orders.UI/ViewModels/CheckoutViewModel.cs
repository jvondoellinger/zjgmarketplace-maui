using Marketplace.Orders.Core.Query;
using Marketplace.Orders.Core.State;
using Marketplace.Orders.Core.Workers;
using System.Windows.Input;

namespace Marketplace.Orders.UI.ViewModels;

public class CheckoutViewModel
{
    private readonly IOrderQuery query;
    private readonly IOrderState selectedState;

    public CheckoutViewModel(IOrderQuery query, IOrderState selectedState)
    {
        this.query = query;
        this.selectedState = selectedState;
        
        AsyncWorker.RunAsync(LoadDataContext);

        LoadCommands();
    }

    public long Id { get; private set; }
    public string ImagePath { get; private set; }
    public string Code { get; private set; }
    public ICommand CopyCodeCommand { get; private set; }  //Copiar o código pix do cliente
    public decimal Price { get; private set; } 
    public ICommand ContactUsCommand { get; private set; } // Fale conosco

    private async Task LoadDataContext()
    {
        var selected = await query.QueryId(1) ?? selectedState.SelectedOrder;
        Id = selected.Id;
        ImagePath = "fallback.png";
        Code = selected.Code;
        Price = selected.Price;
    }

    private void LoadCommands()
    {
        this.CopyCodeCommand = new Command(async () => {
            await Clipboard.SetTextAsync(Code);
        });
    }
}
