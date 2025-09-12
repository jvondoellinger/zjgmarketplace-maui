using System.Numerics;

namespace zjgmarketplace.Core.Product.Model
{
    public class ProductModel
    {
        private readonly string _id;
        private readonly string _title;
        private readonly string _description;
        private readonly decimal _price; // not recomended <<!>> limit 128bit (don't have 100% precision)

        public ProductModel(string id, string title, string description, decimal price)
        {
            _id = id;
            _title = title;
            _description = description;
            _price = price;
        }

        public static ProductModel Instanciate(string id, string title, string description, decimal price)
        {
            return new ProductModel(id,
                                    title,
                                    description,
                                    price);
        }
    }
}
