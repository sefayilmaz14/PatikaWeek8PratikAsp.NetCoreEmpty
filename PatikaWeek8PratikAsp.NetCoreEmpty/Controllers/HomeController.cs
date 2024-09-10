using Microsoft.AspNetCore.Mvc;

namespace PatikaWeek8PratikAsp.NetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
