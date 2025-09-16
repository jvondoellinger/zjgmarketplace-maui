using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.Global.BaseModel;
using zjgmarketplace.Modules.UI.Order.Model;
using zjgmarketplace.Modules.UI.Order.Model.Tests;
using zjgmarketplace.Modules.UI.Order.Singleton;
using zjgmarketplace.Modules.UI.Order.View;

namespace zjgmarketplace.Modules.UI.Order.ViewModel
{
    public class OrderPreviewModelView : PropertyNotifier   
    {
        public ObservableCollection<OrderPreviewModel> OrderPreviews { get; } = new (OrderPreviewModelTest.Load());
        private OrderPreviewModel selectedOrder;
        public OrderPreviewModel SelectedOrder
        {
            get => selectedOrder;
            set
            {
                if (!value.Equals(selectedOrder))
                {
                    Debug.WriteLine(value.Title);
                    StoreOrder.StorePreviewModel(value);
                    selectedOrder = value;
                    OnPropertyChanged(nameof(SelectedOrder));
                }
            }
        }
        public ICommand OrderViewRedirectCommand = new Command(async () =>
        {
            await Task.Delay(1000);
        });
    }
}
