using deneme.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace deneme.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}