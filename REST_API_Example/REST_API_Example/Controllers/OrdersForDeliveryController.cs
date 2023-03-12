using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;
using System.Collections.Generic;

namespace REST_API_Example.Controllers
{
    public class OrdersForDeliveryController : Controller
    {
        [Route("/orders-for-delivery")]
        public IActionResult GetOrders([FromBody] float longitude, [FromBody] float latitude)
        {
            List<OrderForDelivery> orders = new List<OrderForDelivery>();

            //Search orders nearly

            return View();
        }
    }
}
