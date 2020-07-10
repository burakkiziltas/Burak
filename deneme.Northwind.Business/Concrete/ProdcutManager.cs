using deneme.Northwind.Business.Abstract;
using deneme.Northwind.DataAcecess.Abstract;
using deneme.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace deneme.Northwind.Business.Concrete
{
    public class ProdcutManager : IProductService
    {
        private IProductDal _productDal;
        public ProdcutManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId||categoryId==0);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
