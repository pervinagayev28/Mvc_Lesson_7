using Microsoft.AspNetCore.Mvc;
using Mvc_Lesson_7.Models;
using System.Diagnostics;

namespace Mvc_Lesson_7.Controllers
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
        public ActionResult About()
        {
            ViewBag.Message = "application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact page.";
            return View();
        }
    }
}
