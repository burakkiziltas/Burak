using deneme.Core.DataAccess;
using deneme.Core.DataAccess.EntityFramework;
using deneme.Northwind.DataAcecess.Abstract;
using deneme.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace deneme.Northwind.DataAcecess.Concrete.EntityFramework
{
    public class EfCategoryDal: EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
