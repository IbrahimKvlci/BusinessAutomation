using Business.Abstract;
using Business.Concrete;
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
using WindowsFormsApp.Componenets;

namespace WindowsFormsApp.Forms
{
    public partial class ProductCrudForm : Form
    {
        IProductService _iProductService;
        IGetAllEntites _getAllEntites;
        ICategoryService _categoryService;
        IBrandService _brandService;

        List<ProductDetailsDTO> _productsDetails;

        public ProductCrudForm()
        {
            InitializeComponent();
            _iProductService = new ProductManager(new EfProductDal());
            _getAllEntites = new GetAllEntites();
            _categoryService = new CategoryManager(new EfCategoryDal());
            _brandService=new BrandManager(new EfBrandDal());
        }

        private void btnAddPCF_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd.Show();
        }

        private void ProductCrudForm_Load(object sender, EventArgs e)
        {
            GetAllProductsOnScreenWhenFormLoad();

            var categories = _categoryService.GetAll();
            categories.Insert(0,new Category { Name = "Tumu" });

            var brands = _brandService.GetAll();
            brands.Insert(0, new Brand { Name = "Tumu" });

            _getAllEntites.GetAllCategoriesToComboBox(cbxCategoryPCF, categories);
            _getAllEntites.GetAllBrandsToComboBox(cbxBrandPCF, brands);
        }

        void GetAllProductsOnScreenWhenFormLoad()
        {
            
            _productsDetails = _iProductService.GetAllProductsDetails();

            AddProductsToScreen(_productsDetails);
        }

        void AddProductsToScreen(List<ProductDetailsDTO> list)
        {

            foreach (var productDetails in list)
            {
                ProductWidget productWidget = new ProductWidget();
                productWidget.GetProductProperties(productDetails.BrandName.ToString(), productDetails.CategoryName.ToString(), productDetails.Price.ToString(), productDetails.ImageUrl, productDetails.Name,productDetails.Id);
                flowLayoutPanel1.Controls.Add(productWidget);
            }
        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxBarcodePCF_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (tbxBarcodePCF.Text != null)
            {
                var list=_productsDetails.Where(p => p.Barcode.StartsWith(tbxBarcodePCF.Text));
                AddProductsToScreen(list.ToList());
            }
            else if (tbxBarcodePCF.Text == "")
            {
                AddProductsToScreen(_productsDetails);
            }
        }

        private void tbxTitlePCF_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (tbxTitlePCF.Text != null)
            {
                var list = _productsDetails.Where(p => p.Name.ToLower().StartsWith(tbxTitlePCF.Text.ToLower()));
                AddProductsToScreen(list.ToList());
            }
            else if (tbxTitlePCF.Text == "")
            {
                AddProductsToScreen(_productsDetails);
            }
        }

        private void cbxCategoryPCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (cbxCategoryPCF.SelectedIndex !=0)
            {
                var list=_productsDetails.Where(p=>p.CategoryName==cbxCategoryPCF.Text);;
                AddProductsToScreen(list.ToList());
            }
            else
            {
                AddProductsToScreen(_productsDetails);
            }
        }

        private void cbxBrandPCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (cbxBrandPCF.SelectedIndex != 0)
            {
                var list = _productsDetails.Where(p => p.BrandName == cbxBrandPCF.Text); ;
                AddProductsToScreen(list.ToList());
            }
            else
            {
                AddProductsToScreen(_productsDetails);
            }
        }
    }
}
