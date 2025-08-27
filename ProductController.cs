using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Models;  
namespace TiendaOnline.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1000 },
                new Product { Id = 2, Name = "Mouse", Price = 25 }
                };
            return View(products);
        }
 [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = new Product { Id = id, Name = "Example", Price = 123 };
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
