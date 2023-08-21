using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Componenets
{
    public partial class ProductWidget : UserControl
    {
        public ProductWidget()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void GetProductProperties(string lblBrand,string lblCategory,string lblPrice,string imageProduct,string lblTitle)
        {
            lblBrandProduct.Text = lblBrand;
            lblCategoryProduct.Text = lblCategory;
            lblPriceProduct.Text = $"{lblPrice} ₺";
            pbxImageProduct.ImageLocation=imageProduct;
            lblTitleProduct.Text=lblTitle;
            
        }
    }
}
