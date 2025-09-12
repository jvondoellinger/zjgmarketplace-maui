namespace zjgmarketplace.Products.Core.Entity
{
    public class ProductComposite
    {
        private readonly List<Product> _products = new List<Product> ();
        private ProductComposite() { }

        public IReadOnlyCollection<Product> GetProducts() => _products.AsReadOnly();

        public void AddProduct(Product product) => _products.Add(product);
        

        public void RemoveProduct(Product product) => _products.Remove(product);
        

        public void PutProduct(Product product)
        {
            var index = _products.IndexOf(product);
            if (index == -1)
                _products.Add(product);
            else
                _products.Insert(index, product);
        }

        public void Clear() => _products.Clear(); 

        public static ProductComposite GetProductComposite() => new ();
    }
}
