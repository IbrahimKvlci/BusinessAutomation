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
using WindowsFormsApp.Componenets;

namespace WindowsFormsApp.Forms
{
    public partial class ProductCrudForm : Form
    {
        IProductService _iProductService;

       

        public ProductCrudForm()
        {
            InitializeComponent();
            _iProductService = new ProductManager(new EfProductDal());
        }

        private void btnAddPCF_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd.Show();
        }

        private void ProductCrudForm_Load(object sender, EventArgs e)
        {
            GetAllProductsOnScreen();
         
        }

        void GetAllProductsOnScreen()
        {
            List<ProductDetailsDTO> productsDetails = new List<ProductDetailsDTO>();
            productsDetails = _iProductService.GetAllProductsDetails();

            foreach (var productDetails in productsDetails)
            {
                ProductWidget productWidget = new ProductWidget();
                productWidget.GetProductProperties(productDetails.BrandName.ToString(), productDetails.CategoryName.ToString(), productDetails.Price.ToString(), productDetails.ImageUrl, productDetails.Name);
                flowLayoutPanel1.Controls.Add(productWidget);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
