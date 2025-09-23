using Marketplace.Products.UI.ViewModel.Notifiers;
using System.Collections.Generic;

namespace Marketplace.Products.UI.ViewModel;

public class ProductViewModel : PropertyNotifier
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
