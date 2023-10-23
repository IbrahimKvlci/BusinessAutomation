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
using WindowsFormsApp.Tools.Request;

namespace WindowsFormsApp.Forms
{
    public partial class ProductAdd : Form
    {
        IProductService _iProductService;
        IBrandService _iBrandService;
        ICategoryService _iCategoryService;
        IGetAllEntites _iGetAllEntites;

        IImageAdd _imageAdd;

        public ProductAdd()
        {
            InitializeComponent();
            _iProductService = Form1._iProductService;
            _iBrandService = Form1._iBrandService;
            _iCategoryService = Form1._iCategoryService;
            _iGetAllEntites = Form1._iGetAllEntites;
            _imageAdd = new ImageAdd();
        }

        private void pbxImageMMF_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"Images\";
            if (Directory.Exists(appPath) == false)                                             
            {                                                                                   
                Directory.CreateDirectory(appPath);                                            
            }

            _imageAdd.ImageAdd(appPath, pbxImageMMF);
        }

        private void btnAddMMF_Click(object sender, EventArgs e)
        {
            if (cbxCategoryMMF.SelectedValue == null && (cbxCategoryMMF.Text != null || cbxCategoryMMF.Text != ""))
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
                    GetAllCategories();
                    cbxCategoryMMF.SelectedValue = categoryId;
                }
            }
            if (cbxBrandMMF.SelectedValue == null && (cbxBrandMMF.Text != null || cbxBrandMMF.Text != ""))
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
                    GetAllBrands();
                    cbxBrandMMF.SelectedValue = brandId;
                }
            }

            Product product = new Product {
                Barcode = tbxBarkodAdd.Text,
                Name = tbxTitleMMF.Text,
                BrandId= Convert.ToInt32(cbxBrandMMF.SelectedValue),
                CategoryId= Convert.ToInt32(cbxCategoryMMF.SelectedValue),
                Price=nbPriceMMF.Value,
                Stock=(int)nbStockMMF.Value,
                ImageUrl=pbxImageMMF.ImageLocation

            };
            
            var request= _iProductService.Add(product);
            Request.ShowRequest(request);
        }

        void GetAllCategories()
        {
            var categories = _iCategoryService.GetAll();
            _iGetAllEntites.GetAllCategoriesToComboBox(cbxCategoryMMF, categories);
        }

        void GetAllBrands()
        {
            var brands = _iBrandService.GetAll();
            _iGetAllEntites.GetAllBrandsToComboBox(cbxBrandMMF, brands);
        }


        private void ProductAdd_Load(object sender, EventArgs e)
        {
            GetAllCategories();
            GetAllBrands();
        }
    }
}
