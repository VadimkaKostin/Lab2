using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;

namespace REST_API_Example.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Order>()); //Shows all orders
        }

        [Route("/update-order/{id}")]
        [HttpGet]
        public IActionResult UpdateOrder(int id)
        {
            List<Order> orders = new List<Order>();

            //Шукаємо об'єкт по заданому id

            return View(orders);
        }

        [Route("/update-order")]
        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            //Оновлюємо замовлення

            return RedirectToAction(nameof(ListOfOrders));
        }
    }
}
