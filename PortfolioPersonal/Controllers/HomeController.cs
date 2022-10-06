using Microsoft.AspNetCore.Mvc;
using PortfolioPersonal.Models;
using System.Diagnostics;

namespace PortfolioPersonal.Controllers
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

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }


        [HttpPost]
         public IActionResult Contacto(Mensaje mensaje)
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