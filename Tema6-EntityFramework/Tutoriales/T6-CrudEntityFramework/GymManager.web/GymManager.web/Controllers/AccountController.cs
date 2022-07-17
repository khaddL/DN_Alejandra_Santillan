using GymManager.web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        { 
            _userManager = userManager;
            _signInManager = signInManager;

            if (!_userManager.Users.Any())
            {
               var result = _userManager.CreateAsync(new IdentityUser {Email = "aly.san.0397@gmail.com",
                EmailConfirmed= true,
                UserName = "aly.san.0397@gmail.com"
               }, "1234").Result;
            }
        
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            string returnUrl = string.IsNullOrEmpty(Request.Query["returnUrl"]) ? Url.Content("~/") : Request.Query["returnUrl"];

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                { 
                    return LocalRedirect(returnUrl);
                
                }
                if (result.IsLockedOut)
                {
                    return RedirectToPage("./Lockout");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt. ");
                    return View();
                }
            
            }


            return View();
        }
    }
}
