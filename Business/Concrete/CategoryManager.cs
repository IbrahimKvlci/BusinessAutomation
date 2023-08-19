﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _iCategoryDal;

        public CategoryManager(ICategoryDal iCategoryDal)
        {
            _iCategoryDal = iCategoryDal;
        }

        public void Add(Category category)
        {
            _iCategoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _iCategoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _iCategoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _iCategoryDal.Get(c => c.Id == id);
        }

        public void Update(Category category)
        {
            _iCategoryDal.Update(category);
        }
    }
}