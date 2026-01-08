using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Staj_Projesi_1.Models.Classes;


namespace Staj_Projesi_1.Controllers
{
    public class ProductController : Controller
    {

        private readonly Context _context;
        public ProductController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Productss.Include(x => x.Category).Where(x => x.Condition == true).ToList();

            return View(products);
        }

        [HttpGet]
        public IActionResult NewProduct()
        {
            List<SelectListItem> value1 = (from x in _context.Categorys.ToList() select new SelectListItem 
                                                                                           { 
                                                                                               Text= x.CategoryName,
                                                                                               Value= x.CategoryID.ToString()
                                                                                           } ).ToList();

            ViewBag.Vlu1 = value1;

            return View();
        }

        [HttpPost]
        public IActionResult NewProduct(Products p)
        {

            var category = _context.Categorys.FirstOrDefault(x => x.CategoryID == p.Category.CategoryID);
            p.Category = category;

            _context.Productss.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int p)
        {
            var value = _context.Productss.Find(p);

            if (value == null)
            {
                return NotFound(); // Ürün bulunamazsa 404 hata sayfasına yönlendirme
            }

            value.Condition = false;
         
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
