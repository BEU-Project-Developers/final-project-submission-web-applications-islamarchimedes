using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
