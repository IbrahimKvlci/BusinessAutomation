﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;

        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        public void Add(Product product)
        {
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

        public Product GetProductById(int id)
        {
            return _iProductDal.Get(p => p.Id == id);
        }

        public ProductDetailsDTO GetProductDetailsByProductId(int id)
        {
            return _iProductDal.GetProductDetails(p=>p.Id==id);
        }

        public void Update(Product product)
        {
            _iProductDal.Update(product);
        }
    }
}
