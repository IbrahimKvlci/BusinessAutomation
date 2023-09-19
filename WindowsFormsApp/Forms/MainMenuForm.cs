using Business.Abstract;
using Business.Concrete;
using Business.Core.Tools.HtmlAgility.Concrete;
using Business.Core.Tools.MyWebClient.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class MainMenuForm : Form
    {
        IProductService _iProductService;
        IBrandService _iBrandService;
        ICategoryService _iCategoryService;

        IGetAllEntites _iGetAllEntites;

        Product _product;

        public MainMenuForm()
        {
            InitializeComponent();
            _iBrandService = new BrandManager(new EfBrandDal());
            _iCategoryService = new CategoryManager(new EfCategoryDal());
            _iProductService = new ProductManager(new EfProductDal(), new MyWebClient(), new HtmlAgility());

            _iGetAllEntites = new GetAllEntites();
        }

        private void lblBarcode_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            getAllBrands();
            getAllCategories();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxBarkodMMF_TextChanged(object sender, EventArgs e)
        {
            RefreshValues();
            _product = _iProductService.GetProductByBarcode(tbxBarkodMMF.Text);

            if (_product != null)
            {
                lblProductInfo.Text = "";
                addBtn.Visible = false;
                tbxTitleMMF.Text = _product.Name;
                cbxBrandMMF.SelectedValue = _product.BrandId;
                cbxCategoryMMF.SelectedValue = _product.CategoryId;
                nbPriceMMF.Value = _product.Price;
                nbStockMMF.Value = _product.Stock;
                pbxImageMMF.ImageLocation = _product.ImageUrl;
            }
            else
            {
                lblProductInfo.Text = "Urun Bulunamadi!";
                addBtn.Visible = true;

            }
            
        }


        void getAllBrands()
        {
            var brands = _iBrandService.GetAll();
            _iGetAllEntites.GetAllBrandsToComboBox(cbxBrandMMF, brands);
        }

        void getAllCategories()
        {
            var categories = _iCategoryService.GetAll();
            _iGetAllEntites.GetAllCategoriesToComboBox(cbxCategoryMMF, categories);
        }

        private void btnUpdateMMF_Click(object sender, EventArgs e)
        {
            if (_product != null)
            {
                Product product = new Product
                {
                    Id = _product.Id,
                    Barcode = tbxBarkodMMF.Text,
                    BrandId = (int)cbxBrandMMF.SelectedValue,
                    CategoryId = (int)cbxCategoryMMF.SelectedValue,
                    Name = tbxTitleMMF.Text,
                    ImageUrl = pbxImageMMF.ImageLocation,
                    Price = nbPriceMMF.Value,
                    Stock = (int)nbStockMMF.Value
                };

                _iProductService.Update(product);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            
        }

        private void btnDeleteMMF_Click(object sender, EventArgs e)
        {
            if (_product != null)
            {
                _iProductService.Delete(_product);
                this.Controls.Clear();
                this.InitializeComponent();
            }
           
        }

        private void cbxCategoryMMF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Barcode = tbxBarkodMMF.Text,
                Name = tbxTitleMMF.Text,
                BrandId = Convert.ToInt32(cbxBrandMMF.SelectedValue),
                CategoryId = Convert.ToInt32(cbxCategoryMMF.SelectedValue),
                Price = nbPriceMMF.Value,
                Stock = (int)nbStockMMF.Value,
                ImageUrl = pbxImageMMF.ImageLocation

            };

            _iProductService.Add(product);
        }

        void RefreshValues()
        {
            tbxTitleMMF.Text = "";
            cbxBrandMMF.SelectedValue = 0;
            cbxCategoryMMF.SelectedValue = 0;
            nbPriceMMF.Value = 0;
            nbStockMMF.Value = 0;
            pbxImageMMF.ImageLocation = "";
        }
    }
}
