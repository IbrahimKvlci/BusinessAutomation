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
using WindowsFormsApp.CommonClasses.ImageTool.Abstract;
using WindowsFormsApp.CommonClasses.ImageTool.Concrete;

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
            _iProductService = new ProductManager(new EfProductDal());
            _iBrandService=new BrandManager(new EfBrandDal());
            _iCategoryService = new CategoryManager(new EfCategoryDal());
            _iGetAllEntites = new GetAllEntites();
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
            Product product = new Product {
                Barcode = tbxBarkodAdd.Text,
                Name = tbxTitleMMF.Text,
                BrandId= Convert.ToInt32(cbxBrandMMF.SelectedValue),
                CategoryId= Convert.ToInt32(cbxCategoryMMF.SelectedValue),
                Price=nbPriceMMF.Value,
                Stock=(int)nbStockMMF.Value,
                ImageUrl=pbxImageMMF.ImageLocation

            };

            _iProductService.Add(product);
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
