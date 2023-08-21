using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.CommonClasses.Abstract
{
    public interface IGetAllEntites
    {
        void GetAllCategoriesToComboBox(ComboBox cbx, List<Category> categories);
        void GetAllBrandsToComboBox(ComboBox cbx,List<Brand> brands);
    }
}
