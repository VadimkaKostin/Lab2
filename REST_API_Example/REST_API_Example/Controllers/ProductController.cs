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
    }
}
