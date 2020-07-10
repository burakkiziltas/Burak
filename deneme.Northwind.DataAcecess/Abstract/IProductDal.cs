using deneme.Core.DataAccess;
using deneme.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace deneme.Northwind.DataAcecess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
