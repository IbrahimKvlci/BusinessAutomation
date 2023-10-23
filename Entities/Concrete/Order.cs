using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
