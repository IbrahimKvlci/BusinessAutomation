using DataAccess.Core.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailsDTO> GetProductsDetails(Expression<Func<Product, bool>> filter = null);
        ProductDetailsDTO GetProductDetails(Expression<Func<Product, bool>> filter);
    }
}
