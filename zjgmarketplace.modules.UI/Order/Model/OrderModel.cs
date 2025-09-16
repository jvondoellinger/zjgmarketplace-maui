using System.Runtime.CompilerServices;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.Order.ValueObjects.Payment;

namespace zjgmarketplace.Modules.UI.Order.Model
{
    public class OrderModel
    {
        public long OrderId { get; set; }
        public string Title { get; set; }
        public string ImageURI { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public List<string> PaymentMethodsDisplay
        {
            get => PaymentMethods.Select(x => x.Method).ToList();
        }
        public DateTime CreatedAt { get; set; }
    }
}
