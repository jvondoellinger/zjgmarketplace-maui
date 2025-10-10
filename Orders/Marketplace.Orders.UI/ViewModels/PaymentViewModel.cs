using Marketplace.Orders.Core.State;
using Marketplace.Orders.UI.ViewModels.Notifiers;
using System.Windows.Input;

namespace Marketplace.Orders.UI.ViewModels;

public class PaymentViewModel : PropertyNotifier
{
    private readonly IOrderState state;

    public PaymentViewModel(IOrderState state)
    {
        this.state = state;

        state.SelectOrder += (order) =>
        {
             LoadDataContext();
        };

        LoadDataContext();
        LoadCommands();
    }

    // Variables ================================================
    private long id;
    private ImageSource  imageSource;
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
    public ImageSource ImageSource
    {
        get => imageSource;
        set
        {
            imageSource = value;
            OnPropertyChanged(nameof(ImageSource));
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

    // Methods ===============================================================
    private void LoadDataContext()
    {
        var selected = state.SelectedOrder;
        Id = selected.Id;
        ImageSource = "fallback.png";
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
