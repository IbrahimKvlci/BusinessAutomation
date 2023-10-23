using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        void Add(Order order,List<Product> products);
        void Update(Order order,List<Product> products);
        void Delete(Order order);
        List<Order> GetAll();
        Order GetOrderById(int id);
    }
}
