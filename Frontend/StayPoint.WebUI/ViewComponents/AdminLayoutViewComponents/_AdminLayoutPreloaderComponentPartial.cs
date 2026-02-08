using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutPreloaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
