using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;

namespace REST_API_Example.Controllers
{
    public class OrderController : Controller
    {
        [Route("/orders")]
        [HttpGet]
        public IActionResult Orders()
        {
            var orders = new List<Order>();

            //Get orders from db

            return View(orders);
        }

        [Route("/orders/{id}")]
        [HttpGet]
        public IActionResult Order([FromRoute] int id)
        {
            Order orders = new Order();

            //Шукаємо об'єкт по заданому id

            return View(orders);
        }

        [Route("/orders")]
        [HttpPut]
        public IActionResult Update([FromBody] Order order)
        {
            //Оновлюємо замовлення

            return RedirectToAction(nameof(Orders));
        }

        [Route("/orders")]
        [HttpPost]
        public IActionResult Create([FromBody] Order order)
        {
            //Додаємо замовлення

            return RedirectToAction(nameof(Orders));
        }

        [Route("/orders/{id}")]
        [HttpDelete]
        public IActionResult Delete([FromRoute] int id)
        {
            //Видаляємо замовлення

            return RedirectToAction(nameof(Orders));
        }

        [Route("/orders")]
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            //Видаляємо всі замовлення

            return RedirectToAction(nameof(Orders));
        }
    }
}
