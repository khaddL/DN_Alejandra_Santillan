using GymManager.AplicationServices.Members;
using GymManager.Core.Members;
using GymManager.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.web.Controllers
{
    public class MembersController : Controller
    {

        private readonly IMembersAppServices _membersAppServices;

        public MembersController(IMembersAppServices membersAppServices)
        {
            _membersAppServices = membersAppServices;
        }



        public IActionResult Index()
        {
            List<Member> members = _membersAppServices.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;
            return View(viewModel);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
           _membersAppServices.AddMember(member);

            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
