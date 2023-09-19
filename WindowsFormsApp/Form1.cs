using Business.Abstract;
using Business.Concrete;
using Business.Core.Tools.HtmlAgility.Concrete;
using Business.Core.Tools.MyWebClient.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using WindowsFormsApp.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        IProductService _iProductService;
        public Form1()
        {
            InitializeComponent();
            _iProductService = new ProductManager(new EfProductDal(), new MyWebClient(), new HtmlAgility());
        }

        void getForm(Form form,Panel panel)
        {
            panel.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }

        private void btnMainMenuPanel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            getForm(mainMenu, pnlMain);
        }

        private void btnProductCrudPanel_Click(object sender, EventArgs e)
        {
            ProductCrudForm productCrudForm = new ProductCrudForm();
            getForm(productCrudForm,pnlMain);
        }

        private void btnSetSalePanel_Click(object sender, EventArgs e)
        {
            SetSaleForm setSaleForm = new SetSaleForm();
            getForm(setSaleForm, pnlMain);
        }



        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}