using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetProductById(int id);
        IDataResult<Product> GetProductByBarcode(string barcode);
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetAllByBrandId(int brandId);
        IDataResult<List<ProductDetailsDTO>> GetAllProductsDetails();
        IDataResult<ProductDetailsDTO> GetProductDetailsByProductId(int id);
        IResult SetSalePriceToAllProducts(int percentage);
    }
}
