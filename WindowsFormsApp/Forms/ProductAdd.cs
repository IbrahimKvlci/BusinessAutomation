﻿using Business.Abstract;
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

namespace WindowsFormsApp.Forms
{
    public partial class ProductAdd : Form
    {
        IProductService _iProductService;
        IBrandService _iBrandService;
        ICategoryService _iCategoryService;

        public ProductAdd()
        {
            InitializeComponent();
            _iProductService = new ProductManager(new EfProductDal());
            _iBrandService=new BrandManager(new EfBrandDal());
            _iCategoryService = new CategoryManager(new EfCategoryDal());
        }

        private void pbxImageMMF_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"Images\";
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }

            using (OpenFileDialog fileDialog=new OpenFileDialog())
            {
                fileDialog.Title = "Urun Resmi Secin";
                fileDialog.Filter= "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string combinedAppPath = Path.Combine(appPath, Path.GetFileName(fileDialog.FileName));
                    File.Copy(fileDialog.FileName,combinedAppPath );
                    pbxImageMMF.ImageLocation = combinedAppPath;
                    pbxImageMMF.Image = new Bitmap(fileDialog.FileName);
                }
            }
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

            cbxCategoryMMF.DataSource = categories;
            cbxCategoryMMF.DisplayMember = "Name";
            cbxCategoryMMF.ValueMember = "Id";

        }

        void GetAllBrands()
        {
            var brands = _iBrandService.GetAll();

            cbxBrandMMF.DataSource = brands;
            cbxBrandMMF.DisplayMember = "Name";
            cbxBrandMMF.ValueMember = "Id";
        }


        private void ProductAdd_Load(object sender, EventArgs e)
        {
            GetAllCategories();
            GetAllBrands();
        }
    }
}
