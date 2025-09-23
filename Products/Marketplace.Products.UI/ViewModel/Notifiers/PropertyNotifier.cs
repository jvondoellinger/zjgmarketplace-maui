using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Marketplace.Products.UI.ViewModel.Notifiers
{
    public class PropertyNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
