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
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        Product GetProductById(int id);
        Product GetProductByBarcode(string barcode);
        List<Product> GetAllByCategoryId(int categoryId);
        List<ProductDetailsDTO> GetAllProductsDetails();
        ProductDetailsDTO GetProductDetailsByProductId(int id);

    }
}
