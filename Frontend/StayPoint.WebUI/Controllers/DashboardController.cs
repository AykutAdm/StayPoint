using Microsoft.AspNetCore.Mvc;

namespace StayPoint.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
