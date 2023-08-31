using Business.Abstract;
using Business.Concrete;
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
            _iProductService = new ProductManager(new EfProductDal());
            _iGetAllEntities = new GetAllEntites();
            _categoryService = new CategoryManager(new EfCategoryDal());
            _brandService=new BrandManager(new EfBrandDal());
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            var products = _iProductService.GetAll();
            SetSalePriceToProducts(products,cbxSaleAll,nmValueAll);
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
            var products = _iProductService.GetAllByCategoryId((int)cbxCategory.SelectedValue);
            SetSalePriceToProducts(products,cbxSaleCategory,nmValueCategory);
        }

        private void SetSaleForm_Load(object sender, EventArgs e)
        {
            _iGetAllEntities.GetAllCategoriesToComboBox(cbxCategory, _categoryService.GetAll());
            _iGetAllEntities.GetAllBrandsToComboBox(cbxBrand,_brandService.GetAll());
        }

        private void btnApplyBrand_Click(object sender, EventArgs e)
        {
            var products = _iProductService.GetAllByBrandId((int)cbxBrand.SelectedValue);
            SetSalePriceToProducts(products, cbxSaleBrand, nmValueBrand);
        }
    }
}
