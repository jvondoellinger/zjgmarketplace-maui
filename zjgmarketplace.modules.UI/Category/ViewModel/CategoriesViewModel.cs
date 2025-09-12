using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.Category.Model;

namespace zjgmarketplace.Modules.UI.Category.ViewModel
{
    public class CategoriesViewModel
    {
        public CategoriesViewModel()
        {
            Categories = new(CategoriesModelTest.Load());
        }

        public ObservableCollection<CategoriesModel> Categories { get; set; } 
    }
}
