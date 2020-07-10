using deneme.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Northwind.MvcWebUI.Services
{
    public interface ICardSessionService
    {
        Cart GetCart();
        void SetCard(Cart cart);
    }
}
