using Microsoft.AspNetCore.Mvc;

namespace estateagency.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
