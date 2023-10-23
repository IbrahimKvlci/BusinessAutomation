using Business.Abstract;
using Business.Constants.Messages;
using Business.Core.Tools.GetPriceFromString;
using Business.Core.Tools.HtmlAgility.Abstract;
using Business.Core.Tools.MyWebClient.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
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

        public ProductManager(IProductDal iProductDal,IWebClient webClient,IHtmlAgility htmlAgility)
        {
            _iProductDal = iProductDal;
        }

        public IResult Add(Product product)
        {
            
            try
            {
                CheckProductPrice(10000, product);
                IsThereNullValue(product);
                _iProductDal.Add(product);
            }
            catch (DbUpdateException)
            {
                return new ErrorResult(Messages.ProductAlreadyExists);
            }
            catch (NullReferenceException)
            {
                return new ErrorResult(Messages.CannotBeNull);
            }
            return new SuccessResult(Messages.ProductAdded);
            
        }

        public IResult Delete(Product product)
        {

            try
            {
                _iProductDal.Delete(product);
            }
            catch (ArgumentNullException)
            {
                return new ErrorResult(Messages.ProductNotExist);
            }
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll());
        }

        public IDataResult<List<Product>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.BrandId == brandId));
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.CategoryId == categoryId)); 
        }

        public IDataResult<List<ProductDetailsDTO>> GetAllProductsDetails()
        {
            return new SuccessDataResult<List<ProductDetailsDTO>>(_iProductDal.GetProductsDetails());
        }

        public IDataResult<Product> GetProductByBarcode(string barcode)
        {
            return new SuccessDataResult<Product>(_iProductDal.Get(p => p.Barcode == barcode));
        }


        public IDataResult<Product> GetProductById(int id)
        {
            return new SuccessDataResult<Product>(_iProductDal.Get(p => p.Id == id));
        }

        public IDataResult<ProductDetailsDTO> GetProductDetailsByProductId(int id)
        {
            return new SuccessDataResult<ProductDetailsDTO>(_iProductDal.GetProductDetails(p => p.Id == id));
        }

        public IResult SetSalePriceToAllProducts(int percentage)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product product)
        {
            CheckProductPrice(10000, product);
            CheckProductStock(product);
            _iProductDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        void CheckProductPrice(int maxPrice,Product product)
        {
            if (product.Price > maxPrice)
            {
                product.Price = 0;
            }
        }

        void CheckProductStock(Product product)
        {
            if (product.Stock < 0)
            {
                product.Stock = 0;
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
            if (product.CategoryId == null || product.CategoryId == 0)
            {
                throw new NullReferenceException("Kategori veya Marka Bos Olamaz!");
            }
            if (product.BrandId == null || product.BrandId == 0)
            {
                throw new NullReferenceException("Kategori veya Marka Bos Olamaz!");
            }
        }
    }
}
