using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.Global.BaseModel;

namespace zjgmarketplace.Modules.UI.Order.ViewModel
{
    public class OrderPreviewModelView : PropertyNotifier   
    {
        public long Id { get; init; }
        public decimal Price { get; init; }
        public string Title { get; init; }
        public DateTime CreatedAt { get; init; }

        private OrderPreviewModelView selectedOrder;
        public OrderPreviewModelView SelectedOrder
        {
            get => selectedOrder;
            set
            {
                if (!value.Equals(selectedOrder))
                {
                    Debug.WriteLine(value);
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
