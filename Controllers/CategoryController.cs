using Microsoft.AspNetCore.Mvc;
using Staj_Projesi_1.Models.Classes;

namespace Staj_Projesi_1.Controllers
{
    public class CategoryController : Controller
    {

        private readonly Context _context;

        public CategoryController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Categorys.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()   
        {
        
            return View();
        
        }

        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            _context.Categorys.Add(c);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteCategory(int id)
        {
            var ctg = _context.Categorys.Find(id);
            _context.Categorys.Remove(ctg);
            _context.SaveChanges();
            return RedirectToAction("Index");
                
        }

        public IActionResult CategoryU(int id)
        {

            var ctgr = _context.Categorys.Find(id);
            return View("CategoryU",ctgr);


        }

        public IActionResult CategoryUpdate(Category c)
        {

            var ctgrr = _context.Categorys.Find(c.CategoryID);
            ctgrr.CategoryName = c.CategoryName;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
