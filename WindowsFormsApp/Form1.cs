using Business.Abstract;
using Business.Concrete;
using Business.Core.Tools.HtmlAgility.Concrete;
using Business.Core.Tools.MyWebClient.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using WindowsFormsApp.CommonClasses;
using WindowsFormsApp.CommonClasses.Abstract;
using WindowsFormsApp.Componenets;
using WindowsFormsApp.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public static IProductService _iProductService;
        public static IBrandService _iBrandService;
        public static ICategoryService _iCategoryService;
        public static IOrderService _iOrderService;
        public static IGetAllEntites _iGetAllEntites;

        public static List<Brand> _brands;
        public static List<Category> _categories;

        public Form1()
        {
            InitializeComponent();
            _iBrandService = new BrandManager(new EfBrandDal());
            _iCategoryService = new CategoryManager(new EfCategoryDal());
            _iProductService = new ProductManager(new EfProductDal(), new MyWebClient(), new HtmlAgility());

            _iGetAllEntites = new GetAllEntites();
            _iOrderService = new OrderManager(new EfOrderDal(), new EfProductOrdersDal());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            _brands = _iBrandService.GetAll();
            _categories = _iCategoryService.GetAll();
        }
    }
}