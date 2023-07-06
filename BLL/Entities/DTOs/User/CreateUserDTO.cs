using System.ComponentModel.DataAnnotations;

namespace BLL.Entities.DTOs.User
{
    public class CreateUserDTO
    {
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required] 
        public string Lastname { get;set; }


        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$")]
        public string Password { get; set; }

        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
    }
}
