using Microsoft.AspNetCore.Mvc;
using Staj_Projesi_1.Models.Classes;

namespace Staj_Projesi_1.Controllers
{
	public class Pictures : Controller
	{

		private readonly Context _context;

		public Pictures ( Context context)
		{
			_context = context;
		}

		public IActionResult Index()
		{

			var values = _context.Productss.ToList();

			return View(values);

		}





	}
}
