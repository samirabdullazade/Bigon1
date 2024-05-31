using Bigon1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bigon1.Controllers
{
    public class CategoryCrudController : Controller
    {
        private readonly DataContext _context;

        public CategoryCrudController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var datas = _context.Categories.ToList();
            return View(datas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");//nameof(Index)

        }
        [HttpGet]
        public IActionResult Edit(Guid id) 
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category) 
        {
            var categoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            categoryDB.Name = category.Name;
            categoryDB.Description = category.Description;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(Guid id) 
        {
            var data = _context.Categories.FirstOrDefault(x => x.Id == id);
            if(data == null)
            {
                return BadRequest();
            }

            _context.Categories.Remove(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        
        }

    }
}
