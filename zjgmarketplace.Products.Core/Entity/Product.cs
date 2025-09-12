namespace zjgmarketplace.Products.Core.Entity
{
    public class Product
    {

        public Product(string name, string description, decimal price, string category)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }

        public Product(Guid id, string name, string description, decimal price, string category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }

        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public decimal Price { get; init; }
        public string Category { get; init; }
    }
}
