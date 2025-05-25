using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
