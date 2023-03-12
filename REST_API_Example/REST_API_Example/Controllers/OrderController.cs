using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;

namespace REST_API_Example.Controllers
{
    public class OrderController : Controller
    {
        [Route("/orders")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Order> orders = new List<Order>();

            //Load all orders from DB

            return View(orders); 
        }
    }
}
