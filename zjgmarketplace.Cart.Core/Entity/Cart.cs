namespace zjgmarketplace.Cart.Core.Entity
{
    public class Cart
    {
        public Cart(Guid id, List<string> productIds, decimal price)
        {
            Id = id;
            ProductIds = productIds;
            Price = price;
        }

        public Cart(List<string> productIds, decimal price)
        {
            Id = Guid.NewGuid();
            ProductIds = productIds;
            Price = price;
        }

        public required Guid Id { get; init; }
        public required List<string> ProductIds { get; init; } // Primitive type <<!>> ALERT
        public required decimal Price { get; init; }
    }
}
