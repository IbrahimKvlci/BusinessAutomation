using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.CommonClasses.Abstract;

namespace WindowsFormsApp.CommonClasses
{
    public class GetAllEntites : IGetAllEntites
    {
        public void GetAllBrandsToComboBox(ComboBox cbx,List<Brand> brands)
        {
            cbx.DataSource = brands;
            cbx.DisplayMember = "Name";
            cbx.ValueMember = "Id";
        }

        public void GetAllCategoriesToComboBox(ComboBox cbx,List<Category> categories)
        {
            cbx.DataSource = categories;
            cbx.DisplayMember = "Name";
            cbx.ValueMember = "Id";
        }
    }
}
