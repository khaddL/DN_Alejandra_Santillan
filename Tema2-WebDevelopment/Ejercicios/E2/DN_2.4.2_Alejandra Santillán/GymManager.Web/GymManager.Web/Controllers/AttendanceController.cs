using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult MemberIn()
        {
            return View();
        }

        public IActionResult MemberOut()
        {
            return View();
        }
    }
}
