using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;

namespace REST_API_Example.Controllers
{
    public class ProductController : Controller
    {
        [Route("/enterprises/{enterpriseId}/products")]
        [HttpGet]
        public IActionResult ProductsByEnterprise([FromRoute] int enterpriseId)
        {
            List<Product> products = new List<Product>();

            //Load all products from enterprise with entered id from DB

            return View(products);
        }

        [Route("/products")]
        [HttpGet]
        public IActionResult AllProducts()
        {
            List<Product> products = new List<Product>();

            //Read all products from DB

            return View(products);
        }

        [Route("/products/{id}")]
        [HttpGet]
        public IActionResult Product([FromRoute] int id)
        {
            Product product = new Product();

            //Шукаємо об'єкт по заданому id

            return View(product);
        }

        [Route("/products")]
        [HttpPut]
        public IActionResult Update([FromBody] Product product)
        {
            List<Product> orders = new List<Product>();

            //Оновлюємо об'єкт в бд

            return RedirectToAction(nameof(ProductsByEnterprise), new int());
        }

        [Route("/products")]
        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            //додаємо об'єкт в бд

            return RedirectToAction(nameof(ProductsByEnterprise), new int());
        }

        [Route("/products/{id}")]
        [HttpDelete]
        public IActionResult Delete([FromRoute] int id)
        {
            //видаляємо об'єкт в бд

            return RedirectToAction(nameof(ProductsByEnterprise), new int());
        }

        [Route("/products")]
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            //видаляємо всі об'єкти в бд

            return RedirectToAction(nameof(ProductsByEnterprise), new int());
        }
    }
}
