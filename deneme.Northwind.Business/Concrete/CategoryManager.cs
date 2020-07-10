using deneme.Northwind.Business.Abstract;
using deneme.Northwind.DataAcecess.Abstract;
using deneme.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace deneme.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
