namespace zjgmarketplace.Modules.UI.Order.ValueObjects.Payment
{
    public abstract class PaymentMethod
    {
        public string Method { get; }

        protected PaymentMethod(string method)
        {
            Method = method;
        }
    }
}
