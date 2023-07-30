using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        IProductService _iProductService;
        public Form1()
        {
            InitializeComponent();
            _iProductService = new ProductManager(new EfProductDal());
        }

    }
}