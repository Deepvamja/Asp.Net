using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult employee()
        {
            return View();
        }
    }
}
