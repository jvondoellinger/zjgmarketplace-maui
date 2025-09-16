namespace zjgmarketplace.Modules.UI.Order.Model
{
    public class OrderPreviewModel
    {
        public OrderPreviewModel(long id, decimal price, string title, DateTime createdAt)
        {
            Id = id;
            Price = price;
            Title = title;
            CreatedAt = createdAt;
        }

        public long Id { get; protected init; }
        public decimal Price { get; protected init; }
        public string Title { get; protected init; }
        public DateTime CreatedAt { get; protected init; }
    }
}
