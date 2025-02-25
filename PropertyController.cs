using Microsoft.AspNetCore.Mvc;

namespace estateagency.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Property()
        {
            return View();
        }
    }
}
