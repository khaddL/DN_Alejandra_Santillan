using GymManager.ApplicationServices.Membership;
using GymManager.Core.Membership;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipAppServices _membershipAppServices;
        public MembershipTypesController(IMembershipAppServices membershipAppServices) 
        {
            _membershipAppServices = membershipAppServices;
        
        }

       
        public IActionResult Index()
        {
            List<Types> types = _membershipAppServices.GetTypes();
            return View();
            
        }
    }
}
