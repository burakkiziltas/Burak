using deneme.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int PageSize { get; internal set; }
        public int PageCount { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CUrrentPage { get; internal set; }
    }
}
