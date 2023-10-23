using Business.Abstract;
using Business.Concrete;
using Business.Core.Tools.HtmlAgility.Concrete;
using Business.Core.Tools.MyWebClient.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Forms;
using WindowsFormsApp.Tools.Request;

namespace WindowsFormsApp.Componenets
{
    public partial class ProductWidget : UserControl
    {


        int _productId;


        IProductService _iProductService;

        public ProductWidget()
        {
            InitializeComponent();
            _iProductService = new ProductManager(new EfProductDal(), new MyWebClient(), new HtmlAgility());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void GetProductProperties(string lblBrand,string lblCategory,string lblPrice,string imageProduct,string lblTitle,int productId)
        {
            lblBrandProduct.Text = lblBrand;
            lblCategoryProduct.Text = lblCategory;
            lblPriceProduct.Text = $"{lblPrice} ₺";
            pbxImageProduct.ImageLocation=imageProduct;
            lblTitleProduct.Text=lblTitle;
            _productId = productId;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            ProductUpdate productUpdate = new ProductUpdate(_productId);
            productUpdate.Show();
            
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var result=_iProductService.Delete(_iProductService.GetProductById(_productId).Data);
            Request.ShowRequest(result);
        }
    }
}
