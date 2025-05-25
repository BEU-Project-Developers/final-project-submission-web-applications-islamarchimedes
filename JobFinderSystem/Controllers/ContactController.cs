using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
