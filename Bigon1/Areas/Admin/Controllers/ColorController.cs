using Bigon1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bigon1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorController : Controller
    {
        private readonly DataContext db;

        public ColorController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
