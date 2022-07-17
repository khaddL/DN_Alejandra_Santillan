using GymManager.AplicationServices.Members;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GymManager.web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMembersAppServices _membersAppServices;

        public HomeController(IMembersAppServices membersAppServices)
        {
            _membersAppServices = membersAppServices;
        }


        public IActionResult Index()
        {
            var members = _membersAppServices.GetMembersAsync();

            return View(members);
        }
    }
}
