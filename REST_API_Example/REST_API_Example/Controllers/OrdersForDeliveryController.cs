using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;
using System.Collections.Generic;

namespace REST_API_Example.Controllers
{
    public class OrdersForDeliveryController : Controller
    {
        [Route("/orders-for-delivery")]
        public IActionResult GetOrders([FromQuery] float longitude, [FromQuery] float latitude)
        {
            List<OrderForDelivery> orders = new List<OrderForDelivery>();

            //Search orders nearly

            return View();
        }

        [Route("/orders-for-delivery")]
        [HttpPost]
        public IActionResult Create([FromBody] OrderForDelivery orderForDelivery)
        {
            List<OrderForDelivery> orders = new List<OrderForDelivery>();

            //Add orderForDelivery into db

            return RedirectToAction(nameof(GetOrders),new { latitude = new float(), longitude = new float() });
        }

        [Route("/orders-for-delivery")]
        [HttpPut]
        public IActionResult Update([FromBody] OrderForDelivery orderForDelivery)
        {
            OrderForDelivery orders = new OrderForDelivery();

            //Update orderForDelivery in db

            return RedirectToAction(nameof(GetOrders), new { latitude = new float(), longitude = new float() });
        }

        [Route("/orders-for-delivery")]
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            //Delete all ordersForDelivery in db

            return RedirectToAction(nameof(GetOrders), new { latitude = new float(), longitude = new float() });
        }

        [Route("/orders-for-delivery/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //Delete orderForDelivery in db

            return RedirectToAction(nameof(GetOrders), new { latitude = new float(), longitude = new float() });
        }
    }
}
