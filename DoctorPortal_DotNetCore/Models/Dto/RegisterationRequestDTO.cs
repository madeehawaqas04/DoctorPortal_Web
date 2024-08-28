using System.ComponentModel.DataAnnotations;

namespace DoctorPortal_DotNetCore.Models.Dto
{
    public class RegisterationRequestDTO
    {
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string UserName { get; set; } = "";

		[Required]
		public string PhoneNumber { get; set; } = "";

		[Required]
		public string Password { get; set; } = "";

	}
}
