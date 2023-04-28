using Microsoft.AspNetCore.Mvc;

namespace Group2Week11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
