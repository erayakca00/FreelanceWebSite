using FreelanceWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FreelanceWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Index()
        {
            return View();
        }
           
        public IActionResult Profile()  
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Network()
        {
            return View();
        }

        public IActionResult Jobs()
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