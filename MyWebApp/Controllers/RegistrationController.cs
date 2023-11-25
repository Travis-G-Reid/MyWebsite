using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
	public class RegistrationController : Controller
	{
		// GET: /Account/Register
		public IActionResult Index()
		{
			return View();
		}

		// POST: /Account/Register
		[HttpPost]
		public IActionResult Register(string username, string password, string email)
		{
			// Your registration logic here

			// After successful registration
			return RedirectToAction("Index", "Home");
		}
	}
}
