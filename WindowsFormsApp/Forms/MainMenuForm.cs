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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.CommonClasses;
using WindowsFormsApp.CommonClasses.Abstract;
using WindowsFormsApp.Componenets;
using WindowsFormsApp.Tools.Request;

namespace WindowsFormsApp.Forms
{
    public partial class MainMenuForm : Form
    {
  

        IProductService _iProductService;
        IBrandService _iBrandService;
        ICategoryService _iCategoryService;
        IOrderService _iOrderService;
        IGetAllEntites _iGetAllEntites;



        Product _product;

        List<BasketWidget> _productsInBasket;
        List<Brand> _brands;
        List<Category> _categories;

        decimal _totalPrice;

        public MainMenuForm()
        {
            InitializeComponent();
            _productsInBasket = new List<BasketWidget>();

            _productsInBasket.Clear();
            _iProductService = Form1._iProductService;
            _iBrandService = Form1._iBrandService;
            _iCategoryService = Form1._iCategoryService;
            _iOrderService = Form1._iOrderService;
            _iGetAllEntites = Form1._iGetAllEntites;


        }

        private void lblBarcode_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            _brands = Form1._brands;
            _iGetAllEntites.GetAllBrandsToComboBox(cbxBrandMMF, _brands);
            _categories = Form1._categories;
            _iGetAllEntites.GetAllCategoriesToComboBox(cbxCategoryMMF, _categories);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxBarkodMMF_TextChanged(object sender, EventArgs e)
        {
            tbxBarkodMMF.Focus();
            RefreshValues();
            _product = _iProductService.GetProductByBarcode(tbxBarkodMMF.Text).Data;

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

                BasketWidget basketWidget = new BasketWidget(_product,_productsInBasket,flowLayoutPanel1,lblBasketPrice);
                _productsInBasket.Add(basketWidget);
                AddProductsToBasket(_productsInBasket, flowLayoutPanel1,lblBasketPrice);
            }
            else
            {
                lblProductInfo.Text = "Urun Bulunamadi!";
                addBtn.Visible = true;

            }
            
        }




        void getAllBrands()
        {
            _brands = _iBrandService.GetAll();
            _iGetAllEntites.GetAllBrandsToComboBox(cbxBrandMMF, _brands);
        }

        void getAllCategories()
        {
            _categories = _iCategoryService.GetAll();
            _iGetAllEntites.GetAllCategoriesToComboBox(cbxCategoryMMF, _categories);
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

                var request= _iProductService.Update(product);
                Request.ShowRequest(request);
                RefreshValues();
                tbxBarkodMMF.Text = "";

            }
            
        }

        private void btnDeleteMMF_Click(object sender, EventArgs e)
        {
            if (_product != null)
            {
                var request= _iProductService.Delete(_product);
                Request.ShowRequest(request);
                ClearBasket();
                RefreshValues();
                tbxBarkodMMF.Text = "";
            }
           
        }

        private void cbxCategoryMMF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (cbxCategoryMMF.SelectedValue == null && cbxCategoryMMF.Text.Length>0)
            {
                int categoryId;
                if (_iCategoryService.IsExist(cbxCategoryMMF.Text, out categoryId))
                {
                    cbxCategoryMMF.SelectedValue = categoryId;
                }
                else
                {
                    Category category = new Category { Name = cbxCategoryMMF.Text };
                    _iCategoryService.Add(category);
                    categoryId = category.Id;
                    getAllCategories();
                    cbxCategoryMMF.SelectedValue = categoryId;
                }
            }
            if (cbxBrandMMF.SelectedValue == null && cbxBrandMMF.Text.Length>0)
            {
                int brandId;
                if (_iBrandService.IsExist(cbxBrandMMF.Text, out brandId))
                {
                    cbxBrandMMF.SelectedValue = brandId;
                }
                else
                {
                    Brand brand = new Brand { Name = cbxBrandMMF.Text };
                    _iBrandService.Add(brand);
                    brandId = brand.Id;
                    getAllBrands();
                    cbxBrandMMF.SelectedValue = brandId;
                }
            }


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
            
            var request=_iProductService.Add(product);
            RefreshValues();
            tbxBarkodMMF.Text = "";
            Request.ShowRequest(request);
        }

        public void AddProductsToBasket(List<BasketWidget> list,FlowLayoutPanel panel,Label label)
        {
            panel.Controls.Clear();
            decimal totalPrice = 0;
            if(list.Count > 0)
            {

                foreach (var item in list)
                {
                    panel.Controls.Add(item);

                    totalPrice += item._totalPrice;

                }
            }
            else
            {

                totalPrice = 0;
            }
            _totalPrice= totalPrice;
            label.Text =totalPrice.ToString();

            //Debug.WriteLine(lblBasketPrice.Text);
        }

        decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in _productsInBasket)
            {
                totalPrice+=item._totalPrice;
            }
            return totalPrice;
        }

        void ClearBasket()
        {
            flowLayoutPanel1.Controls.Clear();
            _productsInBasket.Clear();
            lblBasketPrice.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (_productsInBasket.Count > 0)
            {
                CreateOrder(_productsInBasket);
                _productsInBasket.Clear();
                flowLayoutPanel1.Controls.Clear();
                lblBasketPrice.Text = "";
                Request.ShowRequest("Siparis Tamamlandi", true);
            }
            else
            {
                Request.ShowRequest("Sepet Bos", false);
            }
            
        }

        void CreateOrder(List<BasketWidget> basketWidgets)
        {
            Order order = new Order
            {
                Date = DateTime.Now.ToString(),
                TotalPrice = GetTotalPrice(),
                Count = basketWidgets.Count,
            };
            List<Product> products=new List<Product>();
            
            foreach (var item in basketWidgets)
            {
                products.Add(item._productInBasket);
                Product product = _iProductService.GetProductById(item._product.Id).Data;
                product.Stock -= item._productCount;
                _iProductService.Update(product);
            }
            _iOrderService.Add(order, products);

            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearBasket();
            Request.ShowRequest("Sepet Temizlendi", true);
        }
    }
}
