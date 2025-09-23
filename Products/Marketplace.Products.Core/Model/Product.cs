namespace Marketplace.Products.Core.Model;

public class Product
{

    public Product(string name, string description, decimal price, string category, List<string> imagesURL)
    {
        Id = Guid.NewGuid();
        Title = name;
        Description = description;
        Category = category;
        Price = price;
        ImagesURL = imagesURL;
    }

    public Product(Guid id, string name, string description, decimal price, string category, List<string> imagesURL)
    {
        Id = id;
        Title = name;
        Description = description;
        Price = price;
        Category = category;
        ImagesURL = imagesURL;
    }

    public Guid Id { get; init; }
    public string Title { get; init; }
    public List<string> ImagesURL { get; init; }
    public string Description { get; init; }
    public decimal Price { get; init; }
    public string Category { get; init; }
}
