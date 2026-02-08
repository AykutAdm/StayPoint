using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutNavHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
