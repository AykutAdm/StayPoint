using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.DashboardViewComponents
{
    public class _DashboardHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
