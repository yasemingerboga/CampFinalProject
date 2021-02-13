using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categaryDal;
        public CategoryManager(ICategoryDal categaryDal)
        {
            _categaryDal = categaryDal;
        }
        public List<Category> GetAll()
        {
            return _categaryDal.GetAll();
        }
        //Select * from Categories where CategoryId = categoryId
        public Category GetById(int categoryId)
        {
            return _categaryDal.Get(c => c.CategoryID == categoryId);
        }
    }
}
