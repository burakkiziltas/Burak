using deneme.Northwind.Entities.Concrete;
using deneme.Northwind.MvcWebUI.Models;
using deneme.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Northwind.MvcWebUI.ViewComponents
{
    public class CardSummaryViewComponent:ViewComponent
    {
        private ICardSessionService _cartSessionService;
        public CardSummaryViewComponent(ICardSessionService cardSessionService)
        {
            _cartSessionService = cardSessionService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel()
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }

   
}
