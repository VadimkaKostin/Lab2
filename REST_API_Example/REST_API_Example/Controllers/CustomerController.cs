using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace REST_API_Example.Controllers
{
    public class CustomerController : Controller
    {
        [Route("/customers")]
        [HttpGet]
        public IActionResult Customers()
        {
            List<Customer> customers = new List<Customer>();

            //Read all customers from DB

            return View(customers);
        }

        [Route("/customers/{id}")]
        [HttpGet]
        public IActionResult CustomerById([FromRoute] int id)
        {
            //Read customer with entered id from DB

            return View(customer);
        }

        [Route("/customers")]
        [HttpPost]
        public IActionResult CreateCustomer([FromBody] Customer? customer)
        {
            //Add new customer to DB

            return RedirectToAction(nameof(CustomerById), new int());
        }

        [Route("/customers")]
        [HttpPut]
        public IActionResult UpdateCustomer([FromBody] Customer? customer)
        {
            //Update customer in DB

            return RedirectToAction(nameof(CustomerById), new int());
        }

        [Route("/customers/{customerId}/products")]
        [HttpPost]
        public IActionResult AddProductToOrder([FromRoute] int customerId, [FromBody] Product? product)
        {
            //Add product to order of customer with entered id to DB

            return RedirectToAction(nameof(CustomerById), new int ());
        }

        [Route("/customers/{customerId}/card")]
        [HttpGet]
        public IActionResult Card([FromRoute] int customerId)
        {
            List<Product> products = new List<Product>();

            //Load all products from last order with entered customer id
            return View(products);
        }

        [Route("/customers")]
        [HttpDelete]
        public IActionResult DeleteCustomers()
        {
            //Delete all customers from DB

            return RedirectToAction(nameof(CustomerById), new int());
        }

        [Route("/customers/{id}")]
        [HttpDelete]
        public IActionResult DeleteCustomer([FromRoute] int id)
        {
            //Delete customer with entered id from DB

            return RedirectToAction(nameof(CustomerById), new int());
        }
    }
}