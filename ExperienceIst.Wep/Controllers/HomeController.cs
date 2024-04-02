using Microsoft.AspNetCore.Mvc;

namespace ExperienceIst.Wep.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MakeRequest()
        {
            return View();
        }
    }
}
