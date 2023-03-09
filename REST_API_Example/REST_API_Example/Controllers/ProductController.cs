using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;

namespace REST_API_Example.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()//Gets some filters
        {
            return View(new List<Product>()); // get all filtered products 
        }

        [Route("/create-product")]
        [HttpGet]
        public IActionResult CreateProduct(int id)
        {
            List<Order> orders = new List<Order>();

            //Шукаємо об'єкт по заданому id

            return View(orders);
        }

        [Route("/create-product")]
        [HttpPut]
        public IActionResult CreateProduct(int id)
        {
            List<Order> orders = new List<Order>();

            //Шукаємо об'єкт по заданому id

            return View(orders);
        }
    }
}
