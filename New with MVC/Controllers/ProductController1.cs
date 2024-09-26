using AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace New_with_MVC.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Productview()
        {
            return View("Index1");
        }
    }
}
