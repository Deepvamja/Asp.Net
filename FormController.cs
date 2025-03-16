using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
    }
}
