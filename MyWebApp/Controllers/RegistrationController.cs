using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
	public class RegistrationController : Controller
	{
		private readonly ILogger<RegistrationController> _logger;
		public RegistrationController(ILogger<RegistrationController> logger)
		{
			_logger = logger;
		}

		// GET:
		[HttpGet]
		public IActionResult Register()
		{
			return View(new RegisterModel());
		}

		// POST:
		[HttpPost]
		public IActionResult Register(RegisterModel model)
		{
			if (ModelState.IsValid)
			{
				var hasher = new PasswordHasher<RegisterModel>();
				var hashedPassword = hasher.HashPassword(model, model.Password);

				var user = new User
				{
					Username = model.Username,
					Email = model.Email,
					PasswordHash = hashedPassword
				};
				_logger.LogInformation($"New user: {System.Text.Json.JsonSerializer.Serialize(user)}");
				return RedirectToAction("Index", "Home");
			}
			else
			{
				_logger.LogInformation("Model invalid: Registration failed.");
				return View(model);
			}
		  }
	}
}
