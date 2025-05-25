using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
