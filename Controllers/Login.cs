using Microsoft.AspNetCore.Mvc;
using Staj_Projesi_1.Models.Classes;

namespace Staj_Projesi_1.Controllers
{
    public class Login : Controller
    {

		private readonly Context _context;

		public Login(Context context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult popup1 ()
        {
            return PartialView();
        }


		[HttpPost]
		[ValidateAntiForgeryToken]
		public PartialViewResult popup1 (Currents c)
		{
			_context.Currentss.Add(c);

			_context.SaveChanges();	

			return PartialView(c);
		}
	}
}
