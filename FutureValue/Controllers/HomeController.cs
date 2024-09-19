using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;


namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.90;
            return View();
        }
        [HttpPost]
       public IActionResult Index(FutureValueModel model) 
        {
            if (ModelState.IsValid) 
            
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
           
            return View(model);
        }

       
    }
}