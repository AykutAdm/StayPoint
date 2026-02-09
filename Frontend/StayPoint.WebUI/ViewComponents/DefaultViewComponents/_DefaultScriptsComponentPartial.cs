using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
