using System.ComponentModel.DataAnnotations;

namespace CarRental.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 nad 8 characters")]
        public string Password { get; set; }
    }
}