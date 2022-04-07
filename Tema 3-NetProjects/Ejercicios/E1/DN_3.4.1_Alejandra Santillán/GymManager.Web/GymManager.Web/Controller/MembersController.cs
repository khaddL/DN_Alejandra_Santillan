using Microsoft.AspNetCore.Mvc;
using System;

namespace GymManager.Web.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
