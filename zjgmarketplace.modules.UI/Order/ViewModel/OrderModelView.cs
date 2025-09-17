using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.Order.ValueObjects.Payment;

namespace zjgmarketplace.Modules.UI.Order.ViewModel
{
    public class OrderModelView
    {
        public long OrderId { get; set; }
        public string Title { get; set; }
        public string ImageURI { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; } = [ new PixPaymentMethod() ];
        public List<string> PaymentMethodsDisplay
        {
            get => [.. PaymentMethods.Select(x => x.Method)];
        }
        public DateTime CreatedAt { get; set; }

        public ICommand CloseOrderCommand { get; } = new Command(() =>
        {
            Debug.WriteLine("Kikozinho lindo e branco");
        }); // Trocar por um evento e acionar para encaminhar uma requisição na API

        public ICommand ContactUsCommandRedirect { get; } = new Command(() =>
        {
            Debug.WriteLine("Kikozinho lindo e branco 2 ");
        }); // Trocar por um evento e acionar para encaminhar uma requisição na API

    }
}
