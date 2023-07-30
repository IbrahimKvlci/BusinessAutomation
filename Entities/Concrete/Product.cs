using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }

    }
}
