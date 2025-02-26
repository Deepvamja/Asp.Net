using Microsoft.AspNetCore.Mvc;

namespace estateagency.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
