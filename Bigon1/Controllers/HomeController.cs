using Bigon1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bigon1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
