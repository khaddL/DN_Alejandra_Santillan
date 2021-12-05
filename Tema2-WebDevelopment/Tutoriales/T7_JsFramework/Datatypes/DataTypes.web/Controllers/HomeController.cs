using Microsoft.AspNetCore.Mvc;

namespace DataTypes.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
