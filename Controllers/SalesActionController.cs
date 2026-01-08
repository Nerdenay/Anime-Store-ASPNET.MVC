using Microsoft.AspNetCore.Mvc;
using Staj_Projesi_1.Models.Classes;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Staj_Projesi_1.Controllers
{
	public class SalesActionController : Controller
	{
		private readonly Context _context;

		public SalesActionController(Context context)
		{
			_context = context;
		}

		public IActionResult Index()
		{

			var values = _context.SalesActions.ToList();
			return View(values);

		}

		[HttpGet]
		public IActionResult NewSale()
		{

			return View();

		}

		[HttpPost]
        public IActionResult NewSale(SalesAction s )
        {
			_context.SalesActions.Add( s );
			_context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
