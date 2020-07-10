using deneme.Northwind.Business.Abstract;
using deneme.Northwind.Entities.Concrete;
using deneme.Northwind.MvcWebUI.Models;
using deneme.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICardSessionService _cardSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(ICardSessionService cardSessionService,ICartService cartService,IProductService productService)
        {
            _cardSessionService = cardSessionService;
            _cartService = cartService;
            _productService = productService;
        }
        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cardSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cardSessionService.SetCard(cart);
            TempData.Add("message", string.Format("{0} Ürün başarıyla eklendi.", productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }
        public ActionResult List()
        {
            var cart = _cardSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }
        public ActionResult Remove(int productId)
        {
            var cart = _cardSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cardSessionService.SetCard(cart);
            TempData.Add("message", " Ürün sepetten silindi.");
            return RedirectToAction("List");
        }
        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", string.Format("Thank you {0} , your order is in proccess", shippingDetails.FirstName));
            return View();
        }
    }
}