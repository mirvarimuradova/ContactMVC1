using ContactMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactMVC1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        public List<Contact> Contacts { get; private set; } = new List<Contact>();

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;

        
        //}

        public IActionResult Index()
        {
            Contact contact1 = new Contact("Mirvari", "+994123445553", "jhasjdhbdjsfhb");
            Contact contact2 = new Contact("Zahra", "+994667778899", "asxcjsdiwye");
            Contact contact3 = new Contact("Esma", "+994567890234", "ahsmvdjwggwie");

            Contacts.Add(contact1);
            Contacts.Add(contact2);
           Contacts.Add(contact3);
            
            return View(Contacts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
