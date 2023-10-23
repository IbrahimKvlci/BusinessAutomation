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
using WindowsFormsApp.Forms;

namespace WindowsFormsApp.Componenets
{
    public partial class BasketWidget : UserControl
    {
        public decimal _totalPrice;
        public int _productCount;

        int _productId;

        List<BasketWidget> _list;
        FlowLayoutPanel _panel;
        MainMenuForm _mainMenuForm;
        public Product _product;
        public Product _productInBasket;

        Label _label;


        public BasketWidget(Product product, List<BasketWidget> list, FlowLayoutPanel panel, Label label)
        {
            InitializeComponent();
            _mainMenuForm = new MainMenuForm();
            _product = product;
            _list = list;
            _panel = panel;
            _label = label;
            this.nmCount.Value = 1;
            _productCount = 1;
            nmCount.Maximum = _product.Stock;
            _productInBasket = new Product
            {
                Stock = 1,
                Barcode=_product.Barcode,
                BrandId=_product.BrandId,
                CategoryId = _product.CategoryId,
                ImageUrl = _product.ImageUrl,
                Name = _product.Name,
                Price = _product.Price,
            };
            GetProperties();
        }

        private void BasketWidget_Load(object sender, EventArgs e)
        {
            
        }

        void GetProperties()
        {
            this.lblBarcode.Text = _product.Barcode;
            this.lblPrice.Text = $"{_totalPrice}";
            this.lblTitle.Text = _product.Name;
            this.pbxImage.ImageLocation = _product.ImageUrl;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _totalPrice = 0;
            _list.Remove(this);
            _mainMenuForm.AddProductsToBasket(_list, _panel, _label) ;
        }

        private void nmCount_ValueChanged(object sender, EventArgs e)
        {
            _totalPrice = _product.Price * this.nmCount.Value;
            _mainMenuForm.AddProductsToBasket(_list, _panel,_label);
            _productCount = (int)nmCount.Value;
            if (_productInBasket != null)
            {
                _productInBasket.Stock = (int)nmCount.Value;
            }
            
            GetProperties();
        }
    }
}
