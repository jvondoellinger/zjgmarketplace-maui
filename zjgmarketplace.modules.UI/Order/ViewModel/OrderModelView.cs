using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.Order.Model;
using zjgmarketplace.Modules.UI.Order.Model.Tests;

namespace zjgmarketplace.Modules.UI.Order.ViewModel
{
    public class OrderModelView
    {
        public OrderModel OrderModel { get; } = OrderModelTest.Load();
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
