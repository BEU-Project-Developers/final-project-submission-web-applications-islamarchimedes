using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class SingleJobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
