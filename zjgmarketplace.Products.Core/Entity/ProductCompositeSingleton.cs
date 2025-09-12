namespace zjgmarketplace.Products.Core.Entity
{
    public static class ProductCompositeSingleton
    {
        private static readonly ProductComposite _productComposite = ProductComposite.GetProductComposite();
        
        public static ProductComposite GetInstance() => _productComposite;
    }
}
