using Business.Abstract;
using Business.Concrete;
using Business.Core.Tools.HtmlAgility.Concrete;
using Business.Core.Tools.MyWebClient.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.CommonClasses;
using WindowsFormsApp.CommonClasses.Abstract;
using WindowsFormsApp.Tools.Request;

namespace WindowsFormsApp.Forms
{
    public partial class SetSaleForm : Form
    {
        IProductService _iProductService;
        ICategoryService _categoryService;
        IGetAllEntites _iGetAllEntities;
        IBrandService _brandService;

        public SetSaleForm()
        {
            InitializeComponent();
            _iProductService = Form1._iProductService;
            _iGetAllEntities = Form1._iGetAllEntites;
            _categoryService = Form1._iCategoryService;
            _brandService = Form1._iBrandService;
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var products = _iProductService.GetAll().Data;
            SetSalePriceToProducts(products,cbxSaleAll,nmValueAll);
            Cursor = Cursors.Default;
            Request.ShowRequest("Fiyatlar Guncellendi", true);
        }

        void SetSalePriceToProducts(List<Product> products,ComboBox cbxSale,NumericUpDown nmValue)
        {
            
            if (cbxSale.SelectedIndex == 0)
            {
                foreach (var product in products)
                {
                    product.Price = product.Price - product.Price * nmValue.Value / 100;
                    _iProductService.Update(product);
                }
            }
            else if(cbxSale.SelectedIndex == 1)
            {
                foreach (var product in products)
                {
                    product.Price = product.Price + product.Price * nmValue.Value / 100;
                    _iProductService.Update(product);
                }
            } 
        }

        private void btnApplyCategory_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var products = _iProductService.GetAllByCategoryId((int)cbxCategory.SelectedValue).Data;
            SetSalePriceToProducts(products,cbxSaleCategory,nmValueCategory);
            Cursor = Cursors.Default;
            Request.ShowRequest("Fiyatlar Guncellendi", true);
        }

        private void SetSaleForm_Load(object sender, EventArgs e)
        {
            _iGetAllEntities.GetAllCategoriesToComboBox(cbxCategory, _categoryService.GetAll());
            _iGetAllEntities.GetAllBrandsToComboBox(cbxBrand,_brandService.GetAll());
        }

        private void btnApplyBrand_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var products = _iProductService.GetAllByBrandId((int)cbxBrand.SelectedValue).Data;
            SetSalePriceToProducts(products, cbxSaleBrand, nmValueBrand);
            Cursor = Cursors.Default;
            Request.ShowRequest("Fiyatlar Guncellendi", true);
        }
    }
}
