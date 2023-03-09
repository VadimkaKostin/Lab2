using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace REST_API_Example.Controllers
{
    public class CustomerController : Controller
    {
        [Route("/enterprises")]
        [HttpGet]
        public IActionResult Enterprises()
        {
            List<Enterprise> enterprises = new List<Enterprise>();

            //Load all enterprises from DB

            return View(enterprises);
        }

        [Route("/enterprises/{enterpriseId}/products")]
        [HttpGet]
        public IActionResult Products([FromRoute] int enterpriseId)
        {
            List<Product> products = new List<Product>();

            //Load all products from enterprise with entered id from DB

            return View(products);
        }

        [Route("/orders")]
        [HttpPost]
        public IActionResult AddOrder([FromBody] Order? order)
        {
            //Create new order and add it to DB
            return View();
        }

        [Route("/orders/{orderId}")]
        [HttpPost]
        public IActionResult AddProductToOrder([FromRoute] int orderId, [FromBody] Product? product)
        {
            //Add product to DB and bind it to order with entered Id
            return View();
        }

        [Route("/users/{customerId}/card")]
        [HttpGet]
        public IActionResult Card([FromRoute] int customerId)
        {
            List<Product> products = new List<Product>();

            //Load all products from last order with entered customer id
            return View(products);
        }
    }
}