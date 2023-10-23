using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        IProductOrdersDal _productOrdersDal;

        public OrderManager(IOrderDal orderDal, IProductOrdersDal productOrdersDal)
        {
            _orderDal = orderDal;
            _productOrdersDal = productOrdersDal;
        }

        public void Add(Order order, List<Product> products)
        {
            _orderDal.Add(order);
            foreach (var product in products)
            {
                ProductOrders productOrders = new ProductOrders
                {
                    ProductId = product.Id,
                    OrderId = order.Id,
                    ProductPrice = product.Price,
                    ProductCount=product.Stock
                };
                _productOrdersDal.Add(productOrders);
            }
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
            
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order, List<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
