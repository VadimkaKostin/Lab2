using Microsoft.AspNetCore.Mvc;

namespace REST_API_Example.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
