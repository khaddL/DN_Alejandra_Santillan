using Microsoft.AspNetCore.Mvc;

namespace GymManager.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
