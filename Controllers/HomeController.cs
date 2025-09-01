using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "¡Hola desde la Vista!";
            return View();
        }

        public IActionResult Morning()
        {
            ViewBag.Message = "¡Buenos días desde la Vista!";
            return View("Home"); // Reusa la misma vista
        }

        public IActionResult Evening()
        {
            ViewBag.Message = "¡Buenas noches desde la Vista!";
            return View("Home"); // Reusa la misma vista
        }
    }
}
