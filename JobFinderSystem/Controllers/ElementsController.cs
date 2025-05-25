using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class ElementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
