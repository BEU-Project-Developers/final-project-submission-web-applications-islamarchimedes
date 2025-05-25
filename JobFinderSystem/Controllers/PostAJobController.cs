using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class PostAJobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
