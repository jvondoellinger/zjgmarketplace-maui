using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace zjgmarketplace.Modules.UI.User.Model.ProfileSection
{
    public abstract class ProfileSectionModel
    {
        protected ProfileSectionModel()
        {
            
        }
        public string Name { get; protected init; }
        public ICommand Command { get; protected init; }
    }
}
