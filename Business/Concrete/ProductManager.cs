using Business.Abstract;
using Business.Core.Tools.GetPriceFromString;
using Business.Core.Tools.HtmlAgility.Abstract;
using Business.Core.Tools.MyWebClient.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;
        IWebClient _webClient;
        IHtmlAgility _htmlAgility;
        IGetPrice _getPrice;

        public ProductManager(IProductDal iProductDal,IWebClient webClient,IHtmlAgility htmlAgility)
        {
            _iProductDal = iProductDal;
            _webClient=webClient;
            _htmlAgility = htmlAgility;
            _getPrice = new GetPriceFromTrendyol();
        }

        public void Add(Product product)
        {
            CheckProductPrice(10000, product);
            IsThereNullValue(product);
            _iProductDal.Add(product);
        }

        public void Delete(Product product)
        {
            _iProductDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _iProductDal.GetAll();
        }

        public List<Product> GetAllByBrandId(int brandId)
        {
            return _iProductDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _iProductDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<ProductDetailsDTO> GetAllProductsDetails()
        {
            return _iProductDal.GetProductsDetails();
        }

        public Product GetProductByBarcode(string barcode)
        {
            return _iProductDal.Get(p => p.Barcode == barcode);
        }

        public ProductDetailsDTO GetProductByBarcodeFromTrendyol(string barcode)
        {
            string webSite = "https://www.trendyol.com/sr?q="+barcode;
            
            string htmlData=_webClient.GetDataHtml(webSite);
            var productBrand=_htmlAgility.GetContentFromWebSite(webSite, "//span[@class='prdct-desc-cntnr-ttl']");
            //var productImage = _htmlAgility.GetContentFromWebSiteWithAttributes(webSite, "//span[@class='p-card-img']", "src");
            var productCategory = _htmlAgility.GetContentFromWebSite(webSite, "/html/body/div[1]/div[3]/div[2]/div[2]/div/div/div/div[1]/div[1]/div/div/div[1]/div[2]/div/div/div/div/a/div");
            //var productPrice = _htmlAgility.GetContentFromWebSite(webSite, "/html/body/div[1]/div[3]/div[2]/div[2]/div/div/div/div[1]/div[2]/div[4]/div[1]/div/div/div[1]/a/div[2]/div[3]/div/div/div");
            var productName = _htmlAgility.GetContentFromWebSite(webSite, "//span[@class='prdct-desc-cntnr-name hasRatings']");


            var productDetailsDTO = new ProductDetailsDTO
            {
                Barcode = barcode,
                BrandName = productBrand,
                //ImageUrl = productImage,
                //Price = Convert.ToDecimal(_getPrice.GetPrice(productPrice)),
                Name = productName,
                CategoryName = productCategory
            };
            return productDetailsDTO;
        }

        public Product GetProductById(int id)
        {
            return _iProductDal.Get(p => p.Id == id);
        }

        public ProductDetailsDTO GetProductDetailsByProductId(int id)
        {
            return _iProductDal.GetProductDetails(p=>p.Id==id);
        }

        public void SetSalePriceToAllProducts(int percentage)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            CheckProductPrice(10000, product);
            _iProductDal.Update(product);
        }

        void CheckProductPrice(int maxPrice,Product product)
        {
            if (product.Price > maxPrice)
            {
                product.Price = 0;
            }
        }

        void IsThereNullValue(Product product)
        {
            if (product.ImageUrl == null)
            {
                product.ImageUrl = "https://static.vecteezy.com/system/resources/thumbnails/022/014/063/small/missing-picture-page-for-website-design-or-mobile-app-design-no-image-available-icon-vector.jpg";
            }
            if(product.Name == null)
            {
                product.Name = "No Name";
            }
        }
    }
}
