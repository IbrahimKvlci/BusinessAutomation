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
        List<ProductDetailsDTO> _list;

        int _index = 0;
        int _range = 0;

        public ProductCrudForm()
        {
            InitializeComponent();
            _iProductService = Form1._iProductService;
            _getAllEntites = Form1._iGetAllEntites;
            _categoryService = Form1._iCategoryService;
            _brandService = Form1._iBrandService;
            _list = new List<ProductDetailsDTO>();
            
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
            
            _productsDetails = _iProductService.GetAllProductsDetails().Data;

            AddProductsToScreen(_productsDetails);
        }

        void AddProductsToScreen(List<ProductDetailsDTO> list)
        {
            if (list.Count<20)
            {
                _range = list.Count;
                _index = 0;
            }
            else if(_index>=list.Count-20)
            {
                _range = 20;
                _index=list.Count-20;
            }
            else if (_index < 0)
            {
                _index = 0;
            }
            else
            {
                _range = 20;
            }



            foreach (var productDetails in list.GetRange(_index,_range))
            {

                    ProductWidget productWidget = new ProductWidget();
                    productWidget.GetProductProperties(productDetails.BrandName.ToString(), productDetails.CategoryName.ToString(), productDetails.Price.ToString(), productDetails.ImageUrl, productDetails.Name, productDetails.Id);
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
                _list.Clear();
                foreach (var item in _productsDetails.Where(p => p.Barcode.StartsWith(tbxBarcodePCF.Text)))
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);
                
            }
            else if (tbxBarcodePCF.Text == "")
            {
                _list.Clear();
                foreach (var item in _productsDetails)
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);
            }
        }

        private void tbxTitlePCF_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (tbxTitlePCF.Text != null)
            {
                _list.Clear();
                foreach (var item in _productsDetails.Where(p => p.Name.ToLower().StartsWith(tbxTitlePCF.Text.ToLower())))
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);

            }
            else if (tbxTitlePCF.Text == "")
            {
                _list.Clear();
                foreach (var item in _productsDetails)
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);
            }
        }

        private void cbxCategoryPCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (cbxCategoryPCF.SelectedIndex !=0)
            {
                _list.Clear();
                foreach (var item in _productsDetails.Where(p => p.CategoryName == cbxCategoryPCF.Text))
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);
            }
            else
            {

                _list.Clear();
                foreach (var item in _productsDetails)
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);
            }
        }

        private void cbxBrandPCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (cbxBrandPCF.SelectedIndex != 0)
            {
                _list.Clear();
                foreach (var item in _productsDetails.Where(p => p.BrandName == cbxBrandPCF.Text))
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);

            }
            else
            {
                _list.Clear();
                foreach (var item in _productsDetails)
                {
                    _list.Add(item);
                }
                flowLayoutPanel1.Controls.Clear();
                AddProductsToScreen(_list);
            }
        }

        private void nmMin_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (nmMax.Value == 0)
            {
                nmMax.Value = 10000;
            }
            _list.Clear();
            foreach (var item in _productsDetails.Where(p => nmMin.Value <= p.Price))
            {
                _list.Add(item);
            }
            List<ProductDetailsDTO> list = new List<ProductDetailsDTO>();
            foreach (var item in _list.Where(p => p.Price <= nmMax.Value))
            {
                list.Add(item);
            }
            _list.Clear();
            foreach (var item in list)
            {
                _list.Add(item);
            }
            flowLayoutPanel1.Controls.Clear();
            AddProductsToScreen(_list);


        }

        private void nmMax_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (nmMax.Value == 0)
            {
                nmMax.Value = 10000;
            }
            _list.Clear();
            foreach (var item in _productsDetails.Where(p => nmMin.Value <= p.Price))
            {
                _list.Add(item);
            }
            List<ProductDetailsDTO> list = new List<ProductDetailsDTO>();
            foreach (var item in _list.Where(p => p.Price <= nmMax.Value))
            {
                list.Add(item);
            }
            _list.Clear();
            foreach (var item in list)
            {
                _list.Add(item);
            }
            flowLayoutPanel1.Controls.Clear();
            AddProductsToScreen(_list);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            _index += 20;
            AddProductsToScreen(_list);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            _index -= 20;
            AddProductsToScreen(_list);
        }
    }
}
