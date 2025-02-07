using Microsoft.AspNetCore.Mvc;

namespace area.Areas.area.Controllers
{
    [Area("Areas")]
    public class countryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
