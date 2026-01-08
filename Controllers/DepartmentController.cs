using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Staj_Projesi_1.Models.Classes;

namespace Staj_Projesi_1.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly Context _context;

        public DepartmentController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var values = _context.Departments.Where(x => x.Condition == true).ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddDepartment()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(Department c)
        {
            _context.Departments.Add(c);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteDepartment(int id)
        {
            var dep = _context.Departments.Find(id);
            dep.Condition = false;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateDepartment(int id)
        {

            var dep = _context.Departments.Find(id);

            return View("UpdateDepartment",dep);
        }

        public IActionResult UppdateDepartment(Department D)
        {

            var dept = _context.Departments.Find( D.DepartmentID);
            dept.DepartmentName = D.DepartmentName;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DepartmentInfo(int id)
        {
         
            var value = _context.Employees.Where(x=>x.DepartmentID == id).ToList();
            var dpt = _context.Departments.Where(x=>x.DepartmentID==id).Select(y=>y.DepartmentName).FirstOrDefault();
            ViewBag.d = dpt; 
            return View(value);
         
        }

        public IActionResult DepartmentEmployeeSale(int id)
        {

            var value = _context.SalesActions.Include(e=>e.Employee).Include(p=>p.Products).Where(x =>x.EmployeeID == id).ToList();
            var per = _context.Employees.Where(x =>x.EmployeeID == id).Select(y=>y.EmployeeName + y.EmployeeSurname).FirstOrDefault();
            ViewBag.per = per;
            return View(value);


        }
    }
}
