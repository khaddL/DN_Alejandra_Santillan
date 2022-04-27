using GymManager.ApplicationServices.Membership;
using GymManager.Core.Membership;
using GymManager.Web.Models;
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
            MembershipListViewModel shiplist = new MembershipListViewModel();
            shiplist.Type = types;
            return View(shiplist);
            
        }

        public IActionResult Create()
        {
          

            return View();

        }
        public IActionResult Exit()
        {


            return RedirectToAction("Index");

        }

        public IActionResult Delete(int Membership)
        {


            _membershipAppServices.RemoveMembership(Membership);
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int Membership)
        {
            Types types = _membershipAppServices.GetMembership(Membership);
            
            return View(types);

        }


        [HttpPost]
        public IActionResult Create(Types types)
        {
            _membershipAppServices.AddMembership(types);

            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Edit(Types types)
        {
            _membershipAppServices.EditMembership(types);

            return RedirectToAction("Index");

        }


    }
}
