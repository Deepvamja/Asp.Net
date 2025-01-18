using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ordertrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
