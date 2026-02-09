using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.BookingViewComponents
{
    public class _BookingCoverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
