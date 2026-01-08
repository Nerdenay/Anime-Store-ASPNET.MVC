using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Staj_Projesi_1.Models.Classes;
namespace Staj_Projesi_1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Context _context;

        public EmployeeController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var values = _context.Employees.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            List<SelectListItem> value1 = ( from x in _context.Departments.ToList() select new SelectListItem 
                                            {  Text = x.DepartmentName, Value = x.DepartmentID.ToString() }).ToList();
                            ViewBag.d = value1; 

            return View();           
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee c)
        {
            
                _context.Employees.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Index");                     
        }

        public IActionResult GetEmployee(int e) 
        {
            var value = _context.Employees.Find(e);


            return View("GetEmployee",value);
        }

        public IActionResult UpdateEmployee(int id)
        {
            var dep = _context.Employees.Find(id);

            return View("UpdateEmployee", dep);
        }
        public IActionResult UppdateEmployee(Employee e)
        {

            var emp = _context.Employees.Find(e);
            emp.EmployeeName = e.EmployeeName;
            emp.EmployeeSurname = e.EmployeeSurname;
            emp.EmployeePic = e.EmployeePic; 
            emp.DepartmentID = e.DepartmentID;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }        

        public IActionResult PersonelGalery()
        {
            var query = _context.Employees.Include(e=>e.Department).ToList();  // Eager Loading 

            return View(query); 

        }
    }
}
