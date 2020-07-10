using deneme.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace deneme.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

    }
}
