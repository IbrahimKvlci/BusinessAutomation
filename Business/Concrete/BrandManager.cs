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
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;
        public BrandManager(IBrandDal iBrandDal)
        {
            _iBrandDal = iBrandDal;
        }

        public void Add(Brand brand)
        {
            _iBrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _iBrandDal.GetAll();
        }

        public Brand GetBrandById(int id)
        {
            return _iBrandDal.Get(b => b.Id == id);
        }

        public bool IsExist(string name,out int id)
        {
            var brand = _iBrandDal.Get(b => b.Name == name);
            if(brand != null)
            {
                id = brand.Id;
                return true;
            }
            id = -1;
            return false;
        }

        public void Update(Brand brand)
        {
            _iBrandDal.Update(brand);
        }
    }
}
