using Microsoft.AspNetCore.Mvc;

namespace ContactMVC1.Controllers
{
    public class DetailController:Controller
    {
        HomeController hcontroller = new HomeController();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details() {


            return View(hcontroller.Contacts);
        }
    }
}
