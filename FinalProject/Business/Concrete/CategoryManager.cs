using Business.Abstract;
using Core.Utilities.Results;
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
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>( _categaryDal.GetAll());
        }
        //Select * from Categories where CategoryId = categoryId
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categaryDal.Get(c => c.CategoryID == categoryId));
        }
    }
}
