using Microsoft.AspNetCore.Mvc;
using Staj_Projesi_1.Models.Classes;

namespace Staj_Projesi_1.Controllers
{
	public class CurrentsController : Controller
	{

        private readonly Context _context;

		public CurrentsController(Context context)
		{
			_context = context;
		}

        public IActionResult Index()
		{
            var values = _context.Currentss.Where(i=>i.Condition == true).ToList();

            return View(values);
		}

		[HttpGet]
		public IActionResult NewCurrent()
		{

			return View();
		}
		[HttpPost]
		public IActionResult NewCurrent( Currents c)
		{
			_context.Currentss.Add(c);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult CurrentDelete(int id)
		{
			var crt = _context.Currentss.Find(id);
			crt.Condition = false;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult GetCurrent(int id)
		{

			var current = _context.Currentss.Find(id);
			return View ("GetCurrent",current);


		}

		public IActionResult UpdateCurrent (Currents c)
		{
			var current = _context.Currentss.Find(c.CurrentID);

			current.CurrentName = c.CurrentName;
			current.CurrentSurname = c.CurrentSurname;
			current.CurrentCity = c.CurrentCity;
			current.CurrentMail = c.CurrentMail;
			_context.SaveChanges ();
			return RedirectToAction("Index");

		}

		public IActionResult CurrentInfo(int id)
		{
			var value = _context.SalesActions.Where(x => x.CurrentID == id).ToList();

			var buyer = _context.Currentss.Where(x => x.CurrentID == id).Select(y => y.CurrentName + " " + y.CurrentSurname).FirstOrDefault();

			ViewBag.buyer = buyer;

			return View(value);


		}

	}
}
