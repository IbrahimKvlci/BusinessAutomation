using DataAccess.Abstract;
using DataAccess.Core.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepository<Product, KavalciKirtasiyeAutomationContext>, IProductDal
    {
        public ProductDetailsDTO GetProductDetails(Expression<Func<Product, bool>> filter)
        {
            using (KavalciKirtasiyeAutomationContext context = new KavalciKirtasiyeAutomationContext())
            {
                var result = from pro in context.Products.Where(filter)
                             join cate in context.Categories
                             on pro.CategoryId equals cate.Id
                             join bra in context.Brands
                             on pro.BrandId equals bra.Id

                             select new ProductDetailsDTO
                             {
                                 Id = pro.Id,
                                 Barcode = pro.Barcode,
                                 BrandName = bra.Name,
                                 Stock = pro.Stock,
                                 CategoryName = cate.Name,
                                 ImageUrl = pro.ImageUrl,
                                 Name = pro.Name,
                                 Price = pro.Price
                             };
                return result.FirstOrDefault();
            }
        }

        public List<ProductDetailsDTO> GetProductsDetails(Expression<Func<Product, bool>> filter = null)
        {
            using (KavalciKirtasiyeAutomationContext context = new KavalciKirtasiyeAutomationContext())
            {
                var result = from pro in filter == null ? context.Products : context.Products.Where(filter)
                             join cate in context.Categories
                             on pro.CategoryId equals cate.Id
                             join bra in context.Brands
                             on pro.BrandId equals bra.Id

                             select new ProductDetailsDTO
                             {
                                 Id = pro.Id,
                                 Barcode = pro.Barcode,
                                 BrandName = bra.Name,
                                 Stock = pro.Stock,
                                 CategoryName = cate.Name,
                                 ImageUrl = pro.ImageUrl,
                                 Name = pro.Name,
                                 Price = pro.Price
                             };
                return result.ToList();
            }
        }
    }
}
