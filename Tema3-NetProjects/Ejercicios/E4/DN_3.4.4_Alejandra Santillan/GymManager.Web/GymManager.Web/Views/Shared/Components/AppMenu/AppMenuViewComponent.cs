using GymManager.ApplicationServices.Navigation;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GymManager.Web.Views.Shared.Components.AppMenu
{
    public class AppMenuViewComponent : ViewComponent
    {
        private readonly IMenuAppService _appService;
        public AppMenuViewComponent(IMenuAppService menuAppService)
        {
            _appService = menuAppService;

        }

        public async Task<IViewComponentResult> InvokeAsync(string currentPageName = null)
        {
            var model = new MenuViewModel
            {
                CurrentPageName = currentPageName,
                Menu = _appService.GetMenu()
            };

            return View("Default", model);
        }
    }
}
