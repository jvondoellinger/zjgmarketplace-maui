namespace Marketplace.Products.Core.Model;

public class Product
{
    private static int counter;
    public Product(string name, string description, decimal price, string category, List<string> imagesURL)
    {
        counter++;
        Id = counter;
        Title = name;
        Description = description;
        Category = category;
        Price = price;
        ImagesURL = imagesURL;
    }

    public Product(int id, string name, string description, decimal price, string category, List<string> imagesURL)
    {
        counter++;
        Id = id;
        Title = name;
        Description = description;
        Price = price;
        Category = category;
        ImagesURL = imagesURL;
    }

    public int Id { get; init; }
    public string Title { get; init; }
    public List<string> ImagesURL { get; init; }
    public string Description { get; init; }
    public decimal Price { get; init; }
    public string Category { get; init; }
}
