using deneme.Northwind.Business.Abstract;
using deneme.Northwind.Entities.Concrete;
using deneme.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Northwind.MvcWebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }
        public ActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()

            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                TempData.Add("message", "Product was not succesfully added.");
                return View();
            }
            _productService.Add(product);
            TempData.Add("message", "Product was succesfully added.");
            return RedirectToAction("Add");
        }
        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                TempData.Add("message", "Product was not succesfully updated.");
                return View();
            }
            _productService.Update(product);
            TempData.Add("message", "Product was succesfully updated.");
            return RedirectToAction("Update");
        }


        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempData.Add("message", "Product was succesfully deleted");
            return RedirectToAction("Index");
        }
    }
}