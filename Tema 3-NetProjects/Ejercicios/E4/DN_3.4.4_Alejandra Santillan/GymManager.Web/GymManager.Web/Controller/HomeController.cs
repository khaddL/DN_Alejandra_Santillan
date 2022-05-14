using GymManager.ApplicationServices.Membership;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GymManager.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMembershipAppServices _membershipAppServices;

        public HomeController(IMembershipAppServices membershipAppServices)
        {
            _membershipAppServices = membershipAppServices;

        }

        public IActionResult Index()
        {
            var typ = _membershipAppServices.GetTypes();
            return View(typ);
            
        }
    }
}
