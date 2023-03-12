using Microsoft.AspNetCore.Mvc;
using REST_API_Example.Models;

namespace REST_API_Example.Controllers
{
    public class EnterpriseController : Controller
    {
        [Route("/enterprises/{cityId?}")]
        [HttpGet]
        public IActionResult Enterprises([FromRoute] int? cityId)
        {
            List<Enterprise> enterprises = new List<Enterprise>();

            if (cityId == null)
                //Load all enterprises from DB
            else
                //Load enterprises located in city with entered id from DB

            return View(enterprises);
        }

        [Route("/enterprises/{id}")]
        [HttpGet]
        public IActionResult Enterprises([FromRoute] int id)
        {
            //Get enterprise with entered id

            return View(enterprise);
        }

        [Route("/enterprises")]
        [HttpPost]
        public IActionResult CreateEnterprise([FromBody] Enterprise? enterprise)
        {
            //Add enterprise to DB

            return RedirectToAction(nameof(Enterprises), new int());
        }

        [Route("/enterprises")]
        [HttpPut]
        public IActionResult UpdateEnterprise([FromBody] Enterprise? enterprise)
        {
            //Update pushed enterprise in DB

            return RedirectToAction(nameof(Enterprises), new int());
        }

        [Route("/enterprises")]
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            //Delete all enterprises from DB

            return RedirectToAction(nameof(Enterprises), new int());
        }

        [Route("/enterprises/{id}")]
        [HttpDelete]
        public IActionResult DeleteAll([FromRoute] int id)
        {
            //Delete enterprise with entered id from DB

            return RedirectToAction(nameof(Enterprises), new int());
        }
    }
}
