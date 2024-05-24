using Microsoft.AspNetCore.Mvc;

namespace Bigon1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
