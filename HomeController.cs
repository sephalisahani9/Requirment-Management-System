using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMS.Controllers
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

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Application()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }

        public IActionResult Experience()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }

        public IActionResult ExamName()
        {
            return View();
        }
        public IActionResult Specialisation()
        {
            return View();
        }
        public IActionResult PWD()
        {
            return View();
        }
        public IActionResult MaratialStatus()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Advertisment()
        {
            return View();
        }
        public IActionResult PostMaster()
        {
            return View();
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