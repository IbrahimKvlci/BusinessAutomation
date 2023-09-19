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
using WindowsFormsApp.CommonClasses.ImageTool.Abstract;
using WindowsFormsApp.CommonClasses.ImageTool.Concrete;
using WindowsFormsApp.Componenets;

namespace WindowsFormsApp.Forms
{
    public partial class ProductUpdate : Form
    {
        int _productId;
        Product _product;
        List<Category> _categories;
        List<Brand> _brands;

        IGetAllEntites _iGetAllEntites;

        IProductService _iProductService;
        IBrandService _brandService;
        ICategoryService _categoryService;

        IImageAdd _imageAdd;

        public ProductUpdate(int productId)
        {
            InitializeComponent();
            _productId = productId;
            _iProductService = new ProductManager(new EfProductDal(), new MyWebClient(), new HtmlAgility());
            _iGetAllEntites = new GetAllEntites();
            _brandService = new BrandManager(new EfBrandDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            _imageAdd = new ImageAdd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = _productId,
                Barcode = tbxBarkodUpdate.Text,
                BrandId = (int)cbxBrandUpdate.SelectedValue,
                CategoryId = (int)cbxCategoryUpdate.SelectedValue,
                Name = tbxTitleUpdate.Text,
                ImageUrl = pbxImageUpdate.ImageLocation,
                Price=nbPriceUpdate.Value,
                Stock=(int)nbStockUpdate.Value
            };

            _iProductService.Update(product);

            this.Close();
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            _categories = _categoryService.GetAll();
            _brands = _brandService.GetAll();

            _product = _iProductService.GetProductById(_productId);
            _iGetAllEntites.GetAllBrandsToComboBox(cbxBrandUpdate,_brands);
            _iGetAllEntites.GetAllCategoriesToComboBox(cbxCategoryUpdate, _categories);

            GetProductToScreen();
        }

        void GetProductToScreen()
        {
            tbxBarkodUpdate.Text = _product.Barcode;
            tbxTitleUpdate.Text = _product.Name;
            cbxBrandUpdate.SelectedValue = _product.BrandId;
            cbxCategoryUpdate.SelectedValue = _product.CategoryId;
            pbxImageUpdate.ImageLocation = _product.ImageUrl;
            nbPriceUpdate.Value = _product.Price;
            nbStockUpdate.Value = _product.Stock;

        }

        private void pbxImageUpdate_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"Images\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }

            _imageAdd.ImageAdd(appPath, pbxImageUpdate);
        }
        
    }
}
