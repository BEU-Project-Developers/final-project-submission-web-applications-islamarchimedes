using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
