using Microsoft.AspNetCore.Mvc;

namespace estateagency.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
