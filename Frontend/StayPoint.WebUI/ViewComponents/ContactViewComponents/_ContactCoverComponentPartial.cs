using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.ViewComponents.ContactViewComponents
{
    public class _ContactCoverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
