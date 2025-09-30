using Marketplace.Orders.Core.Query;
using Marketplace.Orders.Core.State;
using Marketplace.Orders.Core.Workers;
using Marketplace.Orders.UI.ViewModels.Notifiers;
using System.Windows.Input;

namespace Marketplace.Orders.UI.ViewModels;

public class CheckoutViewModel : PropertyNotifier
{
    private readonly IOrderQuery query;
    private readonly IOrderState state;

    public CheckoutViewModel(IOrderQuery query, IOrderState state)
    {
        this.query = query;
        this.state = state;

        state.SelectOrder += async (order) =>
        {
            await LoadDataContext();
        };
        LoadCommands();
    }

    // Variables ================================================
    private long id;
    private string imagePath;
    private string code;
    private ICommand copyCodeCommand;
    private decimal price;
    private ICommand contactUsCommand;

    // Properties ===============================================
    public long Id 
    { 
        get => id; 
        set
        {
            id = value;
            OnPropertyChanged(nameof(Id));
        } 
    }
    public string ImagePath
    {
        get => imagePath;
        set
        {
            imagePath = value;
            OnPropertyChanged(nameof(ImagePath));
        }
    }
    public string Code
    {
        get => code;
        set
        {
            code = value;
            OnPropertyChanged(nameof(Code));
        }
    }
    public ICommand CopyCodeCommand
    {
        get => copyCodeCommand;
        set
        {
            copyCodeCommand = value;
            OnPropertyChanged(nameof(CopyCodeCommand));
        }
    }
    public decimal Price
    {
        get => price;
        set
        {
            price = value;
            OnPropertyChanged(nameof(Price));
        }
    }
    public ICommand ContactUsCommand
    {
        get => contactUsCommand;
        set
        {
            contactUsCommand = value;
            OnPropertyChanged(nameof(ContactUsCommand));
        }
    }

    private async Task LoadDataContext()
    {
        var selected = state.SelectedOrder;
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
