using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.DashboardViewComponents
{
    public class _DashboardScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
