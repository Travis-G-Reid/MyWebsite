using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
	public class RegisterModel
	{
		[Required]
		[StringLength(100, MinimumLength = 3)]
		public string Username { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}
