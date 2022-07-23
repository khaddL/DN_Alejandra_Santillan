using GymManager.AplicationServices.Navigation;
using GymManager.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GymManager.web.Views.Shared.Components.AppMenu
{
    public class AppMenuViewComponent : ViewComponent
    {
        private readonly IMenuAppService _menuAppService;

        public AppMenuViewComponent(IMenuAppService menuAppService)
        { 
            _menuAppService = menuAppService;
        
        }

        public async Task<IViewComponentResult> InvokeAsync(string currentPageName = null)
        {
            var model = new MenuViewModel
            {
                CurrentPageName = currentPageName,
                Menu = _menuAppService.GetMenus()

            };
            return View("Default" , model);
        
        }


    }
}
