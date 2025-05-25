using Microsoft.AspNetCore.Mvc;

namespace JobFinderSystem.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
