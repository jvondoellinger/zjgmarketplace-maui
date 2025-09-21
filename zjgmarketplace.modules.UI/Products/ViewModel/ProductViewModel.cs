using zjgmarketplace.Modules.UI.Global.BaseModel;
using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Modules.UI.Products.ViewModel;

public class ProductViewModel : PropertyNotifier, IProductIdentifierGetter
{
    private string id;
    public string Id
    {
        get => id;
        set
        {
            if (!value.Equals(id))
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
    }

    private List<string> imagesURL;
    public List<string> ImagesURL
    {
        get => imagesURL; 
        set
        {
            if (!value.Equals(imagesURL))
            {
                imagesURL = value;
                OnPropertyChanged(nameof(ImagesURL));
            }
        }
    }


    public string Title { get; init; }
    private string title
    {
        get => title;
        set
        {
            if (!value.Equals(title))
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
    }
    private decimal price;
    public decimal Price
    {
        get => price;
        set
        {
            if (!value.Equals(price))
            {
                price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
    }
    private string description;
    public string Description
    {
        get => description;
        set
        {
            if (!value.Equals(description))
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }

    public string GetId()
    {
        return Id;
    }
}
