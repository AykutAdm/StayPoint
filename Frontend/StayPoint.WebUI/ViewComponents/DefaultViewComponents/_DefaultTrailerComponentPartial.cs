using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultTrailerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
