using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultSpinnerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
