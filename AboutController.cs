using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
