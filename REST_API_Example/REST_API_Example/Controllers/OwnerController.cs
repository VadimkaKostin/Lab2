using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;

namespace REST_API_Example.Controllers
{
    public class OwnerController : Controller
    {
        [Route("/orders-list")]
        public IActionResult ListOfOrders()
        {
            List<Order> orders = new List<Order>();

            //Отримуємо список замовлень для даного закладу

            return View(orders);
        }
    }
}
